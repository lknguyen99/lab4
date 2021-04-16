using QuanlyKho.Util;
using QuanLyKho.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmImportInventory : Form
    {
        public bool isEditForm = false;
        //Some index
        public int INDEX_NO = 0;
        public int INDEX_PRODUCT_ID = 1;
        public int INDEX_PRODUCT_NM = 2;
        public int INDEX_UNIT = 3;
        public int INDEX_QUANTITY = 4;
        public int INDEX_BUY_PRICE = 5;
        public int INDEX_AMOUNT = 6;
        public int INDEX_SELL_PRICE = 7;
        public int INDEX_QUANTITY_OFFER = 8;

        public List<Product> listProduct = new List<Product>();
        public frmImportInventory()
        {
            InitializeComponent();
            
        }
        public frmImportInventory(string invoiceNo)
        {
            InitializeComponent();

            isEditForm = true;
            Invoice findInvoice = Invoice.GetInvoice(invoiceNo);

            List<InventoryHistory> list = InventoryHistory.GetInventoryListFromInvoice(findInvoice);


            dgvImport.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                int row = dgvImport.Rows.Add();
                dgvImport.Rows[row].Cells["No"].Value = i + 1;
                dgvImport.Rows[row].Cells["ProductID"].Value = list[i].ProductID;
                dgvImport.Rows[row].Cells["ProductName"].Value = list[i].ProductID;
                dgvImport.Rows[row].Cells["UnitName"].Value = list[i].UnitID;
                dgvImport.Rows[row].Cells["Quantity"].Value = list[i].Quantity;
                dgvImport.Rows[row].Cells["SellPrice"].Value = Common.GetMoney(list[i].SellPrice);
                dgvImport.Rows[row].Cells["BuyPrice"].Value = Common.GetMoney(list[i].BuyPrice);
                dgvImport.Rows[row].Cells["Amount"].Value = Common.GetMoney(list[i].AmountBuy);
                dgvImport.Rows[row].Cells["QuantityOffer"].Value = list[i].QuantityOffer;
            }

            FormCommon.SetStore(cmbStore, false);
            FormCommon.SetEmployee(cmbEmployee, true);

            dtpRefDate.Value = findInvoice.DeliveryDate;
            txtInvoiceNo.Text = findInvoice.InvoiceNo;
            cmbStore.SelectedValue = findInvoice.StoreID;
            if (findInvoice.EmployeeID != null)
            {
                cmbEmployee.SelectedValue = findInvoice.EmployeeID;
                //txtEmployeeMobile.Text = Employee.GetEmployee(findInvoice.EmployeeID).Mobile;
            }
            txtInvoiceNo.Enabled = cmbStore.Enabled = false;
            btnEdit.Visible = true;
            btnImport.Enabled = false;

        }
        private void frmImportInventory_Load(object sender, EventArgs e)
        {
            try
            {
                if (!isEditForm)
                {
                    FormCommon.SetStore(cmbStore, false);
                    FormCommon.SetEmployee(cmbEmployee, true);
                    SetInvoiceNo(dtpRefDate.Value);
                }
               
                listProduct = Product.GetAllProduct();

                DataGridViewComboBoxColumn cmbProduct = (DataGridViewComboBoxColumn)dgvImport.Columns[2];
              

                List<Product> listProductFill = listProduct
                                          .GroupBy(p => p.ProductID)
                                          .Select(g => g.First())
                                          .ToList();

                cmbProduct.DataSource = listProductFill;
                cmbProduct.ValueMember = "ProductID";
                cmbProduct.DisplayMember = "ProductName";

            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }

        }
        private void LoadUnitFromProduct(string productID)
        {
            var currentcell = dgvImport.CurrentCellAddress;
            if (productID == "")
            {
                DataGridViewTextBoxCell celProductId = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_ID];
                productID = celProductId.Value.ToString();

                DataGridViewComboBoxCell celProductName = (DataGridViewComboBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM];
                dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM].Value = productID;

                //DataGridViewComboBoxCell celProductName = (DataGridViewComboBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM];
                //if (celProductName.Selected == false)
                //{
                //    dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM].Value = productID;
                //}
            }
         
            DataGridViewComboBoxCell cmbUnit = (DataGridViewComboBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_UNIT];
            List<CodeName> listProductUnit = Product.GetListUnitFromProduct(productID);
            if (cmbUnit.DataSource == null || cmbUnit.Selected == false)
            {
                cmbUnit.DataSource = listProductUnit;
                cmbUnit.ValueMember = "Code";
                cmbUnit.DisplayMember = "Name";
            }
            if (listProductUnit.Count > 0)
            {
                dgvImport.Rows[currentcell.Y].Cells[INDEX_UNIT].Value = listProductUnit[0].Code;
            }
        }
        void dgvImport_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvImport.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvImport.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        ((DataGridViewComboBoxColumn)dgvImport.Columns[e.ColumnIndex]).Items.Add(value);
                        e.ThrowException = false;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int storeID = Convert.ToInt32(cmbStore.SelectedValue);
                txtAddress.Text = Store.GetStore(storeID).Address;
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice invoice = GetInvoice();
                List<InventoryHistory> listInventoryhist = GetListInventoryHistory();
                InventoryHistory.ImportData(listInventoryhist, invoice); 
                FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_SUCCESS_IMPORT_INVENTORY"));

                dgvImport.Rows.Clear();
                SetInvoiceNo(dtpRefDate.Value);
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }

        }

        private Invoice GetInvoice()
        {
            Invoice invoice = Invoice.GetInvoice(txtInvoiceNo.Text);
            if (invoice == null)
            {
                invoice = new Invoice();
                invoice.InvoiceNo = txtInvoiceNo.Text;
            }

            invoice.StoreID = Convert.ToInt32(cmbStore.SelectedValue);
            invoice.EmployeeID = Common.GetStringValue(cmbEmployee.SelectedValue);
            invoice.OrderDate = dtpRefDate.Value;
            invoice.DeliveryDate = dtpRefDate.Value;
            invoice.Discount = 0;
            invoice.Amount = Common.GetDecimalValue(txtAmount.Text);
            invoice.InOutKbn = Constant.KBN_IMPORT; 
            invoice.TotalAmount = Common.GetDecimalValue(txtTotalAmount.Text);
            invoice.Discount = 0;
            if (txtDiscount.Text != "")
                invoice.Discount = Common.GetDoubleValue(txtDiscount.Text) / 100;
            return invoice;
        }
        private List<InventoryHistory> GetListInventoryHistory()
        {
            List<InventoryHistory> listInventoryhist = new List<InventoryHistory>();
            foreach (DataGridViewRow row in dgvImport.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[INDEX_PRODUCT_ID].Value + ""))
                {
                    var findProduct = listProduct.FirstOrDefault(p => p.ProductID == row.Cells[INDEX_PRODUCT_ID].Value.ToString());
                    if (findProduct == null)
                    {
                        throw new Exception(Common.GetResouceString("MSG_ERROR_INPUT_INVENTORY"));
                     }

                    InventoryHistory temp = new InventoryHistory();
                 
                    temp.ProductID = findProduct.ProductID;
                    temp.ProductName = findProduct.ProductName;

                    temp.UnitID = row.Cells[INDEX_UNIT].Value.ToString();
                    temp.UnitName = Unit.GetUnit(temp.UnitID).UnitName;

                    temp.Quantity = Common.GetDecimalValue(row.Cells[INDEX_QUANTITY].Value + "");

                    Promotion findPromotion = Promotion.GetPromotionInfo(Constant.KBN_IMPORT, temp.ProductID, temp.UnitID, dtpRefDate.Value, temp.Quantity);
                    if (findPromotion != null)
                    {
                        temp.QuantityOfferUnit = findPromotion.QuantityOfferUnit;
                    }

                    temp.BuyPrice = Common.GetDecimalValue(row.Cells[INDEX_BUY_PRICE].Value + "");
                    temp.AmountBuy = Common.GetDecimalValue(row.Cells[INDEX_AMOUNT].Value + "");
                    temp.SellPrice = Common.GetDecimalValue(row.Cells[INDEX_SELL_PRICE].Value + "");
                    temp.QuantityOffer = Common.GetDecimalValue(row.Cells[INDEX_QUANTITY_OFFER].Value + "");
                    listInventoryhist.Add(temp);
                }
            }

            return listInventoryhist;

          
        }

        private void dgvImport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvImport.Rows[e.RowIndex].Cells[INDEX_NO].Value = (e.RowIndex + 1).ToString();
        }
        private void dgvImport_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (dgvImport.CurrentCell.ColumnIndex == INDEX_PRODUCT_NM && e.Control is ComboBox)
                {
                    ComboBox combobox = e.Control as ComboBox;
                    combobox.DropDownStyle = ComboBoxStyle.DropDown;
                    combobox.AutoCompleteMode = AutoCompleteMode.Suggest;
                    combobox.AutoCompleteSource = AutoCompleteSource.CustomSource;

                    combobox.SelectedIndexChanged += productName_SelectionChanged;
                    combobox.TextChanged += new EventHandler(ProductName_TextChanged);
                  
                }
                if (dgvImport.CurrentCell.ColumnIndex == INDEX_UNIT && e.Control is ComboBox)
                {
                    ComboBox combobox = e.Control as ComboBox;
                    combobox.SelectedIndexChanged += UnitName_SelectionChanged;
                 
                }
                if (dgvImport.CurrentCell.ColumnIndex == INDEX_PRODUCT_ID && e.Control is TextBox)
                {
                    TextBox txt = e.Control as TextBox;
                    txt.TextChanged += txtProductID_TextboxChanged;
                }
                if (dgvImport.CurrentCell.ColumnIndex == INDEX_QUANTITY && e.Control is TextBox)
                {
                    TextBox txt = e.Control as TextBox;
                   // txt.KeyPress += txtQuantity_KeyPress;
                    txt.TextChanged += txtQuantity_TextboxChanged;
                }
            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtQuantity_TextboxChanged(object sender, EventArgs e)
        {
            try
            {
                var currentcell = dgvImport.CurrentCellAddress;
                var sendingCB = sender as DataGridViewTextBoxEditingControl;
                DataGridViewTextBoxCell cellAmount = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_AMOUNT];
                cellAmount.Value = "";
                if (sendingCB != null && currentcell.X == INDEX_QUANTITY)
                {
                    decimal? price = Common.GetDecimalValue(((DataGridViewTextBoxCell)dgvImport.CurrentRow.Cells[INDEX_BUY_PRICE]).Value + "");
                    decimal? quantity = Common.GetDecimalValue(sendingCB.Text + "");
                    if (quantity != null && price != null)
                    {
                        cellAmount.Value = Common.GetMoney(price * quantity);
                    }

                    DataGridViewTextBoxCell celQuantityOffer = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_QUANTITY_OFFER];
                    celQuantityOffer.Value = "0";
                    //tinh khuyen mai 
                    DataGridViewTextBoxCell celProductID = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_ID];

                    DataGridViewComboBoxCell celUnitID = (DataGridViewComboBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_UNIT];
                    if(celProductID.Value!= null)
                    {
                        Promotion findPromotion = Promotion.GetPromotionInfo(Constant.KBN_IMPORT, celProductID.Value.ToString(), celUnitID.Value.ToString(), dtpRefDate.Value, quantity);
                        if (findPromotion!= null && findPromotion.QuantityBuy != null && findPromotion.QuantityOffer != null)
                        {
                            celQuantityOffer.Value = Promotion.GetQuantityOfferMin(findPromotion, quantity.Value);
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
        private void ProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewComboBoxEditingControl combobox = sender as DataGridViewComboBoxEditingControl;
                if (combobox.Text != "" && combobox.SelectedIndex == -1)
                {
                    combobox.DataSource = listProduct.Where(p => p.ProductName.ToLower().Contains(combobox.Text.ToLower())).ToList();
                }
            }
            catch
            { }
        }
        private void productName_SelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dgvImport.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            if (!string.IsNullOrEmpty(sendingCB.SelectedValue + ""))
            {
                  LoadUnitFromProduct(sendingCB.SelectedValue.ToString());
                  SetValueFromProductID(sendingCB.SelectedValue.ToString(), "", true);
            }

        }

        private void txtProductID_TextboxChanged(object sender, EventArgs e)
        {
            try
            {
                var currentcell = dgvImport.CurrentCellAddress;
                var sendingTX = sender as DataGridViewTextBoxEditingControl;
                if (sendingTX != null)
                {
                    LoadUnitFromProduct(sendingTX.Text);
                    SetValueFromProductID(sendingTX.Text, "", false);
                }
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
        private void UnitName_SelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dgvImport.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            if (sendingCB.SelectedValue != null)
            {
                SetValueFromProductID("", sendingCB.SelectedValue.ToString(), true);
            }
        }

        private void SetValueFromProductID(string productID, string unitID, bool isDropDownValue)
        {
            var currentcell = dgvImport.CurrentCellAddress;
            if (unitID == "")
            {
                DataGridViewComboBoxCell celUnit = (DataGridViewComboBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_UNIT];
                unitID = celUnit.Value + "";
            }
            if(productID == "")
            {
                DataGridViewTextBoxCell celProductID = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_ID];
                productID = celProductID.Value + "";
            }

            DataGridViewTextBoxCell celPrice = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_BUY_PRICE];
            DataGridViewComboBoxCell celProductName = (DataGridViewComboBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM];
            DataGridViewTextBoxCell celSellPrice = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_SELL_PRICE];
            DataGridViewTextBoxCell celQuantity = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_QUANTITY];

            if (!string.IsNullOrEmpty(productID) && !string.IsNullOrEmpty(unitID))
            {
                var findProduct = listProduct.FirstOrDefault(p => p.ProductID == productID && p.UnitID == unitID);
                if (findProduct != null)
                {
                    if (isDropDownValue)
                    {
                        DataGridViewTextBoxCell celProductID = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_ID];
                        celProductID.Value = findProduct.ProductID;
                    }
                    else
                    {
                        celProductName.Value = findProduct.ProductID;
                    }

                    celPrice.Value = Common.GetMoney(findProduct.BuyPriceCurrent);
                    celSellPrice.Value = Common.GetMoney(findProduct.SellPrice);

                    if (celQuantity.Value != null)
                    {
                        decimal? quantity = Common.GetDecimalValue(celQuantity.Value + "");
                        decimal? price = Common.GetDecimalValue(celPrice.Value + "");
                        if (quantity != null && price != null)
                        {
                            DataGridViewTextBoxCell cellAmount = (DataGridViewTextBoxCell)dgvImport.Rows[currentcell.Y].Cells[INDEX_AMOUNT];
                            cellAmount.Value = Common.GetMoney(price * quantity);
                        }
                    }
                }
            }
        }
        

        private void dtpRefDate_ValueChanged(object sender, EventArgs e)
        {
            SetInvoiceNo(dtpRefDate.Value);
        }
        private void SetInvoiceNo(DateTime dt)
        {
            string invoice = Common.GetInvoiceNo(Constant.INVOICE_IMPORT, dtpRefDate.Value.Date);
            txtInvoiceNo.Text = Invoice.GetNextInvoice(invoice);
        }

        private void dgvImport_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < this.dgvImport.Rows.Count; i++)
            {
                decimal? amount = Common.GetDecimalValue(dgvImport.Rows[i].Cells[INDEX_AMOUNT].Value + "");
                if (amount != null)
                    sum += amount.Value;
            }

            txtAmount.Text = Common.GetMoney(sum);
            SetTotalAmount(sum);
        }
        private void SetTotalAmount(decimal sum)
        {
            decimal? discount = Common.GetDecimalValue(txtDiscount.Text);
            if (discount == null)
                discount = 0;

            txtTotalAmount.Text = Common.GetMoney(sum - discount * sum / 100); 
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal? sum = Common.GetDecimalValue(txtAmount.Text);
            if (sum == null)
                sum = 0;
            SetTotalAmount(sum.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    frmReport frm = new frmReport(Constant.KBN_IMPORT,  GetInvoice(), GetListInventoryHistory());
            //    frm.ShowDialog();

            //    Invoice findInvoice = Invoice.GetInvoice(txtInvoiceNo.Text);
            //    if (findInvoice != null)
            //    {
            //        dgvImport.Rows.Clear();
            //        SetInvoiceNo(dtpRefDate.Value);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    FormCommon.ShowWindowMessageError(ex.Message);
            //}

            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";

                try
                {
                    for (int i = 0; i < dgvImport.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvImport.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dgvImport.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvImport.Columns.Count; j++)
                        {
                            if (dgvImport.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvImport.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //xoa di , cap nhat lai 
            InventoryHistory.DeleteData(txtInvoiceNo.Text);
            btnImport_Click(sender, e);
            this.Close();
        }

        private void dgvImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
