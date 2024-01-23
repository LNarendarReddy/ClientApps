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
    public partial class frmViewProject : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        int ProjectUserMapID = -1;
        object AssessmentYearID = null;
        EAssessment ObjEAssessment = null;
        DAssessment ObjDAssessment = new DAssessment();
        public object NewProjectUserMapID = 0;
        public bool IsSave = false;
        public int EmployeeID = -1;
        public frmViewProject(object _AssessmentYearID, int _ProjectUserMapID = -1)
        {
            InitializeComponent();
            ProjectUserMapID = _ProjectUserMapID;
            AssessmentYearID = _AssessmentYearID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewProject_Load(object sender, EventArgs e)
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

                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.ProjectUserMapID = ProjectUserMapID;
                ObjEAssessment.EmployeeID = EmployeeID;
                ObjDAssessment.GetUserProjectDetailsForDS(ObjEAssessment);
                gcRatings.DataSource = ObjEAssessment.dtCriteria;
                gvRatings.Columns["CriteriaID"].Visible = false;
                gvRatings.Columns["CriteriaName"].ColumnEdit = txtDescription;
                gvRatings.Columns["Description"].ColumnEdit = txtDescription;
                gvRatings.OptionsBehavior.Editable = false;
                gvRatings.BestFitColumns();
                cmbProjectName.Enabled = false;
                cmbProjectLead.Enabled = false;
                cmbProjectName.EditValue = ObjEAssessment.ProjectID;
                cmbProjectLead.EditValue = ObjEAssessment.LeadID;
                txtSelfComments.EditValue = ObjEAssessment. SelfComments;
                txtManagementComments.EditValue = ObjEAssessment.ManagementComments;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
    }
}