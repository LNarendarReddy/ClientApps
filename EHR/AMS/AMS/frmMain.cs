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
using Microsoft.Win32;
using EHR.LeaveModule;
using DevExpress.XtraSplashScreen;
using System.IO;
using System.Diagnostics;
using EHR.LeaveModule.Reports;
using EHR.Timesheet.Reports;
using EHR.Project;
using EHR.Assessment;
using System.Threading;
using DevExpress.XtraBars.ToastNotifications;
using log4net;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using EHR.User;

namespace EHR
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        Thread thread = null;
        public frmMain()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        private void ShowMdiChild(XtraForm Obj)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == Obj.Name)
                {
                    form.Activate();
                    return;
                }
            }
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.Manual;
            Obj.Location = new Point(0, 0);
            int frmWidth = Obj.Width;
            int frmHeight = this.ClientRectangle.Height - 200;
            Obj.Size = new Size(frmWidth, frmHeight);
            Obj.Show();
        }

        private void ShowForm(XtraForm Obj)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == Obj.Name)
                {
                    form.Close();
                    break;
                }
            }
            Obj.WindowState = FormWindowState.Maximized;
            Obj.MdiParent = this;
            Obj.Show();
        }

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                EUser ObjEUser = new EUser();
                frmUserList Obj = new frmUserList(ObjEUser);
                ShowForm(Obj);
            }
            catch (Exception ex) { }
        }

        private void btnAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAssessment Obj = new frmAssessment();
            ShowMdiChild(Obj);
        }

        private void btnMAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMAssessmentDashBoard Obj = new frmMAssessmentDashBoard();
            ShowMdiChild(Obj);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is MdiClient)
                    {
                        c.BackColor = Color.White;
                    }
                }
                timer1.Start();
                rgAssessment.Visible = Convert.ToBoolean(Utility.EnableAssessment);
                lblName.Caption = "Hello, " + Utility.UserFullName;
                lblViewDesignaion.Caption = Utility.Designation;
                lblVersion.Caption = "Version " + Utility.AppVersion;

                if (Utility.RoleID == 1 || Utility.RoleID == 7 || Utility.UserID == 11)
                {
                    rgAdmin.Visible = true;
                    rgAssessment.Visible = true;
                    rpgSA.Visible = true;
                    rpgDS.Visible = true;
                    rpgMS.Visible = true;
                    rpgApprove.Visible = true;
                    rpgLeaveReports.Visible = true;
                    rpgTimesheetReports.Visible = true;
                }
                else if (Utility.RoleID == 3)
                {
                    rpgSA.Visible = true;
                    rpgMS.Visible = true;
                    rpgTimesheetReports.Visible = true;
                    btnViewTimesheet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    btnEmployeeHours.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    rpgApprove.Visible = true;
                }
                else if (Utility.RoleID == 4)
                {
                    rpgSA.Visible = true;
                    rpgMS.Visible = true;
                }
                else if (Utility.RoleID == 6)
                {
                    rgAdmin.Visible = true;
                    rpgSA.Visible = true;
                    rpgMS.Visible = true;
                    rpgApprove.Visible = true;
                    rpgLeaveReports.Visible = true;
                    rpgTimesheetReports.Visible = true;
                }
                btnTimesheet_ItemClick(null, null);
                thread = new Thread(new ThreadStart(GetNotifications));
                thread.Start();

                Process cp = Process.GetCurrentProcess();
                Log.Info("Main Form / Current Proccess Main window handle : " + cp.MainWindowHandle);
                //WaitForConnection();
            }
            catch (Exception ex){}

        }

        private void btnDAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDAssessment Obj = new frmDAssessment();
            ShowForm(Obj);
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword Obj = new frmChangePassword();
            Obj.ShowDialog();
        }

        private void btnViewAssessment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmAssessment f = (frmAssessment)this.ActiveMdiChild;
                f.ViewReport();
            }
            catch (Exception ex) { }
        }

        private void btnViewDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDAssessment f = (frmDAssessment)this.ActiveMdiChild;
                f.ViewReport();
            }
            catch (Exception ex) { }
        }

        private void btnEmployeeTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployeeTask Obj = new frmEmployeeTask();
            ShowForm(Obj);
        }

        private void btnTimesheet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimesheet Obj = new frmTimesheet();
            ShowForm(Obj);
        }

        private void btnHolidayMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHolidayMaster Obj = new frmHolidayMaster();
            ShowMdiChild(Obj);
        }

        private void btnViewTimesheet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewTimesheet Obj = new frmViewTimesheet();
            ShowForm(Obj);
        }

        private void btnDashBoard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDashBoard Obj = new frmDashBoard();
            ShowForm(Obj);
        }

        private void btnTaskMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaskMaster Obj = new frmTaskMaster();
            Obj.ShowDialog();
        }

        private void btnSubTaskMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSubTaskMaster Obj = new frmSubTaskMaster();
            Obj.ShowDialog();
        }

        private void btnWorkType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmWorkType Obj = new frmWorkType();
            Obj.ShowDialog();
        }

        private void btnProjectMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectMaster Obj = new frmProjectMaster();
            ShowForm(Obj);
        }

        private void btnProjectWorkType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectWorkType Obj = new frmProjectWorkType();
            Obj.ShowDialog();
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                pictureEdit1.Visible = false;
            else
                pictureEdit1.Visible = true;
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\AMS", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\AMS");
                RGkey.SetValue("PasswordString", string.Empty);
                RGkey.Close();
                thread.Abort();
                CallFromEvent = true;
                Application.Exit();
            }
            catch (Exception ex) { }
        }

        private void btnLeaveManagement_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeaveManagement Obj = new frmLeaveManagement(-1);
            Obj.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnFYearMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFinancialYear Obj = new EHR.frmFinancialYear();
            Obj.ShowDialog();
        }

        private void btnWeekendWork_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmWeekendWork Obj = new frmWeekendWork(-1);
            Obj.ShowDialog();
        }

        private void btnViewCompansatoryLeaves_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewCompOff Obj = new frmViewCompOff();
            ShowForm(Obj);
        }

        private void btnApporveCompOff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmApproveCompOff Obj = new frmApproveCompOff();
            ShowForm(Obj);
        }

        private void btnLeaveHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeaveHistory Obj = new frmLeaveHistory();
            ShowForm(Obj);
        }
        
        private void btnApproveLeaves_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmApproveLeave Obj = new frmApproveLeave();
            ShowForm(Obj);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                EUser objEUser = new EUser();
                DUser objDUser = new DUser();
                objDUser.GetDBVersion(objEUser);
                if (objEUser.DBVersion != Utility.AppVersion)
                {
                    timer1.Stop();
                    Utility.ShowError(new Exception("New update available! Please wait till application updated."));
                    SplashScreenManager.ShowForm(null, typeof(frmUpdateInstaller), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("              Downloading installer");
                    string stInstallerPath = @"\\192.168.101.50\common folder\02_Projects\3000_Timesheet\AMS.exe";
                    string stTargetPath = Application.UserAppDataPath;
                    string stFileName = "AMSInstaller.exe";
                    try
                    {
                        File.Copy(stInstallerPath, Path.Combine(stTargetPath, stFileName), true);
                        SplashScreenManager.CloseForm();
                        Process p = new Process();
                        p.StartInfo.FileName = Path.Combine(stTargetPath, stFileName);
                        p.StartInfo.Arguments = "/i \"C:\\Application.msi\"/qn";
                        p.Start();
                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        SplashScreenManager.CloseForm();
                        Utility.ShowError(new Exception("Please check the VPN connection"));
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnViewCompOff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewCompOffForLead Obj = new frmViewCompOffForLead();
            ShowForm(Obj);
        }

        private void btnViewLeaveHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeaveHistoryForLead Obj = new frmLeaveHistoryForLead();
            ShowForm(Obj);
        }

        private void btnProjectTask_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectTask Obj = new frmProjectTask();
            ShowForm(Obj);
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLeaveBalance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeaveBalance Obj = new frmLeaveBalance();
            ShowForm(Obj);
        }

        private void btnEmployeeTimings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployeeTimings Obj = new frmEmployeeTimings();
            ShowForm(Obj);
        }

        private void btnEmployeeHours_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployeeHours Obj = new frmEmployeeHours();
            ShowForm(Obj);
        }

        private void btnLeaveCalendar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLeaveCalendar Obj = new frmLeaveCalendar();
            ShowForm(Obj);
        }

        private void btnProjectPhase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProjectPhase obj = new frmProjectPhase();
            obj.ShowIcon = false;
            obj.ShowInTaskbar = false;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.ShowDialog();
        }

        private void btnYearlyRpeort_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmYearlyReport Obj = new frmYearlyReport();
            ShowForm(Obj);
        }
        private void btnLookupSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLookupSettings Obj = new frmLookupSettings();
            Obj.IconOptions.ShowIcon = false;
            Obj.ShowInTaskbar = false;
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.ShowDialog();
        }

        private void GetNotifications()
        {
            try
            {
                bool IsContinue = true;
                while (IsContinue)
                {
                    Thread.Sleep(30000);
                    DTimeSheet objDTimeSheet = new DTimeSheet();
                    ETimeSheet objETimeSheet = new ETimeSheet();
                    objETimeSheet.EmployeeID = Utility.UserID;
                    objDTimeSheet.GetNotifications(objETimeSheet);
                    if (objETimeSheet.dtNotifications != null &&
                        objETimeSheet.dtNotifications.Rows.Count > 0)
                    {
                        SendNotification(objETimeSheet.dtNotifications);
                    }
                }
            }
            catch (Exception) { }
        }
        private void SendNotification(DataTable dt)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        ToastNotificationsManager tnm = new ToastNotificationsManager();
                        tnm.ApplicationId = "Categis EHR";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            ToastNotification tn = new ToastNotification();
                            tn.Header = Convert.ToString(dt.Rows[i]["UserName"]) + "/" +
                            Convert.ToString(dt.Rows[i]["FullName"]);
                            tn.Image = null;
                            tn.ID = i;
                            int ActionType = 0;
                            if (int.TryParse(Convert.ToString(dt.Rows[i]["ActionType"]), out ActionType))
                            {
                                if (ActionType == 1)
                                    tn.Body = "Logged in";
                                else if (ActionType == 2)
                                    tn.Body = "Logged out";
                                else if (ActionType == 3)
                                    tn.Body = "Going for lunch";
                                else if (ActionType == 4)
                                    tn.Body = "Back from lunch";
                                else if (ActionType == 5)
                                    tn.Body = "Going for break";
                                else if (ActionType == 6)
                                    tn.Body = "Back from break";
                            }
                            tn.Template = DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text02;
                            tn.Sound = ToastNotificationSound.NoSound;
                            tnm.Notifications.Add(tn);
                            tnm.ShowNotification(i);
                        }
                    }));
                    return;
                }
            }
            catch (Exception ex) { }
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            try
            {
                if (FormWindowState.Minimized == WindowState)
                {
                    this.Hide();
                    WaitForConnection();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!CallFromEvent)
                {
                    e.Cancel = true;
                    this.Hide();
                    WaitForConnection();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var pipe = new NamedPipeClientStream(
                       ".",
                       "ShowHide.Pipe",
                       PipeDirection.InOut,
                       PipeOptions.Asynchronous))
            {
                try
                {
                    pipe.Connect(1000);
                }
                catch (Exception ex)
                {
                    try
                    {
                        Process[] processes = Process.GetProcessesByName("EHR");
                        IntPtr s = processes[0].MainWindowHandle;
                        SetForegroundWindow(s);
                    }
                    catch (Exception){}
                }
            }
        }
        bool CallFromEvent = false;
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                var clickedMenuItem = e.ClickedItem;
                var menuText = clickedMenuItem.Text;
                if (menuText == "Open")
                {
                    using (var pipe = new NamedPipeClientStream(
                       ".",
                       "ShowHide.Pipe",
                       PipeDirection.InOut,
                       PipeOptions.Asynchronous))
                    {
                        try
                        {
                            pipe.Connect(1000);
                        }
                        catch (Exception ex){}
                    }
                }
                else if (menuText == "Exit")
                {
                    thread.Abort();
                    CallFromEvent = true;
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void WaitForConnection()
        {
            try
            {
                NamedPipeServerStream pipeServer = new NamedPipeServerStream("ShowHide.Pipe", PipeDirection.InOut,1,
                    PipeTransmissionMode.Byte, PipeOptions.Asynchronous);
                pipeServer.BeginWaitForConnection(new AsyncCallback(ShowHiddenForm), pipeServer);
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }
        private void ShowHiddenForm(IAsyncResult iar)
        {
            try
            {
                NamedPipeServerStream pipeServer = (NamedPipeServerStream)iar.AsyncState;
                pipeServer.EndWaitForConnection(iar);
                this.BeginInvoke((Action)(() => {
                    this.Show();
                    this.WindowState = FormWindowState.Maximized;
                    this.BringToFront();
                }));
                pipeServer.Disconnect();
                pipeServer.Dispose();
            }
            catch (Exception ex)
            {

            }
        }
        private void OnApplicationExit(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();
            }
            catch { }
        }

        private void btnCopyTestCases_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCopyTestCases obj = new frmCopyTestCases();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.ShowInTaskbar = false;
            obj.IconOptions.ShowIcon = false;
            obj.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Utility.SendMailFromES();
        }
    }
}