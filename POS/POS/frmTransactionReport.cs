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

namespace POS
{
    public partial class frmTransactionReport : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEstudent = new EStudent();
        DStudent ObjDstudent = new DStudent();
        public frmTransactionReport()
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
                gvReport.ShowRibbonPrintPreview();
            }
            catch (Exception ex){}
        }

        private void frmTransactionReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDstudent.GetTReport(ObjEstudent);
                gcReport.DataSource = ObjEstudent.dtReport;
            }
            catch (Exception ex){}
        }
    }
}