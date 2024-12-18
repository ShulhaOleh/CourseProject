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
        private void InitializeComponent()
        {
            this.lblDoctorInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDoctorInfo
            // 
            this.lblDoctorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoctorInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDoctorInfo.Location = new System.Drawing.Point(0, 0);
            this.lblDoctorInfo.Name = "lblDoctorInfo";
            this.lblDoctorInfo.Padding = new System.Windows.Forms.Padding(20);
            this.lblDoctorInfo.Size = new System.Drawing.Size(400, 300);
            this.lblDoctorInfo.TabIndex = 0;
            this.lblDoctorInfo.Text = "\u0406\u043D\u0444\u043E\u0440\u043C\u0430\u0446\u0456\u044F \u043F\u0440\u043E \u043B\u0456\u043A\u0430\u0440\u044F";
            this.lblDoctorInfo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDoctorInfo);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(400, 300);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblDoctorInfo;
    }
}
