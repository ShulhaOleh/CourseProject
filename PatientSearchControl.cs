using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class PatientSearchControl : UserControl
    {
        private DatabaseHelper dbHelper;
        private int selectedPatientID;


        public PatientSearchControl()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();

            LoadAllPatients();

            Placeholder.SetPlaceholder(txtSearch, "Введіть фамілію або ім'я...");

            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
        }

        private void LoadAllPatients()
        {
            dgvPatients.DataSource = dbHelper.SearchPatients(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadAllPatients();
            }
            else
            {
                UpdateTable(txtSearch.Text);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "Введіть фамілію або ім'я...")
            {
                LoadAllPatients();
            }
            else
            {
                UpdateTable(txtSearch.Text);
            }
        }

        private void UpdateTable(string keyword)
        {
            var patients = dbHelper.SearchPatients(keyword);
            dgvPatients.DataSource = patients;
        }


    }
}
