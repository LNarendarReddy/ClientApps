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
using System.Threading;

namespace CMS
{
    public partial class frmAppointments : DevExpress.XtraEditors.XtraForm
    {
        EPatient objEPatient = new EPatient();
        DPatient objDPatient = new DPatient();
        public frmAppointments()
        {
            InitializeComponent();
            dtAppointment.Properties.MinValue = DateTime.Today;
        }

        private void textEdit1_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                objEPatient = new EPatient();
                if (txtRegNo.Text.Trim() != string.Empty && e.KeyChar == (char)Keys.Enter)
                {
                    string stAddress = string.Empty;
                    objEPatient.RegNo = txtRegNo.EditValue;
                    objDPatient.GetPatientByRegNo(objEPatient);
                    if (objEPatient.dtPatient != null && objEPatient.dtPatient.Rows.Count > 0)
                    {
                        int iValue = 0;
                        if (int.TryParse(Convert.ToString(objEPatient.dtPatient.Rows[0]["PatientID"]), out iValue))
                            objEPatient.PatientID = iValue;
                        txtPName.Text += objEPatient.dtPatient.Rows[0]["PName"].ToString();
                        txtAddress.Text = Convert.ToString(objEPatient.dtPatient.Rows[0]["PVillage"]) + Environment.NewLine +
                            Convert.ToString(objEPatient.dtPatient.Rows[0]["PCity"]) + Environment.NewLine +
                            Convert.ToString(objEPatient.dtPatient.Rows[0]["PState"]) + Environment.NewLine +
                            Convert.ToString(objEPatient.dtPatient.Rows[0]["Pincode"]);
                        var dlgresult = XtraMessageBox.Show("Continue to print..", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Convert.ToString(dlgresult) == "Yes")
                            btnAppointment_Click(null, null);
                    }
                    else
                    {
                        XtraMessageBox.Show("Patient does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPName.Text = "";
                        txtAddress.Text = "";
                        txtRegNo.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void frmAppointments_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDoctor();
                dtAppointment.EditValue = Utility.dtSelectedDate;
            }
            catch ( Exception ex){ Utility.ShowError(ex); }
            
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
                cmbDoctor.EditValue = obj.dtDoctor.Rows[0][cmbDoctor.Properties.ValueMember];
            }
            catch (Exception ex) { throw ex; }
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
                objEPatient.TreatmentID = 0;
                objDPatient.GetLastTreatmengtID(objEPatient);
                objDPatient.GetLastTreatmentDetails(objEPatient);
                rptTokenOldBooking rpt = new rptTokenOldBooking();
                rpt.Parameters["ADate"].Value = objEPatient.dtAppointment.Rows[0]["AppointmentDate"];
                rpt.Parameters["PName"].Value = objEPatient.dtAppointment.Rows[0]["PName"];
                rpt.Parameters["RegNo"].Value = objEPatient.dtAppointment.Rows[0]["RegNo"];
                rpt.Parameters["TokenNo"].Value = objEPatient.dtAppointment.Rows[0]["TockenID"];
                rpt.Parameters["Mobile"].Value = objEPatient.dtAppointment.Rows[0]["CNumber"];
                string stAddress = Convert.ToString(objEPatient.dtAppointment.Rows[0]["PVillage"]);
                string stVillage = Convert.ToString(objEPatient.dtAppointment.Rows[0]["PCity"]);
                string stCity = Convert.ToString(objEPatient.dtAppointment.Rows[0]["PState"]);
                string stState = Convert.ToString(objEPatient.dtAppointment.Rows[0]["PinCode"]);
                if (!string.IsNullOrEmpty(stVillage))
                    stAddress += ", " + stVillage;
                if (!string.IsNullOrEmpty(stCity))
                    stAddress += ", " + stCity;
                if (!string.IsNullOrEmpty(stState))
                    stAddress += ", " + stState;
                rpt.Parameters["Address"].Value = stAddress;
                if (objEPatient.dtTreatment.Rows.Count > 0)
                {
                    rpt.Parameters["Total"].Value = objEPatient.dtTreatment.Rows[0]["TotalAmount"];
                    rpt.Parameters["Paid"].Value = objEPatient.dtTreatment.Rows[0]["PaidAmount"];
                    rpt.Parameters["Due"].Value = objEPatient.dtTreatment.Rows[0]["PreviousBalance"];
                    rpt.Parameters["LastVisit"].Value = objEPatient.dtTreatment.Rows[0]["AppointmentDate"];
                    rpt.Parameters["FirstVisit"].Value = objEPatient.dtTreatment.Rows[0]["FirstVisitDate"];
                }
                rpt.DataSource = objEPatient.dtMedicine;
                rpt.ShowPrintMarginsWarning = false;
                Utility.Printreport(rpt, PrintersType.NewSmallPrint);
                ClearFields();
            }
            catch (Exception ex) { Utility.ShowError(ex);
                ClearFields();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void ClearFields()
        {
            txtRegNo.EditValue = null;
            txtPName.EditValue = null;
            txtAddress.EditValue = null;
            txtRegNo.Focus();
        }

    }
}