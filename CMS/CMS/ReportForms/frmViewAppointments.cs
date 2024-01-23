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
using DL;
using EL;
using CMS.Reports;
using DevExpress.XtraReports.UI;

namespace CMS.ReportForms
{
    public partial class frmViewAppointments : DevExpress.XtraEditors.XtraForm
    {
        EPatient ObjEPatient = null;
        DPatient ObjDPatient = null;
        public frmViewAppointments()
        {
            InitializeComponent();
        }

        private void frmViewAppointments_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEPatient == null)
                    ObjEPatient = new EPatient();
                if (ObjDPatient == null)
                    ObjDPatient = new DPatient();
                ObjEPatient.AppointmentDate = Utility.dtSelectedDate;
                ObjEPatient.BranchID = Utility.BranchID;
                ObjDPatient.GetAppointmentByDate(ObjEPatient);
                gcAppointments.DataSource = ObjEPatient.dtAppointment;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvAppointments.FocusedRowHandle >= 0)
                {
                    string stType = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PatientType"));
                    if (stType == "New Patient")
                    {
                        rptToken rpt = new rptToken();
                        rpt.Parameters["ADate"].Value = gvAppointments.GetFocusedRowCellValue("AppointmentDate");
                        rpt.Parameters["PName"].Value = gvAppointments.GetFocusedRowCellValue("PName");
                        rpt.Parameters["RegNo"].Value = gvAppointments.GetFocusedRowCellValue("RegNo");
                        rpt.Parameters["TokenNo"].Value = gvAppointments.GetFocusedRowCellValue("TockenID");
                        rpt.Parameters["Mobile"].Value = gvAppointments.GetFocusedRowCellValue("CNumber");
                        string stAddress = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PVillage"));
                        string stVillage = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PCity"));
                        string stCity = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PState"));
                        string stState = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PinCode"));
                        if (!string.IsNullOrEmpty(stVillage))
                            stAddress += ", " + stVillage;
                        if (!string.IsNullOrEmpty(stCity))
                            stAddress += ", " + stCity;
                        if (!string.IsNullOrEmpty(stState))
                            stAddress += ", " + stState;
                        rpt.Parameters["Address"].Value = stAddress;
                        rpt.ShowPrintMarginsWarning = false;

                        rptNewBigPrint rptBig = new rptNewBigPrint();
                        rptBig.Parameters["ADate"].Value = gvAppointments.GetFocusedRowCellValue("AppointmentDate");
                        rptBig.Parameters["PName"].Value = gvAppointments.GetFocusedRowCellValue("PName");
                        rptBig.Parameters["RegNo"].Value = gvAppointments.GetFocusedRowCellValue("RegNo");
                        rptBig.Parameters["Mobile"].Value = gvAppointments.GetFocusedRowCellValue("CNumber");
                        rptBig.Parameters["Age"].Value = gvAppointments.GetFocusedRowCellValue("PAgeYears");
                        rptBig.Parameters["Address"].Value = stAddress;
                        rptBig.ShowPrintMarginsWarning = false;

                        Utility.Printreport(rpt, PrintersType.NewSmallPrint);
                        Utility.Printreport(rptBig, PrintersType.NewBigPrint);
                    }
                    else
                    {
                        int ivalue = 0;
                        bool _rtn = int.TryParse(Convert.ToString(gvAppointments.GetFocusedRowCellValue("PatientID")), out ivalue);
                        if (_rtn)
                        {
                            if (ObjEPatient == null)
                                ObjEPatient = new EPatient();
                            if (ObjDPatient == null)
                                ObjDPatient = new DPatient();
                            ObjEPatient.PatientID = ivalue;
                            ObjEPatient.TreatmentID = 0;
                            ObjDPatient.GetLastTreatmengtID(ObjEPatient);
                            if (ObjEPatient.TreatmentID > 0)
                            {
                                ObjDPatient.GetLastTreatmentDetails(ObjEPatient);
                                rptTokenOldBooking rpt = new rptTokenOldBooking();
                                rpt.Parameters["ADate"].Value = gvAppointments.GetFocusedRowCellValue("AppointmentDate");
                                rpt.Parameters["PName"].Value = gvAppointments.GetFocusedRowCellValue("PName");
                                rpt.Parameters["RegNo"].Value = gvAppointments.GetFocusedRowCellValue("RegNo");
                                rpt.Parameters["TokenNo"].Value = gvAppointments.GetFocusedRowCellValue("TockenID");
                                rpt.Parameters["Mobile"].Value = gvAppointments.GetFocusedRowCellValue("CNumber");
                                string stAddress = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PVillage"));
                                string stVillage = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PCity"));
                                string stCity = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PState"));
                                string stState = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PinCode"));
                                if (!string.IsNullOrEmpty(stVillage))
                                    stAddress += ", " + stVillage;
                                if (!string.IsNullOrEmpty(stCity))
                                    stAddress += ", " + stCity;
                                if (!string.IsNullOrEmpty(stState))
                                    stAddress += ", " + stState;
                                rpt.Parameters["Address"].Value = stAddress;
                                if (ObjEPatient.dtTreatment.Rows.Count > 0)
                                {
                                    rpt.Parameters["Total"].Value = ObjEPatient.dtTreatment.Rows[0]["TotalAmount"];
                                    rpt.Parameters["Paid"].Value = ObjEPatient.dtTreatment.Rows[0]["PaidAmount"];
                                    rpt.Parameters["Due"].Value = ObjEPatient.dtTreatment.Rows[0]["PreviousBalance"];
                                    rpt.Parameters["LastVisit"].Value = ObjEPatient.dtTreatment.Rows[0]["AppointmentDate"];
                                    rpt.Parameters["FirstVisit"].Value = ObjEPatient.dtTreatment.Rows[0]["FirstVisitDate"];
                                }
                                rpt.DataSource = ObjEPatient.dtMedicine;
                                rpt.ShowPrintMarginsWarning = false;
                                Utility.Printreport(rpt, PrintersType.NewSmallPrint);
                            }
                            else
                            {
                                rptToken rpt = new rptToken();
                                rpt.Parameters["ADate"].Value = gvAppointments.GetFocusedRowCellValue("AppointmentDate");
                                rpt.Parameters["PName"].Value = gvAppointments.GetFocusedRowCellValue("PName");
                                rpt.Parameters["RegNo"].Value = gvAppointments.GetFocusedRowCellValue("RegNo");
                                rpt.Parameters["TokenNo"].Value = gvAppointments.GetFocusedRowCellValue("TockenID");
                                rpt.Parameters["Mobile"].Value = gvAppointments.GetFocusedRowCellValue("CNumber");
                                string stAddress = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PVillage"));
                                string stVillage = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PCity"));
                                string stCity = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PState"));
                                string stState = Convert.ToString(gvAppointments.GetFocusedRowCellValue("PinCode"));
                                if (!string.IsNullOrEmpty(stVillage))
                                    stAddress += ", " + stVillage;
                                if (!string.IsNullOrEmpty(stCity))
                                    stAddress += ", " + stCity;
                                if (!string.IsNullOrEmpty(stState))
                                    stAddress += ", " + stState;
                                rpt.Parameters["Address"].Value = stAddress;
                                rpt.ShowPrintMarginsWarning = false;

                                rptNewBigPrint rptBig = new rptNewBigPrint();
                                rptBig.Parameters["ADate"].Value = gvAppointments.GetFocusedRowCellValue("AppointmentDate");
                                rptBig.Parameters["PName"].Value = gvAppointments.GetFocusedRowCellValue("PName");
                                rptBig.Parameters["RegNo"].Value = gvAppointments.GetFocusedRowCellValue("RegNo");
                                rptBig.Parameters["Mobile"].Value = gvAppointments.GetFocusedRowCellValue("CNumber");
                                rptBig.Parameters["Age"].Value = gvAppointments.GetFocusedRowCellValue("PAgeYears");
                                rptBig.Parameters["Address"].Value = stAddress;
                                rptBig.ShowPrintMarginsWarning = false;
                                Utility.Printreport(rpt, PrintersType.NewSmallPrint);
                                Utility.Printreport(rptBig, PrintersType.NewBigPrint);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
         }
    }
}