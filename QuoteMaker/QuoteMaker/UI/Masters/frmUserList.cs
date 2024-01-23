using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using QuoteMaker.Models;
using QuoteMaker.Repository;
using System.Collections.Generic;

namespace QuoteMaker.UI.Masters
{
    public partial class frmUserList : DevExpress.XtraEditors.XtraForm
    {
        User user = null;
        public frmUserList()
        {
            InitializeComponent();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                gcUser.DataSource = new RepositoryBase().GetDataTable("USP_R_USER");
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            user = new User();
            frmUser obj = new frmUser(user);
            obj.ShowInTaskbar = false;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.IconOptions.ShowIcon = false;
            obj.ShowDialog();
            if (user.IsSave)
            {
                gcUser.DataSource = new RepositoryBase().GetDataTable("USP_R_USER");
                Utility.Setfocus(gvUser, "USERID", user.USERID);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gvUser.FocusedRowHandle >= 0)
                {
                    user = new User();
                    user.USERID = gvUser.GetFocusedRowCellValue("USERID");
                    user.ROLEID = gvUser.GetFocusedRowCellValue("ROLEID");
                    user.USERNAME = gvUser.GetFocusedRowCellValue("USERNAME");
                    user.FULLNAME = gvUser.GetFocusedRowCellValue("FULLNAME");
                    user.CNUMBER = gvUser.GetFocusedRowCellValue("CNUMBER");
                    user.EMAIL = gvUser.GetFocusedRowCellValue("EMAIL");
                    user.GENDER = gvUser.GetFocusedRowCellValue("GENDER");
                    frmUser obj = new frmUser(user);
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.IconOptions.ShowIcon = false;
                    obj.ShowDialog();
                    if (user.IsSave)
                    {
                        gcUser.DataSource = new RepositoryBase().GetDataTable("USP_R_USER");
                        Utility.Setfocus(gvUser, "USERID", user.USERID);
                    }

                }
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }
        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (gvUser.FocusedRowHandle < 0 || XtraMessageBox.Show("Are you sure want to delete?", "Confirm!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                user = new User();
                user.USERID = gvUser.GetFocusedRowCellValue("USERID");
                user.UserID = Utility.UserID;

                Dictionary<string, object> parameters = new Dictionary<string, object>() 
                {
                    {"USERID", gvUser.GetFocusedRowCellValue("USERID") },
                    {"CUSERID", Utility.UserID }
                };
                new RepositoryBase().Execute<int>("USP_D_USER", parameters);
                gvUser.SetFocusedRowCellValue("USERSTATUS", "IN-ACTIVE");
            }
            catch (Exception ex)
            {
                ErrorMgmt.ShowError(ex);
                ErrorMgmt.Errorlog.Error(ex);
            }
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcUser.ShowRibbonPrintPreview();
        }
        private void gvUser_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            e.Menu.Items.Add(new DXMenuItem("Reset Password", new EventHandler(OnResetPassword_Click)));
        }
        void OnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvUser.FocusedRowHandle >= 0)
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>()
                        {
                            {"USERID", gvUser.GetFocusedRowCellValue("USERID") },
                            {"PASSWORDSTRING", Utility.Encrypt("Password@1234") }
                        };

                    new RepositoryBase().Execute<int>("USP_U_CHANGEPASSWORD", parameters);
                    XtraMessageBox.Show($"Password reset successfully done {Environment.NewLine}Please login with 'Password@1234'");
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