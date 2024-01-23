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
using EL;
using DL;

namespace EHR
{
    public partial class frmLookupSettings : DevExpress.XtraEditors.XtraForm
    {
        EUser objEUser = new EUser();
        DUser objDUser = new DUser();
        public frmLookupSettings()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objEUser.ReminderDays = txtReminderDays.EditValue;
                objEUser.CompExpiryDays = txtCompOffExpiryDay.EditValue;
                objEUser.JobRunTime = txtJobRunTime.EditValue;
                objEUser.LeavBalanceMailday = txtLeaveBalanceDay.EditValue;
                objDUser.UpdateLookupValues(objEUser);
                XtraMessageBox.Show("Values saved!!");
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void frmLookupSettings_Load(object sender, EventArgs e)
        {
            try
            {
                objDUser.GetLookupValues(objEUser);
                txtReminderDays.EditValue = objEUser.ReminderDays;
                txtCompOffExpiryDay.EditValue = objEUser.CompExpiryDays;
                txtJobRunTime.EditValue = objEUser.JobRunTime;
                txtLeaveBalanceDay.EditValue = objEUser.LeavBalanceMailday;
            }
            catch (Exception ex){}
        }
    }
}