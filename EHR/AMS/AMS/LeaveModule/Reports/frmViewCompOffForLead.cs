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
    public partial class frmViewCompOffForLead : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        public frmViewCompOffForLead()
        {
            InitializeComponent();
        }
        private void frmViewCompOff_Load(object sender, EventArgs e)
        {
            try
            {
                objDLeave.GetCompOffforLead(objELeave);
                gcCompoff.DataSource = objELeave.dsCompOff.Tables[0];
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
                        if (LeaveStatusID == 3)
                        {
                            DXMenuItem dxEdit = new DevExpress.Utils.Menu.DXMenuItem("Enable for leave application", ChangeStatus_ItemClick);
                            dxEdit.Tag = ivalue;
                            e.Menu.Items.Add(dxEdit);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }
        private void ChangeStatus_ItemClick(object sender, EventArgs e)
        {
            try
            {
                frmComments Obj = new frmComments(objELeave);
                Obj.ShowDialog();
                if (objELeave.IsSave)
                {
                    DXMenuItem dx = sender as DXMenuItem;
                    objELeave.CompensatoryLeaveID = dx.Tag;
                    objDLeave.ChangeCompoffStatus(objELeave);
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
                        string stSubject = "Compensatory Off Enabled for Leave Application - " + Utility.UserFullName;
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Compensatory Off Enabled for Leave Application : " + Utility.stParagraphend;
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
                        stBody += Utility.stParagraphstart + "Reason For Changing the Status : "
                            + objELeave.ChangeStatusComments + Utility.stParagraphend;

                        stBody += Utility.stParagraphstart + "Please apply for the today end of the day otherwise comp off will get expired!"
                            + Utility.stParagraphend;
                        Utility.SendEmail(stSubject, stBody, stMailIds);
                    }
                    Utility.Setfocus(gvCompOff, "CompensatoryLeaveID", dx.Tag);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcCompoff.ShowRibbonPrintPreview();
        }
    }
}