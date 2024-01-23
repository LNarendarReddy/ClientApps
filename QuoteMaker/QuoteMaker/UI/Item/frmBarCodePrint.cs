using QuoteMaker.Repository;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuoteMaker.UI.Items
{
    public partial class frmBarCodePrint : DevExpress.XtraEditors.XtraForm
    {
        public frmBarCodePrint()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider11.Validate())
                    return;
                Utility.PrintBarCode(cmbItemCode.Text, txtItemName.Text,
                    txtSalePrice.Text, txtQuantity.EditValue, txtMRP.EditValue,cmbCategory.EditValue);
                cmbItemCode.EditValue = null;
                txtItemName.EditValue = null;
                txtSalePrice.EditValue = null;
                txtMRP.EditValue = null;
                txtQuantity.EditValue = null;
                cmbCategory.EditValue = null;
                cmbItemCode.Focus();
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void frmBarCodePrint_Load(object sender, EventArgs e)
        {
            try
            {
                cmbItemCode.Properties.DataSource = Utility.GetItemCodeList();
                cmbItemCode.Properties.DisplayMember = "ITEMCODE";
                cmbItemCode.Properties.ValueMember = "ITEMCODEID";

                cmbCategory.Properties.DataSource = new RepositoryBase().GetDataTable("USP_R_CATEGORY");
                cmbCategory.Properties.DisplayMember = "CATEGORYNAME";
                cmbCategory.Properties.ValueMember = "CATEGORYID";
            }
            catch (Exception ex){}
        }

        private void cmbItemCode_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbItemCode.EditValue != null)
                {
                    txtItemName.EditValue = cmbLookupView.GetFocusedRowCellValue("ITEMNAME");
                    cmbCategory.EditValue = cmbLookupView.GetFocusedRowCellValue("CATEGORYID");

                    Dictionary<string, object> parameters = new Dictionary<string, object>()
                    {
                        {"ITEMCODEID",  cmbItemCode.EditValue}
                    };
                    DataTable dtMRPList =
                        new RepositoryBase().GetDataTable("USP_R_ITEMMRPLIST", parameters);

                    if (dtMRPList.Rows.Count > 1)
                    {
                        frmMRPList obj = new frmMRPList(dtMRPList);
                        obj.ShowDialog();
                        if (obj._IsSave)
                        {
                            txtMRP.EditValue = ((DataRowView)obj.drSelected)["MRP"];
                            txtSalePrice.EditValue = ((DataRowView)obj.drSelected)["SALEPRICE"];
                        }
                    }
                    else
                    {
                        txtMRP.EditValue = dtMRPList.Rows[0]["MRP"];
                        txtSalePrice.EditValue = dtMRPList.Rows[0]["SALEPRICE"];
                    }
                    txtQuantity.EditValue = 1;
                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}