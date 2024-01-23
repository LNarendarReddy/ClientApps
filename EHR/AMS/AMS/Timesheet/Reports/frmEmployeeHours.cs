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
    public partial class frmEmployeeHours : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmEmployeeHours()
        {
            InitializeComponent();
        }

        private void frmEmployeeHours_Load(object sender, EventArgs e)
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
                objDTimeSheet.GetEmployeeHours(objETimeSheet);
                gcEmployeeTimings.DataSource = objETimeSheet.dtEmployeeHours;
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