using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AMSService
{
    public partial class AMSService : ServiceBase
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private System.Timers.Timer timer1;
        public AMSService()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            try
            {
                
                timer1 = new System.Timers.Timer();
                double inter = (double)GetNextInterval();
                timer1.Interval = inter;
                timer1.Elapsed += new ElapsedEventHandler(ServiceTimer_Tick);
                timer1.AutoReset = true;
                timer1.Enabled = true;
                Log.Info("Timer Intialized successfully");
                SendMailService.SendEmail("AMS Service Status",
                    Utility.stParagraphBoldstart + "AMS Service Started!" + Utility.stParagraphend,
                    Utility.stMailIDs);
                Log.Info("Service start status mail sent to " + Utility.stMailIDs);
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
            Log.Info("Service started successfully");
        }
        protected override void OnStop()
        {
            try
            {
                Log.Info("Service stop process started");
                SendMailService.SendEmail("AMS Service Status",
                 Utility.stParagraphBoldstart + "AMS Service Stopped!" + Utility.stParagraphend +
                 Utility.stParagraphstart + "Please check the issue as soon as possible." + Utility.stParagraphend,
                Utility.stMailIDs);
                Log.Info("Service stop status mail sent to " + Utility.stMailIDs);
                timer1.AutoReset = false;
                timer1.Enabled = false;
                Log.Info("Timer reset done");
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        private double GetNextInterval()
        {
            TimeSpan ts = new TimeSpan();
            try
            {
                DataAccess.GetServiceConfig();
                Log.Info("Service Configuration received from server");
                DateTime t = DateTime.Parse(Utility.timeString);
                ts = t - System.DateTime.Now;
                if (ts.TotalMilliseconds < 0)
                {
                    ts = t.AddDays(1) - System.DateTime.Now;
                }
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
            return ts.TotalMilliseconds;
        }
        private void SetTimer()
        {
            try
            {
                double inter = (double)GetNextInterval();
                timer1.Interval = inter;
                timer1.Start();
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
        }
        private void ServiceTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                timer1.Stop();
                SendMailService.SendEmail("AMS Job Status",
                    Utility.stParagraphBoldstart + "AMS Job Started!" + Utility.stParagraphend,
                    Utility.stMailIDs);
                DataAccess.UpdateLeaveStatus();
                Log.Info("Leave status updated to Availed");
                SendMailService.SendCompOffExpiryNotifications();
                Log.Info("Comp off expiry notificaitons job completed");
                SendMailService.SendMissedTaskNotifications();
                Log.Info("Missed task entry entry notifiations job completed");
                SendMailService.SendMissedCompOffNotifications();
                Log.Info("Missed comp off application notifications job completed");
                SendMailService.SendMissedTimesheetNotifications();
                Log.Info("Missed Leave application notifications job completed");
                SendMailService.SendLeaveBalanceNotifications();
                Log.Info("Leave balance notifications job completed");
                SendMailService.SendCFLeaveUpdate();
                Log.Info("Carry forward leave update job completed");
                System.Threading.Thread.Sleep(1000000);
                SetTimer();
                Log.Info("New intervel setting to timer is done");
                SendMailService.SendEmail("AMS Job Status",
                    Utility.stParagraphBoldstart + "AMS Job Completed!" + Utility.stParagraphend,
                    Utility.stMailIDs);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }
    }
}
