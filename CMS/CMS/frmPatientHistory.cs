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
    public partial class frmPatientHistory : DevExpress.XtraEditors.XtraForm
    {
        int PatientID = 0;
        EPatient Objepatient = new EPatient();
        DPatient ObjdPatient = new DPatient();
        public frmPatientHistory(int _PatientID)
        {
            InitializeComponent();
            PatientID = _PatientID;
        }

        private void frmPatientHistory_Load(object sender, EventArgs e)
        {
            try
            {
                Objepatient.BranchID = Utility.BranchID;
                ObjdPatient.GetPatientDetails(Objepatient);
                cmbPatient.Properties.DataSource = Objepatient.dtPatientDetails;
                cmbPatient.Properties.DisplayMember = "PName";
                cmbPatient.Properties.ValueMember = "PatientID";
                if (PatientID > 0)
                {
                    cmbPatient.EditValue = PatientID;
                    cmbPatient.Enabled = false;
                    Objepatient.PatientID = PatientID;
                    ObjdPatient.GetPatientHistory(Objepatient);
                    gcPatientHistory.DataSource = Objepatient.dtPatientHistory;
                }
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void LoadTreatment(bool isEdit)
        {
            int TreatmentID;
            try
            {
                TreatmentID = Convert.ToInt32(gvPatientHistory.GetRowCellValue(gvPatientHistory.FocusedRowHandle, gcTreatmentID));
                frmTreatment Obj = new frmTreatment(isEdit, TreatmentID);
                Obj.ShowDialog();
            }
            catch (Exception ex) { throw ex; }
        }

        private void lookUpEdit1_Properties_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(cmbPatient.EditValue), out ivalue))
                    {
                        Objepatient.PatientID = ivalue;
                        ObjdPatient.GetPatientHistory(Objepatient);
                        gcPatientHistory.DataSource = Objepatient.dtPatientHistory;
                    }
                }

            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void riView_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTreatment(false);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void riEdit_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTreatment(true);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void riPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvPatientHistory.FocusedRowHandle >= 0 && cmbPatient.EditValue != null)
                {
                    rptSamjawan rpt = new rptSamjawan();
                    rpt.Parameters["RegNo"].Value = gvPatientHistory.GetFocusedRowCellValue("RegNo");
                    rpt.Parameters["PName"].Value = gvPatientHistory.GetFocusedRowCellValue("PName");
                    rpt.Parameters["ADate"].Value = gvPatientHistory.GetFocusedRowCellValue("AppointmentDate");
                    rpt.Parameters["NumberOfWeeks"].Value = gvPatientHistory.GetFocusedRowCellValue("NumberOfWeeks");
                    rpt.Parameters["AmountPerWeek"].Value = gvPatientHistory.GetFocusedRowCellValue("AmountPerWeek");
                    rpt.Parameters["ConFee"].Value = gvPatientHistory.GetFocusedRowCellValue("ConsultationFees");
                    rpt.Parameters["PreviousBalance"].Value = gvPatientHistory.GetFocusedRowCellValue("Due");
                    rpt.Parameters["TotalAmount"].Value = gvPatientHistory.GetFocusedRowCellValue("TotalAmount");
                    string stMedicine = Convert.ToString(gvPatientHistory.GetFocusedRowCellValue("Medicines"));
                    string[] l = stMedicine.Split(',');
                    string stnew = string.Empty;
                    foreach(string s in l)
                    {
                        stnew += s.Trim() + Environment.NewLine;
                    }
                    rpt.Parameters["Medicines"].Value = stnew;
                    string stAddress = Convert.ToString(gvPatientHistory.GetFocusedRowCellValue("PVillage"));
                    string stVillage = Convert.ToString(gvPatientHistory.GetFocusedRowCellValue("PCity"));
                    string stCity = Convert.ToString(gvPatientHistory.GetFocusedRowCellValue("PState"));
                    string stState = Convert.ToString(gvPatientHistory.GetFocusedRowCellValue("PinCode"));
                    if (!string.IsNullOrEmpty(stVillage))
                        stAddress += ", " + stVillage;
                    if (!string.IsNullOrEmpty(stCity))
                        stAddress += ", " + stCity;
                    if (!string.IsNullOrEmpty(stState))
                        stAddress += ", " + stState;
                    rpt.Parameters["Address"].Value = stAddress;
                    Utility.Printreport(rpt, PrintersType.Samjawan);
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPatient.EditValue != null)
                {
                    DataRow sourceDataRow = (cmbPatient.Properties.GetDataSourceRowByKeyValue(cmbPatient.EditValue) as DataRowView).Row;
                    rptHistory rpt = new rptHistory();
                    rpt.Parameters["PName"].Value = sourceDataRow["PName"];
                    rpt.Parameters["RegNo"].Value = sourceDataRow["RegNo"];
                    rpt.DataSource = Objepatient.dtPatientHistory;
                    Utility.Printreport(rpt, PrintersType.History);
                }
            }
            catch (Exception ex){}
        }
    }
}