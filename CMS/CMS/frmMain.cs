using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EL;
using CMS.ReportForms;
using DevExpress.XtraEditors;
using CMS.Properties;
using DevExpress.LookAndFeel;
using Microsoft.Win32;

namespace CMS
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
                biCurrentDate.EditValue = DateTime.Today;
                btnPrinterStatus.Checked = Utility.PrinterStatus;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\CMS", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\CMS");

                if (RGkey.GetValue("SkinName") == null)
                {
                    RGkey.SetValue("SkinName", UserLookAndFeel.Default.SkinName);
                }
                else
                {
                    if (!string.IsNullOrEmpty(UserLookAndFeel.Default.SkinName))
                    {
                        RGkey.SetValue("SkinName", UserLookAndFeel.Default.SkinName);
                        RGkey.Flush();
                    }
                    else
                    {
                        RGkey.SetValue("SkinName", "Office 2019 Colorful");
                        RGkey.Flush();
                    }
                }
                Application.Exit();
            }
            catch (Exception ex){}
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
            ShowForm(Obj);
        }

        private void btnAppointments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmViewAppointments Obj = new frmViewAppointments();
            ShowMdiChild(Obj);
        }

        private void btnNewBooking_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNewPatient Obj = new frmNewPatient(-1);
            ShowForm(Obj);
        }

        private void btnCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMedicineType Obj = new frmMedicineType();
            ShowForm(Obj);
        }

        private void btnPrinterMaster_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPrinterMaster Obj = new frmPrinterMaster();
            ShowForm(Obj);
        }

        private void btnPatientQueue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatientQueue Obj = new frmPatientQueue();
            ShowForm(Obj);
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnJumboPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmJumboPrint Obj = new frmJumboPrint();
            ShowForm(Obj);
        }

        private void btnPrinterStatus_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnPrinterStatus.Checked)
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\CMS", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\CMS");

                if (RGkey.GetValue("PrinterStatus") == null)
                {
                    RGkey.SetValue("PrinterStatus", true);
                }
                else
                {
                    RGkey.SetValue("PrinterStatus", true);
                    RGkey.Flush();
                }
                Utility.PrinterStatus = true;
            }
            else
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\CMS", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\CMS");

                if (RGkey.GetValue("PrinterStatus") == null)
                {
                    RGkey.SetValue("PrinterStatus", false);
                }
                else
                {
                    RGkey.SetValue("PrinterStatus", false);
                    RGkey.Flush();
                }
                Utility.PrinterStatus = false;
            }
                    
        }

        private void btnPatientList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPatientList Obj = new frmPatientList();
            ShowForm(Obj);
        }

        private void btnNextVisitInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNextVisitInfo Obj = new frmNextVisitInfo();
            ShowForm(Obj);
        }
    }
}
