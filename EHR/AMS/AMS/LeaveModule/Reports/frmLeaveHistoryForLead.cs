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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using log4net;

namespace EHR.LeaveModule
{
    public partial class frmLeaveHistoryForLead : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        public frmLeaveHistoryForLead()
        {
            InitializeComponent();
        }
        private void frmLeaveHistory_Load(object sender, EventArgs e)
        {
            try
            {
                objDLeave.GetFYear(objELeave);
                cmbFYear.Properties.DataSource = objELeave.dtFYear;
                cmbFYear.Properties.ValueMember = "FYearID";
                cmbFYear.Properties.DisplayMember = "FYearName";
                DataTable table = cmbFYear.Properties.DataSource as DataTable;
                foreach(DataRow dr in table.Rows)
                {
                    if(Convert.ToInt16(dr["Selected"]) == 1)
                    {
                        cmbFYear.EditValue = dr["FYearID"];
                        break;
                    }
                }

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
                objELeave.FYearID = cmbFYear.EditValue;
                objDLeave.GetLeaveHistoryForLEad(objELeave);
                gcLeaveHistory.DataSource = objELeave.dsLeaveHostory.Tables[0];
                gcLeaveHistory.ForceInitialize();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void gvLeaveHistory_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                //if (gvLeaveHistory.FocusedRowHandle >= 0)
                //{
                //    int ivalue = 0;
                //    int LeaveStatusID = 0;
                //    if (int.TryParse(Convert.ToString(gvLeaveHistory.GetFocusedRowCellValue("EmployeeLeaveID")), out ivalue) 
                //        && ivalue > 0 &&
                //        int.TryParse(Convert.ToString(gvLeaveHistory.GetFocusedRowCellValue("LeaveStatusID")), out LeaveStatusID))
                //    {
                //        if (LeaveStatusID == 1 || LeaveStatusID == 5)
                //        {
                //            DXMenuItem dxEdit = new DevExpress.Utils.Menu.DXMenuItem("Edit", Edit_ItemClick);
                //            dxEdit.Tag = ivalue;
                //            e.Menu.Items.Add(dxEdit);
                //            DXMenuItem dxCancel = new DevExpress.Utils.Menu.DXMenuItem("Cancel", Cancel_ItemClick);
                //            dxCancel.Tag = ivalue;
                //            e.Menu.Items.Add(dxCancel);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
            }
        }
        private void Edit_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem dx = sender as DXMenuItem;
                frmLeaveManagement Obj = new frmLeaveManagement(dx.Tag);
                Obj.ShowDialog();
                cmbFYear_EditValueChanged(null, null);
                Utility.Setfocus(gvLeaveHistory, "EmployeeLeaveID", dx.Tag);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void Cancel_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem dx = sender as DXMenuItem;
                objELeave.EmployeeLeaveID = dx.Tag;
                objDLeave.CancelLeave(objELeave);
                objDLeave.GetLeadDetails(objELeave);
                if(objELeave.dtLeadDetails != null &&
                    objELeave.dtLeadDetails.Rows.Count > 0)
                {
                    string stMailIds = string.Empty;
                    foreach (DataRow  dr in objELeave.dtLeadDetails.Rows)
                    {
                        stMailIds += Convert.ToString(dr["EMail"]) + ",";
                    }
                    stMailIds += Utility.UserEmail;
                    string stSubject = "Leave Canceled - " + Utility.UserFullName;
                    string stBody = string.Empty;
                    stBody = Utility.stParagraphBoldstart + "Leave Canceled : " + Utility.stParagraphend;
                    stBody += Utility.stParagraphstart +  "Employee Name : " + Utility.UserFullName + Utility.stParagraphend;
                    DateTime dtFromDate = DateTime.Now;
                    DateTime dtToDate = DateTime.Now;
                    if (DateTime.TryParse(Convert.ToString(gvLeaveHistory.GetFocusedRowCellValue("LeaveFromDate")), out dtFromDate) &&
                        DateTime.TryParse(Convert.ToString(gvLeaveHistory.GetFocusedRowCellValue("LeaveToDate")), out dtToDate))
                        stBody += Utility.stParagraphstart + "Leave From and To : " + dtFromDate.ToString("dd/MM/yyyy") + " - "
                        + dtToDate.ToString("dd/MM/yyyy") + Utility.stParagraphend;
                    else
                        stBody += Utility.stParagraphstart + "Leave From and To : " 
                            + gvLeaveHistory.GetFocusedRowCellValue("LeaveFromDate").ToString() + " - "
                     + gvLeaveHistory.GetFocusedRowCellValue("LeaveToDate").ToString() + Utility.stParagraphend;
                    stBody += Utility.stParagraphstart + "Leave Type: " 
                        + gvLeaveHistory.GetFocusedRowCellDisplayText("LeaveTypeName").ToString() + Utility.stParagraphend;
                    Utility.SendEmail(stSubject, stBody, stMailIds);
                }
                cmbFYear_EditValueChanged(null, null);
                Utility.Setfocus(gvLeaveHistory, "EmployeeLeaveID", dx.Tag);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcLeaveHistory.ShowRibbonPrintPreview();
        }
    }
}