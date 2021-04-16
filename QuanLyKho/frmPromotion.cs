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
    public partial class frmPromotion : Form
    {
        public frmPromotion()
        {
            InitializeComponent();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPromotion_Load(object sender, EventArgs e)
        {
            try
            {
                FormCommon.SetPromotion(cmbPromotionType);

                cmbPromotionType.SelectedIndex = 0;
                FormCommon.SetUnit(cmbUnit);
                FormCommon.SetUnit(cmbUnitOffer);
                FormCommon.SetProduct(cmbProduct);
                cmbProduct.SelectedIndex = 0;

                dtpEndDate.Value = DateTime.Now.AddDays(30);
                BindGrid();

            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue != null)
            {
                txtMaSP.Text = cmbProduct.SelectedValue.ToString();
                //set Unit agian 
                
                List<CodeName> listUnit = Product.GetListUnitFromProduct(txtMaSP.Text);
                if (listUnit.Count > 0)
                {
                    cmbUnit.DataSource = null;
                    cmbUnit.DisplayMember = "Name";
                    cmbUnit.ValueMember = "Code";
                    cmbUnit.DataSource = listUnit;
                    cmbUnit.SelectedIndex = 0;
                }

                SetProductInfo();
            }   
        }

        
        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            SetProductInfo();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblProductID.Text == "")
                    throw new Exception(string.Format(Common.GetResouceString("MSG_CAN_NOT_NULL_ID"), lblProductID.Text));
                Promotion findObj = GetPromotion(null); 
                findObj.CreateUser = "Admin";
                findObj.Insert();
                FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_INSERT_SUCCESS"));
                BindGrid();
            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int promotionID = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["PromotionID"].Value);
                int inOutKBN = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["InOutKBN"].Value);
                Promotion findObj = Promotion.GetPromotion(inOutKBN, promotionID);
                GetPromotion(findObj);

                findObj.UpdateUser = "Admin";
                findObj.Update();
                FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_UPDATE_SUCCESS"));
                BindGrid();

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
                int promotionID = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["PromotionID"].Value);
                int inOutKBN = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["InOutKBN"].Value);

                Promotion findObj = Promotion.GetPromotion(inOutKBN, promotionID);

                if (findObj != null)
                {
                    findObj.IsDeleted = true;
                    findObj.UpdateUser = "Admin";
                    findObj.Update();
                    FormCommon.ShowWindowMessageOK(Common.GetResouceString("MSG_DELETE_SUCCESS"));
                    BindGrid();
                }

            }
            catch (Exception ex)
            {
                FormCommon.ShowWindowMessageError(ex.Message);
            }
        }
        private void SetProductInfo()
        {
            if (cmbUnit.SelectedValue != null)
            {
                Product findProduct = Product.GetProduct(txtMaSP.Text, cmbUnit.SelectedValue.ToString());
                if (findProduct != null)
                {
                    cmbProduct.SelectedValue = findProduct.ProductID;
                    txtGiaBan.Text = Common.GetMoney(findProduct.SellPrice);
                    txtGiaMua.Text = Common.GetMoney(findProduct.BuyPriceCurrent);

                    //lay don vi nho nhat
                }
            }
        }
      
        private Promotion SetPromotion(Promotion findPromotion)
        {

            txtMaSP.Text = txtGiaMua.Text = txtGiaBan.Text = txtQuantityBuy.Text = txtQuantityOffer.Text = "";
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(90);
            cmbProduct.SelectedIndex = 0;

            if (findPromotion != null)
            {
                cmbProduct.SelectedValue = findPromotion.PromotionID;
                txtMaSP.Text = findPromotion.ProductID;
                SetProductInfo();
                txtQuantityBuy.Text = Common.GetStringValue(findPromotion.QuantityBuy);
                txtQuantityOffer.Text = Common.GetStringValue(findPromotion.QuantityOffer);
                cmbUnit.SelectedValue = findPromotion.UnitID;
                cmbUnitOffer.SelectedValue = findPromotion.QuantityOfferUnit;
                dtpStartDate.Value = findPromotion.StartDate;
                dtpEndDate.Value = findPromotion.EndDate;
            }
            return findPromotion;
        }
        private Promotion GetPromotion(Promotion findObj)
        {
            if (findObj == null)
            {
                findObj = new Promotion();
                findObj.InOutKBN = Convert.ToInt32(cmbPromotionType.SelectedValue);
                findObj.PromotionID = Promotion.GetNextPromotionID(findObj.InOutKBN);
            }
            findObj.ProductID = cmbProduct.SelectedValue.ToString();
            findObj.UnitID = cmbUnit.SelectedValue.ToString();
            findObj.QuantityBuy = Common.GetIntValue(txtQuantityBuy.Text);
            findObj.QuantityOffer = Common.GetIntValue(txtQuantityOffer.Text);
            findObj.QuantityOfferUnit = cmbUnitOffer.SelectedValue.ToString();
            findObj.StartDate = dtpStartDate.Value;
            findObj.EndDate = dtpEndDate.Value;
            return findObj;
        }
        private void SelectPromotion()
        {
            try
            {
                int promotionID = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["PromotionID"].Value.ToString());
                int inOutKBN = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["InOutKBN"].Value.ToString());
                Promotion findPromotion = Promotion.GetPromotion(inOutKBN, promotionID);
                if (findPromotion != null)
                {
                    SetPromotion(findPromotion);
                }
            }
            catch
            { }
        }

        #region GridView Event
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectPromotion();
        }
       
        private void dgvProduct_KeyUp(object sender, KeyEventArgs e)
        {
            SelectPromotion();
        }

        private void BindGrid()
        {
            List<Promotion> list = Promotion.GetAllPromotionSearch(Common.GetIntValue(cmbPromotionType.SelectedValue.ToString()), chkOldPromotion.Checked , chkInPromotion.Checked);
            BindGrid(list);
        }
        private void BindGrid(List<Promotion> List)
        {
            dgvProduct.Rows.Clear();

            for (int i = 0; i < List.Count; i++)
            {
                int row = dgvProduct.Rows.Add();
                dgvProduct.Rows[row].Cells["No"].Value = i + 1;
                dgvProduct.Rows[row].Cells["ProductID"].Value = List[i].ProductID;
                dgvProduct.Rows[row].Cells["UnitID"].Value = List[i].UnitID;
                dgvProduct.Rows[row].Cells["UnitName"].Value = Unit.GetUnit(List[i].UnitID).UnitName;
                Product findProduct = Product.GetProduct(List[i].ProductID, List[i].UnitID);
                if (findProduct != null)
                {
                    dgvProduct.Rows[row].Cells["ProductName"].Value = findProduct.ProductName;
                    if (List[i].InOutKBN == Constant.KBN_IMPORT)
                        dgvProduct.Rows[row].Cells["Price"].Value = Common.GetMoney(findProduct.BuyPriceCurrent);
                    else
                        dgvProduct.Rows[row].Cells["Price"].Value = Common.GetMoney(findProduct.SellPrice);
                }
                dgvProduct.Rows[row].Cells["QuantityBuy"].Value = List[i].QuantityBuy;
                dgvProduct.Rows[row].Cells["QuantityOffer"].Value = List[i].QuantityOffer;
                dgvProduct.Rows[row].Cells["StartDate"].Value = Common.GetShortDate(List[i].StartDate);
                dgvProduct.Rows[row].Cells["EndDate"].Value = Common.GetShortDate(List[i].EndDate);
                dgvProduct.Rows[row].Cells["PromotionID"].Value = List[i].PromotionID;
                dgvProduct.Rows[row].Cells["InOutKBN"].Value = List[i].InOutKBN;
            }
            if(List.Count > 0)
            {
                SelectPromotion();
            }
        }
        #endregion

        private void cmbPromotionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void chkInPromotion_CheckedChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void chkOldPromotion_CheckedChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetProductInfo();
        }

   

      


    }
}
