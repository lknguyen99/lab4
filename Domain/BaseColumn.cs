using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKho.Domain
{
    public class BaseColumn
    {
        public BaseColumn() { }

        #region Common column of all table

        public const string IS_DELETED = "IsDeleted";
        public const string CREATE_DATE = "CreateDate";
        public const string UPDATE_DATE = "UpdateDate";
        public const string CREATE_USER = "CreateUser";
        public const string UPDATE_USER = "UpdateUser";

        #endregion
    }
    public class CustomerColumn
    {
        public const string TABLE_NAME = "Customer";
        public const string CUSTOMER_ID = "CustomerID";
        public const string CUSTOMER_NAME = "CustomerName";
        public const string ADDRESS = "Address";
        public const string MOBILE = "Mobile";
        public const string EMAIL = "Email";

        public const string COMPANY_NAME = "CompanyName";
        public const string MST = "MST";
        public const string PrefixBillNo = "PrefixBillNo";
        public const string NOTE = "Note";
        public const string IS_DEBT = "IsDebt";
     }

    public class UnitColumn
    {
        public const string TABLE_NAME = "Unit";

        public const string ID = "UnitID";
        public const string NAME = "UnitName";
        public const string PRIORITY = "Priority";
        public const string DESCRIPTION = "Description";
 
    }
    public class ProductUnitColumn
    {
        public const string TABLE_NAME = "ProductUnit";
        public const string PRODUCT_ID = "ProductID";

        public const string UNIT1 = "UnitID1";
        public const string UNIT2= "UnitIDMin";

        public const string QUANTITY1 = "Quantity";

    }
    public class ProviderColumn
    {
        public const string TABLE_NAME = "Provider";
        public const string ID = "ProviderID";
        public const string NAME = "ProviderName";
        public const string ADDRESS = "Address";
        public const string MOBILE = "Mobile";
    }
    public class StoreColumn
    {
        public const string TABLE_NAME = "Store";

        public const string ID = "StoreID";
        public const string NAME = "StoreName";
        public const string ADDRESS = "Address";
        public const string MST = "MST";

    }
    public class ProductColumn
    {
        public const string TABLE_NAME = "Product";

        public const string ID = "ProductID";
        public const string NAME = "ProductName";
        public const string PRODUCT_TYPE = "ProductType";

        public const string UNIT_ID = "UnitID";
        public const string UNIT_NAME = "UnitName";

        public const string PROVIDER_ID = "ProviderID";
        public const string PROVIDER_NAME = "ProviderName";
        public const string BUY_PRICE_CURRENT = "BuyPriceCurrent";
        public const string BUY_PRICE_PRE = "BuyPricePrevious";
        public const string BUY_PRICE_AVG = "BuyPriceAverage";
        public const string SELL_PRICE = "SellPrice";

      
    }
    public class ProductTypeColumn
    {
        public const string TABLE_NAME = "ProductType";

        public const string ID = "ProductTypeID";
        public const string NAME = "ProductTypeName";
        public const string TAX_PERCENT = "TaxPercent";

    }
    

    public class InventoryColumn
    {
        public const string TABLE_NAME = "Inventory";

        public const string ID = "ID";
        public const string STORE_ID = "StoreID";
        public const string PRODUCT_ID = "ProductID";
        public const string DELIVERY_DATE = "DeliveryDate";
        public const string PRODUCT_NAME = "ProductName";
        public const string UNIT_ID = "UnitID";

        public const string BUY_PRICE = "BuyPrice";
        public const string SELL_PRICE = "SellPrice";
        public const string QUANTITY = "Quantity"; //so luong
        public const string QUANTITY_ORDER = "QuantityOrder"; //so luong
        

    }
    public class InventoryHistoryColumn
    {
        public const string TABLE_NAME = "InventoryHistory";

        public const string INVENTORY_ID = "InventoryID";
      
        public const string STORE_ID = "StoreID";
        public const string ORDER_DATE = "OrderDate";
        public const string DELIVERY_DATE = "DeliveryDate";
        public const string INVOICE_ID = "InvoiceNo";
        public const string IN_OUT_KBN = "InOutKBN";
        public const string PRODUCT_ID = "ProductID";
        public const string PRODUCT_NAME = "ProductName";
        public const string UNIT_ID = "UnitID";
        public const string UNIT_NAME = "UnitName";
        public const string QUANTITY = "Quantity"; //so luong
        public const string QUANTITY_OFFER = "QuantityOffer"; //so luong
        public const string QUANTITY_OFFER_UNIT = "QuantityOfferUnit";
        public const string BUY_PRICE = "BuyPrice";
        public const string SELL_PRICE = "SellPrice";
        public const string AMOUNT_BUY = "AmountBuy"; //so tien 
        public const string AMOUNT_SELL = "AmountSell"; //so tien 

    }
    public class EmployeeColumn
    {
        public const string TABLE_NAME = "Employee";

        public const string EMPLOYEE_ID = "EmployeeID";
        public const string FIRST_NAME = "FirstName";
        public const string LAST_NAME = "LastName";
        public const string FULL_NAME = "FullName";

        public const string BIRTH_DAY = "BirthDay";
        public const string START_WORK = "StartWorkDate";
        public const string ID_NO = "IDNo";
        public const string MOBILE = "Mobile"; 
        public const string ADDRESS = "Address";
        public const string EMAIL = "Email";
        public const string POSITION_NAME = "PositionName";
        public const string MANAGERID = "ManagerID";
        public const string BASIC_SALARY = "BasicSalary";
 
    }
    public class InvoiceColumn
    {
        public const string TABLE_NAME = "Invoice";

        public const string INVOICE_NO = "InvoiceNo";
        public const string ORDER_DATE = "OrderDate";
        public const string DELIVERY_DATE = "DeliveryDate";
        public const string STORE_ID = "StoreID";
        public const string IN_OUT_KBN = "InOutKBN";

        public const string AMOUNT = "Amount";
        public const string DISCOUNT = "Discount";
        public const string TOTAL_AMOUNT = "TotalAmount";
        public const string PAID = "Paid";

        public const string CUSTOMER_ID = "CustomerID";
        public const string CUSTOMER_NAME = "CustomerName";
        public const string EMPLOYEE_ID = "EmployeeID";
        public const string EMPLOYEE_NAME = "EmployeeName";
        public const string NOTE = "Note";
    }
    public class PromotionColumn
    {
        public const string TABLE_NAME = "Promotion";


        public const string ID = "PromotionID";
        public const string IN_OUT_KBN = "InOutKBN";
        public const string PRODUCT_ID = "ProductID";
        public const string EXPORT_BUY = "QuantityBuy";
        public const string EXPORT_OFFER = "QuantityOffer";

        public const string START_DATE = "StartDate";
        public const string END_DATE = "EndDate";
        public const string QUANTITY_OFFER_UNIT = "QuantityOfferUnit";
    }
}
