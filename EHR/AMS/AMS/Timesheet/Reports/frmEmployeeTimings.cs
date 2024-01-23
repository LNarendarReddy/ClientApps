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
using log4net;
using DL;
using EL;

namespace EHR.Timesheet.Reports
{
    public partial class frmEmployeeTimings : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmEmployeeTimings()
        {
            InitializeComponent();
        }

        private void frmEmployeeTimings_Load(object sender, EventArgs e)
        {
            dtpFromDate.EditValue = DateTime.Now.AddDays(-30);
            dtpToDate.EditValue = DateTime.Now;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.FromDate = dtpFromDate.EditValue;
                objETimeSheet.ToDate = dtpToDate.EditValue;
                objDTimeSheet.GetEmployeeTimings(objETimeSheet);
                gcEmployeeTimings.DataSource = objETimeSheet.dtEmployeeTimings;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcEmployeeTimings.ShowRibbonPrintPreview();
        }
    }
}