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
    public partial class frmResetPassword : DevExpress.XtraEditors.XtraForm
    {
        DUser ObjDUser = new DUser();
        EUser ObjEUser = new EUser();
        List<Control> RequireFields = new List<Control>();

        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            RequireFields.Add(txtOldPassword);
            RequireFields.Add(txtNewPassword);
            RequireFields.Add(txtConfirmPassword);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(RequireFields))
                    return;
                if (Utility.Password != txtOldPassword.Text)
                    throw new Exception("Invalid Old Password");
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                    throw new Exception("New Password and Confirm Password Not Matching");
                ObjEUser.UserInfoID = Utility.UserID;
                ObjEUser.Password = txtNewPassword.Text;
                ObjEUser = ObjDUser.UpdateUser(ObjEUser);
                string str = Convert.ToString(ObjEUser.dtUser.Rows[0][0]);
                int IValue = 0;
                if (int.TryParse(str, out IValue))
                {
                    Utility.UserID = IValue;
                    Utility.UserName = Convert.ToString(ObjEUser.dtUser.Rows[0]["UserName"]);
                    Utility.UserFullName = Convert.ToString(ObjEUser.dtUser.Rows[0]["UserFullName"]);
                    Utility.Password = Convert.ToString(ObjEUser.dtUser.Rows[0]["Password"]);
                    txtOldPassword.Text = string.Empty;
                    txtNewPassword.Text = string.Empty;
                    txtConfirmPassword.Text = string.Empty;
                }
                else
                    throw new Exception(str);
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
    }
}   