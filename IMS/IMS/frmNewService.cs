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
    public partial class frmNewService : DevExpress.XtraEditors.XtraForm
    {
        EPatient ObjEPatient = null;
        List<Control> Requirefields = new List<Control>();
        public frmNewService(EPatient _ObjEPatient)
        {
            InitializeComponent();
            ObjEPatient = _ObjEPatient;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(Requirefields))
                    return;
                ObjEPatient.ServiceName = txtServiceName.Text;
                decimal DValue = 0;
                if (decimal.TryParse(txtPrice.Text, out DValue))
                    ObjEPatient.Price = DValue;
                this.Close();
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

        private void frmNewService_Load(object sender, EventArgs e)
        {
            Requirefields.Add(txtServiceName);
            Requirefields.Add(txtPrice);
        }

        private void frmNewService_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                btnCancel_Click(null,null);
        }

    }
}