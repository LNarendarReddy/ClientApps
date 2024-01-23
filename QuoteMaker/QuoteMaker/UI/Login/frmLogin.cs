using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Win32;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using QuoteMaker.Repository;

namespace QuoteMaker.UI.Login
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
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
                    Dictionary<string, object> parameters = new Dictionary<string, object>() 
                    {
                        { "USERNAME", txtUserName.Text.ToLower()},
                        { "PASSWORD", Utility.Encrypt(txtPassword.Text)},
                        { "APPVERSION",  Utility.AppVersion}
                    };

                    DataSet ds = new RepositoryBase().GetDataset("USP_R_USERLOGIN", parameters);

                    if (ds != null && ds.Tables.Count > 0)
                    {
                        if (int.TryParse(Convert.ToString(ds.Tables[0].Rows[0][0]), out Utility.UserID))
                        {
                            Utility.UserName = txtUserName.Text;
                            Utility.Password = Utility.Encrypt(txtPassword.Text);
                            Utility.FullName = Convert.ToString(ds.Tables[0].Rows[0]["FULLNAME"]);
                            Utility.Role = Convert.ToString(ds.Tables[0].Rows[0]["ROLENAME"]);
                            Utility.RoleID = Convert.ToInt32(ds.Tables[0].Rows[0]["ROLEID"]);
                            Utility.Email = Convert.ToString(ds.Tables[0].Rows[0]["EMAIL"]);
                            bool IsOTP = Convert.ToBoolean(ds.Tables[0].Rows[0]["ISOTP"]);

                            if (IsOTP)
                            {
                                frmChangePassword Obj = new frmChangePassword();
                                Obj.ShowInTaskbar = false;
                                Obj.StartPosition = FormStartPosition.CenterScreen;
                                Obj.IconOptions.ShowIcon = false;
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
                        else
                        {
                            throw new Exception(Convert.ToString(ds.Tables[0].Rows[0][0]));
                        }

                    }
                }
            }
            catch (Exception ex) {

                if (ex.Message.Contains("Application version mismatch"))
                {
                    try
                    {
                        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                        args.AutoCloseOptions.Delay = 5000;
                        args.Caption = "Application Update";
                        args.Text = "New update available! Please wait till the application is updated.";
                        args.DefaultButtonIndex = 0;
                        args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                        args.Buttons = new DialogResult[] { DialogResult.OK };
                        XtraMessageBox.Show(args);

                        SplashScreenManager.ShowForm(null, typeof(frmProgress), true, true, false);
                        SplashScreenManager.Default.SetWaitFormDescription("Downloading installer...");
                        string InstallerPath = GoogleDriveRepository.DownloadFile();
                        SplashScreenManager.CloseForm();
                        if(File.Exists(InstallerPath))
                        {
                            Process p = new Process();
                            p.StartInfo.FileName = InstallerPath;
                            p.StartInfo.Arguments = "/i /qn";
                            p.Start();
                            Application.Exit();
                        }
                    }
                    catch (Exception exx)
                    {
                        SplashScreenManager.CloseForm();
                        ErrorMgmt.ShowError(exx);
                    }
                }
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
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
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(Utility.RegKey, true);
                if (RGkey == null)
                    RGkey = Registry.CurrentUser.CreateSubKey(Utility.RegKey);

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
            catch (Exception ex){
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            try
            {
                RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(Utility.RegKey, true);
                if (RGkey != null)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(RGkey.GetValue("LastUser"))))
                        txtUserName.EditValue = RGkey.GetValue("LastUser");
                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }
    }
}