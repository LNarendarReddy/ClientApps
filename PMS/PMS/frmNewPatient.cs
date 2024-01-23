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

namespace PMS
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
            txtdob.Properties.MaxValue = DateTime.Today;
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
                    txtRegNo.Text = dtPatient.Rows[0]["RegNo"].ToString();
                    txtName.Text = dtPatient.Rows[0]["PName"].ToString();
                    txtdob.Text = dtPatient.Rows[0]["DOB"].ToString();
                    txtfather.Text = dtPatient.Rows[0]["FatheName"].ToString();
                    txtTelephone.Text = dtPatient.Rows[0]["CNumber"].ToString();
                    txtAlternatePhone.Text = dtPatient.Rows[0]["ACnumber"].ToString();
                    txtAadhar.Text = dtPatient.Rows[0]["AadharNumber"].ToString();
                    txtEmail.Text = dtPatient.Rows[0]["Email"].ToString();
                    txtDoor.Text = dtPatient.Rows[0]["PDno"].ToString();
                    txtVillage.Text = dtPatient.Rows[0]["PVillage"].ToString();
                    txtCity.Text = dtPatient.Rows[0]["PCity"].ToString();
                    txtState.Text = dtPatient.Rows[0]["PState"].ToString();
                    txtZipCode.Text = dtPatient.Rows[0]["PinCode"].ToString();
                    txtCourierAddress.Text = dtPatient.Rows[0]["CourierAddress"].ToString();
                    chkIsAddresssame.Checked = Convert.ToBoolean(dtPatient.Rows[0]["IsCAddressSame"].ToString());
                    rgMaritalStatus.SelectedIndex = Convert.ToInt32(dtPatient.Rows[0]["MaritalStatus"].ToString());
                    rgSex.SelectedIndex = Convert.ToInt32(dtPatient.Rows[0]["PSex"].ToString());
                    txtAge.Text = dtPatient.Rows[0]["PAgeYears"].ToString();
                    txtMonths.Text = dtPatient.Rows[0]["PAgeMonths"].ToString();
                    rgBloodGroup.SelectedIndex = Convert.ToInt32(dtPatient.Rows[0]["BloodGroup"].ToString());
                    rgRH.SelectedIndex = Convert.ToInt32(dtPatient.Rows[0]["BloodGroupSign"].ToString());
                    chkStatus.Checked = Convert.ToBoolean(dtPatient.Rows[0]["PStatus"].ToString());
                    txtHeight.Text = dtPatient.Rows[0]["PHeight"].ToString();
                    txtWeight.Text = dtPatient.Rows[0]["PWeight"].ToString();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objEPatient.BranchID = Utility.BranchID;
                objEPatient.OrgID = Utility.OrgID;
                if (txtRegNo.Text == "0" || string.IsNullOrEmpty(txtRegNo.Text))
                    objEPatient.RegNo = -1;
                else
                    objEPatient.RegNo = Convert.ToInt32(txtRegNo.Text.Trim());
                objEPatient.PName = txtName.Text.Trim();
                objEPatient.PDOB = txtdob.DateTime;
                objEPatient.PFatherName = txtfather.Text.Trim();
                objEPatient.PCNumber = txtTelephone.Text.Trim();
                objEPatient.ACNumber = txtAlternatePhone.Text.Trim();
                objEPatient.AdharNumber = txtAadhar.Text.Trim();
                objEPatient.Email = txtEmail.Text.Trim();
                objEPatient.FaxNumber = string.Empty;
                objEPatient.OfficePhone = string.Empty;
                objEPatient.DoorNo = txtDoor.Text.Trim();
                objEPatient.Village = txtVillage.Text.Trim();
                objEPatient.City = txtCity.Text.Trim();
                objEPatient.State = txtState.Text.Trim();
                objEPatient.Pincode = txtZipCode.Text.Trim();
                objEPatient.CourierAddress = txtCourierAddress.Text.Trim();
                objEPatient.IsCourierAddressSame = Convert.ToBoolean(chkIsAddresssame.CheckState);
                objEPatient.PStatus = Convert.ToBoolean(chkStatus.CheckState);
                objEPatient.PFrame = -1;
                objEPatient.MaritalStatus = rgMaritalStatus.SelectedIndex;
                objEPatient.PSex = rgSex.SelectedIndex;
                objEPatient.PAgeYears = Convert.ToInt32(txtAge.Text.Trim());
                objEPatient.PageMonths = Convert.ToInt32(txtMonths.Text.Trim());
                objEPatient.BloodGroup = rgBloodGroup.SelectedIndex;
                objEPatient.BloodGroupSign = rgRH.SelectedIndex;
                objEPatient.PermanentBillingRequired = false;
                objEPatient.UserID = Utility.UserID;
                objEPatient.Status = Convert.ToBoolean(chkStatus.CheckState);
                objEPatient.PHeight = Convert.ToDecimal(txtHeight.EditValue);
                objEPatient.PWeight = Convert.ToDecimal(txtWeight.EditValue);
                objDPatient.SavePatient(objEPatient);
                XtraMessageBox.Show("Patient added successfully");
                if (!IsEdit)
                {
                    frmBookAppointment Obj = new frmBookAppointment(objEPatient.PatientID);
                    Obj.ShowDialog();
                }
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
                txtdob.Text = string.Empty;
                txtfather.Text = string.Empty;
                txtTelephone.Text = string.Empty;
                txtAlternatePhone.Text = string.Empty;
                txtAadhar.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtDoor.Text = string.Empty;
                txtVillage.Text = string.Empty;
                txtCity.Text = string.Empty;
                txtState.Text = string.Empty;
                txtZipCode.Text = string.Empty;
                txtCourierAddress.Text = string.Empty;
                chkIsAddresssame.Checked = false;
                chkStatus.Checked = false;
                rgMaritalStatus.SelectedIndex = -1;
                rgSex.SelectedIndex = -1;
                txtAge.Text = string.Empty;
                txtMonths.Text = string.Empty;
                rgBloodGroup.SelectedIndex = -1;
                rgRH.SelectedIndex = -1;
                //chkBillingRequire.Checked = false;
            }
            catch (Exception ex) { }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdob_DateTimeChanged(object sender, EventArgs e)
        {
            DateTime age = new DateTime(DateTime.Now.Subtract(txtdob.DateTime).Ticks);
            int year = age.Year - 1;
            txtAge.Text = year.ToString();
            txtMonths.Text = age.Month.ToString();
        }

        private void chkIsAddresssame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsAddresssame.Checked)
            {
                string stCourierAddress = txtDoor.Text.Trim() + ", " + txtVillage.Text.Trim() + ", " + txtCity.Text.Trim() + "\t" + txtState.Text.Trim() + "\t" + txtZipCode.Text.Trim();
                txtCourierAddress.Text = stCourierAddress;
            }
            else
                txtCourierAddress.Text = string.Empty;
        }

        private void txtCity_Properties_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if ((string)e.DisplayValue != String.Empty)
            {
                txtCity.EditValue = e.DisplayValue.ToString();
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
            txtdob.DateTime = DateTime.Now;
            rgSex.SelectedIndex = 0;
            rgMaritalStatus.SelectedIndex = 0;
            chkStatus.Checked = true;
            chkIsAddresssame.Checked = true;
            rgBloodGroup.SelectedIndex = 0;
            rgRH.SelectedIndex = 0;
            LoadAddress();
            if (PatientID > 0)
                LoadPatient();
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
                if (e.KeyChar == (char)Keys.Enter)
                {
                    DataRow sourceDataRow = (txtVillage.Properties.GetDataSourceRowByKeyValue(txtVillage.EditValue) as DataRowView).Row;
                    txtCity.EditValue = sourceDataRow["PCity"];
                    txtState.EditValue = sourceDataRow["PState"];
                    txtZipCode.EditValue = sourceDataRow["PinCode"];
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }

        }
    }
}
