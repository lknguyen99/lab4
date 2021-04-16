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
    public partial class frmListOrder : Form
    {
        public List<InventoryHistory> ListInventoryHistory = new List<InventoryHistory>();
        public frmListOrder()
        {
            InitializeComponent();
        }

        private void frmListOrder_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            int inoutKBN = 0; 
            if(chkOrder.Checked && !chkExport.Checked )
            {
                inoutKBN = Constant.KBN_ORDER;
            }
            if(chkExport.Checked && !chkOrder.Checked )
            {
                 inoutKBN = Constant.KBN_EXPORT;
            }
            List<InventoryHistory> list = InventoryHistory.GetInventoryOrderExport(dtpDeliveryFrom.Value, dtpDeliveryTo.Value, inoutKBN);
            ListInventoryHistory = InventoryHistory.GroupInventoryByProductUnit(list);
            FillGrid();
        }
        private void FillGrid()
        {
            dgvProduct.Rows.Clear();

            for (int i = 0; i < ListInventoryHistory.Count; i++)
            {
                int row = dgvProduct.Rows.Add();
                dgvProduct.Rows[row].Cells["No"].Value = i + 1;
                dgvProduct.Rows[row].Cells["ProductID"].Value = ListInventoryHistory[i].ProductID;
                dgvProduct.Rows[row].Cells["ProductName"].Value = ListInventoryHistory[i].ProductName;
                dgvProduct.Rows[row].Cells["UnitName"].Value = ListInventoryHistory[i].UnitName;
                dgvProduct.Rows[row].Cells["BuyPrice"].Value = Common.GetMoney(ListInventoryHistory[i].BuyPrice);
                dgvProduct.Rows[row].Cells["SellPrice"].Value = Common.GetMoney(ListInventoryHistory[i].SellPrice);

                dgvProduct.Rows[row].Cells["Quantity"].Value = Common.GetDefaultDecimalValue(ListInventoryHistory[i].Quantity) + Common.GetDefaultDecimalValue(ListInventoryHistory[i].QuantityOffer);
                dgvProduct.Rows[row].Cells["AmountBuy"].Value = Common.GetMoney(ListInventoryHistory[i].AmountBuy);
                dgvProduct.Rows[row].Cells["AmountSell"].Value = Common.GetMoney(ListInventoryHistory[i].AmountSell);
                dgvProduct.Rows[row].Cells["UnitID"].Value = ListInventoryHistory[i].UnitID;
            }

            txtProfit.Text = Common.GetMoney(ListInventoryHistory.Sum(p => p.AmountSell.Value - p.AmountBuy.Value));
        }

        private void dtpDeliveryFrom_ValueChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //frmReport frm = new frmReport(Constant.KBN_LIST_ORDER, null, ListInventoryHistory);
            //frm.ShowDialog();
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
                    for (int i = 0; i < dgvProduct.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgvProduct.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dgvProduct.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvProduct.Columns.Count; j++)
                        {
                            if (dgvProduct.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvProduct.Rows[i].Cells[j].Value.ToString();
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
