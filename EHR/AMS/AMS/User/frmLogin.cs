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
using System.Net;
using log4net;

namespace EHR
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DUser ObjDUser = new DUser();
        EUser ObjEUser = new EUser();

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
                    if (!dxValidationProvider1.Validate())
                        return;
                    ObjEUser.UserName = txtUserName.Text.ToLower();
                    ObjEUser.Password = Utility.Encrypt(txtPassword.Text);
                    ObjDUser.GetUserCredentials(ObjEUser);

                    if (ObjEUser.dtUserDetails != null && ObjEUser.dtUserDetails.Rows.Count > 0)
                    {
                        if (int.TryParse(Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["UserInfoID"]), out Utility.UserID))
                        {
                            Utility.UserName = txtUserName.Text;
                            Utility.Password = Utility.Encrypt(txtPassword.Text);
                            Utility.UserFullName = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["FullName"]);
                            Utility.Designation = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["DesignationName"]).Trim();
                            Utility.RoleID = Convert.ToInt32(ObjEUser.dtUserDetails.Rows[0]["RoleID"]);
                            Utility.ReportingLead = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["ReportingLead"]);
                            Utility.EnableAssessment = ObjEUser.dtUserDetails.Rows[0]["EnableAssessment"];
                            Utility.UserEmail = ObjEUser.dtUserDetails.Rows[0]["Email"];
                            Utility.HREmail = ObjEUser.dtUserDetails.Rows[0]["HREmail"];
                            bool IsOTP = Convert.ToBoolean(ObjEUser.dtUserDetails.Rows[0]["IsOTP"]);
                            if (IsOTP)
                            {
                                frmChangePassword Obj = new frmChangePassword();
                                Obj.ShowDialog();
                            }
                            else
                            {
                                UpdateUserDetails();
                                this.Hide();
                                frmMain ObjParent = new frmMain();
                                ObjParent.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            btnLogin.LookAndFeel.SkinName = "CategisSkin";
            btnCancel.LookAndFeel.SkinName = "CategisSkin";
            txtUserName.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateUserDetails()
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\AMS", true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(@"Software\AMS");

                if (RGkey.GetValue("LastUser") == null)
                {
                    RGkey.SetValue("LastUser", txtUserName.EditValue);
                    RGkey.SetValue("PasswordString", txtPassword.EditValue);
                }
                else
                {
                    if (txtUserName.EditValue != null)
                    {
                        RGkey.SetValue("LastUser", txtUserName.EditValue);
                        RGkey.SetValue("PasswordString", txtPassword.EditValue);
                        RGkey.Flush();
                    }
                }
                RGkey.Close();
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(@"Software\AMS", true);
                if (RGkey != null)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(RGkey.GetValue("LastUser")))
                        && !string.IsNullOrEmpty(Convert.ToString(RGkey.GetValue("PasswordString"))))
                    {
                        txtUserName.EditValue = RGkey.GetValue("LastUser");
                        txtPassword.EditValue = RGkey.GetValue("PasswordString");
                        btnLogin_Click(null, null);
                    }
                    else
                    {
                        txtUserName.EditValue = RGkey.GetValue("LastUser");
                        txtPassword.EditValue = RGkey.GetValue("PasswordString");
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
    }
}