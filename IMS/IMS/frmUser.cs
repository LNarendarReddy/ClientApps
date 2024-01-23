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
using DL;
using EL;

namespace IMS
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        DUser ObjDUser = new DUser();
        EUser ObjEUser = new EUser();
        List<Control> RequireFields = new List<Control>();
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(RequireFields))
                    return;
                ObjEUser.UserName = txtUserName.Text.Trim().ToLower();
                ObjEUser.UserFullName = txtFullName.Text.Trim();
                ObjEUser.Password = txtPassword.Text.Trim();
                ObjEUser = ObjDUser.SaveUser(ObjEUser);
                ObjEUser = ObjDUser.GetUser(ObjEUser);
                gcUser.DataSource = ObjEUser.dtUser;
                Utility.Setfocus(gvUser, "UserInfoID", ObjEUser.UserInfoID);
                ClearFields();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                RequireFields.Add(txtUserName);
                RequireFields.Add(txtFullName);
                RequireFields.Add(txtPassword);
                ObjEUser = ObjDUser.GetUser(ObjEUser);
                gcUser.DataSource = ObjEUser.dtUser;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void ClearFields()
        {
            ObjEUser.UserInfoID = -1;
            txtUserName.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}