using DevExpress.XtraEditors;
using DL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR.Project
{
    public partial class frmCopyTestCases : DevExpress.XtraEditors.XtraForm
    {
        DProject objDProject = new DProject();
        public frmCopyTestCases()
        {
            InitializeComponent();
        }

        private void frmCopyTestCases_Load(object sender, EventArgs e)
        {
            EProject objEProject = new EProject();
            objEProject = objDProject.GetProjects(objEProject);
            cmbFromProject.Properties.DataSource = objEProject.dtProjects;
            cmbFromProject.Properties.DisplayMember = "ProjectName";
            cmbFromProject.Properties.ValueMember = "ProjectID";

            cmbToProject.Properties.DataSource = objEProject.dtProjects;
            cmbToProject.Properties.DisplayMember = "ProjectName";
            cmbToProject.Properties.ValueMember = "ProjectID";
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
                objDProject.CopyTestCases(cmbFromProjectPhase.EditValue, cmbToProjectPhase.EditValue);
                XtraMessageBox.Show("Test cases copied successfully");
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbFromProject_EditValueChanged(object sender, EventArgs e)
        {
            EProject obje = new EProject();
            obje.ProjectID = cmbFromProject.EditValue;
            obje = objDProject.GetProjectPhase(obje);
            cmbFromProjectPhase.Properties.DataSource = obje.dtPhase;
            cmbFromProjectPhase.Properties.DisplayMember = "PhaseName";
            cmbFromProjectPhase.Properties.ValueMember = "ProjectPhaseID";
        }

        private void cmbToProject_EditValueChanged(object sender, EventArgs e)
        {
            EProject obje = new EProject();
            obje.ProjectID = cmbToProject.EditValue;
            obje = objDProject.GetProjectPhase(obje);
            cmbToProjectPhase.Properties.DataSource = obje.dtPhase;
            cmbToProjectPhase.Properties.DisplayMember = "PhaseName";
            cmbToProjectPhase.Properties.ValueMember = "ProjectPhaseID";
        }
    }
} 