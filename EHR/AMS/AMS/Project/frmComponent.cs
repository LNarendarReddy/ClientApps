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
    public partial class frmComponent : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = null;
        public bool ViewMode = false;
        private bool NewMode = true;
        frmProject frmparent = null;
        public frmComponent(EProject _objEProject, frmProject _frmparent)
        {
            InitializeComponent();
            objEProject = _objEProject;
            frmparent = _frmparent;
        }
        private void frmComponent_Load(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt32(objEProject.ComponentID) > 0)
                {
                    txtComponentName.EditValue = objEProject.ComponentName;
                    objDProject.GetComponentDescription(objEProject);
                    txtComponentDescription.RtfText = 
                        Convert.ToString(objEProject.ComponentDescription);
                    NewMode = false;
                    this.Text = "Edit Component";
                }
                else
                {
                    this.Text = "New Component";
                    
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
                if (string.IsNullOrEmpty(txtComponentDescription.Text))
                    return;
                objEProject.ComponentName = txtComponentName.Text;
                objEProject.ComponentDescription = txtComponentDescription.RtfText;
                objDProject.SaveComponent(objEProject);
                frmparent.gvcomp.GridControl.DataSource = objEProject.dtComponent;
                Utility.Setfocus(frmparent.gvcomp, "ComponentID", objEProject.ComponentID);
                txtComponentName.Focus();
                if(NewMode)
                {
                    objEProject.ComponentID = -1;
                    objEProject.ComponentName = txtComponentName.EditValue = null;
                    objEProject.ComponentDescription = txtComponentDescription.RtfText = null;
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
                    frmparent.gvcomp.MovePrev();
                    GetComponentDetails();
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
                    frmparent.gvcomp.MoveNext();
                    GetComponentDetails();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
                Utility.ShowError(ex);
            }
        }
        private void GetComponentDetails()
        {
            try
            {
                objEProject.ComponentID = frmparent.gvcomp.GetFocusedRowCellValue("ComponentID");
                txtComponentName.EditValue = objEProject.ComponentName = frmparent.gvcomp.GetFocusedRowCellValue("ComponentName");
                objDProject.GetComponentDescription(objEProject);
                txtComponentDescription.RtfText =
                    Convert.ToString(objEProject.ComponentDescription);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void frmComponent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
                btnPrevious_Click(null, null);
            else if (e.KeyCode == Keys.PageDown)
                btnNext_Click(null, null);
        }
    }
}