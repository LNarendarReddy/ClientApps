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
using PMS.Reports;
using DevExpress.XtraReports.UI;
using static PMS.Utility;

namespace PMS
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
        public frmTreatment(bool Edit, int nTreatmentID)
        {
            InitializeComponent();
            txtMedforWeek.EditValue = 1;
            dtAppointment.EditValue = Utility.dtSelectedDate == null || Utility.dtSelectedDate == DateTime.MinValue ? DateTime.Today : Utility.dtSelectedDate;
            isEdit = Edit;
            TreatmentID = nTreatmentID;

        }

        private void frmTreatment_Load(object sender, EventArgs e)
        {
            try
            {
                clearFields();
                LoadInvestigation();
                LoadAppointments(0);
                LoadMedicineList();
                LoadMedicineMessure();
                if (TreatmentID > 0)
                    LoadTreatmentdetails(isEdit, TreatmentID);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void LoadMedicineMessure()
        {
            try
            {
                ObjDMedicine.GetMedicineMessure(ObjEMedicine);
                cmbMessure.Properties.DataSource = ObjEMedicine.dtMedicineMeasure;
                cmbMessure.Properties.DisplayMember = "MessureType";
                cmbMessure.Properties.ValueMember = "MedicineMessureID";
            }
            catch (Exception ex) { throw ex; }
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
        private void LoadInvestigation()
        {
            ObjEPatient = new EPatient();
            try
            {
                ObjEPatient.BranchID = Utility.BranchID;
                ObjDPatient.GetInvestigationDetails(ObjEPatient);
                cmbInvestigation.Properties.DataSource = ObjEPatient.dtIvs;
                cmbInvestigation.Properties.DisplayMember = "Description";
                cmbInvestigation.Properties.ValueMember = "InvestigationDetailsID";
            }
            catch (Exception ex) { throw ex; }
        }
        private void LoadAppointments(int nIndex)
        {
            try
            {
                ObjEMedicine = new EMedicine();
                ObjEMedicine.BranchID = Utility.BranchID;
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
                    ObjDPatient.GetLastTreatmengtID(ObjEPatient);
                    ObjDPatient.GetLastTreatmentDetails(ObjEPatient);
                    gdInvestigation.DataSource = ObjEPatient.dtTreatmentIVs;
                    gdPrescription.DataSource = ObjEPatient.dtMedicine;
                    if (ObjEPatient.dtTreatment.Rows.Count > 0)
                    {
                        txtLastVisitDate.EditValue = ObjEPatient.dtTreatment.Rows[0]["CreatedDate"];
                        txtComplaints.EditValue = ObjEPatient.dtTreatment.Rows[0]["CheifComplaints"];
                        txtFamilyHistory.EditValue = ObjEPatient.dtTreatment.Rows[0]["FamilyHistory"];
                        txtSurgicalHistory.EditValue = ObjEPatient.dtTreatment.Rows[0]["SurgicalHistory"];
                        txtAllergies.EditValue = ObjEPatient.dtTreatment.Rows[0]["Allergies"];
                        txtMedicalHistory.EditValue = ObjEPatient.dtTreatment.Rows[0]["MedicalHistory"];
                        dtAppointment.EditValue = ObjEPatient.dtTreatment.Rows[0]["AppointmentDate"];
                        txtMedforWeek.EditValue = ObjEPatient.dtTreatment.Rows[0]["MedicineForWeek"];
                        chkParcel.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsParcel"];
                        chkFree.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsFree"];
                        chkBill.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsBillRequired"];
                        chkPrint.EditValue = ObjEPatient.dtTreatment.Rows[0]["IsPrintPrescription"];
                        txtConsultation.EditValue = ObjEPatient.dtTreatment.Rows[0]["ConsultationFees"];
                        txtDiscount.EditValue = ObjEPatient.dtTreatment.Rows[0]["Discount"];
                        txtConsultation_EditValueChanged(null, null);
                    }
                    else
                    {
                        txtLastVisitDate.EditValue = null;
                        txtComplaints.EditValue = string.Empty;
                        txtFamilyHistory.EditValue = string.Empty;
                        txtSurgicalHistory.EditValue = string.Empty;
                        txtAllergies.EditValue = string.Empty;
                        txtMedicalHistory.EditValue = string.Empty;
                        dtAppointment.EditValue = Utility.dtSelectedDate;
                        txtMedforWeek.EditValue = "1";
                        chkParcel.Checked = false;
                        chkFree.Checked = false;
                        chkBill.Checked = false;
                        chkPrint.Checked = false;
                        txtConsultation.EditValue = 0;
                        txtDiscount.EditValue = 0;
                        txtTotalAmount.EditValue = 0;
                    }
                }
                else
                {
                    txtPatientID.EditValue = string.Empty;
                    txtPatientName.EditValue = string.Empty;
                    txtMobile.EditValue = string.Empty;
                    txtLastVisitDate.EditValue = null;
                    txtComplaints.EditValue = string.Empty;
                    txtFamilyHistory.EditValue = string.Empty;
                    txtSurgicalHistory.EditValue = string.Empty;
                    txtAllergies.EditValue = string.Empty;
                    txtMedicalHistory.EditValue = string.Empty;
                    dtAppointment.EditValue = Utility.dtSelectedDate;
                    txtMedforWeek.EditValue = 1;
                    chkParcel.Checked = false;
                    chkFree.Checked = false;
                    chkBill.Checked = false;
                    chkPrint.Checked = false;
                    txtConsultation.EditValue = 0;
                    txtDiscount.EditValue = 0;
                    txtTotalAmount.EditValue = 0;
                    ObjDPatient.GetLastTreatmengtID(ObjEPatient);
                    ObjEPatient.TreatmentID = -1;
                    ObjDPatient.GetLastTreatmentDetails(ObjEPatient);
                    gdInvestigation.DataSource = ObjEPatient.dtTreatmentIVs;
                    gdPrescription.DataSource = ObjEPatient.dtMedicine;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void LoadTreatmentdetails(bool isEdit, int nTreatmentID)
        {
            DataSet dsTreatment = new DataSet();
            DataTable dtTreatment = new DataTable(), dtInvestigation = new DataTable(), dtMedicine = new DataTable();
            ObjETreatment = new ETreatment();
            try
            {
                if (isEdit)
                {
                    TreatmentLayer.Enabled = true;
                }
                else
                {
                    TreatmentLayer.Enabled = false;
                }
                gdAppointments.Enabled = false;
                btnSkip.Enabled = false;
                ObjETreatment.TreatmentID = nTreatmentID;
                objDTreatment.GetTreatmentDetails(ObjETreatment);
                if (ObjETreatment.dsTreatmentDetails.Tables.Count > 0 && ObjETreatment.dsTreatmentDetails.Tables[0].Rows.Count > 0)
                {
                    dtTreatment = ObjETreatment.dsTreatmentDetails.Tables[0];
                    txtTreatmentID.EditValue = dtTreatment.Rows[0]["TreatmentID"];
                    txtPatientID.EditValue = dtTreatment.Rows[0]["RegNo"];
                    txtPatientName.EditValue = dtTreatment.Rows[0]["PName"];
                    txtMobile.EditValue = dtTreatment.Rows[0]["CNumber"];
                    txtLastVisitDate.EditValue = dtTreatment.Rows[0]["CreatedDate"];
                    txtComplaints.EditValue = dtTreatment.Rows[0]["CheifComplaints"];
                    txtFamilyHistory.EditValue = dtTreatment.Rows[0]["FamilyHistory"];
                    txtSurgicalHistory.EditValue = dtTreatment.Rows[0]["SurgicalHistory"];
                    txtAllergies.EditValue = dtTreatment.Rows[0]["Allergies"];
                    txtMedicalHistory.EditValue = dtTreatment.Rows[0]["MedicalHistory"];
                    dtAppointment.EditValue = dtTreatment.Rows[0]["AppointmentDate"];
                    txtMedforWeek.EditValue = dtTreatment.Rows[0]["MedicineForWeek"];
                    txtConsultation.EditValue = dtTreatment.Rows[0]["ConsultationFees"];
                    txtDiscount.EditValue = dtTreatment.Rows[0]["Discount"];
                    PID = dtTreatment.Rows[0]["PatientID"];
                    AID = dtTreatment.Rows[0]["AppointmentID"];
                    chkParcel.EditValue = dtTreatment.Rows[0]["IsParcel"];
                    chkFree.EditValue = dtTreatment.Rows[0]["IsFree"];
                    chkBill.EditValue = dtTreatment.Rows[0]["IsBillRequired"];
                    chkPrint.EditValue = dtTreatment.Rows[0]["IsPrintPrescription"];
                }
                dtInvestigation = ObjETreatment.dsTreatmentDetails.Tables[1];
                dtMedicine = ObjETreatment.dsTreatmentDetails.Tables[2];
                gdInvestigation.DataSource = dtInvestigation;
                gdPrescription.DataSource = dtMedicine;
                txtConsultation_EditValueChanged(null, null);
                gdAppointments.Enabled = false;
                btnSkip.Enabled = false;
            }
            catch (Exception ex) { throw ex; }
        }
        private void gvInvestigation_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ObjETreatment = new ETreatment();
            try
            {
                decimal nDiscount, nCounsultation;
                if (decimal.TryParse(txtDiscount.Text, out nDiscount) && decimal.TryParse(txtConsultation.Text, out nCounsultation))
                {
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
                    ObjETreatment.ChiefComplaints = txtComplaints.Text.Trim();
                    ObjETreatment.FamilyHistory = txtFamilyHistory.Text.Trim();
                    ObjETreatment.SurgicalHistory = txtSurgicalHistory.Text.Trim();
                    ObjETreatment.Allergies = txtAllergies.Text.Trim();
                    ObjETreatment.MedicalHistory = txtMedicalHistory.Text.Trim();
                    ObjETreatment.MedicinePrescriptionforWeek = Convert.ToInt32(txtMedforWeek.Text.Trim());
                    ObjETreatment.ConsultationFees = nCounsultation;
                    ObjETreatment.Discount = nDiscount;
                    ObjETreatment.isParcel = Convert.ToBoolean(chkParcel.CheckState);
                    ObjETreatment.isFree = Convert.ToBoolean(chkFree.CheckState);
                    ObjETreatment.isBillRequired = Convert.ToBoolean(chkBill.CheckState);
                    ObjETreatment.isPrintPrescription = Convert.ToBoolean(chkPrint.CheckState);
                    ObjETreatment.UserID = Utility.UserID;
                    ObjETreatment.BranchID = Utility.BranchID;

                    DataTable dtTemp = new DataTable();
                    dtTemp = ((DataTable)gdInvestigation.DataSource).Copy();
                    ObjETreatment.dtInvestigations = dtTemp.Copy();
                    foreach (DataColumn dc in dtTemp.Columns)
                    {
                        if (dc.ColumnName != "InvestigationDetailsID")
                            ObjETreatment.dtInvestigations.Columns.Remove(dc.ColumnName);
                    }
                    ObjETreatment.dtMedicine = Medicine();
                    DTreatment ObjDTreatment = new DTreatment();
                    ObjDTreatment.SaveTreatment(ObjETreatment);

                    if (ObjETreatment.TreatmentID > 0)
                    {

                        rptTreatment rpt = new rptTreatment();
                        rpt.Parameters["TreatmentID"].Value = ObjETreatment.TreatmentID;
                        if(chkParcel.Checked)
                            rpt.Parameters["IsLiquidForm"].Value = "Liquid Form Medicine";
                        rpt.ShowPrintMarginsWarning = false;
                        Utility.Printreport(rpt, PrintersType.TreatmentPrint);

                        rptTreatmentPatientCopy rpt1 = new rptTreatmentPatientCopy();
                        rpt1.Parameters["TreatmentID"].Value = ObjETreatment.TreatmentID;
                        rpt1.ShowPrintMarginsWarning = false;
                        Utility.Printreport(rpt1, PrintersType.TreatmentPrint);
                    }

                    XtraMessageBox.Show("Treatment saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (TreatmentID > 0)
                        this.Close();
                    else
                    {
                        LoadAppointments(0);
                        txtPatientID.Focus();
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
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
                    if (dc.ColumnName == "MedicineID" || dc.ColumnName == "SPrice" || dc.ColumnName == "Quantity"
                        || dc.ColumnName == "TotalPrice" || dc.ColumnName == "PosologyString")
                    {

                    }
                    else
                        dtMedicine.Columns.Remove(dc.ColumnName);
                }
            }
            catch (Exception ex) { throw ex; }
            return dtMedicine;
        }

        private void riDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //gvPrescription.DeleteRow(gvPrescription.FocusedRowHandle);
                ((DataTable)gdPrescription.DataSource).Rows.RemoveAt(gvPrescription.FocusedRowHandle);
            }
            catch (Exception ex) { }
        }

        private void riPosology_Click(object sender, EventArgs e)
        {
            DataTable dtORgMedicine = new DataTable();
            try
            {
                stPosology = string.Empty;
                int nMedicineID = Convert.ToInt32(gvPrescription.GetRowCellValue(gvPrescription.FocusedRowHandle, gcMedicineID));
                frmMedicine Obj = new frmMedicine(nMedicineID);
                Obj.MedicineLayer.Enabled = false;
                Obj.ShowDialog();
                stPosology = Obj.stPosologyCheck;
                dtORgMedicine = (DataTable)gdPrescription.DataSource;
                DataRow row = dtORgMedicine.Select("MedicineID=" + nMedicineID).FirstOrDefault();
                row["PosologyString"] = stPosology;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void cmbInvestigation_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (cmbInvestigation.EditValue == null)
                    {
                        cmbMedicine.Focus();
                        return;
                    }
                    DataTable dtinvs = (DataTable)gdInvestigation.DataSource;
                    DataRow[] rows = dtinvs.Select("[InvestigationDetailsID] = " + Convert.ToString(cmbInvestigation.EditValue));
                    if (rows.Count() > 0)
                    {
                        var dlgresult = XtraMessageBox.Show("Selected Investigation already exists in table! \n\rDo you want to add more Investigations..?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Convert.ToString(dlgresult).ToLower() == "yes")
                            cmbInvestigation.Focus();
                        else
                            cmbMedicine.Focus();
                    }
                    else
                    {
                        DataRow sourceDataRow = (cmbInvestigation.Properties.GetDataSourceRowByKeyValue(cmbInvestigation.EditValue) as DataRowView).Row;
                        DataRow drnew = dtinvs.NewRow();
                        drnew["InvestigationDetailsID"] = sourceDataRow["InvestigationDetailsID"];
                        drnew["CategoryID"] = sourceDataRow["CategoryID"];
                        drnew["CategoryName"] = sourceDataRow["CategoryName"];
                        drnew["Description"] = sourceDataRow["Description"];
                        dtinvs.Rows.Add(drnew);
                        var dlgresult = XtraMessageBox.Show("Do you want to add more Investigations..?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Convert.ToString(dlgresult).ToLower() == "yes")
                            cmbInvestigation.Focus();
                        else
                            cmbMedicine.Focus();
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void riDeleteInvestigation_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)gdInvestigation.DataSource).Rows.RemoveAt(gvInvestigation.FocusedRowHandle);
            }
            catch (Exception ex) { }
        }

        private void txtMedicineQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable dtORgMedicine = new DataTable();
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (cmbMedicine.EditValue == null)
                    {
                        txtConsultation.Focus();
                    }
                    else
                    {
                        decimal dQuantity = 0;
                        if (!decimal.TryParse(Convert.ToString(txtMedicineQuantity.EditValue), out dQuantity) || dQuantity == 0)
                        {
                            XtraMessageBox.Show("Quantity Cannot be zero!");
                            cmbMedicine.Focus();
                            return;
                        }

                        if (gdPrescription.DataSource == null)
                            dtORgMedicine = ObjEMedicine.dtMedicineList;
                        else
                            dtORgMedicine = (DataTable)gdPrescription.DataSource;

                        DataRow[] rows = dtORgMedicine.Select("[MedicineID] = " + Convert.ToString(cmbMedicine.EditValue));
                        if (rows.Count() > 0)
                        {
                            var dlgresult = XtraMessageBox.Show("Selected medicine already exists in table. \n\rDo you want to add more medicine..?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Convert.ToString(dlgresult).ToLower() == "yes")
                                cmbMedicine.Focus();
                            else
                                txtConsultation.Focus();
                        }
                        else
                        {
                            DataRow sourceDataRow = (cmbMedicine.Properties.GetDataSourceRowByKeyValue(cmbMedicine.EditValue) as DataRowView).Row;
                            DataRow drnew = dtORgMedicine.NewRow();
                            drnew["MedicineCode"] = sourceDataRow["MedicineCode"];
                            drnew["MedicineName"] = sourceDataRow["MedicineName"];
                            drnew["GenericName"] = sourceDataRow["GenericName"];
                            drnew["MedicineID"] = sourceDataRow["MedicineID"];
                            drnew["PowerName"] = sourceDataRow["PowerName"];
                            drnew["MessureType"] = cmbMessure.Text;
                            drnew["TypeName"] = sourceDataRow["TypeName"];
                            drnew["Quantity"] = txtMedicineQuantity.EditValue;
                            drnew["SPrice"] = sourceDataRow["SPrice"];
                            decimal dSprice = 0;
                            if (decimal.TryParse(Convert.ToString(sourceDataRow["SPrice"]), out dSprice))
                            {
                                drnew["TotalPrice"] = dQuantity * dSprice;
                            }
                            drnew["PosologyString"] = sourceDataRow["PosologyString"];
                            dtORgMedicine.Rows.Add(drnew);
                            gdPrescription.DataSource = dtORgMedicine;

                            var dlgresult = XtraMessageBox.Show("Do you want to add more medicine..?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Convert.ToString(dlgresult).ToLower() == "yes")
                                cmbMedicine.Focus();
                            else
                                txtConsultation.Focus();
                        }
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void LoadTreatmentMedicine()
        {
            try
            {
                DataTable dtORgMedicine = (DataTable)gdPrescription.DataSource;
                DataRow sourceDataRow = (cmbMedicine.Properties.GetDataSourceRowByKeyValue(cmbMedicine.EditValue) as DataRowView).Row;
                DataRow drnew = dtORgMedicine.NewRow();
                drnew["MedicineCode"] = sourceDataRow["MedicineCode"];
                drnew["MedicineName"] = sourceDataRow["MedicineName"];
                drnew["GenericName"] = sourceDataRow["GenericName"];
                drnew["MedicineID"] = sourceDataRow["MedicineID"];
                drnew["MedicineQuantity"] = sourceDataRow["Quantity"];
                drnew["PowerName"] = sourceDataRow["PowerName"];
                drnew["MessureType"] = sourceDataRow["MessureType"];
                drnew["TypeName"] = sourceDataRow["TypeName"];
                drnew["Quantity"] = txtMedicineQuantity.EditValue;
                drnew["SPrice"] = sourceDataRow["SPrice"];
                decimal dQuantity = 0, dSprice = 0;
                if (decimal.TryParse(txtMedicineQuantity.Text, out dQuantity) && decimal.TryParse(Convert.ToString(sourceDataRow["SPrice"]), out dSprice))
                {
                    drnew["TotalPrice"] = dQuantity * dSprice;
                }
                drnew["PosologyString"] = stPosology;
                dtORgMedicine.Rows.Add(drnew);
                gdPrescription.DataSource = dtORgMedicine;
                cmbMedicine.Focus();
            }
            catch (Exception ex) { throw ex; }
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

        private void clearFields()
        {
            try
            {
                txtPatientID.EditValue = string.Empty;
                txtPatientName.EditValue = string.Empty;
                txtMobile.EditValue = string.Empty;
                txtLastVisitDate.EditValue = null;
                txtComplaints.EditValue = string.Empty;
                txtFamilyHistory.EditValue = string.Empty;
                txtSurgicalHistory.EditValue = string.Empty;
                txtAllergies.EditValue = string.Empty;
                txtMedicalHistory.EditValue = string.Empty;
                cmbInvestigation.EditValue = null;
                gdInvestigation.DataSource = new DataTable();
                txtTreatmentID.EditValue = string.Empty;
                dtAppointment.EditValue = null;
                txtMedforWeek.EditValue = 1;
                chkBill.Checked = false;
                chkFree.Checked = false;
                chkParcel.Checked = false;
                chkPrint.Checked = false;
                cmbMedicine.EditValue = null;
                txtMedicineQuantity.EditValue = 0;
                gdPrescription.DataSource = new DataTable();
                txtConsultation.EditValue = 0;
                txtDiscount.EditValue = 0;
                txtTotalAmount.EditValue = 0;

            }
            catch (Exception ex) { }
        }

        private void txtMedforWeek_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                }
            }
            catch (Exception ex) { }
        }

        private void txtConsultation_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal nDiscount = 0, nCounsultation = 0;
                if (decimal.TryParse(Convert.ToString(txtConsultation.EditValue), out nCounsultation) && decimal.TryParse(Convert.ToString(txtDiscount.EditValue), out nDiscount))
                    txtTotalAmount.EditValue = nCounsultation - nDiscount;
                else
                    txtTotalAmount.EditValue = 0;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void cmbMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                   if (e.KeyChar == (char)Keys.Enter)
                {
                    if (cmbMedicine.EditValue != null)
                    {
                        DataRow sourceDataRow = (cmbMedicine.Properties.GetDataSourceRowByKeyValue(cmbMedicine.EditValue) as DataRowView).Row;
                        cmbMessure.EditValue = sourceDataRow["MedicinceMessureID"];
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void cmbMessure_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (cmbMedicine.EditValue != null)
                    {
                        DataRow sourceDataRow = (cmbMedicine.Properties.GetDataSourceRowByKeyValue(cmbMedicine.EditValue) as DataRowView).Row;
                        sourceDataRow["MedicinceMessureID"] = cmbMessure.EditValue;
                        ObjEMedicine.MedicineID = Convert.ToInt32(sourceDataRow["MedicineID"]);
                        ObjEMedicine.MedicineMessureID = Convert.ToInt32(cmbMessure.EditValue);
                        ObjDMedicine.UpdateMedicineMessure(ObjEMedicine);
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
    }
}