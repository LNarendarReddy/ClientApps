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
    public partial class frmWeekendWork : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DLeave objDLeave = new DLeave();
        ELeave objELeave = new ELeave();
        bool _IsEdit = false;
        public frmWeekendWork(object CompensatoryLeaveID)
        {
            InitializeComponent();
            objELeave.CompensatoryLeaveID = CompensatoryLeaveID;
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
                objELeave.LeaveDate = dtpWorkedDate.EditValue;
                objELeave.LeaveReason = txtWorkingReason.EditValue;
                objELeave.EmployeeID = Utility.UserID;
                objELeave.ApporvalLead = cmbLead.EditValue;
                objELeave.LeaveDuration = cmbLeaveDuration.EditValue;
                objDLeave.SaveCompOff(objELeave);

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
                string stSubject = "Compensatory Off Application - " + Utility.UserFullName;
                string stBody = string.Empty;
                if (_IsEdit)
                    stBody = Utility.stParagraphBoldstart + "Compensatory Off Details Updated :" + Utility.stParagraphend;
                else
                    stBody = Utility.stParagraphBoldstart + "Compensatory Off Details :" + Utility.stParagraphend;
                stBody += Utility.stParagraphstart + "Employee Name: " + Utility.UserFullName + Utility.stParagraphend;
                stBody += Utility.stParagraphstart + "Worked Date : " + dtpWorkedDate.DateTime.ToString("dd/MM/yyyy") + Utility.stParagraphend;
                if (Convert.ToInt16(cmbLeaveDuration.EditValue) != 6)
                {
                    stBody += Utility.stParagraphstart + "No.Of Days : 0.5" + Utility.stParagraphend;
                }
                else
                {
                    stBody += Utility.stParagraphstart + "No.Of Days : 1" + Utility.stParagraphend;
                }
                stBody += Utility.stParagraphstart + "Compensatory Off Category : " + cmbLeaveDuration.Text + Utility.stParagraphend;
                stBody += Utility.stParagraphstart + "Reason For Working : " + txtWorkingReason.Text + Utility.stParagraphend;
                Utility.SendEmail(stSubject, stBody, stMailIDs);
                Utility.ShowError(new Exception("Compansatory leave saved successfully and sent for approval. \n\r Check status in view window!"),true);
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        
        private void frmWeekendWork_Load(object sender, EventArgs e)
        {
            try
            {
                objELeave.EmployeeID = Utility.UserID;
                objDLeave.GetEmployeeList(objELeave);
                cmbLead.Properties.DataSource = objELeave.dtEmployeeList;
                cmbLead.Properties.DisplayMember = "FullName";
                cmbLead.Properties.ValueMember = "UserInfoID";
                objDLeave.GetLeaveDuration(objELeave);
                cmbLeaveDuration.Properties.DataSource = objELeave.dtLeaveDuration;
                cmbLeaveDuration.Properties.ValueMember = "LookupID";
                cmbLeaveDuration.Properties.DisplayMember = "LookupValue";

                if (Convert.ToInt32(objELeave.CompensatoryLeaveID) > 0)
                {
                    _IsEdit = true;
                    objDLeave.GetCompOffDetailsByID(objELeave);
                    dtpWorkedDate.EditValue = objELeave.dtCompOff.Rows[0]["LeaveDate"];
                    txtWorkingReason.EditValue = objELeave.dtCompOff.Rows[0]["LeaveReason"];
                    cmbLeaveDuration.EditValue = objELeave.dtCompOff.Rows[0]["LeaveDurationID"];
                    cmbLead.SetEditValue(objELeave.dtCompOff.Rows[0]["Leads"]);
                }
                else
                    cmbLeaveDuration.EditValue = 6;
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
        }
    }
}