namespace QuanLyKho
{
    partial class frmPromotion
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOffer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PromotionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InOutKBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPromotionType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUnitOffer = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantityOffer = new System.Windows.Forms.TextBox();
            this.txtQuantityBuy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkInPromotion = new System.Windows.Forms.CheckBox();
            this.chkOldPromotion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(375, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "THÔNG TIN KHUYÊN MÃI";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToOrderColumns = true;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductID,
            this.ProductName,
            this.UnitName,
            this.Price,
            this.QuantityBuy,
            this.QuantityOffer,
            this.Type,
            this.StartDate,
            this.EndDate,
            this.PromotionID,
            this.InOutKBN,
            this.UnitID});
            this.dgvProduct.Location = new System.Drawing.Point(374, 88);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(945, 496);
            this.dgvProduct.TabIndex = 12;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            this.dgvProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProduct_KeyUp);
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
            this.ProductID.Width = 70;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Tên SP";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.Width = 150;
            // 
            // UnitName
            // 
            this.UnitName.HeaderText = "ĐVT";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Đơn Giá";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // QuantityBuy
            // 
            this.QuantityBuy.HeaderText = "SL Nhập";
            this.QuantityBuy.Name = "QuantityBuy";
            this.QuantityBuy.ReadOnly = true;
            this.QuantityBuy.Width = 80;
            // 
            // QuantityOffer
            // 
            this.QuantityOffer.HeaderText = "SL Tặng";
            this.QuantityOffer.Name = "QuantityOffer";
            this.QuantityOffer.ReadOnly = true;
            this.QuantityOffer.Width = 80;
            // 
            // Type
            // 
            this.Type.HeaderText = "Loại Giao Dịch";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Ngày Áp Dụng ";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Ngày kết thúc";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // PromotionID
            // 
            this.PromotionID.HeaderText = "PromotionID";
            this.PromotionID.Name = "PromotionID";
            this.PromotionID.ReadOnly = true;
            this.PromotionID.Visible = false;
            // 
            // InOutKBN
            // 
            this.InOutKBN.HeaderText = "InOutKBN";
            this.InOutKBN.Name = "InOutKBN";
            this.InOutKBN.ReadOnly = true;
            this.InOutKBN.Visible = false;
            // 
            // UnitID
            // 
            this.UnitID.HeaderText = "UnitID";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            this.UnitID.Visible = false;
            this.UnitID.Width = 80;
            // 
            // cmbPromotionType
            // 
            this.cmbPromotionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPromotionType.FormattingEnabled = true;
            this.cmbPromotionType.Location = new System.Drawing.Point(652, 31);
            this.cmbPromotionType.Name = "cmbPromotionType";
            this.cmbPromotionType.Size = new System.Drawing.Size(173, 21);
            this.cmbPromotionType.TabIndex = 13;
            this.cmbPromotionType.SelectedIndexChanged += new System.EventHandler(this.cmbPromotionType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUnitOffer);
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtQuantityOffer);
            this.groupBox1.Controls.Add(this.txtQuantityBuy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblProductID);
            this.groupBox1.Controls.Add(this.txtGiaMua);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 426);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Thông Tin Sản Phẩm";
            // 
            // cmbUnitOffer
            // 
            this.cmbUnitOffer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitOffer.FormattingEnabled = true;
            this.cmbUnitOffer.Location = new System.Drawing.Point(232, 225);
            this.cmbUnitOffer.Name = "cmbUnitOffer";
            this.cmbUnitOffer.Size = new System.Drawing.Size(56, 21);
            this.cmbUnitOffer.TabIndex = 30;
           
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(116, 93);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 21);
            this.cmbUnit.TabIndex = 29;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Đơn Vị Tính";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(121, 314);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(105, 20);
            this.dtpEndDate.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ngày kết Thúc";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(119, 275);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(107, 20);
            this.dtpStartDate.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày Áp Dụng";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(115, 61);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(228, 21);
            this.cmbProduct.TabIndex = 23;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tặng";
            // 
            // txtQuantityOffer
            // 
            this.txtQuantityOffer.Location = new System.Drawing.Point(167, 226);
            this.txtQuantityOffer.Name = "txtQuantityOffer";
            this.txtQuantityOffer.Size = new System.Drawing.Size(59, 20);
            this.txtQuantityOffer.TabIndex = 21;
            // 
            // txtQuantityBuy
            // 
            this.txtQuantityBuy.Location = new System.Drawing.Point(167, 200);
            this.txtQuantityBuy.Name = "txtQuantityBuy";
            this.txtQuantityBuy.Size = new System.Drawing.Size(59, 20);
            this.txtQuantityBuy.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mua";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Khuyến Mãi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Giá Bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(115, 157);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(126, 20);
            this.txtGiaBan.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giá Mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Sản Phẩm";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(19, 33);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(74, 13);
            this.lblProductID.TabIndex = 7;
            this.lblProductID.Text = "Mã Sản Phẩm";
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(115, 125);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.ReadOnly = true;
            this.txtGiaMua.Size = new System.Drawing.Size(126, 20);
            this.txtGiaMua.TabIndex = 5;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(115, 30);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(124, 20);
            this.txtMaSP.TabIndex = 0;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(12, 528);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 53);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Chức Năng";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(282, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(203, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(111, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Cập Nhật";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkInPromotion
            // 
            this.chkInPromotion.AutoSize = true;
            this.chkInPromotion.Checked = true;
            this.chkInPromotion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInPromotion.Location = new System.Drawing.Point(1083, 63);
            this.chkInPromotion.Name = "chkInPromotion";
            this.chkInPromotion.Size = new System.Drawing.Size(129, 17);
            this.chkInPromotion.TabIndex = 16;
            this.chkInPromotion.Text = "Đang Và Sẽ Áp Dụng";
            this.chkInPromotion.UseVisualStyleBackColor = true;
            this.chkInPromotion.CheckedChanged += new System.EventHandler(this.chkInPromotion_CheckedChanged);
            // 
            // chkOldPromotion
            // 
            this.chkOldPromotion.AutoSize = true;
            this.chkOldPromotion.Location = new System.Drawing.Point(952, 63);
            this.chkOldPromotion.Name = "chkOldPromotion";
            this.chkOldPromotion.Size = new System.Drawing.Size(122, 17);
            this.chkOldPromotion.TabIndex = 17;
            this.chkOldPromotion.Text = "Các chương trình cũ";
            this.chkOldPromotion.UseVisualStyleBackColor = true;
            this.chkOldPromotion.CheckedChanged += new System.EventHandler(this.chkOldPromotion_CheckedChanged);
            // 
            // frmPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 596);
            this.Controls.Add(this.chkOldPromotion);
            this.Controls.Add(this.chkInPromotion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPromotionType);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.label2);
            this.Name = "frmPromotion";
            this.Text = "frmPromotion";
            this.Load += new System.EventHandler(this.frmPromotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cmbPromotionType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantityOffer;
        private System.Windows.Forms.TextBox txtQuantityBuy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkInPromotion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkOldPromotion;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUnitOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PromotionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InOutKBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
    }
}