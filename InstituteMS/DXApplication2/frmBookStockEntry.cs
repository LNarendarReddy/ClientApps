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

namespace InstituteMS
{
    public partial class frmBookStockEntry : DevExpress.XtraEditors.XtraForm
    {
        EBook ObjEBook = null;
        DBook ObjDBook = null;
        public frmBookStockEntry()
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
                int iValue = 0;
                if (int.TryParse(Convert.ToString(cmbBookNAme.EditValue), out iValue))
                {
                    if (ObjEBook == null)
                        ObjEBook = new EBook();
                    if (ObjDBook == null)
                        ObjDBook = new DBook();
                    ObjEBook.OrgID = Utility.OrgID;
                    ObjEBook.BranchID = Utility.BranchID;
                    int iQ = 0;
                    if (int.TryParse(txtQuantity.Text, out iQ))
                        ObjEBook.Quantity = iQ;
                    else
                        return;
                    ObjEBook.BookInfoID = iValue;
                    ObjEBook.UserID = Utility.UserID;
                    ObjDBook.SaveBookStock(ObjEBook);
                    XtraMessageBox.Show("Book Stock Saved Successfully");
                    txtQuantity.Text = string.Empty;
                    cmbBookNAme.Focus();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void frmBookStockEntry_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEBook == null)
                    ObjEBook = new EBook();
                if (ObjDBook == null)
                    ObjDBook = new DBook();
                ObjEBook.OrgID = Utility.OrgID;
                ObjEBook.BranchID = Utility.BranchID;
                ObjDBook.GetBook(ObjEBook);
                cmbBookNAme.Properties.DataSource = ObjEBook.dtBook;
                cmbBookNAme.Properties.ValueMember = "BookInfoID";
                cmbBookNAme.Properties.DisplayMember= "BookName";
            }
            catch (Exception ex) { }
        }
    }
}