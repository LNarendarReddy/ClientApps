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
using log4net;
using DL;

namespace EHR.Project
{
    public partial class frmRequirement : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = null;
        public bool ViewMode = false;
        private bool NewMode = true;
        frmProject frmparent = null;
        public frmRequirement(EProject _objEProject, frmProject _frmparent)
        {
            InitializeComponent();
            objEProject = _objEProject;
            frmparent = _frmparent;
        }
        private void frmRequirement_Load(object sender, EventArgs e)
        {
            try
            {
                objDProject.GetComponentforDropDown(objEProject);
                cmbComponent.Properties.DataSource = objEProject.dtComponentfroDropDown;
                cmbComponent.Properties.ValueMember = "ComponentID";
                cmbComponent.Properties.DisplayMember = "ComponentName";
                if (Convert.ToInt32(objEProject.RequirementID) > 0)
                {
                    txtRequirementName.EditValue = objEProject.RequirementName;
                    txtShortDescription.EditValue = objEProject.RDescription;
                    cmbComponent.EditValue = objEProject.ComponentID;
                    objDProject.GetRequirementDescription(objEProject);
                    txtLongDescription.RtfText =
                        Convert.ToString(objEProject.ComponentDescription);
                    NewMode = false;
                    this.Text = "Edit Requirement";
                }
                else
                {
                    cmbComponent.EditValue = objEProject.ComponentID;
                    this.Text = "New Requirement";
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
                objEProject.RequirementName = txtRequirementName.EditValue;
                objEProject.RDescription = txtShortDescription.EditValue;
                objEProject.Description = txtLongDescription.RtfText;
                objEProject.UserID = Utility.UserID;
                objDProject.SaveRequirement(objEProject);
                frmparent.gvReq.GridControl.DataSource = objEProject.dtRequirement;
                Utility.Setfocus(frmparent.gvReq, "RequirementID", objEProject.RequirementID);
                txtRequirementName.Focus();
                if(NewMode)
                {
                    objEProject.RequirementID = -1;
                    objEProject.RequirementName = txtRequirementName.EditValue = null;
                    objEProject.RDescription = txtShortDescription.EditValue = null;
                    objEProject.Description = txtLongDescription.RtfText = null;
                }
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
                    frmparent.gvReq.MovePrev();
                    GetRequirementDetails();
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
                    frmparent.gvReq.MoveNext();
                    GetRequirementDetails();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void GetRequirementDetails()
        {
            try
            {
                objEProject.RequirementID = frmparent.gvReq.GetFocusedRowCellValue("RequirementID");
                cmbComponent.EditValue = objEProject.ComponentID = frmparent.gvReq.GetFocusedRowCellValue("ComponentID");
                txtRequirementName.EditValue = objEProject.RequirementName = frmparent.gvReq.GetFocusedRowCellValue("RequirementName");
                txtShortDescription.EditValue = objEProject.RDescription = frmparent.gvReq.GetFocusedRowCellValue("RDescription");
                objDProject.GetRequirementDescription(objEProject);
                txtLongDescription.RtfText =
                        Convert.ToString(objEProject.ComponentDescription);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frmRequirement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
                btnPrevious_Click(null, null);
            else if (e.KeyCode == Keys.PageDown)
                btnNext_Click(null, null);
        }
    }
}