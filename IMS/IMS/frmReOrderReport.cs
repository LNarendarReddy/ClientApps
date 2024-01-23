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
    public partial class frmReOrderReport : DevExpress.XtraEditors.XtraForm
    {
        DMedicine ObjDMedicine = new DMedicine();
        EMedicine ObjEMedicine = new EMedicine();
        public frmReOrderReport()
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

        private void frmReOrderReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEMedicine = ObjDMedicine.GetReOrderReport(ObjEMedicine);
                gcReport.DataSource = ObjEMedicine.dtReOrderReport;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}