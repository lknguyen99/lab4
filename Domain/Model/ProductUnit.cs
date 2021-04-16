using QuanlyKho.Util;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = ProductUnitColumn.TABLE_NAME)]
    public class ProductUnit : BaseDomain<ProductUnit>, ICommonFunctions<ProductUnit>
    {
        private string _ProductID;
        private string _UnitID1;
        private string _UnitIDMin;
        private decimal _Quantity;

        [ColumnAttribute(Name = ProductUnitColumn.PRODUCT_ID, IsPrimaryKey = true, CanBeNull = false)]
        public string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        [ColumnAttribute(Name = ProductUnitColumn.UNIT1, IsPrimaryKey = true, CanBeNull = false)]
        public string UnitID1
        {
            get { return _UnitID1; }
            set { _UnitID1 = value; }
        }
        [ColumnAttribute(Name = ProductUnitColumn.UNIT2, IsPrimaryKey = true, CanBeNull = false)]
        public string UnitIDMin
        {
            get { return _UnitIDMin; }
            set { _UnitIDMin = value; }
        }
        [ColumnAttribute(Name = ProductUnitColumn.QUANTITY1, IsPrimaryKey = false, CanBeNull = false)]
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
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
        public ProductUnit GetByPrimaryKey()
        {
            Table<ProductUnit> table = GetTable();

            ProductUnit item = table.Single(d => (d.ProductID == this.ProductID && d.UnitID1 == this.UnitID1 && d.UnitIDMin == this.UnitIDMin));
            if (item != null)
                item.Detach<ProductUnit>();
            return item;
        }

        #endregion

        public ProductUnit()
        {

        }
        public static ProductUnit GetMinUnitForProduct(string productID)
        {
            return (from item in GetTable()
                    where
                     item.ProductID == productID
                    orderby item.Quantity
                    select item).FirstOrDefault();
        }
        public static ProductUnit GetUnitForProduct(string productID, string unitExchange)
        {
            return (from item in GetTable()
                    where
                     item.ProductID == productID && item.UnitID1 == unitExchange
                     && item.UnitIDMin == "cai"
                    select item).FirstOrDefault();
        }
        public static void InsertUpdateProductUnit(string productID, string unitExchange, decimal quantity)
        {
            ProductUnit pro = GetUnitForProduct(productID, unitExchange); 
            if(pro != null)
            {
                pro.Quantity = quantity;
             
                pro.Update();
            }
            else
            {
                pro = new ProductUnit();
                pro.ProductID = productID;
                pro.UnitID1 = unitExchange;
                pro.UnitIDMin = Constant.DEFAULT_MIN_UNIT;
                pro.Quantity = quantity;
                pro.CreateUser = "Admin";
                pro.Insert();
            }
        }
    }


}
