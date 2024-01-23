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
using log4net;

namespace EHR
{
    public partial class frmWorkType : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmWorkType()
        {
            InitializeComponent();
        }

        private void frmSubTaskMaster_Load(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetWorkType(objETimeSheet);
                gcWorkType.DataSource = objETimeSheet.dtWorkType;
                objDTimeSheet.GetSubTask(objETimeSheet);
                cmbSubTask.DataSource = objETimeSheet.dtSubTask;
                cmbSubTask.ValueMember = "SubTaskID";
                cmbSubTask.DisplayMember = "SubTaskDescription";
                cmbSubTask1.Properties.DataSource = objETimeSheet.dtSubTask;
                cmbSubTask1.Properties.ValueMember = "SubTaskID";
                cmbSubTask1.Properties.DisplayMember = "SubTaskDescription";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.WorkTypeID = gvWorkType.GetFocusedRowCellValue("WorkTypeID");
                txtWorktype.EditValue = gvWorkType.GetFocusedRowCellValue("WorkTypedescription");
                cmbSubTask1.EditValue = gvWorkType.GetFocusedRowCellValue("SubTaskID");
                txtWorktype.Focus();
            }
            catch (Exception ex){}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objETimeSheet.WorkTypeID = 0;
            txtWorktype.EditValue = null;
            cmbSubTask1.EditValue = null;
            txtWorktype.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.WorkTypeDescription = txtWorktype.EditValue;
                objETimeSheet.SubTaskID = cmbSubTask1.EditValue;
                objDTimeSheet.SaveWorkType(objETimeSheet);
                gcWorkType.DataSource = objETimeSheet.dtWorkType;
                Utility.Setfocus(gvWorkType, "WorkTypeID", objETimeSheet.WorkTypeID);
                btnReset_Click(null, null);
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }
    }
}