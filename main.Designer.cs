using System.Windows.Forms;

namespace Hospital
{
    partial class frmMain
    {
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.Button btnAppointmentSearch;
        private System.Windows.Forms.Button btnMedicalCard;
        private System.Windows.Forms.Panel pnlExitContainer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.CheckBox chkRememberMe;



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMedicalCard = new System.Windows.Forms.Button();
            this.btnAppointmentSearch = new System.Windows.Forms.Button();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.pnlExitContainer = new System.Windows.Forms.Panel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlExitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlSideMenu.Controls.Add(this.btnProfile);
            this.pnlSideMenu.Controls.Add(this.btnMedicalCard);
            this.pnlSideMenu.Controls.Add(this.btnAppointmentSearch);
            this.pnlSideMenu.Controls.Add(this.btnPatientSearch);
            this.pnlSideMenu.Controls.Add(this.pnlExitContainer);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 600);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(20, 158);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(160, 40);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Профіль";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMedicalCard
            // 
            this.btnMedicalCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMedicalCard.FlatAppearance.BorderSize = 0;
            this.btnMedicalCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalCard.ForeColor = System.Drawing.Color.White;
            this.btnMedicalCard.Location = new System.Drawing.Point(20, 112);
            this.btnMedicalCard.Name = "btnMedicalCard";
            this.btnMedicalCard.Size = new System.Drawing.Size(160, 40);
            this.btnMedicalCard.TabIndex = 3;
            this.btnMedicalCard.Text = "Амбулаторні картки";
            this.btnMedicalCard.UseVisualStyleBackColor = false;
            this.btnMedicalCard.Click += new System.EventHandler(this.btnMedicalCard_Click);
            // 
            // btnAppointmentSearch
            // 
            this.btnAppointmentSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAppointmentSearch.FlatAppearance.BorderSize = 0;
            this.btnAppointmentSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentSearch.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentSearch.Location = new System.Drawing.Point(20, 66);
            this.btnAppointmentSearch.Name = "btnAppointmentSearch";
            this.btnAppointmentSearch.Size = new System.Drawing.Size(160, 40);
            this.btnAppointmentSearch.TabIndex = 2;
            this.btnAppointmentSearch.Text = "Пошук прийому";
            this.btnAppointmentSearch.UseVisualStyleBackColor = false;
            this.btnAppointmentSearch.Click += new System.EventHandler(this.btnAppointmentSearch_Click);
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPatientSearch.FlatAppearance.BorderSize = 0;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.ForeColor = System.Drawing.Color.White;
            this.btnPatientSearch.Location = new System.Drawing.Point(20, 20);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(160, 40);
            this.btnPatientSearch.TabIndex = 1;
            this.btnPatientSearch.Text = "Каталог пацієнта";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // pnlExitContainer
            // 
            this.pnlExitContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlExitContainer.Controls.Add(this.chkRememberMe);
            this.pnlExitContainer.Controls.Add(this.btnLogout);
            this.pnlExitContainer.Controls.Add(this.btnExit);
            this.pnlExitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExitContainer.Location = new System.Drawing.Point(0, 452);
            this.pnlExitContainer.Name = "pnlExitContainer";
            this.pnlExitContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlExitContainer.Size = new System.Drawing.Size(200, 148);
            this.pnlExitContainer.TabIndex = 4;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Arial", 10F);
            this.chkRememberMe.ForeColor = System.Drawing.Color.White;
            this.chkRememberMe.Location = new System.Drawing.Point(20, 11);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(168, 23);
            this.chkRememberMe.TabIndex = 0;
            this.chkRememberMe.Text = "Запам\'ятати мене";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            this.chkRememberMe.CheckedChanged += new System.EventHandler(this.chkRememberMe_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(20, 40);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 40);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Розлогінитися";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(20, 88);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(850, 600);
            this.pnlContent.TabIndex = 4;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Система поліклініки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlExitContainer.ResumeLayout(false);
            this.pnlExitContainer.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);



        }

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnExit;
        private Button btnProfile;
    }
}

