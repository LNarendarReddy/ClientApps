using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR.Project
{
    public partial class frmViewTestCases : DevExpress.XtraEditors.XtraForm
    {
        DataSet ds = null;
        object ProjectPhaseID = null;
        public frmViewTestCases(DataSet _ds,object _ProjectPhaseID)
        {
            InitializeComponent();
            ds = _ds.Copy();
            ProjectPhaseID = _ProjectPhaseID;
            gcComponent.DataSource = ds.Tables[0];
            gcRequirement.DataSource = ds.Tables[1];
            gcScenario.DataSource = ds.Tables[2];
            gcTestcase.DataSource = ds.Tables[3];
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                SplashScreenManager.Default.SetWaitFormDescription("                  Importing ...");
                foreach (DataRow dr in ds.Tables[2].Rows)
                {
                    dr["ScenarioDescription"] = Utility.GetRTFFormat(Convert.ToString(dr["ScenarioDescription"]));
                }

                foreach (DataRow dr in ds.Tables[3].Rows)
                {
                    dr["TestSteps"] = Utility.GetRTFFormat(Convert.ToString(dr["TestSteps"]));
                    dr["Expectedresult"] = Utility.GetRTFFormat(Convert.ToString(dr["Expectedresult"]));
                }

                new DProject().ImportTestCases(ProjectPhaseID
                            , ds.Tables[0], ds.Tables[1]
                            , ds.Tables[2], ds.Tables[3], Utility.UserID);
                SplashScreenManager.CloseForm();
                this.Close();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}