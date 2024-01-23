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

namespace EHR.LeaveModule
{
    public partial class frmComments : DevExpress.XtraEditors.XtraForm
    {
        ELeave ObjELeave = null;
        public frmComments(ELeave _ObjELeave)
        {
            InitializeComponent();
            ObjELeave = _ObjELeave;
        }

        private void frmComments_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ObjELeave.IsSave = true;
            ObjELeave.ChangeStatusComments = txtComments.EditValue;
            this.Close();
        }
    }
}