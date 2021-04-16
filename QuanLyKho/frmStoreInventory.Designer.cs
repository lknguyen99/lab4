namespace QuanLyKho
{
    partial class frmStoreInventory
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
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCurrentMonth = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDeliveryFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLastMonth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbStore
            // 
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(119, 72);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(244, 21);
            this.cmbStore.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Chọn Kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(298, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "THÔNG TIN TỒN KHO";
            // 
            // chkCurrentMonth
            // 
            this.chkCurrentMonth.AutoSize = true;
            this.chkCurrentMonth.Location = new System.Drawing.Point(702, 70);
            this.chkCurrentMonth.Name = "chkCurrentMonth";
            this.chkCurrentMonth.Size = new System.Drawing.Size(57, 17);
            this.chkCurrentMonth.TabIndex = 30;
            this.chkCurrentMonth.Text = "Tháng";
            this.chkCurrentMonth.UseVisualStyleBackColor = true;
            // 
            // dtpDeliveryTo
            // 
            this.dtpDeliveryTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryTo.Location = new System.Drawing.Point(723, 100);
            this.dtpDeliveryTo.Name = "dtpDeliveryTo";
            this.dtpDeliveryTo.Size = new System.Drawing.Size(101, 20);
            this.dtpDeliveryTo.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(689, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "~";
            // 
            // dtpDeliveryFrom
            // 
            this.dtpDeliveryFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliveryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryFrom.Location = new System.Drawing.Point(570, 100);
            this.dtpDeliveryFrom.Name = "dtpDeliveryFrom";
            this.dtpDeliveryFrom.Size = new System.Drawing.Size(105, 20);
            this.dtpDeliveryFrom.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Thời Gian Từ";
            // 
            // chkLastMonth
            // 
            this.chkLastMonth.AutoSize = true;
            this.chkLastMonth.Location = new System.Drawing.Point(577, 70);
            this.chkLastMonth.Name = "chkLastMonth";
            this.chkLastMonth.Size = new System.Drawing.Size(60, 17);
            this.chkLastMonth.TabIndex = 31;
            this.chkLastMonth.Text = "Tháng ";
            this.chkLastMonth.UseVisualStyleBackColor = true;
            // 
            // frmStoreInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 510);
            this.Controls.Add(this.chkLastMonth);
            this.Controls.Add(this.chkCurrentMonth);
            this.Controls.Add(this.dtpDeliveryTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDeliveryFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frmStoreInventory";
            this.Text = "frmStoreInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCurrentMonth;
        private System.Windows.Forms.DateTimePicker dtpDeliveryTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDeliveryFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLastMonth;
    }
}