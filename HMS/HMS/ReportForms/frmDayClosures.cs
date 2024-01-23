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
using HMS.Reports;
using DevExpress.XtraReports.UI;
using System.IO;

namespace HMS.ReportForms
{
    public partial class frmDayClosures : DevExpress.XtraEditors.XtraForm
    {
        public frmDayClosures()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcDayclosures.PrintDialog();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcDayclosures.ShowRibbonPrintPreview();
        }

        private void frmDayClosures_Load(object sender, EventArgs e)
        {
            try
            {
                DReports ObjDReports = new DReports();
                ERpeorts ObjEReports = new ERpeorts();
                ObjEReports.UserID = Utility.UserID;
                ObjDReports.GetDayClosureList(ObjEReports);
                gcDayclosures.DataSource = ObjEReports.dsDailyCollectionReport.Tables[0];
            }
            catch (Exception ex){}
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                DReports ObjDReports = new DReports();
                ERpeorts ObjEReports = new ERpeorts();
                if(gvDayclosures.FocusedRowHandle >=0)
                {

                    string st = Convert.ToString(gvDayclosures.GetFocusedRowCellValue("DayCloseID"));
                    int Ivalue = 0;
                    if (int.TryParse(st, out Ivalue))
                    {
                        ObjEReports.DayCloseID = Ivalue;
                        ObjDReports.GetDayClosure(ObjEReports);
                        rptDayClose rptBills = new rptDayClose();
                        rptBills.Parameters["OrgName"].Value = Utility.OrgName;
                        rptBills.Parameters["Address"].Value = Utility.OrgAddress;
                        rptBills.Parameters["DayCloseID"].Value = Ivalue;
                        rptBills.DataSource = ObjEReports.dsDailyCollectionReport.Tables[0];
                        rptBills.CreateDocument();

                        rptDayCloseItems rptItems = new rptDayCloseItems();
                        rptItems.Parameters["OrgName"].Value = Utility.OrgName;
                        rptItems.Parameters["Address"].Value = Utility.OrgAddress;
                        rptItems.Parameters["DayCloseID"].Value = Ivalue;
                        rptItems.DataSource = ObjEReports.dsDailyCollectionReport.Tables[1];
                        rptItems.CreateDocument();
                        rptBills.Pages.AddRange(rptItems.Pages);

                        rptClosedVouchers rptVouchers = new rptClosedVouchers();
                        rptVouchers.Parameters["OrgName"].Value = Utility.OrgName;
                        rptVouchers.Parameters["Address"].Value = Utility.OrgAddress;
                        rptVouchers.Parameters["DayCloseID"].Value = Ivalue;
                        rptVouchers.DataSource = ObjEReports.dsDailyCollectionReport.Tables[2];
                        rptVouchers.CreateDocument();
                        rptBills.Pages.AddRange(rptVouchers.Pages);

                        rptDenominations rptdenom = new rptDenominations();
                        rptdenom.Parameters["OrgName"].Value = Utility.OrgName;
                        rptdenom.Parameters["Address"].Value = Utility.OrgAddress;
                        rptdenom.Parameters["DayCloseID"].Value = Ivalue;
                        rptdenom.DataSource = ObjEReports.dsDailyCollectionReport.Tables[3];
                        rptdenom.CreateDocument();
                        rptBills.Pages.AddRange(rptdenom.Pages);

                        rptBills.PrintingSystem.ContinuousPageNumbering = true;

                        //var fileName = Path.Combine(Environment.GetFolderPath(
                        // Environment.SpecialFolder.ApplicationData), "DayClosureReport" + 
                        // DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf");
                        //rptBills.ExportToPdf(fileName);

                        //Utility.SendEmail("Day Closure Report As on: " + Convert.ToString(DateTime.Now),
                        //    "Please find the attachment of dayclosure report", fileName, this);

                        ReportPrintTool printTool = new ReportPrintTool(rptBills);
                        printTool.ShowRibbonPreview();
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}