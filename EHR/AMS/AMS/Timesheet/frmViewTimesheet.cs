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
using DevExpress.XtraSplashScreen;

namespace EHR
{
    public partial class frmViewTimesheet : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        public frmViewTimesheet()
        {
            InitializeComponent();
            try
            {
                dtpSelectedMonth.DateTime = DateTime.Now;
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                objDTimeSheet.GetEmployeeList(objETimeSheet);
                cmbEmployeeList.Properties.DataSource = objETimeSheet.dtEmployeeList;
                cmbEmployeeList.Properties.ValueMember = "UserInfoID";
                cmbEmployeeList.Properties.DisplayMember = "FullName";
                SplashScreenManager.CloseForm();

            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
            }
        }
        private void frmViewTimesheet_Load(object sender, EventArgs e)
        {
            
        }
        private void cmbEmployeeList_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployeeList.EditValue != null)
                {
                    SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                    objETimeSheet.SelectedMonth = dtpSelectedMonth.DateTime;
                    objETimeSheet.EmployeeID = cmbEmployeeList.EditValue;
                    BindTimeSheet();
                    objDTimeSheet.GetDayBreak(objETimeSheet);
                    gcBreaks.DataSource = objETimeSheet.dtDayBreaks;
                    objDTimeSheet.GetTotalHours1(objETimeSheet);
                    gcTotalHours.DataSource = objETimeSheet.dtTotalHours;
                    SplashScreenManager.CloseForm();
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void BindTimeSheet()
        {
            try
            {
                objDTimeSheet.GetTimeSheet(objETimeSheet);
                DataColumn keyColumn = objETimeSheet.dsTimeSheet.Tables[0].Columns["ID"];
                DataColumn foreignKeyColumn = objETimeSheet.dsTimeSheet.Tables[1].Columns["ID"];
                objETimeSheet.dsTimeSheet.Relations.Add("drTimeSheetID", keyColumn, foreignKeyColumn);
                gcTimesheet.DataSource = objETimeSheet.dsTimeSheet.Tables[0];
                gcTimesheet.ForceInitialize();
                gvTimesheet.Columns["TimesheetID"].VisibleIndex = -1;
                gvTimesheet.Columns["LogDate"].VisibleIndex = -1;
                gvTimesheet.Columns["ID"].VisibleIndex = -1;
                gvTimesheet.Columns["IsHoliday"].VisibleIndex = -1;
                gvTimesheet.Columns["IsWeekend"].VisibleIndex = -1;
                gvTimesheet.Columns["LogDateDesc"].Caption = "Log Date";
                gvTimesheet.Columns["DayLogin"].ColumnEdit = repositoryItemDateEdit2;
                gvTimesheet.Columns["DayLogout"].ColumnEdit = repositoryItemDateEdit2;
                gvTimesheet.Columns["LunchLogin"].ColumnEdit = repositoryItemDateEdit2;
                gvTimesheet.Columns["LunchLogout"].ColumnEdit = repositoryItemDateEdit2;

                GridView gvEmployeeTask = new GridView(gcTimesheet);
                gcTimesheet.LevelTree.Nodes.Add("drTimeSheetID", gvEmployeeTask);
                gvEmployeeTask.ViewCaption = "Tasks";
                gvEmployeeTask.PopulateColumns(objETimeSheet.dsTimeSheet.Tables[1]);
                gvEmployeeTask.Columns["TimesheetID"].VisibleIndex = -1;
                gvEmployeeTask.Columns["ID"].VisibleIndex = -1;
                gvEmployeeTask.Columns["TaskMins"].VisibleIndex = -1;
                gvEmployeeTask.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold);
                gvEmployeeTask.Appearance.HeaderPanel.Options.UseFont = true;
                gvEmployeeTask.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
                gvEmployeeTask.Appearance.Row.Options.UseFont = true;
                gvEmployeeTask.OptionsBehavior.Editable = false;
                gvEmployeeTask.OptionsCustomization.AllowColumnResizing = false;
                gvEmployeeTask.OptionsCustomization.AllowFilter = false;
                gvEmployeeTask.OptionsCustomization.AllowGroup = false;
                gvEmployeeTask.OptionsCustomization.AllowSort = false;
                gvEmployeeTask.OptionsFind.AllowFindPanel = false;
                gvEmployeeTask.OptionsView.ShowGroupPanel = false;
                gvEmployeeTask.OptionsView.ShowIndicator = false;
                gvEmployeeTask.Columns["TaskDescription"].VisibleIndex = 0;
                gvEmployeeTask.Columns["TaskDescription"].Width = 50;
                gvEmployeeTask.Columns["SubTaskDescription"].VisibleIndex = 1;
                gvEmployeeTask.Columns["SubTaskDescription"].Width = 75;
                gvEmployeeTask.Columns["WorkTypedescription"].VisibleIndex = 2;
                gvEmployeeTask.Columns["WorkTypedescription"].Width = 100;
                gvEmployeeTask.Columns["EmployeeTaskDescription"].VisibleIndex = 3;
                gvEmployeeTask.Columns["EmployeeTaskDescription"].Width = 200;
                gvEmployeeTask.Columns["TaskHours"].VisibleIndex = 4;
                gvEmployeeTask.Columns["TaskHours"].Width = 50;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                throw ex;
            }
        }
        private void gvTimesheet_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                if (gvTimesheet.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(gvTimesheet.GetFocusedRowCellValue("TimesheetID")), out ivalue) && ivalue > 0)
                    {
                        e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Edit", Edit_ItemClick));
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        private void Edit_ItemClick(object sender, EventArgs e)
        {
            try
            {
                if (gvTimesheet.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    object ID =0;
                    if (int.TryParse(Convert.ToString(gvTimesheet.GetFocusedRowCellValue("TimesheetID")), out ivalue) && ivalue > 0)
                    {
                        ID = gvTimesheet.GetFocusedRowCellValue("ID");
                        objETimeSheet.EmployeeName = cmbEmployeeList.Text;
                        objETimeSheet.TimesheetID = ivalue;
                        objETimeSheet.SelectedMonth = Convert.ToDateTime(gvTimesheet.GetFocusedRowCellValue("LogDate"));
                        frmTimeSheetEdit Obj = new frmTimeSheetEdit(objETimeSheet);
                        Obj.ShowDialog();
                        cmbEmployeeList_EditValueChanged(null, null);
                        Utility.Setfocus(gvTimesheet, "ID", ID);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void dtpSelectedMonth_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployeeList.EditValue != null)
                {
                    SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                    objETimeSheet.SelectedMonth = dtpSelectedMonth.DateTime;
                    objETimeSheet.EmployeeID = cmbEmployeeList.EditValue;
                    BindTimeSheet();
                    objDTimeSheet.GetTotalHours1(objETimeSheet);
                    gcTotalHours.DataSource = objETimeSheet.dtTotalHours;
                    SplashScreenManager.CloseForm();
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbEmployeeList_EditValueChanged(null, null);
        }
        private void gvTimesheet_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (gvTimesheet.FocusedRowHandle >= 0)
                {
                    SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                    object TimesheetID = gvTimesheet.GetFocusedRowCellValue("TimesheetID");
                    DataTable dt = objDTimeSheet.GetDayBreakByID(TimesheetID);
                    gcBreaks.DataSource = dt;
                    SplashScreenManager.CloseForm();
                }
            }
            catch (Exception ex) {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex); }
        }
    }
}