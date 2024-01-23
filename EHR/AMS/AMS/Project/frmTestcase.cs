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
using DL;
using EL;
using log4net;

namespace EHR.Project
{
    public partial class frmTestcase : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = null;
        public bool ViewMode = false;
        frmProject frmparent = null;
        private bool NewMode = true;
        public frmTestcase(EProject _objEProject, frmProject _frmparent)
        {
            InitializeComponent();
            objEProject = _objEProject;
            frmparent = _frmparent;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewMode)
                    return;
                if (!dxValidationProvider1.Validate())
                    return;
                if (string.IsNullOrEmpty(txtTestSteps.Text))
                    return;
                if (string.IsNullOrEmpty(txtExpectedResult.Text))
                    return;
                objEProject.TestcaseName = txtTestcaseName.EditValue;
                objEProject.Severity = cmbSeverity.EditValue;
                objEProject.Complexity = cmbComplexity.EditValue;
                objEProject.TestcaseType = cmbTestcaseType.EditValue;
                objEProject.ComponentID = cmbComponent.EditValue;
                objEProject.RequirementID = cmbRequirement.EditValue;
                objEProject.ScenarioID = cmbScenario.EditValue;
                objEProject.TestSteps = txtTestSteps.RtfText;
                objEProject.ExpectedResult = txtExpectedResult.RtfText;
                objEProject.RegressionRequired = Convert.ToBoolean(chkRegressionRequired.CheckState);
                objDProject.SaveTestcase(objEProject);
                frmparent.gvtc.GridControl.DataSource = objEProject.dtTestcase;
                Utility.Setfocus(frmparent.gvtc, "TestcaseID", objEProject.TestcaseID);
                txtTestcaseName.Focus();
                if (NewMode)
                {
                    objEProject.TestcaseID = -1;
                    objEProject.TestcaseName = txtTestcaseName.EditValue = null;
                    objEProject.Severity = cmbSeverity.EditValue = null;
                    objEProject.Complexity = cmbComplexity.EditValue = null;
                    objEProject.TestcaseType = cmbTestcaseType.EditValue = null;
                    objEProject.ComponentID = cmbComponent.EditValue = null;
                    objEProject.RequirementID = cmbRequirement.EditValue = null;
                    objEProject.ScenarioID = cmbScenario.EditValue = null;
                    objEProject.TestSteps = txtTestSteps.RtfText = null;
                    objEProject.ExpectedResult = txtExpectedResult.RtfText = null;  
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void frmTestcase_Load(object sender, EventArgs e)
        {
            try
            {
                objDProject.GetComponentforDropDown(objEProject);
                cmbComponent.Properties.DataSource = objEProject.dtComponentfroDropDown;
                cmbComponent.Properties.ValueMember = "ComponentID";
                cmbComponent.Properties.DisplayMember = "ComponentName";

                cmbComplexity.Properties.DataSource = Utility.Complexity();
                cmbComplexity.Properties.ValueMember = "ID";
                cmbComplexity.Properties.DisplayMember = "Name";

                cmbSeverity.Properties.DataSource = Utility.Severity();
                cmbSeverity.Properties.ValueMember = "ID";
                cmbSeverity.Properties.DisplayMember = "Name";

                cmbTestcaseType.Properties.DataSource = Utility.TestcaseType();
                cmbTestcaseType.Properties.ValueMember = "ID";
                cmbTestcaseType.Properties.DisplayMember = "Name";

                if (Convert.ToInt32(objEProject.TestcaseID) > 0)
                {
                    txtTestcaseName.EditValue = objEProject.TestcaseName;
                    cmbComponent.EditValue = objEProject.ComponentID;
                    cmbRequirement.EditValue = objEProject.RequirementID;
                    cmbScenario.EditValue = objEProject.ScenarioID;
                    cmbComplexity.EditValue = objEProject.Complexity;
                    cmbSeverity.EditValue = objEProject.Severity;
                    cmbTestcaseType.EditValue = objEProject.TestcaseType;
                    chkRegressionRequired.EditValue = objEProject.RegressionRequired;
                    objDProject.GetTestcaseDescription(objEProject);
                    txtTestSteps.RtfText = Convert.ToString(objEProject.TestSteps);
                    txtExpectedResult.RtfText = Convert.ToString(objEProject.ExpectedResult);
                    NewMode = false;
                    this.Text = "Edit Testcase";
                }
                else
                {
                    cmbComponent.EditValue = objEProject.ComponentID;
                    cmbRequirement.EditValue = objEProject.RequirementID;
                    cmbScenario.EditValue = objEProject.ScenarioID;
                    this.Text = "New Testcase";
                }
                if (ViewMode)
                    btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void cmbComponent_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbComponent.EditValue == null)
                    return;
                objEProject.ComponentID = cmbComponent.EditValue;
                objDProject.GetRequirementForDropDown(objEProject);
                cmbRequirement.Properties.DataSource = objEProject.dtRequirementforDropDown;
                cmbRequirement.Properties.ValueMember = "RequirementID";
                cmbRequirement.Properties.DisplayMember = "RequirementName";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void cmbRequirement_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRequirement.EditValue == null)
                    return;
                objEProject.RequirementID = cmbRequirement.EditValue;
                objDProject.GetScenarioForDropDown(objEProject);
                cmbScenario.Properties.DataSource = objEProject.dtScenarioforDropDown;
                cmbScenario.Properties.ValueMember = "ScenarioID";
                cmbScenario.Properties.DisplayMember = "ShortDescription";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave_Click(null, null);
                if (!NewMode)
                {
                    frmparent.gvtc.MovePrev();
                    GetTestcaseDetails();
                }
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
                if (!NewMode)
                {
                    frmparent.gvtc.MoveNext();
                    GetTestcaseDetails();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void frmTestcase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
                btnPrevious_Click(null, null);
            else if (e.KeyCode == Keys.PageDown)
                btnNext_Click(null, null);

        }
        private void GetTestcaseDetails()
        {
            try
            {
                if (frmparent.gvtc.FocusedRowHandle >= 0)
                {
                    objEProject.TestcaseID = frmparent.gvtc.GetFocusedRowCellValue("TestcaseID");
                    txtTestcaseName.EditValue = objEProject.TestcaseName= frmparent.gvtc.GetFocusedRowCellValue("TestcaseName");
                    cmbComponent.EditValue = objEProject.ComponentID = frmparent.gvtc.GetFocusedRowCellValue("ComponentID");
                    cmbRequirement.EditValue = objEProject.RequirementID = frmparent.gvtc.GetFocusedRowCellValue("RequirementID");
                    cmbScenario.EditValue = objEProject.ScenarioID = frmparent.gvtc.GetFocusedRowCellValue("ScenarioID");
                    cmbComplexity.EditValue = objEProject.Complexity = frmparent.gvtc.GetFocusedRowCellValue("Complexity");
                    cmbSeverity.EditValue = objEProject.Severity = frmparent.gvtc.GetFocusedRowCellValue("Severity");
                    cmbTestcaseType.EditValue = objEProject.TestcaseType = frmparent.gvtc.GetFocusedRowCellValue("TestcaseType");
                    chkRegressionRequired.EditValue = objEProject.RegressionRequired = frmparent.gvtc.GetFocusedRowCellValue("RegressionRequired");
                    objDProject.GetTestcaseDescription(objEProject);
                    txtTestSteps.RtfText = Convert.ToString(objEProject.TestSteps);
                    txtExpectedResult.RtfText = Convert.ToString(objEProject.ExpectedResult);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}