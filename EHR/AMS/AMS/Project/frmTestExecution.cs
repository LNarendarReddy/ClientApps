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
using log4net;
using DL;
using EL;
using DevExpress.XtraGrid.Views.Grid;

namespace EHR.Project
{
    public partial class frmTestExecution : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = null;
        public GridView gv{get { return gvTestcase; }}
        public frmTestExecution(EProject _objEProject)
        {
            InitializeComponent();
            objEProject = _objEProject;
            this.Text = objEProject.ProjectName + " " + objEProject.PhaseName + " " + objEProject.BuildVersion + " Test Execution";
        }
        private void frmTestExecution_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTestStatus.DataSource = Utility.TestStatus();
                cmbTestStatus.ValueMember = "ID";
                cmbTestStatus.DisplayMember = "Name";
                objDProject.GetTestcaseForQA(objEProject);
                gcTestcase.DataSource = objEProject.dtTestcaseForQA;
            }
            catch (Exception ex){}
        }
        private void btnViewTestcase_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvTestcase.FocusedRowHandle >= 0)
                {
                    EProject objEProject = new EProject();
                    frmViewTestcase obj = new frmViewTestcase(gvTestcase.GetFocusedRowCellValue("TestExecutionID"), this);
                    obj.ShowIcon = false;
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();
                }
            }
            catch (Exception ex) { }
        }
        private void btnViewLog_Click(object sender, EventArgs e)
        {
           if(gvTestcase.FocusedRowHandle >= 0)
            {
                objEProject.TestExecutionID = gvTestcase.GetFocusedRowCellValue("TestExecutionID");
                objDProject.GetTestExecutionLog(objEProject);
                frmTestExecutionLog obj = new frmTestExecutionLog(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
        }
    }
}