using DevExpress.XtraEditors;
using QuoteMaker.Models;
using QuoteMaker.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuoteMaker.UI.Masters
{
    public partial class frmSubCategoryList : DevExpress.XtraEditors.XtraForm
    {
        SubCategory subCategory = null;
        public frmSubCategoryList()
        {
            InitializeComponent();
        }

        private void frmSubCategoryList_Load(object sender, EventArgs e)
        {
            try
            {
                gcSubCategory.DataSource = new RepositoryBase().GetDataTable("USP_R_SUBCATEGORY");
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            subCategory = new SubCategory();
            frmSubCategory obj = new frmSubCategory(subCategory);
            obj.ShowInTaskbar = false;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.IconOptions.ShowIcon = false;
            obj.ShowDialog();
            if (subCategory.IsSave)
            {
                gcSubCategory.DataSource = new RepositoryBase().GetDataTable("USP_R_SUBCATEGORY");
                Utility.Setfocus(gvSubCategory, "SUBCATEGORYID", subCategory.SUBCATEGORYID);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gvSubCategory.FocusedRowHandle >= 0)
                {
                    subCategory = new SubCategory();
                    subCategory.SUBCATEGORYID = gvSubCategory.GetFocusedRowCellValue("SUBCATEGORYID");
                    subCategory.SUBCATEGORYNAME = gvSubCategory.GetFocusedRowCellValue("SUBCATEGORYNAME");
                    subCategory.CATEGORYID = gvSubCategory.GetFocusedRowCellValue("CATEGORYID");
                    frmSubCategory obj = new frmSubCategory(subCategory);
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.IconOptions.ShowIcon = false;
                    obj.ShowDialog();
                    if (subCategory.IsSave)
                    {
                        gcSubCategory.DataSource = new RepositoryBase().GetDataTable("USP_R_SUBCATEGORY");
                        Utility.Setfocus(gvSubCategory, "SUBCATEGORYID", subCategory.SUBCATEGORYID);
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var dlgResult = XtraMessageBox.Show("Are you sure want to delete?", "Confirmation!", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Convert.ToString(dlgResult) == "OK" && gvSubCategory.FocusedRowHandle >= 0)
                {
                    Dictionary<string,object> parameters = new Dictionary<string, object>() 
                    {
                        { "SUBCATEGORYID", gvSubCategory.GetFocusedRowCellValue("SUBCATEGORYID")},
                        { "USERID" , Utility.UserID}
                    };
                    new RepositoryBase().Execute<int>("USP_D_SUBCATEGORY", parameters);
                    gvSubCategory.DeleteRow(gvSubCategory.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcSubCategory.ShowRibbonPrintPreview();
        }
    }
}