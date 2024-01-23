using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuoteMaker.Repository;

namespace QuoteMaker.UI.Items
{
    public partial class frmMRPList : XtraForm
    {
        public object drSelected = null;
        public bool _IsSave = false;
        public frmMRPList(DataTable _dtMRP,bool IsItemListCall = false, bool showCostPrice = false)
        {
            InitializeComponent();
            gcDelete.Visible = IsItemListCall && Utility.Role != "Division Manager" && Utility.Role != "Division User"; ;
            gcMRPList.DataSource = _dtMRP;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                _IsSave = true;
                drSelected = gvMRPList.GetFocusedRow();
                this.Close();
            }
            catch (Exception){}
        }

        private void frmMRPList_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMRPList.FocusedRowHandle < 0 || gvMRPList.RowCount == 1)
                return;
            try
            {
                if (XtraMessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"ITEMPRICEID",  gvMRPList.GetFocusedRowCellValue("ITEMPRICEID")},
                    {"USERID", Utility.UserID}
                };
                new RepositoryBase().Execute<int>("USP_D_ITEMPRICE", parameters);
                gvMRPList.DeleteRow(gvMRPList.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void gvMRPList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gvMRPList.FocusedRowHandle < 0)
                return;
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    {"ITEMPRICEID", gvMRPList.GetFocusedRowCellValue("ITEMPRICEID")},
                    {"USERID", Utility.UserID},
                    {"SALEPRICE", gvMRPList.GetFocusedRowCellValue("SALEPRICE")}
                };
                new RepositoryBase().Execute<int>("USP_U_ITEMPRICE", parameters);
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }
    }
}