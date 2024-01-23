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

namespace InstituteMS
{
    public partial class frmEmailConfiguration : DevExpress.XtraEditors.XtraForm
    {
        EUser ObjEUser = new EUser();
        DUser ObjDUser = new DUser();
        public frmEmailConfiguration()
        {
            InitializeComponent();
        }

        private void frmEmailConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEUser.OrganizationID = Utility.OrgID;
                ObjDUser.GetEmail(ObjEUser);
                if (ObjEUser.dtEmail != null && ObjEUser.dtEmail.Rows.Count > 0)
                {
                    txtEmail.Text = Convert.ToString(ObjEUser.dtEmail.Rows[0]["Email"]);
                    txtMobile.Text = Convert.ToString(ObjEUser.dtEmail.Rows[0]["Mobile"]);
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.Text = txtEmail.Text.Trim();
                txtMobile.Text = txtMobile.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEUser.OrganizationID = Utility.OrgID;
                ObjEUser.UserID = Utility.UserID;
                ObjEUser.Email = txtEmail.Text;
                ObjEUser.Mobile = txtMobile.Text;
                ObjDUser.SaveEmail(ObjEUser);
                Utility.FromEmail = txtEmail.Text;
                Utility.ToMobile = txtMobile.Text;
                XtraMessageBox.Show("Email Details Saved Successfully");
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}