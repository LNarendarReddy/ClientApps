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

namespace EHR.LeaveModule.Reports
{
    public partial class frmLeaveCalendar : DevExpress.XtraEditors.XtraForm
    {
        ELeave ObjELeave = new ELeave();
        DLeave ObjDLeave = new DLeave();
        public frmLeaveCalendar()
        {
            InitializeComponent();
            dtpSelectedMonth.DateTime = DateTime.Now;
        }

        private void dtpSelectedMonth_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ObjELeave.SelectedMonth = dtpSelectedMonth.EditValue;
                ObjELeave.RoleID = Utility.RoleID;
                ObjELeave.UserID = Utility.UserID;
                ObjDLeave.GetLeaveCalendar(ObjELeave);
                pivotGridControl1.DataSource = ObjELeave.dtLeaveCalendar;
            }
            catch (Exception ex){}
        }
    }
}