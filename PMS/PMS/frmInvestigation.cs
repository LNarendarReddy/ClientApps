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
using PMS;

namespace PMS
{
    public partial class frmInvestigation : DevExpress.XtraEditors.XtraForm
    {
        EPatient objEpatient = new EPatient();
        DPatient objDPatient = new DPatient();
        public frmInvestigation()
        {
            DataTable dtIvs = new DataTable();
            InitializeComponent();
            LoadCategory();
            objEpatient.BranchID = Utility.BranchID;
            objDPatient.GetInvestigationDetails(objEpatient);
            dtIvs = objEpatient.dtIvs;
            gdInvestigation.DataSource =dtIvs ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objEpatient.CatID = Convert.ToInt16(cmbCategory.EditValue);
                objEpatient.IvsDescription = txtDescription.Text.Trim();
                objEpatient.UserID = Utility.UserID;
                objEpatient.BranchID = Utility.BranchID;
                objEpatient.OrgID = Utility.OrgID;
                objDPatient.SaveInvestigationDetails(objEpatient);
                gdInvestigation.DataSource = objEpatient.dtIvs;
                txtDescription.Text = string.Empty;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void LoadCategory()
        {
            DataTable dtCat = new DataTable();
            try
            {
                objEpatient.BranchID = Utility.BranchID;
                objDPatient.GetCategory(objEpatient);
                dtCat = objEpatient.dtCategory;
                cmbCategory.Properties.DataSource = dtCat;
                cmbCategory.Properties.DisplayMember = "CategoryName";
                cmbCategory.Properties.ValueMember = "CategoryID";
            }
            catch (Exception ex) { }
        }
    }
}