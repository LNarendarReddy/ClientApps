using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Win32;
using QuoteMaker.Repository;

namespace QuoteMaker.UI.Login
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtOPassword.Text = txtOPassword.Text.Trim();
                txtNPassword.Text = txtNPassword.Text.Trim();
                txtcPassword.Text = txtcPassword.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                if (Utility.Encrypt(txtOPassword.Text) != Utility.Password)
                    throw new Exception("Invalid Old Password");
                if(txtNPassword.Text != txtcPassword.Text)
                    throw new Exception("Both Passwords Should be same");

                Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "USERID", Utility.UserID }
                        , { "PASSWORDSTRING", Utility.Encrypt(txtcPassword.Text) }
                    };

                DataTable dt = new RepositoryBase().GetDataTable("USP_U_PASSWORD", parameters);
                if (dt != null && dt.Rows.Count > 0)
                {
                    int Ivalue = 0;
                    string str = Convert.ToString(dt.Rows[0][0]);
                    if (!int.TryParse(str, out Ivalue))
                        throw new Exception(str);
                }
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (int.TryParse(Convert.ToString(dt.Rows[0]["USERID"]), out Utility.UserID))
                    {
                        Utility.Password = Convert.ToString(dt.Rows[0]["Passwordstring"]);
                        RegistryKey RGkey = Registry.CurrentUser.OpenSubKey(Utility.RegKey, true);
                        if (RGkey == null)
                            RGkey = Registry.CurrentUser.CreateSubKey(Utility.RegKey);
                        if (RGkey.GetValue("PasswordString") == null)
                            RGkey.SetValue("PasswordString", Utility.Password);
                        else
                        {
                            RGkey.SetValue("PasswordString", Utility.Password);
                            RGkey.Flush();
                        }
                        RGkey.Close();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }
    }
}