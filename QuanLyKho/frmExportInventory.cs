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
    public partial class frmExportInventory : Form
    {
        public bool isExport = true;
        public bool isEditForm = false;
        //Some index
        public int INDEX_NO = 0;
        public int INDEX_ID = 1;
        public int INDEX_PRODUCT_NM = 2;
        public int INDEX_UNIT = 3;
        public int INDEX_QUANTITY = 4;

        public int INDEX_SELL_PRICE = 5;
        public int INDEX_AMOUNT = 6;

        public int INDEX_QUANTITY_OFFER = 7;
        public int INDEX_QUANTITY_MAX = 8;

        public List<Inventory> listInventory = new List<Inventory>();

        public frmExportInventory()
        {
            InitializeComponent();
        }
        public frmExportInventory(string invoiceNo)
        {
            try
            {
                InitializeComponent();
                isEditForm = true;

                Invoice findInvoice = Invoice.GetInvoice(invoiceNo);
                isExport = true;
                if (findInvoice.InOutKbn == Constant.KBN_ORDER)
                    isExport = false;


                List<InventoryHistory> list = InventoryHistory.GetInventoryListFromInvoice(findInvoice);
                listInventory = Inventory.GetAllProductFromStore(true, list[0].StoreID, -1);


                dgvExport.Rows.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    int row = dgvExport.Rows.Add();
                    dgvExport.Rows[row].Cells["No"].Value = i + 1;
                    dgvExport.Rows[row].Cells["ProductID"].Value = list[i].ProductID;
                    dgvExport.Rows[row].Cells["ProductName"].Value = list[i].ProductID;

                    dgvExport.Rows[row].Cells["UnitName"].Value = list[i].UnitID;
                    dgvExport.Rows[row].Cells["Quantity"].Value = list[i].Quantity;
                    dgvExport.Rows[row].Cells["SellPrice"].Value = Common.GetMoney(list[i].SellPrice);
                    dgvExport.Rows[row].Cells["AmountSell"].Value = Common.GetMoney(list[i].AmountSell);
                    dgvExport.Rows[row].Cells["QuantityOffer"].Value = list[i].QuantityOffer;
                    Inventory find = listInventory.Where(p => p.ProductID == list[i].ProductID).FirstOrDefault();
                    if (find != null)
                        dgvExport.Rows[row].Cells["MaxQuatity"].Value = find.Quantity - Common.GetDefaultDecimalValue(find.QuantityOrder) + list[i].Quantity + Common.GetDefaultDecimalValue(list[i].QuantityOffer);
                    else
                        dgvExport.Rows[row].Cells["MaxQuatity"].Value = list[i].QuantityOffer;
                }

                FormCommon.SetStore(cmbStore, false);
                FormCommon.SetEmployee(cmbEmployee, true);
                FormCommon.SetCustomer(cmbCustomer, true);
                dtpDeliveryDate.Value = findInvoice.DeliveryDate;
                dtpOrderDate.Value = findInvoice.DeliveryDate;

                cmbStore.SelectedValue = findInvoice.StoreID;
                txtNote.Text = findInvoice.Note;
                if (findInvoice.EmployeeID != null)
                {
                    cmbEmployee.SelectedValue = findInvoice.EmployeeID;
                    if (!string.IsNullOrEmpty(findInvoice.EmployeeID))
                        txtEmployeeMobile.Text = Employee.GetEmployee(findInvoice.EmployeeID).Mobile;
                    else
                        txtEmployeeMobile.Text = "";
                }
                else
                {
                    cmbCustomer.Text = findInvoice.CustomerName;
                }
                if (findInvoice.CustomerID != null)
                {
                    cmbCustomer.SelectedValue = findInvoice.CustomerID;
                    txtCustomerMobile.Text = Customer.GetCustomer(findInvoice.CustomerID).Mobile;
                }
                else
                    cmbEmployee.Text = findInvoice.EmployeeName;

                txtInvoiceNo.Text = findInvoice.InvoiceNo;
                txtInvoiceNo.Enabled = cmbStore.Enabled = false;
                btnEdit.Visible = true;
                btnImport.Enabled = false;
            }
            catch (Exception ex)
            { }

        }
        private void frmExportInventory_Load(object sender, EventArgs e)
        {
            try
            {
                if (!isEditForm)
                {
                    FormCommon.SetStore(cmbStore, false);
                    FormCommon.SetEmployee(cmbEmployee, true);
                    FormCommon.SetCustomer(cmbCustomer, true);
                    SetInvoiceNo(dtpDeliveryDate.Value);
                    listInventory = Inventory.GetAllProductFromStore(true, Convert.ToInt32(cmbStore.SelectedValue), 0);
                }




                List<Inventory> listInventoryFill = listInventory
                                          .GroupBy(p => p.ProductID)
                                          .Select(g => g.First())
                                          .ToList();

                DataGridViewComboBoxColumn cmbProduct = (DataGridViewComboBoxColumn)dgvExport.Columns[2];
                cmbProduct.DataSource = listInventoryFill;
                cmbProduct.ValueMember = "ProductID";
                cmbProduct.DisplayMember = "ProductName";
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }

        }
        private void LoadUnitFromProduct(string productID)
        {
            var currentcell = dgvExport.CurrentCellAddress;
            if (productID == " ")
            {
                DataGridViewTextBoxCell celProductId = (DataGridViewTextBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_ID];
                productID = celProductId.Value.ToString();

                DataGridViewComboBoxCell celProductName = (DataGridViewComboBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM];
                dgvExport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM].Value = productID;
            }

            DataGridViewComboBoxCell cmbUnit = (DataGridViewComboBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_UNIT];
            List<CodeName> listProductUnit = Product.GetListUnitFromProduct(productID);
            if (cmbUnit.DataSource == null || cmbUnit.Selected == false)
            {
                cmbUnit.DataSource = listProductUnit;
                cmbUnit.ValueMember = "Code";
                cmbUnit.DisplayMember = "Name";
            }
            if (listProductUnit.Count > 0)
            {
                dgvExport.Rows[currentcell.Y].Cells[INDEX_UNIT].Value = listProductUnit[0].Code;
            }
        }

        private void dgvExport_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvExport.Rows[e.RowIndex].Cells[INDEX_NO].Value = (e.RowIndex + 1).ToString();
        }

        private void dgvExport_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                if (dgvExport.CurrentCell.ColumnIndex == INDEX_PRODUCT_NM && e.Control is ComboBox)
                {
                    ComboBox combobox = e.Control as ComboBox;
                    combobox.DropDownStyle = ComboBoxStyle.DropDown;
                    combobox.SelectedIndexChanged += productName_SelectionChanged;
                    combobox.KeyPress += ProductName_KeyPress;

                }
                if (dgvExport.CurrentCell.ColumnIndex == INDEX_UNIT && e.Control is ComboBox)
                {
                    ComboBox combobox = e.Control as ComboBox;
                    combobox.SelectedIndexChanged += UnitName_SelectionChanged;

                }
                if (dgvExport.CurrentCell.ColumnIndex == INDEX_ID && e.Control is TextBox)
                {
                    TextBox txt = e.Control as TextBox;
                    txt.TextChanged += txtProductID_TextboxChanged;
                }
                if (dgvExport.CurrentCell.ColumnIndex == INDEX_QUANTITY && e.Control is TextBox)
                {
                    TextBox txt = e.Control as TextBox;
                    txt.TextChanged += txtQuantity_TextboxChanged;
                }
            }
            catch (Exception ex)
            {
                // FormCommon.ShowWindowMessageError(ex.Message);
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
                var currentcell = dgvExport.CurrentCellAddress;
                var sendingCB = sender as DataGridViewTextBoxEditingControl;
                SetProductOffer(currentcell.Y, null, Common.GetDecimalValue(sendingCB.Text + ""));
                SetAmount(sendingCB.Text + "");
            }
            catch (Exception ex)
            {
                // FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void productName_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var currentcell = dgvExport.CurrentCellAddress;
                var sendingCB = sender as DataGridViewComboBoxEditingControl;
                if (sendingCB.SelectedValue != null)
                {
                    LoadUnitFromProduct(sendingCB.SelectedValue.ToString());
                    SetValueFromProductID(sendingCB.SelectedValue.ToString(), "", true);
                }
            }
            catch (Exception ex)
            {
                // FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void txtProductID_TextboxChanged(object sender, EventArgs e)
        {
            try
            {
                var currentcell = dgvExport.CurrentCellAddress;
                var sendingTX = sender as DataGridViewTextBoxEditingControl;

                if (sendingTX != null)
                {
                    LoadUnitFromProduct(sendingTX.Text.ToString());
                    SetValueFromProductID(sendingTX.Text, "", false);
                }
            }
            catch (Exception ex)
            {
                // FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
        private void UnitName_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var currentcell = dgvExport.CurrentCellAddress;
                var sendingCB = sender as DataGridViewComboBoxEditingControl;
                if (sendingCB.SelectedValue != null)
                {
                    LoadUnitFromProduct("");
                    SetValueFromProductID("", sendingCB.SelectedValue.ToString(), true);
                }
            }
            catch (Exception ex)
            {
                // FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        void dgvExport_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvExport.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvExport.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        ((DataGridViewComboBoxColumn)dgvExport.Columns[e.ColumnIndex]).Items.Add(value);
                        e.ThrowException = false;
                    }
                }
            }
            catch
            {
            }
        }
        private void SetValueFromProductID(string productID, string unitID, bool isDropDownValue)
        {
            var currentcell = dgvExport.CurrentCellAddress;
            if (productID == "" || productID == "QuanLyKho.Domain.CodeName")
            {
                DataGridViewTextBoxCell celProductID = (DataGridViewTextBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_ID];
                productID = celProductID.Value + "";
            }
            if (unitID == "" || unitID == "QuanLyKho.Domain.CodeName" || unitID == "QuanLyKho.Domain.Inventory")
            {
                DataGridViewComboBoxCell celUnit = (DataGridViewComboBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_UNIT];
                if (celUnit != null)
                    unitID = celUnit.Value + "";
            }


            if (!string.IsNullOrEmpty(productID) && !string.IsNullOrEmpty(unitID))
            {
                var fProduct = Product.GetProduct(productID, unitID); // listInventory.FirstOrDefault(p => p.ProductID == productID && p.UnitID == unitID);              
                Inventory findProduct = listInventory.FirstOrDefault(p => p.ProductID == productID);

                if (findProduct != null)
                {
                    findProduct.SellPrice = fProduct.SellPrice;

                    if (isDropDownValue)
                    {
                        DataGridViewTextBoxCell celProductID = (DataGridViewTextBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_ID];
                        celProductID.Value = findProduct.ProductID;
                    }
                    else
                    {
                        DataGridViewComboBoxCell cel = (DataGridViewComboBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM];
                        cel.Value = findProduct.ProductID;
                    }

                    //DataGridViewTextBoxCell celUnit = (DataGridViewTextBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_UNIT];
                    //celUnit.Value = findProduct.UnitName;

                    DataGridViewTextBoxCell celPrice = (DataGridViewTextBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_SELL_PRICE];
                    celPrice.Value = Common.GetMoney(findProduct.SellPrice);

                    decimal maxQuantity = Common.GetDefaultDecimalValue(findProduct.Quantity);
                    if (findProduct.QuantityOrder != null)
                        maxQuantity = maxQuantity - findProduct.QuantityOrder.Value;

                    DataGridViewTextBoxCell celMaxQuantity = (DataGridViewTextBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_QUANTITY_MAX];
                    celMaxQuantity.Value = maxQuantity;
                    SetProductOffer(currentcell.Y, findProduct, null);
                    SetAmount(null);

                }
            }
        }
        private void SetProductOffer(int row, Inventory findProduct, decimal? quantity)
        {
            if (findProduct == null)
            {
                DataGridViewTextBoxCell celProduct = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_ID];
                findProduct = listInventory.FirstOrDefault(p => p.ProductID == celProduct.Value.ToString());
            }
            DataGridViewTextBoxCell celQuantity = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_QUANTITY];
            if (quantity == null)
                quantity = Common.GetDecimalValue(celQuantity.Value + "");


            DataGridViewTextBoxCell celQuantityOffer = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_QUANTITY_OFFER];
            celQuantityOffer.Value = "0";
            // mua 10 tang 1
            // mua 19 tang ?
            // mua 20 tang 2
            DataGridViewComboBoxCell celUnit = (DataGridViewComboBoxCell)dgvExport.Rows[row].Cells[INDEX_UNIT];

            Promotion findPromotion = Promotion.GetPromotionInfo(Constant.KBN_EXPORT, findProduct.ProductID, celUnit.Value.ToString(), dtpDeliveryDate.Value, quantity);

            if (findPromotion != null && findPromotion.QuantityBuy != null && findPromotion.QuantityOffer != null && quantity != null)
            {
                celQuantityOffer.Value = Promotion.GetQuantityOfferMin(findPromotion, quantity.Value).ToString();
            }
        }
        private void SetAmount(string valueChange)
        {
            string productID = "", unitID = "";
            var currentcell = dgvExport.CurrentCellAddress;

            DataGridViewComboBoxCell celUnit = (DataGridViewComboBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_UNIT];
            unitID = celUnit.Value + "";


            DataGridViewTextBoxCell celProductID = (DataGridViewTextBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_ID];
            productID = celProductID.Value + "";


            if (productID != "" && unitID != "")
            {
                int row = currentcell.Y;
                int col = currentcell.X;

                DataGridViewTextBoxCell cellAmount = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_AMOUNT];
                cellAmount.Value = "0";

                DataGridViewTextBoxCell celQuantity = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_QUANTITY];
                decimal quantity = Common.GetDefaultDecimalValue(celQuantity.Value + "");
                if (col == INDEX_QUANTITY)
                    quantity = Common.GetDefaultDecimalValue(valueChange);


                DataGridViewTextBoxCell celQuantityOffer = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_QUANTITY_OFFER];
                decimal quantityOffer = Common.GetDefaultDecimalValue(celQuantityOffer.Value + "");
                if (col == INDEX_QUANTITY_OFFER)
                    quantityOffer = Common.GetDefaultDecimalValue(valueChange);


                DataGridViewTextBoxCell celMaxQuantity = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_QUANTITY_MAX];
                decimal quantityMax = Common.GetDefaultDecimalValue(celMaxQuantity.Value + "");


                decimal quantityInput = quantity + quantityOffer;

                ProductUnit findUnitExchange = ProductUnit.GetUnitForProduct(productID, unitID);
                if (findUnitExchange != null)
                {
                    quantityInput = quantityInput * findUnitExchange.Quantity;
                }

                if (quantityInput > quantityMax)
                {
                    // celQuantity.Value = "0";
                    FormCommon.ShowWindowMessageError(Common.GetResouceString("MSG_OVER_QUANTIRY_IN_STORE"));
                }

                DataGridViewTextBoxCell celPrice = (DataGridViewTextBoxCell)dgvExport.Rows[row].Cells[INDEX_SELL_PRICE];
                decimal price = Common.GetDefaultDecimalValue(celPrice.Value + "");
                if (col == INDEX_SELL_PRICE)
                    price = Common.GetDefaultDecimalValue(valueChange);

                cellAmount.Value = Common.GetMoney(quantity * price);
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice invoice = GetInvoice();
                List<InventoryHistory> listInventoryExport = GetListInventoryHistory();
                if (listInventoryExport.Count() == 0 && isEditForm)
                {
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_SUCCESS_DELETE_EXPORT"));
                    return;
                }

                InventoryHistory.ExportData(listInventoryExport, invoice);
                FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_SUCCESS_EXPORT_INVENTORY"));

                dgvExport.Rows.Clear();
                listInventory = Inventory.GetAllProductFromStore(true, Convert.ToInt32(cmbStore.SelectedValue), 0);
                SetInvoiceNo(dtpDeliveryDate.Value);

            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }

        }
        private Invoice GetInvoice()
        {
            Invoice invoice = new Invoice();
            invoice.InvoiceNo = txtInvoiceNo.Text;
            invoice.StoreID = Convert.ToInt32(cmbStore.SelectedValue);
            invoice.EmployeeID = Common.GetStringValue(cmbEmployee.SelectedValue);
            invoice.EmployeeName = Common.GetStringValue(cmbEmployee.SelectedValue);
            invoice.CustomerID = Common.GetStringValue(cmbCustomer.SelectedValue);
            invoice.CustomerName = Common.GetStringValue(cmbCustomer.Text);
            invoice.OrderDate = dtpOrderDate.Value;
            invoice.DeliveryDate = dtpDeliveryDate.Value;
            invoice.Note = txtNote.Text;
            invoice.Amount = Common.GetDecimalValue(txtAmount.Text);
            if (isExport)
                invoice.InOutKbn = Constant.KBN_EXPORT;

            invoice.UpdateUser = invoice.CreateUser = "Admin";
            invoice.CreateDate = invoice.UpdateDate = DateTime.Now;
            invoice.Discount = 0;
            if (txtDiscount.Text != "")
                invoice.Discount = Common.GetDoubleValue(txtDiscount.Text) / 100;
            invoice.TotalAmount = Common.GetDecimalValue(txtSum.Text);

            return invoice;
        }
        private List<InventoryHistory> GetListInventoryHistory()
        {
            List<InventoryHistory> listInventoryExport = new List<InventoryHistory>();
            foreach (DataGridViewRow row in dgvExport.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[INDEX_ID].Value + ""))
                {

                    var findInventory = listInventory.FirstOrDefault(p => p.ProductID == row.Cells[INDEX_ID].Value.ToString());
                    if (findInventory == null)
                    {
                        throw new Exception(Common.GetResouceString("MSG_ERROR_INPUT_INVENTORY"));
                    }

                    InventoryHistory temp = new InventoryHistory();

                    temp.ProductID = findInventory.ProductID;
                    temp.ProductName = findInventory.ProductName;

                    temp.UnitID = row.Cells[INDEX_UNIT].Value.ToString();
                    temp.UnitName = Unit.GetUnit(temp.UnitID).UnitName;

                    temp.Quantity = Common.GetDecimalValue(row.Cells[INDEX_QUANTITY].Value + "");
                    temp.QuantityOffer = Common.GetDecimalValue(row.Cells[INDEX_QUANTITY_OFFER].Value + "");

                    Promotion findPromotion = Promotion.GetPromotionInfo(Constant.KBN_EXPORT, temp.ProductID, temp.UnitID, dtpDeliveryDate.Value, temp.Quantity);
                    if (findPromotion != null)
                    {
                        temp.QuantityOfferUnit = findPromotion.QuantityOfferUnit;
                    }

                    if (temp.Quantity == null || temp.Quantity.Value <= 0)
                    {

                        throw new Exception(Common.GetResouceString("MSG_ERROR_INPUT_QUANTITY"));
                    }

                    temp.SellPrice = Common.GetDecimalValue(row.Cells[INDEX_SELL_PRICE].Value + "");
                    temp.AmountSell = Common.GetDecimalValue(row.Cells[INDEX_AMOUNT].Value + "");

                    temp.CreateUser = temp.UpdateUser = "Admin";
                    temp.UpdateDate = temp.CreateDate = DateTime.Now;

                    listInventoryExport.Add(temp);
                }
            }
            return listInventoryExport;
        }
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerID = Common.GetStringValue(cmbCustomer.SelectedValue);
            Customer findCustomer = Customer.GetCustomer(customerID);
            txtCustomerMobile.Text = txtCustomerAddress.Text = "";
            if (findCustomer != null)
            {
                txtCustomerMobile.Text = findCustomer.Mobile;
                txtCustomerAddress.Text = findCustomer.Address;
            }
            SetInvoiceNo(dtpDeliveryDate.Value);
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employeeID = Common.GetStringValue(cmbEmployee.SelectedValue);
            Employee findEmployee = Employee.GetEmployee(employeeID);
            txtEmployeeMobile.Text = "";
            if (findEmployee != null)
                txtEmployeeMobile.Text = findEmployee.Mobile;
        }
        private void SetInvoiceNo(DateTime dt)
        {
            if (!isExport)
            {
                this.lblTitle.Text = Common.GetResouceString("TITLE_FORM_ORDER");
                this.btnImport.Text = Common.GetResouceString("BUTTON_NEW_ORDER");
            }
            Customer findCus = Customer.GetCustomer(Common.GetStringValue(cmbCustomer.SelectedValue));
            string prefix = Common.GetInvoiceNo(Constant.INVOICE_EXPORT, dtpDeliveryDate.Value.Date);

            if (findCus != null && !string.IsNullOrEmpty(findCus.PrefixBillNo))
            {
                prefix = Common.GetInvoiceNo(findCus.PrefixBillNo, dtpDeliveryDate.Value.Date);
            }

            // invoice = Common.GetInvoiceNo(Constant.INVOICE_EXPORT, dtpDeliveryDate.Value.Date);
            txtInvoiceNo.Text = Invoice.GetNextInvoice(prefix);
        }

        private void dgvExport_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < this.dgvExport.Rows.Count; i++)
            {
                decimal? amount = Common.GetDecimalValue(dgvExport.Rows[i].Cells[INDEX_AMOUNT].Value + "");
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

            txtSum.Text = Common.GetMoney(sum - discount * sum / 100);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal? sum = Common.GetDecimalValue(txtAmount.Text);
            if (sum == null)
                sum = 0;
            SetTotalAmount(sum.Value);
        }
        private void copyAlltoClipboard()
        {
            dgvExport.SelectAll();
            DataObject dataObj = dgvExport.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    frmReport frm = new frmReport(Constant.KBN_EXPORT, GetInvoice(), GetListInventoryHistory());
            //    frm.ShowDialog();

            //    Invoice findInvoice = Invoice.GetInvoice(txtInvoiceNo.Text);
            //    if (findInvoice != null)
            //    {
            //        dgvExport.Rows.Clear();
            //        listInventory = Inventory.GetAllProductFromStore(true, Convert.ToInt32(cmbStore.SelectedValue), 0);
            //        SetInvoiceNo(dtpDeliveryDate.Value);
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
                    for (int i = 0; i < dgvExport.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvExport.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dgvExport.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvExport.Columns.Count; j++)
                        {
                            if (dgvExport.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvExport.Rows[i].Cells[j].Value.ToString();
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

        private void dtpDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            SetInvoiceNo(dtpDeliveryDate.Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //xoa di , cap nhat lai 
            InventoryHistory.DeleteData(txtInvoiceNo.Text);
            btnExport_Click(sender, e);

            this.Close();
        }

        private void cmbCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomer.Text != "" && cmbCustomer.SelectedIndex == -1)
                {
                    List<Customer> list = Customer.GetAllCustomer().Where(p => p.CustomerName.ToLower().Contains(cmbCustomer.Text.ToLower())).ToList();
                    cmbCustomer.DataSource = list;
                }
            }
            catch
            { }
        }


        private void ProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var currentcell = dgvExport.CurrentCellAddress;
                DataGridViewComboBoxCell celProduct = (DataGridViewComboBoxCell)dgvExport.Rows[currentcell.Y].Cells[INDEX_PRODUCT_NM];
                var sendingCB = sender as DataGridViewComboBoxCell;
                string textsearch = (sendingCB == null) ? "" : sendingCB.Value.ToString();

                string name = string.Format("{0}{1}", textsearch, e.KeyChar.ToString());
                List<Inventory> listInventorySearch = listInventory.FindAll(p => p.ProductName.ToLower().Contains(name.ToLower()));

                listInventorySearch.Insert(0, new Inventory());
                if (listInventorySearch.Count > 1)
                {
                    celProduct.ValueMember = "ProductID";
                    celProduct.DisplayMember = "ProductName";
                    celProduct.DataSource = listInventorySearch;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                List<Customer> list = Customer.GetAllCustomer();
                string name = string.Format("{0}{1}", cmbCustomer.Text, e.KeyChar.ToString()); //join previous text and new pressed char

                List<Customer> listSearch = list.FindAll(p => p.CustomerName.ToLower().Contains(name.ToLower()));
                listSearch.Insert(0, new Customer("", ""));

                if (listSearch.Count > 1)
                {
                    cmbCustomer.DataSource = null;
                    cmbCustomer.DisplayMember = "CustomerName";
                    cmbCustomer.ValueMember = "CustomerID";
                    cmbCustomer.DataSource = listSearch;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtCustomerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvExport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
