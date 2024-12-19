using System.Windows.Forms;

namespace Hospital
{
    partial class AddMedicalRecordForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxPatients;
        private TextBox textBoxStatus;
        private TextBox textBoxNotes;
        private Button btnSave;
        private Button btnCancel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicalRecordForm));
            this.comboBoxPatients = new System.Windows.Forms.ComboBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPatients
            // 
            this.comboBoxPatients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPatients.Location = new System.Drawing.Point(20, 20);
            this.comboBoxPatients.Name = "comboBoxPatients";
            this.comboBoxPatients.Size = new System.Drawing.Size(300, 24);
            this.comboBoxPatients.TabIndex = 0;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(20, 60);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(300, 22);
            this.textBoxStatus.TabIndex = 1;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(20, 100);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(300, 22);
            this.textBoxNotes.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Зберегти";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddMedicalRecordForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.comboBoxPatients);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMedicalRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати запис";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
