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
    public partial class frmScenario : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = null;
        public bool ViewMode = false;
        frmProject frmparent = null;
        private bool NewMode = true;
        public frmScenario(EProject _objEProject, frmProject _frmparent)
        {
            InitializeComponent();
            objEProject = _objEProject;
            frmparent = _frmparent;
        }
        private void frmScenario_Load(object sender, EventArgs e)
        {
            try
            {
                objDProject.GetComponentforDropDown(objEProject);
                cmbComponent.Properties.DataSource = objEProject.dtComponentfroDropDown;
                cmbComponent.Properties.ValueMember = "ComponentID";
                cmbComponent.Properties.DisplayMember = "ComponentName";
                if (Convert.ToInt32(objEProject.ScenarioID) > 0)
                {
                    txtScenario.EditValue = objEProject.SShortDescription;
                    cmbComponent.EditValue = objEProject.ComponentID;
                    cmbRequirement.EditValue = objEProject.RequirementID;
                    objDProject.GetScenarioDescription(objEProject);
                    txtLongDescription.RtfText =
                        Convert.ToString(objEProject.SLongDescription);
                    NewMode = false;
                    this.Text = "Edit Scneario";
                }
                else
                {
                    cmbComponent.EditValue = objEProject.ComponentID;
                    cmbRequirement.EditValue = objEProject.RequirementID;
                    this.Text = "New Scneario";
                }
                if (ViewMode)
                    btnSave.Enabled = false;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ViewMode)
                    return;
                if (!dxValidationProvider1.Validate())
                    return;
                if (string.IsNullOrEmpty(txtLongDescription.Text))
                    return;
                objEProject.ComponentID = cmbComponent.EditValue;
                objEProject.RequirementID = cmbRequirement.EditValue;
                objEProject.SShortDescription = txtScenario.EditValue;
                objEProject.SLongDescription = txtLongDescription.RtfText;
                objDProject.SaveScenario(objEProject);
                frmparent.gvSce.GridControl.DataSource = objEProject.dtScenario;
                Utility.Setfocus(frmparent.gvSce, "ScenarioID", objEProject.ScenarioID);
                txtScenario.Focus();
                if (NewMode)
                {
                    objEProject.ScenarioID = -1;
                    objEProject.ComponentID = cmbComponent.EditValue = null;
                    objEProject.RequirementID = cmbRequirement.EditValue = null;
                    objEProject.SShortDescription = txtScenario.EditValue = null;
                    objEProject.SLongDescription = txtLongDescription.RtfText = null;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void cmbComponent_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbComponent.EditValue == null)
                    return;
                objEProject.ComponentID = cmbComponent.EditValue;
                objDProject.GetRequirementForDropDown(objEProject);
                cmbRequirement.Properties.DataSource = objEProject.dtRequirementforDropDown;
                cmbRequirement.Properties.ValueMember = "RequirementID";
                cmbRequirement.Properties.DisplayMember = "RequirementName";
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave_Click(null, null);
                if (!NewMode)
                {
                    frmparent.gvSce.MovePrev();
                    GetScenarioDetails();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave_Click(null, null);
                if (!NewMode)
                {
                    frmparent.gvSce.MoveNext();
                    GetScenarioDetails();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void frmScenario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
                btnPrevious_Click(null, null);
            else if (e.KeyCode == Keys.PageDown)
                btnNext_Click(null, null);

        }
        private void GetScenarioDetails()
        {
            try
            {
                if(frmparent.gvSce.FocusedRowHandle>= 0)
                {

                    objEProject.ScenarioID = frmparent.gvSce.GetFocusedRowCellValue("ScenarioID");
                    txtScenario.EditValue = objEProject.SShortDescription = frmparent.gvSce.GetFocusedRowCellValue("ShortDescription");
                    cmbComponent.EditValue = frmparent.gvSce.GetFocusedRowCellValue("ComponentID");
                    cmbRequirement.EditValue = frmparent.gvSce.GetFocusedRowCellValue("RequirementID");
                    objDProject.GetScenarioDescription(objEProject);
                    txtLongDescription.RtfText =
                        Convert.ToString(objEProject.SLongDescription);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}