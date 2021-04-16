using QuanlyKho.Util;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = InventoryColumn.TABLE_NAME)]
    public class Inventory : BaseDomain<Inventory>, ICommonFunctions<Inventory>
    {
        private int _ID;
        private int _StoreID;

        private string _ProductID;
        private System.DateTime _DeliveryDate;

        private string _ProductName;
        private string _UnitID;

        private System.Nullable<decimal> _BuyPrice;
        private System.Nullable<decimal> _SellPrice; 
        private System.Nullable<decimal> _Quantity;
        private System.Nullable<decimal> _QuantityOrder;

        public decimal? Amount;
        public int? QuantityBuy { get; set; }
        public int? QuantityOffer { get; set; }
     
        public string UnitName { get; set; }

        [ColumnAttribute(Name = InventoryColumn.ID, IsPrimaryKey = true, CanBeNull = false)]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        [ColumnAttribute(Name = InventoryColumn.STORE_ID, IsPrimaryKey = true, CanBeNull = false)]
        public int StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }

        [ColumnAttribute(Name = InventoryColumn.PRODUCT_ID, IsPrimaryKey = false, CanBeNull = false)]
        public string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        [ColumnAttribute(Name = InventoryColumn.DELIVERY_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public DateTime DeliveryDate
        {
            get { return _DeliveryDate; }
            set { _DeliveryDate = value; }
        }

        [ColumnAttribute(Name = InventoryColumn.PRODUCT_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        [ColumnAttribute(Name = InventoryColumn.UNIT_ID, IsPrimaryKey = false, CanBeNull = true)]
        public string UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }

        [ColumnAttribute(Name = InventoryColumn.BUY_PRICE, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> BuyPrice
        {
            get { return _BuyPrice; }
            set { _BuyPrice = value; }
        }
        [ColumnAttribute(Name = InventoryColumn.SELL_PRICE, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> SellPrice
        {
            get { return _SellPrice; }
            set { _SellPrice = value; }
        }
        [ColumnAttribute(Name = InventoryColumn.QUANTITY, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
          [ColumnAttribute(Name = InventoryColumn.QUANTITY_ORDER, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> QuantityOrder
        {
            get { return _QuantityOrder; }
            set { _QuantityOrder = value; }
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

        public Inventory()
        {
            ProductID = "";
            ProductName = "";
        }
        public Inventory GetByPrimaryKey()
        {
            Table<Inventory> table = GetTable();

            Inventory item = table.Single(d => (d.ID == this.ID && d.StoreID == this.StoreID));
            if (item != null)
                item.Detach<Inventory>();
            return item;
        }
        public static int GetNextInventoryID(int storeID)
        {
            int result = 1;

             //find max 

            int? id = (from item in GetTable()
                      where
                        item.StoreID == storeID 
                       orderby item.ID descending
                       select item.ID).FirstOrDefault();
                     

            if (id != null)
                result = id.Value +1;

            return result;
        }

        public static List<Inventory> GetAllInventorySearch(int storeID)
        {
            return (from item in GetTable()
                    where
                    (
                        //(storeID == 0 || item.StoreID == storeID)
                      ( item.IsDeleted == null || item.IsDeleted == false )
                    )
                    select item).ToList();
        }


        #endregion

        public static Inventory GetInventory(long id, int storeID)
        {
            return (from item in GetTable()
                    where
                    (
                        item.ID == id 
                     && item.StoreID == storeID 
                     && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    select item).FirstOrDefault();
        }
        public static Inventory GetInventory(int storeID, string productID)
        {
            return (from item in GetTable()
                    where
                    (
                        item.StoreID == storeID
                     && item.ProductID == productID
                     && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    select item).FirstOrDefault();
        }
        public static List<Inventory> GetInventoryListForExport(int storeID)
        {
            return (from item in GetTable()
                    where
                    (
                         item.StoreID == storeID
                     && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    orderby item.DeliveryDate 
                    select item).ToList();
        }
        public static List<Inventory> GetAllProductFromStore(bool useInventory, int storeID, int minQuantity)
        {
            // lay Inventory tu KHO 
            if (useInventory)
            {
                var list = (from item in Inventory.GetTable()
                            where
                            (
                                 item.StoreID == storeID
                             && (item.IsDeleted == null || item.IsDeleted == false)
                             && (item.Quantity != null && item.Quantity.Value > minQuantity)
                            )
                            select item).ToList();

                foreach (var obj in list)
                {
                    Product findProduct = Product.GetProduct(obj.ProductID, obj.UnitID);
                    if (findProduct != null)
                    {
                        obj.SellPrice = findProduct.SellPrice;
                        obj.ProductName = findProduct.ProductName; // luon luon cap nhat lai product
                        obj.UnitName = findProduct.UnitName;
                        obj.UnitID = findProduct.UnitID;

                        Promotion findPromotion = Promotion.GetPromotionInfo(Constant.KBN_EXPORT, findProduct.ProductID,  obj.UnitID , obj.DeliveryDate, obj.Quantity);
                        if (findPromotion != null)
                        {
                            obj.QuantityBuy = findPromotion.QuantityBuy;

                            ProductUnit findProductUnit = ProductUnit.GetUnitForProduct(findProduct.ProductID, findPromotion.QuantityOfferUnit);
                            if (findProductUnit != null && findPromotion.QuantityOffer != null)
                            {
                                //doi ra don vi nho nhat neu promotion chua phai nho nhat
                                obj.QuantityOffer = (int)findPromotion.QuantityOffer.Value * Convert.ToInt32(findProductUnit.Quantity);
                            }
                            else 
                              obj.QuantityOffer = findPromotion.QuantityOffer; //doi ra don vi nho nhat
                        }
                    }
                }
                return list;
            }
            else
            {
                List<Inventory> list = new List<Inventory>();
                List<Product> all = Product.GetAllProduct(); 
                foreach(Product i in all)
                {
                     Inventory temp = new Inventory();
                     temp.ProductID = i.ProductID; 
                     temp.ProductName = i.ProductName;
                     temp.UnitID = i.UnitID; 
                     temp.UnitName = i.UnitName; 
                     temp.BuyPrice = i.BuyPriceCurrent; 
                     temp.SellPrice = i.SellPrice; 

                     list.Add(temp);
                }
                 return list;
            }

        }

        /*
        public static void ImportData(List<Inventory> listNhapKho, Invoice invoice)
        {

            long nextHisID = InventoryHistory.GetNextInventoryID(invoice.StoreID, invoice.DeliveryDate, invoice.DeliveryDate);
            int nextInventoryID = Inventory.GetNextInventoryID(invoice.StoreID);

            using (DBContext db = new DBContext())
            {
                using (System.Data.Common.DbTransaction tran = db.UseTransaction())
                {
                    try
                    {
                        invoice.CreateUser = invoice.UpdateUser = "Admin";
                        invoice.CreateDate = invoice.UpdateDate = DateTime.Now;
                        db.Insert<Invoice>(invoice);

                        // invoice.Amount = listNhapKho.Where(p=>p.AmountBuy!=null).Sum(p=>p.AmountBuy);
                        //invoice.Discount = 0.05; 

                        foreach(Inventory i in listNhapKho)
                        {
                            //tao ra history 
                            InventoryHistory hist = new InventoryHistory(i, invoice.InvoiceNo);
                            hist.InventoryID = nextHisID++;
                            hist.CreateUser = hist.UpdateUser =  "Admin";
                            hist.CreateDate = hist.UpdateDate = DateTime.Now;
                            db.Insert<InventoryHistory>(hist);

                            //dua cung loai san pham gom so luong
                            Inventory inv = Inventory.GetInventory(i.StoreID, i.ProductID);
                            if (inv == null)
                            {
                                i.ID = nextInventoryID++;
                                i.CreateUser = i.UpdateUser = "Admin";
                                i.CreateDate = i.UpdateDate = DateTime.Now;

                                db.Insert<Inventory>(i);
                                
                            }
                            else
                            {
                                inv.Quantity = inv.Quantity + i.Quantity;
                                inv.DeliveryDate = i.DeliveryDate;

                                i.UpdateUser = "Admin";
                                i.UpdateDate = DateTime.Now;
                                db.Update<Inventory>(inv);
                               
                            }
                        }
                        //insert thong tin Invoice
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        throw ex;
                    }
                }
            }
       
        }
         */
    }

}
