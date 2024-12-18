using System.Drawing;
using System.Windows.Forms;

namespace Hospital
{
    partial class AppointmentSearchControl
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvAppointments;
        private RadioButton rbCurrentDate;
        private RadioButton rbDateRange;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TableLayoutPanel mainLayout;
        private Label lblTitle;
        private Panel pnlFilter;
        private RadioButton rbDateSpecific;

        private void InitializeComponent()
        {
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.dtpSpecificDate = new System.Windows.Forms.DateTimePicker();
            this.rbDateSpecific = new System.Windows.Forms.RadioButton();
            this.rbCurrentDate = new System.Windows.Forms.RadioButton();
            this.rbDateRange = new System.Windows.Forms.RadioButton();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.mainLayout.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Controls.Add(this.lblTitle, 0, 0);
            this.mainLayout.Controls.Add(this.pnlFilter, 0, 1);
            this.mainLayout.Controls.Add(this.dgvAppointments, 0, 2);
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
            this.lblTitle.Text = "Пошук прийомів";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFilter.Controls.Add(this.dtpSpecificDate);
            this.pnlFilter.Controls.Add(this.rbDateSpecific);
            this.pnlFilter.Controls.Add(this.rbCurrentDate);
            this.pnlFilter.Controls.Add(this.rbDateRange);
            this.pnlFilter.Controls.Add(this.dtpStartDate);
            this.pnlFilter.Controls.Add(this.dtpEndDate);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(3, 53);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFilter.Size = new System.Drawing.Size(794, 74);
            this.pnlFilter.TabIndex = 1;
            // 
            // dtpSpecificDate
            // 
            this.dtpSpecificDate.Enabled = false;
            this.dtpSpecificDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSpecificDate.Location = new System.Drawing.Point(651, 25);
            this.dtpSpecificDate.Name = "dtpSpecificDate";
            this.dtpSpecificDate.Size = new System.Drawing.Size(111, 22);
            this.dtpSpecificDate.TabIndex = 5;
            this.dtpSpecificDate.Value = new System.DateTime(2024, 12, 18, 0, 0, 0, 0);
            this.dtpSpecificDate.ValueChanged += new System.EventHandler(this.rbDateSpecific_CheckedChanged);
            // 
            // rbDateSpecific
            // 
            this.rbDateSpecific.Location = new System.Drawing.Point(508, 23);
            this.rbDateSpecific.Name = "rbDateSpecific";
            this.rbDateSpecific.Size = new System.Drawing.Size(137, 24);
            this.rbDateSpecific.TabIndex = 4;
            this.rbDateSpecific.Text = "Конкретна дата";
            this.rbDateSpecific.CheckedChanged += new System.EventHandler(this.rbDateSpecific_CheckedChanged);
            // 
            // rbCurrentDate
            // 
            this.rbCurrentDate.Checked = true;
            this.rbCurrentDate.Location = new System.Drawing.Point(8, 25);
            this.rbCurrentDate.Name = "rbCurrentDate";
            this.rbCurrentDate.Size = new System.Drawing.Size(134, 24);
            this.rbCurrentDate.TabIndex = 0;
            this.rbCurrentDate.TabStop = true;
            this.rbCurrentDate.Text = "Поточна дата";
            this.rbCurrentDate.CheckedChanged += new System.EventHandler(this.rbCurrentDate_CheckedChanged);
            // 
            // rbDateRange
            // 
            this.rbDateRange.Location = new System.Drawing.Point(148, 25);
            this.rbDateRange.Name = "rbDateRange";
            this.rbDateRange.Size = new System.Drawing.Size(124, 24);
            this.rbDateRange.TabIndex = 1;
            this.rbDateRange.Text = "Діапазон дат";
            this.rbDateRange.CheckedChanged += new System.EventHandler(this.rbDateRange_CheckedChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(278, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(107, 22);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Value = new System.DateTime(2024, 8, 18, 0, 0, 0, 0);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(391, 25);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(111, 22);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.Value = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersHeight = 29;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.Location = new System.Drawing.Point(5, 135);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(5);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.Size = new System.Drawing.Size(790, 460);
            this.dgvAppointments.TabIndex = 2;
            // 
            // AppointmentSearchControl
            // 
            this.Controls.Add(this.mainLayout);
            this.Name = "AppointmentSearchControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.mainLayout.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        private DateTimePicker dtpSpecificDate;
    }
}
