using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EL;
using DL;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using CMS.Reports;
using DevExpress.XtraReports.UI;

namespace CMS
{
    public partial class frmNewPatient : XtraForm
    {
        EPatient objEPatient = new EPatient();
        DPatient objDPatient = new DPatient();
        int PatientID;
        public bool IsEdit = false;
        public frmNewPatient(int nPatientID)
        {
            InitializeComponent();
            PatientID = nPatientID;
        }
        private void LoadPatient()
        {
            DataTable dtPatient = new DataTable();
            try
            {
                if (objEPatient != null)
                {
                    objEPatient.PatientID = PatientID;
                    objDPatient.GetPatient(objEPatient);
                    dtPatient = objEPatient.dtPatient;
                    txtRegNo.EditValue = dtPatient.Rows[0]["RegNo"];
                    txtName.EditValue = dtPatient.Rows[0]["PName"];
                    txtTelephone.EditValue = dtPatient.Rows[0]["CNumber"];
                    txtAadhar.EditValue = dtPatient.Rows[0]["AadharNumber"];
                    txtEmail.EditValue = dtPatient.Rows[0]["Email"];
                    txtVillage.EditValue = dtPatient.Rows[0]["PVillage"];
                    txtCity.EditValue = dtPatient.Rows[0]["PCity"];
                    txtState.EditValue = dtPatient.Rows[0]["PState"];
                    txtZipCode.EditValue = dtPatient.Rows[0]["PinCode"];
                    txtCourierAddress.EditValue = dtPatient.Rows[0]["CourierAddress"];
                    chkIsAddresssame.Checked = Convert.ToBoolean(dtPatient.Rows[0]["IsCAddressSame"]);
                    rgSex.SelectedIndex = Convert.ToInt32(dtPatient.Rows[0]["PSex"]);
                    txtAge.EditValue = dtPatient.Rows[0]["PAgeYears"];
                    chkStatus.Checked = Convert.ToBoolean(dtPatient.Rows[0]["PStatus"]);
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                objEPatient.BranchID = Utility.BranchID;
                objEPatient.OrgID = Utility.OrgID;
                if (txtRegNo.Text == "0" || string.IsNullOrEmpty(txtRegNo.Text))
                    objEPatient.RegNo = -1;
                else
                    objEPatient.RegNo = txtRegNo.Text;
                objEPatient.PName = txtName.Text;
                objEPatient.PCNumber = txtTelephone.Text.Trim();
                objEPatient.AdharNumber = txtAadhar.Text.Trim();
                objEPatient.Email = txtEmail.Text.Trim();
                objEPatient.Village = txtVillage.Text.Trim();
                objEPatient.City = txtCity.Text.Trim();
                objEPatient.State = txtState.Text.Trim();
                objEPatient.Pincode = txtZipCode.Text.Trim();
                objEPatient.CourierAddress = txtCourierAddress.Text.Trim();
                objEPatient.IsCourierAddressSame = chkIsAddresssame.CheckState;
                objEPatient.PStatus = chkStatus.CheckState;
                objEPatient.PSex = rgSex.SelectedIndex;
                objEPatient.PAgeYears = txtAge.Text.Trim();
                objEPatient.PermanentBillingRequired = false;
                objEPatient.UserID = Utility.UserID;
                objEPatient.Status = chkStatus.CheckState;
                objDPatient.SavePatient(objEPatient);
                if (!IsEdit)
                {
                    objEPatient.DoctorID = Utility.DoctorID;
                    objEPatient.AppointmentDate = Utility.dtSelectedDate;
                    objEPatient.UserID = Utility.UserID;
                    objEPatient.BranchID = Utility.BranchID;
                    objEPatient.IsNewPatient = true;
                    objDPatient.SaveAppointment(objEPatient);
                    rptToken rpt = new rptToken();
                    rpt.Parameters["ADate"].Value = objEPatient.dtAppointment.Rows[0]["AppointmentDate"];
                    rpt.Parameters["PName"].Value = objEPatient.dtAppointment.Rows[0]["PName"];
                    rpt.Parameters["RegNo"].Value = objEPatient.dtAppointment.Rows[0]["RegNo"];
                    rpt.Parameters["TokenNo"].Value = objEPatient.dtAppointment.Rows[0]["TockenID"];
                    rpt.Parameters["Mobile"].Value = txtTelephone.EditValue;
                    string stAddress = txtVillage.Text.Trim();
                    if (!string.IsNullOrEmpty(txtCity.Text.Trim()))
                        stAddress += ", " + txtCity.Text.Trim();
                    if (!string.IsNullOrEmpty(txtState.Text.Trim()))
                        stAddress += ", " + txtState.Text.Trim();
                    if (!string.IsNullOrEmpty(txtZipCode.Text.Trim()))
                        stAddress += ", " + txtZipCode.Text.Trim();
                    rpt.Parameters["Address"].Value = stAddress;
                    rpt.ShowPrintMarginsWarning = false;

                    rptNewBigPrint rptBig = new rptNewBigPrint();
                    rptBig.Parameters["ADate"].Value = objEPatient.dtAppointment.Rows[0]["AppointmentDate"];
                    rptBig.Parameters["PName"].Value = objEPatient.dtAppointment.Rows[0]["PName"];
                    rptBig.Parameters["RegNo"].Value = objEPatient.dtAppointment.Rows[0]["RegNo"];
                    rptBig.Parameters["Age"].Value = objEPatient.dtAppointment.Rows[0]["PAgeYears"];
                    rptBig.Parameters["Mobile"].Value = objEPatient.dtAppointment.Rows[0]["CNumber"];
                    rptBig.Parameters["Address"].Value = stAddress;
                    rptBig.ShowPrintMarginsWarning = false;

                    Utility.Printreport(rpt, PrintersType.NewSmallPrint);
                    Utility.Printreport(rptBig, PrintersType.NewBigPrint);
                }
                else
                    this.Close();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void ClearFields()
        {
            try
            {
                txtRegNo.Text = string.Empty;
                txtName.Text = string.Empty;
                txtTelephone.Text = string.Empty;
                txtAadhar.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtVillage.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtState.Text = string.Empty;
                txtZipCode.Text = string.Empty;
                txtCourierAddress.Text = string.Empty;
                chkIsAddresssame.Checked = false;
                chkStatus.Checked = false;
                rgSex.SelectedIndex = -1;
                txtAge.Text = string.Empty;
            }
            catch (Exception ex) { }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chkIsAddresssame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsAddresssame.Checked)
            {
                string stAddress = txtVillage.Text.Trim();
                if (!string.IsNullOrEmpty(txtCity.Text.Trim()))
                    stAddress += ", " + txtCity.Text.Trim();
                if (!string.IsNullOrEmpty(txtState.Text.Trim()))
                    stAddress += ", " + txtState.Text.Trim();
                if (!string.IsNullOrEmpty(txtZipCode.Text.Trim()))
                    stAddress += ", " + txtZipCode.Text.Trim();
                txtCourierAddress.Text = stAddress;
            }
            else
                txtCourierAddress.Text = string.Empty;
        }
        private void txtCity_Properties_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if ((string)e.DisplayValue != String.Empty)
            {
                txtCity.EditValue = e.DisplayValue;
                e.Handled = true;
            }
        }
        private void txtState_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            //DataRow Row;
            //RepositoryItemLookUpEdit Edit;
            //Edit = ((LookUpEdit)sender).Properties;

            //if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
            //    return;

            //Row = LookupTable.NewRow();
            //Row["Name"] = e.DisplayValue;
            //LookupTable.Rows.Add(Row);

            //e.Handled = true;
        }
        private void frmNewPatient_Load(object sender, EventArgs e)
        {
            rgSex.SelectedIndex = 0;
            chkStatus.Checked = true;
            chkIsAddresssame.Checked = false;
            txtAge.EditValue = 0;
            LoadAddress();
            if (PatientID > 0)
            {
                LoadPatient();
                btnSave.Text = "Save Patient";
            }
        }
        private void LoadAddress()
        {
            try
            {
                objEPatient.BranchID = Utility.BranchID;
                objDPatient.GetAddressDetails(objEPatient);
                txtVillage.Properties.DataSource = objEPatient.dtPatientDetails;
                txtVillage.Properties.DisplayMember = "PVillage";
                txtVillage.Properties.ValueMember = "PVillage";
            }
            catch (Exception ex) { }
        }
        private void txtVillage_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter && txtVillage.EditValue != null)
                {
                    object obj = txtVillage.Properties.GetDataSourceRowByKeyValue(txtVillage.EditValue);
                    if(obj != null)
                    {
                        DataRow sourceDataRow = (obj as DataRowView).Row;
                        txtCity.EditValue = sourceDataRow["PCity"];
                        txtState.EditValue = sourceDataRow["PState"];
                        txtZipCode.EditValue = sourceDataRow["PinCode"];
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }

        }
    }
}

