using QuoteMaker.Models;
using QuoteMaker.Repository;
using System;

namespace QuoteMaker.UI.Masters
{
    public partial class frmGST : DevExpress.XtraEditors.XtraForm
    {
        GST gst = null;
        public frmGST(GST _gst)
        {
            InitializeComponent();
            gst = _gst;
        }

        private void frmGST_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gst.GSTID) > 0)
            {
                this.Text = "Edit GST";
                txtGSTCode.EditValue = gst.GSTCODE;
                txtCGST.EditValue = gst.CGST;
                txtSGST.EditValue = gst.SGST;
                txtIGST.EditValue = gst.IGST;
                txtCESS.EditValue = gst.CESS;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                gst. GSTCODE = txtGSTCode.EditValue;
                gst.CGST = txtCGST.EditValue;
                gst.SGST= txtSGST.EditValue;
                gst.IGST= txtIGST.EditValue;
                gst.CESS = txtCESS.EditValue;
                gst.UserID = Utility.UserID;
                gst.GSTID = new RepositoryBase().Execute<int>("USP_CU_GST", gst.Params);
                gst.IsSave = true;
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
            gst.IsSave = false;
            this.Close();
        }
    }
}