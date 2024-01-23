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

namespace EHR.Project
{
    public partial class frmAddNewProject : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = null;
        public frmAddNewProject(EProject _objEProject)
        {
            InitializeComponent();
            objEProject = _objEProject;
        }
        private void frmAddNewProject_Load(object sender, EventArgs e)
        {
            try
            {
                objDProject.GetUsers(objEProject);
                cmbProjectLead.Properties.DataSource = objEProject.dtUsers;
                cmbProjectLead.Properties.ValueMember = "UserInfoID";
                cmbProjectLead.Properties.DisplayMember = "FullName";
                if (Convert.ToInt32(objEProject.ProjectID) >0)
                {
                    txtProjectName.EditValue = objEProject.ProjectName;
                    cmbProjectLead.EditValue = objEProject.ProjectLeadID;
                    chkIsActive.EditValue = objEProject.IsActive;
                    txtClientName.EditValue = objEProject.ClientName;
                    txtSourceCodePath.EditValue = objEProject.SourceCodePath;
                    txtJiraProject.EditValue = objEProject.JiraProject;
                    txtProjectShortName.EditValue = objEProject.ProjectShortName;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                objEProject.ProjectName = txtProjectName.EditValue;
                objEProject.ProjectLeadID = cmbProjectLead.EditValue;
                objEProject.IsActive = chkIsActive.EditValue;
                objEProject.ClientName = txtClientName.EditValue;
                objEProject.SourceCodePath = txtSourceCodePath.EditValue;
                objEProject.JiraProject = txtJiraProject.EditValue;
                objEProject.ProjectShortName = txtProjectShortName.EditValue;
                objDProject.SaveProjectList(objEProject);
                objEProject.IsSave = true;
                this.Close();
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }
    }
}