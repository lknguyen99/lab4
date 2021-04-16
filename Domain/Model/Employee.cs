using QuanlyKho.Util;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = EmployeeColumn.TABLE_NAME)]
    public class Employee : BaseDomain<Employee>, ICommonFunctions<Employee>
    {
        private string _EmployeeID;
        private string _FirstName;
        private string _LastName;
        private string _FullName;

        private Nullable<DateTime> _BirthDay;
        private Nullable<DateTime> _StartWorkDate;

        private string _IDNo;
        private string _Mobile;
        private string _Address;
        private string _Email;
        private string _PositionName;  
        private string _ManagerID;
        private Nullable<decimal> _BasicSalary;

        [ColumnAttribute(Name = EmployeeColumn.EMPLOYEE_ID, IsPrimaryKey = true, CanBeNull = false)]
        public string EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.FIRST_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.LAST_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.FULL_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.BIRTH_DAY, IsPrimaryKey = false, CanBeNull = true)]
        public Nullable<DateTime> BirthDay
        {
            get { return _BirthDay; }
            set { _BirthDay = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.START_WORK, IsPrimaryKey = false, CanBeNull = true)]
        public Nullable<DateTime> StartWorkDate
        {
            get { return _StartWorkDate; }
            set { _StartWorkDate = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.ID_NO, IsPrimaryKey = false, CanBeNull = true)]
        public string IDNo
        {
            get { return _IDNo; }
            set { _IDNo = value; }
        }

        [ColumnAttribute(Name = EmployeeColumn.MOBILE, IsPrimaryKey = false, CanBeNull = true)]
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.ADDRESS, IsPrimaryKey = false, CanBeNull = true)]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.EMAIL, IsPrimaryKey = false, CanBeNull = true)]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [ColumnAttribute(Name = EmployeeColumn.POSITION_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string PositionName
        {
            get { return _PositionName; }
            set { _PositionName = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.MANAGERID, IsPrimaryKey = false, CanBeNull = true)]
        public string ManagerID
        {
            get { return _ManagerID; }
            set { _ManagerID = value; }
        }
        [ColumnAttribute(Name = EmployeeColumn.BASIC_SALARY, IsPrimaryKey = false, CanBeNull = true)]
        public Nullable<decimal> BasicSalary
        {
            get { return _BasicSalary; }
            set { _BasicSalary = value; }
        }

        [ColumnAttribute(Name = BaseColumn.IS_DELETED, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<bool> IsDeleted
        {
            get { return this._IsDeleted; }
            set { this._IsDeleted = value; }
        }

        [ColumnAttribute(Name = BaseColumn.CREATE_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public System.DateTime CreateDate
        {
            get { return this._CreateDate; }
            set { this._CreateDate = value; }
        }

        [ColumnAttribute(Name = BaseColumn.CREATE_USER, IsPrimaryKey = false, CanBeNull = false)]
        public string CreateUser
        {
            get { return this._CreateUser; }
            set { this._CreateUser = value; }
        }
        [ColumnAttribute(Name = BaseColumn.UPDATE_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public System.DateTime UpdateDate
        {
            get { return this._UpdateDate; }
            set { this._UpdateDate = value; }
        }
        [ColumnAttribute(Name = BaseColumn.UPDATE_USER, IsPrimaryKey = false, CanBeNull = false)]
        public string UpdateUser
        {
            get { return this._UpdateUser; }
            set { this._UpdateUser = value; }
        }

        #region ICommonFunction
        public Employee GetByPrimaryKey()
        {
            Table<Employee> table = GetTable();

            Employee item = table.Single(d => (d.EmployeeID == this.EmployeeID));
            if (item != null)
                item.Detach<Employee>();
            return item;
        }

        #endregion

        public Employee()
        {

        }
        public Employee(string id,string name)
        {
            EmployeeID = id;
            FullName = name;
        }
        public static List<Employee> GetAllEmployee()
        {
            return (from item in GetTable()
                    where
                     item.IsDeleted == null || item.IsDeleted == false
                    select item).ToList();
        }
        public static Employee GetEmployee(string employeeID)
        {
            return (from item in GetTable()
                    where
                        item.EmployeeID == employeeID 
                    && ( item.IsDeleted == null || item.IsDeleted == false)
                    select item).FirstOrDefault();
        }

        public static List<Employee> GetEmployeeSearch(Employee findObj)
        {
            return (from item in GetTable()
                    where
                     (
                           item.EmployeeID.Contains(findObj.EmployeeID)
                       && item.FirstName.Contains(findObj.FirstName)
                         && item.LastName.Contains(findObj.LastName)
                       && item.Mobile.Contains(findObj.Mobile)
                       && item.Address.Contains(findObj.Address)
                       && item.Email.Contains(findObj.Email)
                       && (item.IsDeleted == null || item.IsDeleted == false)
                     )
                    select item).ToList();
      
        }
    }

    public class EmployeeExport
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public decimal SumAmount { get; set; }
        public decimal SumTotalAmount { get; set; }
        public string InvoiceNo { get; set; }
        public int TotalInvoice { get; set; }
        public static List<EmployeeExport> GetEmployeeExport(string employeeID, DateTime fromDate, DateTime toDate)
        {
            List<EmployeeExport> list = new List<EmployeeExport>();
            var listEmployee = Employee.GetAllEmployee(); 
            foreach(Employee i in listEmployee)
            {
                var listInvoice = Invoice.GetListInvoiceByEmployee(0, Constant.KBN_EXPORT, fromDate, toDate, i.EmployeeID);

                EmployeeExport j = new EmployeeExport();
                j.EmployeeID = i.EmployeeID;
                j.FullName = i.FullName;
                j.Mobile = i.Mobile;
                j.SumAmount = 0;
                j.SumTotalAmount = 0; 

                j.InvoiceNo = "";
                j.TotalInvoice = 0;
                foreach(Invoice k in listInvoice)
                {
                    j.InvoiceNo += k.InvoiceNo + ";";
                    if(k.Amount!= null)
                        j.SumAmount += k.Amount.Value;
                    if(k.TotalAmount!= null)
                        j.SumTotalAmount += k.TotalAmount.Value;
                    j.TotalInvoice++;
                }
                list.Add(j);
            }
            return list.OrderByDescending(p => p.SumTotalAmount).ToList();
        }

    }
}

