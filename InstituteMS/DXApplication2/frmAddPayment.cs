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
    public partial class frmAddPayment : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEStudent = null;
        DStudent ObjDStudent = new DStudent();
        public frmAddPayment(EStudent _ObjEStudent)
        {
            ObjEStudent = _ObjEStudent;
            InitializeComponent();
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            try
            {
                txtStudentName.ReadOnly = true;
                txtCourseName.ReadOnly = true;
                txtTotalFee.ReadOnly = true;
                txtBalance.ReadOnly = true;

                txtStudentName.Text = ObjEStudent.FullName;
                txtCourseName.Text = ObjEStudent.CName;
                txtTotalFee.Text = Convert.ToString(ObjEStudent.Fees);
                txtBalance.Text = Convert.ToString(ObjEStudent.Balance);
                dtpNextDueDate.DateTime = ObjEStudent.DueDate;

                if (ObjEStudent.FeepaymentID > 0)
                {
                    txtAmount.Text = Convert.ToString(ObjEStudent.Payment);
                    cmbPaymentMode.Text = Convert.ToString(ObjEStudent.PaymentMode);
                    txtRemarks.Text = Convert.ToString(ObjEStudent.Remarks);
                }
                txtAmount.Focus();
            }
            catch (Exception ex) { Utility.ShowError(ex); }   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                decimal dValue = 0;
                if (decimal.TryParse(txtAmount.Text, out dValue))
                    ObjEStudent.Advance = dValue;
                if (ObjEStudent.Advance <= 0)
                    return;
                decimal bal = 0;
                if (decimal.TryParse(txtBalance.Text, out dValue))
                    bal = dValue;
                if(bal < ObjEStudent.Advance)
                    throw new Exception("Advance cannot be more than fees");
                ObjEStudent.DueDate = dtpNextDueDate.DateTime;
                ObjEStudent.UserID = Utility.UserID;
                ObjEStudent.PaymentMode = cmbPaymentMode.Text;
                ObjEStudent.Remarks = txtRemarks.Text;
                ObjDStudent.SavePayment(ObjEStudent);
                ObjEStudent._IsContinue = true;
                this.Close();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjEStudent._IsContinue = false;
            this.Close();
        }
    }
}