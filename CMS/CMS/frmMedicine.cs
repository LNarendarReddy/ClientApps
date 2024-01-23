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
using System.Resources;
using System.Reflection;
using EL;
using DL;
using DevExpress.XtraGrid.Views.Grid;

namespace CMS
{
    public partial class frmMedicine : DevExpress.XtraEditors.XtraForm
    {
        EMedicine ObjEMedicine = new EMedicine();
        DMedicine ObjDMedicine = new DMedicine();
        int MedicineID;
        public frmMedicine(int nMedicineID)
        {
            InitializeComponent();
            MedicineID = nMedicineID;
            MedicineDetails(MedicineID);
        }
        private void frmMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMedicineType();
                LoadMedicinedetails();
                txtPrice.EditValue = 0;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void LoadMedicineType()
        {
            try
            {
                ObjDMedicine.GetMedicineType(ObjEMedicine);
                cmbType.Properties.DataSource = ObjEMedicine.dtMedicineType;
                cmbType.Properties.DisplayMember = "TypeName";
                cmbType.Properties.ValueMember = "MedicineTypeID";
            }
            catch (Exception ex) { throw ex; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjEMedicine.MedicineID <= 0)
                    ObjEMedicine.MedicineID = -1;

                ObjEMedicine.MedicineCode = txtMedicineCode.Text.Trim();
                ObjEMedicine.MedinceName = txtMedName.Text.Trim();
                ObjEMedicine.GenericName = txtGenericName.Text.Trim();
                ObjEMedicine.MedicineTypeID = Convert.ToInt32(cmbType.EditValue);
                ObjEMedicine.MedicinePowerID = 1;
                ObjEMedicine.MedicineQuantity = 1;
                ObjEMedicine.MedicineMessureID = 1;
                ObjEMedicine.SPrice = Convert.ToDouble(txtPrice.EditValue);
                ObjEMedicine.ReorderLevel = 1;
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjEMedicine.OrgID = Utility.OrgID;
                ObjEMedicine.UserID = Utility.UserID;
                ObjDMedicine.SaveMedicine(ObjEMedicine);
                gdMedicine.DataSource = ObjEMedicine.dtMedicineList;
                Utility.Setfocus(gvMedicine, "MedicineID", ObjEMedicine.MedicineID);
                clearFields();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void LoadMedicinedetails()
        {
            try
            {
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjDMedicine.GetMedicineList(ObjEMedicine);
                gdMedicine.DataSource = ObjEMedicine.dtMedicineList;
            }
            catch (Exception ex) { throw ex; }
        }
        private void clearFields()
        {
            ObjEMedicine.MedicineID = -1;
            txtMedicineCode.Text = string.Empty;
            txtMedName.Text = string.Empty;
            txtGenericName.Text = string.Empty;
            cmbType.EditValue = -1;
            txtPrice.EditValue = 0;
            txtMedicineCode.Focus();
        }
        private void gvMedicine_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int nMedicineID = Convert.ToInt32(gvMedicine.GetFocusedRowCellValue("MedicineID"));
                MedicineDetails(nMedicineID);
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }
        private void MedicineDetails(int nMedicineID)
        {
            try
            {
                ObjEMedicine.MedicineID = nMedicineID;
                ObjDMedicine.GetMedicinedetails(ObjEMedicine);
                if (ObjEMedicine.dsMedicineDetails != null 
                    && ObjEMedicine.dsMedicineDetails.Tables.Count > 0 
                    && ObjEMedicine.dsMedicineDetails.Tables[0].Rows.Count > 0)
                {
                    txtMedicineCode.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicineCode"];
                    txtMedName.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicineName"];
                    txtGenericName.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["GenericName"];
                    cmbType.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["MedicineTypeID"];
                    txtPrice.EditValue = ObjEMedicine.dsMedicineDetails.Tables[0].Rows[0]["SPrice"];
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void btnNewMedicine_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}