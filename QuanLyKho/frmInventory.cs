
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
    public partial class frmInventory : Form
    {
        List<InventoryStore> listInventoryStore = new List<InventoryStore>();
        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportInventory frm = new frmImportInventory();
            frm.Show();

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            try
            {
                FormCommon.SetStore(cmbStore, false);
                chkCurrentMonth.Text = chkCurrentMonth.Text + string.Format(" {0:MM/yyyy}", DateTime.Now);

                chkCurrentMonth.Checked = true;
               
                BindGrid();
                
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    long inventoryID = Convert.ToInt64(dgvInventory.SelectedRows[0].Cells["InventoryID"].Value);
            //    DateTime refDate = Convert.ToDateTime(dgvInventory.SelectedRows[0].Cells["DeliveryDate"].Value);
            //    int storeID = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["StoreID"].Value);

            //    Inventory findInventory = Inventory.GetInventory(inventoryID, storeID);
            //    if (findInventory != null)
            //    {
            //        findInventory.Quantity = Common.GetDecimalValue(txtQuantity.Text);
            //        findInventory.QuantityOrder = Common.GetDecimalValue(txtQuantityOrder.Text);
            //        findInventory.BuyPrice = Common.GetDecimalValue(txtBuyPrice.Text);
            //        findInventory.SellPrice = Common.GetDecimalValue(txtSellPrice.Text);
            //        findInventory.Update();
            //        FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_UPDATE_SUCCESS"));
            //        BindGrid();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    FormCommon.ShowWindowMessageError(ex.Message);
            //}
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //long inventoryID = Convert.ToInt64(dgvInventory.SelectedRows[0].Cells["InventoryID"].Value);
            //DateTime refDate = Convert.ToDateTime(dgvInventory.SelectedRows[0].Cells["DeliveryDate"].Value);
            //int storeID = Convert.ToInt32(dgvInventory.SelectedRows[0].Cells["StoreID"].Value);
            //Inventory findInventory = Inventory.GetInventory(inventoryID, storeID);
            //if (findInventory != null)
            //{
            //    findInventory.IsDeleted = true;
            //    findInventory.Update();
            //    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_UPDATE_SUCCESS"));
            //    BindGrid();
            //}
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BindGrid()
        {
            btnUpdateInventory.Enabled = false;
            if (dtpDeliveryTo.Value.Date >= DateTime.Now.Date)
            {
                btnUpdateInventory.Enabled = true;
            }

            int storeID = Convert.ToInt32(cmbStore.SelectedValue);
            listInventoryStore = InventoryStore.GetListInventoryStore(storeID, dtpDeliveryFrom.Value, dtpDeliveryTo.Value);
            dgvInventory.Rows.Clear();

            
            btnGetInventory.Enabled = false;
            InventoryStore s = listInventoryStore.FirstOrDefault(p => p.QuantityInventory != p.Quantity);
            if (s != null)
            {
                btnGetInventory.Enabled = true;
            }

            for (int i = 0; i < listInventoryStore.Count; i++)
            {
                int row = dgvInventory.Rows.Add();
                dgvInventory.Rows[row].Cells["No"].Value = i + 1;
                dgvInventory.Rows[row].Cells["ProductID"].Value = listInventoryStore[i].ProductID;
                dgvInventory.Rows[row].Cells["ProductName"].Value = listInventoryStore[i].ProductName;
                dgvInventory.Rows[row].Cells["UnitName"].Value = listInventoryStore[i].UnitName;

                dgvInventory.Rows[row].Cells["QuantityLast"].Value = listInventoryStore[i].QuantityLast;
                dgvInventory.Rows[row].Cells["AmountLast"].Value =  Common.GetMoney(listInventoryStore[i].AmountLast);

                dgvInventory.Rows[row].Cells["QuantityImport"].Value = listInventoryStore[i].QuantityImport;
                dgvInventory.Rows[row].Cells["AmountImport"].Value =  Common.GetMoney(listInventoryStore[i].AmountImport);

                dgvInventory.Rows[row].Cells["QuantityExport"].Value = listInventoryStore[i].QuantityExport;
                dgvInventory.Rows[row].Cells["AmountExport"].Value = Common.GetMoney(listInventoryStore[i].AmountExport);


                dgvInventory.Rows[row].Cells["Quantity"].Value = listInventoryStore[i].Quantity;
                dgvInventory.Rows[row].Cells["QuantityInventory"].Value = listInventoryStore[i].QuantityInventory;

                if (listInventoryStore[i].Quantity != listInventoryStore[i].QuantityInventory)
                { 
                    dgvInventory.Rows[row].Cells["QuantityInventory"].Style.BackColor = System.Drawing.Color.OrangeRed;

                }

                dgvInventory.Rows[row].Cells["StoreID"].Value = listInventoryStore[i].StoreID;
                if(listInventoryStore[i].Quantity <=0 )
                    dgvInventory.DefaultCellStyle.BackColor = Color.Beige;
            }

            dgvInventory.Columns["QuantityLast"].DefaultCellStyle.BackColor = Color.PowderBlue;
            dgvInventory.Columns["AmountLast"].DefaultCellStyle.BackColor = Color.PowderBlue;

            dgvInventory.Columns["QuantityExport"].DefaultCellStyle.BackColor = Color.Azure;
            dgvInventory.Columns["AmountExport"].DefaultCellStyle.BackColor = Color.Azure;

            dgvInventory.Columns[1].ReadOnly = true;
            dgvInventory.Columns[11].ReadOnly = false;

        }
       
        private void btnExport_Click(object sender, EventArgs e)
        {
            frmExportInventory frm = new frmExportInventory();
            frm.Show();
        }
        private void chkCurrentMonth_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCurrentMonth.Checked)
            {
                dtpDeliveryFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpDeliveryTo.Value = dtpDeliveryFrom.Value.AddMonths(1).AddDays(-1);
            }
            BindGrid();
        }

        private void dtpDeliveryFrom_ValueChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int storeID = Convert.ToInt32(cmbStore.SelectedValue);
            List<InventoryStore> list = InventoryStore.GetListInventoryStore(storeID, dtpDeliveryFrom.Value, dtpDeliveryTo.Value);

            frmReport frm = new frmReport(dtpDeliveryFrom.Value, dtpDeliveryTo.Value, list);
            frm.ShowDialog();
         
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dig = FormCommon.ShowWindowMessageConfirm(Common.GetResouceString("CONFIRM_UPDATE"));
                if (dig == System.Windows.Forms.DialogResult.Yes)
                {
                    List<Inventory> listCurrentInv = Inventory.GetAllInventorySearch(0);
                    for (int i = 0; i < listInventoryStore.Count; i++)
                    {
                        int storeID = Convert.ToInt32(cmbStore.SelectedValue);
                        Inventory inv = listCurrentInv.FirstOrDefault(p => p.StoreID == storeID && p.ProductID == Common.GetStringValue(dgvInventory.Rows[i].Cells["ProductID"].Value));
                        if (inv != null &&  Common.GetDefaultDecimalValue(inv.Quantity) + Common.GetDefaultDecimalValue(inv.QuantityOrder) != Common.GetDefaultDecimalValue(dgvInventory.Rows[i].Cells["QuantityInventory"].Value))
                        {
                            inv.Quantity = Common.GetDefaultDecimalValue(dgvInventory.Rows[i].Cells["QuantityInventory"].Value) - Common.GetDefaultDecimalValue(inv.QuantityOrder);
                            inv.Update();
                        }
                    }
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_SUCCESS_EXPORT_INVENTORY"));
                }
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnGetInventory_Click(object sender, EventArgs e)
        {
            //lay gia tri thay doi ton kho tu kho chinh
            try
            {
                for (int i = 0; i < listInventoryStore.Count; i++)
                {
                    dgvInventory.Rows[i].Cells["QuantityInventory"].Value =   dgvInventory.Rows[i].Cells["Quantity"].Value;
                }
                FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_SUCCESS_EXPORT_INVENTORY"));
            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

       
    }
}
