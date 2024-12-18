using System;
using System.Data;
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
            
            DataTable records;

            if (string.IsNullOrEmpty(search))
            {
                records = dbHelper.GetAllMedicalCards();
            }
            else
            {
                records = dbHelper.SearchMedicalCards(search);
            }

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
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "Введіть критерій пошуку...")
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
                int recordID = Convert.ToInt32(dgvMedicalCards.SelectedRows[0].Cells["ID пацієнта"].Value);
                string currentHealthStatus = dgvMedicalCards.SelectedRows[0].Cells["Статус здоров'я"].Value.ToString();
                string currentNotes = dgvMedicalCards.SelectedRows[0].Cells["Примітка"].Value.ToString();

                string newHealthStatus = Prompt.ShowDialog("Редагувати стан здоров'я:", "Редагування", currentHealthStatus);
                string newNotes = Prompt.ShowDialog("Редагувати примітки:", "Редагування", currentNotes);

                if (!string.IsNullOrEmpty(newHealthStatus) && !string.IsNullOrEmpty(newNotes))
                {
                    dbHelper.UpdateMedicalRecord(recordID, newHealthStatus, newNotes);
                    MessageBox.Show("Запис успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllMedicalRecords(); // Оновлюємо таблицю
                }
            }
            else
            {
                MessageBox.Show("Виберіть запис для редагування.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedicalCards.SelectedRows.Count > 0)
            {
                int recordID = Convert.ToInt32(dgvMedicalCards.SelectedRows[0].Cells["ID пацієнта"].Value);

                var result = MessageBox.Show("Ви впевнені, що хочете видалити цей запис?",
                                             "Підтвердження видалення",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dbHelper.DeleteMedicalRecord(recordID);
                    MessageBox.Show("Запис успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllMedicalRecords();
                }
            }
            else
            {
                MessageBox.Show("Виберіть запис для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
