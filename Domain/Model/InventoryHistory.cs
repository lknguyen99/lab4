using QuanlyKho.Util;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    [Table(Name = InventoryHistoryColumn.TABLE_NAME)]
    public class InventoryHistory : BaseDomain<InventoryHistory>, ICommonFunctions<InventoryHistory>
    {
        private string _InvoiceNo;
        private int _StoreID;
        private int _InventoryID;

        private System.DateTime _OrderDate;
        private System.DateTime _DeliveryDate;

        private string _ProductID;
        private string _ProductName;
        private string _UnitID;
        private string _UnitName;

        private System.Nullable<decimal> _BuyPrice;
        private System.Nullable<decimal> _SellPrice;
        private System.Nullable<decimal> _Quantity;
        private System.Nullable<decimal> _QuantityOffer;
        private string _QuantityOfferUnit;

        private System.Nullable<decimal> _AmountBuy;
        private System.Nullable<decimal> _AmountSell;



        private int _InOutKBN;
        public InventoryHistory()
        {

        }
        public InventoryHistory(Inventory i,  string invoiceNo)
        {
            // TODO: Complete member initialization
            this.StoreID = i.StoreID;
            this.OrderDate = this.DeliveryDate = i.DeliveryDate;
            this.InvoiceNo = invoiceNo;
            this.ProductID = i.ProductID;
            this.ProductName = i.ProductName;
            this.UnitID = i.UnitID;
            this.BuyPrice = i.BuyPrice;
            this.Quantity = i.Quantity;
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.INVOICE_ID, IsPrimaryKey = true, CanBeNull = true)]
        public string InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        } 
        [ColumnAttribute(Name = InventoryHistoryColumn.INVENTORY_ID, IsPrimaryKey = true, CanBeNull = false)]
        public int InventoryID
        {
            get { return _InventoryID; }
            set { _InventoryID = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.STORE_ID, IsPrimaryKey = true, CanBeNull = false)]
        public int StoreID
        {
            get { return _StoreID; }
            set { _StoreID = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.ORDER_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set { _OrderDate = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.DELIVERY_DATE, IsPrimaryKey = false, CanBeNull = false)]
        public System.DateTime DeliveryDate
        {
            get { return _DeliveryDate; }
            set { _DeliveryDate = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.IN_OUT_KBN, IsPrimaryKey = false, CanBeNull = false)]
        public int InOutKBN
        {
            get { return _InOutKBN; }
            set { _InOutKBN = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.PRODUCT_ID, IsPrimaryKey = false, CanBeNull = false)]
        public string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.PRODUCT_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.UNIT_ID, IsPrimaryKey = false, CanBeNull = true)]
        public string UnitID
        {
            get { return _UnitID; }
            set { _UnitID = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.UNIT_NAME, IsPrimaryKey = false, CanBeNull = true)]
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        [ColumnAttribute(Name = InventoryHistoryColumn.BUY_PRICE, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> BuyPrice
        {
            get { return _BuyPrice; }
            set { _BuyPrice = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.SELL_PRICE, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> SellPrice
        {
            get { return _SellPrice; }
            set { _SellPrice = value; }
        }

        [ColumnAttribute(Name = InventoryHistoryColumn.QUANTITY, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.QUANTITY_OFFER, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> QuantityOffer
        {
            get { return _QuantityOffer; }
            set { _QuantityOffer = value; }
        }
        [ColumnAttribute(Name = PromotionColumn.QUANTITY_OFFER_UNIT, IsPrimaryKey = false, CanBeNull = true)]
        public string QuantityOfferUnit
        {
            get { return _QuantityOfferUnit; }
            set { _QuantityOfferUnit = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.AMOUNT_BUY, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> AmountBuy
        {
            get { return _AmountBuy; }
            set { _AmountBuy = value; }
        }
        [ColumnAttribute(Name = InventoryHistoryColumn.AMOUNT_SELL, IsPrimaryKey = false, CanBeNull = true)]
        public System.Nullable<decimal> AmountSell
        {
            get { return _AmountSell; }
            set { _AmountSell = value; }
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
        public InventoryHistory GetByPrimaryKey()
        {
            Table<InventoryHistory> table = GetTable();

            InventoryHistory item = table.Single(d => (d.InventoryID == this.InventoryID && d.StoreID == this.StoreID && d.InvoiceNo == this.InvoiceNo));
            if (item != null)
                item.Detach<InventoryHistory>();
            return item;
        }
        public static int GetNextInventoryID(int storeID, string invoiceNo)
        {
            int result = 1;

            //find max 

            int? id = (from item in GetTable()
                      where
                      item.StoreID == storeID
                       && item.InvoiceNo == invoiceNo 
                      select item.InventoryID).FirstOrDefault();

            if (id != null)
                result = id.Value + 1;

            return result;
        }

        public static List<InventoryHistory> GetAllInventorySearch(int storeID)
        {
            return (from item in GetTable()
                    where
                    (
                        (storeID == 0 || Convert.ToInt32(item.StoreID) == storeID)
                     && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    select item).ToList();
        }

        #endregion

        public static InventoryHistory GetInventory(int inventoryID, int storeID, string invoiceNo)
        {
            return (from item in GetTable()
                    where
                    (
                        item.InventoryID == inventoryID
                     && item.StoreID == storeID
                     && item.InvoiceNo == invoiceNo
                     && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    select item).FirstOrDefault();
        }
        public static InventoryHistory GetInventory(string productID, int storeID, string invoiceNo)
        {
            return (from item in GetTable()
                    where
                    (
                        item.ProductID == productID
                     && item.StoreID == storeID
                     && item.InvoiceNo == invoiceNo
                     && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    select item).FirstOrDefault();
        }
        public static List<InventoryHistory> GetInventoryListFromInvoice(Invoice invoice)
        {
            return (from item in GetTable()
                    where
                    (
                        item.StoreID == invoice.StoreID
                    && item.InvoiceNo == invoice.InvoiceNo
                     && (item.IsDeleted == null || item.IsDeleted == false)
                    )
                    select item).ToList();
        }
        public static List<InventoryHistory> GetInventoryOrderExport(DateTime fromdt, DateTime to, int inOutKBN)
        {
            return (from item in GetTable()
                    where
                    (
                            item.DeliveryDate.Date <= to.Date
                          && item.DeliveryDate.Date >= fromdt.Date
                         && (item.InOutKBN == Constant.KBN_EXPORT || item.InOutKBN == Constant.KBN_ORDER)
                         && (item.InOutKBN == inOutKBN || inOutKBN == 0)
                    )
                    select item).ToList();
        }
        public static List<InventoryHistory> GroupInventoryByProductUnit(List<InventoryHistory> list)
        {
           return (from p in list
                           group p by new { p.ProductID, p.UnitID } into g
                           select new InventoryHistory
                           {
                               ProductID = g.First().ProductID,
                               ProductName = g.First().ProductName,
                               UnitID = g.First().UnitID,
                               UnitName = g.First().UnitName,
                               Quantity = g.Where(p => p.Quantity != null).Sum(p => p.Quantity),
                               QuantityOffer = g.Where(p => p.QuantityOffer != null).Sum(p => p.QuantityOffer.Value),
                               SellPrice = g.Where(p => p.SellPrice != null).Average(p => p.SellPrice),
                               BuyPrice = g.Where(p => p.SellPrice != null).Average(p => p.BuyPrice),
                               AmountSell = g.Where(p => p.AmountSell != null).Sum(p => p.AmountSell),
                               AmountBuy = g.Where(p => p.AmountSell != null).Sum(p => p.AmountBuy)

                           }).ToList();
        }

        public decimal GetQuantity(InventoryHistory hist)
        {
            decimal quantity = Common.GetDefaultDecimalValue(hist.Quantity) + Common.GetDefaultDecimalValue(hist.QuantityOffer);
            //lay so luong san pham nho nhat 

            ProductUnit pro = ProductUnit.GetUnitForProduct(hist.ProductID, hist.UnitID);
            if(pro!= null)
            {
                quantity = pro.Quantity * quantity;
            }
            return quantity; 
        }
        public static void ImportData(List<InventoryHistory> listNhapKho, Invoice invoice)
        {
            int nextHisID = InventoryHistory.GetNextInventoryID(invoice.StoreID, invoice.InvoiceNo);
            int nextInventoryID = Inventory.GetNextInventoryID(invoice.StoreID);

            using (DBContext db = new DBContext())
            {
                using (System.Data.Common.DbTransaction tran = db.UseTransaction())
                {
                    try
                    {
                        foreach (InventoryHistory hist in listNhapKho)
                        {
                            decimal quatity = GetQuantityForInventory(hist);

                            //dua cung loai san pham gom so luong
                            Inventory inv = db.GetTable<Inventory>().FirstOrDefault(p => p.StoreID == invoice.StoreID && p.ProductID == hist.ProductID && (p.IsDeleted == null || p.IsDeleted == false));
                            if (inv == null)
                            {
                                inv = new Inventory();
                                inv.ID = nextInventoryID++;
                                inv.StoreID = invoice.StoreID;
                                inv.BuyPrice = hist.BuyPrice;
                                inv.SellPrice = hist.SellPrice;

                                inv.UnitID = ProductUnit.GetMinUnitForProduct(hist.ProductID).UnitID1; //lay don vi nho nhat cua san pham
                                inv.Quantity =  quatity;

                                inv.Amount = hist.AmountBuy;
                                inv.ProductID = hist.ProductID;
                                inv.ProductName = hist.ProductName;
                                inv.DeliveryDate = invoice.DeliveryDate;
                             
                                inv.CreateUser = inv.UpdateUser = "Admin";
                                inv.CreateDate = inv.UpdateDate = DateTime.Now;

                                db.Insert<Inventory>(inv);

                            }
                            else
                            {
                                //doi sang don vi nho nhat 

                                inv.Quantity = Common.GetDefaultDecimalValue(inv.Quantity) + quatity;
                                inv.DeliveryDate = invoice.DeliveryDate;

                                inv.UpdateUser = "Admin";
                                inv.UpdateDate = DateTime.Now;
                                db.Refresh(RefreshMode.KeepCurrentValues, inv);
                               // db.Update<Inventory>(inv);

                            }
                            //tao ra history 
                            hist.StoreID = invoice.StoreID;
                            hist.OrderDate = invoice.OrderDate;
                            hist.DeliveryDate = invoice.DeliveryDate;
                            hist.InvoiceNo = invoice.InvoiceNo;
                            hist.InOutKBN = Constant.KBN_IMPORT;
                            hist.InventoryID = nextHisID++;
                            hist.CreateUser = hist.UpdateUser = "Admin";
                            hist.UpdateDate = hist.CreateDate = DateTime.Now;
                            db.Insert<InventoryHistory>(hist);

                        }

                        //insert thong tin Invoice

                        invoice.CreateUser = invoice.UpdateUser = "Admin";
                        invoice.UpdateDate = invoice.CreateDate = DateTime.Now;
                        db.Insert<Invoice>(invoice);
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
        // inoutKBN = NULL : _> them order 
        // isexport = false: them order 
        public static void ExportData(List<InventoryHistory> listXuatKho, Invoice invoice)
        {
            int nextHisID = InventoryHistory.GetNextInventoryID(invoice.StoreID, invoice.InvoiceNo);
            using (DBContext db = new DBContext())
            {
                using (System.Data.Common.DbTransaction tran = db.UseTransaction())
                {
                    try
                    {
                        List<InventoryHistory> listHist = InventoryHistory.GetInventoryListFromInvoice(invoice);
                        foreach (InventoryHistory hist in listHist)
                        {
                            db.Delete<InventoryHistory>(hist);
                        }
                        foreach (InventoryHistory hist in listXuatKho)
                        {
                            Inventory inv = db.GetTable<Inventory>().FirstOrDefault(p => p.StoreID == invoice.StoreID && p.ProductID == hist.ProductID && (p.IsDeleted == null || p.IsDeleted == false));
                            decimal quatity = GetQuantityForInventory(hist); 
                            if (inv == null)
                            {
                                throw new Exception("KHONG CO GIA TRI XUAT KHO DUOC");
                            }
                            else
                            {
                                if (invoice.InOutKbn != null)
                                {
                                    inv.Quantity = Common.GetDefaultDecimalValue(inv.Quantity) - quatity;
                                    if (invoice.InOutKbn != null && invoice.InOutKbn == Constant.KBN_ORDER)
                                    {
                                        inv.QuantityOrder = Common.GetDefaultDecimalValue(inv.QuantityOrder) - quatity;
                                    }
                                    inv.SellPrice = hist.SellPrice;
                                    inv.DeliveryDate = invoice.DeliveryDate;
                                }
                                else
                                {
                                    inv.QuantityOrder = quatity;
                                    inv.SellPrice = hist.SellPrice;
                                    inv.DeliveryDate = invoice.DeliveryDate;
                                }
                                inv.UpdateUser = "Admin";
                                inv.UpdateDate = DateTime.Now;

                                db.Refresh(RefreshMode.KeepCurrentValues, inv);
                            }


                            //tao ra history 
                            hist.StoreID = invoice.StoreID;
                            hist.OrderDate = invoice.OrderDate;
                            hist.DeliveryDate = invoice.DeliveryDate;
                            hist.InvoiceNo = invoice.InvoiceNo;
                            if (invoice.InOutKbn == null)
                                hist.InOutKBN = Constant.KBN_ORDER; 
                            else
                                hist.InOutKBN = Constant.KBN_EXPORT; 
                            hist.InventoryID = nextHisID++;


                            hist.CreateUser = hist.UpdateUser = "Admin";
                            hist.UpdateDate = hist.CreateDate = DateTime.Now;
                            db.Insert<InventoryHistory>(hist);

                        }
                        //insert thong tin Invoice
                        if (invoice.InOutKbn == null || invoice.InOutKbn == Constant.KBN_EXPORT)
                        {
                            if(invoice.InOutKbn == null)
                               invoice.InOutKbn = Constant.KBN_ORDER;
                            else
                               invoice.InOutKbn = Constant.KBN_EXPORT;

                            invoice.CreateUser = invoice.UpdateUser = "Admin";
                            invoice.UpdateDate = invoice.CreateDate = DateTime.Now;
                            db.Insert<Invoice>(invoice);
                        }
                        else
                        {
                             invoice.InOutKbn = Constant.KBN_EXPORT;
                             invoice.UpdateDate =  DateTime.Now;
                             invoice.UpdateUser = "Admin";
                             db.Update<Invoice>(invoice);
                        }
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

        public static void DeleteData(string invoiceNo)
        {
           Invoice invoice = Invoice.GetInvoice(invoiceNo);
           if (invoice == null)
               return;

           List<InventoryHistory> listHist = InventoryHistory.GetInventoryListFromInvoice(invoice);

            using (DBContext db = new DBContext())
            {
                using (System.Data.Common.DbTransaction tran = db.UseTransaction())
                {
                    try
                    {
                        db.Delete<Invoice>(invoice);
 
                       
                        //delete tai kho 
                        foreach (InventoryHistory hist in listHist)
                        {
                            Inventory inv = db.GetTable<Inventory>().FirstOrDefault(p => p.StoreID == invoice.StoreID && p.ProductID == hist.ProductID && (p.IsDeleted == null || p.IsDeleted == false));
                            if(inv!= null)
                            {
                                decimal totalQuatity = GetQuantityForInventory(hist);
                                if (invoice.InOutKbn == Constant.KBN_EXPORT)
                                {
                                    inv.Quantity =  Common.GetDefaultDecimalValue(inv.Quantity) + totalQuatity;
                                }
                                else if (invoice.InOutKbn == Constant.KBN_ORDER)
                                {
                                    inv.QuantityOrder = Common.GetDefaultDecimalValue(inv.QuantityOrder) - totalQuatity;
                                }
                                else if (invoice.InOutKbn == Constant.KBN_IMPORT)
                                {
                                    inv.Quantity = Common.GetDefaultDecimalValue(hist.Quantity) - Common.GetDefaultDecimalValue(inv.Quantity);
                                }
                                inv.UpdateUser = "Admin";
                                inv.UpdateDate = DateTime.Now;
                                db.Refresh(RefreshMode.KeepCurrentValues, inv);
                            }

                            db.Delete<InventoryHistory>(hist);
                        }
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
        public static decimal GetQuantityForInventory(InventoryHistory hist)
        {
            decimal totalQuatity = Common.GetDefaultDecimalValue(hist.Quantity);
            decimal totalQuatityOffer = Common.GetDefaultDecimalValue(hist.QuantityOffer);
            if(hist.UnitID == hist.QuantityOfferUnit)
            {
                totalQuatity +=Common.GetDefaultDecimalValue(hist.QuantityOffer);
            }
            else
            {
                 ProductUnit findUnitExchange1 = ProductUnit.GetUnitForProduct(hist.ProductID, hist.QuantityOfferUnit);
                if (findUnitExchange1 != null)
                {
                    totalQuatityOffer = totalQuatityOffer * findUnitExchange1.Quantity;
                }
              
            }
            ProductUnit findUnitExchange = ProductUnit.GetUnitForProduct(hist.ProductID, hist.UnitID);
            if (findUnitExchange != null)
            {
                totalQuatity = totalQuatity * findUnitExchange.Quantity;
                
            }
            return totalQuatity + totalQuatityOffer;
        }
    }
    public class ReportInventoryHistory 
    {
        public List<InventoryHistory> listInventory = new List<InventoryHistory>();
        public string ProductType; 


    }
}
