using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using Microsoft.Win32;
using DevExpress.XtraSplashScreen;
using System.Threading;
using EL;
using DL;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Reflection;
using System.ComponentModel;
using log4net;
using System.Configuration;
using System.Runtime.InteropServices;
using DevExpress.XtraEditors;
using System.IO.Pipes;

namespace EHR
{
    static class Program
    {
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   

            Process[] processes = Process.GetProcessesByName("EHR");
            if (processes.Count() <= 1)
            {
                log4net.Config.XmlConfigurator.Configure();
                Assembly asm = typeof(DevExpress.UserSkins.CategisSkin).Assembly;
                DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
                SplashScreenManager.RegisterUserSkins(typeof(DevExpress.UserSkins.CategisSkin).Assembly);
                BonusSkins.Register();
                UserLookAndFeel.Default.SetSkinStyle("CategisSkin");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                SkinManager.EnableFormSkins();
                SkinManager.EnableMdiFormSkins();

                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Connecting to database...");
                bool rtn = Utility.CheckDbConnection();
                if (rtn)
                {
                    SplashScreenManager.Default.SetWaitFormDescription("              Connection succeded...");
                    Thread.Sleep(1000);
                    SplashScreenManager.CloseForm();
                    EUser objEUser = new EUser();
                    DUser objDUser = new DUser();
                    objDUser.GetDBVersion(objEUser);
                    if (objEUser.DBVersion != Utility.AppVersion)
                    {
                        Utility.ShowError(new Exception("New update available! Please wait till the application is updated."));
                        SplashScreenManager.ShowForm(null, typeof(frmUpdateInstaller), true, true, false);
                        SplashScreenManager.Default.SetWaitFormDescription("              Downloading installer");
                        string stInstallerPath = @"\\192.168.101.50\common folder\02_Projects\3000_Timesheet\EHR.exe";
                        string stTargetPath = Application.UserAppDataPath;
                        string stFileName = "EHRInstaller.exe";
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
                            Log.Error(ex.Message, ex);
                            SplashScreenManager.CloseForm();
                            Utility.ShowError(new Exception("Please check the VPN connection"));
                            Application.Exit();
                        }
                    }
                    else
                    {
                        Application.Run(new frmLogin());
                    }
                }
                else
                {
                    SplashScreenManager.Default.SetWaitFormDescription("                  Connection failed...");
                    Thread.Sleep(5000);
                    SplashScreenManager.CloseForm();
                    Application.Exit();
                }
            }
            else
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
                    catch (Exception ex){
                        try
                        {
                            Process[] p = Process.GetProcessesByName("EHR");
                            IntPtr s = p[0].MainWindowHandle;
                            SetForegroundWindow(s);
                        }
                        catch (Exception) { }
                    }
                }
            }
        }
    }
    public class SkinRegistration : Component
    {
        public SkinRegistration()
        {
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.CategisSkin).Assembly);
        }
    }
}
