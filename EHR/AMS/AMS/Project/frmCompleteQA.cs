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
    public partial class frmCompleteQA : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = null;
        public frmCompleteQA(EProject _objEProject)
        {
            InitializeComponent();
            objEProject = _objEProject;
        }
        private void btnCompleteQA_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                objEProject.BuildVersion = txtBuildVersion.EditValue;
                objEProject.BuildPath = txtBuildPath.EditValue;
                objEProject.ImpactAnalysis = txtImpactAnalysis.EditValue;
                objEProject.ImpactModules = txtImpactModules.EditValue;
                objEProject.BuildChanges = txtBuildChanges.EditValue;
                objEProject.QAComments = txtQAComments.EditValue;
                objEProject.UserID = Utility.UserID;
                objDProject.CompleteQA(objEProject);
                objEProject.IsSave = true;
                this.Close();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void frmCompleteQA_Load(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(objEProject.DevBuildID) > 0)
                {
                    txtBuildVersion.EditValue = objEProject.BuildVersion;
                    txtBuildPath.EditValue = objEProject.BuildPath;
                    txtImpactAnalysis.EditValue = objEProject.ImpactAnalysis;
                    txtImpactModules.EditValue = objEProject.ImpactModules;
                    txtBuildChanges.EditValue = objEProject.BuildChanges;
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