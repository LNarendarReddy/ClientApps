using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EProject
    {
        public DataTable dtProjects { get; set; }
        public DataTable dtUsers { get; set; }
        public DataTable dtPhase { get; set; }
        public DataTable dtTeam { get; set; }
        public DataTable dtComponent { get; set; }
        public DataTable dtChangeLog { get; set; }
        public DataTable dtRequirement { get; set; }
        public DataTable dtComponentfroDropDown { get; set; }
        public DataTable dtScenario { get; set; }
        public DataTable dtRequirementforDropDown { get; set; }
        public DataTable dtTestcase { get; set; }
        public DataTable dtScenarioforDropDown { get; set; }
        public DataTable dtDevBuilds { get; set; }
        public DataTable dtQABuilds { get; set; }
        public DataTable dtSelectedCases { get; set; }
        public DataTable dtTestcaseForQA { get; set; }
        public DataTable dtTestExecutionLog { get; set; }
        public DataTable dtChanges { get; set; }
        public DataTable dsQAReport_DevBuild { get; set; }
        public DataTable dsQAReport_ProjectTeam { get; set; }
        public DataTable dsQAReport_TestExecution { get; set; }

        public object ProjectID = -1;
        public object ProjectName = string.Empty;
        public object ProjectLeadID = -1;
        public object IsActive = false;
        public object ClientName { get; set; }
        public object SourceCodePath { get; set; }
        public object JiraProject { get; set; }
        public object ProjectShortName { get; set; }

        public object ProjectPhaseID = -1;
        public object PhaseName = string.Empty;
        public object UserID = -1;
        public object EmployeeID = -1;
        public object ProjectEmployeeID = -1;
        public bool IsSave = false;
        public object ComponentID = -1;
        public object ComponentName = string.Empty;
        public object ComponentDescription = string.Empty;
        public object ID = null;
        public object Type = null;
        public object RequirementID = null;
        public object RequirementName = string.Empty;
        public object RDescription = string.Empty;
        public object Description = string.Empty;
        public object ScenarioID = null;
        public object SShortDescription = null;
        public object SLongDescription = null;

        public object TestcaseID = string.Empty;
        public object TestcaseName = string.Empty;
        public object Complexity = string.Empty;
        public object Severity = string.Empty;
        public object TestcaseType = string.Empty;
        public object RegressionRequired = false;
        public object TestSteps = string.Empty;
        public object ExpectedResult = string.Empty;

        public object TestExecutionID = null;
        public object Testdata = string.Empty;
        public object Testdate = null;
        public object TestStatus = null;
        public object Comments = string.Empty;

        public object DevBuildID = 0;
        public object BuildVersion = string.Empty;
        public object BuildPath = string.Empty;
        public object ImpactAnalysis = string.Empty;
        public object ImpactModules = string.Empty;
        public object BuildChanges = string.Empty;
        public object QAComments = string.Empty;
    }
}
