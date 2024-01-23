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
    public partial class frmProjectWorkType : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmProjectWorkType()
        {
            InitializeComponent();
        }

        private void frmTaskMaster_Load(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetProjectWorkType(objETimeSheet);
                gcTask.DataSource = objETimeSheet.dtWorkType;
            }
            catch (Exception ex){Log.Error(ex.Message, ex);}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.WorkTypeDescription = txtWorktype.EditValue;
                objDTimeSheet.SaveProjectWorkType(objETimeSheet);
                gcTask.DataSource = objETimeSheet.dtWorkType;
                Utility.Setfocus(gvTask, "ProjectWorkTypeID", objETimeSheet.WorkTypeID);
                btnReset_Click(null, null);
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objETimeSheet.WorkTypeID = 0;
            txtWorktype.EditValue = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.WorkTypeID = gvTask.GetFocusedRowCellValue("ProjectWorkTypeID");
                txtWorktype.EditValue = gvTask.GetFocusedRowCellValue("WorkTypeDescription");
                txtWorktype.Focus();
            }
            catch (Exception ex) { }
        }
    }
}