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
    public partial class frmPOSMaster : DevExpress.XtraEditors.XtraForm
    {
        EPOS ObjEPOS = new EPOS();
        DPOS ObjDPOS = new DPOS();
        public frmPOSMaster()
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
                txtPOSName.Text = txtPOSName.Text.Trim();
                txtPOSDescription.Text = txtPOSDescription.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEPOS.POSName = txtPOSName.Text;
                ObjEPOS.POSDescription = txtPOSDescription.Text;
                ObjDPOS.SavePOS(ObjEPOS);
                gcPOS.DataSource = ObjEPOS.dtPOS;
                Utility.Setfocus(gvPOS, "POSID", ObjEPOS.POSID);
                txtPOSName.Text = string.Empty;
                txtPOSDescription.Text = string.Empty;
                ObjEPOS.POSID = -1;
                txtPOSName.Focus();
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void frmPOSMaster_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDPOS.GetPOS(ObjEPOS);
                gcPOS.DataSource = ObjEPOS.dtPOS;
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }
    }
}