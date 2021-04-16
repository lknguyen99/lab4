using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Collections;

namespace QuanLyKho.Domain
{
    [Table(Name = ProductColumn.TABLE_NAME)]
    public class Product : BaseDomain<Product>, ICommonFunctions<Product>
    {
        private string _ProductID;
        private string _ProductName;
        private string _UnitID;
        private string _UnitName;
        private string _ProductType;
        private string _ProviderID;
        private string _ProviderName;
        private System.Nullable<decimal> _BuyPriceCurrent;


        private System.Nullable<decimal> _BuyPricePrevious;
        private System.Nullable<decimal> _BuyPriceAverage;
        private System.Nullable<decimal> _SellPrice;

        [ColumnAttribute(Name = ProductColumn.ID, IsPrimaryKey = true, CanBeNull = false)]
        public string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        [ColumnAttribute(Name = ProductColumn.NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        [ColumnAttribute(Name = ProductColumn.PRODUCT_TYPE, IsPrimaryKey = false, CanBeNull = true)]
        public string ProductType
        {
            get { return _ProductType; }
            set { _ProductType = value; }
        }

        [ColumnAttribute(Name = ProductColumn.UNIT_ID, IsPrimaryKey = true, CanBeNull = false)]
        public string UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }
        [ColumnAttribute(Name = ProductColumn.UNIT_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }
        [ColumnAttribute(Name = ProductColumn.PROVIDER_ID, IsPrimaryKey = false, CanBeNull = true)]
        public string ProviderID
        {
            get { return _ProviderID; }
            set { _ProviderID = value; }
        }
        [ColumnAttribute(Name = ProductColumn.PROVIDER_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string ProviderName
        {
            get { return _ProviderName; }
            set { _ProviderName = value; }
        }
        [ColumnAttribute(Name = ProductColumn.BUY_PRICE_CURRENT, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> BuyPriceCurrent
        {
            get { return _BuyPriceCurrent; }
            set { _BuyPriceCurrent = value; }
        }
        [ColumnAttribute(Name = ProductColumn.BUY_PRICE_PRE, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> BuyPricePrevious
        {
            get { return _BuyPricePrevious; }
            set { _BuyPricePrevious = value; }
        }
        [ColumnAttribute(Name = ProductColumn.BUY_PRICE_AVG, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> BuyPriceAverage
        {
            get { return _BuyPriceAverage; }
            set { _BuyPriceAverage = value; }
        }
        [ColumnAttribute(Name = ProductColumn.SELL_PRICE, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> SellPrice
        {
            get { return _SellPrice; }
            set { _SellPrice = value; }
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
        public Product GetByPrimaryKey()
        {
            Table<Product> table = GetTable();

            Product item = table.Single(d => (d.ProductID == this.ProductID) && (d.IsDeleted == null || d.IsDeleted == false) && d.UnitID == this.UnitID);
            if (item != null)
                item.Detach<Product>();
            return item;
        }
        #endregion

        public static List<Product> GetAllProduct()
        {
            return (from item in GetTable()
                    where 
                     item.IsDeleted == null || item.IsDeleted == false
                    select item).ToList();
        }

        public static Product GetProduct(string productID, string unitID)
        {
            return (from item in GetTable()
                    where
                     item.ProductID == productID  && item.UnitID == unitID
                     && 
                     ( item.IsDeleted == null || item.IsDeleted == false )
                    select item).FirstOrDefault();
        }

        public static List<Product> GetProductSearch(Product findObj)
        {
            return (from item in GetTable()
                    where
                     (
                           item.ProductID.Contains(findObj.ProductID)
                       && item.ProductName.Contains(findObj.ProductName)
                       && item.UnitName.Contains(findObj.UnitName)
                       && item.ProviderName.Contains(findObj.ProviderName)
                       && (findObj.BuyPriceCurrent == null   || item.BuyPriceCurrent ==findObj.BuyPriceCurrent)
                       && (findObj.SellPrice == null || item.SellPrice == findObj.SellPrice)
                       && (item.IsDeleted == null || item.IsDeleted == false)
                     )
                    select item).ToList();
        }
        public static CodeName GetUnitFromProduct(string productID)
        {
            return (from item in GetTable()
                    where
                     (item.ProductID == productID
                     &&
                     (item.IsDeleted == null || item.IsDeleted == false)
                     )
                    select new CodeName() 
                    {
                         Code = item.UnitID, 
                         Name =  item.UnitName
                    } 
                    ).FirstOrDefault();
        }
        public static List<CodeName> GetListUnitFromProduct(string productID)
        {
            return (from item in GetTable()
                    where
                     (item.ProductID == productID
                     &&
                     (item.IsDeleted == null || item.IsDeleted == false)
                     )
                    group item by item.UnitID into g
                    select new CodeName()
                    {
                        Code = g.First().UnitID,
                        Name = g.First().UnitName
                    }
                    ).ToList();
        }
    }







}
