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

namespace PMS
{
    public partial class frmCategory : DevExpress.XtraEditors.XtraForm
    {
        EPatient objEpatient = new EPatient();
        DPatient objDPatient = new DPatient();

        public frmCategory()
        {
            InitializeComponent();
            objEpatient.BranchID = Utility.BranchID;
            objDPatient.GetCategory(objEpatient);
            DataTable dtCat = new DataTable();
            dtCat = objEpatient.dtCategory;
            gdCategory.DataSource = dtCat;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objEpatient.Category = txtCategory.Text.Trim();
                objEpatient.UserID = Utility.UserID;
                objEpatient.BranchID = Utility.BranchID;
                objEpatient.OrgID = Utility.OrgID;
                objDPatient.SaveCategory(objEpatient);
                gdCategory.DataSource = objEpatient.dtCategory;
                txtCategory.Text = string.Empty;
            }
            catch (Exception ex)
            { Utility.ShowError(ex); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmInvestigation obj = new frmInvestigation();
            obj.Show();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }
    }
}