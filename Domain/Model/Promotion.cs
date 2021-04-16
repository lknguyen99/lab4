using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = PromotionColumn.TABLE_NAME)]
    public class Promotion : BaseDomain<Promotion>, ICommonFunctions<Promotion>
    {
        private int _PromotionID;
        private string _ProductID;
        private string _UnitID;
        private int _InOutKBN;
        private DateTime _startDate;
        private DateTime _endDate;
        private System.Nullable<int> _QuantityBuy;
        private System.Nullable<int> _QuantityOffer;

        private string _QuantityOfferUnit;
        public string ProductName { get; set; }
       

        [ColumnAttribute(Name = PromotionColumn.ID, IsPrimaryKey = true, CanBeNull = false)]
        public int PromotionID
        {
            get { return _PromotionID; }
            set { _PromotionID = value; }
        }

          [ColumnAttribute(Name = PromotionColumn.IN_OUT_KBN, IsPrimaryKey = true, CanBeNull = false)]
        public int InOutKBN
        {
            get { return _InOutKBN; }
            set { _InOutKBN = value; }
        }
        [ColumnAttribute(Name = PromotionColumn.PRODUCT_ID, IsPrimaryKey = true, CanBeNull = false)]
        public string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        [ColumnAttribute(Name = ProductColumn.UNIT_ID, IsPrimaryKey = true, CanBeNull = false)]
        public string UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }
          [ColumnAttribute(Name = PromotionColumn.QUANTITY_OFFER_UNIT, IsPrimaryKey = false, CanBeNull = false)]
        public string QuantityOfferUnit
        {
            get { return _QuantityOfferUnit; }
            set { _QuantityOfferUnit = value; }
        }
        
        [ColumnAttribute(Name = PromotionColumn.EXPORT_BUY, IsPrimaryKey = false, CanBeNull = false)]
        public System.Nullable<int> QuantityBuy
        {
            get { return _QuantityBuy; }
            set { _QuantityBuy = value; }
        }

        [ColumnAttribute(Name = PromotionColumn.EXPORT_OFFER, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<int> QuantityOffer
        {
            get { return _QuantityOffer; }
            set { _QuantityOffer = value; }
        }
         [ColumnAttribute(Name = PromotionColumn.START_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        [ColumnAttribute(Name = PromotionColumn.END_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
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
        public Promotion GetByPrimaryKey()
        {
            Table<Promotion> table = GetTable();

            Promotion item = table.Single(d => (d.PromotionID == this.PromotionID && d.InOutKBN == this.InOutKBN));
            if (item != null)
                item.Detach<Promotion>();
            return item;
        }
        #endregion

        public static List<Promotion> GetAllPromotion()
        {
            return (from item in GetTable()
                    where
                     item.IsDeleted == null || item.IsDeleted == false
                    select item).ToList();
        }

        public static Promotion GetPromotion(int inOutKBN, int promotionID)
        {
            return (from item in GetTable()
                    where
                        item.InOutKBN == inOutKBN
                     && (item.IsDeleted == null || item.IsDeleted == false)
                     && item.PromotionID == promotionID
                    select item).FirstOrDefault();
        }

        public static Promotion GetPromotionInfo(int inOutKBN, string productID , string unitID, DateTime deliveryDate , decimal? quantity)
        {
            //tao 1 cai Promotion co KM luon 
            if (quantity == null)
            {
                return (from item in GetTable()
                        where
                             item.InOutKBN == inOutKBN
                             && item.ProductID == productID
                             && item.UnitID == unitID
                             && (item.IsDeleted == null || item.IsDeleted == false)
                             && item.StartDate.Date <= deliveryDate.Date
                             && item.EndDate.Date >= deliveryDate.Date
                        orderby item.QuantityBuy
                        select item).FirstOrDefault();
            }
            else
            {
                Promotion findPromotion = null;

                findPromotion = (from item in GetTable()
                        where
                             item.InOutKBN == inOutKBN
                             && item.ProductID == productID
                             && item.UnitID == unitID
                             && (item.IsDeleted == null || item.IsDeleted == false)
                             && item.StartDate.Date <= deliveryDate.Date
                             && item.EndDate.Date >= deliveryDate.Date
                             && item.QuantityBuy <= quantity.Value
                        orderby item.QuantityBuy descending
                        select item).FirstOrDefault();

                if (findPromotion != null)
                {
                    int passedQuatity = (int)quantity.Value / findPromotion.QuantityBuy.Value;
                    int missingQuatity = (int)quantity.Value % findPromotion.QuantityBuy.Value;
                    if(missingQuatity < findPromotion.QuantityBuy)
                    {
                        var findPromotion2 = (from item in GetTable()
                                         where
                                              item.InOutKBN == inOutKBN
                                              && item.ProductID == productID
                                              && item.UnitID == unitID
                                              && (item.IsDeleted == null || item.IsDeleted == false)
                                              && item.StartDate.Date <= deliveryDate.Date
                                              && item.EndDate.Date >= deliveryDate.Date
                                              && item.QuantityBuy <=  missingQuatity
                                         orderby item.QuantityBuy descending
                                         select item).FirstOrDefault();
                         if(findPromotion2 != null && findPromotion2.QuantityOfferUnit == findPromotion.QuantityOfferUnit)
                         {
                              //so luong tang 
                             int soTang =  passedQuatity * (int)findPromotion.QuantityOffer.Value  + (findPromotion2.QuantityOffer.Value * missingQuatity) / findPromotion2.QuantityBuy.Value;
                             findPromotion.QuantityBuy = (int)quantity.Value;
                             findPromotion.QuantityOffer = soTang;
                         }
                    }
                }
                return findPromotion; 

            }
        }

        public static List<Promotion> GetAllPromotionSearch(Nullable<int> inOutKBN, bool chkOld , bool chkCurrent)
        {
            if (chkOld == false && chkCurrent == false)
            {
                return new List<Promotion>(); 
            }

            return (from item in GetTable()
                    where
                    (
                       (item.IsDeleted == null || item.IsDeleted == false)
                       && (inOutKBN == null || inOutKBN.Value == item.InOutKBN)
                       && 
                          (
                             ( chkOld == true && chkCurrent == true)
                          || (chkCurrent == true && chkOld == false && DateTime.Now.Date <= item.EndDate.Date)
                          || (chkCurrent == false && chkOld == true &&  item.EndDate.Date < DateTime.Now.Date)
                           )
                           )
                    select item).ToList();
        }
        public static List<Promotion> GetAllPromotionSearch(Nullable<int> inOutKBN, Nullable<DateTime> dateTime)
        {
            return (from item in GetTable()
                    where
                    (
                       (item.IsDeleted == null || item.IsDeleted == false)
                       && (inOutKBN == null || inOutKBN.Value == item.InOutKBN)
                       && (dateTime == null || (dateTime.Value.Date >= item.StartDate.Date && dateTime.Value.Date <= item.EndDate.Date) )
                     )
                    select item).ToList();
        }
        public static int GetNextPromotionID(int inoutKBN)
        {
            int result = 1;
            Nullable<int> id = (from item in GetTable()
                      where
                        item.InOutKBN == inoutKBN
                      orderby item.PromotionID descending
                      select item.PromotionID).FirstOrDefault();
            if (id != null)
                result = id.Value + 1;
            return result;
        }
        public static int GetQuantityOfferMin(Promotion findPromotion, decimal quantity)
        {
            //doi sang don vi nho nhat 
            int quantityOffer = findPromotion.QuantityOffer.Value;

            ProductUnit findUnit = ProductUnit.GetUnitForProduct(findPromotion.ProductID, findPromotion.QuantityOfferUnit); 
            if(findUnit != null)
            {
                if (quantity < findPromotion.QuantityBuy)
                    return 0; 

                quantityOffer = (int)findUnit.Quantity * quantityOffer;
            }

            return (int)(quantityOffer * quantity) / findPromotion.QuantityBuy.Value;
        }
    }
}
