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

namespace CMS.ReportForms
{
    public partial class frmNextVisitInfo : DevExpress.XtraEditors.XtraForm
    {
        ERpeorts ObjERpeorts = new ERpeorts();
        DReports ObjDReports = new DReports();
        public frmNextVisitInfo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcPatientList.ShowRibbonPrintPreview();
        }

        private void frmNextVisitInfo_Load(object sender, EventArgs e)
        {
            try
            {
                ObjERpeorts.BranchID = Utility.BranchID;
                ObjDReports.GetNextVisitInfo(ObjERpeorts);
                gcPatientList.DataSource = ObjERpeorts.dtDailyCollectionReport;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}