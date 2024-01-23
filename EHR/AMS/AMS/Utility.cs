using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DL;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using log4net;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Exchange.WebServices.Autodiscover;

namespace EHR
{
    public class Utility
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static string stParagraphBoldstart = "<p style=\"font-family:Bahnschrift Light; font-size:100%; font-weight:bold;\">";
        public static string stParagraphstart = "<p style=\"font-family:Bahnschrift Light; font-size:80%; font-weight:regular;\">";
        public static string stParagraphend = "</p>";


        public static string stTableStart = "<table border = 1 cellpadding = 3 cellspacing= 0 width = 1000>";
        public static string stTableEnd = "</table>";
        public static string stTableHeaderStart = "<tr style=\"background-color:#E7EEEC; font-family:Bahnschrift Light; font-size:100%; font-weight:bold;\">";
        public static string stRowStart = "<tr style=\"font-family:Bahnschrift Light; font-size:80%; font-weight:regular;\">";
        public static string stRowEnd = "</tr>";
        public static string stCellHeaderLeftStart = "<th style =\"text-align:left;\">";
        public static string stCellHeaderCenterStart = "<th style =\"text-align:center; \">";
        public static string stCellHeaderEnd = "</th>";
        public static string stColumn1Start = "<td style =\"text-align:left; width:600\">";
        public static string stColumn2Start = "<td style =\"text-align:left; width:400\">";
        public static string stCellRowEnd = "</td>";

        public static int UserID = 0;
        public static string UserName = string.Empty;
        public static string UserFullName = string.Empty;
        public static string Password = string.Empty;
        public static int RoleID = 0;
        public static string Designation = string.Empty;
        public static string ReportingLead = string.Empty;
        public static object EnableAssessment = false;
        public static object UserEmail = string.Empty;
        public static object HREmail = string.Empty;

        public static string MachineName = string.Empty;
        public static string MachineUserName = string.Empty;
        public static string IPAddress = string.Empty;

        public static int OrgID = 1;
        public static string OrgName = string.Empty;
        public static string OrgShortName = string.Empty;
        public static string OrgAddress = string.Empty;
        public static string OrgCNumber = string.Empty;
        public static string STNumber = string.Empty;
        public static string State = string.Empty;

        public static int BranchID = 1;
        public static string BranchName = string.Empty;
        public static string BranchAddress = string.Empty;
        public static string BranchCPerson = string.Empty;
        public static string BranchCNumber = string.Empty;

        public static string FromEmail = string.Empty;
        public static string FromPassword = string.Empty;
        public static string ToMobile = string.Empty;

        public static string strURL = string.Empty;
        public static string strAppKey = string.Empty;
        public static string strSenderID = string.Empty;

        public static int DoctorID = 0;
        public static string DTitle = string.Empty;
        public static string DName = string.Empty;
        public static string DQualification = string.Empty;
        public static string DAddress = string.Empty;
        public static string DEmail = string.Empty;
        public static string DPhone = string.Empty;
        public static string DNameHindi = string.Empty;
        public static string DQualificationHindi = string.Empty;

        public static string AppVersion = "1.8.5";

        public static bool PrinterStatus = true;

        public static byte[] Imagedata = null;

        public static DateTime dtSelectedDate;
        public static void ShowError(Exception ex, bool IsInfo = false)
        {
            if (IsInfo)
                ShowMesBox("Information", ex.Message, "I");
            else if (ex.Message.Contains("New update available"))
                ShowAutoMesBox("Application Update", ex.Message);
            else if (ex.Message.Contains("Please wait for some time"))
                ShowMesBox("Lunch Time", "Minimum lunch time is 15mins. Please wait.", "I");
            else
                ShowMesBox("Error", ex.Message, "E");
        }

        private static void ShowMesBox(string stCaption, string stText, string Type)
        {
            //Icon customIcon = null;
            //if (Type == "E")
            //    customIcon = MessageBoxIcon.Error;
            //else
            //    customIcon = XtraMessageBox.Icons[MessageBoxIcon.Information];

            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = stCaption;
            args.Text = stText;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            //args.Icon = customIcon;
            args.Showing += Args_Showing;
            XtraMessageBox.Show(args);
        }

        private static void ShowAutoMesBox(string stCaption, string stText)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = 5000;
            args.Caption = stCaption;
            args.Text = stText;
            args.DefaultButtonIndex = 0;
            args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
            args.Buttons = new DialogResult[] { DialogResult.OK };
            args.Showing += Args_Showing;
            XtraMessageBox.Show(args);
        }

        private static void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F);
            MessageButtonCollection buttons = e.Buttons as MessageButtonCollection;
            SimpleButton btn = buttons[System.Windows.Forms.DialogResult.OK] as SimpleButton;
            if (btn != null)
            {
                btn.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F);
            }
        }

        public static void Setfocus(GridView view, string ColumnName, object Value)
        {
            try
            {
                if (Convert.ToInt32(Value) > -1)
                {
                    int rowHandle = view.LocateByValue(ColumnName, Value);
                    if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        view.FocusedRowHandle = rowHandle;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Encrypt(string input)
        {
            try
            {
                return CategisSecurity.Security.Encrypt(input);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SendEmail(string Subject, string Body, string ToEmail)
        {
            MailMessage msg = new MailMessage();
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                msg.From = new MailAddress("hr-leave@categis.com");
                msg.To.Add(ToEmail);
                msg.Subject = Subject;
                msg.IsBodyHtml = true;
                msg.Body = Body;
                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.1und1.de";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "hr-leave@categis.com";
                ntcd.Password = "Leaves@Categis2020";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
                SplashScreenManager.CloseForm(false);
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Utility.ShowError(ex);
            }
            finally
            {
                msg.Dispose();
                msg = null;
            }
        }

        public static bool CheckDbConnection()
        {
            try
            {
                SQLCon.Sqlconn();
                if (SQLCon.Sqlconn().State == System.Data.ConnectionState.Open)
                    SQLCon.Sqlconn().Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                return false;
            }
            return true;
        }

        public static void PrintRecipt(int FeePaymentID)
        {
            try
            {
                XtraReport rpt = new XtraReport();
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                rpt.Parameters["FeePaymentID"].Value = FeePaymentID;
                rpt.Parameters["OrgName"].Value = Utility.OrgName;
                rpt.Parameters["OrgAddress"].Value = Utility.OrgAddress;
                rpt.Parameters["OrgContact"].Value = Utility.OrgCNumber;
                rpt.Parameters["STNumber"].Value = Utility.STNumber;
                rpt.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to print Recipt");
            }
        }

        public static string GetResource(string stVal)
        {
            ResourceManager rm = new ResourceManager("AMS.Language.H", Assembly.GetExecutingAssembly());
            return rm.GetString(stVal);
        }

        public static void Printreport(XtraReport rpt, string Printername)
        {
            try
            {
                if (PrinterStatus)
                {
                    ReportPrintTool printTool = new ReportPrintTool(rpt);
                    printTool.Print(Printername);
                }
            }
            catch (Exception ex) { }
        }

        public static DataTable ChangeColumnDataType(DataTable dt)
        {
            DataTable dtTemp = dt.Clone();
            try
            {
                dtTemp.Columns["SA"].DataType = typeof(decimal);
                DataRow drnew = null;
                foreach (DataRow dr in dt.Rows)
                {
                    drnew = dtTemp.NewRow();
                    foreach (DataColumn dc in dtTemp.Columns)
                    {
                        if (dc.ColumnName == "SA")
                        {
                            decimal dValue = 0;
                            if (decimal.TryParse(Convert.ToString(dr["SA"]), out dValue))
                                drnew[dc.ColumnName] = dr[dc.ColumnName];
                        }
                        else
                            drnew[dc.ColumnName] = dr[dc.ColumnName];
                    }
                    dtTemp.Rows.Add(drnew);
                }
            }
            catch (Exception ex) { throw ex; }
            return dtTemp;
        }

        public static void downloadFile(string sourceURL, string destinationPath)
        {
            try
            {
                long fileSize = 0;
                int bufferSize = 1024;
                bufferSize *= 1000;
                long existLen = 0;

                System.IO.FileStream saveFileStream;
                if (System.IO.File.Exists(destinationPath))
                {
                    System.IO.FileInfo destinationFileInfo = new System.IO.FileInfo(destinationPath);
                    existLen = destinationFileInfo.Length;
                }

                if (existLen > 0)
                    saveFileStream = new System.IO.FileStream(destinationPath,
                                                              System.IO.FileMode.Append,
                                                              System.IO.FileAccess.Write,
                                                              System.IO.FileShare.ReadWrite);
                else
                    saveFileStream = new System.IO.FileStream(destinationPath,
                                                              System.IO.FileMode.Create,
                                                              System.IO.FileAccess.Write,
                                                              System.IO.FileShare.ReadWrite);

                System.Net.HttpWebRequest httpReq;
                System.Net.HttpWebResponse httpRes;
                httpReq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(sourceURL);
                httpReq.AddRange((int)existLen);
                System.IO.Stream resStream;
                httpRes = (System.Net.HttpWebResponse)httpReq.GetResponse();
                resStream = httpRes.GetResponseStream();

                fileSize = httpRes.ContentLength;

                int byteSize;
                byte[] downBuffer = new byte[bufferSize];

                while ((byteSize = resStream.Read(downBuffer, 0, downBuffer.Length)) > 0)
                {
                    saveFileStream.Write(downBuffer, 0, byteSize);
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        public static bool DirectoryVisible(string path)
        {
            try
            {
                Directory.Exists(path);
                //var info = new DirectoryInfo(path);
                //info.GetAccessControl();
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        static string MailUser = "hrleave-india@betasystems.com";
        static string MailPass = "BtaCtsh589!";
        static string MailDomain = "betasystems.com";
        static string MailTo = "narendar.reddy@betasystems.com";
        static bool RedirectionCallback(string url)
        {
            // Return true if the URL is an HTTPS URL.
            return url.ToLower().StartsWith("https://");
        }
        public static void SendMailFromES()
        {
            ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2013_SP1);
            service.Credentials = new NetworkCredential(MailUser, MailPass, MailDomain);
            try
            {
                service.AutodiscoverUrl(MailUser, RedirectionCallback);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Convert.ToString(service.Url));
            }
            EmailMessage emailMessage = new EmailMessage(service);
            emailMessage.Subject = "TEST MAIL SUBJECT";
            emailMessage.Body = new MessageBody("<table><tr><td>Hi Admin" + ",</td><td></td><td></td></tr>" +
                "<tr><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr><tr>" +
                "<td>Name</td><td>:</td><td>" + "info.Name" + "</td></tr><tr><td></td><td></td><td></td></tr><tr><td>Email</td><td>:</td><td>" + "info.EmailId" 
                + "</td></tr><tr><td></td><td></td><td></td></tr><tr><td>Details</td><td>:</td><td>" + "info.Details" + 
                "</td></tr><tr><td></td><td></td><td></td></tr><tr><td>Date</td><td>:</td><td>" + DateTime.Now.ToString() + "</td></tr></table>");
            emailMessage.ToRecipients.Add(MailTo);
            emailMessage.SendAndSaveCopy();
        }

        public static DataTable Complexity()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "High");
            dt.Rows.Add(2, "Low");
            return dt;
        }
        public static DataTable Severity()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "Major");
            dt.Rows.Add(2, "Minor");
            return dt;
        }
        public static DataTable TestcaseType()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "Positive");
            dt.Rows.Add(2, "Negative");
            return dt;
        }
        public static DataTable TestStatus()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(bool));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(false, "Failed");
            dt.Rows.Add(true, "Passed");
            return dt;
        }
        public static string GetRTFFormat(string Plaintext)
        {
            string st = string.Empty;
            try
            {
                using (RichTextBox rtf = new RichTextBox())
                {
                    rtf.Text = Plaintext;
                    st = rtf.Rtf;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return st;
        }
    }
    class RowInfo
    {
        public RowInfo(GridView view, int rowHandle)
        {
            this.RowHandle = rowHandle;
            this.View = view;
        }
        public GridView View;
        public int RowHandle;
    }
}