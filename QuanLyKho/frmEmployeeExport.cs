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
    public partial class frmEmployeeExport : Form
    {
        public frmEmployeeExport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployeeExport_Load(object sender, EventArgs e)
        {
            FormCommon.SetEmployee(cmbEmployee, true);
            cmbEmployee.SelectedIndex = 0;

            chkMonth.Text = chkMonth.Text + string.Format(" {0:MM/yyyy}", DateTime.Now);
            chkMonth.Checked = true;
            //if (DateTime.Now.Day == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            //{
            //    chkMonth.Checked = true;
            //}
            Search(sender, e);
        }

        private void Search(object sender, EventArgs e)
        {
            List<EmployeeExport> List = EmployeeExport.GetEmployeeExport(Common.GetStringValue(cmbEmployee.SelectedValue), dtpDeliveryFrom.Value, dtpDeliveryTo.Value);
            BindGrid(List);
        }
        private void BindGrid(List<EmployeeExport> List)
        {
            dgvEmployee.Rows.Clear();
            for (int i = 0; i < List.Count; i++)
            {
                int row = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[row].Cells["No"].Value = i + 1;
                dgvEmployee.Rows[row].Cells["EmployeeID"].Value = List[i].EmployeeID;
                dgvEmployee.Rows[row].Cells["FullName"].Value = List[i].FullName;
                dgvEmployee.Rows[row].Cells["Mobile"].Value =List[i].Mobile;
                dgvEmployee.Rows[row].Cells["SumAmount"].Value = Common.GetMoney(List[i].SumAmount);
                dgvEmployee.Rows[row].Cells["SumTotalAmount"].Value = Common.GetMoney(List[i].SumTotalAmount);
                dgvEmployee.Rows[row].Cells["TotalInvoice"].Value =List[i].TotalInvoice;
                dgvEmployee.Rows[row].Cells["InvoiceNo"].Value =List[i].InvoiceNo;
            }


            this.dgvEmployee.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue; 
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

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(sender, e);
        }

        private void dtpDeliveryTo_ValueChanged(object sender, EventArgs e)
        {
            Search(sender, e);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
