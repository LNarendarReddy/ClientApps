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

namespace EHR
{
    public partial class frmMAssessment : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        EAssessment ObjEAssessment = null;
        DAssessment ObjDAssessment = new DAssessment();
        public frmMAssessment(EAssessment _ObjEAssessment)
        {
            InitializeComponent();
            ObjEAssessment = _ObjEAssessment;
        } 

        private void frmMAssessment_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.UserInfoID = Utility.UserID;

                EUser ObjEUser = new EUser();
                DUser ObjDUser = new DUser();

                ObjEUser.EmployeeID = ObjEAssessment.EmployeeID;
                ObjDUser.GetUserDetailsByID(ObjEUser);

                int iRoleID = 0;
                if (ObjEUser.dtUser.Rows.Count > 0 &&
                    int.TryParse(Convert.ToString(ObjEUser.dtUser.Rows[0]["RoleID"]), out iRoleID) &&
                    iRoleID == 4)
                    tbLeadRatings.PageVisible = false;
                else
                    tbLeadRatings.PageVisible = true;

                if(Utility.RoleID == 4)
                {
                    tbLeadRatings.PageVisible = false;
                    tbGeneralRatings.PageVisible = false;
                }

                int iReportingLead = 0;
                if (ObjEUser.dtUser.Rows.Count > 0 &&
                    int.TryParse(Convert.ToString(ObjEUser.dtUser.Rows[0]["ReportingLeadID"]), out iReportingLead) &&
                    iReportingLead != Utility.UserID)
                {
                    tbWorkplaceRatings.PageVisible = false;
                    tbSelfGoals.PageVisible = false;
                    tbManagementGoals.PageVisible = false;
                    if(!ObjEAssessment.IsYourTeam)
                    {
                        tbProjectRatings.PageVisible = false;
                        tbTechnicalRatings.PageVisible = false;
                    }
                }
                else
                {
                    tbWorkplaceRatings.PageVisible = true;
                    tbSelfGoals.PageVisible = true;
                    tbManagementGoals.PageVisible = true;

                }


                //Populating Workplace ratings
                ObjDAssessment.GetWorkPlaceRatings(ObjEAssessment);
                gcWorkPlaceRatings.DataSource = ObjEAssessment.dtWorkplaceRAtings;
                txtImprovements.EditValue = ObjEAssessment.Improvements;
                txtAppreciations.EditValue = ObjEAssessment.Appreciations;
                int IValue = 0;
                int.TryParse(Convert.ToString(ObjEAssessment.AditionalContributions), out IValue);
                rgAditionalContribution.SelectedIndex = IValue;
                txtAditionalRole.EditValue = ObjEAssessment.AdtionalRole;

                //Populating User projects
                LoadProjects();

                //populating general ratings
                ObjDAssessment.GetGeneralRatings(ObjEAssessment);
                if (ObjEAssessment.dtGeneralRatings != null &&
                    ObjEAssessment.dtGeneralRatings.Rows.Count > 0 &&
                    ObjEAssessment.dtGeneralRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEAssessment.dtGeneralRatings = Utility.ChangeColumnDataType(ObjEAssessment.dtGeneralRatings);
                }
                gcGeneralRatings.DataSource = ObjEAssessment.dtGeneralRatings;
                gvGeneralRatings.Columns["SA"].Caption = "MA (1-10)";

                //Populating Employee Behaviour ratings
                ObjDAssessment.GetEmployeeBehaviourRatings(ObjEAssessment);
                if (ObjEAssessment.dtWorkPlacePerformanceRatings  != null &&
                    ObjEAssessment.dtWorkPlacePerformanceRatings.Rows.Count > 0 &&
                    ObjEAssessment.dtWorkPlacePerformanceRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEAssessment.dtWorkPlacePerformanceRatings = 
                        Utility.ChangeColumnDataType(ObjEAssessment.dtWorkPlacePerformanceRatings);
                }
                gcEmployeeBehaviour.DataSource = ObjEAssessment.dtWorkPlacePerformanceRatings;
                gvEmployeeBehaviour.Columns["SA"].Caption = "MA (1-10)";

                txtPeerReviewComments.EditValue = ObjDAssessment.GetPeerReviewComments(ObjEAssessment);

                //populating technical ratings
                ObjDAssessment.GetTechnicalRatings(ObjEAssessment);
                if (ObjEAssessment.dtTechnicalRatings != null &&
                    ObjEAssessment.dtTechnicalRatings.Rows.Count > 0 &&
                    ObjEAssessment.dtTechnicalRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEAssessment.dtTechnicalRatings = Utility.ChangeColumnDataType(ObjEAssessment.dtTechnicalRatings);
                }
                gcTechnicalRatings.DataSource = ObjEAssessment.dtTechnicalRatings;
                gvTechnicalRatings.Columns["SA"].Caption = "MA (1-10)";

                //Populating Lead ratings
                ObjDAssessment.GetLeadRatings(ObjEAssessment);
                if (ObjEAssessment.dtLeadershipRatings != null &&
                    ObjEAssessment.dtLeadershipRatings.Rows.Count > 0 &&
                    ObjEAssessment.dtLeadershipRatings.Columns["SA"].DataType != typeof(decimal))
                {
                    ObjEAssessment.dtLeadershipRatings = Utility.ChangeColumnDataType(ObjEAssessment.dtLeadershipRatings);
                }
                gcLeadRatings.DataSource = ObjEAssessment.dtLeadershipRatings;
                gvLeadRatings.Columns["SA"].Caption = "MA (1-10)";

                //Populating Self Goals
                ObjDAssessment.GetSelfGoals(ObjEAssessment);
                txtSelfAchivedGoals.EditValue = ObjEAssessment.AchivedGoals;
                txtSelfGoalsForYear.EditValue = ObjEAssessment.SelfGoalForYear;
                txtSelfGoalsHalfYear.EditValue = ObjEAssessment.SelfGoalforHalfYear;
                txtSelfGoalsDetail.EditValue = ObjEAssessment.SelfGoalForHalfYearDetails;

                //Populating Management Goals
                ObjDAssessment.GetMGoals(ObjEAssessment);
                txtMGoalsAchived.EditValue = ObjEAssessment.MGoalsAssessment;
                txtMGoalsForYear.EditValue = ObjEAssessment.MGoalForYear;
                txtMGoalsHalfYear.EditValue = ObjEAssessment.MGoalforHalfYear;
                txtMGoalsDetail.EditValue = ObjEAssessment.MGoalForHalfYearDetails;

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnSaveGeneralRatings_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEAssessment.UserInfoID = Utility.UserID;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEAssessment.dtGeneralRatings.Copy();
                foreach (DataColumn dc in ObjEAssessment.dtGeneralRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEAssessment.dtGeneralRatingsUpdated = dtTemp;
                ObjDAssessment.SaveGeneralRatings(ObjEAssessment);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnSaveBehaviourRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEAssessment.UserInfoID = Utility.UserID;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEAssessment.dtWorkPlacePerformanceRatings.Copy();
                foreach (DataColumn dc in ObjEAssessment.dtWorkPlacePerformanceRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEAssessment.dtWorkplacePerformanceRatingsUpdated = dtTemp;
                ObjDAssessment.SaveEmployeeBehaviourRatings(ObjEAssessment,txtPeerReviewComments.EditValue);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnTechnicalRatings_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEAssessment.UserInfoID = Utility.UserID;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEAssessment.dtTechnicalRatings.Copy();
                foreach (DataColumn dc in ObjEAssessment.dtTechnicalRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEAssessment.dtTechnicalRatingsUpdated = dtTemp;
                ObjDAssessment.SaveTechnicalRatings(ObjEAssessment);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnSaveLeadRatings_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEAssessment.UserInfoID = Utility.UserID;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEAssessment.dtLeadershipRatings.Copy();
                foreach (DataColumn dc in ObjEAssessment.dtLeadershipRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEAssessment.dtLeadershipRatingsUpdated = dtTemp;
                ObjDAssessment.SaveLeadRatings(ObjEAssessment);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if (int.TryParse(Convert.ToString(gvProject.GetFocusedRowCellValue("ProjectUserMapID")), out IValue))
                {
                    frmAddProject Obj = new frmAddProject(ObjEAssessment.AssessMentYearID,
                        ObjEAssessment.AssessMentModeID, IValue);
                    Obj.ShowDialog();
                    int Ivalue = 0;
                    if (Obj.IsSave && int.TryParse(Convert.ToString(Obj.NewProjectUserMapID), out Ivalue))
                    {
                        LoadProjects();
                        Utility.Setfocus(gvProject, "ProjectUserMapID", Ivalue);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void btnSaveMGoals_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEAssessment.UserInfoID = Convert.ToInt32(ObjEAssessment.EmployeeID);
                ObjEAssessment.MGoalsAssessment = txtMGoalsAchived.EditValue;
                ObjEAssessment.MGoalForYear = txtMGoalsForYear.EditValue;
                ObjEAssessment.MGoalforHalfYear = txtMGoalsHalfYear.EditValue;
                ObjEAssessment.MGoalForHalfYearDetails = txtMGoalsDetail.EditValue;
                ObjDAssessment.SaveMGoals(ObjEAssessment);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void LoadProjects()
        {
            try
            {
                ObjDAssessment.GetUserProjectForMS(ObjEAssessment);
                gcProjectRatings.DataSource = ObjEAssessment.dtUserProjects;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}