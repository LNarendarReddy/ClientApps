using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EL;
using HMS.ReportForms;
using DevExpress.XtraEditors;
using DL;
using HMS.Reports;
using DevExpress.XtraReports.UI;

namespace HMS
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void biOrganization_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmOrgMaster Obj = new frmOrgMaster();
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }

        }

        private void biBranch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmBranch Obj = new frmBranch();
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }

        }

        private void biUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                EUser ObjEUser = new EUser();
                ObjEUser.BranchID = Utility.BranchID;
                ObjEUser.OrganizationID = Utility.OrgID;
                frmUser Obj = new frmUser(ObjEUser);
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }

        }

        private void biEmailConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmEmailConfiguration Obj = new frmEmailConfiguration();
                ShowSmallForms(Obj);
            }
            catch (Exception ex) { }

        }

        private void biSMSConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSMSConfiguration Obj = new frmSMSConfiguration();
                ShowSmallForms(Obj);
            }
            catch (Exception ex) { }

        }

        private void biChangepwd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmChangePassword Obj = new frmChangePassword();
                ShowSmallForms(Obj);
            }
            catch (Exception ex) { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(0, 0);
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                if (Utility.UserName.ToLower() == "admin" && Utility.Password == "776986")
                {
                    biOrganization.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    biBranch.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                if (Utility.UserName.ToLower() == "admin")
                {
                    btnUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    biEmailConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    biSMSConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnDailySales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnPastClosures.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    btnAllVoucheres.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                this.Text = this.Text + " - " + Utility.OrgName;
                biCurrentDate.EditValue = DateTime.Today;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowMdiChild(XtraForm Obj)
        {
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.Manual;
            Obj.Location = new Point(0, 0);
            int frmWidth = Obj.Width;
            int frmHeight = this.ClientRectangle.Height-160;
            Obj.Size = new Size(frmWidth, frmHeight);
            Obj.Show();
        }

        private void ShowSmallForms(XtraForm Obj)
        {
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
        }

        private void ShowForm(XtraForm Obj)
        {
            Obj.MdiParent = this;
            Obj.StartPosition = FormStartPosition.Manual;
            Obj.Location = new Point(0, 0);
            Obj.Show();
        }

        private void btnItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmItem Obj = new frmItem();
            ShowMdiChild(Obj);
        }

        private void btnCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmItemCategory Obj = new frmItemCategory();
            ShowForm(Obj);
        }

        private void btnBilling_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBilling Obj = new frmBilling();
            ShowMdiChild(Obj);
        }

        private void btnDailySales_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDailySales Obj = new frmDailySales();
            ShowMdiChild(Obj);
        }

        private void btnDayClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var result = XtraMessageBox.Show("Are you sure want to close the day.?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if(Convert.ToString(result) == "Yes")
                {
                    DReports ObjDReports = new DReports();
                    ERpeorts ObjEReports = new ERpeorts();

                    frmDayClosure Obj = new frmDayClosure();
                    Obj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnPastClosures_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDayClosures Obj = new frmDayClosures();
            ShowMdiChild(Obj);
        }

        private void btnVouchers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVouchers Obj = new frmVouchers();
            ShowForm(Obj);
        }

        private void btnAllVoucheres_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAllVouchers Obj = new frmAllVouchers();
            ShowMdiChild(Obj);
        }

        private void btnDayClosure_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var result = XtraMessageBox.Show("Are you sure want to close the day.?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (Convert.ToString(result) == "Yes")
                {
                    frmDayClosure Obj = new frmDayClosure();
                     ShowMdiChild(Obj);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnVoucherCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVoucherCategory Obj = new frmVoucherCategory();
            ShowForm(Obj);
        }
    }
}
