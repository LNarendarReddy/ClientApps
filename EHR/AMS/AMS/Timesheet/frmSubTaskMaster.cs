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
    public partial class frmSubTaskMaster : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmSubTaskMaster()
        {
            InitializeComponent();
        }

        private void frmSubTaskMaster_Load(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetSubTask(objETimeSheet);
                gcSubTask.DataSource = objETimeSheet.dtSubTask;
                objDTimeSheet.GetTask(objETimeSheet);
                cmbTask.DataSource = objETimeSheet.dtTask;
                cmbTask.ValueMember = "TaskID";
                cmbTask.DisplayMember = "TaskDescription";
                cmbTask1.Properties.DataSource = objETimeSheet.dtTask;
                cmbTask1.Properties.ValueMember = "TaskID";
                cmbTask1.Properties.DisplayMember = "TaskDescription";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objETimeSheet.SubTaskID = 0;
            txtSubTask.EditValue = null;
            cmbTask1.EditValue = null;
            txtSubTask.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.SubTaskDescription = txtSubTask.EditValue;
                objETimeSheet.TaskID = cmbTask1.EditValue;
                objDTimeSheet.SaveSubTask(objETimeSheet);
                gcSubTask.DataSource = objETimeSheet.dtSubTask;
                Utility.Setfocus(gvSubTask, "SubTaskID", objETimeSheet.SubTaskID);
                btnReset_Click(null, null);
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.SubTaskID = gvSubTask.GetFocusedRowCellValue("SubTaskID");
                txtSubTask.EditValue = gvSubTask.GetFocusedRowCellValue("SubTaskDescription");
                cmbTask1.EditValue = gvSubTask.GetFocusedRowCellValue("TaskID");
                txtSubTask.Focus();
            }
            catch (Exception ex){}
        }
    }
}