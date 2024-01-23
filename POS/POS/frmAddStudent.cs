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

namespace POS
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtAddmissionNumber.Text = txtAddmissionNumber.Text.Trim();
                txtMobile1.Text = txtMobile1.Text.Trim();
                txtMobile2.Text = txtMobile2.Text.Trim();
                txtRFID.Text = txtRFID.Text.Trim();
                txtStudentNAme.Text = txtStudentNAme.Text.Trim();
                cmbGrade.Text = cmbGrade.Text.Trim();
                cmbSection.Text = cmbSection.Text.Trim();
                txtFatheName.Text = txtFatheName.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                double dValue = 0;
                if (double.TryParse(txtAmount.Text, out dValue))
                {
                    if (ObjEStudent.StudentID <= 0 && dValue == 0)
                        throw new Exception("Amount should be greater than Zero!!");
                }
                ObjEStudent.AdmissionNumber = txtAddmissionNumber.EditValue;
                ObjEStudent.CNumber1 = txtMobile1.EditValue;
                ObjEStudent.CNumber2 = txtMobile2.EditValue;
                ObjEStudent.RFID = txtRFID.EditValue;
                ObjEStudent.FullName = txtStudentNAme.EditValue;
                ObjEStudent.Gender = rgGender.SelectedIndex;
                ObjEStudent.Amount = txtAmount.EditValue;
                ObjEStudent.Grade = cmbGrade.EditValue;
                ObjEStudent.Section = cmbSection.EditValue;
                ObjEStudent.FatherName = txtFatheName.EditValue;
                ObjDStudent.SaveStudent(ObjEStudent);
                ObjEStudent._IsContinue = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                if(ObjEStudent.StudentID > 0)
                {
                    txtAddmissionNumber.EditValue = ObjEStudent.AdmissionNumber;
                    txtStudentNAme.EditValue = ObjEStudent.FullName;
                    txtMobile1.EditValue = ObjEStudent.CNumber1;
                    txtMobile2.EditValue = ObjEStudent.CNumber2;
                    txtRFID.EditValue = ObjEStudent.RFID;
                    txtAmount.EditValue = ObjEStudent.Amount;
                    rgGender.SelectedIndex = Convert.ToInt32(ObjEStudent.Gender);
                    cmbGrade.EditValue = ObjEStudent.Grade;
                    cmbSection.EditValue = ObjEStudent.Section;
                    txtFatheName.EditValue = ObjEStudent.FatherName;
                    txtAddmissionNumber.Enabled = false;
                    txtAmount.Enabled = false;
                }
            }
            catch (Exception ex){}
        }
    }
}