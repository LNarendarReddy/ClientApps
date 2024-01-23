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
    public partial class frmDueReport : DevExpress.XtraEditors.XtraForm
    {
        DReports ObjDReports = new DReports();
        EReports ObjEReports = new EReports();
        public frmDueReport()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvData.RowCount > 0)
                {
                    string Filepath = Application.UserAppDataPath + "\\" + "DueReport.pdf";
                    gcData.ExportToPdf(Filepath);
                    Utility.SendEmail("Due Report As On : " + DateTime.Now.ToString(), "Due Collection Report", Filepath,this);
                    if (File.Exists(Filepath))
                        File.Delete(Filepath);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvData.RowCount > 0)
                gcData.Print();
            }
            catch (Exception ex){}
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvData.RowCount > 0)
                gcData.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(this, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("Sending Messages...");
                if (!string.IsNullOrEmpty(Utility.strURL))
                {
                    //DataTable dt = (DataTable)gcData.DataSource;
                    DataView dv = GetFilteredData(gvData);
                    DataTable dt = dv.ToTable();

                    foreach (DataRow dr in dt.Rows)
                    {
                        string FullName = Convert.ToString(dr["FullName"]);
                        string Number = Convert.ToString(dr["Mobile"]);
                        string Due = Convert.ToString(dr["Due"]);
                        string Ano = Convert.ToString(dr["AdmissionNo"]);
                        DateTime dtime = DateTime.Now;
                        if (DateTime.TryParse(Convert.ToString(dr["DueDate"]), out dtime))
                        { }
                        string DueDate = dtime.ToString("dd/MM/yyyy");
                        string Message = "Dear Mr." + FullName + "(" + Ano + ")" + " your due amount is : " + Due + ". Please Pay on or before : " + DueDate;
                        string stQuery = string.Empty;
                        stQuery = string.Format(Utility.strURL, Utility.strAppKey, Utility.strSenderID, Number, Message);
                        webBrowser1.Navigate(stQuery);
                        Thread.Sleep(3000);
                    }
                    SplashScreenManager.CloseForm(false);
                    XtraMessageBox.Show("Messages Sent Successfully");
                }
            }
            catch (Exception ex) { SplashScreenManager.CloseForm(false); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDueReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEReports.BranchID = Utility.BranchID;
                ObjDReports.GetDueReport(ObjEReports);
                gcData.DataSource = ObjEReports.dtDueReport;
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
            catch (Exception ex){}
            return filteredDataView;
        }
    }
}