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

namespace CMS
{
    public partial class frmPatientQueue : DevExpress.XtraEditors.XtraForm
    {
        EPatient ObjEPatient = null;
        DPatient ObjDPatient = null;

        public frmPatientQueue()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReresh_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void frmPatientQueue_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            try
            {
                ObjEPatient = new EPatient();
                ObjDPatient = new DPatient();
                ObjEPatient.AppointmentDate = Utility.dtSelectedDate;
                ObjEPatient.BranchID = Utility.BranchID;
                ObjDPatient.GetPatientQueue(ObjEPatient);
                gcNonTreatedOldPatients.DataSource = ObjEPatient.dtNonTreatedOldPatients;
                gcTreatedOldPatients.DataSource = ObjEPatient.dtTreatedOldPatients;
                gcNonTreatedNewPatients.DataSource = ObjEPatient.dtNonTreatedNewPatients;
                gcTreatedNewPatients.DataSource = ObjEPatient.dtTreatedNewPatients;
                lblOldPatients.Text = 
                    "Total Old Patients : " +
                    Convert.ToString(ObjEPatient.dtNonTreatedOldPatients.Rows.Count +
                    ObjEPatient.dtTreatedOldPatients.Rows.Count);

                lblNewPatients.Text =
                    "Total New Patients : " +
                    Convert.ToString(ObjEPatient.dtNonTreatedNewPatients.Rows.Count +
                    ObjEPatient.dtTreatedNewPatients.Rows.Count);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}