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
    public partial class frmTaskMaster : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmTaskMaster()
        {
            InitializeComponent();
        }

        private void frmTaskMaster_Load(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetTask(objETimeSheet);
                gcTask.DataSource = objETimeSheet.dtTask;
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
            objETimeSheet.TaskID = 0;
            txtTask.EditValue = null;
            txtTask.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.TaskDescription = txtTask.EditValue;
                objDTimeSheet.SaveTask(objETimeSheet);
                gcTask.DataSource = objETimeSheet.dtTask;
                Utility.Setfocus(gvTask, "TaskID", objETimeSheet.TaskID);
                btnReset_Click(null, null);
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.TaskID = gvTask.GetFocusedRowCellValue("TaskID");
                txtTask.EditValue = gvTask.GetFocusedRowCellValue("TaskDescription");
                txtTask.Focus();
            }
            catch (Exception ex) { }
        }
    }
}