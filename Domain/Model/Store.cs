using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = StoreColumn.TABLE_NAME)]
    public class Store : BaseDomain<Store>, ICommonFunctions<Store>
    {
        private int _StoreID;
        private string _StoreName;
       
        private string _CompanyName;
        private string _MST;
        private string _Address;
        private string _Mobile;
        private string _Email;


        [ColumnAttribute(Name = StoreColumn.ID, IsPrimaryKey = true, CanBeNull = false)]
        public int StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }
        [ColumnAttribute(Name = StoreColumn.NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string StoreName
        {
            get { return _StoreName; }
            set { _StoreName = value; }
        }
        [ColumnAttribute(Name = StoreColumn.ADDRESS, IsPrimaryKey = false, CanBeNull = true)]
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
        [ColumnAttribute(Name = EmployeeColumn.MOBILE, IsPrimaryKey = false, CanBeNull = true)]
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
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
        [ColumnAttribute(Name = StoreColumn.MST, IsPrimaryKey = false, CanBeNull = true)]
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

        public Store()
        {
      
        }
        public Store(int id, string name)
        {
            StoreID = id;
            StoreName = name;
        }
        #region ICommonFunction
        public Store GetByPrimaryKey()
        {
            Table<Store> table = GetTable();

            Store item = table.Single(d => (d.StoreID == this.StoreID));
            if (item != null)
                item.Detach<Store>();
            return item;
        }
        #endregion

        public static List<Store> GetAllStore()
        {
            return (from item in GetTable()
                    where
                     item.IsDeleted == null || item.IsDeleted == false
                    select item).ToList();
        }
        public static Store GetStore(int storeID)
        {
            return (from item in GetTable()
                    where
                     item.StoreID == storeID
                     &&
                     (item.IsDeleted == null || item.IsDeleted == false)
                    select item).FirstOrDefault();
        }
    }







}
