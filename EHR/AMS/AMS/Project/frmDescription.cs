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

namespace EHR.Project
{
    public partial class frmDescription : DevExpress.XtraEditors.XtraForm
    {
        public string Description = string.Empty;
        public bool IsSave = false;
        public frmDescription()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Description = txtDescription.Text;
            IsSave = true;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}