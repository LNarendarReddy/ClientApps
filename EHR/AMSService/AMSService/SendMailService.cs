using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AMSService
{
    public class SendMailService
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void SendEmail(string Subject, string Body, string ToEmail)
        {
            MailMessage msg = new MailMessage();
            try
            {
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
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
            finally
            {
                msg.Dispose();
                msg = null;
            }
        }
        public static void SendCompOffExpiryNotifications()
        {
            try
            {
                Log.Info("Comp off status updated started");
                DataSet ds = DataAccess.UpdateCompOffStatus();
                Log.Info("Comp off status updated completed");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = null;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dv = ds.Tables[1].DefaultView;
                        dv.RowFilter = "EmployeeID = " + Convert.ToString(dr["EmployeeID"]);
                        string stMailIds = Convert.ToString(dr["EMail"]);
                        string stSubject = "Compensatory Off Expired";
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Compensatory Off Expired!" + Utility.stParagraphend;
                        DataTable dtTemp = dv.ToTable();
                        foreach (DataRow drDate in dtTemp.Rows)
                        {
                            DateTime dtWorkedDate = DateTime.Now;
                            if (DateTime.TryParse(Convert.ToString(drDate["LeaveDate"]), out dtWorkedDate))
                                stBody += Utility.stParagraphstart + "Worked Date : " + dtWorkedDate.ToString("dd/MM/yyyy") + Utility.stParagraphend;
                            else
                                stBody += Utility.stParagraphstart + "Worked Date : " + Convert.ToString(drDate["LeaveDate"]) + Utility.stParagraphend;
                        }
                        SendEmail(stSubject, stBody, stMailIds);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        public static void SendMissedTaskNotifications()
        {
            try
            {
                Log.Info("Retrieving Missed task entry data started");
                DataSet ds = DataAccess.GetMissedTaskEntry();
                Log.Info("Retrieving Missed task entry data received");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = null;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dv = ds.Tables[1].DefaultView;
                        dv.RowFilter = "EmployeeID = " + Convert.ToString(dr["EmployeeID"]);
                        string stMailIds = string.Empty;
                        stMailIds += Convert.ToString(dr["EMail"]) + ",";
                        stMailIds += Convert.ToString(dr["ReportingLeadEmail"]) + ",";
                        stMailIds += Convert.ToString(dr["HRMail"]);
                        string stSubject = "Logged hours and Task hours Mismatch - " + Convert.ToString(dr["FullName"]);
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Logged hours and task hours mismatch in below dates" + Utility.stParagraphend;
                        DataTable dtTemp = dv.ToTable();
                        foreach (DataRow drDate in dtTemp.Rows)
                        {
                            DateTime dtWorkedDate = DateTime.Now;
                            if (DateTime.TryParse(Convert.ToString(drDate["LogDate"]), out dtWorkedDate))
                                stBody += Utility.stParagraphstart + "Worked Date : " + dtWorkedDate.ToString("dd/MM/yyyy") + Utility.stParagraphend;
                            else
                                stBody += Utility.stParagraphstart + "Worked Date : " + Convert.ToString(drDate["LogDate"]) + Utility.stParagraphend;
                        }
                        stBody += Utility.stParagraphstart + "Please followup with HR and resolve them." + Utility.stParagraphend;
                        SendEmail(stSubject, stBody, stMailIds);
                    }
                }
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
        }
        public static void SendMissedTimesheetNotifications()
        {
            try
            {
                Log.Info("Retrieving Missed timesheet data started");
                DataSet ds = DataAccess.GetMissedTimesheet();
                Log.Info("Retrieving Missed timesheet data completed");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = null;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dv = ds.Tables[1].DefaultView;
                        dv.RowFilter = "EmployeeID = " + Convert.ToString(dr["EmployeeID"]);
                        string stMailIds = string.Empty;
                        stMailIds += Convert.ToString(dr["EMail"]) + ",";
                        stMailIds += Convert.ToString(dr["ReportingLeadEmail"]) + ",";
                        stMailIds += Convert.ToString(dr["HRMail"]);
                        string stSubject = "Leave Application Reminder - " + Convert.ToString(dr["FullName"]);
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Leave application reminder for below dates" + Utility.stParagraphend;
                        DataTable dtTemp = dv.ToTable();
                        foreach (DataRow drDate in dtTemp.Rows)
                        {
                            DateTime dtWorkedDate = DateTime.Now;
                            if (DateTime.TryParse(Convert.ToString(drDate["DayDate"]), out dtWorkedDate))
                                stBody += Utility.stParagraphstart + "Leave Date : " + dtWorkedDate.ToString("dd/MM/yyyy")
                                    + Utility.stParagraphend;
                            else
                                stBody += Utility.stParagraphstart + "Leave Date : " + Convert.ToString(drDate["DayDate"])
                                    + Utility.stParagraphend;
                        }
                        stBody += Utility.stParagraphstart + "Apply for leave at the earliest." + Utility.stParagraphend;
                        SendEmail(stSubject, stBody, stMailIds);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        public static void SendMissedCompOffNotifications()
        {
            try
            {
                Log.Info("Retrieving Missed comp off data started");
                DataSet ds = DataAccess.GetMissedcompoff();
                Log.Info("Retrieving Missed comp off data completed");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = null;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dv = ds.Tables[1].DefaultView;
                        dv.RowFilter = "EmployeeID = " + Convert.ToString(dr["EmployeeID"]);
                        string stMailIds = string.Empty;
                        stMailIds += Convert.ToString(dr["EMail"]) + ",";
                        stMailIds += Convert.ToString(dr["ReportingLeadEmail"]) + ",";
                        stMailIds += Convert.ToString(dr["HRMail"]);
                        string stSubject = "Comp off Application Reminder - " + Convert.ToString(dr["FullName"]);
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Comp off application reminder for below dates" + Utility.stParagraphend;
                        DataTable dtTemp = dv.ToTable();
                        foreach (DataRow drDate in dtTemp.Rows)
                        {
                            DateTime dtWorkedDate = DateTime.Now;
                            if (DateTime.TryParse(Convert.ToString(drDate["DayDate"]), out dtWorkedDate))
                                stBody += Utility.stParagraphstart + "Worked Date : " + dtWorkedDate.ToString("dd/MM/yyyy")
                                    + Utility.stParagraphend;
                            else
                                stBody += Utility.stParagraphstart + "Worked Date : " + Convert.ToString(drDate["DayDate"])
                                    + Utility.stParagraphend;
                        }
                        stBody += Utility.stParagraphstart + "Apply for comp off at the earliest." + Utility.stParagraphend;
                        SendEmail(stSubject, stBody, stMailIds);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        public static void SendLeaveBalanceNotifications()
        {
            try
            {
                Log.Info("Retrieving leave balance data started");
                DataSet ds = DataAccess.GetLeaveBalance();
                Log.Info("Retrieving leave balance data completed");
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    DataView dv = null;
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dv = ds.Tables[1].DefaultView;
                        dv.RowFilter = "EmployeeID = " + Convert.ToString(dr["EmployeeID"]);
                        string stMailIds = string.Empty;
                        stMailIds += Convert.ToString(dr["EMail"]);
                        string stSubject = "Leave Balance - " + Convert.ToString(dr["FullName"]);
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Leave balance as on : " + DateTime.Now.ToString("dd/MM/yyyy")
                            + Utility.stParagraphend;
                        DataTable dtTemp = dv.ToTable();

                        stBody += Utility.stTableStart;
                        stBody += Utility.stTableHeaderStart;
                        stBody += Utility.stCellHeaderLeftStart + "Leave Type" + Utility.stCellHeaderEnd;
                        stBody += Utility.stCellHeaderCenterStart + "Total Leaves For the Year" + Utility.stCellHeaderEnd;
                        stBody += Utility.stCellHeaderCenterStart + "Pro - Rata leaves as on Month" + Utility.stCellHeaderEnd;
                        stBody += Utility.stCellHeaderCenterStart + "Leaves Availed" + Utility.stCellHeaderEnd;
                        stBody += Utility.stCellHeaderCenterStart + "Leave Balance" + Utility.stCellHeaderEnd;
                        stBody += Utility.stRowEnd;

                        foreach (DataRow drData in dtTemp.Rows)
                        {
                            stBody += Utility.stRowStart;
                            stBody += Utility.stCellRowLeftStart + drData["LeaveTypeName"] + Utility.stCellRowEnd;
                            stBody += Utility.stCellRowCenterStart + drData["TotalLeaves"] + Utility.stCellRowEnd;
                            stBody += Utility.stCellRowCenterStart + drData["ProrataLeaves"] + Utility.stCellRowEnd;
                            stBody += Utility.stCellRowCenterStart + drData["LeavesAvailed"] + Utility.stCellRowEnd;
                            stBody += Utility.stCellRowCenterStart + drData["LeaveBalance"] + Utility.stCellRowEnd;
                            stBody += Utility.stRowEnd;
                        }
                        stBody += Utility.stTableEnd;
                        stBody += Utility.stParagraphstart + "Please getback to HR in case of deviation." + Utility.stParagraphend;
                        SendEmail(stSubject, stBody, stMailIds);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        public static void SendCFLeaveUpdate()
        {
            try
            {
                Log.Info("updating CF leaves started");
                DataTable dt = DataAccess.UpdateCFLeaves();
                Log.Info("updating CF leaves completed");
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string stMailIds = string.Empty;
                        stMailIds += Convert.ToString(dr["EMail"]);
                        string stSubject = "Carry forward leaves updated";
                        string stBody = string.Empty;
                        stBody = Utility.stParagraphBoldstart + "Carry forward leaves updated. Please check your leave balance" 
                            + Utility.stParagraphend;
                        stBody += Utility.stParagraphstart + "Please get back to HR in case of deviation" + Utility.stParagraphend;
                        SendEmail(stSubject, stBody, stMailIds);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
    }
}
