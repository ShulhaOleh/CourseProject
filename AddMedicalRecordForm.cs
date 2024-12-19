using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class AddMedicalRecordForm : Form
    {
        private readonly DatabaseHelper dbHelper;

        public int? SelectedPatientID { get; private set; }
        public string HealthStatus { get; private set; }
        public string Notes { get; private set; }

        public AddMedicalRecordForm(DatabaseHelper dbHelper)
        {
            InitializeComponent();
            this.dbHelper = dbHelper;
            LoadPatients();

            Placeholder.SetPlaceholder(textBoxStatus, "Введіть статус здоров'я...");
            Placeholder.SetPlaceholder(textBoxNotes, "Введіть примітки...");
        }

        private void LoadPatients()
        {
            var patients = dbHelper.GetPatients();
            comboBoxPatients.DataSource = patients;
            comboBoxPatients.DisplayMember = "FullName";
            comboBoxPatients.ValueMember = "PatientID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isStatusEmpty = string.IsNullOrWhiteSpace(textBoxStatus.Text) || textBoxStatus.Text == "Введіть статус здоров'я...";
            bool isNotesEmpty = string.IsNullOrWhiteSpace(textBoxNotes.Text) || textBoxNotes.Text == "Введіть примітки...";

            if (comboBoxPatients.SelectedValue == null || isStatusEmpty || isNotesEmpty)
            {
                MessageBox.Show("Усі поля мають бути заповнені.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SelectedPatientID = (int)comboBoxPatients.SelectedValue;
            HealthStatus = textBoxStatus.Text.Trim();
            Notes = textBoxNotes.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
