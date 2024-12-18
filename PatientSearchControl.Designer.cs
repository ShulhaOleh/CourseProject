using System.Windows.Forms;

namespace Hospital
{
    partial class PatientSearchControl
    {
        private Label lblTitle;
        private TextBox txtSearch;
        private DataGridView dgvPatients;
        private TableLayoutPanel tableLayoutPanel;

        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.txtSearch, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dgvPatients, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1484, 834);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(13, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1458, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Каталог пацієнтів";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearch.Location = new System.Drawing.Point(10, 65);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1464, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPatients.ColumnHeadersHeight = 29;
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(13, 103);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            this.dgvPatients.Size = new System.Drawing.Size(1458, 718);
            this.dgvPatients.TabIndex = 2;
            // 
            // PatientSearchControl
            // 
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "PatientSearchControl";
            this.Size = new System.Drawing.Size(1484, 834);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
