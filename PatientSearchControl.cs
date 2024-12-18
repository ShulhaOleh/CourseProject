using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class PatientSearchControl : UserControl
    {
        private DatabaseHelper dbHelper;

        public PatientSearchControl()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadAllPatients();
        }

        private void LoadAllPatients()
        {
            dgvPatients.DataSource = dbHelper.SearchPatients(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            dgvPatients.DataSource = dbHelper.SearchPatients(keyword);
        }
    }
}
