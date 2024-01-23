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
    public partial class frmChanges : DevExpress.XtraEditors.XtraForm
    {
        public frmChanges(string Description)
        {
            InitializeComponent();
            txtDescription.RtfText = Description;
        }

        private void frmChanges_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }
    }
}