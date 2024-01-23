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
using DL;
using EL;

namespace InstituteMS
{
    public partial class frmDailyCollection : DevExpress.XtraEditors.XtraForm
    {
        DReports ObjDReports = new DReports();
        EReports ObjEReports = new EReports();
        public frmDailyCollection()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(gvData.RowCount > 0)
            gcData.Print();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (gvData.RowCount > 0)
            gcData.ShowPrintPreview();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvData.RowCount > 0)
                {
                    string Filepath = Application.UserAppDataPath + "\\" + "DailyCollectionReport.pdf";
                    gcData.ExportToPdf(Filepath);
                    Utility.SendEmail("Daily Collection Report As On : " + DateTime.Now.ToString(), "Daily Collection Report", Filepath,this);
                    if (File.Exists(Filepath))
                        File.Delete(Filepath);
                }
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDailyCollection_Load(object sender, EventArgs e)
        {
            try
            {
                deCollectionDate.DateTime = DateTime.Now;
                ObjEReports.BranchID = Utility.BranchID;
                ObjDReports.GetDailyCollection(ObjEReports);
                gcData.DataSource = ObjEReports.dtDailCollection;
                if(Utility.OrgShortName == "RCC" || Utility.OrgShortName == "POLICE")
                {
                    lcReportDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    lcSendMessageButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                }
            }
            catch (Exception ex){}
        }

        private void btnSendDailyCollection_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Utility.strURL))
                {
                    ObjEReports.BranchID = Utility.BranchID;
                    ObjEReports.ColelctionDAte = deCollectionDate.DateTime;
                    ObjDReports.GetDailyCollectionForMessage(ObjEReports);
                    string stCollectionDate = ObjEReports.ColelctionDAte.ToString("dd/MMM/yyyy");
                    if (ObjEReports.dtDCR != null && ObjEReports.dtDCR.Rows.Count > 0)
                    {
                        string stDCR = Convert.ToString(ObjEReports.dtDCR.Rows[0]["DCR"]);
                        string stEX = Convert.ToString(ObjEReports.dtDCR.Rows[0]["EX"]);
                        string stCB = Convert.ToString(ObjEReports.dtDCR.Rows[0]["CB"]);
                        string message = string.Empty;
                        message = "Daily Collection Report : Date : " + stCollectionDate + " Daily Collection : " +  stDCR + " Expenses : " +  stEX + " Closing Balance : " + stCB;
                        string stQuery = string.Empty;
                        stQuery = string.Format(Utility.strURL, Utility.strAppKey, Utility.strSenderID, Utility.ToMobile, message);
                        webBrowser1.Navigate(stQuery);
                        XtraMessageBox.Show("Message Sent Successfully");
                    }
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Message Sending Failed"); }
        }
    }
}