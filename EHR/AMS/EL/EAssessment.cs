using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class EAssessment
    {
        public DataTable dtProjects = null;
        public DataTable dtUsers = null;
        public DataTable dtAssessmentYear = null;
        public DataTable dtCriteria = null;
        public DataTable dtLeads = null;
        public DataTable dtAssessmentMode = null;
        public DataTable dtUserProjects = null;
        public object AssessMentYearID = -1;
        public object AssessMentModeID = -1;
        public DataTable dtProjectRatings = null;
        public DataTable dtProjectDetails = null;
        public DataTable dtGeneralRatings = null;
        public DataTable dtWorkPlacePerformanceRatings = null;
        public DataTable dtGeneralRatingsUpdated = null;
        public DataTable dtWorkplacePerformanceRatingsUpdated = null;
        public DataTable dtEmployeeforPR = null;
        public DataTable dtEmployeeforGR = null;
        public DataTable dtEmployeeforDS = null;
        public DataTable dtEmployeeforLR = null;
        public DataTable dtTechnicalRatings = null;
        public DataTable dtTechnicalRatingsUpdated = null;
        public DataTable dtReportingEmployees = null;
        public DataTable dtProjectEmployees = null;
        public DataTable dtAllEmployees = null;

        public DataTable dtLeadershipRatings = null;
        public DataTable dtLeadershipRatingsUpdated = null;

        public DataTable dtUserProjectsForDS = null;
        public DataTable dtGeneralRatingsForDS = null;
        public DataTable dtEmployeeBehaviourRatingsForDS = null;
        public DataTable dtTechnicalRatingsForDS = null;
        public DataTable dtLeadRatingsForDS = null;
        public DataTable dtLeadCommentsForDS = null;

        public object LeadID = -1;
        public int UserInfoID = -1;
        public object ProjectUserMapID = -1;
        public object SelfComments = string.Empty;
        public object ManagementComments = string.Empty;
        public object EmployeeID = -1;
        public object ProjectID = -1;
        public object ProjectName = -1;
        public object ProjectLeadID = -1;
        public object IsActive = false;

        public object Improvements { get; set; }
        public object Appreciations { get; set; }
        public object AditionalContributions = 0;
        public object AdtionalRole { get; set; }
        public object AchivedGoals { get; set; }
        public object SelfGoalForYear { get; set; }
        public object SelfGoalforHalfYear { get; set; }
        public object SelfGoalForHalfYearDetails { get; set; }
        public object MGoalsAssessment { get; set; }
        public object MGoalForYear { get; set; }
        public object MGoalforHalfYear { get; set; }
        public object MGoalForHalfYearDetails { get; set; }
        public DataTable dtWorkplaceRAtings { get; set; }
        public bool IsYourTeam = false;
        public object SPeerReviewComments { get; set; }
        public object MPeerReviewComments { get; set; }
    }
}
