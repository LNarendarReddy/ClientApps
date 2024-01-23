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
using DL;
using EL;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace InstituteMS
{
    public partial class frmEnquiryReport : DevExpress.XtraEditors.XtraForm
    {
        DReports ObjDReports = new DReports();
        EReports ObjEReports = new EReports();
        public string studentname = string.Empty;
        public string Mobile = string.Empty;
        public string flag = string.Empty;
        public int EnquiryID = 0;
        public frmEnquiryReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gvEnquiry.RowCount > 0)
                gvEnquiry.ShowRibbonPrintPreview();
        }

        private void frmEnquiryReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEReports.BranchID = Utility.BranchID;
                ObjDReports.GetEnquiryReport(ObjEReports);
                gcEnquiry.DataSource = ObjEReports.dtEnquiry;
                if (string.IsNullOrEmpty(flag))
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                gvEnquiry.Columns["StudentEnquiryID"].Visible = false;
            }
            catch (Exception ex) { }
        }

        private void btnMovetoadmission_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Convert.ToString(gvEnquiry.GetFocusedRowCellValue("StudentEnquiryID")),
                    out EnquiryID))
                {
                    studentname = Convert.ToString(gvEnquiry.GetFocusedRowCellValue("StudentName"));
                    Mobile = Convert.ToString(gvEnquiry.GetFocusedRowCellValue("Mobile"));
                }
                this.Close();
            }
            catch (Exception ex) { }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("          Sending Messages...");
                if (!string.IsNullOrEmpty(Utility.strURL))
                {
                    if (string.IsNullOrEmpty(txtMessage.Text))
                        throw new Exception("Please Enter Message");

                    DataView dv = GetFilteredData(gvEnquiry);
                    DataTable dt = dv.ToTable();
                    foreach (DataRow dr in dt.Rows)
                    {
                        string Number = Convert.ToString(dr["Mobile"]);
                        string stQuery = string.Empty;
                        stQuery = string.Format(Utility.strURL, Utility.strAppKey, Utility.strSenderID, Number, txtMessage.Text);
                        webBrowser1.Navigate(stQuery);
                        Thread.Sleep(3000);
                    }
                }
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show("Messages Sent Successfully");
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Utility.ShowError(ex);
            }
        }
        private DataView GetFilteredData(ColumnView view)
        {
            DataView filteredDataView = new DataView();
            try
            {
                if (view == null) return null;
                if (view.ActiveFilter == null || !view.ActiveFilterEnabled
                    || view.ActiveFilter.Expression == "")
                    return view.DataSource as DataView;

                DataTable table = ((DataView)view.DataSource).Table;
                filteredDataView = new DataView(table);
                filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(view.ActiveFilterCriteria);

            }
            catch (Exception ex) { }
            return filteredDataView;
        }
    }
}