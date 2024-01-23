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

namespace HMS.ReportForms
{
    public partial class frmDailySales : DevExpress.XtraEditors.XtraForm
    {
        DReports ObjDReports = new DReports();
        ERpeorts ObjEReports = new ERpeorts();
        public frmDailySales()
        {
            InitializeComponent();
        }

        private void frmDailySales_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDReports.GetDailyCollectionReport(ObjEReports);
                DataColumn keyColumn = ObjEReports.dsDailyCollectionReport.Tables[0].Columns["BillID"];
                DataColumn foreignKeyColumn = ObjEReports.dsDailyCollectionReport.Tables[1].Columns["BillID"];
                ObjEReports.dsDailyCollectionReport.Relations.Add("BillItems", keyColumn, foreignKeyColumn);
                gcDailysales.DataSource = ObjEReports.dsDailyCollectionReport.Tables[0];
                gcDailysales.LevelTree.Nodes.Add("BillItems", gvItems);
                gvItems.ViewCaption = "Bill Items";

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcDailysales.PrintDialog();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcDailysales.ShowRibbonPrintPreview();
        }
    }
}