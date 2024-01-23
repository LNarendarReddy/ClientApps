using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Google.Apis.Util;
using QuoteMaker.Models;
using QuoteMaker.Repository;
using QuoteMaker.UI.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuoteMaker.UI.Quote
{
    public partial class frmQuotationList : XtraForm
    {
        public frmQuotationList()
        {
            InitializeComponent();

            dtpFromDate.EditValue = DateTime.Now.AddDays(-7);
            dtpToDate.EditValue = DateTime.Now;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "FromDate", dtpFromDate.EditValue }
                , { "ToDate", dtpToDate.EditValue }
            };
            gcQuotationList.DataSource = new RepositoryBase().GetDataTable("USP_R_QUOTATIONLIST", parameters);
        }

        private void btnViewReport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (Convert.ToString(gvQuotationList.GetFocusedRowCellValue("STATUS")) == "Draft")
            {
                XtraMessageBox.Show("Draft bills cannot be viewed or printed. The operation is cancelled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DataSet ds = new RepositoryBase().GetDataset("USP_R_QUOTATION",
                new Dictionary<string, object>
                {
                    { "QUOTATIONID", gvQuotationList.GetFocusedRowCellValue("QUOTATIONID").ToString() }
                });
            if (ds == null && ds.Tables.Count < 2)
            {
                return;
            }
            rptQuote rpt = new rptQuote(ds.Tables[0], ds.Tables[1]);
            rpt.ShowPrintMarginsWarning = false;
            rpt.ShowRibbonPreview();
        }

    }
}
