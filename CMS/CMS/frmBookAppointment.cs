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
            try
            {
                LoadDoctor();
                dtAppointment.EditValue = Utility.dtSelectedDate == DateTime.MinValue ? DateTime.Today.Date : Utility.dtSelectedDate;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void LoadDoctor()
        {
            EDoctor obj = new EDoctor();
            DDoctor objD = new DDoctor();
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
                rptToken rpt = new rptToken();
                rpt.Parameters["ADate"].Value = objEPatient.dtAppointment.Rows[0]["AppointmentDate"];
                rpt.Parameters["PName"].Value = objEPatient.dtAppointment.Rows[0]["PName"];
                rpt.Parameters["RegNo"].Value = objEPatient.dtAppointment.Rows[0]["RegNo"];
                rpt.Parameters["TokenNo"].Value = objEPatient.dtAppointment.Rows[0]["TockenID"];
                rpt.ShowPrintMarginsWarning = false;
                rpt.Print();
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