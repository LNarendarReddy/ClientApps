using QuoteMaker.Models;
using QuoteMaker.Repository;
using System;

namespace QuoteMaker.UI.Masters
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        User user = null;
        public frmUser(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            try
            {
                cmbRole.Properties.DataSource = new RepositoryBase().GetDataTable("USP_R_ROLE");
                cmbRole.Properties.DisplayMember = "ROLENAME";
                cmbRole.Properties.ValueMember = "ROLEID";

                if (Convert.ToInt32(user.USERID) > 0)
                {
                    this.Text = "Edit User";
                    txtUserName.EditValue = user.USERNAME;
                    txtFullName.EditValue = user.FULLNAME;
                    txtPhoneNumber.EditValue = user.CNUMBER;
                    cmbRole.EditValue = user.ROLEID;
                    rgGenderr.SelectedIndex = Convert.ToInt32(user.GENDER);
                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                user.USERNAME = txtUserName.EditValue;
                user.FULLNAME =  txtFullName.EditValue;
                user.CNUMBER = txtPhoneNumber.EditValue;
                user.EMAIL = "test@test.com";
                user.GENDER = rgGenderr.EditValue;
                user.PASSWORDSTRING = Utility.Encrypt("Password@1234");
                user.ROLEID = cmbRole.EditValue;
                user.UserID = Utility.UserID;
                user.USERID = new RepositoryBase().Execute<int>("USP_CU_USER", user.Params);
                user.IsSave = true;
                this.Close();

            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            user.IsSave = false;
            this.Close();
        }
    }
}