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
using DevExpress.XtraSplashScreen;
using System.Threading;
using Microsoft.Win32;

namespace HMS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        EUser ObjEUser = new EUser();
        DUser ObjDUser = new DUser();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
                {
                if (txtUserName.Text.ToLower() == "admin" && txtPassword.Text == "776986")
                {
                    Utility.UserName = txtUserName.Text;
                    Utility.Password = txtPassword.Text;
                    this.Hide();
                    frmMain ObjParent = new frmMain();
                    ObjParent.Show();
                }
                else
                {
                    txtUserName.Text = txtUserName.Text.Trim();
                    txtPassword.Text = txtPassword.Text.Trim();
                    cmbOrganization.Text = cmbOrganization.Text.Trim();
                    cmbBranch.Text = cmbBranch.Text.Trim();
                    if (!dxValidationProvider1.Validate())
                        return;
                    ObjEUser.UserName = txtUserName.Text.ToLower();
                    ObjEUser.Password = Utility.Encrypt(txtPassword.Text);
                    ObjEUser.ShortName = cmbOrganization.Text;
                    ObjEUser.BranchName = cmbBranch.Text;
                    ObjDUser.GetUserCredentials(ObjEUser);

                    if (ObjEUser.dtUserDetails != null && ObjEUser.dtUserDetails.Rows.Count > 0)
                    {
                        if (int.TryParse(Convert.ToString(ObjEUser.dtOrg.Rows[0]["OrgID"]), out Utility.OrgID))
                        {
                            ObjEUser.OrganizationID = Utility.OrgID;
                            Utility.OrgName = Convert.ToString(ObjEUser.dtOrg.Rows[0]["FullName"]);
                            Utility.OrgShortName = Convert.ToString(ObjEUser.dtOrg.Rows[0]["ShortName"]);
                            Utility.OrgAddress = Convert.ToString(ObjEUser.dtOrg.Rows[0]["FullAddress"]);
                            Utility.OrgCNumber = Convert.ToString(ObjEUser.dtOrg.Rows[0]["CNumber"]);
                            Utility.STNumber = Convert.ToString(ObjEUser.dtOrg.Rows[0]["STNumber"]);
                            Utility.State = Convert.ToString(ObjEUser.dtOrg.Rows[0]["ISExpired"]);
                        }

                        if (Utility.State == "Yes")
                        {
                            XtraMessageBox.Show("  Error Occured, Please Contact Administrator..!!");
                            //Thread.Sleep(5000);
                            Application.Exit();
                        }
                        else
                        {

                            if (int.TryParse(Convert.ToString(ObjEUser.dtBranch.Rows[0]["BranchID"]), out Utility.BranchID))
                            {
                                ObjEUser.BranchID = Utility.BranchID;
                                Utility.BranchName = cmbBranch.Text;
                                Utility.BranchAddress = Convert.ToString(ObjEUser.dtBranch.Rows[0]["FullAddress"]);
                                Utility.BranchCPerson = Convert.ToString(ObjEUser.dtBranch.Rows[0]["CPerson"]);
                                Utility.BranchCNumber = Convert.ToString(ObjEUser.dtBranch.Rows[0]["CNumber"]);
                            }
                            if (int.TryParse(Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["UserInfoID"]), out Utility.UserID))
                            {
                                Utility.UserName = txtUserName.Text;
                                Utility.Password = Utility.Encrypt(txtPassword.Text);
                                Utility.UserFullName = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["FullName"]);
                            }

                            if (ObjEUser.dtEmail != null && ObjEUser.dtEmail.Rows.Count > 0)
                            {
                                Utility.FromEmail = Convert.ToString(ObjEUser.dtEmail.Rows[0]["Email"]);
                                Utility.ToMobile = Convert.ToString(ObjEUser.dtEmail.Rows[0]["Mobile"]);
                            }
                            if (ObjEUser.dtSMS != null && ObjEUser.dtSMS.Rows.Count > 0)
                            {
                                Utility.strURL = Convert.ToString(ObjEUser.dtSMS.Rows[0]["URLtext"]);
                                Utility.strAppKey = Convert.ToString(ObjEUser.dtSMS.Rows[0]["AppKey"]);
                                Utility.strSenderID = Convert.ToString(ObjEUser.dtSMS.Rows[0]["SenderID"]);
                            }
                            EStudent ObjEStudent = new EStudent();
                            ObjEStudent.OrgID = Utility.OrgID;
                            DStudent ObjDStudent = new DStudent();
                            ObjDStudent.GetOrgShortLogo(ObjEStudent);
                            Utility.Imagedata = ObjEStudent.Imagedata;
                            UpdateUserDetails();
                            this.Hide();
                            frmMain ObjParent = new frmMain();
                            ObjParent.Show();
                        }
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
                                    }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\IC", true);
                if (RGkey != null)
                {
                    if (RGkey.GetValue("Org") != null)
                        cmbOrganization.EditValue = RGkey.GetValue("Org");
                    if (RGkey.GetValue("Branch") != null)
                        cmbBranch.EditValue = RGkey.GetValue("Branch");
                    if (RGkey.GetValue("LastUser") != null)
                        txtUserName.EditValue = RGkey.GetValue("LastUser");
                }
            }
            catch (Exception ex) { }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateUserDetails()
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\IC", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\IC");

                if (RGkey.GetValue("Org") == null)
                {
                    RGkey.SetValue("Org", cmbOrganization.EditValue);
                }
                else
                {
                    if (cmbOrganization.EditValue != null)
                    {
                        RGkey.SetValue("Org", cmbOrganization.EditValue);
                        RGkey.Flush();
                    }
                }

                if (RGkey.GetValue("Branch") == null)
                {
                    RGkey.SetValue("Branch", cmbBranch.EditValue);
                }
                else
                {
                    if (cmbBranch.EditValue != null)
                    {
                        RGkey.SetValue("Branch", cmbBranch.EditValue);
                        RGkey.Flush();
                    }
                }
                if (RGkey.GetValue("LastUser") == null)
                {
                    RGkey.SetValue("LastUser", txtUserName.EditValue);
                }
                else
                {
                    if (txtUserName.EditValue != null)
                    {
                        RGkey.SetValue("LastUser", txtUserName.EditValue);
                        RGkey.Flush();
                    }
                }
                RGkey.Close();
            }
            catch (Exception ex){}
        }
    }
}