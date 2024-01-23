using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;
using System.ComponentModel;

namespace NFRTest
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
            UserLookAndFeel.Default.SetSkinStyle("BetaDialogSkin");
            Application.Run(new frmMain());
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
    