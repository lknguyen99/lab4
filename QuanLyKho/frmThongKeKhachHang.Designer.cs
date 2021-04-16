namespace QuanLyKho
{
    partial class frmThongKeKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkMonth = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDeliveryFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.CustomerID,
            this.CustomerName,
            this.Mobile,
            this.Address,
            this.TotalAmount,
            this.InvoiceNo});
            this.dgvCustomer.Location = new System.Drawing.Point(21, 127);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(909, 451);
            this.dgvCustomer.TabIndex = 50;
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "Mã KH";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 70;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Tên KH";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // Mobile
            // 
            this.Mobile.HeaderText = "SĐT";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Width = 80;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 190;
            // 
            // TotalAmount
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TotalAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.TotalAmount.HeaderText = "Tổng cộng";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 130;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.HeaderText = "Mã Hóa Đơn";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            this.InvoiceNo.Width = 205;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-56, -31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerAddress);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCustomerMobile);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chkMonth);
            this.groupBox1.Controls.Add(this.dtpDeliveryTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDeliveryFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 104);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(137, 82);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(324, 20);
            this.txtCustomerAddress.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Địa Chỉ:";
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(137, 52);
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.ReadOnly = true;
            this.txtCustomerMobile.Size = new System.Drawing.Size(115, 20);
            this.txtCustomerMobile.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "SĐT";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(137, 25);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(233, 21);
            this.cmbCustomer.TabIndex = 48;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomer_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Tên Khách Hàng";
            // 
            // chkMonth
            // 
            this.chkMonth.AutoSize = true;
            this.chkMonth.Checked = true;
            this.chkMonth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMonth.Location = new System.Drawing.Point(436, 25);
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
            this.dtpDeliveryTo.Location = new System.Drawing.Point(682, 54);
            this.dtpDeliveryTo.Name = "dtpDeliveryTo";
            this.dtpDeliveryTo.Size = new System.Drawing.Size(101, 20);
            this.dtpDeliveryTo.TabIndex = 24;
            this.dtpDeliveryTo.ValueChanged += new System.EventHandler(this.Search);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "~";
            // 
            // dtpDeliveryFrom
            // 
            this.dtpDeliveryFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryFrom.Location = new System.Drawing.Point(546, 54);
            this.dtpDeliveryFrom.Name = "dtpDeliveryFrom";
            this.dtpDeliveryFrom.Size = new System.Drawing.Size(105, 20);
            this.dtpDeliveryFrom.TabIndex = 22;
            this.dtpDeliveryFrom.ValueChanged += new System.EventHandler(this.Search);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tổng Cộng";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(792, 584);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(138, 20);
            this.txtTotalAmount.TabIndex = 53;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(20, 587);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 23);
            this.btnExport.TabIndex = 54;
            this.btnExport.Text = "Xuất Bảng Kê Chi Tiết";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 619);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.label3);
            this.Name = "frmThongKeKhachHang";
            this.Text = "Thống kê khách hàng";
            this.Load += new System.EventHandler(this.frmThongKeKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMonth;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDeliveryFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.Button btnExport;
    }
}