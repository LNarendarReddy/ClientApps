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
using DevExpress.XtraSplashScreen;
using System.Diagnostics;

namespace EHR
{
    public partial class frmTimesheet : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DTimeSheet objDTimeSheet = new DTimeSheet();
        ETimeSheet objETimeSheet = new ETimeSheet();
        bool _OnLoad = false;
        public frmTimesheet()
        {
            InitializeComponent();
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Loading timesheet...");
                _OnLoad = true;
                objETimeSheet.EmployeeID = Utility.UserID;
                dtpSelectedMonth.DateTime = DateTime.Now;
                objETimeSheet.SelectedMonth = dtpSelectedMonth.DateTime;
                BindTimeSheet();
                objDTimeSheet.GetTotalHours1(objETimeSheet);
                gcTotalHours.DataSource = objETimeSheet.dtTotalHours;
                objDTimeSheet.GetLiveHours(objETimeSheet);
                txtTodayHours.EditValue = objETimeSheet.LiveHours;
                objDTimeSheet.GetLoginState(objETimeSheet);
                if (objETimeSheet.LoginState == "DLI")
                {
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Login Now";
                    btnLunch.Enabled = false;
                    btnLunch.Text = "Going For Lunch";
                    btnBreak.Enabled = false;
                    btnBreak.Text = "Going For Break";
                }
                else if (objETimeSheet.LoginState == "DLO")
                {
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break \n\r Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = true;
                        btnLunch.Text = "Going For Lunch";
                    }
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed \n\r for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = true;
                        btnBreak.Text = "Going For Break";
                    }
                }
                else if (objETimeSheet.LoginState == "LLO")
                {
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = true;
                    btnLunch.Text = "Back From Lunch";
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed \n\r for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "Going For Break";
                    }
                }
                else if (objETimeSheet.LoginState == "BLO")
                {
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break \n\r Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Going on Lunch";
                    }
                    btnBreak.Enabled = true;
                    btnBreak.Text = "Back From Break";
                }
                if (objETimeSheet.DayState == "Y")
                {
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Day Completed";
                    btnLunch.Enabled = false;
                    btnLunch.Text = "Lunch Break \n\r Completed";
                    btnBreak.Enabled = false;
                    btnBreak.Text = "All breaks availed \n\r for the day";
                }
                timer1.Start();
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                objETimeSheet.EmployeeID = Utility.UserID;
                if (btnDayLogin.Text == "Login Now")
                {
                    SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                    objDTimeSheet.InsertDayLogin(objETimeSheet);
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = true;
                    btnLunch.Text = "Going For Lunch";
                    btnBreak.Enabled = true;
                    btnBreak.Text = "Going For Break";
                    _OnLoad = true;
                    dtpSelectedMonth.DateTime = DateTime.Now;
                    BindTimeSheet();
                    SplashScreenManager.CloseForm();
                }
                else if (btnDayLogin.Text == "Logout Now")
                {
                    timer1.Stop();
                    frmTaskEntry Obj = new frmTaskEntry(objETimeSheet);
                    Obj.ShowDialog();
                    if (objETimeSheet._IsSave)
                    {
                        SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                        SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                        DataTable dtTemp = objETimeSheet.dtEmployeeTask.Clone();
                        foreach (DataColumn dc in dtTemp.Columns)
                        {
                            if (dc.ColumnName == "TaskDescription" || dc.ColumnName == "SubTaskDescription" ||
                                dc.ColumnName == "WorkTypedescription" || dc.ColumnName == "stHours")
                                objETimeSheet.dtEmployeeTask.Columns.Remove(dc.ColumnName);
                        }
                        objDTimeSheet.InsertDayLogout(objETimeSheet);
                        btnDayLogin.Enabled = false;
                        btnDayLogin.Text = "Day Completed";
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break \n\r Completed";
                        btnBreak.Enabled = false;
                        btnBreak.Text = "Break Completed";
                        _OnLoad = true;
                        dtpSelectedMonth.DateTime = DateTime.Now;
                        BindTimeSheet();
                        SplashScreenManager.CloseForm();
                    }
                    else
                        timer1.Start();
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                objETimeSheet.EmployeeID = Utility.UserID;
                if (btnLunch.Text == "Going For Lunch")
                {
                    objDTimeSheet.InsertLunchLogin(objETimeSheet);
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = true;
                    btnLunch.Text = "Back From Lunch";

                    objDTimeSheet.GetLoginState(objETimeSheet);
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed \n\r for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "Going For Break";
                    }
                }
                else if (btnLunch.Text == "Back From Lunch")
                {
                    objDTimeSheet.InsertLunchLogout(objETimeSheet);
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    btnLunch.Enabled = false;
                    btnLunch.Text = "Lunch Break \n\r Completed";
                    objDTimeSheet.GetLoginState(objETimeSheet);
                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed \n\r for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = true;
                        btnBreak.Text = "Going For Break";
                    }
                    objETimeSheet.LunchState = "Y";
                }
                _OnLoad = true;
                dtpSelectedMonth.DateTime = DateTime.Now;
                BindTimeSheet();
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                objETimeSheet.EmployeeID = Utility.UserID;
                if (btnBreak.Text == "Going For Break")
                {
                    objDTimeSheet.InsertBreakLogin(objETimeSheet);
                    btnDayLogin.Enabled = false;
                    btnDayLogin.Text = "Logout Now";
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break \n\r Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Going For Lunch";
                    }
                    btnBreak.Enabled = true;
                    btnBreak.Text = "Back From Break";
                }
                else if (btnBreak.Text == "Back From Break")
                {
                    objDTimeSheet.InsertBreakLogout(objETimeSheet);
                    btnDayLogin.Enabled = true;
                    btnDayLogin.Text = "Logout Now";
                    objDTimeSheet.GetLoginState(objETimeSheet);
                    if (objETimeSheet.LunchState == "Y")
                    {
                        btnLunch.Enabled = false;
                        btnLunch.Text = "Lunch Break \n\r Completed";
                    }
                    else
                    {
                        btnLunch.Enabled = true;
                        btnLunch.Text = "Going For Lunch";
                    }

                    if (objETimeSheet.BreakState == "Y")
                    {
                        btnBreak.Enabled = false;
                        btnBreak.Text = "All breaks availed \n\r for the day";
                    }
                    else
                    {
                        btnBreak.Enabled = true;
                        btnBreak.Text = "Going For Break";
                    }
                }
                _OnLoad = true;
                dtpSelectedMonth.DateTime = DateTime.Now;
                BindTimeSheet();
                BindDayBreaks(objETimeSheet.TimesheetID);
                Utility.Setfocus(gvBreaks, "DayBreakID", Convert.ToInt32(objETimeSheet.DayBreakID));
                SplashScreenManager.CloseForm();
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
                gvEmployeeTask.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                objDTimeSheet.GetLiveHours(objETimeSheet);
                txtTodayHours.EditValue = objETimeSheet.LiveHours;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }

        private void SelectedMonth_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_OnLoad)
                {
                    _OnLoad = false;
                    return;
                }
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Loading timesheet...");
                objETimeSheet.SelectedMonth = dtpSelectedMonth.DateTime;
                objDTimeSheet.GetTotalHours1(objETimeSheet);
                gcTotalHours.DataSource = objETimeSheet.dtTotalHours;
                BindTimeSheet();
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void gvTimesheet_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (gvTimesheet.FocusedRowHandle >= 0)
                {
                    object TimesheetID = gvTimesheet.GetFocusedRowCellValue("TimesheetID");
                    BindDayBreaks(TimesheetID);
                }
            }
            catch (Exception ex){Log.Error(ex.Message, ex);}
        }

        private void gvTimesheet_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                if (gvTimesheet.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    int Editable = 0;
                    if (int.TryParse(Convert.ToString(gvTimesheet.GetFocusedRowCellValue("TimesheetID")), out ivalue) && ivalue > 0
                        && int.TryParse(Convert.ToString(gvTimesheet.GetFocusedRowCellValue("Editable")), out Editable) && Editable == 1)
                    {
                        DXMenuItem dxAddEditTask = new DevExpress.Utils.Menu.DXMenuItem("Add/Edit Task", AddTask_ItemClick);
                        dxAddEditTask.Tag = ivalue;
                        e.Menu.Items.Add(dxAddEditTask);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }

        private void AddTask_ItemClick(object sender, EventArgs e)
        {
            try
            {
                DXMenuItem dx = sender as DXMenuItem;
                object ID = 0;
                ID = gvTimesheet.GetFocusedRowCellValue("ID");
                ETimeSheet objET = new ETimeSheet();
                objET.TimesheetID = dx.Tag;
                objET.EmployeeID = Utility.UserID;
                objET.IsEdit = true;
                frmTaskEntry Obj = new frmTaskEntry(objET);
                Obj.ShowDialog();
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                BindTimeSheet();
                Utility.Setfocus(gvTimesheet, "ID", ID);
                SplashScreenManager.CloseForm();

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void BindDayBreaks(object TimesheetID)
        {
            try
            {
                DataTable dtTemp = objETimeSheet.dtDayBreaks.Copy();
                DataView dv = dtTemp.DefaultView;
                dv.RowFilter = "TimesheetID = " + TimesheetID;
                gcBreaks.DataSource = dv.ToTable();
            }
            catch (Exception ex){}
        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {
            Process cp = Process.GetCurrentProcess();
            Log.Info("Timesheet Form / Current Proccess Main window handle : " + cp.MainWindowHandle);
        }
    }
}