﻿using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmMain : Form
    {
        private Doctor loggedInDoctor;
        private PatientSearchControl patientSearchControl;


        public frmMain(Doctor doctor )
        {
            InitializeComponent();
            patientSearchControl = new PatientSearchControl();
            ShowControlInPanel(patientSearchControl);
            this.loggedInDoctor = doctor;
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowControlInPanel(new PatientSearchControl()); // Default subform

            chkRememberMe.Checked = Properties.Settings.Default.RememberMe;
            ShowControlInPanel(new PatientSearchControl());
        }

        // Switching subforms ---
        private void ShowControlInPanel(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }


        private void btnPatientSearch_Click(object sender, EventArgs e)
        {
            ShowControlInPanel(new PatientSearchControl());
        }

        private void btnAppointmentSearch_Click(object sender, EventArgs e)
        {
            AppointmentSearchControl appointmentSearchControl = new AppointmentSearchControl(loggedInDoctor);
            ShowControlInPanel(appointmentSearchControl);
        }


        private void btnMedicalCard_Click(object sender, EventArgs e)
        {
            ShowControlInPanel(new MedicalCardControl());
        }

        // ---

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedInDoctor = null;

            this.Hide();

            using (var loginForm = new frmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    var newMainForm = new frmMain(loginForm.LoggedInDoctor);
                    newMainForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }




        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RememberMe = chkRememberMe.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ShowControlInPanel(new ProfileControl(loggedInDoctor));
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Properties.Settings.Default.RememberMe)
            {
                Properties.Settings.Default.SavedUsername = string.Empty;
                Properties.Settings.Default.SavedPassword = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

    }
}

