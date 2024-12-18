using System.Windows.Forms;

namespace Hospital
{
    partial class AppointmentSearchControl
    {
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl.Font = new System.Drawing.Font("Arial", 16F);
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(1484, 23);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Пошук прийомів";
            // 
            // AppointmentSearchControl
            // 
            this.Controls.Add(this.lbl);
            this.Name = "AppointmentSearchControl";
            this.Size = new System.Drawing.Size(1484, 834);
            this.ResumeLayout(false);

        }

        private Label lbl;
    }
}
