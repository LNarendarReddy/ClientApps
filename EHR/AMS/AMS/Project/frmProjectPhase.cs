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
using log4net;
using System.Globalization;
using System.Data.OleDb;
using DevExpress.XtraSplashScreen;

namespace EHR.Project
{
    public partial class frmProjectPhase : DevExpress.XtraEditors.XtraForm
    {
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DProject objDProject = new DProject();
        EProject objEProject = new EProject();
        public frmProjectPhase()
        {
            InitializeComponent();
        }
        private void frmProjectPhase_Load(object sender, EventArgs e)
        {
            try
            {
                objDProject.GetProjects(objEProject);
                cmbProject.Properties.DataSource = objEProject.dtProjects;
                cmbProject.Properties.ValueMember = "ProjectID";
                cmbProject.Properties.DisplayMember = "ProjectName";
                objEProject.ProjectPhaseID = -1;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                objEProject.UserID = Utility.UserID;
                objEProject.ProjectID = cmbProject.EditValue;
                objEProject.PhaseName = txtPhaseName.EditValue;
                objEProject.IsActive = chkIsActive.EditValue;
                objDProject.SaveProjectPhase(objEProject);
                gcPhase.DataSource = objEProject.dtPhase;
                Utility.Setfocus(gvPhase, "ProjectPhaseID", objEProject.ProjectPhaseID);
                objEProject.ProjectPhaseID = -1;
                txtPhaseName.EditValue = null;
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbProject_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbProject.EditValue != null)
                {
                    objEProject.ProjectID = cmbProject.EditValue;
                    objDProject.GetProjectPhase(objEProject);
                    gcPhase.DataSource = objEProject.dtPhase;
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
                objEProject.ProjectPhaseID = gvPhase.GetFocusedRowCellValue("ProjectPhaseID");
                cmbProject.EditValue = gvPhase.GetFocusedRowCellValue("ProjectID");
                txtPhaseName.EditValue = gvPhase.GetFocusedRowCellValue("PhaseName");
                chkIsActive.EditValue = gvPhase.GetFocusedRowCellValue("IsActive");
                txtPhaseName.Focus();
            }
            catch (Exception ex) { Log.Error(ex.Message, ex); Utility.ShowError(ex); }
        }
        private void btnViewTeam_Click(object sender, EventArgs e)
        {
            if (gvPhase.FocusedRowHandle >= 0)
            {
                objEProject.ProjectPhaseID = gvPhase.GetFocusedRowCellValue("ProjectPhaseID");
                frmProjectTeam obj = new frmProjectTeam(objEProject);
                obj.ShowIcon = false;
                obj.ShowInTaskbar = false;
                obj.StartPosition = FormStartPosition.CenterScreen;
                obj.ShowDialog();
            }
        }
        private void btnImportTestcases_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (XtraOpenFileDialog dialog = new XtraOpenFileDialog())
                {
                    dialog.Filter = "xlsx files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    dialog.FilterIndex = 2;
                    dialog.RestoreDirectory = true;

                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;
                    //Get the path of specified file
                    SplashScreenManager.ShowForm(null, typeof(frmSpinner), true, true, false);
                    SplashScreenManager.Default.SetWaitFormDescription("                  Reading Excel File...");
                    DataSet ds = ReadExcel(dialog.FileName);
                    SplashScreenManager.CloseForm();
                    frmViewTestCases obj = new
                        frmViewTestCases(ds, gvPhase.GetFocusedRowCellValue("ProjectPhaseID"));
                    obj.ShowInTaskbar = false;
                    obj.IconOptions.ShowIcon = false;
                    obj.WindowState = FormWindowState.Normal;
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                Utility.ShowError(ex);
            }
        }
        private DataSet ReadExcel(string strFilePath)
        {
            DataSet ds = new DataSet();
            try
            {
                DataTable dt = null;
                DataTable dtTablesList = default(DataTable);
                OleDbConnection oleExcelConnection = default(OleDbConnection);
                string constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFilePath + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
                if (strFilePath.ToLower().Contains(".xlsx"))
                    constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strFilePath + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                oleExcelConnection = new OleDbConnection(constring);
                oleExcelConnection.Open();
                dtTablesList = oleExcelConnection.GetSchema("Tables");
                foreach (DataRow dr in dtTablesList.Rows)
                {
                    if (Convert.ToString(dr["TABLE_NAME"]).ToLower().Equals("component$") ||
                        Convert.ToString(dr["TABLE_NAME"]).ToLower().Equals("requirement$") ||
                        Convert.ToString(dr["TABLE_NAME"]).ToLower().Equals("scenario$") ||
                        Convert.ToString(dr["TABLE_NAME"]).ToLower().Equals("testcase$"))
                    {
                        string sqlquery = $"Select * From [{ dr["TABLE_NAME"] }]";
                        OleDbDataAdapter da = new OleDbDataAdapter(sqlquery, oleExcelConnection);
                        dt = new DataTable();
                        da.Fill(dt);
                        ds.Tables.Add(dt);
                    }
                }
                oleExcelConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}