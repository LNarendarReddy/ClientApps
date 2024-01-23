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

namespace EHR.Project
{
    public partial class frmViewTestcase : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = new EProject();
        frmTestExecution frmparent = null;
        private object TestExecutionID = null;
        public frmViewTestcase(object _TestExecutionID, frmTestExecution _frmparent)
        {
            InitializeComponent();
            TestExecutionID = _TestExecutionID;
            frmparent = _frmparent;
        }
        private void frmViewTestcase_Load(object sender, EventArgs e)
        {
            try
            {
                cmbComplexity.Properties.DataSource = Utility.Complexity();
                cmbComplexity.Properties.ValueMember = "ID";
                cmbComplexity.Properties.DisplayMember = "Name";

                cmbSeverity.Properties.DataSource = Utility.Severity();
                cmbSeverity.Properties.ValueMember = "ID";
                cmbSeverity.Properties.DisplayMember = "Name";

                cmbTestcaseType.Properties.DataSource = Utility.TestcaseType();
                cmbTestcaseType.Properties.ValueMember = "ID";
                cmbTestcaseType.Properties.DisplayMember = "Name";
                GetTestcaseDetails(TestExecutionID);
                //txtTestSteps.Document.Sections[0].Margins.Left = 5;
                //txtTestSteps.Document.Sections[0].Margins.Top = 5;
                //txtTestSteps.Document.Sections[0].Margins.Bottom = 5;
                //txtTestSteps.Document.Sections[0].Margins.Right = 5;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                 objEProject.Testdata = txtTestData.EditValue;
                objEProject.TestStatus = rgTestStatus.EditValue;
                objEProject.Comments = txtComments.EditValue;
                objEProject.UserID = Utility.UserID;
                objDProject.UpdateTestcase(objEProject);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave_Click(null, null);
                frmparent.gv.MovePrev();
                GetTestcaseDetails(frmparent.gv.GetFocusedRowCellValue("TestExecutionID"));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave_Click(null, null);
                frmparent.gv.MoveNext();
                GetTestcaseDetails(frmparent.gv.GetFocusedRowCellValue("TestExecutionID"));
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void GetTestcaseDetails(object TID)
        {
            try
            {
                objEProject.TestExecutionID = TID;
                objDProject.GetTestcaseDetails(objEProject);
                txtTestcaseName.EditValue = objEProject.TestcaseName;
                cmbComplexity.EditValue = objEProject.Complexity;
                cmbSeverity.EditValue = objEProject.Severity;
                cmbTestcaseType.EditValue = objEProject.TestcaseType;
                cmbComponent.EditValue = objEProject.ComponentID;
                cmbRequirement.EditValue = objEProject.RequirementID;
                cmbScenario.EditValue = objEProject.ScenarioID;
                txtTestData.EditValue = objEProject.Testdata;
                rgTestStatus.EditValue = objEProject.TestStatus;
                txtComments.EditValue = objEProject.Comments;
                txtTestSteps.RtfText = Convert.ToString(objEProject.TestSteps);
                txtExpectedResult.RtfText = Convert.ToString(objEProject.ExpectedResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frmViewTestcase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
                btnPrevious_Click(null, null);
            else if (e.KeyCode == Keys.PageDown)
                btnNext_Click(null, null);
        }
    }
}