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

namespace InstituteMS.Report
{
    public partial class frmBookStockReport : DevExpress.XtraEditors.XtraForm
    {
        EBook ObjEBook = null;
        DBook ObjDBook = null;
        public frmBookStockReport()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookStockReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEBook == null)
                    ObjEBook = new EBook();
                if (ObjDBook == null)
                    ObjDBook = new DBook();
                ObjEBook.OrgID = Utility.OrgID;
                ObjEBook.BranchID = Utility.BranchID;
                ObjDBook.GetBookStockReport(ObjEBook);
                gcBook.DataSource = ObjEBook.dtBook;
            }
            catch (Exception ex) { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gvBook.RowCount > 0)
                gcBook.Print();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (gvBook.RowCount > 0)
                gcBook.ShowRibbonPrintPreview();
        }
    }
}