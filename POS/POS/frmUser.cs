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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace POS
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        EPOS ObjEPOS = new EPOS();
        DPOS ObjDPOS = new DPOS();
        EUser ObjEUser = new EUser();
        DUser ObjDUser = new DUser();
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDPOS.GetPOS(ObjEPOS);
                cmbPOS.Properties.DataSource = ObjEPOS.dtPOS;
                cmbPOS.Properties.ValueMember = "POSID";
                cmbPOS.Properties.DisplayMember = "POSName";
                ObjDUser.GetUser(ObjEUser);
                gcUser.DataSource = ObjEUser.dtUser;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserNameTextEdit.Text = UserNameTextEdit.Text.Trim();
                PasswordstringTextEdit.Text = PasswordstringTextEdit.Text.Trim();
                FullNameTextEdit.Text = FullNameTextEdit.Text.Trim();
                CNumberTextEdit.Text = CNumberTextEdit.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                if(chkPOSUser.Checked == true)
                {
                    if (cmbPOS.EditValue == null)
                        throw new Exception("Please select POS");
                }

                ObjEUser.UserName = UserNameTextEdit.Text.ToLower();
                ObjEUser.Password = Utility.Encrypt(PasswordstringTextEdit.Text);
                ObjEUser.FullName = FullNameTextEdit.Text;
                ObjEUser.CNumber = CNumberTextEdit.Text;
                ObjEUser.UserID = Utility.UserID;
                ObjEUser.POSUser = Convert.ToBoolean(chkPOSUser.CheckState);
                ObjEUser.POSID = cmbPOS.EditValue;
                ObjDUser.SaveUser(ObjEUser);
                gcUser.DataSource = ObjEUser.dtUser;
                Utility.Setfocus(gvUser, "UserInfoID", ObjEUser.UserInfoID);
                btnReset_Click(null, null);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjEUser.UserInfoID = -1;
            UserNameTextEdit.Text = string.Empty;
            PasswordstringTextEdit.Text = string.Empty;
            FullNameTextEdit.Text = string.Empty;
            CNumberTextEdit.Text = string.Empty;
            UserNameTextEdit.ReadOnly = false;
            chkPOSUser.Checked = false;
            cmbPOS.EditValue = null;
            UserNameTextEdit.Focus();
        }

        private void gvUser_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvUser.GetFocusedRowCellValue("UserInfoID") != null
                        && int.TryParse(Convert.ToString(gvUser.GetFocusedRowCellValue("UserInfoID")), out IValue))
                    {
                        ObjEUser.UserInfoID = IValue;
                        UserNameTextEdit.Text = Convert.ToString(gvUser.GetFocusedRowCellValue("UserName"));
                        FullNameTextEdit.Text = Convert.ToString(gvUser.GetFocusedRowCellValue("FullName"));
                        CNumberTextEdit.Text = Convert.ToString(gvUser.GetFocusedRowCellValue("CNumber"));
                        PasswordstringTextEdit.Text = Utility.Decrypt(Convert.ToString(gvUser.GetFocusedRowCellValue("Passwordstring")));
                        chkPOSUser.Checked = Convert.ToBoolean(gvUser.GetFocusedRowCellValue("POSUser"));
                        cmbPOS.EditValue = gvUser.GetFocusedRowCellValue("POSID");
                        UserNameTextEdit.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void chkPOSUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPOSUser.Checked == true)
                cmbPOS.Enabled = true;
            else
                cmbPOS.Enabled = false;
        }
    }
}