using System.Windows.Forms;

namespace Hospital
{
    partial class MedicalCardControl
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private Label lblTitle;
        private Panel pnlFilter;
        private TextBox txtSearch;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvMedicalCards;

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMedicalCards = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalCards)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.mainLayout.Controls.Add(this.pnlFilter, 0, 1);
            this.mainLayout.Controls.Add(this.dgvMedicalCards, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(800, 600);
            this.mainLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(794, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Амбулаторна картка";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnAdd);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.btnEdit);
            this.pnlFilter.Controls.Add(this.btnDelete);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(3, 53);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFilter.Size = new System.Drawing.Size(794, 74);
            this.pnlFilter.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSearch.Location = new System.Drawing.Point(10, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10F);
            this.btnEdit.Location = new System.Drawing.Point(316, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 25);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10F);
            this.btnDelete.Location = new System.Drawing.Point(422, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvMedicalCards
            // 
            this.dgvMedicalCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicalCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicalCards.Location = new System.Drawing.Point(3, 133);
            this.dgvMedicalCards.Name = "dgvMedicalCards";
            this.dgvMedicalCards.RowHeadersWidth = 51;
            this.dgvMedicalCards.Size = new System.Drawing.Size(794, 464);
            this.dgvMedicalCards.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F);
            this.btnAdd.Location = new System.Drawing.Point(528, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MedicalCardControl
            // 
            this.Controls.Add(this.mainLayout);
            this.Name = "MedicalCardControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.mainLayout.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalCards)).EndInit();
            this.ResumeLayout(false);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);


        }

        private Button btnAdd;
    }
}
