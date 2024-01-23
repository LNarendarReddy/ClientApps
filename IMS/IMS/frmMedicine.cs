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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace IMS
{
    public partial class frmMedicine : DevExpress.XtraEditors.XtraForm
    {
        DMedicine ObjDMedicine = new DMedicine();
        EMedicine ObjEMedicine = new EMedicine();
        ECategory ObjECategory = new ECategory();
        DCategory ObjDCategory = new DCategory();

        List<Control> Requirefields = new List<Control>();
        public frmMedicine()
        {
            InitializeComponent();
        }

        private void frmMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                Requirefields.Add(txtMedicineName);
                Requirefields.Add(cmbCategoryName);
                Requirefields.Add(cmbMName);
                Requirefields.Add(cmbUnit);
                Requirefields.Add(txtReOrderLevel);
                Requirefields.Add(txtLocation);

                ObjEMedicine = ObjDMedicine.GetMedicine(ObjEMedicine);
                gcMedicine.DataSource = ObjEMedicine.dtMedicine;

                ObjECategory = ObjDCategory.GetCategory(ObjECategory);
                cmbCategoryName.Properties.DataSource = ObjECategory.dtCategory;
                cmbCategoryName.Properties.DisplayMember = "CategoryName";
                cmbCategoryName.Properties.ValueMember = "CategoryID";

                ObjEMedicine = ObjDMedicine.GetUnit(ObjEMedicine);
                cmbUnit.Properties.DataSource = ObjEMedicine.dtUnit;
                cmbUnit.Properties.DisplayMember = "Unit";
                cmbUnit.Properties.ValueMember = "UnitID";

                ObjEMedicine = ObjDMedicine.GetManufacturer(ObjEMedicine);
                cmbMName.Properties.DataSource = ObjEMedicine.dtManufacturer;
                cmbMName.Properties.DisplayMember = "MaufacturerName";
                cmbMName.Properties.ValueMember = "MaufacturerID";
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(Requirefields))
                    return;
                ObjEMedicine.MedicineName = txtMedicineName.Text;
                int IValue = 0;
                if (int.TryParse(Convert.ToString(cmbCategoryName.EditValue), out IValue))
                    ObjEMedicine.CategoryID = IValue;
                if (ObjEMedicine.CategoryID <= 0)
                    throw new Exception("Please select valid Category");
                ObjEMedicine.CategoryName = cmbCategoryName.Text;
                
                if (int.TryParse(Convert.ToString(cmbMName.EditValue), out IValue))
                    ObjEMedicine.MID = IValue;
                if (ObjEMedicine.MID <= 0)
                    throw new Exception("Please select valid Manufacturer");
                ObjEMedicine.MName = cmbMName.Text;

                if (int.TryParse(Convert.ToString(cmbUnit.EditValue), out IValue))
                    ObjEMedicine.UnitID = IValue;
                if (ObjEMedicine.UnitID <= 0)
                    throw new Exception("Please select valid Unit");
                ObjEMedicine.Unit = cmbUnit.Text;
                if (int.TryParse(txtReOrderLevel.Text, out IValue))
                    ObjEMedicine.ReOrderLevel = IValue;
                ObjEMedicine.Location = txtLocation.Text;
                ObjEMedicine.UserID = Utility.UserID;
                ObjEMedicine = ObjDMedicine.SaveMedicine(ObjEMedicine);
                gcMedicine.DataSource = ObjEMedicine.dtMedicine;
                Utility.Setfocus(gvMedicine, "MedicineID", ObjEMedicine.MedicineID);
                ClearFields();
                txtMedicineName.Focus();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void frmMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                btnCancel_Click(null, null);
        }

        private void gcMedicine_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                var grid = sender as GridControl;
                var view = grid.FocusedView as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int IValue = 0;
                    if (gvMedicine.GetFocusedRowCellValue("MedicineID") != null
                        && int.TryParse(Convert.ToString(gvMedicine.GetFocusedRowCellValue("MedicineID")), out IValue))
                    {
                        var dlgresult = XtraMessageBox.Show("You Want to delete Medicine..?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dlgresult.ToString().ToLower() == "ok")
                        {
                            ObjEMedicine.MedicineID = IValue;
                            ObjEMedicine = ObjDMedicine.DeleteMedicine(ObjEMedicine);
                            gvMedicine.DeleteSelectedRows();
                            ObjEMedicine.MedicineID = -1;
                        }
                    }
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvMedicine_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvMedicine.GetFocusedRowCellValue("MedicineID") != null
                        && int.TryParse(Convert.ToString(gvMedicine.GetFocusedRowCellValue("MedicineID")), out IValue))
                    {
                        ObjEMedicine.MedicineID = IValue;
                        txtMedicineName.Text = Convert.ToString(gvMedicine.GetFocusedRowCellValue("MedicineName"));
                        txtReOrderLevel.Text = Convert.ToString(gvMedicine.GetFocusedRowCellValue("ReOrderLevel"));
                        txtLocation.Text = Convert.ToString(gvMedicine.GetFocusedRowCellValue("Location"));
                        cmbCategoryName.EditValue = gvMedicine.GetFocusedRowCellValue("CategoryID");
                        cmbMName.EditValue = gvMedicine.GetFocusedRowCellValue("MID");
                        cmbUnit.EditValue = gvMedicine.GetFocusedRowCellValue("UnitID");
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void ClearFields()
        {
            ObjEMedicine.MedicineID = -1;
            txtMedicineName.Text = string.Empty;
            txtReOrderLevel.Text = string.Empty;
            txtLocation.Text = string.Empty;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                frmModelPopup Obj = new frmModelPopup("category");
                Obj.ShowDialog();
                if (!string.IsNullOrEmpty(Obj.strValue))
                {
                    ObjECategory.CategoryID = -1;
                    ObjECategory.CategoryName = Obj.strValue;
                    ObjECategory = ObjDCategory.SaveCategory(ObjECategory);
                    cmbCategoryName.Properties.DataSource = ObjECategory.dtCategory;
                    cmbCategoryName.Properties.DisplayMember = "CategoryName";
                    cmbCategoryName.Properties.ValueMember = "CategoryID";
                    cmbCategoryName.EditValue = ObjECategory.CategoryID;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnAddManufacturer_Click(object sender, EventArgs e)
        {
            try
            {
                frmModelPopup Obj = new frmModelPopup("mname");
                Obj.ShowDialog();
                if (!string.IsNullOrEmpty(Obj.strValue))
                {
                    ObjEMedicine.MID = -1;
                    ObjEMedicine.MName = Obj.strValue;
                    ObjEMedicine = ObjDMedicine.SaveManufacturer(ObjEMedicine);
                    cmbMName.Properties.DataSource = ObjEMedicine.dtManufacturer;
                    cmbMName.Properties.DisplayMember = "MaufacturerName";
                    cmbMName.Properties.ValueMember = "MaufacturerID";
                    cmbMName.EditValue = ObjEMedicine.MID;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            try
            {
                frmModelPopup Obj = new frmModelPopup("unit");
                Obj.ShowDialog();
                if (!string.IsNullOrEmpty(Obj.strValue))
                {
                    ObjEMedicine.UnitID = -1;
                    ObjEMedicine.Unit = Obj.strValue;
                    ObjEMedicine = ObjDMedicine.SaveUnit(ObjEMedicine);
                    cmbUnit.Properties.DataSource = ObjEMedicine.dtUnit;
                    cmbUnit.Properties.DisplayMember = "Unit";
                    cmbUnit.Properties.ValueMember = "UnitID";
                    cmbUnit.EditValue = ObjEMedicine.UnitID;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}