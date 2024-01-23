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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraGrid;
using log4net;

namespace EHR
{
    public partial class frmProjectTask : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmProjectTask()
        {
            InitializeComponent();
        }
        private void frmEmployeeTask_Load(object sender, EventArgs e)
        {
            tglActiveProjects.IsOn = true;
        }
        private void cmbEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        int TotalHours = 0;
        int GroupedHours = 0;
        private void gvTaskManagement_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);

                // Initialization. 
                if (e.SummaryProcess == CustomSummaryProcess.Start)
                {
                    TotalHours = 0;
                    GroupedHours = 0;
                }
                // Calculation.
                if (e.SummaryProcess == CustomSummaryProcess.Calculate)
                {
                    switch (summaryID)
                    {
                        case 1:
                            int TMinutes = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "TaskMins"));
                            TotalHours += TMinutes;
                            break;
                        case 2:
                            int TMinutes1 = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "TaskMins"));
                            GroupedHours += TMinutes1;
                            break;
                    }
                }
                // Finalization. 
                if (e.SummaryProcess == CustomSummaryProcess.Finalize)
                {
                    switch (summaryID)
                    {
                        case 1:
                            string stHours = Convert.ToString(TotalHours / 60).PadLeft(2, '0');
                            string stMins = Convert.ToString(TotalHours % 60).PadLeft(2, '0');
                            e.TotalValue = stHours + ":" + stMins;
                            break;
                        case 2:
                            string stHours1 = Convert.ToString(GroupedHours / 60).PadLeft(2, '0');
                            string stMins1 = Convert.ToString(GroupedHours % 60).PadLeft(2, '0');
                            e.TotalValue = stHours1 + ":" + stMins1;
                            break;
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            gcTaskManagement.ShowRibbonPrintPreview();
        }

        private void tglActiveProjects_Toggled(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.IsActive = tglActiveProjects.IsOn;
                objETimeSheet.UserID = Utility.UserID;
                objETimeSheet.RoleID = Utility.RoleID;
                objDTimeSheet.GetProjectListForReport(objETimeSheet);
                cmbProjectName.Properties.DataSource = objETimeSheet.dtProjectList;
                cmbProjectName.Properties.DisplayMember = "ProjectName";
                cmbProjectName.Properties.ValueMember = "ProjectID";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void gcTaskManagement_Click(object sender, EventArgs e)
        {

        }

        private void cmbProjectName_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
          

        }

        private void cmbProjectName_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                ETimeSheet objETimeSheet = new ETimeSheet();
                DTimeSheet objDTimeSheet = new DTimeSheet();
                objETimeSheet.ProjectID = cmbProjectName.EditValue;
                objDTimeSheet.GetProjectTask(objETimeSheet);
                gcTaskManagement.DataSource = objETimeSheet.dtEmployeeTask;
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
    }
}
