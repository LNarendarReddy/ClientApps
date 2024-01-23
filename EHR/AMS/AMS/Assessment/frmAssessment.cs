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
using DevExpress.XtraReports.UI;
using EHR.Reports;
using DevExpress.XtraPrinting;
using log4net;
using EHR.Assessment.Reports;

namespace EHR
{
    public partial class frmAssessment : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        EAssessment ObjEAssessment = null;
        DAssessment ObjDAssessment = new DAssessment();

        public frmAssessment()
        {
            InitializeComponent();
        }
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null && cmbAssessmentMode.EditValue == null)
                    return;
                frmAddProject Obj = new frmAddProject(cmbAssessmentYear.EditValue,cmbAssessmentMode.EditValue);
                Obj.EmployeeID = Utility.UserID;
                Obj.ShowDialog();
                int Ivalue = 0;
                if (Obj.IsSave && int.TryParse(Convert.ToString(Obj.NewProjectUserMapID), out Ivalue))
                {
                    cmbAssessmentYear_EditValueChanged(null, null);
                    Utility.Setfocus(gvProject, "ProjectUserMapID", Ivalue);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAssessment_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjDAssessment.GetProjectRatingsMaster(ObjEAssessment);
                cmbAssessmentYear.Properties.DataSource = ObjEAssessment.dtAssessmentYear;
                cmbAssessmentYear.Properties.DisplayMember = "AssessmentYearName";
                cmbAssessmentYear.Properties.ValueMember = "AssessmentYearID";

                cmbAssessmentMode.Properties.DataSource = ObjEAssessment.dtAssessmentMode;
                cmbAssessmentMode.Properties.DisplayMember = "AssessmentModeName";
                cmbAssessmentMode.Properties.ValueMember = "AssessmentModeID";

                if (Utility.RoleID == 3 || Utility.RoleID == 1 || Utility.RoleID == 7 || Utility.RoleID == 6)
                    tbLeaderSkillsAssessment.PageVisible = true;

                lcAchivedGoals.Text = "Please check your copy of the last Assessment Talk: Which goals had been agreed upon with Management.\nWhat steps have you undertaken towards achieving the goals? What‘s the completion status of goal achievement ?";
                lcGoalDetails.Text = "Please  define in detail: Which methods, technologies, languages do you want to learn/acquire? \nWhat would your training / learning schedule look like? What kind of mentoring will be required?";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void rgAditionalContribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgAditionalContribution.SelectedIndex == 0)
                txtAditionalRole.Enabled = true;
            else
                txtAditionalRole.Enabled = false;
        }
        private void cmbAssessmentYear_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                
                ObjDAssessment.GetWorkPlaceRatings(ObjEAssessment);
                gcWorkPlaceRatings.DataSource = ObjEAssessment.dtWorkplaceRAtings;
                txtImprovements.EditValue = ObjEAssessment.Improvements;
                txtAppreciations.EditValue = ObjEAssessment.Appreciations;
                int IValue = 0;
                int.TryParse(Convert.ToString(ObjEAssessment.AditionalContributions), out IValue);
                rgAditionalContribution.SelectedIndex = IValue;
                txtAditionalRole.EditValue = ObjEAssessment.AdtionalRole;

                ObjDAssessment.GetUserProject(ObjEAssessment);
                gcProjectRatings.DataSource = ObjEAssessment.dtUserProjects;

                ObjDAssessment.GetGeneralRatings(ObjEAssessment);
                gcGeneralRatings.DataSource = ObjEAssessment.dtGeneralRatings;

                ObjDAssessment.GetEmployeeBehaviourRatings(ObjEAssessment);
                gcEmployeeBehaviour.DataSource = ObjEAssessment.dtWorkPlacePerformanceRatings;

                txtPeerReviewComments.EditValue = ObjDAssessment.GetPeerReviewComments(ObjEAssessment);

                ObjDAssessment.GetTechnicalRatings(ObjEAssessment);
                gcTechnicalRatings.DataSource = ObjEAssessment.dtTechnicalRatings;

                ObjDAssessment.GetLeadRatings(ObjEAssessment);
                gcLeadRatings.DataSource = ObjEAssessment.dtLeadershipRatings;

                ObjDAssessment.GetSelfGoals(ObjEAssessment);
                txtSelfAchivedGoals.EditValue = ObjEAssessment.AchivedGoals;
                txtSelfGoalsForYear.EditValue = ObjEAssessment.SelfGoalForYear;
                txtSelfGoalsHalfYear.EditValue = ObjEAssessment.SelfGoalforHalfYear;
                txtSelfGoalsDetail.EditValue = ObjEAssessment.SelfGoalForHalfYearDetails;

                ObjDAssessment.GetMGoals(ObjEAssessment);
                txtMGoalsAchived.EditValue = ObjEAssessment.MGoalsAssessment;
                txtMGoalsForYear.EditValue = ObjEAssessment.MGoalForYear;
                txtMGoalsHalfYear.EditValue = ObjEAssessment.MGoalforHalfYear;
                txtMGoalsDetail.EditValue = ObjEAssessment.MGoalForHalfYearDetails;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnSaveWorkPlaceRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                ObjEAssessment.Improvements = txtImprovements.EditValue;
                ObjEAssessment.Appreciations = txtAppreciations.EditValue;
                ObjEAssessment.AditionalContributions = rgAditionalContribution.SelectedIndex;
                ObjEAssessment.AdtionalRole = txtAditionalRole.EditValue;
                ObjDAssessment.SaveWorkPlaceRatings(ObjEAssessment);
                tcRatings.SelectedTabPage = tbProjectRatings;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnProjectNext_Click(object sender, EventArgs e)
        {
            tcRatings.SelectedTabPage = tbGeneralRatings;
        }
        private void btnSaveGeneralRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                ObjEAssessment.dtGeneralRatingsUpdated = ObjEAssessment.dtGeneralRatings.Copy();
                foreach(DataColumn dc in ObjEAssessment.dtGeneralRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        ObjEAssessment.dtGeneralRatingsUpdated.Columns.Remove(dc.ColumnName);
                }

                ObjDAssessment.SaveGeneralRatings(ObjEAssessment);
                tcRatings.SelectedTabPage = tbWorkPerformance;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnSaveEmployeeBehaviourRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (!dxValidationProvider1.Validate())
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                ObjEAssessment.dtWorkplacePerformanceRatingsUpdated = ObjEAssessment.dtWorkPlacePerformanceRatings.Copy();
                foreach (DataColumn dc in ObjEAssessment.dtWorkPlacePerformanceRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        ObjEAssessment.dtWorkplacePerformanceRatingsUpdated.Columns.Remove(dc.ColumnName);
                }

                ObjDAssessment.SaveEmployeeBehaviourRatings(ObjEAssessment,txtPeerReviewComments.EditValue);
                tcRatings.SelectedTabPage = tbTechnicalRatings;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnSaveTechnicalRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                ObjEAssessment.dtTechnicalRatingsUpdated = ObjEAssessment.dtTechnicalRatings.Copy();
                foreach (DataColumn dc in ObjEAssessment.dtTechnicalRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        ObjEAssessment.dtTechnicalRatingsUpdated.Columns.Remove(dc.ColumnName);
                }

                ObjDAssessment.SaveTechnicalRatings(ObjEAssessment);
                if (Utility.RoleID == 3 || Utility.RoleID == 1 || Utility.RoleID == 7 || Utility.RoleID == 6)
                    tcRatings.SelectedTabPage = tbLeaderSkillsAssessment;
                else
                    tcRatings.SelectedTabPage = tbSelfGoals;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnSaveLeadershipRatings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                ObjEAssessment.dtLeadershipRatingsUpdated = ObjEAssessment.dtLeadershipRatings.Copy();
                foreach (DataColumn dc in ObjEAssessment.dtLeadershipRatings.Columns)
                {
                    if (dc.ColumnName == "RatingName" || dc.ColumnName == "RatingDescription")
                        ObjEAssessment.dtLeadershipRatingsUpdated.Columns.Remove(dc.ColumnName);
                }
                ObjDAssessment.SaveLeadRatings(ObjEAssessment);
                tcRatings.SelectedTabPage = tbSelfGoals;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnSaveSelfGoals_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                ObjEAssessment.AchivedGoals = txtSelfAchivedGoals.EditValue;
                ObjEAssessment.SelfGoalForYear = txtSelfGoalsForYear.EditValue;
                ObjEAssessment.SelfGoalforHalfYear = txtSelfGoalsHalfYear.EditValue;
                ObjEAssessment.SelfGoalForHalfYearDetails = txtSelfGoalsDetail.EditValue;
                ObjDAssessment.SaveSelfGoals(ObjEAssessment);
                tcRatings.SelectedTabPage = tbMGoals;
                XtraMessageBox.Show("Your assessment filing is completed.");
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnSaveMGoals_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.EmployeeID = Utility.UserID;
                ObjEAssessment.MGoalsAssessment = txtMGoalsAchived.EditValue;
                ObjEAssessment.MGoalForYear = txtMGoalsForYear.EditValue;
                ObjEAssessment.MGoalforHalfYear = txtMGoalsHalfYear.EditValue;
                ObjEAssessment.MGoalForHalfYearDetails = txtMGoalsDetail.EditValue;
                ObjDAssessment.SaveMGoals(ObjEAssessment);
                XtraMessageBox.Show("Your assessment filing is finished");
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null && cmbAssessmentMode.EditValue == null)
                    return;

                if (gvProject.FocusedRowHandle >= 0)
                {
                    int ProjectUserMapID = 0;
                    if(int.TryParse(Convert.ToString(gvProject.GetFocusedRowCellValue("ProjectUserMapID")),out ProjectUserMapID))
                    {
                        frmAddProject Obj = new frmAddProject(cmbAssessmentYear.EditValue, cmbAssessmentMode.EditValue, ProjectUserMapID);
                        Obj.EmployeeID = Utility.UserID;
                        Obj.ShowDialog();
                        int Ivalue = 0;
                        if (Obj.IsSave && int.TryParse(Convert.ToString(Obj.NewProjectUserMapID), out Ivalue))
                        {
                            cmbAssessmentYear_EditValueChanged(null, null);
                            Utility.Setfocus(gvProject, "ProjectUserMapID", Ivalue);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }
        public void ViewReport()
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null)
                    return;
                EReports ObjEReports = new EReports();
                DReports ObjDReports = new DReports();
                ObjEReports.AssessmentyYearID = cmbAssessmentYear.EditValue;
                ObjEReports.AssessmentyModeID = cmbAssessmentMode.EditValue;
                ObjEReports.EmployeeID = Utility.UserID;
                ObjDReports.GetSelfAssessment(ObjEReports);

                rptCoverPage rptCP = new rptCoverPage();
                rptCP.Parameters["UserFullName"].Value = Utility.UserFullName;
                rptCP.Parameters["Designation"].Value = Utility.Designation;
                rptCP.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                rptCP.Parameters["AssessmentMode"].Value = cmbAssessmentMode.Text;
                rptCP.CreateDocument();

                if (ObjEReports.dsAssessment.Tables.Count > 1)
                {
                    rptWorkPlaceRatings rptWP = new rptWorkPlaceRatings();
                    rptWP.Parameters["Improvements"].Value = ObjEReports.dsAssessment.Tables[1].Rows[0]["Improvements"];
                    rptWP.Parameters["Appreciations"].Value = ObjEReports.dsAssessment.Tables[1].Rows[0]["Appreciations"];
                    rptWP.Parameters["AditionalContribution"].Value = ObjEReports.dsAssessment.Tables[1].Rows[0]["AditionalContributions"];
                    rptWP.Parameters["AditionalRole"].Value = ObjEReports.dsAssessment.Tables[1].Rows[0]["AdtionalRole"];
                    if (ObjEReports.dsAssessment.Tables.Count > 0)
                        rptWP.DataSource = ObjEReports.dsAssessment.Tables[0];
                    rptWP.CreateDocument();
                    rptCP.Pages.AddRange(rptWP.Pages);
                }

                rptSTechnicalAssessment rptST = new rptSTechnicalAssessment();
                rptST.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                rptST.Parameters["EmployeeID"].Value = Utility.UserID;
                rptST.Parameters["UserName"].Value = Utility.UserName;
                rptST.Parameters["FullName"].Value = Utility.UserFullName;
                rptST.Parameters["Designation"].Value = Utility.Designation;
                rptST.Parameters["ReportingLead"].Value = Utility.ReportingLead;
                rptST.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                if (ObjEReports.dsAssessment.Tables.Count > 2)
                    rptST.DataSource = ObjEReports.dsAssessment.Tables[2];
                rptST.CreateDocument();
                rptCP.Pages.AddRange(rptST.Pages);


                if (ObjEReports.dsAssessment.Tables.Count > 3 && ObjEReports.dsAssessment.Tables[3].Rows.Count > 0)
                {
                    rptSProjectAssessment rptSP = new rptSProjectAssessment();
                    rptSP.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptSP.Parameters["EmployeeID"].Value = Utility.UserID;
                        rptSP.DataSource = ObjEReports.dsAssessment.Tables[3];
                    rptSP.CreateDocument();
                    rptCP.Pages.AddRange(rptSP.Pages);
                }

                if (Utility.RoleID == 3 || Utility.RoleID == 6 || Utility.RoleID == 7)
                {
                    rptSLeadershipAssessment rptSL = new rptSLeadershipAssessment();
                    rptSL.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptSL.Parameters["EmployeeID"].Value = Utility.UserID;
                    if (ObjEReports.dsAssessment.Tables.Count > 6)
                        rptSL.DataSource = ObjEReports.dsAssessment.Tables[6];
                    rptSL.CreateDocument();
                    rptCP.Pages.AddRange(rptSL.Pages);
                }

                rptSGeneralAssessment rptSG = new rptSGeneralAssessment();
                rptSG.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                rptSG.Parameters["EmployeeID"].Value = Utility.UserID;
                if (ObjEReports.dsAssessment.Tables.Count > 4)
                    rptSG.DataSource = ObjEReports.dsAssessment.Tables[4];
                rptSG.CreateDocument();
                rptCP.Pages.AddRange(rptSG.Pages);

                rptSPeerReview rptSPR = new rptSPeerReview();
                if (ObjEReports.dsAssessment.Tables.Count > 9)
                    rptSPR.Parameters["PeerReviewComments"].Value = 
                        ObjEReports.dsAssessment.Tables[9].Rows[0]["Comments"];
                if (ObjEReports.dsAssessment.Tables.Count > 5)
                    rptSPR.DataSource = ObjEReports.dsAssessment.Tables[5];
                rptSPR.CreateDocument();
                rptCP.Pages.AddRange(rptSPR.Pages);

                if (ObjEReports.dsAssessment.Tables.Count > 7)
                {
                    rptSeflGoals rptSGoals = new rptSeflGoals();
                    rptSGoals.Parameters["AchivedGoals"].Value = ObjEReports.dsAssessment.Tables[7].Rows[0]["AchivedGoals"];
                    rptSGoals.Parameters["SelfGoalsForYear"].Value = ObjEReports.dsAssessment.Tables[7].Rows[0]["SelfGoalForYear"];
                    rptSGoals.Parameters["SelfGoalsForHalfYear"].Value = ObjEReports.dsAssessment.Tables[7].Rows[0]["SelfGoalforHalfYear"];
                    rptSGoals.Parameters["SeflGoalsDetails"].Value = ObjEReports.dsAssessment.Tables[7].Rows[0]["SelfGoalForHalfYearDetails"];
                    rptSGoals.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                    rptSGoals.CreateDocument();
                    rptCP.Pages.AddRange(rptSGoals.Pages);
                }
                rptCP.ShowRibbonPreview();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

    }
}