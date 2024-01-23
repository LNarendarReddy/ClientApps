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

namespace EHR
{
    public partial class frmProjectTeam : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject =null;
        public frmProjectTeam(EProject _objEProject)
        {
            InitializeComponent();
            objEProject = _objEProject;
        }
        private void frmProjectTeam_Load(object sender, EventArgs e)
        {
            try
            {
                objDProject.GetUsers(objEProject);
                gcTeam.DataSource = objEProject.dtUsers;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        { 
            try
            {
                if (gvTeam.FocusedRowHandle >= 0)
                {
                    objEProject.ProjectEmployeeID = -1;
                    objEProject.EmployeeID = gvTeam.GetFocusedRowCellValue("UserInfoID");
                    objEProject.UserID = Utility.UserID;
                    objEProject.IsActive = true;
                    objDProject.SaveProjectTeam(objEProject);
                    objEProject.IsSave = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}