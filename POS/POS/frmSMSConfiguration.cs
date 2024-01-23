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

namespace POS
{
    public partial class frmSMSConfiguration : DevExpress.XtraEditors.XtraForm
    {
        EUser ObjEUser = new EUser();
        DUser ObjDUser = new DUser();

        public frmSMSConfiguration()
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
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEUser.URLtext = txtURL.Text;
                ObjEUser.AppKey = txtAppKey.Text;
                ObjEUser.SenderID = txtSenderID.Text;
                ObjDUser.SaveSMS(ObjEUser);
                XtraMessageBox.Show("SMS Details Saved Successfully");
                Utility.strURL = txtURL.Text;
                Utility.strAppKey = txtAppKey.Text;
                Utility.strSenderID = txtSenderID.Text;
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }

        private void frmSMSConfiguration_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDUser.GetSMS(ObjEUser);
                if (ObjEUser.dtSMS != null && ObjEUser.dtSMS.Rows.Count > 0)
                {
                    txtURL.Text = Convert.ToString(ObjEUser.dtSMS.Rows[0]["URLtext"]);
                    txtAppKey.Text = Convert.ToString(ObjEUser.dtSMS.Rows[0]["AppKey"]);
                    txtSenderID.Text = Convert.ToString(ObjEUser.dtSMS.Rows[0]["SenderID"]);
                }
            }
            catch (Exception ex) { }
        }
    }
}