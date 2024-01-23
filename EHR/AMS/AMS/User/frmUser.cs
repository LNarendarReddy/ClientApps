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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using log4net;

namespace EHR
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        EUser ObjEUser = null;
        DUser ObjDUser = new DUser();
        public frmUser(EUser _ObjEUser)
        {
            InitializeComponent();
            ObjEUser = _ObjEUser;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDUser.GetRolesandDesignations(ObjEUser);
                cmbRole.Properties.DataSource = ObjEUser. dtRoles;
                cmbRole.Properties.DisplayMember = "RoleName";
                cmbRole.Properties.ValueMember = "RoleID";

                cmbDesignation.Properties.DataSource = ObjEUser.dtDesignations;
                cmbDesignation.Properties.DisplayMember = "DesignationName";
                cmbDesignation.Properties.ValueMember = "DesignationID";

                cmbReportingLead.Properties.DataSource = ObjEUser.dtUser;
                cmbReportingLead.Properties.DisplayMember = "FullName";
                cmbReportingLead.Properties.ValueMember = "UserInfoID";

                dtpJoiningDate.DateTime = DateTime.Now;
                dtpDOB.DateTime = DateTime.Now;
                rgGender.SelectedIndex = 0;

                DataTable dt = new DataTable();
                dt.Columns.Add("DepartmentID", typeof(int));
                dt.Columns.Add("Department", typeof(string));
                DataRow dr1 = dt.NewRow();
                dr1["DepartmentID"] = 1;
                dr1["Department"] = "Developement";
                dt.Rows.Add(dr1);

                DataRow dr2 = dt.NewRow();
                dr2["DepartmentID"] = 2;
                dr2["Department"] = "QA";
                dt.Rows.Add(dr2);

                DataRow dr3 = dt.NewRow();
                dr3["DepartmentID"] = 3;
                dr3["Department"] = "CRM";
                dt.Rows.Add(dr3);

                DataRow dr4 = dt.NewRow();
                dr4["DepartmentID"] = 4;
                dr4["Department"] = "HR";
                dt.Rows.Add(dr4);

                cmbDepartment.Properties.DataSource = dt;
                cmbDepartment.Properties.DisplayMember = "Department";
                cmbDepartment.Properties.ValueMember = "DepartmentID";

                if(ObjEUser.UserInfoID >0 )
                {
                    UserNameTextEdit.Text = ObjEUser.UserName;
                    FullNameTextEdit.Text = ObjEUser.FullName;
                    CNumberTextEdit.Text = ObjEUser.CNumber;
                    EMailTextEdit.Text = ObjEUser.Email;
                    cmbRole.EditValue = ObjEUser.RoleID;
                    cmbDesignation.EditValue = ObjEUser.DesignationID;
                    cmbReportingLead.EditValue = ObjEUser.ReportingLeadID;
                    rgGender.EditValue = ObjEUser.gender;
                    dtpDOB.EditValue = ObjEUser.DOB;
                    dtpJoiningDate.EditValue = ObjEUser.JoiningDate;
                    cmbDepartment.EditValue = ObjEUser.DepartmentID;
                    chkEmployeeStatus.EditValue = ObjEUser.EmployeeStatus;
                    chkEnableAssessment.EditValue = ObjEUser.EnableAssessment;
                    dtpResignationDate.EditValue = ObjEUser.ResignationDate;
                    dtpPLWDate.EditValue = ObjEUser.ProjectedLastWorkingDate;
                    dtpALWDate.EditValue = ObjEUser.ActualLastWorkingDate;
                    UserNameTextEdit.ReadOnly = true;
                }
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserNameTextEdit.Text = UserNameTextEdit.Text.Trim();
                FullNameTextEdit.Text = FullNameTextEdit.Text.Trim();
                CNumberTextEdit.Text = CNumberTextEdit.Text.Trim();
                EMailTextEdit.Text = EMailTextEdit.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEUser.UserName = UserNameTextEdit.Text.ToLower();
                ObjEUser.Password = Utility.Encrypt("Password@1234");
                ObjEUser.FullName = FullNameTextEdit.Text;
                ObjEUser.CNumber = CNumberTextEdit.Text;
                ObjEUser.Email = EMailTextEdit.Text;
                ObjEUser.UserID = Utility.UserID;
                ObjEUser.RoleID = cmbRole.EditValue;
                ObjEUser.DesignationID = cmbDesignation.EditValue;
                ObjEUser.ReportingLeadID = cmbReportingLead.EditValue;
                ObjEUser.gender = rgGender.SelectedIndex;
                ObjEUser.JoiningDate = dtpJoiningDate.EditValue;
                ObjEUser.DOB = dtpDOB.EditValue;
                ObjEUser.DepartmentID = cmbDepartment.EditValue;
                ObjEUser.EmployeeStatus = chkEmployeeStatus.EditValue;
                ObjEUser.EnableAssessment = chkEnableAssessment.EditValue;
                ObjEUser.ResignationDate = dtpResignationDate.EditValue;
                ObjEUser.ProjectedLastWorkingDate = dtpPLWDate.EditValue;
                ObjEUser.ActualLastWorkingDate = dtpALWDate.EditValue;
                ObjDUser.SaveUser(ObjEUser);
                ObjEUser.IsSave = true;
                this.Close();

            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ObjEUser.IsSave = false;
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjEUser.UserInfoID = -1;
            UserNameTextEdit.Text = string.Empty;
            FullNameTextEdit.Text = string.Empty;
            CNumberTextEdit.Text = string.Empty;
            EMailTextEdit.Text = string.Empty;
            cmbDesignation.EditValue = null;
            cmbRole.EditValue = null;
            cmbReportingLead.EditValue = null;
            dtpDOB.DateTime = DateTime.Now;
            dtpJoiningDate.DateTime = DateTime.Now;
            rgGender.SelectedIndex = 0;
            cmbDepartment.EditValue = null;
            chkEnableAssessment.EditValue = false;
            chkEmployeeStatus.EditValue = false;
            UserNameTextEdit.ReadOnly = false;
            UserNameTextEdit.Focus();
        }
    }
}