using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AppointmentSearchControl : UserControl
    {
        private readonly DatabaseHelper dbHelper;
        private Doctor loggedInDoctor;

        public AppointmentSearchControl(Doctor doctor)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            loggedInDoctor = doctor;

            rbCurrentDate.Checked = true;
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;

            AttachEventHandlers();

            LoadAppointments("Current");

            UpdateRadioButtonColors();
        }

        private void AttachEventHandlers()
        {
            dtpStartDate.ValueChanged += OnDateRangeChanged;
            dtpEndDate.ValueChanged += OnDateRangeChanged;
            dtpSpecificDate.ValueChanged += OnSpecificDateChanged;
        }

        private void OnDateRangeChanged(object sender, EventArgs e)
        {
            if (rbDateRange.Checked && dtpStartDate.Value <= dtpEndDate.Value)
            {
                LoadAppointments("Range");
            }
        }

        private void OnSpecificDateChanged(object sender, EventArgs e)
        {
            if (rbDateSpecific.Checked)
            {
                LoadAppointments("Specific");
            }
        }


        private void LoadAppointments(string dateFilter)
        {
            try
            {
                string query = @"
                SELECT 
                    CONCAT(p.LastName, ' ', p.FirstName) AS 'ФІ пацієнта', 
                    a.AppointmentDate AS 'Дата прийому', 
                    a.Notes AS 'Примітки'
                FROM Appointments a
                INNER JOIN Patients p ON a.PatientID = p.PatientID
                WHERE a.DoctorID = @DoctorID";

                if (dateFilter == "Current")
                {
                    query += " AND DATE(a.AppointmentDate) = CURDATE()";
                }
                else if (dateFilter == "Range" && dtpStartDate.Value <= dtpEndDate.Value)
                {
                    query += " AND DATE(a.AppointmentDate) BETWEEN @StartDate AND @EndDate";
                }
                else if (dateFilter == "Specific")
                {
                    query += " AND DATE(a.AppointmentDate) = @SpecificDate";
                }

                var parameters = new[]
                {
                    dbHelper.CreateParameter("@DoctorID", loggedInDoctor.ID),
                    dbHelper.CreateParameter("@StartDate", dtpStartDate.Value.Date),
                    dbHelper.CreateParameter("@EndDate", dtpEndDate.Value.Date),
                    dbHelper.CreateParameter("@SpecificDate", dtpSpecificDate.Value.Date)
                };

                DataTable appointments = dbHelper.ExecuteQuery(query, parameters);
                dgvAppointments.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні прийомів: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void rbCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCurrentDate.Checked)
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                LoadAppointments("Current");
            }

            UpdateRadioButtonColors();
        }

        private void rbDateRange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDateRange.Checked)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                LoadAppointments("Range");
            }

            UpdateRadioButtonColors();
        }

        private void rbDateSpecific_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDateSpecific.Checked)
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                dtpSpecificDate.Enabled = true;
                LoadAppointments("Specific");
            }

            UpdateRadioButtonColors();
        }

        private void UpdateRadioButtonColors()
        {
            rbCurrentDate.ForeColor = rbCurrentDate.Checked ? Color.Black : Color.Gray;
            rbDateRange.ForeColor = rbDateRange.Checked ? Color.Black : Color.Gray;
            rbDateSpecific.ForeColor = rbDateSpecific.Checked ? Color.Black : Color.Gray;
        }



    }
}
