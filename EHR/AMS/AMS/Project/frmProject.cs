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
using DevExpress.Utils.Menu;
using EHR.Project.Reports;
using DevExpress.XtraReports.UI;

namespace EHR.Project
{
    public partial class frmProject : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = new EProject();
        public GridView gvcomp { get { return gvComponent; } }
        public GridView gvReq { get { return gvRequirement; } }
        public GridView gvSce { get { return gvScenario; } }
        public GridView gvtc { get { return gvTestcase; } }
        public frmProject(object _ProjectID,object stProjectName)
        {
            InitializeComponent();
            objEProject.ProjectID = _ProjectID;
            objEProject.ProjectName = stProjectName;
            this.Text = Convert.ToString(stProjectName);
        }
        private void frmProject_Load(object sender, EventArgs e)
        {
            try
            {
                if (objEProject.ProjectID != null)
                {
                    objDProject.GetProjectPhase(objEProject);
                    cmbPhase.Properties.DataSource = objEProject.dtPhase;
                    cmbPhase.Properties.DisplayMember = "PhaseName";
                    cmbPhase.Properties.ValueMember = "ProjectPhaseID";

                    DataTable table = cmbPhase.Properties.DataSource as DataTable;
                    foreach (DataRow dr in table.Rows)
                    {
                        if (Convert.ToBoolean(dr["IsActive"]) == true)
                        {
                            cmbPhase.EditValue = dr["ProjectPhaseID"];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                frmProjectTeam obj = new frmProjectTeam(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if(objEProject.IsSave)
                {
                    gcTeam.DataSource = objEProject.dtTeam;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void cmbPhase_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue != null)
                {
                    objEProject.ProjectPhaseID = cmbPhase.EditValue;
                    objDProject.GetProjectTeam(objEProject);
                    gcTeam.DataSource = objEProject.dtTeam;
                    objDProject.GetComponent(objEProject);
                    gcComponent.DataSource = objEProject.dtComponent;
                    objDProject.GetRequirement(objEProject);
                    gcRequirement.DataSource = objEProject.dtRequirement;
                    objDProject.GetScenario(objEProject);
                    gcScenario.DataSource = objEProject.dtScenario;
                    objDProject.GetTestcase(objEProject);
                    gcTestcase.DataSource = objEProject.dtTestcase;
                    objDProject.GetDevBuild(objEProject);
                    gcBuilds.DataSource = objEProject.dtDevBuilds;
                    objDProject.GetQABuild(objEProject);
                    gcQAbuilds.DataSource = objEProject.dtQABuilds;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnNewComponent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.ComponentID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmComponent obj = new frmComponent(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.ComponentName = string.Empty;
                objEProject.ComponentDescription = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnViewComponent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvComponent.FocusedRowHandle <0)
                    return;
                objEProject.ComponentID = gvComponent.GetFocusedRowCellValue("ComponentID");
                objEProject.ComponentName = gvComponent.GetFocusedRowCellValue("ComponentName");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmComponent obj = new frmComponent(objEProject,this);
                obj.ViewMode = true;
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.ComponentName = string.Empty;
                objEProject.ComponentDescription = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnEditComponent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.ComponentID = gvComponent.GetFocusedRowCellValue("ComponentID");
                objEProject.ComponentName = gvComponent.GetFocusedRowCellValue("ComponentName");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmComponent obj = new frmComponent(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.ComponentName = string.Empty;
                objEProject.ComponentDescription = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            try
            {
                if(gvComponent.FocusedRowHandle >= 0)
                {
                    objEProject.ComponentID = gvComponent.GetFocusedRowCellValue("ComponentID");
                    objEProject.ProjectPhaseID = cmbPhase.EditValue;
                    objEProject.UserID = Utility.UserID;
                    objDProject.DeleteComponent(objEProject);
                    gvComponent.DeleteRow(gvComponent.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnChangeLogComponent_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvComponent.FocusedRowHandle >= 0)
                {
                    objEProject.ID = gvComponent.GetFocusedRowCellValue("ComponentID");
                    objEProject.Type = 1;
                    objDProject.GetChangeLog(objEProject);
                    frmChangeLog obj = new frmChangeLog(objEProject);
                    obj.ShowIcon = false;
                    obj.ShowInTaskbar = false;  
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnNewRequirement_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.RequirementID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmRequirement obj = new frmRequirement(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcRequirement.DataSource = objEProject.dtRequirement;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnViewRequirement_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvRequirement.FocusedRowHandle < 0)
                    return;
                objEProject.RequirementID = gvRequirement.GetFocusedRowCellValue("RequirementID");
                objEProject.RequirementName = gvRequirement.GetFocusedRowCellValue("RequirementName");
                objEProject.RDescription = gvRequirement.GetFocusedRowCellValue("RDescription");
                objEProject.ComponentID = gvRequirement.GetFocusedRowCellValue("ComponentID");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmRequirement obj = new frmRequirement(objEProject,this);
                obj.ViewMode = true;
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.RequirementName = string.Empty;
                objEProject.RDescription = string.Empty;
                objEProject.Description = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnEditRequirement_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvRequirement.FocusedRowHandle < 0)
                    return;
                objEProject.RequirementID = gvRequirement.GetFocusedRowCellValue("RequirementID");
                objEProject.RequirementName = gvRequirement.GetFocusedRowCellValue("RequirementName");
                objEProject.RDescription = gvRequirement.GetFocusedRowCellValue("RDescription");
                objEProject.ComponentID = gvRequirement.GetFocusedRowCellValue("ComponentID");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmRequirement obj = new frmRequirement(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.RequirementName = string.Empty;
                objEProject.RDescription = string.Empty;
                objEProject.Description = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnViewChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvRequirement.FocusedRowHandle >= 0)
                {
                    objEProject.ID = gvRequirement.GetFocusedRowCellValue("RequirementID");
                    objEProject.Type = 2;
                    objDProject.GetChangeLog(objEProject);
                    frmChangeLog obj = new frmChangeLog(objEProject);
                    obj.ShowIcon = false;
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnNewScenario_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject. ScenarioID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmScenario obj = new frmScenario(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcScenario.DataSource = objEProject.dtScenario;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnScenarioView_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvScenario.FocusedRowHandle < 0)
                    return;
                objEProject.ScenarioID = gvScenario.GetFocusedRowCellValue("ScenarioID");
                objEProject.SShortDescription = gvScenario.GetFocusedRowCellValue("ShortDescription");
                objEProject.RequirementID = gvScenario.GetFocusedRowCellValue("RequirementID");
                objEProject.ComponentID = gvScenario.GetFocusedRowCellValue("ComponentID");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmScenario obj = new frmScenario(objEProject,this);
                obj.ViewMode = true;
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.SShortDescription = string.Empty;
                objEProject.SLongDescription = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnEditScenario_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvScenario.FocusedRowHandle < 0)
                    return;
                objEProject.ScenarioID = gvScenario.GetFocusedRowCellValue("ScenarioID");
                objEProject.SShortDescription = gvScenario.GetFocusedRowCellValue("ShortDescription");
                objEProject.RequirementID = gvScenario.GetFocusedRowCellValue("RequirementID");
                objEProject.ComponentID = gvScenario.GetFocusedRowCellValue("ComponentID");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmScenario obj = new frmScenario(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.SShortDescription = string.Empty;
                objEProject.SLongDescription = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnChangeLogScenario_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvScenario.FocusedRowHandle >= 0)
                {
                    objEProject.ID = gvScenario.GetFocusedRowCellValue("ScenarioID");
                    objEProject.Type = 3;
                    objDProject.GetChangeLog(objEProject);
                    frmChangeLog obj = new frmChangeLog(objEProject);
                    obj.ShowIcon = false;
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnNewTestcase_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.TestcaseID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmTestcase obj = new frmTestcase(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcTestcase.DataSource = objEProject.dtTestcase;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnViewTestcase_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvTestcase.FocusedRowHandle < 0)
                    return;
                objEProject.TestcaseID = gvTestcase.GetFocusedRowCellValue("TestcaseID");
                objEProject.TestcaseName = gvTestcase.GetFocusedRowCellValue("TestcaseName");
                objEProject.ComponentID = gvTestcase.GetFocusedRowCellValue("ComponentID");
                objEProject.RequirementID = gvTestcase.GetFocusedRowCellValue("RequirementID");
                objEProject.ScenarioID = gvTestcase.GetFocusedRowCellValue("ScenarioID");
                objEProject.Complexity = gvTestcase.GetFocusedRowCellValue("Complexity");
                objEProject.Severity = gvTestcase.GetFocusedRowCellValue("Severity");
                objEProject.TestcaseType = gvTestcase.GetFocusedRowCellValue("TestcaseType");
                objEProject.RegressionRequired = gvTestcase.GetFocusedRowCellValue("RegressionRequired");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmTestcase obj = new frmTestcase(objEProject,this);
                obj.ViewMode = true;
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.TestSteps = string.Empty;
                objEProject.ExpectedResult = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnEditTestcase_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvTestcase.FocusedRowHandle < 0)
                    return;
                objEProject.TestcaseID = gvTestcase.GetFocusedRowCellValue("TestcaseID");
                objEProject.TestcaseName = gvTestcase.GetFocusedRowCellValue("TestcaseName");
                objEProject.ComponentID = gvTestcase.GetFocusedRowCellValue("ComponentID");
                objEProject.RequirementID = gvTestcase.GetFocusedRowCellValue("RequirementID");
                objEProject.ScenarioID = gvTestcase.GetFocusedRowCellValue("ScenarioID");
                objEProject.Complexity = gvTestcase.GetFocusedRowCellValue("Complexity");
                objEProject.Severity = gvTestcase.GetFocusedRowCellValue("Severity");
                objEProject.TestcaseType = gvTestcase.GetFocusedRowCellValue("TestcaseType");
                objEProject.RegressionRequired = gvTestcase.GetFocusedRowCellValue("RegressionRequired");
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmTestcase obj = new frmTestcase(objEProject,this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                objEProject.TestSteps = string.Empty;
                objEProject.ExpectedResult = string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnViewLogTestcase_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvTestcase.FocusedRowHandle >= 0)
                {
                    objEProject.ID = gvTestcase.GetFocusedRowCellValue("TestcaseID");
                    objEProject.Type = 4;
                    objDProject.GetChangeLog(objEProject);
                    frmChangeLog obj = new frmChangeLog(objEProject);
                    obj.ShowIcon = false;
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnNewBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.DevBuildID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmDevBuild obj = new frmDevBuild(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcBuilds.DataSource = objEProject.dtDevBuilds;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnViewBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvBuilds.FocusedRowHandle < 0)
                    return;
                objEProject.DevBuildID = gvBuilds.GetFocusedRowCellValue("DevBuildID");
                objEProject.BuildVersion = gvBuilds.GetFocusedRowCellValue("BuildVersion");
                objEProject.BuildPath = gvBuilds.GetFocusedRowCellValue("BuildPath");
                objEProject.ImpactAnalysis = gvBuilds.GetFocusedRowCellValue("ImpactAnalysis");
                objEProject.ImpactModules = gvBuilds.GetFocusedRowCellValue("ImpactModules");
                objEProject.BuildChanges = gvBuilds.GetFocusedRowCellValue("BuildChanges");
                objEProject.UserID = Utility.UserID;
                frmDevBuild obj = new frmDevBuild(objEProject);
                obj.ViewMode = true;
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnEditBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvBuilds.FocusedRowHandle < 0)
                    return;
                objEProject.DevBuildID = gvBuilds.GetFocusedRowCellValue("DevBuildID");
                objEProject.BuildVersion = gvBuilds.GetFocusedRowCellValue("BuildVersion");
                objEProject.BuildPath = gvBuilds.GetFocusedRowCellValue("BuildPath");
                objEProject.ImpactAnalysis = gvBuilds.GetFocusedRowCellValue("ImpactAnalysis");
                objEProject.ImpactModules = gvBuilds.GetFocusedRowCellValue("ImpactModules");
                objEProject.BuildChanges = gvBuilds.GetFocusedRowCellValue("BuildChanges");
                objEProject.UserID = Utility.UserID;
                frmDevBuild obj = new frmDevBuild(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcBuilds.DataSource = objEProject.dtDevBuilds;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnDeleteBuild_Click(object sender, EventArgs e)
        {

        }
        private void btnBuildChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvBuilds .FocusedRowHandle >= 0)
                {
                    objEProject.ID = gvBuilds.GetFocusedRowCellValue("DevBuildID");
                    objEProject.Type = 5;
                    objDProject.GetChangeLog(objEProject);
                    frmChangeLog obj = new frmChangeLog(objEProject);
                    obj.ShowIcon = false;
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnQABuildView_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvQAbuilds.FocusedRowHandle < 0)
                    return;
                objEProject.DevBuildID = gvQAbuilds.GetFocusedRowCellValue("DevBuildID");
                objEProject.BuildVersion = gvQAbuilds.GetFocusedRowCellValue("BuildVersion");
                objEProject.BuildPath = gvQAbuilds.GetFocusedRowCellValue("BuildPath");
                objEProject.ImpactAnalysis = gvQAbuilds.GetFocusedRowCellValue("ImpactAnalysis");
                objEProject.ImpactModules = gvQAbuilds.GetFocusedRowCellValue("ImpactModules");
                objEProject.BuildChanges = gvQAbuilds.GetFocusedRowCellValue("BuildChanges");
                objEProject.UserID = Utility.UserID;
                frmDevBuild obj = new frmDevBuild(objEProject);
                obj.ViewMode = true;
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnStartExecution_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvQAbuilds.FocusedRowHandle >= 0)
                    return;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.DevBuildID = gvQAbuilds.GetFocusedRowCellValue("DevBuildID");
                objEProject.PhaseName = cmbPhase.SelectedText;
                objEProject.BuildVersion = gvQAbuilds.GetFocusedRowCellValue("BuildVersion");
                frmTestExecution obj = new frmTestExecution(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.WindowState = FormWindowState.Maximized;
                obj.MdiParent = this.MdiParent;
                obj.Show();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        } 
        private void btnSelectTestcases_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvQAbuilds.FocusedRowHandle >= 0)
                    return;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.DevBuildID = gvQAbuilds.GetFocusedRowCellValue("DevBuildID");
                frmSelectTestcases obj = new frmSelectTestcases(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnCompleteQA_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null && gvQAbuilds.FocusedRowHandle < 0)
                    return;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.DevBuildID = gvQAbuilds.GetFocusedRowCellValue("DevBuildID");
                objEProject.BuildVersion = gvQAbuilds.GetFocusedRowCellValue("BuildVersion");
                objEProject.BuildPath = gvQAbuilds.GetFocusedRowCellValue("BuildPath");
                objEProject.ImpactAnalysis = gvQAbuilds.GetFocusedRowCellValue("ImpactAnalysis");
                objEProject.ImpactModules = gvQAbuilds.GetFocusedRowCellValue("ImpactModules");
                objEProject.BuildChanges = gvQAbuilds.GetFocusedRowCellValue("BuildChanges");
                objEProject.UserID = Utility.UserID;
                frmCompleteQA obj = new frmCompleteQA(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcBuilds.DataSource = objEProject.dtQABuilds;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void gvComponent_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                if (gvComponent.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(gvComponent.GetFocusedRowCellValue("ComponentID")), out ivalue) && ivalue > 0)
                    {
                        DXMenuItem mi = new DXMenuItem("Add Requirement");
                        mi.Click += AddRequirement_ItemClick;
                        mi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F);
                        e.Menu.Items.Add(mi);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        private void AddRequirement_ItemClick(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.ComponentID = gvComponent.GetFocusedRowCellValue("ComponentID");
                objEProject.RequirementID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                frmRequirement obj = new frmRequirement(objEProject, this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void gvRequirement_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                if (gvRequirement.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(gvRequirement.GetFocusedRowCellValue("RequirementID")), out ivalue) && ivalue > 0)
                    {
                        DXMenuItem mi = new DXMenuItem("Add Scenario");
                        mi.Click += AddScenario_ItemClick;
                        mi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F);
                        e.Menu.Items.Add(mi);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        private void AddScenario_ItemClick(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.ScenarioID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                objEProject.ComponentID = gvRequirement.GetFocusedRowCellValue("ComponentID");
                objEProject.RequirementID = gvRequirement.GetFocusedRowCellValue("RequirementID");
                frmScenario obj = new frmScenario(objEProject, this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void gvScenario_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                if (gvScenario.FocusedRowHandle >= 0)
                {
                    int ivalue = 0;
                    if (int.TryParse(Convert.ToString(gvScenario.GetFocusedRowCellValue("ScenarioID")), out ivalue) && ivalue > 0)
                    {
                        DXMenuItem mi = new DXMenuItem("Add Testcase");
                        mi.Click += AddTestcase_ItemClick;
                        mi.Appearance.Font = new System.Drawing.Font("Bahnschrift", 10F);
                        e.Menu.Items.Add(mi);
                    }
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); }
        }
        private void AddTestcase_ItemClick(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhase.EditValue == null)
                    return;
                objEProject.TestcaseID = -1;
                objEProject.ProjectPhaseID = cmbPhase.EditValue;
                objEProject.UserID = Utility.UserID;
                objEProject.ComponentID = gvScenario.GetFocusedRowCellValue("ComponentID");
                objEProject.RequirementID = gvScenario.GetFocusedRowCellValue("RequirementID");
                objEProject.ScenarioID = gvScenario.GetFocusedRowCellValue("ScenarioID");
                frmTestcase obj = new frmTestcase(objEProject, this);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnQAReport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                EProject eProject = new EProject();
                eProject.DevBuildID = gvQAbuilds.GetFocusedRowCellValue("DevBuildID");
                if (objDProject != null)
                    objDProject = new DProject();
                objDProject.GetQAReport_DevBuild(eProject);
                objDProject.GetQAReport_ProjectTeam(eProject);
                objDProject.GetQAReport_TestExecution(eProject);
                rptQAReport rpt = new rptQAReport(eProject);
                rpt.ShowRibbonPreview();
            }
            catch (Exception ex){}
        }

        private void btnReportHeader_Click(object sender, EventArgs e)
        {
            try
            {
                EProject eProject = new EProject();
                eProject.DevBuildID = gvQAbuilds.GetFocusedRowCellValue("DevBuildID");
                if (objDProject != null)
                    objDProject = new DProject();
                objDProject.GetQAReport_DevBuild(eProject);
                objDProject.GetQAReport_ProjectTeam(eProject);
                rptQAHeader rpt = new rptQAHeader(eProject);
                rpt.ShowRibbonPreview();
            }
            catch (Exception ex) { }
        }
    }
}
