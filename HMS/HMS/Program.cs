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

namespace HMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly asm = typeof(DevExpress.UserSkins.BetaSkin).Assembly;
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("POSSkin");

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
                SplashScreenManager.Default.SetWaitFormDescription("                  Connection Failed...");
                Thread.Sleep(5000);
                SplashScreenManager.CloseForm();
                Application.Exit();
            }
        }
        public class SkinRegistration : Component
        {
            public SkinRegistration()
            {
                DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.BetaSkin).Assembly);
            }
        }
    }
}
