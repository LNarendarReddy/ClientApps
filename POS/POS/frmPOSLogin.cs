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
    public partial class frmPOSLogin : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEStudent = new EStudent();
        DStudent ObjDStudent = new DStudent();
        public frmPOSLogin()
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
                txtAdmissionNumber.Text = txtAdmissionNumber.Text.Trim();
                txtRFID.Text = txtRFID.Text.Trim();
                txtStudentName.Text = txtStudentName.Text.Trim();
                txtDescription.Text = txtDescription.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                double Balance = 0;
                double.TryParse(txtBalance.Text,out Balance);
                double Amount = 0;
                double.TryParse(txtAmount.Text, out Amount);
                if (Balance < Amount)
                    throw new Exception("Amount should be less than balance");
                ObjEStudent.AdmissionNumber = txtAdmissionNumber.EditValue;
                ObjEStudent.Amount = -Amount;
                ObjEStudent.TType = 1;
                ObjEStudent.UserID = Utility.UserID;
                ObjEStudent.RFID = txtRFID.EditValue;
                ObjEStudent.Remarks = txtDescription.EditValue;
                ObjDStudent.SavePayment(ObjEStudent);
                SendSMS();
                rptBill rpt = new rptBill();
                rpt.Parameters["AdmissionNumber"].Value = txtAdmissionNumber.EditValue;
                rpt.Parameters["StudentName"].Value = txtStudentName.EditValue;
                rpt.Parameters["RFID"].Value = txtRFID.EditValue;
                rpt.Parameters["Ramarks"].Value = txtDescription.EditValue;
                rpt.Parameters["Amount"].Value = txtAmount.EditValue;
                rpt.Parameters["PosName"].Value = Utility.POSName;
                rpt.ShowPrintMarginsWarning = false;
                rpt.Print();
                btnREset_Click(null, null);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void frmPOSLogin_Load(object sender, EventArgs e)
        {
            lblUser.Text = "User : " + Utility.UserFullName;
            lblPOS.Text = "POS : " + Utility.POSName;
        }

        private void txtRFID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRFID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtRFID.Text))
                {
                    ObjEStudent.RFID = txtRFID.Text;
                    ObjDStudent.GETStudentByRFID(ObjEStudent);
                    if (ObjEStudent.dtStudent != null && ObjEStudent.dtStudent.Rows.Count > 0)
                    {
                        string stID = Convert.ToString(ObjEStudent.dtStudent.Rows[0]["StudentID"]);
                        int.TryParse(stID, out ObjEStudent.StudentID);
                        txtAdmissionNumber.EditValue = ObjEStudent.dtStudent.Rows[0]["AdmissionNumber"];
                        txtStudentName.EditValue = Convert.ToString(ObjEStudent.dtStudent.Rows[0]["FullName"]);
                        txtBalance.EditValue = ObjEStudent.dtStudent.Rows[0]["Balance"];
                        txtMobileNumber.EditValue = ObjEStudent.dtStudent.Rows[0]["CNumber1"];
                    }
                    else
                    {
                        txtRFID.Focus();
                        txtRFID.Text = string.Empty;
                        throw new Exception("RFID deos not exists");
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnREset_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEStudent.StudentID = -1;
                txtRFID.Text = string.Empty;
                txtAdmissionNumber.Text = string.Empty;
                txtStudentName.Text = string.Empty;
                txtBalance.Text = string.Empty;
                txtAmount.Text = string.Empty;
                txtDescription.Text = string.Empty;
                txtMobileNumber.Text = string.Empty;
                txtRFID.Focus();
            }
            catch (Exception ex){}
        }

        private void SendSMS()
        {
            try
            {
                if (!string.IsNullOrEmpty(Utility.strURL))
                {
                    string NAme = txtStudentName.Text;
                    string Number = txtMobileNumber.Text;
                    string Amount = txtAmount.Text;
                    string Balance = txtBalance.Text;
                    string Ano = txtAdmissionNumber.Text;
                    decimal dAmount = 0;
                    decimal.TryParse(txtAmount.Text, out dAmount);
                    decimal dBalance = 0;
                    decimal.TryParse(txtBalance.Text, out dBalance);
                    decimal dValue = dBalance - dAmount;
                    string paymentdate = string.Empty;
                    paymentdate = DateTime.Now.ToString("dd/MMM/yyyy");
                    string message = "Dear Mr." + NAme + "(" + Ano + ")" + ". Debited : Rs." + Amount + " On : " + paymentdate + " Towards : " + txtDescription.Text +". Available Balance: " + dValue.ToString("F2");
                    string stQuery = string.Empty;
                    stQuery = string.Format(Utility.strURL, Utility.strAppKey, Utility.strSenderID, Number + "," + Utility.ToMobile, message);
                    webBrowser1.Navigate(stQuery);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Message Sending Failed"); }
        }
    }
}