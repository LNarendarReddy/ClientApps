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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;

namespace POS
{
    public partial class frmStudent : DevExpress.XtraEditors.XtraForm
    {
        EStudent ObjEStudent = new EStudent();
        DStudent ObjDStudent = new DStudent();
        EUser ObjEUser = new EUser();
        DUser ObjDUser = new DUser();
        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDStudent.GetStudent(ObjEStudent);
                gcStudent.DataSource = ObjEStudent.dtStudent;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEStudent.StudentID = -1;
                frmAddStudent Obj = new frmAddStudent(ObjEStudent);
                Obj.ShowDialog();
                    if (ObjEStudent._IsContinue)
                {
                    ObjEStudent._IsContinue = false;
                    gcStudent.DataSource = ObjEStudent.dtStudent;
                    Utility.Setfocus(gvStudent, "StudentID", ObjEStudent.StudentID);
                    gcTransactions.DataSource = ObjEStudent.dtPayment;
                    repositoryItemButtonEdit1_Click(null, null);
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
            finally
            {
                ObjEStudent.StudentID = -1;
            }
        }

        private void btnCourseEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (gvStudent.GetFocusedRowCellValue("StudentID") != null
                    && int.TryParse(Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentID")), out IValue))
                {
                    ObjEStudent.StudentID = IValue;
                    ObjEStudent.AdmissionNumber = gvStudent.GetFocusedRowCellValue("AdmissionNumber");
                    ObjEStudent.FullName = gvStudent.GetFocusedRowCellValue("FullName");
                    ObjEStudent.CNumber1 = gvStudent.GetFocusedRowCellValue("CNumber1");
                    ObjEStudent.CNumber2 = gvStudent.GetFocusedRowCellValue("CNumber2");
                    ObjEStudent.RFID = gvStudent.GetFocusedRowCellValue("RFIDNumber");
                    ObjEStudent.Amount = 0;
                    ObjEStudent.Gender = gvStudent.GetFocusedRowCellValue("GenderID");
                    ObjEStudent.Grade = gvStudent.GetFocusedRowCellValue("S_Grade");
                    ObjEStudent.Section = gvStudent.GetFocusedRowCellValue("S_Section");
                    ObjEStudent.FatherName = gvStudent.GetFocusedRowCellValue("FatherName");
                    frmAddStudent Obj = new frmAddStudent(ObjEStudent);
                    Obj.ShowDialog();
                    if (ObjEStudent._IsContinue)
                    {
                        ObjEStudent._IsContinue = false;
                        gvStudent.SetFocusedRowCellValue("FullName", ObjEStudent.FullName);
                        gvStudent.SetFocusedRowCellValue("CNumber1", ObjEStudent.CNumber1);
                        gvStudent.SetFocusedRowCellValue("CNumber2", ObjEStudent.CNumber2);
                        gvStudent.SetFocusedRowCellValue("RFIDNumber", ObjEStudent.RFID);
                        gvStudent.SetFocusedRowCellValue("S_Grade", ObjEStudent.Grade);
                        gvStudent.SetFocusedRowCellValue("S_Section", ObjEStudent.Section);
                        gvStudent.SetFocusedRowCellValue("FatherName", ObjEStudent.FatherName);
                        string stgender = string.Empty;
                        if (Convert.ToInt32(ObjEStudent.Gender) == 0)
                            stgender = "MALE";
                        else
                            stgender = "FEMALE";
                        gvStudent.SetFocusedRowCellValue("Gender", stgender);
                        gvStudent.SetFocusedRowCellValue("GenderID", ObjEStudent.Gender);
                        gvStudent.BestFitColumns();
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
            finally
            {
                ObjEStudent.StudentID = -1;
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentID")), out IValue))
                {
                    ObjEStudent.StudentID = IValue;
                    ObjEStudent.FullName = gvStudent.GetFocusedRowCellValue("FullName");
                    ObjEStudent.AdmissionNumber = gvStudent.GetFocusedRowCellValue("AdmissionNumber");
                    ObjEStudent.TType = 0;
                    ObjEStudent.UserID = Utility.UserID;
                    ObjEStudent.RFID = gvStudent.GetFocusedRowCellValue("RFIDNumber");
                    ObjEStudent.CNumber1 = gvStudent.GetFocusedRowCellValue("CNumber1");
                    frmAddPayment Obj = new frmAddPayment(ObjEStudent);
                    Obj.ShowDialog();
                    if (ObjEStudent._IsContinue)
                    {
                        ObjEStudent._IsContinue = false;
                        string balance = Convert.ToString(gvStudent.GetFocusedRowCellValue("Balance"));
                        double dValue = 0;
                        if (double.TryParse(balance, out dValue))
                            dValue = dValue + Convert.ToDouble(ObjEStudent.Amount);
                        gvStudent.SetFocusedRowCellValue(gvStudent.Columns["Balance"], dValue);
                        gcTransactions.DataSource = ObjEStudent.dtPayment;
                        Utility.Setfocus(gvTransactions, "TransactionsID", ObjEStudent.TransactionID);
                        repositoryItemButtonEdit1_Click(null, null);
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void gvCourse_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentID")), out IValue))
                {
                    ObjEStudent.StudentID = IValue;
                    ObjDStudent.GetPayment(ObjEStudent);
                    gcTransactions.DataSource = ObjEStudent.dtPayment;
                    gvTransactions.BestFitColumns();
                }
                else
                {
                    gcTransactions.DataSource = null;
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
            finally { }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Utility.strURL))
                {
                    string NAme = Convert.ToString(gvStudent.GetFocusedRowCellValue("FullName"));
                    string Number = Convert.ToString(gvStudent.GetFocusedRowCellValue("CNumber1"));
                    string Amount = Convert.ToString(gvTransactions.GetFocusedRowCellValue("Amount"));
                    string Balance = Convert.ToString(gvStudent.GetFocusedRowCellValue("Balance"));
                    string Ano = Convert.ToString(gvStudent.GetFocusedRowCellValue("AdmissionNumber"));
                    string paymentdate = string.Empty;
                    paymentdate = DateTime.Now.ToString("dd/MMM/yyyy");
                    string message = "Dear Mr." + NAme + "(" + Ano + ")" + " Credited : Rs." + Amount + " On : " + paymentdate + ". Available Balance: " + Balance;
                    string stQuery = string.Empty;
                    stQuery = string.Format(Utility.strURL, Utility.strAppKey, Utility.strSenderID, Number + "," + Utility.ToMobile, message);
                    webBrowser1.Navigate(stQuery);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Message Sending Failed"); }
        }

        private void btnViewImage_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (gvStudent.GetFocusedRowCellValue("StudentID") != null
                    && int.TryParse(Convert.ToString(gvStudent.GetFocusedRowCellValue("StudentID")), out IValue))
                {
                    ObjEStudent.StudentID = IValue;
                    ObjEStudent.Imagetype = "S";
                    frmViewImage Obj = new frmViewImage(ObjEStudent);
                    Obj.ShowDialog();
                }
            }
            catch (Exception ex) { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}