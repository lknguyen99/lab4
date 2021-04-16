namespace QuanLyKho
{
    partial class frmExportInventory
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvExport = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxQuatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmployeeMobile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(700, 41);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "THÔNG TIN XUẤT KHO";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(183, 1015);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(207, 42);
            this.btnImport.TabIndex = 39;
            this.btnImport.Text = "Xuất Kho";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(1558, 124);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(215, 29);
            this.dtpDeliveryDate.TabIndex = 38;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1382, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ngày Giao Hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 1015);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 35;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(1522, 39);
            this.cmbStore.Margin = new System.Windows.Forms.Padding(6);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(281, 32);
            this.cmbStore.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1382, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Xuất tại kho";
            // 
            // dgvExport
            // 
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductID,
            this.ProductName,
            this.UnitName,
            this.Quantity,
            this.SellPrice,
            this.AmountSell,
            this.QuantityOffer,
            this.MaxQuatity});
            this.dgvExport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvExport.Location = new System.Drawing.Point(37, 391);
            this.dgvExport.Margin = new System.Windows.Forms.Padding(6);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.RowHeadersWidth = 72;
            this.dgvExport.Size = new System.Drawing.Size(1883, 611);
            this.dgvExport.TabIndex = 26;
            this.dgvExport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExport_CellContentClick);
            this.dgvExport.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvExport_CellPainting);
            this.dgvExport.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvExport_DataError);
            this.dgvExport.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvExport_EditingControlShowing);
            this.dgvExport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvExport_RowPostPaint);
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.MinimumWidth = 9;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 50;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Mã SP";
            this.ProductID.MinimumWidth = 9;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 90;
            // 
            // ProductName
            // 
            this.ProductName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.MinimumWidth = 9;
            this.ProductName.Name = "ProductName";
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductName.Width = 220;
            // 
            // UnitName
            // 
            this.UnitName.HeaderText = "ĐVT";
            this.UnitName.MinimumWidth = 9;
            this.UnitName.Name = "UnitName";
            this.UnitName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitName.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.MinimumWidth = 9;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 175;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Giá Bán";
            this.SellPrice.MinimumWidth = 9;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Width = 90;
            // 
            // AmountSell
            // 
            this.AmountSell.HeaderText = "Thành Tiền";
            this.AmountSell.MinimumWidth = 9;
            this.AmountSell.Name = "AmountSell";
            this.AmountSell.ReadOnly = true;
            this.AmountSell.Width = 150;
            // 
            // QuantityOffer
            // 
            this.QuantityOffer.HeaderText = "Khuyến Mãi";
            this.QuantityOffer.MinimumWidth = 9;
            this.QuantityOffer.Name = "QuantityOffer";
            this.QuantityOffer.Width = 175;
            // 
            // MaxQuatity
            // 
            this.MaxQuatity.HeaderText = "SL Tại Kho";
            this.MaxQuatity.MinimumWidth = 9;
            this.MaxQuatity.Name = "MaxQuatity";
            this.MaxQuatity.ReadOnly = true;
            this.MaxQuatity.Width = 175;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmployeeMobile);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(801, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(581, 186);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Người Nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmployeeMobile
            // 
            this.txtEmployeeMobile.Location = new System.Drawing.Point(171, 102);
            this.txtEmployeeMobile.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmployeeMobile.Name = "txtEmployeeMobile";
            this.txtEmployeeMobile.ReadOnly = true;
            this.txtEmployeeMobile.Size = new System.Drawing.Size(208, 29);
            this.txtEmployeeMobile.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 43;
            this.label7.Text = "SĐT";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(169, 50);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(6);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(352, 32);
            this.cmbEmployee.TabIndex = 42;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Người Bán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustomerAddress);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCustomerMobile);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbCustomer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(39, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(744, 186);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Khách Hàng";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(139, 133);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.ReadOnly = true;
            this.txtCustomerAddress.Size = new System.Drawing.Size(591, 29);
            this.txtCustomerAddress.TabIndex = 46;
            this.txtCustomerAddress.TextChanged += new System.EventHandler(this.txtCustomerAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Địa Chỉ:";
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(209, 85);
            this.txtCustomerMobile.Margin = new System.Windows.Forms.Padding(6);
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.ReadOnly = true;
            this.txtCustomerMobile.Size = new System.Drawing.Size(208, 29);
            this.txtCustomerMobile.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "SĐT";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(209, 35);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(424, 32);
            this.cmbCustomer.TabIndex = 42;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.TextChanged += new System.EventHandler(this.cmbCustomer_TextChanged);
            this.cmbCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCustomer_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tên Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(970, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ngày Đặt Hàng";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(1129, 122);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(215, 29);
            this.dtpOrderDate.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1393, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ghi Chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(1390, 255);
            this.txtNote.Margin = new System.Windows.Forms.Padding(6);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(527, 111);
            this.txtNote.TabIndex = 49;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(631, 120);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(325, 29);
            this.txtInvoiceNo.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Theo hóa đơn số";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1681, 1023);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "Chiết khấu";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(1800, 1017);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(65, 29);
            this.txtDiscount.TabIndex = 53;
            this.txtDiscount.Text = "5";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1885, 1023);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 25);
            this.label12.TabIndex = 54;
            this.label12.Text = "%";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(1261, 1025);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 25);
            this.lblAmount.TabIndex = 55;
            this.lblAmount.Text = "Thành Tiền";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1386, 1017);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(275, 29);
            this.txtAmount.TabIndex = 56;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(1265, 1084);
            this.lblSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(111, 25);
            this.lblSum.TabIndex = 57;
            this.lblSum.Text = "Tổng Cộng";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(1386, 1078);
            this.txtSum.Margin = new System.Windows.Forms.Padding(6);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSum.Size = new System.Drawing.Size(275, 29);
            this.txtSum.TabIndex = 58;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(403, 1015);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 42);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "Thay đổi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmExportInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1146);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvExport);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmExportInventory";
            this.Text = "frmExport";
            this.Load += new System.EventHandler(this.frmExportInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmployeeMobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxQuatity;
    }
}