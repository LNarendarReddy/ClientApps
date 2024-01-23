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
    public partial class frmBookMaster : DevExpress.XtraEditors.XtraForm
    {
        EBook ObjEBook = null;
        DBook ObjDBook = null;
        public frmBookMaster()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjEBook == null)
                    ObjEBook = new EBook();
                txtBookNAme.Text = txtBookNAme.Text.Trim();
                txtAuthorName.Text = txtAuthorName.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEBook.BranchID = Utility.BranchID;
                ObjEBook.OrgID = Utility.OrgID;
                ObjEBook.UserID = Utility.UserID;
                ObjEBook.BookName = txtBookNAme.Text;
                ObjEBook.AuthorName = txtAuthorName.Text;
                ObjDBook.SaveBook(ObjEBook);
                gcBookMaster.DataSource = ObjEBook.dtBook;
                Utility.Setfocus(gvBookMaster, "BookInfoID", ObjEBook.BookInfoID);
                txtBookNAme.Text = string.Empty;
                txtAuthorName.Text = string.Empty;
                ObjEBook.BookInfoID = -1;
                txtBookNAme.Focus();
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void btnCacnel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookMaster_Load(object sender, EventArgs e)
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
                gcBookMaster.DataSource = ObjEBook.dtBook;
            }
            catch (Exception ex){}
        }
    }
}
