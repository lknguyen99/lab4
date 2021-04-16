namespace QuanLyKho
{
    partial class frmListOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDeliveryTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDeliveryFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkOrder = new System.Windows.Forms.CheckBox();
            this.chkExport = new System.Windows.Forms.CheckBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lblProfit = new System.Windows.Forms.Label();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExport);
            this.groupBox1.Controls.Add(this.chkOrder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDeliveryTo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDeliveryFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 97);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đơn Hàng";
            // 
            // dtpDeliveryTo
            // 
            this.dtpDeliveryTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryTo.Location = new System.Drawing.Point(281, 33);
            this.dtpDeliveryTo.Name = "dtpDeliveryTo";
            this.dtpDeliveryTo.Size = new System.Drawing.Size(101, 20);
            this.dtpDeliveryTo.TabIndex = 24;
            this.dtpDeliveryTo.ValueChanged += new System.EventHandler(this.dtpDeliveryFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "~";
            // 
            // dtpDeliveryFrom
            // 
            this.dtpDeliveryFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryFrom.Location = new System.Drawing.Point(145, 33);
            this.dtpDeliveryFrom.Name = "dtpDeliveryFrom";
            this.dtpDeliveryFrom.Size = new System.Drawing.Size(105, 20);
            this.dtpDeliveryFrom.TabIndex = 22;
            this.dtpDeliveryFrom.ValueChanged += new System.EventHandler(this.dtpDeliveryFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thời Gian Giao Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Loại Đơn Hàng";
            // 
            // chkOrder
            // 
            this.chkOrder.AutoSize = true;
            this.chkOrder.Checked = true;
            this.chkOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOrder.Location = new System.Drawing.Point(145, 69);
            this.chkOrder.Name = "chkOrder";
            this.chkOrder.Size = new System.Drawing.Size(74, 17);
            this.chkOrder.TabIndex = 27;
            this.chkOrder.Text = "Các Order";
            this.chkOrder.UseVisualStyleBackColor = true;
            this.chkOrder.CheckedChanged += new System.EventHandler(this.dtpDeliveryFrom_ValueChanged);
            // 
            // chkExport
            // 
            this.chkExport.AutoSize = true;
            this.chkExport.Location = new System.Drawing.Point(281, 69);
            this.chkExport.Name = "chkExport";
            this.chkExport.Size = new System.Drawing.Size(87, 17);
            this.chkExport.TabIndex = 28;
            this.chkExport.Text = "Đã Xuất Kho";
            this.chkExport.UseVisualStyleBackColor = true;
            this.chkExport.CheckedChanged += new System.EventHandler(this.dtpDeliveryFrom_ValueChanged);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.UnitName,
            this.BuyPrice,
            this.SellPrice,
            this.AmountBuy,
            this.AmountSell,
            this.UnitID});
            this.dgvProduct.Location = new System.Drawing.Point(12, 117);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(956, 457);
            this.dgvProduct.TabIndex = 53;
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(753, 583);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(56, 13);
            this.lblProfit.TabIndex = 54;
            this.lblProfit.Text = "Lợi Nhuận";
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(823, 580);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(145, 20);
            this.txtProfit.TabIndex = 55;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 582);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 23);
            this.btnPrint.TabIndex = 56;
            this.btnPrint.Text = "Xem / In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Mã SP";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 80;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên SP";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 180;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Số Lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.HeaderText = "ĐVT";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 70;
            // 
            // BuyPrice
            // 
            this.BuyPrice.HeaderText = "Giá Mua";
            this.BuyPrice.Name = "BuyPrice";
            this.BuyPrice.ReadOnly = true;
            // 
            // SellPrice
            // 
            this.SellPrice.HeaderText = "Giá Bán";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            this.SellPrice.Width = 120;
            // 
            // AmountBuy
            // 
            this.AmountBuy.HeaderText = "Tổng Mua";
            this.AmountBuy.Name = "AmountBuy";
            this.AmountBuy.ReadOnly = true;
            // 
            // AmountSell
            // 
            this.AmountSell.HeaderText = "Tổng Bán";
            this.AmountSell.Name = "AmountSell";
            this.AmountSell.ReadOnly = true;
            // 
            // UnitID
            // 
            this.UnitID.HeaderText = "Unit ID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            this.UnitID.Visible = false;
            // 
            // frmListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 612);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListOrder";
            this.Text = "frmListOrder";
            this.Load += new System.EventHandler(this.frmListOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDeliveryFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkOrder;
        private System.Windows.Forms.CheckBox chkExport;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;

    }
}