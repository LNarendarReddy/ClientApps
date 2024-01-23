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
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        DAccount ObjDAccount = new DAccount();
        EAccount ObjEAccount = new EAccount();
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            dtpFromDate.DateTime = DateTime.Now;
            dtpToDate.DateTime = DateTime.Now;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEAccount.FromDate = dtpFromDate.DateTime;
                ObjEAccount.ToDate = dtpToDate.DateTime;
                ObjEAccount = ObjDAccount.GetAccount(ObjEAccount);
                gcIncome.DataSource = ObjEAccount.dtIncome;
                gcExpenses.DataSource = ObjEAccount.dtExpenses;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}
