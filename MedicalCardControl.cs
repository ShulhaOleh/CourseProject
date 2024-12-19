using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hospital 
{
    public partial class MedicalCardControl : UserControl
    {
        private DatabaseHelper dbHelper;

        
        public MedicalCardControl()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();

            Placeholder.SetPlaceholder(txtSearch, "Введіть фамілію або ім'я...");

            LoadAllMedicalRecords();

            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Leave += txtSearch_Leave;
        }

        private void LoadAllMedicalRecords(string search = "")
        {

            string query =
            "SELECT m.RecordID AS 'ID примітки', " +
            "CONCAT(p.LastName, ' ', p.FirstName) AS 'ФІ пацієнта', " +
            "a.EntryDate AS 'Дата запису', " +
            "m.HealthStatus AS 'Статус здоров''я', m.Notes AS 'Примітка' " +
            "FROM MedicalRecords m " +
            "JOIN AmbulatoryCards a ON m.AmbulatoryCardID = a.AmbulatoryCardID " +
            "JOIN Patients p ON a.PatientID = p.PatientID";


            DataTable records = dbHelper.ExecuteQuery(query);
            dgvMedicalCards.DataSource = records;
        }


        private void UpdateTable(string keyword)
        {
            var records = dbHelper.SearchMedicalCards(keyword);
            dgvMedicalCards.DataSource = records;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadAllMedicalRecords();
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
                LoadAllMedicalRecords();
            }
            else
            {
                UpdateTable(txtSearch.Text);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedicalCards.SelectedRows.Count > 0)
            {
                int recordID = Convert.ToInt32(dgvMedicalCards.SelectedRows[0].Cells["ID примітки"].Value);
                string currentHealthStatus = dgvMedicalCards.SelectedRows[0].Cells["Статус здоров'я"].Value.ToString();
                string currentNotes = dgvMedicalCards.SelectedRows[0].Cells["Примітка"].Value.ToString();

                using (var promptForm = new Prompt())
                {
                    promptForm.HealthStatus = currentHealthStatus;
                    promptForm.Notes = currentNotes;

                    if (promptForm.ShowDialog() == DialogResult.OK)
                    {
                        string newHealthStatus = promptForm.HealthStatus;
                        string newNotes = promptForm.Notes;

                        dbHelper.UpdateMedicalRecord(recordID, newHealthStatus, newNotes);
                        LoadAllMedicalRecords(txtSearch.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть запис для редагування", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedicalCards.SelectedRows.Count > 0)
            {
                // Отримуємо RecordID із вибраного рядка
                int recordID = Convert.ToInt32(dgvMedicalCards.SelectedRows[0].Cells["ID примітки"].Value);

                try
                {
                    dbHelper.DeleteMedicalRecord(recordID);
                    LoadAllMedicalRecords(); // Оновлення таблиці
                    MessageBox.Show("Запис успішно видалено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час видалення: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть запис для видалення.");
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AddMedicalRecordForm(dbHelper))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.SelectedPatientID.HasValue)
                    {
                        dbHelper.AddMedicalRecord(
                            form.SelectedPatientID.Value,
                            form.HealthStatus,
                            form.Notes,
                            DateTime.Now);
                        LoadAllMedicalRecords(txtSearch.Text);
                        MessageBox.Show("Запис успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }





    }
}
