using System;

using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using DL;
using System;
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

namespace HMS
{
    public class Utility
    {        
        public static int UserID = 0;
        public static string UserName = string.Empty;
        public static string UserFullName = string.Empty;
        public static string Password = string.Empty;

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

        public static byte[] Imagedata = null;

        public static DateTime dtSelectedDate;
        public static void ShowError(Exception ex)
        {
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Setfocus(GridView view, string ColumnName, int Value)
        {
            try
            {
                if (Value > -1)
                {
                    int rowHandle = view.LocateByValue(ColumnName, Value);
                    if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                        view.FocusedRowHandle = rowHandle;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private string EncryptInner(string input)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input)));
        }

        private byte[] Encrypt(byte[] input)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("CategisOTTO", new byte[] { 0x43, 0x87, 0x23, 0x72, 0x45, 0x56, 0x68, 0x14, 0x62, 0x84 });
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
        }

        public static string Decrypt(string input)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
        }

        private static byte[] Decrypt(byte[] input)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes("CategisOTTO", new byte[] { 0x43, 0x87, 0x23, 0x72, 0x45, 0x56, 0x68, 0x14, 0x62, 0x84 });
            MemoryStream ms = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = pdb.GetBytes(aes.KeySize / 8);
            aes.IV = pdb.GetBytes(aes.BlockSize / 8);
            CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(input, 0, input.Length);
            cs.Close();
            return ms.ToArray();
        }

        public static string Encrypt(string input)
        {
            Utility sec = new Utility();
            return sec.EncryptInner(input);
        }

        public static void SendEmail(string Subject, string Body, string filepath, XtraForm Parent)
        {
            MailMessage msg = new MailMessage();
            try
            {
                SplashScreenManager.ShowForm(Parent, typeof(frmSpinner), true, true, false);
                msg.From = new MailAddress("gyanasofts@gmail.com");
                msg.To.Add(FromEmail);
                msg.Subject = Subject;
                msg.Body = Body;
                msg.Attachments.Add(new Attachment(filepath));

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "gyanasofts@gmail.com";
                ntcd.Password = "31153115";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
                SplashScreenManager.CloseForm(false);
                XtraMessageBox.Show("Your Mail is Sent");
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
            ResourceManager rm = new ResourceManager("PMS.Language.H", Assembly.GetExecutingAssembly());
            return rm.GetString(stVal);
        }
        
    }
}
