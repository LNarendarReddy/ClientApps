using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Google.Apis.Util;
using QuoteMaker.UI.Items;
using QuoteMaker.UI.Masters;
using QuoteMaker.UI.Quote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuoteMaker.UI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public event EventHandler RefreshBaseLineData;
        protected override void OnLoad(EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(frmProgress), true, true);
            base.OnLoad(e);
            Utility.FillBaseLine();
            SplashScreenManager.CloseForm();
        }
        private void btnCreateQuote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmCreateQuote()
            {
                ShowInTaskbar = false,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void btnViewQuote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmQuotationList()
            {
                ShowInTaskbar = false,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUserList obj = new frmUserList();
            obj.ShowInTaskbar = false;
            obj.WindowState = FormWindowState.Maximized;
            obj.IconOptions.ShowIcon = false;
            obj.MdiParent = this;
            obj.Show();
        }

        private void btnCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCategoryList obj = new frmCategoryList();
            obj.ShowInTaskbar = false;
            obj.IconOptions.ShowIcon = false;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.ShowDialog();
        }

        private void btnSubCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmSubCategoryList obj = new frmSubCategoryList();
            obj.ShowInTaskbar = false;
            obj.IconOptions.ShowIcon = false;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.ShowDialog();
        }

        private void btnGST_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmGSTList obj = new frmGSTList();
            obj.ShowInTaskbar = false;
            obj.IconOptions.ShowIcon = false;
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnItemList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmItemCodeList()
            {
                ShowInTaskbar = false,
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                WindowState = FormWindowState.Maximized
            }.Show();
        }
    }
}