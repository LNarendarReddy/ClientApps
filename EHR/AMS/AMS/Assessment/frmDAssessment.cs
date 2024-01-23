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
using DevExpress.XtraEditors.Repository;
using EHR.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using log4net;
using EHR.Assessment.Reports;

namespace EHR
{
    public partial class frmDAssessment : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        EAssessment ObjEAssessment = null;
        DAssessment ObjDAssessment = new DAssessment();
        public frmDAssessment()
        {
            InitializeComponent();
        }

        private void frmDAssessment_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjDAssessment.GetAssessmentYearforMS(ObjEAssessment);
                cmbAssessmentYear.Properties.DataSource = ObjEAssessment.dtAssessmentYear;
                cmbAssessmentYear.Properties.DisplayMember = "AssessmentYearName";
                cmbAssessmentYear.Properties.ValueMember = "AssessmentYearID";

                ObjDAssessment.GetAssessmentMode(ObjEAssessment);
                cmbAssessmentMode.Properties.DataSource = ObjEAssessment.dtAssessmentMode;
                cmbAssessmentMode.Properties.DisplayMember = "AssessmentModeName";
                cmbAssessmentMode.Properties.ValueMember = "AssessmentModeID";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void cmbAssessmentYear_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjDAssessment.GetEmployeeforDS(ObjEAssessment);
                cmbEmployeeName.Properties.DataSource = ObjEAssessment.dtEmployeeforDS;
                cmbEmployeeName.Properties.DisplayMember = "FullName";
                cmbEmployeeName.Properties.ValueMember = "UserInfoID";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        } 

        private void cmbEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null || cmbEmployeeName.EditValue == null || cmbAssessmentMode.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.UserInfoID = Convert.ToInt32(cmbEmployeeName.EditValue);
                ObjEAssessment.EmployeeID = cmbEmployeeName.EditValue;

                EUser ObjEUser = new EUser();
                DUser ObjDUser = new DUser();

                ObjEUser.EmployeeID = cmbEmployeeName.EditValue;
                ObjDUser.GetUserDetailsByID(ObjEUser);

                ObjDAssessment.GetWorkPlaceRatings(ObjEAssessment);
                gcWorkPlaceRatings.DataSource = ObjEAssessment.dtWorkplaceRAtings;
                txtImprovements.EditValue = ObjEAssessment.Improvements;
                txtAppreciations.EditValue = ObjEAssessment.Appreciations;
                int IValue = 0;
                int.TryParse(Convert.ToString(ObjEAssessment.AditionalContributions), out IValue);
                rgAditionalContribution.SelectedIndex = IValue;
                txtAditionalRole.EditValue = ObjEAssessment.AdtionalRole;

                int Ivalue = 0;
                if (ObjEUser.dtUser.Rows.Count > 0 &&
                    int.TryParse(Convert.ToString(ObjEUser.dtUser.Rows[0]["RoleID"]), out Ivalue) && 
                    Ivalue == 4)
                    tbLeadershipSkillsAssessment.PageVisible = false;
                else
                    tbLeadershipSkillsAssessment.PageVisible = true;

                ObjDAssessment.GetEmployeeRatingsforDS(ObjEAssessment);
                gcProjectRatings.DataSource = ObjEAssessment.dtUserProjectsForDS;
                gvGeneralRatings.Columns.Clear();
                gcGeneralRatings.DataSource = ObjEAssessment.dtGeneralRatingsForDS;
                if (ObjEAssessment.dtGeneralRatingsForDS != null)
                {
                    gvGeneralRatings.Columns["GeneralPerformanceID"].Visible = false;
                    gvGeneralRatings.Columns["RatingName"].ColumnEdit = this.txtMemo;
                    gvGeneralRatings.Columns["RatingDescription"].ColumnEdit = this.txtMemo;
                    gvGeneralRatings.Columns["SA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "SA", "AVG={0:0.##}");
                    gvGeneralRatings.Columns["MA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "MA", "AVG={0:0.##}");
                    gvGeneralRatings.OptionsBehavior.Editable = false;
                }

                ObjDAssessment.GetEmployeeBehaviourRatingsForDS(ObjEAssessment);
                gvEmployeeBehaviuor.Columns.Clear();
                gcEmployeeBehaviuor.DataSource = ObjEAssessment.dtEmployeeBehaviourRatingsForDS;
                if (ObjEAssessment.dtEmployeeBehaviourRatingsForDS != null)
                {
                    gvEmployeeBehaviuor.Columns["WorkPlacePerformanceID"].Visible = false;
                    gvEmployeeBehaviuor.Columns["RatingName"].ColumnEdit = this.txtMemo;
                    gvEmployeeBehaviuor.Columns["RatingDescription"].ColumnEdit = this.txtMemo;
                    gvEmployeeBehaviuor.Columns["SA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "SA", "AVG={0:0.##}");
                    gvEmployeeBehaviuor.Columns["MA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "MA", "AVG={0:0.##}");
                    gvEmployeeBehaviuor.OptionsBehavior.Editable = false;
                }

                txtSPeerReviewComments.EditValue = ObjEAssessment.SPeerReviewComments;
                txtMPeerReviewComments.EditValue = ObjEAssessment.MPeerReviewComments;

                ObjDAssessment.GetTechnicalRatingsforDS(ObjEAssessment);
                gvTechnicalRatings.Columns.Clear();
                gcTechnicalRatings.DataSource = ObjEAssessment.dtTechnicalRatingsForDS;
                if (ObjEAssessment.dtTechnicalRatingsForDS != null)
                {
                    gvTechnicalRatings.Columns["TechnicalPerformanceID"].Visible = false;
                    gvTechnicalRatings.Columns["RatingName"].ColumnEdit = this.txtMemo;
                    gvTechnicalRatings.Columns["RatingDescription"].ColumnEdit = this.txtMemo;
                    gvTechnicalRatings.Columns["SA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "SA", "AVG={0:0.##}");
                    gvTechnicalRatings.Columns["MA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "MA", "AVG={0:0.##}");
                    gvTechnicalRatings.OptionsBehavior.Editable = false;
                }

                ObjDAssessment.GetLeadRatingsforDS(ObjEAssessment);
                gvLeadRatings.Columns.Clear();
                gcLeadRatings.DataSource = ObjEAssessment.dtLeadRatingsForDS;
                if (ObjEAssessment.dtLeadRatingsForDS != null && ObjEAssessment.dtLeadRatingsForDS.Rows.Count > 0)
                {
                    gvLeadRatings.Columns["LeadPerformanceID"].Visible = false;
                    gvLeadRatings.Columns["RatingName"].ColumnEdit = this.txtMemo;
                    gvLeadRatings.Columns["RatingDescription"].ColumnEdit = this.txtMemo;
                    gvLeadRatings.Columns["SA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "SA", "AVG={0:0.##}");
                    gvLeadRatings.Columns["MA"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "MA", "AVG={0:0.##}");
                    gvLeadRatings.OptionsBehavior.Editable = false;
                }

                if (ObjEAssessment.dtLeadCommentsForDS != null && ObjEAssessment.dtLeadCommentsForDS.Rows.Count > 0)
                {
                    txtSelfComments.EditValue = ObjEAssessment.dtLeadCommentsForDS.Rows[0]["SelfComments"];
                    txtManagementComments.EditValue = ObjEAssessment.dtLeadCommentsForDS.Rows[0]["ManagementComments"];
                }

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
                    frmViewProject Obj = new frmViewProject(cmbAssessmentYear.EditValue, IValue);
                    Obj.EmployeeID = Convert.ToInt32(cmbEmployeeName.EditValue);
                    Obj.ShowDialog();
                    int Ivalue = 0;
                    if (Obj.IsSave && int.TryParse(Convert.ToString(Obj.NewProjectUserMapID), out Ivalue))
                    {
                        cmbAssessmentYear_EditValueChanged(null, null);
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

        public void ViewReport()
        {
            try
            {
                if (cmbAssessmentYear.EditValue == null)
                    return;
                if (cmbEmployeeName.EditValue == null)
                    return;
                EUser ObjEUser = new EUser();
                DUser ObjDUser = new DUser();

                ObjEUser.EmployeeID = cmbEmployeeName.EditValue;
                ObjDUser.GetUserDetailsByID(ObjEUser);

                EReports ObjEReports = new EReports();
                DReports ObjDReports = new DReports();
                ObjEReports.AssessmentyYearID = cmbAssessmentYear.EditValue;
                ObjEReports.AssessmentyModeID = cmbAssessmentMode.EditValue;
                ObjEReports.EmployeeID = cmbEmployeeName.EditValue;
                ObjDReports.GetDAssessment(ObjEReports);

                if (ObjEUser.dtUser != null && ObjEUser.dtUser.Rows.Count > 0)
                {
                    rptCoverPage rptCP = new rptCoverPage();
                    rptCP.Parameters["UserFullName"].Value = ObjEUser.dtUser.Rows[0]["FullName"];
                    rptCP.Parameters["Designation"].Value = ObjEUser.dtUser.Rows[0]["DesignationName"];
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

                    rptDTechnicalAssessment rptDT = new rptDTechnicalAssessment();
                    rptDT.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptDT.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                    rptDT.Parameters["UserName"].Value = ObjEUser.dtUser.Rows[0]["UserName"];
                    rptDT.Parameters["FullName"].Value = ObjEUser.dtUser.Rows[0]["FullName"];
                    rptDT.Parameters["Designation"].Value = ObjEUser.dtUser.Rows[0]["DesignationName"];
                    rptDT.Parameters["ReportingLead"].Value = ObjEUser.dtUser.Rows[0]["ReportingLead"];
                    rptDT.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                    if (ObjEReports.dsAssessment.Tables.Count > 2)
                        rptDT.DataSource = ObjEReports.dsAssessment.Tables[2];
                    rptDT.CreateDocument();
                    rptCP.Pages.AddRange(rptDT.Pages);

                    if (ObjEReports.dsAssessment.Tables.Count > 3 && ObjEReports.dsAssessment.Tables[3].Rows.Count > 0)
                    {
                        rptDProjectAssessment rptDP = new rptDProjectAssessment();
                        rptDP.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                        rptDP.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                        rptDP.DataSource = ObjEReports.dsAssessment.Tables[3];
                        rptDP.CreateDocument();
                        rptCP.Pages.AddRange(rptDP.Pages);
                    }

                    int Ivalue = 0;
                    if (int.TryParse(Convert.ToString(ObjEUser.dtUser.Rows[0]["RoleID"]), out Ivalue))
                    {
                        if (Ivalue == 3 || Ivalue == 6 || Ivalue == 7)
                        {
                            rptDLeadAssessment rptDL = new rptDLeadAssessment();
                            rptDL.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                            rptDL.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;

                            if (ObjEReports.dsAssessment.Tables.Count > 5)
                            {
                                rptDL.Parameters["SComments"].Value = ObjEReports.dsAssessment.Tables[5].Rows[0][0];
                                rptDL.Parameters["MComments"].Value = ObjEReports.dsAssessment.Tables[5].Rows[0][1];
                            }
                            if (ObjEReports.dsAssessment.Tables.Count > 4)
                                rptDL.DataSource = ObjEReports.dsAssessment.Tables[4];
                            rptDL.CreateDocument();
                            rptCP.Pages.AddRange(rptDL.Pages);
                        }
                    }

                    rptDGeneralAssessment rptDG = new rptDGeneralAssessment();
                    rptDG.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                    rptDG.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                    if (ObjEReports.dsAssessment.Tables.Count > 6)
                        rptDG.DataSource = ObjEReports.dsAssessment.Tables[6];
                    rptDG.CreateDocument();
                    rptCP.Pages.AddRange(rptDG.Pages);

                    rptDPeerReview rptDPR= new rptDPeerReview();
                    if (ObjEReports.dsAssessment.Tables.Count > 11)
                    {
                        rptDPR.Parameters["SelfComments"].Value = 
                            ObjEReports.dsAssessment.Tables[11].Rows[0]["SelfComments"];

                        rptDPR.Parameters["ManagementComments"].Value = 
                            ObjEReports.dsAssessment.Tables[11].Rows[0]["ManagementComments"];
                    }
                    if (ObjEReports.dsAssessment.Tables.Count > 7)
                        rptDPR.DataSource = ObjEReports.dsAssessment.Tables[7];
                    rptDPR.CreateDocument();
                    rptCP.Pages.AddRange(rptDPR.Pages);

                    if (ObjEReports.dsAssessment.Tables.Count > 8)
                    {
                        rptSeflGoals rptSGoals = new rptSeflGoals();
                        rptSGoals.Parameters["AchivedGoals"].Value = ObjEReports.dsAssessment.Tables[8].Rows[0]["AchivedGoals"];
                        rptSGoals.Parameters["SelfGoalsForYear"].Value = ObjEReports.dsAssessment.Tables[8].Rows[0]["SelfGoalForYear"];
                        rptSGoals.Parameters["SelfGoalsForHalfYear"].Value = ObjEReports.dsAssessment.Tables[8].Rows[0]["SelfGoalforHalfYear"];
                        rptSGoals.Parameters["SeflGoalsDetails"].Value = ObjEReports.dsAssessment.Tables[8].Rows[0]["SelfGoalForHalfYearDetails"];
                        rptSGoals.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                        rptSGoals.CreateDocument();
                        rptCP.Pages.AddRange(rptSGoals.Pages);
                    }

                    if (ObjEReports.dsAssessment.Tables.Count > 9)
                    {
                        rptMGoals rptMGoals = new rptMGoals();
                        rptMGoals.Parameters["GoalsAssessment"].Value = ObjEReports.dsAssessment.Tables[9].Rows[0]["MGoalsAssessment"];
                        rptMGoals.Parameters["MGoalsForYear"].Value = ObjEReports.dsAssessment.Tables[9].Rows[0]["MGoalForYear"];
                        rptMGoals.Parameters["MGoalsForHalfYear"].Value = ObjEReports.dsAssessment.Tables[9].Rows[0]["MGoalforHalfYear"];
                        rptMGoals.Parameters["MGoalsDetails"].Value = ObjEReports.dsAssessment.Tables[9].Rows[0]["MGoalForHalfYearDetails"];
                        rptMGoals.Parameters["AssessmentYear"].Value = cmbAssessmentYear.Text;
                        rptMGoals.CreateDocument();
                        rptCP.Pages.AddRange(rptMGoals.Pages);
                    }

                    if (Ivalue == 3 || Ivalue == 6 || Ivalue == 7)
                    {
                        rptFinalRatingWithLR rptFR = new rptFinalRatingWithLR();
                        rptFR.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                        rptFR.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                        if (ObjEReports.dsAssessment.Tables.Count > 10)
                            rptFR.DataSource = ObjEReports.dsAssessment.Tables[10];
                        rptFR.CreateDocument();
                        rptCP.Pages.AddRange(rptFR.Pages);
                    }
                    else
                    {
                        rptFinalRating rptFR = new rptFinalRating();
                        rptFR.Parameters["AssessmentYearID"].Value = cmbAssessmentYear.EditValue;
                        rptFR.Parameters["EmployeeID"].Value = cmbEmployeeName.EditValue;
                        if (ObjEReports.dsAssessment.Tables.Count > 10)
                            rptFR.DataSource = ObjEReports.dsAssessment.Tables[10];
                        rptFR.CreateDocument();
                        rptCP.Pages.AddRange(rptFR.Pages);
                    }
                    rptCP.ShowRibbonPreview();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void cmbAssessmentMode_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}