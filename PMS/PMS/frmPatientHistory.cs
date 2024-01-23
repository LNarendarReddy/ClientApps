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
        private void riView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                LoadTreatment(false);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void riEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                LoadTreatment(true);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void riPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gvPatientHistory.FocusedRowHandle >= 0)
                {
                    object OTreatmentID;
                    OTreatmentID = gvPatientHistory.GetFocusedRowCellValue("TreatmentID");
                    rptTreatment rpt = new rptTreatment();
                    rpt.Parameters["TreatmentID"].Value = OTreatmentID;
                    rpt.ShowPrintMarginsWarning = false;
                    Utility.Printreport(rpt, PrintersType.TreatmentPrint);

                    rptTreatmentPatientCopy rpt1 = new rptTreatmentPatientCopy();
                    rpt1.Parameters["TreatmentID"].Value = OTreatmentID;
                    rpt1.ShowPrintMarginsWarning = false;
                    Utility.Printreport(rpt1, PrintersType.TreatmentPrint);
                }
            }
            catch (Exception ex){ Utility.ShowError(ex); }
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
    }
}