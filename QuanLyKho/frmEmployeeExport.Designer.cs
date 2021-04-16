namespace QuanLyKho
{
    partial class frmEmployeeExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMonth = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDeliveryFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.EmployeeID,
            this.FullName,
            this.Mobile,
            this.SumAmount,
            this.SumTotalAmount,
            this.TotalInvoice,
            this.InvoiceNo});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 131);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(907, 403);
            this.dgvEmployee.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMonth);
            this.groupBox1.Controls.Add(this.dtpDeliveryTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDeliveryFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // chkMonth
            // 
            this.chkMonth.AutoSize = true;
            this.chkMonth.Location = new System.Drawing.Point(294, 26);
            this.chkMonth.Name = "chkMonth";
            this.chkMonth.Size = new System.Drawing.Size(134, 17);
            this.chkMonth.TabIndex = 25;
            this.chkMonth.Text = "Xem tất cả trong tháng";
            this.chkMonth.UseVisualStyleBackColor = true;
            this.chkMonth.CheckedChanged += new System.EventHandler(this.chkMonth_CheckedChanged);
            // 
            // dtpDeliveryTo
            // 
            this.dtpDeliveryTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryTo.Location = new System.Drawing.Point(540, 55);
            this.dtpDeliveryTo.Name = "dtpDeliveryTo";
            this.dtpDeliveryTo.Size = new System.Drawing.Size(101, 20);
            this.dtpDeliveryTo.TabIndex = 24;
            this.dtpDeliveryTo.ValueChanged += new System.EventHandler(this.dtpDeliveryTo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "~";
            // 
            // dtpDeliveryFrom
            // 
            this.dtpDeliveryFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryFrom.Location = new System.Drawing.Point(404, 55);
            this.dtpDeliveryFrom.Name = "dtpDeliveryFrom";
            this.dtpDeliveryFrom.Size = new System.Drawing.Size(105, 20);
            this.dtpDeliveryFrom.TabIndex = 22;
            this.dtpDeliveryFrom.ValueChanged += new System.EventHandler(this.dtpDeliveryTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Thời Gian Giao Hàng";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(92, 26);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(169, 21);
            this.cmbEmployee.TabIndex = 20;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nhân viên";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(763, 102);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Xem Chi tiết";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(844, 102);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Trở về";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "Mã NV";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ Và Tên";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 150;
            // 
            // Mobile
            // 
            this.Mobile.HeaderText = "SĐT";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Width = 80;
            // 
            // SumAmount
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.SumAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.SumAmount.HeaderText = "Tổng Tiền";
            this.SumAmount.Name = "SumAmount";
            this.SumAmount.ReadOnly = true;
            // 
            // SumTotalAmount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.SumTotalAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.SumTotalAmount.HeaderText = "Doanh Thu";
            this.SumTotalAmount.Name = "SumTotalAmount";
            this.SumTotalAmount.ReadOnly = true;
            // 
            // TotalInvoice
            // 
            this.TotalInvoice.HeaderText = "Tổng HĐ";
            this.TotalInvoice.Name = "TotalInvoice";
            this.TotalInvoice.ReadOnly = true;
            this.TotalInvoice.Width = 80;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.HeaderText = "Các HĐ";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            this.InvoiceNo.Width = 200;
            // 
            // frmEmployeeExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 542);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "frmEmployeeExport";
            this.Text = "frmEmployeeExport";
            this.Load += new System.EventHandler(this.frmEmployeeExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMonth;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDeliveryFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
    }
}