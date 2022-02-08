using OpenCvSharp;
using OpenCvSharp.Extensions;
using SharpDX;
using SharpDX.Direct2D1;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleRenderWebcam
{
    public partial class UserControlCam : UserControl
    {
        private readonly Form1 Parentform;
        private Thread camera;

        private readonly BlockingCollection<SharpDX.Direct2D1.Bitmap> _q = new BlockingCollection<SharpDX.Direct2D1.Bitmap>();
        private RenderTarget2D _renderTarget = null;
        private DataStream _bitmapData;
        private VideoCapture _capture = null;

        public UserControlCam(Form1 form1)
        {
            Parentform = form1;
            InitializeComponent();
        }

        ~UserControlCam()
        {
            DisposeThreadRender();
            DisposeVideoCapture();
        }

        public void ClearWarpingPoint()
        {
        }
        
        private void DisposeThreadRender()
        {
            try
            {
                if (_renderTarget != null)
                {
                    _renderTarget.Dispose();
                }
            }
            catch { }
        }

        private void DisposeVideoCapture()
        {
            try
            {
                if (_capture != null)
                {
                    _capture.Release();
                    _capture.Dispose();
                }
            }
            catch { }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //  base.OnPaintBackground(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            while (true)
            {
                if (_q.TryTake(out SharpDX.Direct2D1.Bitmap item) == true)
                {
                    _renderTarget.Render(
                        (renderer) =>
                        {
                            this.Text = _q.Count.ToString();
                            renderer.DrawBitmap(item, 1.0f, BitmapInterpolationMode.Linear);
                        });
                    item.Dispose();
                }
                else
                {
                    break;
                }
            }
        }

        private void CaptureCameraCallback()
        {
            DisposeVideoCapture();

            //캠 인덱스
            int index = Parentform.CamIndex;
            _capture = new VideoCapture(index)
            {
                BufferSize = 1
            };

            if (_capture.IsOpened() == false)
            {
                DisposeThreadRender();
                return;
            }

            _renderTarget = new RenderTarget2D();
            Parentform.IsPlayCam = true;

            this.Invoke((Action)(() =>
            {
                this.Width = _capture.FrameWidth;
                this.Height = _capture.FrameHeight * 2;
                _renderTarget.Initialize(this.Handle, _capture.FrameWidth, _capture.FrameHeight * 2);
            }));

            _bitmapData = new DataStream(_capture.FrameWidth * _capture.FrameHeight * 4 * 2, false, false);

            int expectedProcessTimePerFrame = 1000 / 30; // 30 fps
            Stopwatch st = new Stopwatch();
            st.Start();

            using (Mat image = new Mat())
            {
                while (true)
                {
                    long started = st.ElapsedMilliseconds;

                    _capture.Read(image);
                    if (image.Empty() == true)
                    {
                        DisposeThreadRender();
                        break;
                    }

                    //이미지 수정적용 영역

                    SharpDX.Direct2D1.Bitmap bitmap = ToSharpDXBitmap(image);
                    _q.Add(bitmap);

                    try
                    {
                        this.Invoke((Action)(() => this.Invalidate()));
                    }
                    catch (ObjectDisposedException) { }
                    catch (InvalidOperationException) { }

                    int elapsed = (int)(st.ElapsedMilliseconds - started);
                    int delay = expectedProcessTimePerFrame - elapsed;

                    //Trace.WriteLine($"elapsed: {elapsed}, delay: {delay}");
                        
                    if (delay > 0)
                    {
                        Thread.Sleep(delay);
                    }
                }
            }

            Parentform.IsPlayCam = false;
        }
        private SharpDX.Direct2D1.Bitmap ToSharpDXBitmap(Mat org)
        {
            using (Mat orgData = org.CvtColor(ColorConversionCodes.BGR2BGRA))
            {
                IntPtr dstPtr = _bitmapData.DataPointer;
                Utilities.CopyMemory(dstPtr, orgData.Data, (int)orgData.Total() * orgData.ElemSize());
                return _renderTarget.CreateBitmap(_bitmapData);
            }
        }

        public void ConnectCam()
        {
            bool isNeedConnect = false;

            if (camera != null)
            {
                if (camera.ThreadState != System.Threading.ThreadState.Background)
                {
                    isNeedConnect = true;
                }
            }
            else
            {
                isNeedConnect = true;
            }

            if (isNeedConnect)
            {
                camera = new Thread(new ThreadStart(CaptureCameraCallback))
                {
                    IsBackground = true
                };
                camera.Start();
            }
        }

        public void DisconnectCam()
        {
            camera.Abort();
            Parentform.IsPlayCam = false;
        }

        public void ReconnectCam()
        {
            DisconnectCam();
            var task1 = Task.Run(() => Thread.Sleep(1000));
            task1.ContinueWith(_ =>
            {
                //재귀
                ConnectCam();
            });
        }

        //OCR WebCAM 설정
        public void SettingWebCam()
        {
            if (_capture != null)
            {
                _capture.Set(VideoCaptureProperties.Settings, 1.0);
            }
        }

    }
}