using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleRenderWebcam
{
    public partial class Form1 : Form
    {
        UserControlCam userControlCam;


        private int _camIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public int CamIndex
        {
            get
            {
                return _camIndex;
            }
            set
            {
                _camIndex = value;
            }
        }

        public bool IsPlayCam
        {
            get
            {
                return panelCam.Visible;
            }
            set
            {
                if (value)
                {
                    LabelConnectStatus.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    //238, 83, 65
                    LabelConnectStatus.BackColor = Color.IndianRed;
                }

                SetPanalCamStatus(value);
            }
        }


        private delegate void CrossThreadSafetyOCRText(bool isVisble);

        public void SetPanalCamStatus(bool isVisble)
        {
            if (panelCam != null)
            {
                if (panelCam.InvokeRequired)
                {
                    try
                    {
                        if (panelCam != null)
                        {
                            panelCam.Invoke(new CrossThreadSafetyOCRText(SetPanalCamStatus), isVisble);
                        }
                    }
                    finally { }
                }
                else
                {
                    try
                    {
                        panelCam.Visible = isVisble;
                    }
                    finally { }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControlCam = new UserControlCam(this);
            panelCam.Controls.Add(userControlCam);
        }

        private void CheckBoxVideoIndexReverse_CheckedChanged(object sender, EventArgs e)
        {
            int isOldWebCamIndex = _camIndex;
            int isCurrentWebCamIndex = CheckBoxVideoIndexReverse.Checked ? 0 : 1;
            if (isCurrentWebCamIndex != isOldWebCamIndex)
            {
                _camIndex = isCurrentWebCamIndex;

                if (userControlCam != null)
                {
                    userControlCam.ReconnectCam();
                }
            }
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            if (userControlCam != null)
            {
                userControlCam.ConnectCam();
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            if (userControlCam != null)
            {
                userControlCam.DisconnectCam();
            }
        }

        private void ButtonOCRSettingWebcam_Click(object sender, EventArgs e)
        {
            if (userControlCam != null)
            {
                userControlCam.SettingWebCam();
            }
        }
    }
}
