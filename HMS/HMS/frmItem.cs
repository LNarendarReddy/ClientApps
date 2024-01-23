using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Resources;
using System.Reflection;
using EL;
using DL;
using DevExpress.XtraGrid.Views.Grid;

namespace HMS
{
    public partial class frmItem : DevExpress.XtraEditors.XtraForm
    {
        EItem ObjEItem = new EItem();
        DItem ObjDItem = new DItem();
        public frmItem()
        {
            InitializeComponent();
        }
        private void frmMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                LoadItemDetails();
                LoadItemCategory();
                if (Utility.UserName != "admin")
                    gcEdit.Visible = false;
                ObjDItem.GetNewItemCode(ObjEItem);
                txtItemCode.Text = ObjEItem.ItemCode;
                txtItemName.Focus();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void LoadItemCategory()
        {
            try
            {
                ObjEItem.BranchID = Utility.BranchID;
                ObjDItem.GetItemCategory(ObjEItem);
                cmbItemCategory.Properties.DataSource = ObjEItem.dtItemCategory;
                cmbItemCategory.Properties.ValueMember = "ItemCategoryID";
                cmbItemCategory.Properties.DisplayMember = "CategoryName";
            }
            catch (Exception ex) { }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
                try
                {
                    if (!dxValidationProvider1.Validate())
                        return;

                    if (ObjEItem.ItemID <= 0)
                        ObjEItem.ItemID = -1;
                    ObjEItem.ItemCode = txtItemCode.Text.Trim();
                    ObjEItem.ItemName = txtItemName.Text.Trim();
                    ObjEItem.ItemCategoryID = Convert.ToInt32(cmbItemCategory.EditValue);
                    ObjEItem.SPrice = Convert.ToDouble(txtSPrice.EditValue);
                    ObjEItem.ServicePrice = Convert.ToDouble(txtServicePrice.EditValue);
                    ObjEItem.BranchID = Utility.BranchID;
                    ObjEItem.OrgID = Utility.OrgID;
                    ObjEItem.UserID = Utility.UserID;
                    ObjDItem.SaveItem(ObjEItem);
                    gcItem.DataSource = ObjEItem.dtItemList;
                    Utility.Setfocus(gvItem, "ItemID", ObjEItem.ItemID);
                    clearFields();
                }
                catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void LoadItemDetails()
        {
            try
            {
                ObjEItem.BranchID = Utility.BranchID;
                ObjDItem.GetItemList(ObjEItem);
                gcItem.DataSource = ObjEItem.dtItemList;
            }
            catch (Exception ex) { throw ex; }
        }
        private void clearFields()
        {
            ObjDItem.GetNewItemCode(ObjEItem);
            txtItemCode.Text = ObjEItem.ItemCode;
            txtItemName.Text = string.Empty;
            cmbItemCategory.EditValue = null;
            txtSPrice.Text = string.Empty;
            txtServicePrice.Text = string.Empty;
            txtItemName.Focus();
            ObjEItem.ItemID = -1;
        }
        private void gvItem_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }
        private void btnNewItem_Click(object sender, EventArgs e)
        {
            ObjEItem.ItemID = -1;
            clearFields();
        }
        private void btnAddItemCategory_Click(object sender, EventArgs e)
        {
            try
            {
                frmItemCategory Obj = new frmItemCategory();
                Obj.ShowDialog();
                LoadItemCategory();
            }
            catch (Exception ex){}
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }
        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEItem.ItemID = Convert.ToInt32(gvItem.GetFocusedRowCellValue("ItemID"));
                txtItemCode.EditValue = gvItem.GetFocusedRowCellValue("ItemCode");
                txtItemName.EditValue = gvItem.GetFocusedRowCellValue("ItemName");
                cmbItemCategory.EditValue = gvItem.GetFocusedRowCellValue("ItemCategoryID");
                txtSPrice.EditValue = gvItem.GetFocusedRowCellValue("SPrice");
                txtServicePrice.EditValue = gvItem.GetFocusedRowCellValue("ServicePrice");
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}