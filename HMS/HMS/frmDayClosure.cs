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

namespace HMS
{
    public partial class frmDayClosure : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        DReports ObjDReports = new DReports();
        ERpeorts ObjEReports = new ERpeorts();
        public frmDayClosure()
        {
            InitializeComponent();
        }

        private void gcDayClosure_Click(object sender, EventArgs e)
        {

        }

        private void frmDayClosure_Load(object sender, EventArgs e)
        {
            try
            {
                
                dt.Columns.Add("DenominationsinText", typeof(string));
                dt.Columns.Add("DenominationsinNumbers", typeof(decimal));
                dt.Columns.Add("Quantity", typeof(int));
                dt.Columns.Add("Total", typeof(decimal));

                DataRow drnew = dt.NewRow();
                drnew["DenominationsinText"] = "TWO THOUSANDS";
                drnew["DenominationsinNumbers"] = 2000;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "FIVE HUNDREDS";
                drnew["DenominationsinNumbers"] = 500;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "HUNDREDS";
                drnew["DenominationsinNumbers"] = 100;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "FIFTIES";
                drnew["DenominationsinNumbers"] = 50;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "TWENTIES";
                drnew["DenominationsinNumbers"] = 20;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "TENS";
                drnew["DenominationsinNumbers"] = 10;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "FIVES";
                drnew["DenominationsinNumbers"] = 5;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "TWOS";
                drnew["DenominationsinNumbers"] = 2;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "ONES";
                drnew["DenominationsinNumbers"] = 1;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "BULKCOINS";
                drnew["DenominationsinNumbers"] = 1;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "ONLINEPAYMENTS";
                drnew["DenominationsinNumbers"] = 1;
                dt.Rows.Add(drnew);

                drnew = dt.NewRow();
                drnew["DenominationsinText"] = "OTHERS";
                drnew["DenominationsinNumbers"] = 1;
                dt.Rows.Add(drnew);

                gcDayClosure.DataSource = dt;

            }
            catch (Exception ex)
            {
                            }
        }

        private void gvDayClosure_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    gvDayClosure.MoveNext();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvDayClosure_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal dValue = 0;
                int Count = 0;
                if(gvDayClosure.FocusedRowHandle >= 0)
                {
                    if(decimal.TryParse(Convert.ToString(gvDayClosure.GetFocusedRowCellValue("DenominationsinNumbers")),out dValue))
                    {
                        if (int.TryParse(Convert.ToString(gvDayClosure.GetFocusedRowCellValue("Quantity")), out Count))
                        {
                            dt.Rows[gvDayClosure.FocusedRowHandle]["Total"] = dValue * Count;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                ObjEReports.UserID = Utility.UserID;
                ObjEReports.dtDenominations = dt;
                ObjDReports.SaveDayClosure(ObjEReports);

                if (ObjEReports.dsDailyCollectionReport != null &&
                    ObjEReports.dsDailyCollectionReport.Tables.Count > 4 &&
                    ObjEReports.dsDailyCollectionReport.Tables[4].Rows.Count > 0)
                {
                    

                    rptDayClose rptBills = new rptDayClose();
                    rptBills.Parameters["OrgName"].Value = Utility.OrgName;
                    rptBills.Parameters["Address"].Value = Utility.OrgAddress;
                    rptBills.Parameters["DayCloseID"].Value = ObjEReports.dsDailyCollectionReport.Tables[4].Rows[0][0];
                    rptBills.DataSource = ObjEReports.dsDailyCollectionReport.Tables[0];
                    rptBills.CreateDocument();

                    rptDayCloseItems rptItems = new rptDayCloseItems();
                    rptItems.Parameters["OrgName"].Value = Utility.OrgName;
                    rptItems.Parameters["Address"].Value = Utility.OrgAddress;
                    rptItems.Parameters["DayCloseID"].Value = ObjEReports.dsDailyCollectionReport.Tables[4].Rows[0][0];
                    rptItems.DataSource = ObjEReports.dsDailyCollectionReport.Tables[1];
                    rptItems.CreateDocument();
                    rptBills.Pages.AddRange(rptItems.Pages);

                    rptClosedVouchers rptVouchers = new rptClosedVouchers();
                    rptVouchers.Parameters["OrgName"].Value = Utility.OrgName;
                    rptVouchers.Parameters["Address"].Value = Utility.OrgAddress;
                    rptVouchers.Parameters["DayCloseID"].Value = ObjEReports.dsDailyCollectionReport.Tables[4].Rows[0][0];
                    rptVouchers.DataSource = ObjEReports.dsDailyCollectionReport.Tables[2];
                    rptVouchers.CreateDocument();
                    rptBills.Pages.AddRange(rptVouchers.Pages);

                    rptDenominations rptdenom = new rptDenominations();
                    rptdenom.Parameters["OrgName"].Value = Utility.OrgName;
                    rptdenom.Parameters["Address"].Value = Utility.OrgAddress;
                    rptdenom.Parameters["DayCloseID"].Value = ObjEReports.dsDailyCollectionReport.Tables[4].Rows[0][0];
                    rptdenom.DataSource = ObjEReports.dsDailyCollectionReport.Tables[3];
                    rptdenom.CreateDocument();
                    rptBills.Pages.AddRange(rptdenom.Pages);

                    rptBills.PrintingSystem.ContinuousPageNumbering = true;
                    var fileName = Path.Combine(Environment.GetFolderPath(
                         Environment.SpecialFolder.ApplicationData), "DayClosureReport" +
                         DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf");
                    rptBills.ExportToPdf(fileName);

                    Utility.SendEmail("Day Closure Report As on: " + Convert.ToString(DateTime.Now),
                        "Please find the attachment of dayclosure report", fileName, this);

                    //ReportPrintTool printTool = new ReportPrintTool(rptBills);
                    //printTool.ShowRibbonPreview();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }

        }
    }
} 