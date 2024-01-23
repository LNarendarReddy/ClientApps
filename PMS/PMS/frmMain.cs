using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EL;
using PMS.ReportForms;
using DevExpress.XtraEditors;

namespace PMS
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void biPatients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmSearchPatient Obj = new frmSearchPatient();
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }
        }

        private void biDoctors_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmDoctorsMaster Obj = new frmDoctorsMaster();
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }
        }

        private void biCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCategory Obj = new frmCategory();
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }

        }

        private void biMedicines_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMedicine Obj = new frmMedicine(0);
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }

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

        private void biTreatment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmTreatment Obj = new frmTreatment(true,0);
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }

        }

        private void biStockUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmStockUpdate Obj = new frmStockUpdate();
                ShowForm(Obj);
            }
            catch (Exception ex) { }

        }

        private void biPatientHistory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmPatientHistory Obj = new frmPatientHistory(0);
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
                    biUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    biEmailConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    biSMSConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                this.Text = this.Text + " - " + Utility.OrgName;
                //lblUser.Text = "Logged User : " + Utility.UserName;
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

        private void biDayCollections_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDailyCollectionReport Obj = new frmDailyCollectionReport();
            ShowMdiChild(Obj);
        }

        private void biCurrentDate_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Utility.dtSelectedDate = Convert.ToDateTime(biCurrentDate.EditValue);
            }
            catch (Exception ex)
            {
                throw;
            }
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

        private void btnBookAppointments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAppointments Obj = new frmAppointments();
            ShowSmallForms(Obj);
        }

        private void btnAppointments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewAppointments Obj = new frmViewAppointments();
            ShowMdiChild(Obj);
        }

        private void btnPrinterMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmPrinterMaster Obj = new frmPrinterMaster();
                ShowMdiChild(Obj);
            }
            catch (Exception ex) { }
        }

        private void btnDatabaseBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDataBaseBackup obj = new frmDataBaseBackup();
            obj.StartPosition = FormStartPosition.CenterParent;
            obj.ShowDialog();
        }
    }
}
