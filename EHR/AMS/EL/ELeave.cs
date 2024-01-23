using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ELeave
    {
        public DataTable dtLeaveType = null;
        public DataTable dtLeavePlan = null;
        public DataTable dtFYear = null;
        public DataTable dtLeaveDetails = null;
        public DataTable dtEmployeeList = null;
        public DataSet dsCompOff = null;
        public DataTable dtCompOff = null;
        public DataTable dtLeaveBalance = null;
        public DataSet dsLeaveHostory = null;
        public DataTable dtLeaves = null;
        public DataTable dtLeaveDuration = null;
        public DataTable dtLeadDetails = null;
        public DataTable dtLeaveCalendar = null;

        public object FYearID = null;
        public object FromDate = DateTime.Now;
        public object ToDate = DateTime.Now;
        public object EnableAssessment = false;
        public object LeaveTypeID = null;
        public object EmployeeID = null;
        public object LeaveDate = null;
        public object LeaveReason = null;
        public object ApporvalLead = null;
        public object LeaveDuration = null;
        public object CompensatoryLeaveApprovalID = null;
        public object ApprovalStatus = null;

        public object EmployeeLeaveID = null;
        public object LeaveCategory = null;
        public object IsDeliveryExists = null;
        public object IsCompleted = null;
        public object ProjectPlan = null;
        public object EmergencyContact = null;
        public object LeaveApprovalID = null;
        public object Comments = null;
        public object CompensatoryLeaveID = null;
        public object ChangeStatusComments = null;
        public bool IsSave = false;
        public object SelectedMonth = null;
        public object RoleID = null;
        public object UserID = null;

    }
}
