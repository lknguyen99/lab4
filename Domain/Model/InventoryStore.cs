using QuanlyKho.Util;
using QuanLyKho.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    public class InventoryStore
    {
        public int StoreID { get; set; }
        public string ProductID {get; set;}
        public string ProductName { get; set; }
        public string UnitName { get; set; }

        //cuoi ki
        public decimal QuantityLast { get; set; }
        public decimal AmountLast { get; set; }

        // trong ki
        public decimal QuantityImport { get; set; }
        public decimal AmountImport { get; set; }

        public decimal QuantityExport { get; set; }
        public decimal AmountExport { get; set; }

        //dau ki
        public decimal Quantity { get; set; }
        // lay tu kho hien tai
        public decimal QuantityInventory { get; set; }

        public static List<InventoryStore> GetListInventoryStore(int storeID, DateTime deliveryFrom , DateTime delivertyTo)
        {
            List<InventoryStore> list = new List<InventoryStore>();

            Dictionary<string, InventoryStore> dicProductLast = GetListInventoryHistory(storeID, new DateTime(2000, 1, 1), deliveryFrom.AddDays(-1));
            Dictionary<string, InventoryStore> dicProductPeriod = GetListInventoryHistory(storeID, deliveryFrom, delivertyTo);

            List<Inventory> listCurrentInv = Inventory.GetAllInventorySearch(storeID);
            foreach (InventoryStore temp in dicProductPeriod.Values)
            {
                 temp.QuantityLast = 0;
                 temp.AmountLast = 0;
                 if (dicProductLast.ContainsKey(temp.ProductID))
                 {
                     InventoryStore last = dicProductLast[temp.ProductID];
                     temp.QuantityLast = last.QuantityImport - last.QuantityExport;
                     temp.AmountLast = last.AmountImport - last.AmountExport;

                     dicProductLast.Remove(temp.ProductID);
                 }
                 temp.Quantity = temp.QuantityLast + temp.QuantityImport - temp.QuantityExport;

                 Inventory inv = listCurrentInv.Where(p => p.ProductID == temp.ProductID && p.StoreID == temp.StoreID).FirstOrDefault();
                 if(inv != null)
                 {
                     temp.QuantityInventory = Common.GetDefaultDecimalValue(inv.Quantity) + Common.GetDefaultDecimalValue(inv.QuantityOrder);
                 }
              
                 list.Add(temp); 
            }
            foreach (InventoryStore temp in dicProductLast.Values)
            {
                temp.QuantityLast = temp.QuantityImport - temp.QuantityExport;
                temp.AmountLast = temp.AmountImport - temp.AmountExport;


                temp.QuantityImport = temp.QuantityExport = 0;
                temp.AmountImport = temp.AmountExport = 0;
                //if (dicProductLast.ContainsKey(temp.ProductID))
                //{

                //}
                temp.Quantity = temp.QuantityLast + temp.QuantityImport - temp.QuantityExport;
                Inventory inv = listCurrentInv.Where(p => p.ProductID == temp.ProductID && p.StoreID == temp.StoreID).FirstOrDefault();
                if (inv != null)
                {
                    temp.QuantityInventory = Common.GetDefaultDecimalValue(inv.Quantity) + Common.GetDefaultDecimalValue(inv.QuantityOrder);
                }
                list.Add(temp); 
            }
            return list;
        }
        public static Dictionary<string, InventoryStore> GetListInventoryHistory(int storeId, DateTime deliveryDateFrom, DateTime deliveryDateTo)
        {
            //storeID = 0 -> tat ca cac kho 
            var listInvenHistory = (from item in InventoryHistory.GetTable()
                                    where
                                    (
                                       (storeId == 0 || item.StoreID == storeId)
                                        &&  item.DeliveryDate.Date <= deliveryDateTo.Date
                                        &&  item.DeliveryDate.Date >= deliveryDateFrom.Date 
                                        && item.InOutKBN != Constant.KBN_ORDER
                                        && (item.IsDeleted == null || item.IsDeleted == false)
                                    )
                                    select item).ToList();

            Dictionary<string, InventoryStore> dicProduct = new Dictionary<string, InventoryStore>();

            foreach (InventoryHistory i in listInvenHistory)
            {
                ProductUnit findUnitExchange = ProductUnit.GetUnitForProduct(i.ProductID, i.UnitID);
                string unitID = i.UnitID;

                decimal quatity = Common.GetDefaultDecimalValue(i.Quantity);
                if (findUnitExchange != null)
                {
                    unitID = findUnitExchange.UnitIDMin;
                    quatity = quatity * findUnitExchange.Quantity;
                }
                quatity = quatity + Common.GetDefaultDecimalValue(i.QuantityOffer);

                if (!dicProduct.ContainsKey(i.ProductID))
                {
                    InventoryStore item = new InventoryStore();
                    item.ProductID = i.ProductID;
                    item.ProductName = i.ProductName;
                    item.QuantityImport = 0; 
                    item.QuantityExport = 0;

                    item.UnitName = Unit.GetUnit(unitID).UnitName;
                    item.StoreID = i.StoreID;

                    dicProduct.Add(i.ProductID, item);
                }

                InventoryStore obj = dicProduct[i.ProductID];
                if(i.InOutKBN == Constant.KBN_IMPORT && i.Quantity!= null)
                {
                    obj.QuantityImport += quatity;
                    obj.AmountImport += (i.AmountBuy == null ? 0 : i.AmountBuy.Value);
                }
                else if(i.InOutKBN == Constant.KBN_EXPORT && i.Quantity!= null)
                {
                    obj.QuantityExport += quatity;
                    obj.AmountExport += (i.AmountSell == null ? 0 : i.AmountSell.Value);
                }
            }
            return dicProduct;
        }
    }
}
