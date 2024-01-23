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
using CMS.Reports;
using DevExpress.XtraReports.UI;

namespace CMS
{
    public partial class frmJumboPrint : DevExpress.XtraEditors.XtraForm
    {
        ERpeorts ObjEReports = null;
        DReports ObjDReports = null;
        public frmJumboPrint()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmJumboPrint_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                if (ObjEReports == null)
                    ObjEReports = new ERpeorts();
                if (ObjDReports == null)
                    ObjDReports = new DReports();
                ObjEReports.AppointmentDate = Utility.dtSelectedDate;
                ObjEReports.FromID = txtFrom.EditValue;
                ObjEReports.ToID = txtTo.EditValue;
                ObjDReports.GetJumboPrintData(ObjEReports);

                rptJumboPrint rpt = new rptJumboPrint();
                rpt.Parameters["ADate"].Value = Utility.dtSelectedDate;
                rpt.Parameters["EmployeeName"].Value = cmbEmployeeName.Text;
                int ivalue = 1;
                if (int.TryParse(txtTo.Text, out ivalue))
                    rpt.Parameters["PNumber"].Value = ivalue / 10;
                rpt.DataSource = ObjEReports.dtDailyCollectionReport;
                Utility.Printreport(rpt, PrintersType.JumboList);
            }
            catch (Exception EX)
            {
                Utility.ShowError(EX);
            }
        }
    }
}