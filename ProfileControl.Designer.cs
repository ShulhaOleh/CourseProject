namespace Hospital
{
    partial class ProfileControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        // private System.Windows.Forms.Label lblDoctorInfo;


        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.lblDoctorInfo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(600, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Профіль лікаря";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelBackground.Controls.Add(this.lblDoctorInfo);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 50);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(600, 350);
            this.panelBackground.TabIndex = 0;
            // 
            // lblDoctorInfo
            // 
            this.lblDoctorInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblDoctorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDoctorInfo.Location = new System.Drawing.Point(20, 23);
            this.lblDoctorInfo.Name = "lblDoctorInfo";
            this.lblDoctorInfo.Size = new System.Drawing.Size(360, 210);
            this.lblDoctorInfo.TabIndex = 0;
            this.lblDoctorInfo.Text = "Інформація про лікаря";
            // 
            // ProfileControl
            // 
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelHeader);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.panelHeader.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Label lblDoctorInfo;
    }
}
