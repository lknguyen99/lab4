using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = ProviderColumn.TABLE_NAME)]
    public class Provider : BaseDomain<Provider>, ICommonFunctions<Provider>
    {
        private string _ProviderID;
        private string _ProviderName;
        private string _Mobile;
        private string _Address;

        [ColumnAttribute(Name = ProviderColumn.ID, IsPrimaryKey = true, CanBeNull = false)]
        public string ProviderID
        {
            get { return _ProviderID; }
            set { _ProviderID = value; }
        }
        [ColumnAttribute(Name = ProviderColumn.NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string ProviderName 
        {
            get { return _ProviderName; }
            set { _ProviderName = value; }
        }
        [ColumnAttribute(Name = ProviderColumn.ADDRESS, IsPrimaryKey = false, CanBeNull = true)]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        [ColumnAttribute(Name = ProviderColumn.MOBILE, IsPrimaryKey = false, CanBeNull = true)]
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
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
        public Provider GetByPrimaryKey()
        {
            Table<Provider> table = GetTable();

            Provider item = table.Single(d => (d.ProviderID == this.ProviderID));
            if (item != null)
                item.Detach<Provider>();
            return item;
        }

        #endregion

        public static List<Provider> GetAllProvider()
        {
            return (from item in GetTable()
                    where
                     item.IsDeleted == null || item.IsDeleted == false
                    select item).ToList();
        }
    }


}
