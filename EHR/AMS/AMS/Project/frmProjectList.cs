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
using DL;
using EL;
using DevExpress.XtraGrid.Views.Grid;
using log4net;
using EHR.Project;

namespace EHR
{
    public partial class frmProjectMaster : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = new EProject();
        public frmProjectMaster()
        {
            InitializeComponent();
        }
        private void frmSubTaskMaster_Load(object sender, EventArgs e)
        {
            try
            {
                objDProject.GetProjects(objEProject);
                gcSubTask.DataSource = objEProject.dtProjects;
                gvSubTask.ActiveFilterString = "[IsActive] = True";
                objDProject.GetUsers(objEProject);
                cmbTask.DataSource = objEProject.dtUsers;
                cmbTask.ValueMember = "UserInfoID";
                cmbTask.DisplayMember = "FullName";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }
        private void btnNewProject_Click(object sender, EventArgs e)
        {
            try
            {
                objEProject.ProjectID = -1;
                frmAddNewProject obj = new frmAddNewProject(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcSubTask.DataSource = objEProject.dtProjects;
                    Utility.Setfocus(gvSubTask, "ProjectID", objEProject.ProjectID);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objEProject.ProjectID = gvSubTask.GetFocusedRowCellValue("ProjectID");
                objEProject.ProjectName = gvSubTask.GetFocusedRowCellValue("ProjectName");
                objEProject.ProjectLeadID = gvSubTask.GetFocusedRowCellValue("UserInfoID");
                objEProject.IsActive = gvSubTask.GetFocusedRowCellValue("IsActive");
                objEProject.ClientName = gvSubTask.GetFocusedRowCellValue("ClientName");
                objEProject.SourceCodePath = gvSubTask.GetFocusedRowCellValue("SourceCodePath");
                objEProject.JiraProject = gvSubTask.GetFocusedRowCellValue("JiraProject");
                objEProject.ProjectShortName = gvSubTask.GetFocusedRowCellValue("ProjectShortName");

                frmAddNewProject obj = new frmAddNewProject(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
                if (objEProject.IsSave)
                {
                    gcSubTask.DataSource = objEProject.dtProjects;
                    Utility.Setfocus(gvSubTask, "ProjectID", objEProject.ProjectID);
                }
            }
            catch (Exception ex){
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if(gvSubTask.FocusedRowHandle >= 0)
            {
                frmProject obj = new frmProject(gvSubTask.GetFocusedRowCellValue("ProjectID"),
                    gvSubTask.GetFocusedRowCellValue("ProjectName"));
                obj.MdiParent = this.MdiParent;
                obj.Show();
            }
        }
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            gcSubTask.ShowRibbonPrintPreview();
        }
    }
}
