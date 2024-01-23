using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QuoteMaker.Repository;
using System.Collections.Generic;

namespace QuoteMaker.UI.Masters
{
    public partial class frmCategoryList : DevExpress.XtraEditors.XtraForm
    {
        Models.Category category = null;
        public frmCategoryList()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            try
            {
                gcCategory.DataSource = new RepositoryBase().GetDataTable("USP_R_CATEGORY");
            }
            catch (Exception ex) {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void gvCategory_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["CATEGORYID"], -1);
            }
            catch (Exception ex) { }
        }

        private void gvCategory_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                category = new Models.Category();
                GridView view = sender as GridView;
                DataRow row = (e.Row as DataRowView).Row;
                category.CATEGORYNAME = Convert.ToString(row["CATEGORYNAME"]);
                category.CATEGORYID = Convert.ToInt32(row["CATEGORYID"]);
                category.UserID = Utility.UserID;
                object CategoryID = new RepositoryBase().Execute<int>("USP_CU_CATEGORY", category.Params);
                row["CATEGORYID"] = CategoryID;
            }
            catch (Exception ex) {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var dlgResult = XtraMessageBox.Show("Are you sure want to delete?", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Convert.ToString(dlgResult) == "OK" && gvCategory.FocusedRowHandle >= 0)
                {
                    Dictionary<string,object> Parameters = 
                        new Dictionary<string, object>
                            {
                                { "CATEGORYID", gvCategory.GetFocusedRowCellValue("CATEGORYID")},
                                { "USERID",Utility.UserID}
                            };
                    new RepositoryBase().Execute<int>("USP_D_CATEGORY", Parameters);
                    gvCategory.DeleteRow(gvCategory.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcCategory.ShowRibbonPrintPreview();
        }
    }
}