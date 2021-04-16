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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid();

            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Customer findObj = GetCutomer();
                List<Customer> list = Customer.GetCustomerSearch(findObj);
                BindGrid(list);
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            SetCutomer(null);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               // if (lblCustomerID.Text == "")
                //    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblCustomerID.Text));
                string nextCustomer = Customer.GetNextCustomer();
                txtbMaKhach.Text = nextCustomer;
                Customer findObj = GetCutomer();
                findObj.CreateUser = "Admin";
                findObj.Insert();

                FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_INSERT_SUCCESS"));
                BindGrid();
            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCustomerID.Text == "")
                    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblCustomerID.Text));

                Customer findObj = Customer.GetCustomer(txtbMaKhach.Text.TrimEnd());
               
                if (findObj == null)
                {
                    findObj = GetCutomer();
                    findObj.CustomerID = Customer.GetNextCustomer();
                    findObj.CreateUser = "Admin";
                    findObj.Insert();
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_INSERT_SUCCESS"));
                    BindGrid();
                }
                else
                {
                    findObj.CustomerName = txtbTenKhach.Text.TrimEnd();
                    findObj.Address = txtbDiaChi.Text;
                    findObj.CompanyName = txtbCongTy.Text;
                    findObj.Mobile = txtbDienThoai.Text;
                    findObj.Email = txtbEmail.Text;
                    findObj.Note = txtNote.Text;
                    findObj.PrefixBillNo = txtPrefixInvoice.Text;
                    findObj.UpdateUser = "Admin";
                    findObj.Update();
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_UPDATE_SUCCESS"));
                    BindGrid();
                }
            }
            catch(Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCustomerID.Text == "")
                    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblCustomerID.Text));

                Customer findObj = Customer.GetCustomer(txtbMaKhach.Text.TrimEnd());

                if (findObj != null)
                {
                    findObj.IsDeleted = true;
                    findObj.UpdateUser = "ABC";
                    findObj.Update();
                    findObj.Delete();
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_DELETE_SUCCESS"));
                    BindGrid();
                }



            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }


        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectCustomer();
        }
        private void dgvCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            SelectCustomer();
        }
        public Customer GetCutomer()
        {
            Customer cus = new Customer();
            cus.CustomerID = txtbMaKhach.Text.TrimEnd();
            cus.CustomerName = txtbTenKhach.Text.TrimEnd();
            cus.Address = txtbDiaChi.Text;
            cus.CompanyName = txtbCongTy.Text;
            cus.Mobile = txtbDienThoai.Text;
            cus.Email = txtbEmail.Text;
            cus.PrefixBillNo = txtPrefixInvoice.Text;
            cus.Note = txtNote.Text;
            return cus;
        }
        public void SetCutomer(Customer cus)
        {
            txtbMaKhach.Text = txtbTenKhach.Text = txtNote.Text = txtbEmail.Text = txtbDienThoai.Text = txtbDiaChi.Text = txtbCongTy.Text = "";

            if(cus!=null)
            {
                txtbMaKhach.Text = cus.CustomerID;
                txtbTenKhach.Text = cus.CustomerName;
                txtbDiaChi.Text = cus.Address;
                txtbCongTy.Text = cus.CompanyName;
                txtbDienThoai.Text = cus.Mobile;
                txtbEmail.Text = cus.Email;
                txtNote.Text = cus.Note;
                txtPrefixInvoice.Text = cus.PrefixBillNo;
            }
        }

        private void SelectCustomer()
        {
            string customerID = dgvCustomer.SelectedRows[0].Cells["CustomerID"].Value.ToString();

            // dgvCustomer.Rows[row].Cells["CustomerID"].Value = List[i].CustomerID;
            Customer findCustomer = Customer.GetCustomer(customerID);
            if (findCustomer != null)
            {
                SetCutomer(findCustomer);
            }
        }
        private void BindGrid()
        {
            List<Customer> list = Customer.GetAllCustomer();
            BindGrid(list);
        }
        private void BindGrid(List<Customer> List)
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
                dgvCustomer.Rows[row].Cells["Email"].Value = List[i].Email;
                dgvCustomer.Rows[row].Cells["PrefixBillNo"].Value = List[i].PrefixBillNo;
            }
            if (List.Count > 0)
                SelectCustomer();
        }

        private void txtbMaKhach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
