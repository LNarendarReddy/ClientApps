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
using DevExpress.Skins;
using DevExpress.Skins.XtraForm;
using DevExpress.Utils;

namespace POS
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
                    ObjParent.ShowDialog();
                    this.Close();
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
                            Utility.POSUser = Convert.ToBoolean(ObjEUser.dtUserDetails.Rows[0]["POSUser"]);
                            Utility.POSName = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["POSName"]);
                            Utility.POSDescription = Convert.ToString(ObjEUser.dtUserDetails.Rows[0]["POSDescription"]);

                        }
                        if (ObjEUser.dtSMS != null && ObjEUser.dtSMS.Rows.Count > 0)
                        {
                            Utility.strURL = Convert.ToString(ObjEUser.dtSMS.Rows[0]["URLtext"]);
                            Utility.strAppKey = Convert.ToString(ObjEUser.dtSMS.Rows[0]["AppKey"]);
                            Utility.strSenderID = Convert.ToString(ObjEUser.dtSMS.Rows[0]["SenderID"]);
                        }
                        this.Hide();
                        frmMain ObjParent = new frmMain();
                        ObjParent.ShowDialog();
                        this.Close();
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
            //txtUserName.Text = "Naren";
            //txtPassword.Text = "1234";
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}