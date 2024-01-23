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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.CustomEditor;
using EL;
using DL;
using CMS.Reports;
using DevExpress.XtraReports.UI;

namespace CMS
{
    public partial class frmSearchPatient : DevExpress.XtraEditors.XtraForm
    {
        EPatient Objepatient = new EPatient();
        DPatient ObjdPatient = new DPatient();
        public frmSearchPatient()
        {
            InitializeComponent();
        }
        BindingSource bSource = new BindingSource();
        private void frmSearchPatient_Load(object sender, EventArgs e)
        {
            try
            {
                Binddata();
            }
            catch (Exception ex) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmNewPatient objfrm = new frmNewPatient(-1);
            objfrm.ShowDialog();
            Binddata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Convert.ToInt32(gvSearchPatient.GetFocusedRowCellValue(gdPatientID));
                frmNewPatient Obj = new frmNewPatient(PatientID);
                Obj.IsEdit = true;
                Obj.MdiParent = this.MdiParent;
                Obj.StartPosition = FormStartPosition.Manual;
                Obj.Location = new Point(0, 0);
                Obj.Show();
            }
            catch (Exception ex){}
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {
                int PatientID = Convert.ToInt32(gvSearchPatient.GetFocusedRowCellValue(gdPatientID));
                frmPatientHistory Obj = new frmPatientHistory(PatientID);
                Obj.MdiParent = this.MdiParent;
                Obj.Show();
            }
            catch (Exception ex){}
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                int ivalue = 0;
                bool _rtn = int.TryParse(Convert.ToString(gvSearchPatient.GetFocusedRowCellValue("PatientID")), out ivalue);
                if (_rtn)
                {
                    if (Objepatient == null)
                        Objepatient = new EPatient();
                    if (ObjdPatient == null)
                        ObjdPatient = new DPatient();

                    Objepatient. AppointmentID = 0;
                    Objepatient.PatientID = ivalue;
                    Objepatient.DoctorID = Utility.DoctorID;
                    Objepatient.AppointmentDate = Utility.dtSelectedDate;
                    Objepatient.UserID = Utility.UserID;
                    Objepatient.BranchID = Utility.BranchID;
                    ObjdPatient.SaveAppointment(Objepatient);
                    Objepatient.TreatmentID = 0;
                    ObjdPatient.GetLastTreatmengtID(Objepatient);
                    if (Objepatient.TreatmentID > 0)
                    {
                        ObjdPatient.GetLastTreatmentDetails(Objepatient);
                        rptTokenOldBooking rpt = new rptTokenOldBooking();
                        rpt.Parameters["ADate"].Value = Objepatient.dtAppointment.Rows[0]["AppointmentDate"];
                        rpt.Parameters["PName"].Value = Objepatient.dtAppointment.Rows[0]["PName"];
                        rpt.Parameters["RegNo"].Value = Objepatient.dtAppointment.Rows[0]["RegNo"];
                        rpt.Parameters["TokenNo"].Value = Objepatient.dtAppointment.Rows[0]["TockenID"];
                        rpt.Parameters["Mobile"].Value = Objepatient.dtAppointment.Rows[0]["CNumber"];
                        string stAddress = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PVillage"]);
                        string stVillage = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PCity"]);
                        string stCity = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PState"]);
                        string stState = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PinCode"]);
                        if (!string.IsNullOrEmpty(stVillage))
                            stAddress += ", " + stVillage;
                        if (!string.IsNullOrEmpty(stCity))
                            stAddress += ", " + stCity;
                        if (!string.IsNullOrEmpty(stState))
                            stAddress += ", " + stState;
                        rpt.Parameters["Address"].Value = stAddress;
                        if (Objepatient.dtTreatment.Rows.Count > 0)
                        {
                            rpt.Parameters["Total"].Value = Objepatient.dtTreatment.Rows[0]["TotalAmount"];
                            rpt.Parameters["Paid"].Value = Objepatient.dtTreatment.Rows[0]["PaidAmount"];
                            rpt.Parameters["Due"].Value = Objepatient.dtTreatment.Rows[0]["PreviousBalance"];
                            rpt.Parameters["LastVisit"].Value = Objepatient.dtTreatment.Rows[0]["AppointmentDate"];
                            rpt.Parameters["FirstVisit"].Value = Objepatient.dtTreatment.Rows[0]["FirstVisitDate"];
                        }
                        rpt.DataSource = Objepatient.dtMedicine;
                        rpt.ShowPrintMarginsWarning = false;
                        Utility.Printreport(rpt, PrintersType.NewSmallPrint);
                    }
                    else
                    {
                        rptToken rpt = new rptToken();
                        rpt.Parameters["ADate"].Value = Objepatient.dtAppointment.Rows[0]["AppointmentDate"];
                        rpt.Parameters["PName"].Value = Objepatient.dtAppointment.Rows[0]["PName"];
                        rpt.Parameters["RegNo"].Value = Objepatient.dtAppointment.Rows[0]["RegNo"];
                        rpt.Parameters["TokenNo"].Value = Objepatient.dtAppointment.Rows[0]["TockenID"];
                        rpt.Parameters["Mobile"].Value = Objepatient.dtAppointment.Rows[0]["CNumber"];
                        string stAddress = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PVillage"]);
                        string stVillage = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PCity"]);
                        string stCity = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PState"]);
                        string stState = Convert.ToString(Objepatient.dtAppointment.Rows[0]["PinCode"]);
                        if (!string.IsNullOrEmpty(stVillage))
                            stAddress += ", " + stVillage;
                        if (!string.IsNullOrEmpty(stCity))
                            stAddress += ", " + stCity;
                        if (!string.IsNullOrEmpty(stState))
                            stAddress += ", " + stState;
                        rpt.Parameters["Address"].Value = stAddress;
                        rpt.ShowPrintMarginsWarning = false;

                        rptNewBigPrint rptBig = new rptNewBigPrint();
                        rptBig.Parameters["ADate"].Value = Objepatient.dtAppointment.Rows[0]["AppointmentDate"];
                        rptBig.Parameters["PName"].Value = Objepatient.dtAppointment.Rows[0]["PName"];
                        rptBig.Parameters["RegNo"].Value = Objepatient.dtAppointment.Rows[0]["RegNo"];
                        rptBig.Parameters["Age"].Value = Objepatient.dtAppointment.Rows[0]["PAgeYears"];
                        rptBig.Parameters["Mobile"].Value = Objepatient.dtAppointment.Rows[0]["CNumber"];
                        rptBig.Parameters["Address"].Value = stAddress;
                        rptBig.ShowPrintMarginsWarning = false;

                        Utility.Printreport(rpt, PrintersType.NewSmallPrint);
                        Utility.Printreport(rptBig, PrintersType.NewBigPrint);
                    }
                }
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void Binddata()
        {
            try
            {
                Objepatient.BranchID = Utility.BranchID;
                ObjdPatient.GetPatientDetails(Objepatient);
                gdSearchpatient.DataSource = Objepatient.dtPatientDetails;
            }
            catch (Exception ex){}
        }
    }
}