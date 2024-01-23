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
    public partial class frmBookSales : DevExpress.XtraEditors.XtraForm
    {
        EBook ObjEBook = null;
        DBook ObjDBook = null;
        public frmBookSales()
        {
            InitializeComponent();
        }

        private void frmBookSales_Load(object sender, EventArgs e)
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
                cmbBookName.Properties.DataSource = ObjEBook.dtBook;
                cmbBookName.Properties.ValueMember = "BookInfoID";
                cmbBookName.Properties.DisplayMember = "BookName";
            }
            catch (Exception ex) { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                int iValue = 0;
                if (int.TryParse(Convert.ToString(cmbBookName.EditValue), out iValue))
                {
                    if (ObjEBook == null)
                        ObjEBook = new EBook();
                    if (ObjDBook == null)
                        ObjDBook = new DBook();
                    ObjEBook.OrgID = Utility.OrgID;
                    ObjEBook.BranchID = Utility.BranchID;
                    int iQ = 0;
                    if (int.TryParse(txtQuantity.Text, out iQ))
                        ObjEBook.Quantity = -iQ;
                    else
                        return;
                    ObjEBook.BookInfoID = iValue;
                    ObjEBook.UserID = Utility.UserID;
                    ObjEBook.StudentName = txtStudentName.Text;
                    ObjEBook.StudentMobile = txtStudentMobile.Text;
                    ObjDBook.SaveBookStock(ObjEBook);
                    XtraMessageBox.Show("Book Sale Saved Successfully");
                    txtQuantity.Text = string.Empty;
                    txtStudentName.Text = string.Empty;
                    txtStudentMobile.Text = string.Empty;
                    cmbBookName.Focus();
                }
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