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
    public partial class frmApproveCompOff : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        public frmApproveCompOff()
        {
            InitializeComponent();
        }
        private void frmViewCompOff_Load(object sender, EventArgs e)
        {
            try
            {
                objELeave.EmployeeID = Utility.UserID;
                objDLeave.GetCompOffForApproval(objELeave);
                DataColumn keyColumn = objELeave.dsCompOff.Tables[0].Columns["CompensatoryLeaveID"];
                DataColumn foreignKeyColumn = objELeave.dsCompOff.Tables[1].Columns["CompensatoryLeaveID"];
                objELeave.dsCompOff.Relations.Add("drApproval", keyColumn, foreignKeyColumn);
                gcCompoff.DataSource = objELeave.dsCompOff.Tables[0];
                gcCompoff.ForceInitialize();
                
                GridView gvLead = new GridView(gcCompoff);
                gcCompoff.LevelTree.Nodes.Add("drApproval", gvLead);
                gvLead.ViewCaption = "Approval Persons";
                gvLead.PopulateColumns(objELeave.dsCompOff.Tables[1]);
                gvLead.Columns["CompensatoryLeaveID"].VisibleIndex = -1;
                gvLead.Columns["CompensatoryLeaveApprovalID"].VisibleIndex = -1;
                gvLead.Columns["LeadID"].VisibleIndex = -1;
                gvLead.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
                gvLead.Appearance.HeaderPanel.Options.UseFont = true;
                gvLead.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
                gvLead.Appearance.Row.Options.UseFont = true;
                gvLead.OptionsBehavior.Editable = false;
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
                gvLead.Columns["Approved"].Width = 50;
                gvLead.Columns["ApporvedDate"].VisibleIndex = 2;
                gvLead.Columns["ApporvedDate"].Width = 50;
                gvLead.PopupMenuShowing += gvCompOff_PopupMenuShowing;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void gvCompOff_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                GridView gvlead = sender as GridView;
                if (gvlead.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(gvlead.GetFocusedRowCellValue("CompensatoryLeaveApprovalID")), out ivalue) 
                        && Convert.ToInt16(gvlead.GetFocusedRowCellValue("LeadID")) == Utility.UserID
                        && ivalue > 0)
                    {
                        DXMenuItem dxApprove = new DevExpress.Utils.Menu.DXMenuItem("Approve", Approve_ItemClick);
                        dxApprove.Tag = new RowInfo(gvlead, gvlead.FocusedRowHandle);
                        e.Menu.Items.Add(dxApprove);
                        DXMenuItem dxReject = new DevExpress.Utils.Menu.DXMenuItem("Reject", Reject_ItemClick);
                        dxReject.Tag = new RowInfo(gvlead, gvlead.FocusedRowHandle);
                        e.Menu.Items.Add(dxReject);
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void Approve_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem dx = sender as DXMenuItem;
                RowInfo ri = dx.Tag as RowInfo;
                int ivalue = 0;
                if (int.TryParse(Convert.ToString(ri.View.GetFocusedRowCellValue("CompensatoryLeaveApprovalID")), out ivalue) && ivalue > 0)
                {
                    objELeave.CompensatoryLeaveApprovalID = ivalue;
                    objELeave.ApprovalStatus = 9;
                    objDLeave.ApproveCompOff(objELeave);
                    objELeave.CompensatoryLeaveID = gvCompOff.GetFocusedRowCellValue("CompensatoryLeaveID");
                    objDLeave.GetLeadDetailsCompOff(objELeave);
                    if (objELeave.dtLeadDetails != null &&
                        objELeave.dtLeadDetails.Rows.Count > 0)
                    {
                        string stMailIds = string.Empty;
                        foreach (DataRow dr in objELeave.dtLeadDetails.Rows)
                        {
                            stMailIds += Convert.ToString(dr["EMail"]) + ",";
                        }
                        stMailIds += gvCompOff.GetFocusedRowCellValue("EMail");
                        string stSubject = "Compensatory Off Approved - " + gvCompOff.GetFocusedRowCellValue("FullName");
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Compensatory Off Approved :" + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Employee Name : " + 
                            gvCompOff.GetFocusedRowCellValue("FullName") + Utility.stParagraphend;
                        DateTime dtWorkedDate = DateTime.Now;
                        if(DateTime.TryParse(Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDate")),out dtWorkedDate))
                            stBody += Utility.stParagraphstart + "Worked Date : " + dtWorkedDate.ToString("dd/MM/yyyy") + Utility.stParagraphend;
                        else
                            stBody += Utility.stParagraphstart + "Worked Date : " + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDate")) 
                                + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + 
                            "Compensatory Off Category : " + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDuration")) 
                            + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Reason For Working : " 
                            + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveReason")) + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Approved by : " + Utility.UserFullName + Utility.stParagraphend;
                        Utility.SendEmail(stSubject, stBody, stMailIds);
                    }
                    gvCompOff.DeleteSelectedRows();
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
                if (int.TryParse(Convert.ToString(ri.View.GetFocusedRowCellValue("CompensatoryLeaveApprovalID")), out ivalue) && ivalue > 0)
                {
                    objELeave.CompensatoryLeaveApprovalID = ivalue;
                    objELeave.ApprovalStatus = 10;
                    objDLeave.ApproveCompOff(objELeave);
                    objELeave.CompensatoryLeaveID = gvCompOff.GetFocusedRowCellValue("CompensatoryLeaveID");
                    objDLeave.GetLeadDetailsCompOff(objELeave);
                    if (objELeave.dtLeadDetails != null &&
                        objELeave.dtLeadDetails.Rows.Count > 0)
                    {
                        string stMailIds = string.Empty;
                        foreach (DataRow dr in objELeave.dtLeadDetails.Rows)
                        {
                            stMailIds += Convert.ToString(dr["EMail"]) + ",";
                        }
                        stMailIds += gvCompOff.GetFocusedRowCellValue("EMail");
                        string stSubject = "Compensatory Off Rejected - " + gvCompOff.GetFocusedRowCellValue("FullName");
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Compensatory Off Rejected :" + Utility.stParagraphend;
                         stBody +=  Utility.stParagraphstart + "Employee Name : " + gvCompOff.GetFocusedRowCellValue("FullName") + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Worked Date : " 
                            + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDate")) + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Compensatory Off Category : " 
                            + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDuration")) + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Reason For Working : " 
                            + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveReason")) + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Rejected by : " + Utility.UserFullName + Utility.stParagraphend;
                        Utility.SendEmail(stSubject, stBody, stMailIds);
                    }
                    gvCompOff.DeleteSelectedRows();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void gcCompoff_Click(object sender, EventArgs e)
        {

        }
    }
}