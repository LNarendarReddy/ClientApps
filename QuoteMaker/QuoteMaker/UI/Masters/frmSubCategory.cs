using QuoteMaker.Models;
using QuoteMaker.Repository;
using System;

namespace QuoteMaker.UI.Masters
{
    public partial class frmSubCategory : DevExpress.XtraEditors.XtraForm
    {
        SubCategory subCategory = null;
        public frmSubCategory(SubCategory _subCategory)
        {
            InitializeComponent();
            subCategory = _subCategory;
        }

        private void frmSubCategory_Load(object sender, EventArgs e)
        {
            cmbCategory.Properties.DataSource = new RepositoryBase().GetDataTable("USP_R_CATEGORY");
            cmbCategory.Properties.DisplayMember = "CATEGORYNAME";
            cmbCategory.Properties.ValueMember = "CATEGORYID";
            if (Convert.ToInt32(subCategory.SUBCATEGORYID) > 0)
            {
                this.Text = "Edit Sub Category";
                txtsubCategoryName.EditValue = subCategory.SUBCATEGORYNAME;
                cmbCategory.EditValue = subCategory.CATEGORYID;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                subCategory.SUBCATEGORYNAME = txtsubCategoryName.EditValue;
                subCategory.CATEGORYID = cmbCategory.EditValue;
                subCategory.UserID = Utility.UserID;
                subCategory.SUBCATEGORYID = new RepositoryBase().Execute<int>("USP_CU_SUBCATEGORY", subCategory.Params);
                subCategory.IsSave = true;
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            subCategory.IsSave = false;
            this.Close();
        }
    }
}