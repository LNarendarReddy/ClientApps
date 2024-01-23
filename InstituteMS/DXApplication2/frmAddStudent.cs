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
    public partial class frmAddStudent : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEStudent = null;
        DStudent ObjDStudent = new DStudent();
        public frmAddStudent(EStudent _ObjEStudent)
        {
            InitializeComponent();
            ObjEStudent = _ObjEStudent;
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEStudent.StudentID > 0)
                {
                    FullNameTextEdit.ReadOnly = true;
                    FullNameTextEdit.Text = ObjEStudent.FullName;
                    CNumberTextEdit.Text = ObjEStudent.CNumber;
                    cmbAccadamicYear.Text = ObjEStudent.AYear;
                    //if (ObjEStudent.Gender == "Male")
                    //    GenderRadioGroup.SelectedIndex = 0;
                    //else
                    //    GenderRadioGroup.SelectedIndex = 1;
                    EmailIDTextEdit.Text = ObjEStudent.EmailID;
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                FullNameTextEdit.Text = FullNameTextEdit.Text.Trim();
                CNumberTextEdit.Text = CNumberTextEdit.Text.Trim();
                EmailIDTextEdit.Text = EmailIDTextEdit.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEStudent.FullName = FullNameTextEdit.Text;
                ObjEStudent.CNumber = CNumberTextEdit.Text;
                ObjEStudent.AYear = cmbAccadamicYear.Text;
                //if (GenderRadioGroup.SelectedIndex == 0)
                //    ObjEStudent.Gender = "Male";
                //else
                //    ObjEStudent.Gender = "Female";
                ObjEStudent.EmailID = EmailIDTextEdit.Text;
                ObjEStudent.BranchID = Utility.BranchID;
                ObjEStudent.OrgID = Utility.OrgID;
                ObjEStudent.UserID = Utility.UserID;
                ObjDStudent.SaveStudent(ObjEStudent);
                ObjEStudent._IsContinue = true;
                this.Close();
            }
            catch (Exception ex){Utility.ShowError(ex);}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjEStudent._IsContinue = false;
            this.Close();
        }
    }
}