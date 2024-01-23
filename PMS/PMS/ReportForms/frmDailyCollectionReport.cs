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
using EL;
using DL;

namespace PMS.ReportForms
{
    public partial class frmDailyCollectionReport : DevExpress.XtraEditors.XtraForm
    {
        ERpeorts ObjEReports = new ERpeorts();
        DReports ObjDReports = new DReports();
        public frmDailyCollectionReport()
        {
            InitializeComponent();
        }

        private void frmDailyCollectionReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEReports.BranchID = Utility.BranchID;
                ObjDReports.GetDailyCollectionReport(ObjEReports);
                gcDailyCollectionReport.DataSource = ObjEReports.dtDailyCollectionReport;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcDailyCollectionReport.ShowRibbonPrintPreview();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcDailyCollectionReport.PrintDialog();
        }
    }
}