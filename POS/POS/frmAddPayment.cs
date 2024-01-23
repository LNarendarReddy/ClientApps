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
using POS.Reports;
using DevExpress.XtraReports.UI;

namespace POS
{
    public partial class frmAddPayment : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEStudent = null;
        DStudent ObjDStudent = new DStudent();
        public frmAddPayment(EStudent _ObjEStudent)
        {
            InitializeComponent();
            ObjEStudent = _ObjEStudent;
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            try
            {
                txtANumber.EditValue = ObjEStudent.AdmissionNumber;
                txtStudentName.EditValue = ObjEStudent.FullName;
                txtRFID.EditValue = ObjEStudent.RFID;
            }
            catch (Exception ex) { Utility.ShowError(ex);}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEStudent.Amount = txtAmount.EditValue;
                ObjEStudent.Remarks = txtRemarks.EditValue;
                if (!dxValidationProvider1.Validate())
                    return;
                ObjDStudent.SavePayment(ObjEStudent);
                ObjEStudent._IsContinue = true;
                rptReciept rpt = new rptReciept();
                rpt.Parameters["AdmissionNumber"].Value = txtANumber.EditValue;
                rpt.Parameters["StudentName"].Value = txtStudentName.EditValue;
                rpt.Parameters["RFID"].Value = txtRFID.EditValue;
                rpt.Parameters["Remarks"].Value = txtRemarks.EditValue;
                rpt.Parameters["CNumber"].Value = ObjEStudent.CNumber1;
                rpt.Parameters["Amount"].Value = txtAmount.EditValue;
                rpt.ShowPrintMarginsWarning = false;
                rpt.Print();
                this.Close();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}