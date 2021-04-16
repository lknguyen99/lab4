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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                FormCommon.SetEmployee(cmbManager, true);
                FormCommon.SetPosition(cmbPositionName, true);
                BindGrid();
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Employee findObj = GetEmployee(null);
                List<Employee> list = Employee.GetEmployeeSearch(findObj);
                BindGrid(list);
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetEmployee(null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEmployeeID.Text == "")
                    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblEmployeeID.Text));


                Employee findObj = Employee.GetEmployee(txtEmployeeID.Text.Trim());

                if (findObj == null)
                {
                    findObj = GetEmployee(null);
                    findObj.CreateUser = "Admin";
                    findObj.Insert();
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_INSERT_SUCCESS"));
                    BindGrid();
                }
                else
                {
                    findObj = GetEmployee(findObj);
                    findObj.UpdateUser = "Admin";
                    findObj.Update();
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_UPDATE_SUCCESS"));
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEmployeeID.Text == "")
                    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblEmployeeID.Text));

                Employee findObj = Employee.GetEmployee(txtEmployeeID.Text.Trim());

                if (findObj != null)
                {
                    findObj.IsDeleted = true;
                    findObj.UpdateUser = "Admin";
                    findObj.Update();

                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_DELETE_SUCCESS"));
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectEmployee();
        }
        private void dgvEmployee_KeyUp(object sender, KeyEventArgs e)
        {
            SelectEmployee();
        }
        public Employee GetEmployee(Employee obj)
        {
            if(obj == null)
                 obj = new Employee();
            obj.EmployeeID = txtEmployeeID.Text;
            obj.FirstName = txtFirstName.Text;
            obj.LastName = txtLastName.Text;
            obj.FullName = obj.FirstName.TrimEnd() + " " + obj.LastName.TrimEnd();
            obj.Email = txtbEmail.Text;
            obj.Mobile = txtbDienThoai.Text;
            obj.Address = txtAddress.Text;
            obj.BasicSalary = Common.GetDecimalValue(txtBasicSalary.Text);
            obj.ManagerID = Common.GetStringValue(cmbManager.SelectedValue);
            obj.IDNo = txtIDNo.Text;
            obj.BirthDay = dtpBirthDay.Value;
            obj.StartWorkDate = dtpWorkDay.Value;
            return obj;
        }
        public void SetEmployee(Employee obj)
        {
            txtEmployeeID.Text = txtFirstName.Text = txtLastName.Text = txtbEmail.Text = txtbDienThoai.Text = txtAddress.Text = txtBasicSalary.Text = txtIDNo.Text = "";
            cmbManager.SelectedIndex = 0;

            if (obj != null)
            {
                txtEmployeeID.Text = obj.EmployeeID;
                txtFirstName.Text = obj.FirstName;
                txtLastName.Text = obj.LastName;
                txtbEmail.Text = obj.Email;
                if(obj.BirthDay!= null)
                   dtpBirthDay.Value = obj.BirthDay.Value;
                if (obj.StartWorkDate != null)
                    dtpWorkDay.Value = obj.StartWorkDate.Value;
                txtbDienThoai.Text = obj.Mobile;
                txtAddress.Text = obj.Address;
               
               txtBasicSalary.Text = Common.GetStringValue(obj.BasicSalary);
               txtIDNo.Text = obj.IDNo;

               if (!string.IsNullOrEmpty(obj.ManagerID))
                   cmbManager.SelectedValue = obj.ManagerID;
            }
        }

        private void SelectEmployee()
        {
            string customerID = dgvEmployee.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

            // dgvCustomer.Rows[row].Cells["CustomerID"].Value = List[i].CustomerID;
            Employee findCustomer = Employee.GetEmployee(customerID);
            if (findCustomer != null)
            {
                SetEmployee(findCustomer);
            }
        }
        private void BindGrid()
        {
            List<Employee> list = Employee.GetAllEmployee();
            BindGrid(list);
        }
        private void BindGrid(List<Employee> List)
        {
            dgvEmployee.Rows.Clear();

            for (int i = 0; i < List.Count; i++)
            {
                int row = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[row].Cells["No"].Value = i + 1;
                dgvEmployee.Rows[row].Cells["EmployeeID"].Value = List[i].EmployeeID;
                dgvEmployee.Rows[row].Cells["FullName"].Value = List[i].FullName;
                dgvEmployee.Rows[row].Cells["Mobile"].Value = List[i].Mobile;
                dgvEmployee.Rows[row].Cells["Email"].Value = List[i].Email;
                dgvEmployee.Rows[row].Cells["Address"].Value = List[i].Address;
                dgvEmployee.Rows[row].Cells["BasicSalary"].Value = Common.GetMoney(List[i].BasicSalary);
            }
            txtTotalSalary.Text = Common.GetMoney(List.Where(p => p.BasicSalary != null).Sum(p => p.BasicSalary));
            if (List.Count > 0)
                SelectEmployee();
        }

   
    }
}
