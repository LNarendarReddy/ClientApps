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
    public partial class frmStudentEnquiry : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEStudent = null;
        DStudent ObjDStudent = new DStudent();
        public frmStudentEnquiry()
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
                txtName.Text = txtName.Text.Trim();
                txtMobile.Text = txtMobile.Text.Trim();
                txtCourse.Text = txtCourse.Text.Trim();
                txtFees.Text = txtFees.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEStudent = new EStudent();
                ObjEStudent.FullName = txtName.Text;
                ObjEStudent.CNumber = txtMobile.Text;
                ObjEStudent.course = txtCourse.Text;
                ObjEStudent.fees_enquiry = txtFees.Text;
                ObjEStudent.UserID = Utility.UserID;
                ObjEStudent. BranchID = Utility.BranchID;
                ObjDStudent.SaveStudentEnquiry(ObjEStudent);
                XtraMessageBox.Show("Enquiry Saved Successfully");
                txtName.Text = string.Empty;
                txtMobile.Text = string.Empty;
                txtCourse.Text = string.Empty;
                txtFees.Text = string.Empty;
                txtName.Focus();
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }
    }
}