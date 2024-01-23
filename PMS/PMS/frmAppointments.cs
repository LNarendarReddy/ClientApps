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
                if (txtRegNo.Text.Trim() != string.Empty && e.KeyChar == (char)Keys.Enter)
                {
                    string stAddress = string.Empty;
                    int ivalue = 0;
                    if (int.TryParse(txtRegNo.Text, out ivalue))
                    {
                        objEPatient.RegNo = ivalue;
                        objDPatient.GetPatientByRegNo(objEPatient);
                        if (objEPatient.dtPatient != null && objEPatient.dtPatient.Rows.Count > 0)
                        {
                            int iValue = 0;
                            if (int.TryParse(Convert.ToString(objEPatient.dtPatient.Rows[0]["PatientID"]), out iValue))
                                objEPatient.PatientID = iValue;
                            txtPName.Text += objEPatient.dtPatient.Rows[0]["PName"].ToString();
                            stAddress = Convert.ToString(objEPatient.dtPatient.Rows[0]["PDno"]) + Environment.NewLine +
                                Convert.ToString(objEPatient.dtPatient.Rows[0]["PVillage"]) + Environment.NewLine +
                                Convert.ToString(objEPatient.dtPatient.Rows[0]["PCity"]) + Environment.NewLine +
                                Convert.ToString(objEPatient.dtPatient.Rows[0]["PState"]) + Environment.NewLine +
                                Convert.ToString(objEPatient.dtPatient.Rows[0]["Pincode"]);
                            txtAddress.Text += stAddress;
                        }
                        else
                        {
                            XtraMessageBox.Show("Patient does not exists","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            txtPName.Text = " ";
                            txtAddress.Text = " ";
                            txtRegNo.Focus();
                            return;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Patient does not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPName.Text = " ";
                        txtAddress.Text = " ";
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
                dtAppointment.EditValue = Utility.dtSelectedDate == DateTime.MinValue ? DateTime.Today.Date : Utility.dtSelectedDate;
            }
            catch ( Exception ex){ Utility.ShowError(ex); }
            
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
                DialogResult dlg = XtraMessageBox.Show("Do you want to print receipt", "Question", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(Convert.ToString(dlg) == "Yes")
                {
                    rptAppointment rpt = new rptAppointment();
                    objDPatient.GetAppointment(objEPatient);
                    rpt.DataSource = objEPatient.dtAppointmentDetails;
                    rpt.Parameters["ADate"].Value = dtAppointment.EditValue;
                    rpt.Parameters["RegNo"].Value = txtRegNo.EditValue;
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