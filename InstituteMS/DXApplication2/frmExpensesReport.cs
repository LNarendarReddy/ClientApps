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
using System.IO;

namespace InstituteMS
{
    public partial class frmExpensesReport : DevExpress.XtraEditors.XtraForm
    {
        DReports ObjDReports = new DReports();
        EReports ObjEReports = new EReports();
        public frmExpensesReport()
        {
            InitializeComponent();
        }

        private void frmExpensesReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEReports.BranchID = Utility.BranchID;
                ObjDReports.GetExpenses(ObjEReports);
                gcExpeses.DataSource = ObjEReports.dtExpenses;
            }
            catch (Exception ex) { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvExpenses.RowCount > 0)
                gcExpeses.Print();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvExpenses.RowCount > 0)
                {
                    string Filepath = Application.UserAppDataPath + "\\" + "ExpensesReport.pdf";
                    gcExpeses.ExportToPdf(Filepath);
                    Utility.SendEmail("Expenses Report As On : " + DateTime.Now.ToString(), "Expenses Report", Filepath, this);
                    if (File.Exists(Filepath))
                        File.Delete(Filepath);
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (gvExpenses.RowCount > 0)
                gcExpeses.ShowRibbonPrintPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}