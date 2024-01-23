using DevExpress.Skins;
using DevExpress.Skins.XtraForm;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nbUserMaster_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmUser Obj = new frmUser();
            Obj.ShowDialog();
        }

        private void nbPosMaster_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPOSMaster Obj = new frmPOSMaster();
            Obj.ShowDialog();
        }

        private void nbStudentMaster_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStudent Obj = new frmStudent();
            Obj.ShowDialog();
        }

        private void nbTansactionReport_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTransactionReport Obj = new frmTransactionReport();
            Obj.ShowDialog();
        }

        private void nbPOSLogin_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPOSLogin Obj = new frmPOSLogin();
            Obj.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                DStudent ObjDStudent = new DStudent();
                EStudent ObjEStudent = new EStudent();
                ObjDStudent.GetOrgShortLogo(ObjEStudent);
                pcorgLogo.Image = BinaryToImage(ObjEStudent.Imagedata);
                if (Utility.POSUser)
                {
                    nbPosMaster.Visible = false;
                    nbUserMaster.Visible = false;
                    nbStudentMaster.Visible = false;
                    nbgReports.Visible = false;
                    nbOrgLogo.Visible = false;
                    nbSMSConfiguration.Visible = false;
                    nbPOSLogin_LinkClicked(null, null);
                }
            }
            catch (Exception ex){}
        }

        public class MyFormPainter : FormPainter
        {
            public MyFormPainter(Control owner, ISkinProvider provider) : base(owner, provider) { }

            public override void DrawIcon(DevExpress.Utils.Drawing.GraphicsCache cache)
            {
                Icon icon = this.GetIcon();
                Icon sizedIcon = new Icon(icon, new Size(32, 32));
                Rectangle bounds = new Rectangle(this.IconBounds.X + 6, this.IconBounds.Y - 6, 32, 32);
                Rectangle r = RectangleHelper.GetCenterBounds(bounds, new Size(32, 32));
                cache.Graphics.DrawIcon(sizedIcon, r);
            }

            protected override void DrawText(DevExpress.Utils.Drawing.GraphicsCache cache)
            {
                string text = Text;
                if (text == null || text.Length == 0 || this.TextBounds.IsEmpty) return;
                AppearanceObject appearance = new AppearanceObject(GetDefaultAppearance());
                appearance.Font = new Font("Roboto", 11, FontStyle.Regular);
                appearance.TextOptions.Trimming = Trimming.EllipsisCharacter;
                Rectangle r = RectangleHelper.GetCenterBounds(TextBounds, new Size(TextBounds.Width, appearance.CalcDefaultTextSize(cache.Graphics).Height));
                DrawTextShadow(cache, appearance, r);
                cache.DrawString(text, appearance.Font, appearance.GetForeBrush(cache), r, appearance.GetStringFormat());
            }
        }

        private void nbOrgLogo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                EStudent ObjEStudent = new EStudent();
                ObjEStudent.Imagetype = "OS";
                frmViewImage Obj = new frmViewImage(ObjEStudent);
                Obj.ShowDialog();
            }
            catch (Exception ex) { }
        }

        private Image BinaryToImage(byte[] b)
        {
            MemoryStream memStream = new MemoryStream();
            try
            {
                if (b == null)
                    return null;
                memStream.Write(b, 0, b.Length);
            }
            catch (Exception ex){}
            return Image.FromStream(memStream);
        }

        private void nbSMSConfiguration_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSMSConfiguration Obj = new frmSMSConfiguration();
            Obj.ShowDialog();
        }
    }
}
