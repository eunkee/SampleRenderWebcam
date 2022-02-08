
namespace SampleRenderWebcam
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonOCRSettingWebcam = new System.Windows.Forms.Button();
            this.LabelConnectStatus = new System.Windows.Forms.Label();
            this.CheckBoxVideoIndexReverse = new System.Windows.Forms.CheckBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCam = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.BackColor = System.Drawing.Color.Gray;
            this.ButtonDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonDisconnect.FlatAppearance.BorderSize = 0;
            this.ButtonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(83)))), ((int)(((byte)(65)))));
            this.ButtonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDisconnect.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.25F, System.Drawing.FontStyle.Bold);
            this.ButtonDisconnect.ForeColor = System.Drawing.Color.White;
            this.ButtonDisconnect.Location = new System.Drawing.Point(684, 274);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(142, 88);
            this.ButtonDisconnect.TabIndex = 247;
            this.ButtonDisconnect.Text = "해제";
            this.ButtonDisconnect.UseVisualStyleBackColor = false;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonConnect.FlatAppearance.BorderSize = 0;
            this.ButtonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConnect.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.25F, System.Drawing.FontStyle.Bold);
            this.ButtonConnect.ForeColor = System.Drawing.Color.White;
            this.ButtonConnect.Location = new System.Drawing.Point(684, 165);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(142, 88);
            this.ButtonConnect.TabIndex = 246;
            this.ButtonConnect.Text = "연결";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonOCRSettingWebcam
            // 
            this.ButtonOCRSettingWebcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonOCRSettingWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonOCRSettingWebcam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonOCRSettingWebcam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonOCRSettingWebcam.FlatAppearance.BorderSize = 0;
            this.ButtonOCRSettingWebcam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonOCRSettingWebcam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonOCRSettingWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOCRSettingWebcam.Font = new System.Drawing.Font("나눔스퀘어 Bold", 15.25F, System.Drawing.FontStyle.Bold);
            this.ButtonOCRSettingWebcam.ForeColor = System.Drawing.Color.White;
            this.ButtonOCRSettingWebcam.Location = new System.Drawing.Point(684, 378);
            this.ButtonOCRSettingWebcam.Name = "ButtonOCRSettingWebcam";
            this.ButtonOCRSettingWebcam.Size = new System.Drawing.Size(142, 88);
            this.ButtonOCRSettingWebcam.TabIndex = 245;
            this.ButtonOCRSettingWebcam.Text = "캠 설정창";
            this.ButtonOCRSettingWebcam.UseVisualStyleBackColor = false;
            this.ButtonOCRSettingWebcam.Click += new System.EventHandler(this.ButtonOCRSettingWebcam_Click);
            // 
            // LabelConnectStatus
            // 
            this.LabelConnectStatus.BackColor = System.Drawing.Color.IndianRed;
            this.LabelConnectStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelConnectStatus.Font = new System.Drawing.Font("나눔스퀘어", 14.25F);
            this.LabelConnectStatus.ForeColor = System.Drawing.Color.White;
            this.LabelConnectStatus.Location = new System.Drawing.Point(704, 51);
            this.LabelConnectStatus.Name = "LabelConnectStatus";
            this.LabelConnectStatus.Size = new System.Drawing.Size(102, 37);
            this.LabelConnectStatus.TabIndex = 250;
            this.LabelConnectStatus.Text = "연결 상태";
            this.LabelConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxVideoIndexReverse
            // 
            this.CheckBoxVideoIndexReverse.AutoSize = true;
            this.CheckBoxVideoIndexReverse.Font = new System.Drawing.Font("나눔스퀘어", 14.25F);
            this.CheckBoxVideoIndexReverse.ForeColor = System.Drawing.Color.Black;
            this.CheckBoxVideoIndexReverse.Location = new System.Drawing.Point(684, 134);
            this.CheckBoxVideoIndexReverse.Name = "CheckBoxVideoIndexReverse";
            this.CheckBoxVideoIndexReverse.Size = new System.Drawing.Size(131, 25);
            this.CheckBoxVideoIndexReverse.TabIndex = 249;
            this.CheckBoxVideoIndexReverse.Text = "화면순서변경";
            this.CheckBoxVideoIndexReverse.UseVisualStyleBackColor = true;
            this.CheckBoxVideoIndexReverse.CheckedChanged += new System.EventHandler(this.CheckBoxVideoIndexReverse_CheckedChanged);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelMain.Controls.Add(this.panelCam);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(640, 524);
            this.panelMain.TabIndex = 251;
            // 
            // panelCam
            // 
            this.panelCam.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCam.Location = new System.Drawing.Point(0, 0);
            this.panelCam.Name = "panelCam";
            this.panelCam.Size = new System.Drawing.Size(640, 524);
            this.panelCam.TabIndex = 4;
            this.panelCam.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 524);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.LabelConnectStatus);
            this.Controls.Add(this.CheckBoxVideoIndexReverse);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ButtonOCRSettingWebcam);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sample Render Webcam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonOCRSettingWebcam;
        private System.Windows.Forms.Label LabelConnectStatus;
        private System.Windows.Forms.CheckBox CheckBoxVideoIndexReverse;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCam;
    }
}

