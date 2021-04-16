using QuanlyKho.Util;
using QuanLyKho.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKho
{
    public class FormCommon
    {
        public static void ShowWindowMessageOK(string content)
        {
            MessageBox.Show(content, Common.GetResouceString("TITLE_INFO"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public static void ShowWindowMessageOK(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public static void ShowWindowMessageError(string content)
        {
            MessageBox.Show(content, Common.GetResouceString("TITLE_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowWindowMessageError(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult ShowWindowMessageConfirm(string content)
        {
            return MessageBox.Show(content, Common.GetResouceString("TITLE_CONFIRM"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void SetDropDownList(ComboBox cmb,string displayMember, string valueMember, List<object> list)
        {
            cmb.Items.Clear();
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = list;

        }
        public static void SetUnit(ComboBox cmb)
        {
            List<Unit> list = Unit.GetAllUnit();

            if (list == null)
                throw new Exception(Common.GetResouceString("DATA_MUST_VALUE_IN_UNIT"));


            cmb.Items.Clear();
            cmb.DisplayMember = "UnitName";
            cmb.ValueMember = "UnitID";
            cmb.DataSource = list;
            
        }
        public static void SetProvider(ComboBox cmb)
        {
            List<Provider> list = Provider.GetAllProvider();

            if (list == null)
                throw new Exception(Common.GetResouceString("DATA_MUST_VALUE_IN_PROVIDER"));


            cmb.Items.Clear();
            cmb.DisplayMember = "ProviderName";
            cmb.ValueMember = "ProviderID";
            cmb.DataSource = list;
        }
        public static void SetStore(ComboBox cmb, bool isFirstEmpty)
        {
            List<Store> list = Store.GetAllStore();

            if (list == null && isFirstEmpty == false)
                throw new Exception(Common.GetResouceString("DATA_MUST_VALUE_IN_STORE"));


            cmb.Items.Clear();
            if (isFirstEmpty)
                list.Insert(0, new Store(0, ""));
          
            cmb.DisplayMember = "StoreName";
            cmb.ValueMember = "StoreID";
            cmb.DataSource = list;
        }
        public static void SetProduct(ComboBox cmb)
        {
            List<Product> listAllProduct = Product.GetAllProduct().GroupBy(p => p.ProductID).Select(g => g.First()).ToList();

            if (listAllProduct == null)
                throw new Exception(Common.GetResouceString("DATA_MUST_VALUE_IN_PRODUCT"));

            cmb.Items.Clear();
            cmb.DisplayMember = "ProductName";
            cmb.ValueMember = "ProductID";
            cmb.DataSource = listAllProduct;
            
        }
        public static void SetEmployee(ComboBox cmb, bool isFirstEmpty)
        {
            List<Employee> list = Employee.GetAllEmployee();

            cmb.Items.Clear();
            if (isFirstEmpty)
                list.Insert(0, new Employee("", ""));

            cmb.DisplayMember = "FullName";
            cmb.ValueMember = "EmployeeID";
            cmb.DataSource = list;
        }

        public static void SetCustomer(ComboBox cmb, bool isFirstEmpty)
        {
            List<Customer> list = Customer.GetAllCustomer();

            cmb.Items.Clear();
            if (isFirstEmpty)
            {
                list.Insert(0, new Customer("", ""));
                //cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //AutoCompleteStringCollection  arrCustomerName = new AutoCompleteStringCollection();
                //foreach(Customer i in list)
                //{
                //    arrCustomerName.Add(i.CustomerName);
                //}
                //cmb.AutoCompleteCustomSource = arrCustomerName;
            }

            cmb.DisplayMember = "CustomerName";
            cmb.ValueMember = "CustomerID";
            cmb.DataSource = list;

        }
       
        public static void SetPosition(ComboBox cmb, bool isFirstEmpty)
        {
            cmb.Items.Clear();
            if (isFirstEmpty)
                cmb.Items.Add("");

            cmb.Items.Add("Nhân viên bán hàng");
            cmb.Items.Add("Nhân viên giao hàng");
   
        }
        public static void SetStatus(ComboBox cmb)
        {

            List<CodeName> list = new List<CodeName>();
            list.Add(new CodeName("0","Tất cả"));
            list.Add(new CodeName(Constant.KBN_ORDER.ToString(), "Các Order"));
            list.Add(new CodeName(Constant.KBN_EXPORT.ToString(), "Xuất Kho"));
            list.Add(new CodeName(Constant.KBN_IMPORT.ToString(), "Nhập Kho"));
            cmb.Items.Clear();

            cmb.DisplayMember = "Name";
            cmb.ValueMember = "Code";
            cmb.DataSource = list;
          

        }
        public static void SetPromotion(ComboBox cmb)
        {
            List<CodeName> list = new List<CodeName>();

            list.Add(new CodeName(Constant.KBN_EXPORT.ToString(), "khuyến mãi Xuất Kho"));
            list.Add(new CodeName(Constant.KBN_IMPORT.ToString(), "khuyến mãi Nhập Kho"));
            cmb.Items.Clear();

            cmb.DisplayMember = "Name";
            cmb.ValueMember = "Code";
            cmb.DataSource = list;


        }
        public static void SetProductType(ComboBox cmb)
        {
            List<ProductType> listAllProduct = ProductType.GetAllProductType();

            if (listAllProduct == null)
                throw new Exception(Common.GetResouceString("DATA_MUST_VALUE_IN_PRODUCT"));

            cmb.Items.Clear();

            listAllProduct.Insert(0, new ProductType());
            cmb.DisplayMember = "ProductTypeName";
            cmb.ValueMember = "ProductTypeID";

            cmb.DataSource = listAllProduct;
        }
    }
}
