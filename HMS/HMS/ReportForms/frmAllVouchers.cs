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
    public partial class frmAllVouchers : DevExpress.XtraEditors.XtraForm
    {
        DReports ObjDReports = new DReports();
        ERpeorts ObjEReports = new ERpeorts();
        public frmAllVouchers()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcAllVouchers.PrintDialog();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcAllVouchers.ShowRibbonPrintPreview();
        }

        private void frmAllVouchers_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDReports.GetAllVouchers(ObjEReports);
                gcAllVouchers.DataSource = ObjEReports.dsDailyCollectionReport.Tables[0];
            }
            catch (Exception ex)
            {
            }
            
        }
    }
}