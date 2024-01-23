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
    public partial class frmAddCourse : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEStudent = null;
        DStudent ObjDStudent = new DStudent();
        public frmAddCourse(EStudent _ObjEStudent)
        {
            ObjEStudent = _ObjEStudent;
            InitializeComponent();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            try
            {
                DCourse ObjDCourse = new DCourse();
                ECourse ObjECourse = new ECourse();
                ObjECourse.BranchID = Utility.BranchID;

                ObjDCourse.GetMainCourse(ObjECourse);
                cmbMainCourse.Properties.DataSource = ObjECourse.dtMainCourse;
                cmbMainCourse.Properties.DisplayMember = "Name";
                cmbMainCourse.Properties.ValueMember = "MainCourseID";

                ObjDCourse.GetCourse(ObjECourse);
                NameTextEdit.Properties.DataSource = ObjECourse.dtCourse;
                NameTextEdit.Properties.DisplayMember = "Name";
                NameTextEdit.Properties.ValueMember = "CourseID";
                NameTextEdit.CascadingOwner = cmbMainCourse;
                NameTextEdit.Properties.CascadingMember = "MainCourseID";

                if (ObjEStudent.StudentCourseMapID > 0)
                {
                    FullNameTextEdit.Text = ObjEStudent.FullName;
                    CNumberTextEdit.Text = ObjEStudent.CNumber;
                    EmailIDTextEdit.Text = ObjEStudent.EmailID;
                    cmbAccadamicYear.Text = ObjEStudent.AYear;
                    FeesTextEdit.Text = Convert.ToString(ObjEStudent.Fees);
                    AdvancetextEdit.Text = Convert.ToString(ObjEStudent.Advance);
                    DueDateDateEdit.DateTime = ObjEStudent.DueDate;
                    MAIssuedCheckEdit.Checked = ObjEStudent.MAIssued;
                    IDIssuedCheckEdit.Checked = ObjEStudent.IDIssued;
                    txtBatchNumber.Text = ObjEStudent.BNumber;
                    txtTimings.Text = ObjEStudent.Timings;
                    txtDuration.Text = Convert.ToString(ObjEStudent.Duration);
                    cmbMainCourse.EditValue = ObjEStudent.MainCourseID;
                    NameTextEdit.EditValue = ObjEStudent.CourseID;
                    rgMedium.SelectedIndex = ObjEStudent.Medium;

                    FullNameTextEdit.Enabled = false;
                    FeesTextEdit.Enabled = false;
                    AdvancetextEdit.Enabled = false;
                    NameTextEdit.Enabled = false;
                    cmbMainCourse.Enabled = false;
                    CNumberTextEdit.Focus();
                }
                else
                {
                    DueDateDateEdit.DateTime = DateTime.Now;
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                int IValue = 0;
                if (int.TryParse(Convert.ToString(NameTextEdit.EditValue), out IValue))
                {
                    ObjEStudent.FullName = FullNameTextEdit.Text;
                    ObjEStudent.CNumber = CNumberTextEdit.Text;
                    ObjEStudent.EmailID = EmailIDTextEdit.Text;
                    ObjEStudent.AYear = cmbAccadamicYear.Text;
                    ObjEStudent.CourseID = IValue;
                    decimal dValue = 0;
                    if (decimal.TryParse(FeesTextEdit.Text,out dValue))
                        ObjEStudent.Fees = dValue;

                    if (decimal.TryParse(AdvancetextEdit.Text, out dValue))
                        ObjEStudent.Advance = dValue;

                    if (ObjEStudent.Fees < ObjEStudent.Advance)
                        throw new Exception("Advance cannot be more than fees");
                   
                    ObjEStudent.DueDate = DueDateDateEdit.DateTime;
                    ObjEStudent.MAIssued = Convert.ToBoolean(MAIssuedCheckEdit.CheckState);
                    ObjEStudent.IDIssued = Convert.ToBoolean(IDIssuedCheckEdit.CheckState);
                    ObjEStudent.BNumber = txtBatchNumber.Text;
                    ObjEStudent.Timings = txtTimings.Text;
                    if (AdvancetextEdit.Enabled == true && string.IsNullOrEmpty(cmbPaymentMode.Text))
                        throw new Exception("Payment Mode cannot be empty");
                    ObjEStudent.PaymentMode = cmbPaymentMode.Text;
                    ObjEStudent.Remarks = txtRemarks.Text;
                    ObjEStudent.Medium = rgMedium.SelectedIndex;
                    ObjEStudent.BranchID = Utility.BranchID;
                    ObjEStudent.OrgID = Utility.OrgID;
                    ObjEStudent.UserID = Utility.UserID;
                    if (int.TryParse(txtDuration.Text, out IValue))
                        ObjEStudent.Duration = IValue;
                    else
                        ObjEStudent.Duration = 0;
                    ObjDStudent.SaveCourse(ObjEStudent);
                    ObjEStudent._IsContinue = true;
                    this.Close();
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjEStudent._IsContinue = false;
            this.Close();
        }

        private void NameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                if (editor.EditValue != null)
                {
                    DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                    if (row != null && editor.Text != string.Empty)
                        FeesTextEdit.Text = Convert.ToString(row["Fees"]);
                }
                else
                    FeesTextEdit.Text = "0";
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancelAddmission_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRemarks.Text.Trim()))
                    throw new Exception("Remarks cannot be empty");
                var dlgResult = XtraMessageBox.Show("Are you sure want to cancel admission..?", "Confirmation!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Convert.ToString(dlgResult).ToLower() == "ok")
                {
                    ObjEStudent.Remarks = txtRemarks.Text;
                    ObjDStudent.CancelAdmission(ObjEStudent);
                    ObjEStudent._IsContinue = true;
                    this.Close();
                }
            }
            catch (Exception ex){ Utility.ShowError(ex); }
        }

        private void btnEnquiryList_Click(object sender, EventArgs e)
        {
            try
            {
                frmEnquiryReport Obj = new frmEnquiryReport();
                Obj.StartPosition = FormStartPosition.CenterScreen;
                Obj.flag = "Search";
                Obj.ShowDialog();
                if (!string.IsNullOrEmpty(Obj.studentname))
                {
                    FullNameTextEdit.Text = Obj.studentname;
                    CNumberTextEdit.Text = Obj.Mobile;
                    if (ObjEStudent == null)
                        ObjEStudent = new EStudent();
                    ObjEStudent.EnquiryID = Obj.EnquiryID;
                }
            }
            catch (Exception ex){ Utility.ShowError(ex); } 
        }
    }
}