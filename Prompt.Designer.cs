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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prompt));
            this.labelHealthStatus = new System.Windows.Forms.Label();
            this.textBoxHealthStatus = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHealthStatus
            // 
            this.labelHealthStatus.Location = new System.Drawing.Point(12, 20);
            this.labelHealthStatus.Name = "labelHealthStatus";
            this.labelHealthStatus.Size = new System.Drawing.Size(100, 23);
            this.labelHealthStatus.TabIndex = 0;
            this.labelHealthStatus.Text = "Стан здоров\'я:";
            // 
            // textBoxHealthStatus
            // 
            this.textBoxHealthStatus.Location = new System.Drawing.Point(12, 40);
            this.textBoxHealthStatus.Name = "textBoxHealthStatus";
            this.textBoxHealthStatus.Size = new System.Drawing.Size(260, 22);
            this.textBoxHealthStatus.TabIndex = 1;
            // 
            // labelNotes
            // 
            this.labelNotes.Location = new System.Drawing.Point(12, 80);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(100, 23);
            this.labelNotes.TabIndex = 2;
            this.labelNotes.Text = "Примітки:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(12, 100);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(260, 22);
            this.textBoxNotes.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 140);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Зберегти";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Prompt
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.labelHealthStatus);
            this.Controls.Add(this.textBoxHealthStatus);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагувати запис";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
