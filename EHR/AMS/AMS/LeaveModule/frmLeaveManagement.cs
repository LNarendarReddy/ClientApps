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
using log4net;

namespace EHR
{
    public partial class frmLeaveManagement : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        bool _IsEdit = false;
        public frmLeaveManagement(object EmployeeLeaveID)
        {
            InitializeComponent();
            layoutControlItem12.Text = "If not completed, has the work been delegated/ rescheduled? \n\rHow are you planning to meet the timeline?";
            layoutControlItem13.Text = "Your contact number during your absence.\n\r This number will be contacted only in case of utmost delivery emergency.";
            objELeave.EmployeeLeaveID = EmployeeLeaveID;
        }

        private void frmLeaveManagement_Load(object sender, EventArgs e)
        {
            try
            {
                objDLeave.GetFYear(objELeave);
                cmbFYear.Properties.DataSource = objELeave.dtFYear;
                cmbFYear.Properties.ValueMember = "FYearID";
                cmbFYear.Properties.DisplayMember = "FYearName";
                DataTable table = cmbFYear.Properties.DataSource as DataTable;
                foreach (DataRow dr in table.Rows)
                {
                    if (Convert.ToInt16(dr["Selected"]) == 1)
                    {
                        cmbFYear.EditValue = dr["FYearID"];
                        break;
                    }
                }
                objDLeave.GetLeavePlan(objELeave);
                cmbLeaveCategory.Properties.DataSource = objELeave.dtLeavePlan;
                cmbLeaveCategory.Properties.ValueMember = "LookupID";
                cmbLeaveCategory.Properties.DisplayMember = "LookupValue";
                objELeave.EmployeeID = Utility.UserID;
                objDLeave.GetLeaveType(objELeave);
                cmbLeaveType.Properties.DataSource = objELeave.dtLeaveType;
                cmbLeaveType.Properties.ValueMember = "LeaveTypeID";
                cmbLeaveType.Properties.DisplayMember = "LeaveTypeName";
                objELeave.EmployeeID = Utility.UserID;
                objDLeave.GetEmployeeList(objELeave);
                cmbLead.Properties.DataSource = objELeave.dtEmployeeList;
                cmbLead.Properties.DisplayMember = "FullName";
                cmbLead.Properties.ValueMember = "UserInfoID";
                objDLeave.GetLeaveDuration(objELeave);
                cmbLeaveDuration.Properties.DataSource = objELeave.dtLeaveDuration;
                cmbLeaveDuration.Properties.ValueMember = "LookupID";
                cmbLeaveDuration.Properties.DisplayMember = "LookupValue";

                if (Convert.ToInt32(objELeave.EmployeeLeaveID) > 0)
                {
                    _IsEdit = true;
                    objDLeave.GetLeaveDetailsByID(objELeave);
                    cmbFYear.EditValue = objELeave.dtLeaves.Rows[0]["FYearID"];
                    cmbLeaveType.EditValue = objELeave.dtLeaves.Rows[0]["LeaveTypeID"];
                    dtpFromDate.EditValue = objELeave.dtLeaves.Rows[0]["LeaveFromDate"];
                    dtpToDate.EditValue = objELeave.dtLeaves.Rows[0]["LeaveToDate"];
                    txtLeaveReason.EditValue = objELeave.dtLeaves.Rows[0]["LeaveReason"];
                    chkIsDelivery.EditValue = objELeave.dtLeaves.Rows[0]["IsProjectDelivery"];
                    chkIsCompleted.EditValue = objELeave.dtLeaves.Rows[0]["IsCompleted"];
                    txtProjectPlan.EditValue = objELeave.dtLeaves.Rows[0]["ProjectPlan"];
                    txtEmergency.EditValue = objELeave.dtLeaves.Rows[0]["EmergencyContact"];
                    cmbLeaveCategory.EditValue = objELeave.dtLeaves.Rows[0]["LeaveCategoryID"];
                    cmbLeaveDuration.EditValue = objELeave.dtLeaves.Rows[0]["LeaveDurationID"];
                    cmbLead.SetEditValue(objELeave.dtLeaves.Rows[0]["Leads"]);
                    cmbFYear.Enabled = false;
                    cmbLeaveType.Enabled = false;
                }
                else
                {
                    cmbLeaveDuration.EditValue = 6;
                }

            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                if (dtpToDate.DateTime.Date < dtpFromDate.DateTime.Date)
                    throw new Exception("ToDate cannot be less than From Date");
                if (chkIsDelivery.Checked == true && chkIsCompleted.Checked == false && txtProjectPlan.EditValue == null)
                    throw new Exception("If project work not completed, Please enter plan for the same");
                double IValue = 0;
                if (dtpFromDate.DateTime.Date != dtpToDate.DateTime.Date
                                    && Convert.ToInt16(cmbLeaveDuration.EditValue) != 6)
                    throw new Exception("Leave duration should be Full Day");

                if (Convert.ToInt16(cmbLeaveDuration.EditValue) != 6 &&
                    double.TryParse(Convert.ToString(txtLeaveBalance.EditValue), out IValue) &&
                    IValue < 0.5)
                    throw new Exception("Leave days cannot be greater than Leave Balance Days");
                objELeave.EmployeeID = Utility.UserID;
                objELeave.LeaveTypeID = cmbLeaveType.EditValue;
                objELeave.FYearID = cmbFYear.EditValue;
                objELeave.FromDate = dtpFromDate.EditValue;
                objELeave.ToDate = dtpToDate.EditValue;
                objELeave.LeaveCategory = cmbLeaveCategory.EditValue;
                objELeave.LeaveReason = txtLeaveReason.EditValue;
                objELeave.IsDeliveryExists = chkIsDelivery.EditValue;
                objELeave.IsCompleted = chkIsCompleted.EditValue;
                objELeave.ProjectPlan = txtProjectPlan.EditValue;
                objELeave.EmergencyContact = txtEmergency.EditValue;
                objELeave.ApporvalLead= cmbLead.EditValue;
                objELeave.LeaveDuration = cmbLeaveDuration.EditValue;
                objDLeave.SaveLeave(objELeave);
                DataTable table = cmbLead.Properties.DataSource as DataTable;
                String stMailIDs = string.Empty;
                int count = cmbLead.Properties.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    if (cmbLead.Properties.Items[i].CheckState == CheckState.Checked)
                        stMailIDs += Convert.ToString(table.Rows[i]["EMail"]) + ",";
                }
                stMailIDs += Utility.UserEmail + ",";
                stMailIDs += Utility.HREmail;
                string stSubject = "Leave Application - " + Utility.UserFullName;
                string stBody = string.Empty;
                if (_IsEdit)
                    stBody = Utility.stParagraphBoldstart + "Leave Details Updated :" + Utility.stParagraphend;
                else
                    stBody = Utility.stParagraphBoldstart + "Leave Details :" + Utility.stParagraphend;

                stBody += Utility.stTableStart;
                stBody += Utility.stTableHeaderStart;
                stBody += Utility.stColumn1Start + "Perticulars" + Utility.stCellHeaderEnd;
                stBody += Utility.stColumn2Start + "Details" + Utility.stCellHeaderEnd;
                stBody += Utility.stRowEnd;

                stBody += Utility.stRowStart;
                    stBody += Utility.stColumn1Start + "Employee Name: " + Utility.stCellRowEnd;
                    stBody += Utility.stColumn2Start + Utility.UserFullName + Utility.stCellRowEnd;
                    stBody += Utility.stRowEnd;

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "Leave From and To :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + dtpFromDate.DateTime.ToString("dd/MM/yyyy") + "/" + dtpToDate.DateTime.ToString("dd/MM/yyyy") + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;

                if (Convert.ToInt16(cmbLeaveDuration.EditValue) != 6)
                {
                    stBody += Utility.stRowStart;
                    stBody += Utility.stColumn1Start + "No.Of Days :" + Utility.stCellRowEnd;
                    stBody += Utility.stColumn2Start + "0.5" + Utility.stCellRowEnd;
                    stBody += Utility.stRowEnd;
                }
                else
                {
                    stBody += Utility.stRowStart;
                    stBody += Utility.stColumn1Start + "No.Of Days :" + Utility.stCellRowEnd;
                    stBody += Utility.stColumn2Start + GetBusinessDays(dtpFromDate.DateTime, dtpToDate.DateTime) + Utility.stCellRowEnd;
                    //stBody += Utility.stColumn2Start + Convert.ToString((dtpToDate.DateTime.Date - dtpFromDate.DateTime.Date).TotalDays + 1) + Utility.stCellRowEnd;
                    stBody += Utility.stRowEnd;
                }

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "Leave Category :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + cmbLeaveDuration.Text + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "Leave Type :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + cmbLeaveType.Text + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "Reason For Leave Taking :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + txtLeaveReason.Text + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;

                string stTemp1 = chkIsDelivery.Checked == true ? "Yes" : "No";

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "Is there any delivery or deadline for the day/ days of leave ? :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + stTemp1 + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;

                stTemp1 = chkIsCompleted.Checked == true ? "Yes" : "No";

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "Has the work for the delivery been completed ? :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + stTemp1 + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "If not completed, has the work been delegated / rescheduled ? \n\r How are you planning to meet the timeline ? :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + txtProjectPlan.Text + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;

                stBody += Utility.stRowStart;
                stBody += Utility.stColumn1Start + "Your contact number during your absence. \n\r This number will be contacted only in case of utmost delivery emergency. :" + Utility.stCellRowEnd;
                stBody += Utility.stColumn2Start + txtEmergency.Text + Utility.stCellRowEnd;
                stBody += Utility.stRowEnd;
                stBody += Utility.stTableEnd;
                Utility.SendEmail(stSubject, stBody, stMailIDs);
                Utility.ShowError(new Exception("Leave applied successfully and sent for approval. \n\r Please check the status in view window!"),true );
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void cmbLeaveType_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbFYear.EditValue != null && cmbLeaveType.EditValue != null)
                {
                    objELeave.FYearID = cmbFYear.EditValue;
                    objELeave.LeaveTypeID = cmbLeaveType.EditValue;
                    objELeave.EmployeeID = Utility.UserID;
                    objDLeave.GetLeaveDetailsByType(objELeave);
                   if(objELeave.dtLeaveDetails != null && objELeave.dtLeaveDetails.Rows.Count > 0)
                    {
                        txtTotalLeaves.EditValue = objELeave.dtLeaveDetails.Rows[0][0];
                        txtLeavesProRata.EditValue = objELeave.dtLeaveDetails.Rows[0][1];
                        if (Convert.ToInt32(objELeave.EmployeeLeaveID) > 0)
                        {
                            double LeaveDays = 0;
                            double LeavesAvailed = 0;
                            double LeavesBalance = 0;
                            if (double.TryParse(Convert.ToString(objELeave.dtLeaves.Rows[0]["LeaveDays"]), out LeaveDays) &&
                                 double.TryParse(Convert.ToString(objELeave.dtLeaveDetails.Rows[0][2]), out LeavesAvailed) &&
                                 double.TryParse(Convert.ToString(objELeave.dtLeaveDetails.Rows[0][3]), out LeavesBalance))
                            {
                                txtLeavesAvailed.EditValue = LeavesAvailed - LeaveDays;
                                txtLeaveBalance.EditValue = LeavesBalance + LeaveDays;
                            }
                        }
                        else
                        {
                            txtLeavesAvailed.EditValue = objELeave.dtLeaveDetails.Rows[0][2];
                            txtLeaveBalance.EditValue = objELeave.dtLeaveDetails.Rows[0][3];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void dtpFromDate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFromDate.DateTime.Date <= DateTime.Now.Date)
                    cmbLeaveCategory.EditValue = 5;
                else
                    cmbLeaveCategory.EditValue = 4;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void cmbFYear_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbLeaveType_EditValueChanged(null, null);
                DataRow dr = (cmbFYear.GetSelectedDataRow() as DataRowView).Row;
                if (dr != null)
                {
                    DateTime FromDate = DateTime.Now;
                    DateTime ToDate = DateTime.Now;
                    if (DateTime.TryParse(Convert.ToString(dr["FromDate"]), out FromDate))
                    {
                        dtpFromDate.Properties.MinValue = FromDate;
                        dtpToDate.Properties.MinValue = FromDate;
                    }
                    if (DateTime.TryParse(Convert.ToString(dr["ToDate"]), out ToDate))
                    {
                        dtpFromDate.Properties.MaxValue = ToDate;
                        dtpToDate.Properties.MaxValue = ToDate;
                    }
                }
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
        }

        public double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays = 0;
            try
            {
                calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

                if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
                if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;
            }
            catch (Exception ex){}
            return calcBusinessDays;
        }
    }
}