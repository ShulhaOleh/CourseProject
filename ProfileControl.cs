using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class ProfileControl : UserControl
    {
        private Doctor loggedInDoctor;
        public ProfileControl(Doctor doctor)
        {
            InitializeComponent();
            this.loggedInDoctor = doctor;
            DisplayDoctorInfo();
        }

        private void DisplayDoctorInfo()
        {
            lblDoctorInfo.Text = $"Прізвище: {loggedInDoctor.LastName}\n" +
                                 $"Ім'я: {loggedInDoctor.FirstName}\n" +
                                 $"Вік: {CalculateAge(loggedInDoctor.DateOfBirth)}\n" +
                                 $"Спеціальність: {loggedInDoctor.Specialty}";
        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}