namespace QuanLyKho
{
    partial class frmInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityExport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountExport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkCurrentMonth = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDeliveryFrom = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateInventory = new System.Windows.Forms.Button();
            this.btnGetInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(418, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "THÔNG TIN TỒN KHO";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(220, 556);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductID,
            this.ProductName,
            this.UnitName,
            this.QuantityLast,
            this.AmountLast,
            this.QuantityImport,
            this.AmountImport,
            this.QuantityExport,
            this.AmountExport,
            this.Quantity,
            this.QuantityInventory,
            this.StoreID});
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInventory.Location = new System.Drawing.Point(26, 151);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(1192, 402);
            this.dgvInventory.TabIndex = 13;
            // 
            // No
            // 
            this.No.HeaderText = "STT";
            this.No.Name = "No";
            this.No.Width = 40;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Mã SP";
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 70;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên SP";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // UnitName
            // 
            this.UnitName.HeaderText = "ĐVT";
            this.UnitName.Name = "UnitName";
            this.UnitName.Width = 50;
            // 
            // QuantityLast
            // 
            this.QuantityLast.FillWeight = 120F;
            this.QuantityLast.HeaderText = "Tồn Đầu Kỳ";
            this.QuantityLast.Name = "QuantityLast";
            this.QuantityLast.Width = 120;
            // 
            // AmountLast
            // 
            this.AmountLast.HeaderText = "Tổng cộng";
            this.AmountLast.Name = "AmountLast";
            // 
            // QuantityImport
            // 
            this.QuantityImport.FillWeight = 120F;
            this.QuantityImport.HeaderText = "Nhập trong kỳ";
            this.QuantityImport.Name = "QuantityImport";
            // 
            // AmountImport
            // 
            this.AmountImport.HeaderText = "Tổng Cộng";
            this.AmountImport.Name = "AmountImport";
            // 
            // QuantityExport
            // 
            this.QuantityExport.HeaderText = "Xuất trong kỳ";
            this.QuantityExport.Name = "QuantityExport";
            // 
            // AmountExport
            // 
            this.AmountExport.HeaderText = "Tổng cộng";
            this.AmountExport.Name = "AmountExport";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 120F;
            this.Quantity.HeaderText = "Tồn cuối kỳ";
            this.Quantity.Name = "Quantity";
            // 
            // QuantityInventory
            // 
            this.QuantityInventory.HeaderText = "Kho Lưu Trữ HT";
            this.QuantityInventory.Name = "QuantityInventory";
            this.QuantityInventory.Width = 110;
            // 
            // StoreID
            // 
            this.StoreID.HeaderText = "StoreID";
            this.StoreID.Name = "StoreID";
            this.StoreID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tổng Số Lượng";
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Location = new System.Drawing.Point(598, 561);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.ReadOnly = true;
            this.txtTotalQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQuantity.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tổng Giá Trị";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(803, 559);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(120, 20);
            this.txtTotalAmount.TabIndex = 20;
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(80, 28);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(244, 21);
            this.cmbStore.TabIndex = 22;
            this.cmbStore.SelectedIndexChanged += new System.EventHandler(this.cmbStore_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Chọn Kho";
            // 
            // chkCurrentMonth
            // 
            this.chkCurrentMonth.AutoSize = true;
            this.chkCurrentMonth.Location = new System.Drawing.Point(510, 17);
            this.chkCurrentMonth.Name = "chkCurrentMonth";
            this.chkCurrentMonth.Size = new System.Drawing.Size(57, 17);
            this.chkCurrentMonth.TabIndex = 36;
            this.chkCurrentMonth.Text = "Tháng";
            this.chkCurrentMonth.UseVisualStyleBackColor = true;
            this.chkCurrentMonth.CheckedChanged += new System.EventHandler(this.chkCurrentMonth_CheckedChanged);
            // 
            // dtpDeliveryTo
            // 
            this.dtpDeliveryTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryTo.Location = new System.Drawing.Point(663, 47);
            this.dtpDeliveryTo.Name = "dtpDeliveryTo";
            this.dtpDeliveryTo.Size = new System.Drawing.Size(101, 20);
            this.dtpDeliveryTo.TabIndex = 35;
            this.dtpDeliveryTo.ValueChanged += new System.EventHandler(this.dtpDeliveryFrom_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(629, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "~";
            // 
            // dtpDeliveryFrom
            // 
            this.dtpDeliveryFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryFrom.Location = new System.Drawing.Point(510, 47);
            this.dtpDeliveryFrom.Name = "dtpDeliveryFrom";
            this.dtpDeliveryFrom.Size = new System.Drawing.Size(105, 20);
            this.dtpDeliveryFrom.TabIndex = 33;
            this.dtpDeliveryFrom.ValueChanged += new System.EventHandler(this.dtpDeliveryFrom_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Thời Gian Từ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(23, 556);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 38;
            this.btnPrint.Text = "Xem";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStore);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpDeliveryTo);
            this.groupBox1.Controls.Add(this.chkCurrentMonth);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpDeliveryFrom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(26, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 73);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tồn kho";
            // 
            // btnUpdateInventory
            // 
            this.btnUpdateInventory.Location = new System.Drawing.Point(104, 556);
            this.btnUpdateInventory.Name = "btnUpdateInventory";
            this.btnUpdateInventory.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateInventory.TabIndex = 40;
            this.btnUpdateInventory.Text = "Cập Nhật Kho";
            this.btnUpdateInventory.UseVisualStyleBackColor = true;
            this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
            // 
            // btnGetInventory
            // 
            this.btnGetInventory.Enabled = false;
            this.btnGetInventory.Location = new System.Drawing.Point(1101, 117);
            this.btnGetInventory.Name = "btnGetInventory";
            this.btnGetInventory.Size = new System.Drawing.Size(108, 23);
            this.btnGetInventory.TabIndex = 41;
            this.btnGetInventory.Text = "Cuối kỳ >> Tồn kho";
            this.btnGetInventory.UseVisualStyleBackColor = true;
            this.btnGetInventory.Click += new System.EventHandler(this.btnGetInventory_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 608);
            this.Controls.Add(this.btnGetInventory);
            this.Controls.Add(this.btnUpdateInventory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.label1);
            this.Name = "frmInventory";
            this.Text = "Tồn kho";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCurrentMonth;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDeliveryFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.Button btnGetInventory;
    }
}