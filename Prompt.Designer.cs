using System.Windows.Forms;

namespace Hospital
{
    partial class Prompt
    {
        // Додати елементи для стану здоров'я
        private System.Windows.Forms.Label labelHealthStatus;
        private System.Windows.Forms.TextBox textBoxHealthStatus;

        // Додати елементи для приміток
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxNotes;

        // Кнопки підтвердження і скасування
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        // Ініціалізація компонентів
        private void InitializeComponent()
        {
            this.labelHealthStatus = new System.Windows.Forms.Label();
            this.textBoxHealthStatus = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // labelHealthStatus
            this.labelHealthStatus.Text = "Стан здоров'я:";
            this.labelHealthStatus.Location = new System.Drawing.Point(12, 20);

            // textBoxHealthStatus
            this.textBoxHealthStatus.Location = new System.Drawing.Point(12, 40);
            this.textBoxHealthStatus.Size = new System.Drawing.Size(260, 20);

            // labelNotes
            this.labelNotes.Text = "Примітки:";
            this.labelNotes.Location = new System.Drawing.Point(12, 80);

            // textBoxNotes
            this.textBoxNotes.Location = new System.Drawing.Point(12, 100);
            this.textBoxNotes.Size = new System.Drawing.Size(260, 20);

            // btnOK
            this.btnOK.Text = "OK";
            this.btnOK.Location = new System.Drawing.Point(12, 140);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // btnCancel
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.Location = new System.Drawing.Point(100, 140);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Form
            this.Controls.Add(this.labelHealthStatus);
            this.Controls.Add(this.textBoxHealthStatus);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Text = "Редагувати запис";
        }


    }
}
