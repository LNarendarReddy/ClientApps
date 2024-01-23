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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using CMS.Reports;
using DevExpress.XtraReports.UI;

namespace CMS
{

    public partial class frmTreatment : DevExpress.XtraEditors.XtraForm
    {
        EPatient ObjEPatient = new EPatient();
        DPatient ObjDPatient = new DPatient();
        EMedicine ObjEMedicine = new EMedicine();
        DMedicine ObjDMedicine = new DMedicine();
        ETreatment ObjETreatment = new ETreatment();
        DTreatment objDTreatment = new DTreatment();
        string stPosology = string.Empty;
        bool isEdit;
        int TreatmentID;
        object PID;
        object AID;
        object PVillage = null;
        object PCity = null;
        object PState = null;
        object Pincode = null;
        public frmTreatment(bool Edit, int nTreatmentID)
        {
            InitializeComponent();
            txtMedforWeek.EditValue = 1;
            dtAppointment.EditValue = Utility.dtSelectedDate;
            isEdit = Edit;
            TreatmentID = nTreatmentID;

        }
        private void frmTreatment_Load(object sender, EventArgs e)
        {
            try
            {
                clearFields();
                LoadMedicineList();
                if (TreatmentID > 0)
                    LoadTreatmentdetails(isEdit);
                else
                    LoadAppointments(0);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void clearFields()
        {
            try
            {
                txtPatientID.EditValue = string.Empty;
                txtPatientName.EditValue = string.Empty;
                txtMobile.EditValue = string.Empty;
                txtLastVisitDate.EditValue = null;
                txtComplaints.EditValue = string.Empty;
                txtTreatmentID.EditValue = string.Empty;
                dtAppointment.EditValue = null;
                txtMedforWeek.EditValue = 1;
                chkBill.Checked = false;
                chkFree.Checked = false;
                cmbMedicine.EditValue = null;
                gdPrescription.DataSource = new DataTable();
                txtConsultation.EditValue = 0;
                txtPreviousBalance.EditValue = 0;
                txtTotalAmount.EditValue = 0;

            }
            catch (Exception ex) { }
        }
        private void LoadMedicineList()
        {
            ObjEMedicine = new EMedicine();
            try
            {
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjDMedicine.GetMedicineList(ObjEMedicine);
                cmbMedicine.Properties.DataSource = ObjEMedicine.dtMedicineList;
                cmbMedicine.Properties.DisplayMember = "MedicineName";
                cmbMedicine.Properties.ValueMember = "MedicineID";
            }
            catch (Exception ex) { throw ex; }
        }
        private void LoadAppointments(int nIndex)
        {
            try
            {
                ObjEMedicine = new EMedicine();
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjEMedicine.dtAppointmentDate = Utility.dtSelectedDate;
                ObjDMedicine.GetAppointments(ObjEMedicine);
                gdAppointments.DataSource = ObjEMedicine.dtAppointment;
                int IVlaue = 0;
                if (ObjEMedicine.dtAppointment.Rows.Count > 0 && int.TryParse(Convert.ToString(ObjEMedicine.dtAppointment.Rows[nIndex]["PatientID"]), out IVlaue))
                {
                    ObjEPatient.PatientID = IVlaue;
                    ObjEPatient.TreatmentID = 0;
                    txtPatientID.EditValue = ObjEMedicine.dtAppointment.Rows[nIndex]["RegNo"];
                    txtPatientName.EditValue = ObjEMedicine.dtAppointment.Rows[nIndex]["PName"];
                    txtMobile.EditValue = ObjEMedicine.dtAppointment.Rows[nIndex]["CNumber"];
                    txtTreatmentID.EditValue = ObjEMedicine.dtAppointment.Rows[nIndex]["TockenID"];
                    PVillage = ObjEMedicine.dtAppointment.Rows[nIndex]["PVillage"];
                    PCity = ObjEMedicine.dtAppointment.Rows[nIndex]["PCity"];
                    PState = ObjEMedicine.dtAppointment.Rows[nIndex]["PState"];
                    Pincode = ObjEMedicine.dtAppointment.Rows[nIndex]["PinCode"];
                    ObjDPatient.GetLastTreatmengtID(ObjEPatient);
                    ObjDPatient.GetLastTreatmentDetails(ObjEPatient);
                    gdPrescription.DataSource = ObjEPatient.dtMedicine;
                    if (ObjEPatient.dtTreatment.Rows.Count > 0)
                    {
                        txtLastVisitDate.EditValue = ObjEPatient.dtTreatment.Rows[0]["CreatedDate"];
                        txtFirstVisitDate.EditValue = ObjEPatient.dtTreatment.Rows[0]["FirstVisitDate"];
                        txtComplaints.EditValue = ObjEPatient.dtTreatment.Rows[0]["CheifComplaints"];
                        dtAppointment.EditValue = ObjEPatient.dtTreatment.Rows[0]["AppointmentDate"];
                        txtMedforWeek.EditValue = ObjEPatient.dtTreatment.Rows[0]["NumberOfWeeks"];
                        txtAmountPerWeek.EditValue = ObjEPatient.dtTreatment.Rows[0]["AmountPerWeek"];
                        txtConsultation.EditValue = ObjEPatient.dtTreatment.Rows[0]["ConsultationFees"];
                        txtPreviousBalance.EditValue = ObjEPatient.dtTreatment.Rows[0]["PreviousBalance"];
                        txtTotalAmount.EditValue = ObjEPatient.dtTreatment.Rows[0]["TotalAmount"];
                        txtPaidAmount.EditValue = 0;
                        chkFree.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsFree"];
                        chkBill.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsBillRequired"];
                        gdPrescription.DataSource = ObjEPatient.dtMedicine;
                    }
                    else
                    {
                        txtLastVisitDate.EditValue = null;
                        txtFirstVisitDate.EditValue = null;
                        txtComplaints.EditValue = string.Empty;
                        dtAppointment.EditValue = Utility.dtSelectedDate;
                        txtMedforWeek.EditValue = 1;
                        txtAmountPerWeek.EditValue = 0;
                        txtConsultation.EditValue = 0;
                        txtPreviousBalance.EditValue = 0;
                        txtTotalAmount.EditValue = 0;
                        txtPaidAmount.EditValue = 0;
                        chkFree.Checked = false;
                        chkBill.Checked = false;
                        ObjEPatient.dtMedicine = new DataTable();
                        ObjEPatient.dtMedicine.Columns.Add("MedicineID", typeof(int));
                        ObjEPatient.dtMedicine.Columns.Add("MedicineCode", typeof(string));
                        ObjEPatient.dtMedicine.Columns.Add("MedicineName", typeof(string));
                        ObjEPatient.dtMedicine.Columns.Add("GenericName", typeof(string));
                        ObjEPatient.dtMedicine.Columns.Add("TypeName", typeof(string));
                        ObjEPatient.dtMedicine.Columns.Add("SPrice", typeof(decimal));
                        gdPrescription.DataSource = ObjEPatient.dtMedicine;
                    }
                }
                cmbMedicine.Focus();
            }
            catch (Exception ex) { throw ex; }
        }
        private void cmbMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataTable dtORgMedicine = new DataTable();
                try
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        if (cmbMedicine.EditValue == null)
                        {
                            txtMedforWeek.Focus();
                        }
                        else
                        {
                            dtORgMedicine = (DataTable)gdPrescription.DataSource;
                            DataRow[] rows = dtORgMedicine.Select("[MedicineID] = " + Convert.ToString(cmbMedicine.EditValue));
                            if (rows.Count() > 0)
                            {
                                var dlgresult = XtraMessageBox.Show("Selected medicine already exists in table.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbMedicine.EditValue = null;
                                cmbMedicine.Focus();
                            }
                            else
                            {
                                DataRow sourceDataRow = (cmbMedicine.Properties.GetDataSourceRowByKeyValue(cmbMedicine.EditValue) as DataRowView).Row;
                                DataRow drnew = dtORgMedicine.NewRow();
                                drnew["MedicineCode"] = sourceDataRow["MedicineCode"];
                                drnew["MedicineName"] = sourceDataRow["MedicineName"];
                                drnew["GenericName"] = sourceDataRow["GenericName"];
                                drnew["MedicineID"] = sourceDataRow["MedicineID"];
                                drnew["TypeName"] = sourceDataRow["TypeName"];
                                dtORgMedicine.Rows.Add(drnew);
                                gdPrescription.DataSource = dtORgMedicine;
                                cmbMedicine.EditValue = null;
                                cmbMedicine.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex) { Utility.ShowError(ex); }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void riDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)gdPrescription.DataSource).Rows.RemoveAt(gvPrescription.FocusedRowHandle);
            }
            catch (Exception ex) { }
        }
        private DataTable Medicine()
        {
            DataTable dtORgMedicine = new DataTable();
            DataTable dtMedicine = new DataTable();
            try
            {
                dtORgMedicine = (DataTable)gdPrescription.DataSource;
                dtMedicine = dtORgMedicine.Copy();
                foreach (DataColumn dc in dtORgMedicine.Columns)
                {
                    if (dc.ColumnName != "MedicineID")
                        dtMedicine.Columns.Remove(dc.ColumnName);
                }
            }
            catch (Exception ex) { throw ex; }
            return dtMedicine;
        }
        private void txtConsultation_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal nCounsultation = 0, AmountPerWeek = 0, PreviousBalance = 0;
                int noofWeeks = 1;
                int.TryParse(Convert.ToString(txtMedforWeek.EditValue), out noofWeeks);
                decimal.TryParse(Convert.ToString(txtConsultation.EditValue), out nCounsultation);
                decimal.TryParse(Convert.ToString(txtAmountPerWeek.EditValue), out AmountPerWeek);
                decimal.TryParse(Convert.ToString(txtPreviousBalance.EditValue), out PreviousBalance);
                txtTotalAmount.EditValue = (noofWeeks * AmountPerWeek) + nCounsultation + PreviousBalance;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ObjETreatment = new ETreatment();
            try
            {
                if (gvPrescription.RowCount == 0)
                    return;
                if (TreatmentID > 0)
                {
                    ObjETreatment.TreatmentID = TreatmentID;
                    ObjETreatment.PatientID = Convert.ToInt32(PID);
                    ObjETreatment.AppointmentID = Convert.ToInt32(AID);
                }
                else
                {
                    ObjETreatment.TreatmentID = -1;
                    ObjETreatment.PatientID = Convert.ToInt32(gvAppointments.GetFocusedRowCellValue("PatientID").ToString());
                    ObjETreatment.AppointmentID = Convert.ToInt32(gvAppointments.GetFocusedRowCellValue("AppointmentID").ToString());
                }
                ObjETreatment.ChiefComplaints = txtComplaints.EditValue;
                ObjETreatment.MedicinePrescriptionforWeek = txtMedforWeek.EditValue;
                ObjETreatment.AmountPerWeek = txtAmountPerWeek.EditValue;
                ObjETreatment.ConsultationFees = txtConsultation.EditValue;
                ObjETreatment.TotalAmount = txtTotalAmount.EditValue;
                ObjETreatment.PaidAmount = txtPaidAmount.EditValue;
                ObjETreatment.Due = txtPreviousBalance.EditValue;
                ObjETreatment.isFree = Convert.ToBoolean(chkFree.CheckState);
                ObjETreatment.isBillRequired = Convert.ToBoolean(chkBill.CheckState);
                ObjETreatment.UserID = Utility.UserID;
                ObjETreatment.BranchID = Utility.BranchID;
                ObjETreatment.dtMedicine = Medicine();
                DTreatment ObjDTreatment = new DTreatment();
                ObjDTreatment.SaveTreatment(ObjETreatment);

                if (ObjETreatment.TreatmentID > 0)
                {
                    rptSamjawan rpt = new rptSamjawan();
                    rpt.Parameters["RegNo"].Value = txtPatientID.EditValue;
                    rpt.Parameters["PName"].Value = txtPatientName.EditValue;
                    rpt.Parameters["ADate"].Value = dtAppointment.EditValue;
                    rpt.Parameters["NumberOfWeeks"].Value = txtMedforWeek.EditValue;
                    rpt.Parameters["AmountPerWeek"].Value = txtAmountPerWeek.EditValue;
                    rpt.Parameters["ConFee"].Value = txtConsultation.EditValue;
                    rpt.Parameters["PreviousBalance"].Value = txtPreviousBalance.EditValue;
                    rpt.Parameters["TotalAmount"].Value = txtTotalAmount.EditValue;
                    DataTable dttmep = (DataTable)gdPrescription.DataSource;
                    string stMedicines = string.Empty;
                    foreach(DataRow dr in dttmep.Rows)
                    {
                        stMedicines += Convert.ToString(dr["MedicineName"]) + Environment.NewLine;
                    }
                    rpt.Parameters["Medicines"].Value = stMedicines;

                    string stAddress = Convert.ToString(PVillage);
                    string stVillage = Convert.ToString(PCity);
                    string stCity = Convert.ToString(PState);
                    string stState = Convert.ToString(Pincode);
                    if (!string.IsNullOrEmpty(stVillage))
                        stAddress += ", " + stVillage;
                    if (!string.IsNullOrEmpty(stCity))
                        stAddress += ", " + stCity;
                    if (!string.IsNullOrEmpty(stState))
                        stAddress += ", " + stState;
                    rpt.Parameters["Address"].Value = stAddress;
                    Utility.Printreport(rpt, PrintersType.Samjawan);
                }
                XtraMessageBox.Show("Treatment saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (TreatmentID > 0)
                    this.Close();
                else
                {
                    LoadAppointments(0);
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            int nIndex;
            try
            {
                gvAppointments.Focus();
                nIndex = gvAppointments.FocusedRowHandle;
                if (nIndex < 0 || nIndex >= gvAppointments.DataRowCount - 1)
                    return;
                gvAppointments.MoveNext();
                nIndex = gvAppointments.FocusedRowHandle;
                LoadAppointments(gvAppointments.FocusedRowHandle);
                gvAppointments.FocusedRowHandle = nIndex;
            }
            catch (Exception EX) { Utility.ShowError(EX); }
        }
        private void LoadTreatmentdetails(bool isEdit)
        {
            ObjETreatment = new ETreatment();
            try
            {
                gdAppointments.Enabled = false;
                btnSkip.Enabled = false;
                ObjEPatient.TreatmentID = TreatmentID;
                ObjDPatient.GetLastTreatmentDetails(ObjEPatient);
                gdPrescription.DataSource = ObjEPatient.dtMedicine;
                if (ObjEPatient.dtTreatment.Rows.Count > 0)
                {
                    txtPatientID.EditValue = ObjEPatient.dtTreatment.Rows[0]["RegNo"];
                    txtPatientName.EditValue = ObjEPatient.dtTreatment.Rows[0]["PName"];
                    txtMobile.EditValue = ObjEPatient.dtTreatment.Rows[0]["CNumber"];
                    txtTreatmentID.EditValue = ObjEPatient.dtTreatment.Rows[0]["TockenID"];
                    txtLastVisitDate.EditValue = ObjEPatient.dtTreatment.Rows[0]["CreatedDate"];
                    txtComplaints.EditValue = ObjEPatient.dtTreatment.Rows[0]["CheifComplaints"];
                    dtAppointment.EditValue = ObjEPatient.dtTreatment.Rows[0]["AppointmentDate"];
                    txtMedforWeek.EditValue = ObjEPatient.dtTreatment.Rows[0]["NumberOfWeeks"];
                    txtAmountPerWeek.EditValue = ObjEPatient.dtTreatment.Rows[0]["AmountPerWeek"];
                    txtConsultation.EditValue = ObjEPatient.dtTreatment.Rows[0]["ConsultationFees"];
                    txtPreviousBalance.EditValue = ObjEPatient.dtTreatment.Rows[0]["PreviousBalance"];
                    txtTotalAmount.EditValue = ObjEPatient.dtTreatment.Rows[0]["TotalAmount"];
                    PVillage = ObjEPatient.dtTreatment.Rows[0]["PVillage"];
                    PCity = ObjEPatient.dtTreatment.Rows[0]["PCity"];
                    PState = ObjEPatient.dtTreatment.Rows[0]["PState"];
                    Pincode = ObjEPatient.dtTreatment.Rows[0]["PinCode"];
                    txtPaidAmount.EditValue = 0;
                    chkFree.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsFree"];
                    chkBill.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsBillRequired"];
                    txtFirstVisitDate.EditValue = ObjEPatient.dtTreatment.Rows[0]["FirstVisitDate"];
                    PID = ObjEPatient.dtTreatment.Rows[0]["PatientID"];
                    AID = ObjEPatient.dtTreatment.Rows[0]["AppointmentID"];
                    gdPrescription.DataSource = ObjEPatient.dtMedicine;
                }
            }
            catch (Exception ex) { throw ex; }
        }

    }
}