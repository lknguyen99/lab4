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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.Show();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportInventory frm = new frmImportInventory();
            frm.ShowDialog();

            Search(sender, e);
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory frm = new frmInventory();
            frm.ShowDialog();

        
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportInventory frm = new frmExportInventory();
            frm.ShowDialog();

            Search(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                FormCommon.SetStatus(cmbStatus);
                cmbStatus.SelectedIndex = 0;

                chkMonth.Text = chkMonth.Text + string.Format(" {0:MM/yyyy}", DateTime.Now);
                if (DateTime.Now.Day == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
                {
                    chkMonth.Checked = true;
                    cmbStatus.SelectedIndex = 0;
                }
                Search(sender, e);
            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
       
        private void BindGrid(List<Invoice> List)
        {
            dgvInvoice.Rows.Clear();
            for (int i = 0; i < List.Count; i++)
            {
                int row = dgvInvoice.Rows.Add();
                dgvInvoice.Rows[row].Cells["No"].Value = i + 1;
                dgvInvoice.Rows[row].Cells["InvoiceType"].Value = List[i].InvoiceType; 
                dgvInvoice.Rows[row].Cells["InvoiceNo"].Value = List[i].InvoiceNo;
                dgvInvoice.Rows[row].Cells["OrderDate"].Value = Common.GetShortDate(List[i].OrderDate);
                dgvInvoice.Rows[row].Cells["DeliveryDate"].Value = Common.GetShortDate(List[i].DeliveryDate);
                dgvInvoice.Rows[row].Cells["Amount"].Value = Common.GetMoney(List[i].Amount);
                dgvInvoice.Rows[row].Cells["DiscountPercent"].Value = (List[i].Discount * 100) + " %";
                dgvInvoice.Rows[row].Cells["TotalAmount"].Value = Common.GetMoney(List[i].TotalAmount);

                if(List[i].InvoiceNo.Contains(Constant.INVOICE_IMPORT))
                {
                    Employee findEmployee = Employee.GetEmployee(List[i].EmployeeID + "");
                    if (findEmployee != null)
                        dgvInvoice.Rows[row].Cells["FullName"].Value = findEmployee.FullName;
                }
                else
                {
                    Customer findCustomer = Customer.GetCustomer(List[i].CustomerID + "");
                    if (findCustomer != null)
                        dgvInvoice.Rows[row].Cells["FullName"].Value = findCustomer.CustomerName;
                }
                dgvInvoice.Rows[row].Cells["StoreName"].Value = Store.GetStore(List[i].StoreID).StoreName;
                dgvInvoice.Rows[row].Cells["Note"].Value = List[i].Note;

                if (cmbStatus.SelectedIndex == 0)
                {
                    if (List[i].InOutKbn == Constant.KBN_ORDER)
                    {
                        dgvInvoice.Rows[row].DefaultCellStyle.BackColor = Color.Wheat;
                    }
                    else if (List[i].InOutKbn == Constant.KBN_IMPORT)
                    {
                        dgvInvoice.Rows[row].DefaultCellStyle.BackColor = Color.PowderBlue;
                    }
                }
            }

            var listOrder = List.Where(p => p.InOutKbn == Constant.KBN_ORDER);
            lblOrder.Text = string.Format(Common.GetResouceString("TEXT_TOTAL_ORDER"), listOrder.Count());
            txtTotalOrder.Text = Common.GetMoney(listOrder.Where(p => p.TotalAmount != null).Sum(p => p.TotalAmount));


            var listExport = List.Where(p =>  p.InOutKbn == Constant.KBN_EXPORT);
            lblExport.Text = string.Format(Common.GetResouceString("TEXT_TOTAL_EXPORT"), listExport.Count());
            decimal? totalExport = listExport.Where(p => p.TotalAmount != null).Sum(p => p.TotalAmount);
            txtTotalExport.Text = Common.GetMoney(totalExport);

            var listImport= List.Where(p => p.InOutKbn == Constant.KBN_IMPORT);
            lblImport.Text = string.Format(Common.GetResouceString("TEXT_TOTAL_IMPORT"), listImport.Count());
            decimal? totalImport = listImport.Where(p => p.TotalAmount != null).Sum(p => p.TotalAmount);
            txtTotalImport.Text = Common.GetMoney(totalImport);
            
            decimal Profit = ((totalExport == null ? 0 : totalExport.Value) - (totalImport == null ? 0 : totalImport.Value));
            if(Profit <0) 
                txtProfit.Text = "(" + Common.GetMoney(Math.Abs(Profit)) + ")"; 
            else 
                txtProfit.Text = Common.GetMoney(Profit);

            lblSumAmount.Text = lblSumTotalAmount.Text = ""; 
            if(cmbStatus.SelectedIndex != 0)
            {
                lblSumAmount.Text = Common.GetMoney(List.Where(p => p.Amount != null).Sum(p => p.Amount));
                lblSumTotalAmount.Text = Common.GetMoney(List.Where(p => p.TotalAmount != null).Sum(p => p.TotalAmount)); 
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try 
            {
                frmExportInventory frm = new frmExportInventory();
                frm.isExport = false;  // THEM ORDER 
                frm.Show();
                Search(sender, e);
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void chkMonth_CheckedChanged(object sender, EventArgs e)
        {
            if(chkMonth.Checked)
            {
                DateTime now = DateTime.Now;
                dtpDeliveryFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpDeliveryTo.Value = dtpDeliveryFrom.Value.AddMonths(1).AddDays(-1);
                cmbStatus.SelectedIndex = 0;
            }

            Search(sender, e);
        }
        private void Search(object sender, EventArgs e)
        {
            List<Invoice> list = Invoice.GetInvoiceSearch(0, Convert.ToInt32(cmbStatus.SelectedValue), dtpDeliveryFrom.Value, dtpDeliveryTo.Value);
            BindGrid(list);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string invoiceNo = dgvInvoice.CurrentRow.Cells[2].Value.ToString();
            //    Invoice findInvoice = Invoice.GetInvoice(invoiceNo);
            //    if (findInvoice == null)
            //        throw new Exception("Vui lòng chọn lại item");
            //    frmReport frm = new frmReport(findInvoice.InOutKbn.Value, findInvoice, InventoryHistory.GetInventoryListFromInvoice(findInvoice));
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
                    for (int i = 0; i < dgvInvoice.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvInvoice.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dgvInvoice.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvInvoice.Columns.Count; j++)
                        {
                            if (dgvInvoice.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvInvoice.Rows[i].Cells[j].Value.ToString();
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

        private void chươngTrìnhKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPromotion frm = new frmPromotion();
            frm.ShowDialog();
        }

        private void quảnLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeExport frm = new frmEmployeeExport();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string invoiceNo = dgvInvoice.CurrentRow.Cells[2].Value.ToString();
            if (!invoiceNo.StartsWith(Constant.INVOICE_IMPORT))
            {
                frmExportInventory frm = new frmExportInventory(invoiceNo);
                frm.ShowDialog();
            }
            else 
            {
                frmImportInventory frm = new frmImportInventory(invoiceNo);
                frm.ShowDialog();
            }
            Search(sender, e);
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SetRow();
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void SetRow()
        {
            string InvoiceType = dgvInvoice.SelectedRows[0].Cells["InvoiceType"].Value.ToString();
            //btnEdit.Enabled = false;
            //if(InvoiceType == Constant.STR_ORDER || InvoiceType == Constant.STR_EXPORT)
            //{
            //    btnEdit.Enabled = true;
            //}
        }

        private void dgvInvoice_KeyUp(object sender, KeyEventArgs e)
        {
            SetRow();
        }

        private void dgvInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            SetRow();
        }

        private void thốngKêKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeKhachHang frm = new frmThongKeKhachHang();
            frm.ShowDialog();
        }

        private void xemDanhSáchĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOrder frm = new frmListOrder();
            frm.ShowDialog();
        }
    }
}
