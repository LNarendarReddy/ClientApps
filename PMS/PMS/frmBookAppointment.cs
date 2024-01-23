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
using PMS.Reports;
using DevExpress.XtraReports.UI;
using static PMS.Utility;

namespace PMS
{
    public partial class frmBookAppointment : DevExpress.XtraEditors.XtraForm
    {
        EPatient objEPatient = new EPatient();
        DPatient objDPatient = new DPatient();
        public frmBookAppointment(int nPatientID)
        {
            InitializeComponent();
            objEPatient.PatientID = nPatientID;
            LoadPatient();
            dtAppointment.Properties.MinValue = DateTime.Today;
        }
        private void LoadPatient()
        {
            string stAddress = string.Empty;
            DataTable dtPatient = new DataTable();
            try
            {
                if (objEPatient != null)
                {
                    objDPatient.GetPatient(objEPatient);
                    dtPatient = objEPatient.dtPatient;
                    lblPatientID.Text += dtPatient.Rows[0]["RegNo"].ToString();
                    lblPatientName.Text += dtPatient.Rows[0]["PName"].ToString();
                    stAddress = dtPatient.Rows[0]["PDno"].ToString() + Environment.NewLine + dtPatient.Rows[0]["PVillage"].ToString() + Environment.NewLine + dtPatient.Rows[0]["PCity"].ToString() +
                        Environment.NewLine + dtPatient.Rows[0]["PState"].ToString() + Environment.NewLine + dtPatient.Rows[0]["Pincode"].ToString();
                    lblAddress.Text += stAddress;
                }
            }
            catch (Exception ex) { }
        }
        private void frmBookAppointment_Load(object sender, EventArgs e)
        {
            LoadDoctor();
            dtAppointment.EditValue = Utility.dtSelectedDate == DateTime.MinValue ? DateTime.Today.Date : Utility.dtSelectedDate;
        }
        private void LoadDoctor()
        {
            EDoctor obj = new EDoctor();
            DDoctorMaster objD = new DDoctorMaster();
            try
            {
                obj.BranchID = Utility.BranchID;
                objD.GetDoctorMaster(obj);
                cmbDoctor.Properties.DataSource = obj.dtDoctor;
                cmbDoctor.Properties.DisplayMember = "DName";
                cmbDoctor.Properties.ValueMember = "DoctorID";
                cmbDoctor.EditValue = obj.dtDoctor.Rows[0][cmbDoctor.Properties.ValueMember]; ;
            }
            catch(Exception ex) { }
        }
        private void btnAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                objEPatient.DoctorID = Convert.ToInt32(cmbDoctor.EditValue);
                objEPatient.AppointmentDate = Convert.ToDateTime(dtAppointment.EditValue);
                objEPatient.UserID = Utility.UserID;
                objEPatient.BranchID = Utility.BranchID;
                objDPatient.SaveAppointment(objEPatient);
                DialogResult dlg = XtraMessageBox.Show("Do you want to print receipt", "Question",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Convert.ToString(dlg) == "Yes")
                {
                    rptAppointment rpt = new rptAppointment();
                    objDPatient.GetAppointment(objEPatient);
                    rpt.DataSource = objEPatient.dtAppointmentDetails;
                    rpt.Parameters["ADate"].Value = dtAppointment.EditValue;
                    rpt.Parameters["RegNo"].Value = objEPatient.dtAppointment.Rows[0]["RegNo"];
                    rpt.ShowPrintMarginsWarning = false;
                    Utility.Printreport(rpt, PrintersType.NewBigPrint);
                }
                this.Close();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}