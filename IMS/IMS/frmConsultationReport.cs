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

namespace IMS
{
    public partial class frmConsultationReport : DevExpress.XtraEditors.XtraForm
    {
        DPatient objDPatient = new DPatient();
        EPatient objEPatient = new EPatient();
        public frmConsultationReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                gcReport.ShowRibbonPrintPreview();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void frmConsultationReport_Load(object sender, EventArgs e)
        {
            try
            {
                objEPatient = objDPatient.GetConsultationReport(objEPatient);
                gcReport.DataSource = objEPatient.dtReport;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}