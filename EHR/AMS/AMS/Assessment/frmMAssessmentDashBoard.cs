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

namespace EHR.Assessment
{
    public partial class frmMAssessmentDashBoard : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        EAssessment ObjEAssessment = null;
        DAssessment ObjDAssessment = new DAssessment();
        public frmMAssessmentDashBoard()
        {
            InitializeComponent();
        }

        private void frmMAssessmentDashBoard_Load(object sender, EventArgs e)
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
                if (cmbAssessmentMode.EditValue == null || cmbAssessmentYear.EditValue == null)
                    return;
                if (ObjEAssessment == null)
                    ObjEAssessment = new EAssessment();
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;

                ObjDAssessment.GetEmployeeforMS(ObjEAssessment);
                gcYourTeamMembers.DataSource = ObjEAssessment.dtProjectEmployees;
                gcAllTeamMembers.DataSource = ObjEAssessment.dtAllEmployees;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvYourTeamMembers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (cmbAssessmentMode.EditValue == null || cmbAssessmentYear.EditValue == null)
                    return;
                if (gvYourTeamMembers.FocusedRowHandle >= 0)
                {
                    if (ObjEAssessment == null)
                        ObjEAssessment = new EAssessment();
                    ObjEAssessment.UserInfoID = Utility.UserID;
                    ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                    ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                    ObjEAssessment.EmployeeID = gvYourTeamMembers.GetFocusedRowCellValue("UserInfoID");
                    ObjEAssessment.IsYourTeam = true;
                    frmMAssessment obj = new frmMAssessment(ObjEAssessment);
                    obj.ShowInTaskbar = false;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvAllTeamMembers_DoubleClick(object sender, EventArgs e)
        {
            if (cmbAssessmentMode.EditValue == null || cmbAssessmentYear.EditValue == null)
                return;
            if (ObjEAssessment == null)
                ObjEAssessment = new EAssessment();
            if (gvAllTeamMembers.FocusedRowHandle >= 0)
            {
                ObjEAssessment.UserInfoID = Utility.UserID;
                ObjEAssessment.AssessMentYearID = cmbAssessmentYear.EditValue;
                ObjEAssessment.AssessMentModeID = cmbAssessmentMode.EditValue;
                ObjEAssessment.EmployeeID = gvAllTeamMembers.GetFocusedRowCellValue("UserInfoID");
                ObjEAssessment.IsYourTeam = false;
                frmMAssessment obj = new frmMAssessment(ObjEAssessment);
                obj.IconOptions.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
        }
    }
}