using System;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Prompt : Form
    {

        public Prompt()
        {
            InitializeComponent();
        }

        public string HealthStatus
        {
            get => textBoxHealthStatus.Text;
            set => textBoxHealthStatus.Text = value;
        }

        public string Notes
        {
            get => textBoxNotes.Text;
            set => textBoxNotes.Text = value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HealthStatus) || string.IsNullOrWhiteSpace(Notes))
            {
                MessageBox.Show("Поля не можуть бути порожніми", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
