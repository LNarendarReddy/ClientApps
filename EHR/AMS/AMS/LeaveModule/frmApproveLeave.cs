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
    public partial class frmApproveLeave : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        public frmApproveLeave()
        {
            InitializeComponent();
        }
        private void frmLeaveHistory_Load(object sender, EventArgs e)
        {
            try
            {
                objELeave.EmployeeID = Utility.UserID;
                objDLeave.GetLeavesForApproval(objELeave);
                DataColumn keyColumn = objELeave.dsLeaveHostory.Tables[0].Columns["EmployeeLeaveID"];
                DataColumn foreignKeyColumn = objELeave.dsLeaveHostory.Tables[1].Columns["EmoloyeeLeaveID"];
                objELeave.dsLeaveHostory.Relations.Add("drApproval", keyColumn, foreignKeyColumn);
                gcLeaveHistory.DataSource = objELeave.dsLeaveHostory.Tables[0];
                gcLeaveHistory.ForceInitialize();

                GridView gvLead = new GridView(gcLeaveHistory);
                gcLeaveHistory.LevelTree.Nodes.Add("drApproval", gvLead);
                gvLead.ViewCaption = "Approval Persons";
                gvLead.PopulateColumns(objELeave.dsLeaveHostory.Tables[1]);
                gvLead.Columns["EmoloyeeLeaveID"].VisibleIndex = -1;
                gvLead.Columns["LeaveApprovalID"].VisibleIndex = -1;
                gvLead.Columns["LeadID"].VisibleIndex = -1;
                gvLead.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
                gvLead.Appearance.HeaderPanel.Options.UseFont = true;
                gvLead.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
                gvLead.Appearance.Row.Options.UseFont = true;
                gvLead.OptionsBehavior.Editable = true;
                gvLead.OptionsCustomization.AllowColumnResizing = false;
                gvLead.OptionsCustomization.AllowFilter = false;
                gvLead.OptionsCustomization.AllowGroup = false;
                gvLead.OptionsCustomization.AllowSort = false;
                gvLead.OptionsFind.AllowFindPanel = false;
                gvLead.OptionsView.ShowGroupPanel = false;
                gvLead.OptionsView.ShowIndicator = false;
                gvLead.Columns["FullName"].VisibleIndex = 0;
                gvLead.Columns["FullName"].Width = 100;
                gvLead.Columns["Approved"].VisibleIndex = 1;
                gvLead.Columns["Approved"].Width = 25;
                gvLead.Columns["ApprovalDate"].VisibleIndex = 2;
                gvLead.Columns["ApprovalDate"].Width = 25;
                gvLead.Columns["LeadComments"].VisibleIndex = 3;
                gvLead.Columns["LeadComments"].Width = 100;
                gvLead.Columns["FullName"].OptionsColumn.AllowEdit = false;
                gvLead.Columns["Approved"].OptionsColumn.AllowEdit = false;
                gvLead.Columns["ApprovalDate"].OptionsColumn.AllowEdit = false;
                gvLead.Columns["EmoloyeeLeaveID"].OptionsColumn.AllowEdit = false;
                gvLead.Columns["LeaveApprovalID"].OptionsColumn.AllowEdit = false;
                gvLead.Columns["LeadID"].OptionsColumn.AllowEdit = false;
                gvLead.Columns["LeadComments"].OptionsColumn.AllowEdit = true;
                gvLead.PopupMenuShowing += gvCompOff_PopupMenuShowing;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message,ex);   
                Utility.ShowError(ex);
            }
        }
        private void gvCompOff_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                GridView gvLead = sender as GridView;
                if (gvLead.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(gvLead.GetFocusedRowCellValue("LeaveApprovalID")), out ivalue)
                        && Convert.ToInt16(gvLead.GetFocusedRowCellValue("LeadID")) == Utility.UserID
                        && ivalue > 0)
                    {
                        DXMenuItem dxApprove = new DevExpress.Utils.Menu.DXMenuItem("Approve", Approve_ItemClick);
                        dxApprove.Tag = new RowInfo(gvLead, gvLead.FocusedRowHandle);
                        e.Menu.Items.Add(dxApprove);
                        DXMenuItem dxReject = new DevExpress.Utils.Menu.DXMenuItem("Reject", Reject_ItemClick);
                        dxReject.Tag = new RowInfo(gvLead, gvLead.FocusedRowHandle);
                        e.Menu.Items.Add(dxReject);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        private void Approve_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem dx = sender as DXMenuItem;
                RowInfo ri = dx.Tag as RowInfo;
                int ivalue = 0;
                if (int.TryParse(Convert.ToString(ri.View.GetFocusedRowCellValue("LeaveApprovalID")), out ivalue) && ivalue > 0)
                {
                    objELeave.LeaveApprovalID = ivalue;
                    objELeave.Comments = Convert.ToString(ri.View.GetFocusedRowCellValue("LeadComments"));
                    objELeave.ApprovalStatus = 9;
                    objDLeave.ApproveLeave(objELeave);
                    objELeave.EmployeeLeaveID = gvLeaveHistory.GetFocusedRowCellValue("EmployeeLeaveID");
                    objDLeave.GetLeadDetails(objELeave);
                    if (objELeave.dtLeadDetails != null &&
                        objELeave.dtLeadDetails.Rows.Count > 0)
                    {
                        string stMailIds = string.Empty;
                        foreach (DataRow dr in objELeave.dtLeadDetails.Rows)
                        {
                            stMailIds += Convert.ToString(dr["EMail"]) + ",";
                        }
                        stMailIds += gvLeaveHistory.GetFocusedRowCellValue("EMail");
                        string stSubject = "Leave Approved - " + gvLeaveHistory.GetFocusedRowCellValue("EmployeeName");
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Leave Approved : " + Utility.stParagraphend;
                          stBody +=  Utility.stParagraphstart  + "Employee Name : " 
                            + gvLeaveHistory.GetFocusedRowCellValue("EmployeeName") + Utility.stParagraphend;

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
                        stBody += Utility.stParagraphstart + "Leave Type : " 
                            + gvLeaveHistory.GetFocusedRowCellValue("LeaveTypeName").ToString() + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Leave Approved By : " + Utility.UserFullName + Utility.stParagraphend;
                        Utility.SendEmail(stSubject, stBody, stMailIds);
                    }
                    gvLeaveHistory.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void Reject_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem dx = sender as DXMenuItem;
                RowInfo ri = dx.Tag as RowInfo;
                int ivalue = 0;
                if (int.TryParse(Convert.ToString(ri.View.GetFocusedRowCellValue("LeaveApprovalID")), out ivalue) && ivalue > 0)
                {
                    objELeave.LeaveApprovalID = ivalue;
                    objELeave.Comments = Convert.ToString(ri.View.GetFocusedRowCellValue("LeadComments"));
                    objELeave.ApprovalStatus = 10;
                    objDLeave.ApproveLeave(objELeave);
                    objELeave.EmployeeLeaveID = gvLeaveHistory.GetFocusedRowCellValue("EmployeeLeaveID");
                    objDLeave.GetLeadDetails(objELeave);
                    if (objELeave.dtLeadDetails != null &&
                        objELeave.dtLeadDetails.Rows.Count > 0)
                    {
                        string stMailIds = string.Empty;
                        foreach (DataRow dr in objELeave.dtLeadDetails.Rows)
                        {
                            stMailIds += Convert.ToString(dr["EMail"]) + ",";
                        }
                        stMailIds += gvLeaveHistory.GetFocusedRowCellValue("EMail");
                        string stSubject = "Leave Rejected - " + gvLeaveHistory.GetFocusedRowCellValue("EmployeeName");
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Leave Rejected : " + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Employee Name : " 
                            + gvLeaveHistory.GetFocusedRowCellValue("EmployeeName") + Utility.stParagraphend;
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
                        stBody += Utility.stParagraphstart + "Leave Rejected By : " + Utility.UserFullName + Utility.stParagraphend;
                        Utility.SendEmail(stSubject, stBody, stMailIds);
                    }
                    gvLeaveHistory.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
    }
}