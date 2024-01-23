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
using InstituteMS.ReportDesign;
using DevExpress.XtraReports.UI;

namespace InstituteMS
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
                ObjEStudent.BranchID = Utility.BranchID;
                ObjDStudent.GetCourse(ObjEStudent);
                gcCourse.DataSource = ObjEStudent.dtCourse;
                if (Utility.UserName.ToLower() != "admin")
                {
                    gvCourse.Columns.RemoveAt(25);
                    gvFeepayments.Columns.RemoveAt(6);
                    gvFeepayments.Columns.Remove(gcedit);
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEStudent.StudentCourseMapID = -1;
                ObjEStudent.StudentID = -1;
                frmAddCourse Obj = new frmAddCourse(ObjEStudent);
                Obj.ShowDialog();
                if (ObjEStudent._IsContinue)
                {
                    ObjEStudent._IsContinue = false;
                    gcCourse.DataSource = ObjEStudent.dtCourse;
                    Utility.Setfocus(gvCourse, "StudentCourseMapID", ObjEStudent.StudentCourseMapID);
                    gvCourse_FocusedRowChanged(null, null);
                    string FilePath = string.Empty;
                    Utility.PrintRecipt(ObjEStudent.FeepaymentID, ref FilePath);
                    SendEmail(FilePath, ObjEStudent, false,true);
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
            finally
            {
                ObjEStudent.StudentCourseMapID = -1;
                ObjEStudent.StudentID = -1;
                ObjEStudent.FeepaymentID = -1;
            }
        }

        private void btnCourseEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (gvCourse.GetFocusedRowCellValue("StudentID") != null
                    && int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("StudentID")), out IValue))
                {
                    ObjEStudent.StudentID = IValue;
                    ObjEStudent.FullName = Convert.ToString(gvCourse.GetFocusedRowCellValue("FullName"));
                    ObjEStudent.CNumber = Convert.ToString(gvCourse.GetFocusedRowCellValue("CNumber"));
                    ObjEStudent.AYear = Convert.ToString(gvCourse.GetFocusedRowCellValue("AYear"));
                    ObjEStudent.EmailID = Convert.ToString(gvCourse.GetFocusedRowCellValue("EmailID"));
                    ObjEStudent.CourseID = Convert.ToInt32(gvCourse.GetFocusedRowCellValue("CourseID"));
                    ObjEStudent.StudentCourseMapID = Convert.ToInt32(gvCourse.GetFocusedRowCellValue("StudentCourseMapID"));
                    ObjEStudent.Fees = Convert.ToDecimal(gvCourse.GetFocusedRowCellValue("Fees"));
                    ObjEStudent.Advance = 0;
                    ObjEStudent.DueDate = Convert.ToDateTime(gvCourse.GetFocusedRowCellValue("DueDate"));
                    ObjEStudent.MAIssued = Convert.ToBoolean(gvCourse.GetFocusedRowCellValue("MAIssued"));
                    ObjEStudent.IDIssued = Convert.ToBoolean(gvCourse.GetFocusedRowCellValue("IDIssued"));
                    ObjEStudent.BNumber = Convert.ToString(gvCourse.GetFocusedRowCellValue("BNumber"));
                    ObjEStudent.Timings = Convert.ToString(gvCourse.GetFocusedRowCellValue("Timings"));
                    ObjEStudent.Duration = Convert.ToInt32(gvCourse.GetFocusedRowCellValue("Duration"));
                    ObjEStudent.Medium = Convert.ToInt32(gvCourse.GetFocusedRowCellValue("Medium"));
                    ObjEStudent.MainCourseID = Convert.ToInt32(gvCourse.GetFocusedRowCellValue("MainCourseID"));

                    frmAddCourse Obj = new frmAddCourse(ObjEStudent);
                    Obj.ShowDialog();
                    if (ObjEStudent._IsContinue)
                    {
                        ObjEStudent._IsContinue = false;
                        int Temp = ObjEStudent.StudentCourseMapID;
                        gcCourse.DataSource = ObjEStudent.dtCourse;
                        gvCourse.BestFitColumns();
                        Utility.Setfocus(gvCourse, "StudentCourseMapID", Temp);
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
            finally
            {
                ObjEStudent.CourseID = -1;
                ObjEStudent.StudentCourseMapID = -1;
                ObjEStudent.StudentID = -1;
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("StudentCourseMapID")), out IValue))
                {
                    ObjEStudent.StudentCourseMapID = IValue;
                    ObjEStudent.StudentID = Convert.ToInt32(gvCourse.GetFocusedRowCellValue("StudentID"));
                    ObjEStudent.FullName = Convert.ToString(gvCourse.GetFocusedRowCellValue("FullName"));
                    ObjEStudent.CName = Convert.ToString(gvCourse.GetFocusedRowCellValue("Name"));
                    ObjEStudent.Fees = Convert.ToDecimal(gvCourse.GetFocusedRowCellValue("Fees"));
                    ObjEStudent.DueDate = Convert.ToDateTime(gvCourse.GetFocusedRowCellValue("DueDate"));
                    ObjEStudent.Balance = Convert.ToDecimal(gvCourse.GetFocusedRowCellValue("Due"));
                    if (ObjEStudent.Balance > 0)
                    {
                        frmAddPayment Obj = new frmAddPayment(ObjEStudent);
                        Obj.ShowDialog();
                        if (ObjEStudent._IsContinue)
                        {
                            ObjEStudent._IsContinue = false;
                            int temp = ObjEStudent.StudentCourseMapID;
                            gcCourse.DataSource = ObjEStudent.dtCourse;
                            gvCourse.BestFitColumns();
                            Utility.Setfocus(gvCourse, "StudentCourseMapID", temp);
                            gvCourse_FocusedRowChanged(null, null);
                            string FilePath = string.Empty;
                            Utility.PrintRecipt(ObjEStudent.FeepaymentID,ref FilePath);
                            ObjEStudent.StudentCourseMapID = temp;
                            SendEmail(FilePath, ObjEStudent);
                        }
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
            finally
            {
                ObjEStudent.StudentID = -1;
                ObjEStudent.FeepaymentID = -1;
                ObjEStudent.StudentCourseMapID = -1;
            }
        }

        private void SendEmail(string FilePAth, EStudent ObjEStudent, bool IsEdit = false, bool IsNewUser = false)
        {
            try
            {
                ObjDStudent.GetStudentByStudentCourceMapID(ObjEStudent);
                string NAme = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["FullName"]);
                string Number = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["CNumber"]);
                string Paid = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["Amount"]);
                string Due = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["Due"]);
                string Ano = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["AdmissionNumber"]);
                string Subcourse = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["Name"]);
                string BNumber = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["BNumber"]);
                string Fees = Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["Fees"]);
                DateTime dt = DateTime.Now;
                string DueDate = string.Empty;
                if (DateTime.TryParse(Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["DueDate"]), out dt))
                    DueDate = dt.ToString("dd/MMM/yyyy");

                string paymentdate = string.Empty;
                if (DateTime.TryParse(Convert.ToString(ObjEStudent.dtStudentDetails.Rows[0]["CreatedDate"]), out dt))
                    paymentdate = dt.ToString("dd/MMM/yyyy");

                decimal dValue = 0;
                string Subject = string.Empty;
                string Body = string.Empty;
                if (IsEdit)
                {
                    if (decimal.TryParse(Due, out dValue) && dValue > 0)
                    {
                        Subject = "Payment Edited : " + Paid + " on : " + paymentdate + " For cource: " + Subcourse + " Total Fees: " + Fees +
                        " and due amount: " + Due + " due date: " + DueDate;
                    }
                    else
                    {
                        Subject = "Payment Edited : " + Paid + " on : " + paymentdate + " For cource: " + Subcourse + " Total Fees :" + Fees +
                        " and total fees paid";
                    }
                }
                else
                {
                    if (decimal.TryParse(Due, out dValue) && dValue > 0)
                    {
                        if (IsNewUser)
                        {
                            Subject = "New Student Resgistered : Received : " + Paid + " on : " + paymentdate + " For cource: " + Subcourse + " Total Fees: " + Fees +
                        " and due amount: " + Due + " due date: " + DueDate;
                        }
                        else
                        {
                            Subject = "Received : " + Paid + " on : " + paymentdate + " For cource: " + Subcourse + " Total Fees: " + Fees +
                        " and due amount: " + Due + " due date: " + DueDate;
                        }

                    }
                    else
                    {
                        Subject = "Received : " + Paid + " on : " + paymentdate + " For cource: " + Subcourse + " Total Fees :" + Fees +
                        " and total fees paid";
                    }
                }
                Body = "Student NAME: " + NAme + "\n";
                Body += "I'D NO: " + Ano + "\n";
                Body += "Batch No: " + BNumber + "\n";
                Body += "Paid Date: " + paymentdate + "\n";
                Body += "Course: " + Subcourse + "\n";
                Body += "Total Fees: " + Fees + "\n";
                Body += "Due Amount: " + Due + "\n";
                Body += "Due Date: " + DueDate + "\n";
                Body += "Phone Number: " + Number + "\n";
                Body += "Logged In User: " + Utility.UserFullName + "\n";
                Body += Utility.OrgSecondName;
                Utility.SendEmail(Subject, Body, FilePAth, this);
            } 
            catch (Exception ex) { XtraMessageBox.Show("Message Sending Failed"); }
        }

        private void gvCourse_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("StudentCourseMapID")), out IValue))
                {
                    ObjEStudent.StudentCourseMapID = IValue;
                    ObjDStudent.GetPayment(ObjEStudent);
                    gcFeepayments.DataSource = ObjEStudent.dtPayment;
                    Utility.Setfocus(gvFeepayments, "FeePaymentID", ObjEStudent.FeepaymentID);
                    gvFeepayments.BestFitColumns();
                }
                else
                {
                    gcFeepayments.DataSource = null;
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnPrintReciept_Click(object sender, EventArgs e)
        {
            try
            {
                int ivalue = 0;
                if(int.TryParse(Convert.ToString(gvFeepayments.GetFocusedRowCellValue("FeePaymentID")),out ivalue))
                {
                    string FilePath = string.Empty;
                    Utility.PrintRecipt(ivalue,ref FilePath);
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Utility.strURL))
                {
                    string NAme = Convert.ToString(gvCourse.GetFocusedRowCellValue("FullName"));
                    string Number = Convert.ToString(gvCourse.GetFocusedRowCellValue("CNumber"));
                    string Paid = Convert.ToString(gvFeepayments.GetFocusedRowCellValue("Amount"));
                    string Due = Convert.ToString(gvCourse.GetFocusedRowCellValue("Due"));
                    string Ano = Convert.ToString(gvCourse.GetFocusedRowCellValue("AdmissionNumber"));
                    string Subcourse = Convert.ToString(gvCourse.GetFocusedRowCellValue("Name"));
                    string BNumber = Convert.ToString(gvCourse.GetFocusedRowCellValue("BNumber"));
                    DateTime dt = DateTime.Now;
                    string DueDate = string.Empty;
                    if (DateTime.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("DueDate")), out dt))
                        DueDate = dt.ToString("dd/MMM/yyyy");

                    string paymentdate = string.Empty;
                    if (DateTime.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("CreatedDate")), out dt))
                        paymentdate = dt.ToString("dd/MMM/yyyy");

                    decimal dValue = 0;
                    string message = string.Empty;
                    if(decimal.TryParse(Due,out dValue) && dValue > 0)
                        message = "Received : " + Paid + " Dear Student, NAME: " + NAme + " I'D NO: " + Ano
                        + " BATCH NO: " + BNumber + " PAID DATE: " + paymentdate + " COURSE: " + Subcourse +
                        " DUE AMOUNT: " + Due + " DUE DATE: " + DueDate + " PHONE NO: " + Number + " RAMAIAH COACHING CENTRE RAMAIAH ACADEMY";
                    else
                        message = "Received : " + Paid + " Dear Student, NAME: " + NAme + " I'D NO: " + Ano
                        + " BATCH NO: " + BNumber +" PAID AMOUNT&DATE: " + paymentdate + " COURSE: " + Subcourse +
                        " PHONE NO:{#var#} RAMAIAH COACHING CENTRE RAMAIAH ACADEMY";
                    string stQuery = string.Empty;
                    stQuery = string.Format(Utility.strURL, Utility.strAppKey, Utility.strSenderID, Number + "," + Utility.ToMobile, message);
                    stQuery += "&entityid=1701159670744037625";
                    stQuery += "&tempid=1707162512992761791";
                    webBrowser1.Navigate(stQuery);
                }
            }
            catch (Exception ex) { XtraMessageBox.Show("Message Sending Failed"); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewImage_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (gvCourse.GetFocusedRowCellValue("StudentCourseMapID") != null
                    && int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("StudentCourseMapID")), out IValue))
                {
                    ObjEStudent.StudentCourseMapID = IValue;
                    ObjEStudent.Imagetype = "S";
                    frmViewImage Obj = new frmViewImage(ObjEStudent);
                    Obj.ShowDialog();
                    ObjEStudent.StudentCourseMapID = -1;
                }
            }
            catch (Exception ex){}
        }

        private void btnPrintID_Click(object sender, EventArgs e)
        {
            try
            {
                string str = Convert.ToString(gvCourse.GetFocusedRowCellValue("SCRemarks"));
                if (string.IsNullOrEmpty(str))
                {
                    int i = 0;
                    if (int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("StudentCourseMapID")), out i))
                    {
                        IDCard rpt = new IDCard();
                        ReportPrintTool printTool = new ReportPrintTool(rpt);
                        rpt.Parameters["StudentID"].Value = i;
                        rpt.Parameters["OrgName"].Value = Utility.OrgName;
                        rpt.Parameters["OrgAddress"].Value = Utility.OrgAddress;
                        rpt.Parameters["OrgContact"].Value = Utility.OrgCNumber;
                        rpt.Parameters["STNumber"].Value = Utility.STNumber;
                        rpt.ShowRibbonPreview();
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnPaymentEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvCourse.GetFocusedRowCellValue("StudentCourseMapID")), out IValue))
                {
                    ObjEStudent.StudentCourseMapID = IValue;
                    ObjEStudent.StudentID = Convert.ToInt32(gvCourse.GetFocusedRowCellValue("StudentID"));
                    ObjEStudent.FullName = Convert.ToString(gvCourse.GetFocusedRowCellValue("FullName"));
                    ObjEStudent.CName = Convert.ToString(gvCourse.GetFocusedRowCellValue("Name"));
                    ObjEStudent.Fees = Convert.ToDecimal(gvCourse.GetFocusedRowCellValue("Fees"));
                    ObjEStudent.DueDate = Convert.ToDateTime(gvCourse.GetFocusedRowCellValue("DueDate"));
                    ObjEStudent.Balance = Convert.ToDecimal(gvCourse.GetFocusedRowCellValue("Due")) + Convert.ToDecimal(gvFeepayments.GetFocusedRowCellValue("Amount"));
                    ObjEStudent.FeepaymentID = Convert.ToInt32(gvFeepayments.GetFocusedRowCellValue("FeePaymentID"));
                    ObjEStudent.Payment = Convert.ToDecimal(gvFeepayments.GetFocusedRowCellValue("Amount"));
                    ObjEStudent.PaymentMode = Convert.ToString(gvFeepayments.GetFocusedRowCellValue("PaymentMode"));
                    ObjEStudent.Remarks = Convert.ToString(gvFeepayments.GetFocusedRowCellValue("Remarks"));
                    if (ObjEStudent.Balance > 0)
                    {
                        frmAddPayment Obj = new frmAddPayment(ObjEStudent);
                        Obj.ShowDialog();
                        if (ObjEStudent._IsContinue)
                        {
                            ObjEStudent._IsContinue = false;
                            int temp = ObjEStudent.StudentCourseMapID;
                            gcCourse.DataSource = ObjEStudent.dtCourse;
                            gvCourse.BestFitColumns();
                            Utility.Setfocus(gvCourse, "StudentCourseMapID", temp);
                            gvCourse_FocusedRowChanged(null, null);
                            string FilePath = string.Empty;
                            Utility.PrintRecipt(ObjEStudent.FeepaymentID, ref FilePath);
                            ObjEStudent.StudentCourseMapID = temp;
                            SendEmail(FilePath, ObjEStudent,true);
                        }
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
            finally
            {
                ObjEStudent.StudentID = -1;
                ObjEStudent.FeepaymentID = -1;
                ObjEStudent.StudentCourseMapID = -1;
            }
        }
    }
}