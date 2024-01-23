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

namespace IMS
{
    public partial class frmExpensesReport : DevExpress.XtraEditors.XtraForm
    {
        EExpenses ObjEExpenses = new EExpenses();
        DExpenses ObjDExpenses = new DExpenses();
        public frmExpensesReport()
        {
            InitializeComponent();
        }

        private void frmExpensesReport_Load(object sender, EventArgs e)
        {
            try
            {
                ObjEExpenses = ObjDExpenses.GetExpses(ObjEExpenses);
                gcExpeses.DataSource = ObjEExpenses.dtExpenses;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                gcExpeses.ShowRibbonPrintPreview();
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
    }
}