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
using log4net;
using DevExpress.XtraSplashScreen;

namespace EHR
{
    public partial class frmDashBoard : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        ETimeSheet objETimeSheet = new ETimeSheet();
        DTimeSheet objDTimeSheet = new DTimeSheet();
        bool _OnLoad = false;
        public frmDashBoard()
        {
            InitializeComponent();
            _OnLoad = true;
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                dtpSelectedDate.DateTime = DateTime.Now;
                objETimeSheet.SelectedMonth = dtpSelectedDate.DateTime;
                objDTimeSheet.GetDashboard(objETimeSheet);
                gcDashBoard.DataSource = objETimeSheet.dtDashoard;
                _OnLoad = false;
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void dtpSelectedDate_EditValueChanged(object sender, EventArgs e)
        {
            if (_OnLoad)
                return;
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Please wait...");
                objETimeSheet.SelectedMonth = dtpSelectedDate.DateTime;
                objDTimeSheet.GetDashboard(objETimeSheet);
                gcDashBoard.DataSource = objETimeSheet.dtDashoard;
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            try
            {
                if(Utility.RoleID == 1 || Utility.RoleID == 3 || Utility.RoleID == 6 || Utility.RoleID == 7)
                {
                    gcLogin.Visible = true;
                    gcLogout.Visible = true;
                    gcGoingforlunch.Visible = true;
                    gcBackFromLunch.Visible = true;
                    gcGoingforbreak.Visible = true;
                    gcBackfromBreak.Visible = true;
                    gcTotalSentTime.Visible = true;
                    gcLunchTime.Visible = true;
                    gcBreakTime.Visible = true;
                }
            }
            catch (Exception ex){ Log.Error(ex.Message, ex); }
        }
    }
}