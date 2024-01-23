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

namespace PMS.ReportForms
{
    public partial class frmViewAppointments : DevExpress.XtraEditors.XtraForm
    {
        public frmViewAppointments()
        {
            InitializeComponent();
        }

        private void frmViewAppointments_Load(object sender, EventArgs e)
        {
            try
            {
                EPatient ObjEPatient = new EPatient();
                DPatient ObjDPatient = new DPatient();
                ObjEPatient.AppointmentDate = Utility.dtSelectedDate == null ? DateTime.Now : Utility.dtSelectedDate;
                ObjEPatient.BranchID = Utility.BranchID;
                ObjDPatient.GetAppointmentByDate(ObjEPatient);
                gcAppointments.DataSource = ObjEPatient.dtAppointment;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}