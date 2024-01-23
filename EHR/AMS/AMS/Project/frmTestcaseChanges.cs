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
    public partial class frmTestcaseChanges : DevExpress.XtraEditors.XtraForm
    {
        public frmTestcaseChanges(string TestSteps,string ExpectedResult)
        {
            InitializeComponent();
            txtTestSteps.RtfText = TestSteps;
            txtExpectedResult.RtfText = ExpectedResult;
        }

        private void frmTestcaseChanges_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }
    }
}