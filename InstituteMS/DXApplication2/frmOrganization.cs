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

namespace InstituteMS
{
    public partial class frmOrganization : DevExpress.XtraEditors.XtraForm
    {
        EUser ObjEUser = null;
        DUser ObjDUser = new DUser();
        public bool IsContinue = false;

        public frmOrganization(EUser _ObjEUser)
        {
            InitializeComponent();
            ObjEUser = _ObjEUser;
        }

        private void frmOrganization_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEUser.OrganizationID > 0)
                {
                    FullNameTextEdit.Text = ObjEUser.FullName;
                    ShortNameTextEdit.Text = ObjEUser.ShortName;
                    FullAddressMemoEdit.Text = ObjEUser.FullAddress;
                    CNumberTextEdit.Text = ObjEUser.CNumber;
                    txtSTNumber.Text = ObjEUser.STNumber;
                    dtpExpiryDate.DateTime = ObjEUser.Exdate;
                    txtOrgSecondName.EditValue = ObjEUser.OrgSecondName;
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FullNameTextEdit.Text = FullNameTextEdit.Text.Trim();
                ShortNameTextEdit.Text = ShortNameTextEdit.Text.Trim();
                FullAddressMemoEdit.Text = FullAddressMemoEdit.Text.Trim();
                CNumberTextEdit.Text = CNumberTextEdit.Text.Trim();
                txtSTNumber.Text = txtSTNumber.Text.Trim();
                txtOrgSecondName.Text = txtOrgSecondName.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEUser.Name = FullNameTextEdit.Text;
                ObjEUser.ShortName = ShortNameTextEdit.Text;
                ObjEUser.FullAddress = FullAddressMemoEdit.Text;
                ObjEUser.CNumber = CNumberTextEdit.Text;
                ObjEUser.STNumber = txtSTNumber.Text;
                ObjEUser.UserID = Utility.UserID;
                ObjEUser.Exdate = dtpExpiryDate.DateTime;
                ObjEUser. OrgSecondName = txtOrgSecondName.Text;
                ObjDUser.SaveOrganization(ObjEUser);
                IsContinue = true;
                this.Close();
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}