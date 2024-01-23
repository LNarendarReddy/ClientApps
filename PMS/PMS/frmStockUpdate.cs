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
    public partial class frmStockUpdate : DevExpress.XtraEditors.XtraForm
    {
        EMedicine ObjEMedicine = new EMedicine();
        DMedicine ObjDMedicine = new DMedicine();
        public frmStockUpdate()
        {
            InitializeComponent();
        }
        private void LoadMedicineType()
        {
            try
            {
                ObjDMedicine.GetMedicineType(ObjEMedicine);
                //cmbMedicineType.Properties.DataSource = ObjEMedicine.dtMedicineType;
                //cmbMedicineType.Properties.DisplayMember = "TypeName";
                //cmbMedicineType.Properties.ValueMember = "MedicineTypeID";
                //cmbMedicineType.Properties.KeyMember = "Key";
            }
            catch (Exception ex) { }
        }
        private void LoadMedicineDetails()
        {
            try
            {
                ObjEMedicine.BranchID = Utility.BranchID;
                ObjDMedicine.GetMedicineList(ObjEMedicine);
                cmbMedicineName.Properties.DataSource = ObjEMedicine.dtMedicineList;
                cmbMedicineName.Properties.DisplayMember = "MedicineName";
                cmbMedicineName.Properties.ValueMember = "MedicineID";
                //cmbMedicineName.Properties.CascadingMember = "MedicineTypeID";
            }
            catch (Exception ex) { }
        }
        private void LoadMedicinePower()
        {
            try
            {
                ObjDMedicine.GetMedicinePower(ObjEMedicine);
                cmbPower.Properties.DataSource = ObjEMedicine.dtMedicinePower;
                cmbPower.Properties.DisplayMember = "PowerName";
                cmbPower.Properties.ValueMember = "MedicinePowerID";
            }
            catch (Exception ex) { }
        }

        private void cmbMedicineName_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dtMedicine = new DataTable();
            try
            {
                int ivalue = 0;
                if (int.TryParse(Convert.ToString(cmbMedicineName.EditValue), out ivalue))
                {
                    ObjEMedicine.MedicineID = ivalue;
                    ObjDMedicine.GetMedicinedetails(ObjEMedicine);
                    if (ObjEMedicine.dsMedicineDetails != null && ObjEMedicine.dsMedicineDetails.Tables.Count > 0)
                    {
                        dtMedicine = ObjEMedicine.dsMedicineDetails.Tables[0];
                        if (dtMedicine.Rows.Count > 0)
                        {
                            cmbPower.EditValue = dtMedicine.Rows[0]["MedicinePowerID"];
                            txtPrice.EditValue = dtMedicine.Rows[0]["SPrice"];
                            txtMedicineCode.EditValue = dtMedicine.Rows[0]["MedicineCode"];
                            txtMedincineType.EditValue = dtMedicine.Rows[0]["TypeName"];
                            decimal dvalue = 0;
                            if (decimal.TryParse(Convert.ToString(dtMedicine.Rows[0]["LooseStock"]), out dvalue))
                                lblCurrentStock.Text = Convert.ToString(dvalue);
                            else
                                lblCurrentStock.Text = " ";
                        }
                        else
                        {
                            cmbPower.EditValue = null;
                            txtPrice.EditValue = null;
                            txtMedicineCode.EditValue = null;
                            txtMedincineType.EditValue = null;
                            lblCurrentStock.Text = " ";
                        }
                    }
                }
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void frmStockUpdate_Load(object sender, EventArgs e)
        {
            LoadMedicineType();
            LoadMedicineDetails();
            LoadMedicinePower();
            lblCurrentStock.Text = "0";
            txtStockToAdd.Text = "0";
            txtStockToLoose.Text = "0";
        }

        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEMedicine.MedicineID = Convert.ToInt32(cmbMedicineName.EditValue);

                decimal DValue = 0;
                if (decimal.TryParse(txtStockToAdd.Text, out DValue))
                    ObjEMedicine.NoofPackstoAdd = DValue;
                
                if (decimal.TryParse(txtStockToLoose.Text, out DValue))
                    ObjEMedicine.NoofPackstoLess = DValue;

                ObjDMedicine.SaveMedicineStock(ObjEMedicine);
                ClearFields();
                cmbMedicineName.Focus();
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void ClearFields()
        {
            try
            {
                cmbMedicineName.EditValue = 0;
                lblCurrentStock.Text = "0";
                txtStockToAdd.Text = "0";
                txtStockToLoose.Text = "0";
                cmbPower.EditValue = 0;
                txtPrice.Text = string.Empty;
                txtMedicineCode.Text = string.Empty;
            }
            catch (Exception ex) { }
        }
    }
}