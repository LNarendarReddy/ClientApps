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
using System.IO;
using DevExpress.XtraSplashScreen;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using System.Threading;
using DL;
using EL;
using DevExpress.XtraGrid.Views.Base;

namespace InstituteMS
{
    public partial class frmStudentReport : DevExpress.XtraEditors.XtraForm
    {
        DReports ObjDReports = new DReports();
        EReports ObjEReports = new EReports();
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvData.RowCount > 0)
                    gcData.Print();
            }
            catch (Exception ex) { }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvData.RowCount > 0)
                {
                    string Filepath = Application.UserAppDataPath + "\\" + "StudentReport.pdf";
                    gcData.ExportToPdf(Filepath);
                    Utility.SendEmail("Student Report As On : " + DateTime.Now.ToString(), "Student Collection Report", Filepath,this);
                    if (File.Exists(Filepath))
                        File.Delete(Filepath);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvData.RowCount > 0)
                    gcData.ShowRibbonPrintPreview();
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

                    DataView dv = GetFilteredData(gvData);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEReports.BranchID = Utility.BranchID;
                ObjDReports.GetStudentReport(ObjEReports);
                gcData.DataSource = ObjEReports.dtStudentReport;
            }
            catch (Exception ex) { }
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