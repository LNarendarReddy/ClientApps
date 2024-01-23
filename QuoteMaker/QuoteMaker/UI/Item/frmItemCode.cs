using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QuoteMaker.Models;
using QuoteMaker.Repository;

namespace QuoteMaker.UI.Items
{
    public partial class frmItemCode : DevExpress.XtraEditors.XtraForm
    {
        Item itemObj;
        GridView gvItemCode;
        bool isLoading, isEditMode;

        public frmItemCode(Item item)
        {
            InitializeComponent();
            itemObj = item;
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            frmItemCodeList parentForm = Owner as frmItemCodeList;
            gvItemCode = parentForm.ItemCodeListGridView;

            chkIsEAN_CheckedChanged(null, null);
            BindDataSource(false);

            // setting the item code calls the get proc and loads all values
            txtItemCode.EditValue = itemObj.ItemCode;
            luSubCategory.CascadingOwner = gluCategory;
            luSubCategory.Properties.CascadingMember = "CATEGORYID";

            txtItemCode_Properties_Leave(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxItemValidationProvider.Validate())
                    return;
                if (decimal.TryParse(Convert.ToString(txtMRP.EditValue), out decimal MRP) &&
                    decimal.TryParse(Convert.ToString(txtSalePrice.EditValue), out decimal salePrice))
                {
                    string message = string.Empty;
                    message = MRP < salePrice ? "MRP cannot be less than sale price" : message;

                    if (!string.IsNullOrEmpty(message))
                    {
                        XtraMessageBox.Show(message);
                        return;
                    }
                }

                itemObj.ItemCode = txtItemCode.Text;                
                itemObj.HSNCode = txtHSNCode.EditValue;
                itemObj.SKUCode = sluSKUCode.Text;
                itemObj.ItemID = sluSKUCode.EditValue;
                itemObj.ItemName = txtItemName.EditValue;
                itemObj.SalePrice = txtSalePrice.EditValue;
                itemObj.MRP = txtMRP.EditValue;
                itemObj.UserID = Utility.UserID;
                itemObj.GSTID = luGST.EditValue;
                itemObj.CategoryID = gluCategory.EditValue;
                itemObj.CategoryName = gluCategory.Text;
                itemObj.SubCategoryID = luSubCategory.EditValue;
                itemObj.SubCategoryName = luSubCategory.Text;
                itemObj.IsEAN = chkIsEAN.CheckState;

                string result = new RepositoryBase().Execute<string>("USP_CU_ITEMCODE", itemObj.Params);
                if(!string.IsNullOrEmpty(result) && result.Split(',').Count() > 0)
                {
                    if (int.TryParse(result.Split(',')[0], out int itemcodeid))
                        itemObj.ItemCodeID = itemcodeid;
                    if (int.TryParse(result.Split(',')[1], out int itemid))
                        itemObj.ItemID = itemid;
                }

                // refresh values back in data tables
                DataTable dtItemSKUList = Utility.GetItemSKUList();
                DataTable dtItemCodeList = Utility.GetItemCodeList();

                int itemSKURowHandle, itemCodeRowHandle;
                itemSKURowHandle = gvItemSKU.LocateByValue("SKUCODE", itemObj.SKUCode);
                itemCodeRowHandle = gvItemCode.LocateByValue("ITEMCODE", itemObj.ItemCode);

                if(itemSKURowHandle != GridControl.InvalidRowHandle)
                {
                    DataRow drItemSKU = dtItemSKUList.Rows[itemSKURowHandle];
                    drItemSKU["ITEMID"] =  itemObj.ItemID;
                    drItemSKU["ITEMNAME"] = itemObj.ItemName;
                }
                else
                {
                    DataRow drNew = dtItemSKUList.NewRow();
                    drNew["ITEMID"] = itemObj.ItemID;
                    drNew["ITEMNAME"] = itemObj.ItemName;
                    dtItemSKUList.Rows.Add(drNew);
                }


                if (itemCodeRowHandle != GridControl.InvalidRowHandle)
                {
                    gvItemCode.SetRowCellValue(itemCodeRowHandle, "ITEMID", itemObj.ItemID);
                    gvItemCode.SetRowCellValue(itemCodeRowHandle, "ITEMNAME", itemObj.ItemName);
                    gvItemCode.SetRowCellValue(itemCodeRowHandle, "ITEMCODEID", itemObj.ItemCodeID);
                    gvItemCode.SetRowCellValue(itemCodeRowHandle, "SKUCODE", itemObj.SKUCode);
                    gvItemCode.SetRowCellValue(itemCodeRowHandle, "CATEGORYNAME", itemObj.CategoryName);
                    gvItemCode.SetRowCellValue(itemCodeRowHandle, "SUBCATEGORYNAME", itemObj.SubCategoryName);
                }
                else
                {
                    DataRow drNewItemCode = dtItemCodeList.NewRow();
                    drNewItemCode["ITEMID"] = itemObj.ItemID;
                    drNewItemCode["ITEMNAME"] = itemObj.ItemName;
                    drNewItemCode["ITEMCODE"] = itemObj.ItemCode;
                    drNewItemCode["ITEMCODEID"] = itemObj.ItemCodeID;
                    drNewItemCode["SKUCODE"] = itemObj.SKUCode;
                    drNewItemCode["CATEGORYNAME"] = itemObj.CategoryName;
                    drNewItemCode["SUBCATEGORYNAME"] = itemObj.SubCategoryName;
                    drNewItemCode["CREATEDBY"] = Utility.FullName;
                    drNewItemCode["CREATEDDATE"] = DateTime.Now;
                    dtItemCodeList.Rows.Add(drNewItemCode);
                }

                itemObj.IsSave = true;
                itemObj.IsNewToggleSwitched = tsCreateNew.EditValue;
                this.Close();

            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void chkIsEAN_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            txtItemCode.ReadOnly = !chkIsEAN.Checked;
            if (!chkIsEAN.Checked)
                txtItemCode.EditValue = sluSKUCode.Text;
        }

        private void searchLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            bool hasValue = sluSKUCode.EditValue != null && (int)sluSKUCode.EditValue > 0 && gvItemSKU.GetFocusedDataRow() != null;

            txtItemName.EditValue = hasValue ? gvItemSKU.GetFocusedDataRow()["ITEMNAME"] : string.Empty;
            txtItemCode.EditValue = hasValue && !chkIsEAN.Checked ? gvItemSKU.GetFocusedDataRow()["SKUCODE"] : txtItemCode.EditValue;
        }

        private void btnAddSKU_Click(object sender, EventArgs e)
        {
            ItemNewCode itemNewCodeObj = new ItemNewCode() { isSKUorItem = true };
            new frmAddCode(itemNewCodeObj).ShowDialog();
            if(!itemNewCodeObj.IsSave)
            {
                return;
            }

            DataTable dtItems = Utility.GetItemSKUList();
            DataRow drNewSKUCode = dtItems.NewRow();
            drNewSKUCode["ITEMID"] = -1;
            drNewSKUCode["SKUCODE"] = itemNewCodeObj.Code;
            dtItems.Rows.Add(drNewSKUCode);
            gvItemSKU.RefreshData();
            sluSKUCode.EditValue = -1;
        }

        private void BindDataSource(bool refresh)
        {
            object selectedSKU = null, selectedGST = null, selectedItemCode = null;

            if (refresh)
            {
                selectedSKU = sluSKUCode.EditValue;
                selectedItemCode = txtItemCode.EditValue;
                selectedGST = luGST.EditValue;
            }

            sluSKUCode.Properties.DataSource = Utility.GetItemSKUList();
            sluSKUCode.Properties.DisplayMember = "SKUCODE";
            sluSKUCode.Properties.ValueMember = "ITEMID";
            
            luGST.Properties.DataSource = Utility.GetGSTInfoList();
            luGST.Properties.DisplayMember = "GSTCODE";
            luGST.Properties.ValueMember = "GSTID";

            DataView dvCategory = new RepositoryBase().GetDataTable("USP_R_CATEGORY").DefaultView;
            dvCategory.RowFilter = "CATEGORYNAME <> 'ALL'";
            gluCategory.Properties.DataSource = dvCategory;
            gluCategory.Properties.DisplayMember = "CATEGORYNAME";
            gluCategory.Properties.ValueMember = "CATEGORYID";
            if(dvCategory.Count == 1)
            {
                gluCategory.EditValue = dvCategory[0]["CATEGORYID"];
            }

            luSubCategory.Properties.DataSource = new RepositoryBase().GetDataTable("USP_R_SUBCATEGORY").DefaultView;
            luSubCategory.Properties.DisplayMember = "SUBCATEGORYNAME";
            luSubCategory.Properties.ValueMember = "SUBCATEGORYID";

            if (refresh)
            {
                txtItemCode.EditValue = selectedItemCode;
                sluSKUCode.EditValue = selectedSKU;
                luGST.EditValue = selectedGST;
            }

            if(!refresh)
            {
                gvItemSKU.GridControl.BindingContext = new BindingContext();
                gvItemSKU.GridControl.DataSource = sluSKUCode.Properties.DataSource;
            }
        }

        private void frmItemCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(itemObj.IsSave)
            {
                return;
            }

            // remove items added to data tables but not saved
            DataTable dtItemSKUList = Utility.GetItemSKUList();
            DataTable dtItemCodeList = Utility.GetItemCodeList();

            int itemSKURowHandle, itemCodeRowHandle;
            itemSKURowHandle = gvItemSKU.LocateByValue("ITEMID", -1);
            itemCodeRowHandle = gvItemCode.LocateByValue("ITEMCODEID", -1);

            if (itemSKURowHandle != GridControl.InvalidRowHandle)
            {
                dtItemSKUList.Rows.RemoveAt(itemSKURowHandle);
            }

            if (itemCodeRowHandle != GridControl.InvalidRowHandle)
            {
                dtItemCodeList.Rows.RemoveAt(itemCodeRowHandle);
            }
        }

        private void ClearUI()
        {
            txtHSNCode.EditValue = null;
            chkIsEAN.EditValue = true;
            sluSKUCode.EditValue = null;
            txtItemName.EditValue = null;
            Text = "New Item";
            itemObj.ItemID = null;
            gluCategory.EditValue = null;
            txtSalePrice.EditValue = null;
            txtMRP.EditValue = null;
            luGST.EditValue = null;
            luSubCategory.EditValue = null;
            isEditMode = false;
        }

        private void txtItemCode_Properties_Leave(object sender, EventArgs e)
        {
            // do not load again unless code changes
            if (isEditMode && itemObj.ItemCode.Equals(txtItemCode.EditValue)) return;

            if (string.IsNullOrEmpty(Convert.ToString(txtItemCode.EditValue)))
            {
                ClearUI();
                return;
            }

            int rowHandle = gvItemCode.LocateByValue("ITEMCODE", txtItemCode.EditValue);

            // if the scanned item is already existing, go into edit mode
            if (rowHandle != GridControl.InvalidRowHandle)
            {
                gvItemCode.FocusedRowHandle = rowHandle;
                itemObj.ItemCodeID = gvItemCode.GetFocusedRowCellValue("ITEMCODEID");
            }
            else
            {
                ClearUI();
                return;
            }
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"ItemCodeID",  itemObj.ItemCodeID}
            };
            DataSet dsItemDetails = new RepositoryBase().GetDataset("USP_R_ITEMCODE", parameters);

            DataTable dtItemDetails = dsItemDetails.Tables[0];

            if(dtItemDetails.Rows.Count == 0)
            {
                ClearUI();
                return;
            }

            isLoading = true;
            txtHSNCode.EditValue = dtItemDetails.Rows[0]["HSNCODE"];
            chkIsEAN.EditValue = dtItemDetails.Rows[0]["ISEAN"];
            sluSKUCode.EditValue = dtItemDetails.Rows[0]["ITEMID"];
            txtItemName.EditValue = dtItemDetails.Rows[0]["ITEMNAME"];
            Text = "Edit Item - " + txtItemName.Text;
            itemObj.ItemID = dtItemDetails.Rows[0]["ITEMID"];
            itemObj.ItemCode = dtItemDetails.Rows[0]["ITEMCODE"];
            gluCategory.EditValue = dtItemDetails.Rows[0]["CATEGORYID"];
            luSubCategory.EditValue = dtItemDetails.Rows[0]["SUBCATEGORYID"];

            DataTable dtItemCodePrices = dsItemDetails.Tables[1];
            DataRow selectedPrice = dtItemCodePrices.Rows[0];

            if (dtItemCodePrices.Rows.Count > 1)
            {
                frmMRPList frmMRPList = new frmMRPList(dtItemCodePrices, showCostPrice: true);
                frmMRPList.ShowDialog();
                if (!frmMRPList._IsSave)
                {
                    this.Close();
                    return;
                }

                selectedPrice = (frmMRPList.drSelected as DataRowView).Row;
            }
            txtSalePrice.EditValue = selectedPrice["SALEPRICE"];
            txtMRP.EditValue = selectedPrice["MRP"];
            luGST.EditValue = selectedPrice["GSTID"];

            isLoading = false;
            isEditMode = true;
        }

        private void gluCategory_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView drCategory = gluCategory.GetSelectedDataRow() as DataRowView;
            if (isLoading) return;
            luSubCategory.EditValue = null;
        }
        
    }
}
