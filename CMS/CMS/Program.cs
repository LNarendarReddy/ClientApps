using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;
using System.ComponentModel;
using DevExpress.XtraSplashScreen;
using System.Threading;
using EL;
using DL;
using CMS.Properties;
using Microsoft.Win32;

namespace CMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();

            RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\CMS", true);
            if (RGkey != null)
            {
                string stSkinName = Convert.ToString(RGkey.GetValue("SkinName"));
                if (string.IsNullOrEmpty(stSkinName))
                    UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
                else
                    UserLookAndFeel.Default.SetSkinStyle(stSkinName);
            }
            SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
            SplashScreenManager.Default.SetWaitFormDescription("                  Connecting to database...");
            bool rtn = Utility.CheckDbConnection();
            if (rtn)
            {
                SplashScreenManager.Default.SetWaitFormDescription("              Connection succeded...");
                Thread.Sleep(1000);
                SplashScreenManager.CloseForm();
                Application.Run(new frmLogin());
            }
            else
            {
                SplashScreenManager.Default.SetWaitFormDescription("                  Connection failed...");
                Thread.Sleep(5000);
                SplashScreenManager.CloseForm();
                Application.Exit();
            }
        }
    }
}
