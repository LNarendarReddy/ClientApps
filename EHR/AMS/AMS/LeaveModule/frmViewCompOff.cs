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
    public partial class frmViewCompOff : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        public frmViewCompOff()
        {
            InitializeComponent();
        }
        private void frmViewCompOff_Load(object sender, EventArgs e)
        {
            try
            {
                objELeave.EmployeeID = Utility.UserID;
                objDLeave.GetCompOff(objELeave);
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
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void gvCompOff_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                if (gvCompOff.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    int LeaveStatusID = 0;
                    if (int.TryParse(Convert.ToString(gvCompOff.GetFocusedRowCellValue("CompensatoryLeaveID")), out ivalue)
                        && ivalue > 0 &&
                        int.TryParse(Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveStatus")), out LeaveStatusID))
                    {
                        if (LeaveStatusID == 1 || LeaveStatusID == 5)
                        {
                            DXMenuItem dxEdit = new DevExpress.Utils.Menu.DXMenuItem("Edit", Edit_ItemClick);
                            dxEdit.Tag = ivalue;
                            e.Menu.Items.Add(dxEdit);
                            DXMenuItem dxCancel = new DevExpress.Utils.Menu.DXMenuItem("Cancel", Cancel_ItemClick);
                            dxCancel.Tag = ivalue;
                            e.Menu.Items.Add(dxCancel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }
        private void Edit_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem dx = sender as DXMenuItem;
                frmWeekendWork Obj = new frmWeekendWork(dx.Tag);
                Obj.ShowDialog();
                frmViewCompOff_Load(null, null);
                Utility.Setfocus(gvCompOff, "CompensatoryLeaveID", dx.Tag);
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
                objELeave.CompensatoryLeaveID = dx.Tag;
                objDLeave.CancelCompOff(objELeave);
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
                    stMailIds += Utility.UserEmail;
                    string stSubject = "Compensatory Off Canceled - " + Utility.UserFullName;
                    string stBody = string.Empty;
                    stBody = Utility.stParagraphBoldstart + "Compensatory Off Canceled : " + Utility.stParagraphend;
                    stBody += Utility.stParagraphstart + "Employee Name : " + Utility.UserFullName + Utility.stParagraphend;

                    DateTime dtWorkedDate = DateTime.Now;
                    if (DateTime.TryParse(Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDate")), out dtWorkedDate))
                        stBody += Utility.stParagraphstart + "Worked Date : " 
                            + dtWorkedDate.ToString("dd/MM/yyyy") + Utility.stParagraphend;
                    else
                        stBody += Utility.stParagraphstart + "Worked Date : " 
                            + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDate")) + Utility.stParagraphend;

                    stBody += Utility.stParagraphstart + "Compensatory Off Category : " 
                        + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveDuration")) + Utility.stParagraphend;
                    stBody += Utility.stParagraphstart + "Reason For Working : " 
                        + Convert.ToString(gvCompOff.GetFocusedRowCellValue("LeaveReason")) + Utility.stParagraphend;
                    Utility.SendEmail(stSubject, stBody, stMailIds);
                }
                frmViewCompOff_Load(null, null);
                Utility.Setfocus(gvCompOff, "CompensatoryLeaveID", dx.Tag);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
    }
}