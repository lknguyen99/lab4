namespace QuanLyKho
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácĐơnVịTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chươngTrìnhKhuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMonth = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDeliveryFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.txtTotalExport = new System.Windows.Forms.TextBox();
            this.lblExport = new System.Windows.Forms.Label();
            this.txtTotalImport = new System.Windows.Forms.TextBox();
            this.lblImport = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSumAmount = new System.Windows.Forms.TextBox();
            this.lblSumTotalAmount = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.xemDanhSáchĐặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanrToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanrToolStripMenuItem
            // 
            this.quanrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhoToolStripMenuItem,
            this.xuấtKhoToolStripMenuItem,
            this.tồnKhoToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.quanrToolStripMenuItem.Name = "quanrToolStripMenuItem";
            this.quanrToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.quanrToolStripMenuItem.Text = "Quản Lý Kho";
            // 
            // nhậpKhoToolStripMenuItem
            // 
            this.nhậpKhoToolStripMenuItem.Name = "nhậpKhoToolStripMenuItem";
            this.nhậpKhoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhậpKhoToolStripMenuItem.Text = "Nhập Kho";
            this.nhậpKhoToolStripMenuItem.Click += new System.EventHandler(this.nhậpKhoToolStripMenuItem_Click);
            // 
            // xuấtKhoToolStripMenuItem
            // 
            this.xuấtKhoToolStripMenuItem.Name = "xuấtKhoToolStripMenuItem";
            this.xuấtKhoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xuấtKhoToolStripMenuItem.Text = "Xuất Kho";
            this.xuấtKhoToolStripMenuItem.Click += new System.EventHandler(this.xuấtKhoToolStripMenuItem_Click);
            // 
            // tồnKhoToolStripMenuItem
            // 
            this.tồnKhoToolStripMenuItem.Name = "tồnKhoToolStripMenuItem";
            this.tồnKhoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tồnKhoToolStripMenuItem.Text = "Tồn Kho";
            this.tồnKhoToolStripMenuItem.Click += new System.EventHandler(this.tồnKhoToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.cácĐơnVịTínhToolStripMenuItem,
            this.chươngTrìnhKhuyếnMãiToolStripMenuItem});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // cácĐơnVịTínhToolStripMenuItem
            // 
            this.cácĐơnVịTínhToolStripMenuItem.Name = "cácĐơnVịTínhToolStripMenuItem";
            this.cácĐơnVịTínhToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.cácĐơnVịTínhToolStripMenuItem.Text = "Các Đơn Vị Tính";
            // 
            // chươngTrìnhKhuyếnMãiToolStripMenuItem
            // 
            this.chươngTrìnhKhuyếnMãiToolStripMenuItem.Name = "chươngTrìnhKhuyếnMãiToolStripMenuItem";
            this.chươngTrìnhKhuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.chươngTrìnhKhuyếnMãiToolStripMenuItem.Text = "Chương trình khuyến mãi";
            this.chươngTrìnhKhuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.chươngTrìnhKhuyếnMãiToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýBánHàngToolStripMenuItem});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân Viên";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýBánHàngToolStripMenuItem
            // 
            this.quảnLýBánHàngToolStripMenuItem.Name = "quảnLýBánHàngToolStripMenuItem";
            this.quảnLýBánHàngToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.quảnLýBánHàngToolStripMenuItem.Text = "Quản Lý Bán Hàng";
            this.quảnLýBánHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBánHàngToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKháchHàngToolStripMenuItem,
            this.thốngKêKháchHàngToolStripMenuItem,
            this.xemDanhSáchĐặtHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // thốngKêKháchHàngToolStripMenuItem
            // 
            this.thốngKêKháchHàngToolStripMenuItem.Name = "thốngKêKháchHàngToolStripMenuItem";
            this.thốngKêKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.thốngKêKháchHàngToolStripMenuItem.Text = "Thống kê khách Hàng";
            this.thốngKêKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêKháchHàngToolStripMenuItem_Click);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToOrderColumns = true;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InvoiceType,
            this.InvoiceNo,
            this.OrderDate,
            this.DeliveryDate,
            this.Amount,
            this.DiscountPercent,
            this.TotalAmount,
            this.FullName,
            this.StoreName,
            this.Note});
            this.dgvInvoice.Location = new System.Drawing.Point(14, 129);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.Size = new System.Drawing.Size(1044, 402);
            this.dgvInvoice.TabIndex = 14;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            this.dgvInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvInvoice_KeyDown);
            this.dgvInvoice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvInvoice_KeyUp);
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // InvoiceType
            // 
            this.InvoiceType.HeaderText = "Loại";
            this.InvoiceType.Name = "InvoiceType";
            this.InvoiceType.ReadOnly = true;
            this.InvoiceType.Width = 60;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.HeaderText = "Số HĐ";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            this.InvoiceNo.Width = 95;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Ngày Đặt Hàng";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 95;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "Ngày Giao Hàng";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            this.DeliveryDate.Width = 95;
            // 
            // Amount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle7;
            this.Amount.HeaderText = "Tổng Tiền";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DiscountPercent
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.DiscountPercent.DefaultCellStyle = dataGridViewCellStyle8;
            this.DiscountPercent.HeaderText = "CK";
            this.DiscountPercent.Name = "DiscountPercent";
            this.DiscountPercent.ReadOnly = true;
            this.DiscountPercent.Width = 50;
            // 
            // TotalAmount
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.TotalAmount.DefaultCellStyle = dataGridViewCellStyle9;
            this.TotalAmount.HeaderText = "Thành Tiền";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Tên Khách Hàng";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 130;
            // 
            // StoreName
            // 
            this.StoreName.HeaderText = "Kho Lưu Trữ";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi Chú";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 130;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(113, 537);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(105, 23);
            this.btnAddOrder.TabIndex = 15;
            this.btnAddOrder.Text = "Thêm Đơn Hàng";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMonth);
            this.groupBox1.Controls.Add(this.dtpDeliveryTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDeliveryFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 85);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // chkMonth
            // 
            this.chkMonth.AutoSize = true;
            this.chkMonth.Location = new System.Drawing.Point(436, 21);
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
            this.dtpDeliveryTo.Location = new System.Drawing.Point(682, 51);
            this.dtpDeliveryTo.Name = "dtpDeliveryTo";
            this.dtpDeliveryTo.Size = new System.Drawing.Size(101, 20);
            this.dtpDeliveryTo.TabIndex = 24;
            this.dtpDeliveryTo.ValueChanged += new System.EventHandler(this.Search);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "~";
            // 
            // dtpDeliveryFrom
            // 
            this.dtpDeliveryFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryFrom.Location = new System.Drawing.Point(546, 51);
            this.dtpDeliveryFrom.Name = "dtpDeliveryFrom";
            this.dtpDeliveryFrom.Size = new System.Drawing.Size(105, 20);
            this.dtpDeliveryFrom.TabIndex = 22;
            this.dtpDeliveryFrom.ValueChanged += new System.EventHandler(this.Search);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Thời Gian Giao Hàng";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(148, 25);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(169, 21);
            this.cmbStatus.TabIndex = 20;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Loại Nhập/Xuất";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(493, 570);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(147, 13);
            this.lblOrder.TabIndex = 21;
            this.lblOrder.Text = "0 Đơn đặt hàng, Tổng Cộng: ";
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Location = new System.Drawing.Point(650, 566);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.ReadOnly = true;
            this.txtTotalOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalOrder.Size = new System.Drawing.Size(95, 20);
            this.txtTotalOrder.TabIndex = 22;
            this.txtTotalOrder.Text = "0";
            // 
            // txtTotalExport
            // 
            this.txtTotalExport.Location = new System.Drawing.Point(926, 563);
            this.txtTotalExport.Name = "txtTotalExport";
            this.txtTotalExport.ReadOnly = true;
            this.txtTotalExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalExport.Size = new System.Drawing.Size(132, 20);
            this.txtTotalExport.TabIndex = 24;
            this.txtTotalExport.Text = "0";
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(778, 567);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(145, 13);
            this.lblExport.TabIndex = 23;
            this.lblExport.Text = "0 Đơn xuất kho, Tổng Cộng: ";
            // 
            // txtTotalImport
            // 
            this.txtTotalImport.Location = new System.Drawing.Point(926, 589);
            this.txtTotalImport.Name = "txtTotalImport";
            this.txtTotalImport.ReadOnly = true;
            this.txtTotalImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalImport.Size = new System.Drawing.Size(132, 20);
            this.txtTotalImport.TabIndex = 26;
            this.txtTotalImport.Text = "0";
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Location = new System.Drawing.Point(770, 593);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(155, 13);
            this.lblImport.TabIndex = 25;
            this.lblImport.Text = "0 Đơn nhập hàng, Tổng Cộng: ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(15, 537);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "In / Xem";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lợi Nhuận ( Xuất - Nhập):";
            // 
            // txtProfit
            // 
            this.txtProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.ForeColor = System.Drawing.Color.Red;
            this.txtProfit.Location = new System.Drawing.Point(927, 614);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProfit.Size = new System.Drawing.Size(132, 23);
            this.txtProfit.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tổng Cộng";
            // 
            // lblSumAmount
            // 
            this.lblSumAmount.Location = new System.Drawing.Point(496, 537);
            this.lblSumAmount.Name = "lblSumAmount";
            this.lblSumAmount.ReadOnly = true;
            this.lblSumAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSumAmount.Size = new System.Drawing.Size(96, 20);
            this.lblSumAmount.TabIndex = 31;
            this.lblSumAmount.Text = "0";
            // 
            // lblSumTotalAmount
            // 
            this.lblSumTotalAmount.Location = new System.Drawing.Point(650, 537);
            this.lblSumTotalAmount.Name = "lblSumTotalAmount";
            this.lblSumTotalAmount.ReadOnly = true;
            this.lblSumTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSumTotalAmount.Size = new System.Drawing.Size(95, 20);
            this.lblSumTotalAmount.TabIndex = 32;
            this.lblSumTotalAmount.Text = "0";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(225, 537);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 23);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Thay Đổi ";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // xemDanhSáchĐặtHàngToolStripMenuItem
            // 
            this.xemDanhSáchĐặtHàngToolStripMenuItem.Name = "xemDanhSáchĐặtHàngToolStripMenuItem";
            this.xemDanhSáchĐặtHàngToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.xemDanhSáchĐặtHàngToolStripMenuItem.Text = "Xem Danh Sách Đặt Hàng";
            this.xemDanhSáchĐặtHàngToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchĐặtHàngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 643);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblSumTotalAmount);
            this.Controls.Add(this.lblSumAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTotalImport);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.txtTotalExport);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.txtTotalOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản Lý Kho";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tồnKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cácĐơnVịTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDeliveryFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.CheckBox chkMonth;
        private System.Windows.Forms.TextBox txtTotalExport;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.TextBox txtTotalImport;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhKhuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêKháchHàngToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblSumAmount;
        private System.Windows.Forms.TextBox lblSumTotalAmount;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchĐặtHàngToolStripMenuItem;
    }
}

