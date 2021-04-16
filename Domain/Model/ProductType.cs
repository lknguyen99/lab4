using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Collections;

namespace QuanLyKho.Domain
{
    [Table(Name = ProductTypeColumn.TABLE_NAME)]
    public class ProductType : BaseDomain<ProductType>, ICommonFunctions<ProductType>
    {
        private string _ProductTypeID;
        private string _ProductTypeName;
        private Nullable<int> _TaxPercent;

        [ColumnAttribute(Name = ProductTypeColumn.ID, IsPrimaryKey = true, CanBeNull = false)]
        public string ProductTypeID
        {
            get { return _ProductTypeID; }
            set { _ProductTypeID = value; }
        }

        [ColumnAttribute(Name = ProductTypeColumn.NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string ProductTypeName
        {
            get { return _ProductTypeName; }
            set { _ProductTypeName = value; }
        }
        [ColumnAttribute(Name = ProductTypeColumn.TAX_PERCENT, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<int> TaxPercent
        {
            get { return _TaxPercent; }
            set { _TaxPercent = value; }
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
        public ProductType GetByPrimaryKey()
        {
            Table<ProductType> table = GetTable();

            ProductType item = table.Single(d => (d.ProductTypeID == this.ProductTypeID));
            if (item != null)
                item.Detach<ProductType>();
            return item;
        }
        #endregion

        public ProductType()
        { }
        public static List<ProductType> GetAllProductType()
        {
            return (from item in GetTable()
                    select item).ToList();
        }
    }







}
