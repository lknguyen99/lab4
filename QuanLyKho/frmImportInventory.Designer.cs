namespace QuanLyKho
{
    partial class frmImportInventory
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
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRefDate = new System.Windows.Forms.DateTimePicker();
            this.btnImport = new System.Windows.Forms.Button();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImport
            // 
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductID,
            this.ProductName,
            this.UnitName,
            this.Quantity,
            this.BuyPrice,
            this.Amount,
            this.SellPrice,
            this.QuantityOffer});
            this.dgvImport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvImport.Location = new System.Drawing.Point(39, 301);
            this.dgvImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.RowHeadersWidth = 72;
            this.dgvImport.Size = new System.Drawing.Size(1863, 709);
            this.dgvImport.StandardTab = true;
            this.dgvImport.TabIndex = 0;
            this.dgvImport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImport_CellContentClick);
            this.dgvImport.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvImport_CellPainting);
            this.dgvImport.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvImport_DataError);
            this.dgvImport.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvImport_EditingControlShowing);
            this.dgvImport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvImport_RowPostPaint);
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
            this.ProductID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProductName.HeaderText = "Tên Sản Phẩm";
            this.ProductName.MinimumWidth = 9;
            this.ProductName.Name = "ProductName";
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductName.Width = 200;
            // 
            // UnitName
            // 
            this.UnitName.FillWeight = 80F;
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
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "Giá Nhập Kho";
            this.BuyPrice.MinimumWidth = 9;
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.Width = 120;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Thành Tiền";
            this.Amount.MinimumWidth = 9;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 120;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Giá Bán";
            this.SellPrice.MinimumWidth = 9;
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Width = 120;
            // 
            // QuantityOffer
            // 
            this.QuantityOffer.HeaderText = "Hàng Tặng";
            this.QuantityOffer.MinimumWidth = 9;
            this.QuantityOffer.Name = "QuantityOffer";
            this.QuantityOffer.Width = 175;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(612, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "THÔNG TIN NHẬP KHO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Họ và tên người nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Theo hóa đơn số";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(218, 179);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(230, 29);
            this.txtInvoiceNo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập tại kho";
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(803, 120);
            this.cmbStore.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(318, 32);
            this.cmbStore.TabIndex = 17;
            this.cmbStore.SelectedIndexChanged += new System.EventHandler(this.cmbStore_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(39, 1021);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 42);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày Nhập Kho";
            // 
            // dtpRefDate
            // 
            this.dtpRefDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRefDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRefDate.Location = new System.Drawing.Point(218, 124);
            this.dtpRefDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpRefDate.Name = "dtpRefDate";
            this.dtpRefDate.Size = new System.Drawing.Size(149, 29);
            this.dtpRefDate.TabIndex = 24;
            this.dtpRefDate.ValueChanged += new System.EventHandler(this.dtpRefDate_ValueChanged);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(187, 1021);
            this.btnImport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(138, 42);
            this.btnImport.TabIndex = 25;
            this.btnImport.Text = "Nhập Kho";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(257, 234);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(422, 32);
            this.cmbEmployee.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1135, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1221, 124);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(561, 29);
            this.txtAddress.TabIndex = 19;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(1364, 1076);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(275, 29);
            this.txtTotalAmount.TabIndex = 65;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(1241, 1084);
            this.lblSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(111, 25);
            this.lblSum.TabIndex = 64;
            this.lblSum.Text = "Tổng Cộng";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1362, 1021);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAmount.Size = new System.Drawing.Size(275, 29);
            this.txtAmount.TabIndex = 63;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(1238, 1028);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(113, 25);
            this.lblAmount.TabIndex = 62;
            this.lblAmount.Text = "Thành Tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1861, 1026);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 25);
            this.label12.TabIndex = 61;
            this.label12.Text = "%";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(1777, 1021);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(65, 29);
            this.txtDiscount.TabIndex = 60;
            this.txtDiscount.Text = "9";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1657, 1026);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 59;
            this.label11.Text = "Chiết khấu";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(336, 1021);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(174, 42);
            this.btnEdit.TabIndex = 66;
            this.btnEdit.Text = "Thay đổi";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmImportInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1137);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dtpRefDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvImport);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmImportInventory";
            this.Text = "frmImportInventory";
            this.Load += new System.EventHandler(this.frmImportInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRefDate;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOffer;
    }
}