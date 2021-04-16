using QuanlyKho.Util;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = InvoiceColumn.TABLE_NAME)]
    public class Invoice : BaseDomain<Invoice>, ICommonFunctions<Invoice>
    {
        private string _InvoiceNo;

        private DateTime _OrderDate;
        private DateTime _DeliveryDate;
        private int _StoreID;
        private Nullable<int> _InOutKbn;

        private System.Nullable<decimal> _Amount;
        private System.Nullable<double> _Discount;
        private System.Nullable<decimal> _TotalAmount;


        private string _CustomerID;
        private string _CustomerName;
        private string _EmployeeID;
        private string _EmployeeName;
        private string _Note;

        public string InvoiceType
        {
            get
            {
                if (InOutKbn == Constant.KBN_IMPORT)
                    return Constant.STR_IMPORT;
                else if (InOutKbn == Constant.KBN_EXPORT)
                    return Constant.STR_EXPORT;
                else if (InOutKbn == Constant.KBN_ORDER)
                    return Constant.STR_ORDER;
                return "";
            }
        }
        [ColumnAttribute(Name = InvoiceColumn.INVOICE_NO, IsPrimaryKey = true, CanBeNull = false)]
        public string InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.ORDER_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set { _OrderDate = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.DELIVERY_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public DateTime DeliveryDate
        {
            get { return _DeliveryDate; }
            set { _DeliveryDate = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.STORE_ID, IsPrimaryKey = false, CanBeNull = false)]
        public int StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }
       [ColumnAttribute(Name = InvoiceColumn.IN_OUT_KBN, IsPrimaryKey = false, CanBeNull = true)]
        public Nullable<int> InOutKbn
        {
            get { return _InOutKbn; }
            set { _InOutKbn = value; }
        }

        [ColumnAttribute(Name = InvoiceColumn.AMOUNT, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.DISCOUNT, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<double> Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.TOTAL_AMOUNT, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }

        [ColumnAttribute(Name = InvoiceColumn.CUSTOMER_ID, IsPrimaryKey = false, CanBeNull = true)]
        public string CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.CUSTOMER_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        [ColumnAttribute(Name = InvoiceColumn.EMPLOYEE_ID, IsPrimaryKey = false, CanBeNull = true)]
        public string EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.EMPLOYEE_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }
        [ColumnAttribute(Name = InvoiceColumn.NOTE, IsPrimaryKey = false, CanBeNull = true)]
        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
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
        public Invoice GetByPrimaryKey()
        {
            Table<Invoice> table = GetTable();

            Invoice item = table.Single(d => (d.InvoiceNo == this.InvoiceNo));
            if (item != null)
                item.Detach<Invoice>();
            return item;
        }
        #endregion

        public static List<Invoice> GetAllStore()
        {
            return (from item in GetTable()
                    where
                     item.IsDeleted == null || item.IsDeleted == false
                    select item).ToList();
        }
        public static Invoice GetInvoice(string InvoiceNo)
        {
            return (from item in GetTable()
                    where
                     item.InvoiceNo == InvoiceNo
                     &&
                     (item.IsDeleted == null || item.IsDeleted == false)
                    select item).FirstOrDefault();
        }
        public static List<Invoice> GetListInvoiceByEmployee(int storeID, int inOutKBN, DateTime fromDate, DateTime toDate, string employeeID)
        {
            return (from item in GetTable()
                    where
                    (
                     (storeID == 0 || item.StoreID == storeID)
                         &&   (employeeID == null || item.EmployeeID == employeeID)
                         && (inOutKBN == 0 || Convert.ToInt32(item.InOutKbn.Value) == inOutKBN)
                         && item.DeliveryDate.Date >= fromDate.Date
                         && item.DeliveryDate.Date <= toDate.Date
                         && (item.IsDeleted == null || item.IsDeleted == false)
                     )
                    select item).ToList();
        }
        public static List<Invoice> GetListInvoiceByCustomerID(int storeID, int inOutKBN, DateTime fromDate, DateTime toDate, string customerID)
        {
            return (from item in GetTable()
                    where
                    (
                     (storeID == 0 || item.StoreID == storeID)
                         && (customerID == null || item.CustomerID == customerID)
                         && (inOutKBN == 0 || Convert.ToInt32(item.InOutKbn.Value) == inOutKBN)
                         && item.DeliveryDate.Date >= fromDate.Date
                         && item.DeliveryDate.Date <= toDate.Date
                         && (item.IsDeleted == null || item.IsDeleted == false)
                     )
                    select item).ToList();
        }
        public static List<Invoice> GetInvoiceSearch(int storeID, int inOutKBN, DateTime fromDate, DateTime toDate)
        {
            return (from item in GetTable()
                    where
                    (
                         (storeID == 0 || item.StoreID == storeID)
                         && (inOutKBN == 0 || Convert.ToInt32(item.InOutKbn.Value) == inOutKBN)
                         && item.DeliveryDate.Date >= fromDate.Date 
                         && item.DeliveryDate.Date<= toDate.Date
                         && (item.IsDeleted == null || item.IsDeleted == false)
                     )
                     orderby item.DeliveryDate descending 
                    select item).ToList();
        }


        public static string GetNextInvoice(string prefix)
        {
            // HDX201608XXX
            string firstInvoice = 
                    (from item in GetTable()
                    where
                     item.InvoiceNo.StartsWith(prefix)
                     orderby item.InvoiceNo descending
                    select item.InvoiceNo).FirstOrDefault();

            // lay ra 4 digital 
            int no = 1; 
            if(firstInvoice != null)   
            {
                no = Convert.ToInt32(firstInvoice.Replace(prefix, ""));
                no++;
            }
             return prefix + no.ToString("000"); 
        }
    }







}
