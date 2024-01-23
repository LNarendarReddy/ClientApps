using DevExpress.Utils.Gesture;
using DevExpress.XtraEditors;
using QuoteMaker.Models;
using QuoteMaker.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuoteMaker.UI.Masters
{
    public partial class frmGSTList : DevExpress.XtraEditors.XtraForm
    {
        GST gst = null;
        public frmGSTList()
        {
            InitializeComponent();
        }

        private void frmGSTList_Load(object sender, EventArgs e)
        {
            try
            {
                gcGST.DataSource = new RepositoryBase().GetDataTable("USP_R_GST");
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gst = new GST();
            frmGST obj = new frmGST(gst);
            obj.ShowInTaskbar = false;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.IconOptions.ShowIcon = false;
            obj.ShowDialog();
            if (gst.IsSave)
            {
                gcGST.DataSource = new RepositoryBase().GetDataTable("USP_R_GST");
                Utility.Setfocus(gvGST, "GSTID", gst.GSTID);
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
                if (gvGST.FocusedRowHandle >= 0)
                {
                    gst = new GST();
                    gst.GSTID = gvGST.GetFocusedRowCellValue("GSTID");
                    gst.GSTCODE = gvGST.GetFocusedRowCellValue("GSTCODE");
                    gst.CGST = gvGST.GetFocusedRowCellValue("CGST");
                    gst.SGST = gvGST.GetFocusedRowCellValue("SGST");
                    gst.IGST = gvGST.GetFocusedRowCellValue("IGST");
                    gst.CESS = gvGST.GetFocusedRowCellValue("CESS");
                    frmGST obj = new frmGST(gst);
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.IconOptions.ShowIcon = false;
                    obj.ShowDialog();
                    if (gst.IsSave)
                    {
                        gcGST.DataSource = new RepositoryBase().GetDataTable("USP_R_GST");
                        Utility.Setfocus(gvGST, "GSTID", gst.GSTID);
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
                var dlgResult = XtraMessageBox.Show("Are you sure want to delete?", "Confirmation!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (Convert.ToString(dlgResult) == "OK" && gvGST.FocusedRowHandle >= 0)
                {
                    Dictionary<string,object> parameters= new Dictionary<string, object>()
                    {
                        { "GSTID", gvGST.GetFocusedRowCellValue("GSTID")},
                        { "USERID", Utility.UserID}
                    };

                    new RepositoryBase().GetDataTable("USP_R_GST");
                    gvGST.DeleteRow(gvGST.FocusedRowHandle);
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
            gcGST.ShowRibbonPrintPreview();
        }
    }
}