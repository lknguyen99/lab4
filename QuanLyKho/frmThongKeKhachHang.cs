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
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
        {
            InitializeComponent();
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
            Search(sender, e);
        }
        private void Search(object sender, EventArgs e)
        {
            string customerID = ""; 
            if(cmbCustomer.SelectedIndex > 0)
               customerID = cmbCustomer.SelectedValue.ToString();

            List<CustomerAmount> list = CustomerAmount.GetAllCustomerAmount(customerID, dtpDeliveryFrom.Value, dtpDeliveryTo.Value);
            BindGrid(list);
        }

        private void chkMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonth.Checked)
            {
                DateTime now = DateTime.Now;
                dtpDeliveryFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpDeliveryTo.Value = dtpDeliveryFrom.Value.AddMonths(1).AddDays(-1);
            }

            Search(sender, e);
        }

        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            FormCommon.SetCustomer(cmbCustomer, true);
            if (chkMonth.Checked)
            {
                DateTime now = DateTime.Now;
                dtpDeliveryFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpDeliveryTo.Value = dtpDeliveryFrom.Value.AddMonths(1).AddDays(-1);
            }
            Search(sender, e);
        
        }

        private void BindGrid(List<CustomerAmount> List)
        {
            dgvCustomer.Rows.Clear();

            for (int i = 0; i < List.Count; i++)
            {
                int row = dgvCustomer.Rows.Add();
                dgvCustomer.Rows[row].Cells["No"].Value = i + 1;
                dgvCustomer.Rows[row].Cells["CustomerID"].Value = List[i].CustomerID;
                dgvCustomer.Rows[row].Cells["CustomerName"].Value = List[i].CustomerName;
                dgvCustomer.Rows[row].Cells["Mobile"].Value = List[i].Mobile;
                dgvCustomer.Rows[row].Cells["Address"].Value = List[i].Address;
                dgvCustomer.Rows[row].Cells["TotalAmount"].Value = Common.GetMoney(List[i].TotalAmount);
                dgvCustomer.Rows[row].Cells["InvoiceNo"].Value = List[i].InvoiceNo;

            }
            txtTotalAmount.Text = Common.GetMoney(List.Sum(p => p.TotalAmount));

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

        private void button1_Click(object sender, EventArgs e)
        {
            // lay thong tin khach hang 
            //try
            //{
            //    string customerID = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            //    List<Invoice> listInvoice = Invoice.GetListInvoiceByCustomerID(0, Constant.KBN_EXPORT, dtpDeliveryFrom.Value, dtpDeliveryTo.Value, customerID);
            //    List<InventoryHistory> list = new List<InventoryHistory>();
            //    foreach (Invoice i in listInvoice)
            //    {
            //        list.AddRange(InventoryHistory.GetInventoryListFromInvoice(i));
            //    }


            //    var results = InventoryHistory.GroupInventoryByProductUnit(list);

            //    Invoice temp = listInvoice[0];
            //    temp.InOutKbn = Constant.KBN_EXPORT_ALL;
            //    temp.Amount = listInvoice.Sum(p => p.Amount);
            //    temp.TotalAmount = listInvoice.Sum(p => p.TotalAmount);


            //    frmReport frm = new frmReport(listInvoice[0].InOutKbn.Value, listInvoice[0], results);
            //    frm.ShowDialog();
            //    Search(sender, e);

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
                    for (int i = 0; i < dgvCustomer.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvCustomer.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dgvCustomer.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvCustomer.Columns.Count; j++)
                        {
                            if (dgvCustomer.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvCustomer.Rows[i].Cells[j].Value.ToString();
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
        
    }
}
