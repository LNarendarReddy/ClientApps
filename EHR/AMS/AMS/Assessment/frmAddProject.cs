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
    public partial class frmAddProject : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        int ProjectUserMapID = -1;
        object AssessmentYearID = null;
        object AssessmentModeID = null;
        EAssessment ObjEAssessment = null;
        DAssessment ObjDAssessment = new DAssessment();
        public object NewProjectUserMapID = 0;
        public bool IsSave = false;
        public int EmployeeID = -1;
        public frmAddProject(object _AssessmentYearID, object _AssessmentModeID, int _ProjectUserMapID = -1)
        {
            InitializeComponent();
            ProjectUserMapID = _ProjectUserMapID;
            AssessmentYearID = _AssessmentYearID;
            AssessmentModeID = _AssessmentModeID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProjectName.EditValue == null)
                    return;

                if (cmbProjectLead.EditValue == null)
                    return;

                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.ProjectUserMapID = ProjectUserMapID;
                ObjEAssessment.ProjectID = cmbProjectName.EditValue;
                ObjEAssessment.AssessMentYearID = AssessmentYearID;
                ObjEAssessment.AssessMentModeID = AssessmentModeID;
                ObjEAssessment.SelfComments = string.Empty;
                ObjEAssessment.ManagementComments = string.Empty;
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.LeadID = cmbProjectLead.EditValue;
                DataTable dtTemp = new DataTable();
                dtTemp = ObjEAssessment.dtCriteria.Copy();
                foreach(DataColumn dc in ObjEAssessment.dtCriteria.Columns)
                {
                    if (dc.ColumnName == "Description" || dc.ColumnName == "CriteriaName")
                        dtTemp.Columns.Remove(dc.ColumnName);
                }
                ObjEAssessment.dtProjectRatings = dtTemp;
                ObjDAssessment.SaveUserProject(ObjEAssessment);
                NewProjectUserMapID = ObjEAssessment.ProjectUserMapID;
                IsSave = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            try
            {
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjDAssessment.GetProjectRatingsMaster(ObjEAssessment);
                cmbProjectName.Properties.DataSource = ObjEAssessment.dtProjects;
                cmbProjectName.Properties.DisplayMember = "ProjectName";
                cmbProjectName.Properties.ValueMember = "ProjectID";

                cmbProjectLead.Properties.DataSource = ObjEAssessment.dtLeads;
                cmbProjectLead.Properties.DisplayMember = "FullName";
                cmbProjectLead.Properties.ValueMember = "UserInfoID";
                if (ProjectUserMapID <= 0)
                {
                    ObjEAssessment.dtCriteria.Columns.Add("SA", typeof(decimal));
                    ObjEAssessment.dtCriteria.Columns.Add("Comments", typeof(string));
                    gcRatings.DataSource = ObjEAssessment.dtCriteria;
                    gvRatings.Columns["CriteriaID"].Visible = false;
                    gvRatings.Columns["SA"].Caption = "SA (1-10)";
                    gvRatings.Columns["Comments"].Caption = "Self Comments";
                }
                else
                {
                    ObjEAssessment.UserInfoID = Utility.UserID;
                    ObjEAssessment.ProjectUserMapID = ProjectUserMapID;
                    ObjDAssessment.GetUserProjectDetails(ObjEAssessment);
                    if (ObjEAssessment.dtCriteria != null &&
                        ObjEAssessment.dtCriteria.Rows.Count > 0 &&
                        ObjEAssessment.dtCriteria.Columns["SA"].DataType != typeof(decimal))
                    {
                        ObjEAssessment.dtCriteria = Utility.ChangeColumnDataType(ObjEAssessment.dtCriteria);
                    }
                    gcRatings.DataSource = ObjEAssessment.dtCriteria;
                    gvRatings.Columns["CriteriaID"].Visible = false;
                    cmbProjectName.Enabled = false;
                    if (EmployeeID != Utility.UserID)
                        gvRatings.Columns["SA"].Caption = "MA (1-10)";
                    else
                        gvRatings.Columns["SA"].Caption = "SA (1-10)";
                    cmbProjectName.EditValue = ObjEAssessment.ProjectID;
                    this.Text = "View Project";
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }

        private void cmbProjectName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LookUpEdit lookUp = sender as LookUpEdit;
                DataRowView dataRow = lookUp.GetSelectedDataRow() as DataRowView;
                cmbProjectLead.EditValue = dataRow["ProjectLeadID"];
            }
            catch (Exception ex){}
        }

        private void gcRatings_Click(object sender, EventArgs e)
        {

        }
    }
}