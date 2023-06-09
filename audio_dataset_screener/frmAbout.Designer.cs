namespace audio_dataset_screener
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAbout = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.linkLabelHuggingFace = new System.Windows.Forms.LinkLabel();
            this.linkLabelBilibili = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.Location = new System.Drawing.Point(84, 11);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(315, 80);
            this.labelAbout.TabIndex = 1;
            this.labelAbout.Text = "Audio Dataset Screener\r\nVersion 1.3.0\r\nby 2DIPW\r\nLicensed under GNU General Publi" +
    "c License v3\r\nOpen source leads the world to a brighter future!";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelGithub.Location = new System.Drawing.Point(85, 106);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(41, 12);
            this.linkLabelGithub.TabIndex = 2;
            this.linkLabelGithub.Text = "GitHub";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(321, 101);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(63, 59);
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // linkLabelHuggingFace
            // 
            this.linkLabelHuggingFace.AutoSize = true;
            this.linkLabelHuggingFace.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelHuggingFace.Location = new System.Drawing.Point(132, 106);
            this.linkLabelHuggingFace.Name = "linkLabelHuggingFace";
            this.linkLabelHuggingFace.Size = new System.Drawing.Size(71, 12);
            this.linkLabelHuggingFace.TabIndex = 2;
            this.linkLabelHuggingFace.Text = "HuggingFace";
            this.linkLabelHuggingFace.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHuggingFace_LinkClicked);
            // 
            // linkLabelBilibili
            // 
            this.linkLabelBilibili.AutoSize = true;
            this.linkLabelBilibili.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelBilibili.Location = new System.Drawing.Point(209, 106);
            this.linkLabelBilibili.Name = "linkLabelBilibili";
            this.linkLabelBilibili.Size = new System.Drawing.Size(53, 12);
            this.linkLabelBilibili.TabIndex = 2;
            this.linkLabelBilibili.Text = "Bilibili";
            this.linkLabelBilibili.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBilibili_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 141);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkLabelBilibili);
            this.Controls.Add(this.linkLabelHuggingFace);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.labelAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.LinkLabel linkLabelHuggingFace;
        private System.Windows.Forms.LinkLabel linkLabelBilibili;
    }
}