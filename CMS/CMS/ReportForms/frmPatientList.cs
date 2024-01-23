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
    public partial class frmPatientList : DevExpress.XtraEditors.XtraForm
    {
        EPatient Objepatient = new EPatient();
        DPatient ObjdPatient = new DPatient();
        public frmPatientList()
        {
            InitializeComponent();
        }

        private void rptPatientList_Load(object sender, EventArgs e)
        {
            try
            {
                Objepatient.BranchID = Utility.BranchID;
                ObjdPatient.GetPatientDetails(Objepatient);
                gcPatientList.DataSource = Objepatient.dtPatientDetails;
            }
            catch (Exception ex) { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcPatientList.ShowRibbonPrintPreview();
        }
    }
}