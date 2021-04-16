using QuanlyKho.Util;
using QuanLyKho.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                FormCommon.SetUnit(cmbUnit);
                FormCommon.SetProvider(cmbProvider);
                FormCommon.SetProductType(cmbProductType);
                lblDefaultUnit.Text = Unit.GetMinUnit().UnitName;
                BindGrid();
               
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Product findObj = GetProduct(null);
                List<Product> list = Product.GetProductSearch(findObj);
                BindGrid(list);
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetProduct(null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (lblProductID.Text == "")
                    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblProductID.Text));

                Product findObj = Product.GetProduct(txtMaSP.Text.TrimEnd(), cmbUnit.SelectedValue.ToString());
                if (findObj == null)
                {
                    findObj = GetProduct(null);
                    findObj.CreateUser = "Admin";
                    findObj.Insert();
                    ProductUnit.InsertUpdateProductUnit(findObj.ProductID, findObj.UnitID, Common.GetDefaultDecimalValue(txtQuantityExchange.Text));
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_INSERT_SUCCESS"));
                    BindGrid();
                }
                else
                {
                    GetProduct(findObj);
                    findObj.UpdateUser = "Admin";
                    findObj.Update();
                    ProductUnit.InsertUpdateProductUnit(findObj.ProductID, findObj.UnitID, Common.GetDefaultDecimalValue(txtQuantityExchange.Text));
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_UPDATE_SUCCESS"));
                    BindGrid();
                }
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblProductID.Text == "")
                    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblProductID.Text));

                Product findObj = Product.GetProduct(txtMaSP.Text.TrimEnd(), cmbUnit.SelectedValue.ToString());

                if (findObj != null)
                {
                    // findObj.IsDeleted = true;
                    //findObj.UpdateUser = "ABC";
                    findObj.Delete();

                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_DELETE_SUCCESS"));
                    BindGrid();
                }

            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Product GetProduct(Product pro)
        {
            if (pro == null)
            {
                pro = new Product();
                pro.ProductID = txtMaSP.Text.TrimEnd();
            }
            pro.ProductName = txtTenSP.Text;
            pro.BuyPriceCurrent = Common.GetDecimalValue(txtGiaMua.Text);
            pro.SellPrice = Common.GetDecimalValue(txtGiaBan.Text);
            if (cmbUnit.SelectedValue != null)
            {
                pro.UnitID = Common.GetStringValue(cmbUnit.SelectedValue);
                pro.UnitName = Common.GetStringValue(cmbUnit.Text);
            }
            if (cmbProvider.SelectedValue != null)
            {
                pro.ProviderID = Common.GetStringValue(cmbProvider.SelectedValue);
                pro.ProviderName = Common.GetStringValue(cmbProvider.Text);
            }
             
            if(cmbProductType.SelectedValue != null)
              pro.ProductType = cmbProductType.SelectedValue.ToString();
     
            return pro;
        }
       
        public Product SetProduct(Product pro)
        {
            txtMaSP.Text = txtTenSP.Text = txtGiaMua.Text = txtGiaBan.Text =txtExportBuy.Text = txtExportOffer.Text ="";
            txtExportBuy.Text = txtExportOffer.Text = txtImportBuy.Text = txtImportOffer.Text = "";
            cmbProductType.SelectedIndex = 0;
            if (pro != null)
            {
                txtMaSP.Text = pro.ProductID;
                txtTenSP.Text = pro.ProductName;
                txtGiaMua.Text = Common.GetMoney(pro.BuyPriceCurrent);
                txtGiaBan.Text = Common.GetMoney(pro.SellPrice);
                if (pro.UnitID != null)
                {
                    cmbUnit.SelectedValue = Common.GetStringValue(pro.UnitID);
                }
              
                if (pro.ProductType != null)
                    cmbProductType.SelectedValue = pro.ProductType;

                if (pro.ProviderID != null)
                    cmbProvider.SelectedValue = Common.GetStringValue(pro.ProviderID);

                Promotion findPromotion = Promotion.GetPromotionInfo(Constant.KBN_EXPORT, pro.ProductID, pro.UnitID, DateTime.Now, null);
                if(findPromotion !=null)
                {
                    txtExportBuy.Text = Common.GetStringValue(findPromotion.QuantityBuy);
                    txtExportOffer.Text = Common.GetStringValue(findPromotion.QuantityOffer);
                }

                findPromotion = Promotion.GetPromotionInfo(Constant.KBN_IMPORT, pro.ProductID, pro.UnitID, DateTime.Now, null);
                if (findPromotion != null)
                {
                    txtImportBuy.Text = Common.GetStringValue(findPromotion.QuantityBuy);
                    txtImportOffer.Text = Common.GetStringValue(findPromotion.QuantityOffer);
                }

                txtQuantityExchange.Text = "1";
                ProductUnit findProductUnit = ProductUnit.GetUnitForProduct(pro.ProductID, pro.UnitID);
                if(findProductUnit != null)
                {
                    txtQuantityExchange.Text = findProductUnit.Quantity.ToString();
                }
                
            }
            return pro;
        }

        private void SelectProduct()
        {
            string productID = dgvProduct.SelectedRows[0].Cells["ProductID"].Value.ToString();
            string unitID = dgvProduct.SelectedRows[0].Cells["UnitID"].Value.ToString();
            Product findProduct = Product.GetProduct(productID, unitID);
            if (findProduct != null)
            {
                SetProduct(findProduct);
            }
        }
        private void BindGrid()
        {
            List<Product> list = Product.GetAllProduct();
            BindGrid(list);
        }
        private void BindGrid(List<Product> List)
        {
            dgvProduct.Rows.Clear();

            for (int i = 0; i < List.Count; i++)
            {
                int row = dgvProduct.Rows.Add();
                dgvProduct.Rows[row].Cells["No"].Value = i + 1;
                dgvProduct.Rows[row].Cells["ProductID"].Value = List[i].ProductID;
                dgvProduct.Rows[row].Cells["ProductName"].Value = List[i].ProductName;
                dgvProduct.Rows[row].Cells["UnitName"].Value = List[i].UnitName;
                dgvProduct.Rows[row].Cells["ProviderName"].Value = List[i].ProviderName;
                dgvProduct.Rows[row].Cells["BuyPriceCurrent"].Value = Common.GetMoney(List[i].BuyPriceCurrent);
                dgvProduct.Rows[row].Cells["SellPrice"].Value = Common.GetMoney(List[i].SellPrice);
                dgvProduct.Rows[row].Cells["UnitID"].Value = List[i].UnitID;
            }
            if (List.Count > 0)
                SelectProduct();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectProduct();
        }

        private void dgvProduct_KeyUp(object sender, KeyEventArgs e)
        {
            SelectProduct();
        }

       
    }
}
