using QuanlyKho.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QuanLyKho.Domain
{
    [Table(Name = CustomerColumn.TABLE_NAME)]
    public class Customer : BaseDomain<Customer>, ICommonFunctions<Customer>
    {

        private string _CustomerID;
        private string _CustomerName;
        private string _Address;
        private string _Mobile;
        private string _Email;
        private string _CompanyName;
        private string _MST;
        private string _PrefixBillNo;
        private string _Note;

        private System.Nullable<bool> _IsDebt;


        public Customer()
        {
            
        }
        public Customer(string id, string name)
        {
            CustomerID = id;
            CustomerName = name;
        }

        #region property 

        [ColumnAttribute(Name = CustomerColumn.CUSTOMER_ID, IsPrimaryKey = true, CanBeNull = false)]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                  this._CustomerID = value;
            }
        }

        [ColumnAttribute(Name = CustomerColumn.CUSTOMER_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string CustomerName
        {
            get
            {
                return this._CustomerName;
            }
            set
            {
                this._CustomerName = value;
            }
        }

        [ColumnAttribute(Name = CustomerColumn.ADDRESS, IsPrimaryKey = false, CanBeNull = true)]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
            }
        }


        [ColumnAttribute(Name = CustomerColumn.MOBILE, IsPrimaryKey = false, CanBeNull = true)]
        public string Mobile
        {
            get
            {
                return this._Mobile;
            }
            set
            {
                this._Mobile = value;
            }
        }

        [ColumnAttribute(Name = CustomerColumn.EMAIL, IsPrimaryKey = false, CanBeNull = true)]
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = value;
            }
        }

        [ColumnAttribute(Name = CustomerColumn.COMPANY_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string CompanyName
        {
            get
            {
                return this._CompanyName;
            }
            set
            {
                this._CompanyName = value;
            }
        }
        [ColumnAttribute(Name = CustomerColumn.MST, IsPrimaryKey = false, CanBeNull = true)]
        public string MST
        {
            get
            {
                return this._MST;
            }
            set
            {
                this._MST = value;
            }
        }
        [ColumnAttribute(Name = CustomerColumn.PrefixBillNo, IsPrimaryKey = false, CanBeNull = true)]
        public string PrefixBillNo
        {
            get
            {
                return this._PrefixBillNo;
            }
            set
            {
                this._PrefixBillNo = value;
            }
        }

        [ColumnAttribute(Name = CustomerColumn.NOTE, IsPrimaryKey = false, CanBeNull = true)]
        public string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this._Note = value;
            }
        }


        [ColumnAttribute(Name = CustomerColumn.IS_DEBT, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<bool> IsDebt
        {
            get
            {
                return this._IsDebt;
            }
            set
            {
                this._IsDebt = value;
            }
        }

        [ColumnAttribute(Name = BaseColumn.IS_DELETED, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<bool> IsDeleted
        {
            get  { return this._IsDeleted;  }
            set  { this._IsDeleted = value;  }
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
            get  {   return this._CreateUser; }
            set  {    this._CreateUser = value; }
        }
        [ColumnAttribute(Name = BaseColumn.UPDATE_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public System.DateTime UpdateDate
        {
            get  {  return this._UpdateDate;  }
            set  { this._UpdateDate = value;  }
        }
        [ColumnAttribute(Name = BaseColumn.UPDATE_USER, IsPrimaryKey = false, CanBeNull = false)]
        public string UpdateUser
        {
            get  { return this._UpdateUser;  }
            set  { this._UpdateUser = value; }
        }
        #endregion

        #region ICommonFunction
        public Customer GetByPrimaryKey()
        {
            Table<Customer> table = GetTable();

            Customer item = table.Single(d => (d.CustomerID == this.CustomerID));
            if (item != null)
                item.Detach<Customer>();
            return item;
        }

        public static Customer GetCustomer(string customerID)
        {
            return (from item in GetTable()
                    where 
                    ( item.CustomerID == customerID
                    && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    select item).FirstOrDefault();
        }
        public static string GetNextCustomer()
        {
            string result = Constant.STR_KH + "00001"; 
            string customerID = (from item in GetTable()
                       orderby item.CustomerID descending
                       select item.CustomerID).FirstOrDefault();

            if (customerID != null)
            {
                int nextID = Convert.ToInt32(customerID.Replace(Constant.STR_KH, "")) + 1;
                result = string.Format("{0}{1}", Constant.STR_KH, nextID.ToString("00000"));
            }

            return result;
        }
        public static List<Customer> GetCustomerSearch(Customer search)
        {
            return (from item in GetTable()
                    where 
                     (
                           item.CustomerID.Contains(search.CustomerID)
                       && item.CustomerName.Contains(search.CustomerName)
                       && item.Mobile.Contains(search.Mobile)
                       && item.CompanyName.Contains(search.CompanyName)
                       && item.Address.Contains(search.Address)
                       && item.Note.Contains(search.Note)
                       && (item.IsDeleted == null || item.IsDeleted== false)
                     )
                     select item).ToList();
        }
        public static List<Customer> GetAllCustomer()
        {
            return (from item in GetTable()
                    where 
                     item.IsDeleted == null || item.IsDeleted== false
                    select item).ToList();
        }


        #endregion

    }

    public class CustomerAmount : Customer
    {
        public string InvoiceNo { get; set; }
        public decimal TotalAmount { get; set; }

        public CustomerAmount()
        {

        }

        public static List<CustomerAmount> GetAllCustomerAmount(string customerID, DateTime fromDate , DateTime toDate)
        {
            List<CustomerAmount> list = new List<CustomerAmount>();
            var context = new DBContext();
            list =
                    (from item in context.GetTable<Customer>()
                     from item2 in context.GetTable<Invoice>()
                     where
                     (
                          item.CustomerID == item2.CustomerID
                         && (item.IsDeleted == null || item.IsDeleted == false)
                         && (customerID == "" || item.CustomerID == customerID)
                         && (item2.DeliveryDate.Date >= fromDate.Date  && item2.DeliveryDate.Date <= toDate.Date)
                         && item2.InOutKbn == Constant.KBN_EXPORT
                     )
                     orderby item2.InvoiceNo
                     select new CustomerAmount()
                     {
                         CustomerID = item.CustomerID,
                         CustomerName = item.CustomerName,
                         Mobile = item.Mobile,
                         InvoiceNo = item2.InvoiceNo,
                         Address = item.Address,
                         TotalAmount = item2.TotalAmount.Value,
                     }
                     ).ToList();

            //filter again 
            if(customerID == "")  // gom nhom lai 
            {
                List<CustomerAmount> listReturn = new List<CustomerAmount>();
                Hashtable hash = new Hashtable(); 
                foreach(CustomerAmount i in list)
                {
                    /////////////////////////
                    if(!hash.ContainsKey(i.CustomerID))
                    {
                        hash.Add(i.CustomerID,  i); 
                    }
                    else
                    {
                        CustomerAmount temp = (CustomerAmount)hash[i.CustomerID];
                        temp.TotalAmount += i.TotalAmount;
                        temp.InvoiceNo += ", " + i.InvoiceNo;
                        hash[i.CustomerID] = temp;
                    }
                }
                /// filter again 
                foreach(string i in hash.Keys)
                {
                    listReturn.Add((CustomerAmount)hash[i]);
                }
                return listReturn;
            }
            else 
            {
                return list;
            }
        }
    }
}
