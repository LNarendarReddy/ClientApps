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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
using IMS.Reports;

namespace IMS
{
    public partial class frmBilling : DevExpress.XtraEditors.XtraForm
    {
        DPatient objDPatient = new DPatient();
        EPatient objEPatient = new EPatient();
        DMedicine ObjDMedicine = new DMedicine();
        EMedicine ObjEMedicine = new EMedicine();
        DBilling ObjDBilling = new DBilling();
        EBilling ObjEBilling = new EBilling();
        DataTable dtBilling = new DataTable();
        List<Control> RequireFields = new List<Control>();
      
        public frmBilling()
        {
            InitializeComponent();
        }
            
        private void frmBilling_Load(object sender, EventArgs e)
        {
            try
            {
                objEPatient = objDPatient.GetPatient(objEPatient);
                cmbPatientName.Properties.DataSource = objEPatient.dtPatient;
                cmbPatientName.Properties.DisplayMember = "PatientName";
                cmbPatientName.Properties.ValueMember = "PatientID";

                BindMedicine();

                dtBilling.Columns.Add("MedicineID", typeof(int));
                dtBilling.Columns.Add("MedicineName", typeof(string));
                dtBilling.Columns.Add("Unit", typeof(string));
                dtBilling.Columns.Add("BatchNoID", typeof(int));
                dtBilling.Columns.Add("BatchNumber", typeof(string));
                dtBilling.Columns.Add("MRP", typeof(decimal));
                dtBilling.Columns.Add("Quantity", typeof(int));
                dtBilling.Columns.Add("Total", typeof(decimal));

                RequireFields.Add(txtPatientID);
                RequireFields.Add(txtMobileNumber);
                RequireFields.Add(cmbPatientName);
                RequireFields.Add(txtGrandTotal);
                RequireFields.Add(txtNetPayable);
                RequireFields.Add(txtPaid);
                RequireFields.Add(txtDiscount);
                RequireFields.Add(txtDue);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbPatientName_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                if (editor.EditValue != null)
                {
                    DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                    txtPatientID.Text = Convert.ToString(row["PatientID"]);
                    txtMobileNumber.Text = Convert.ToString(row["MobileNumber"]);
                    txtDiscount.Text = "0";
                    int Ivalue = 0;
                    if (int.TryParse(txtPatientID.Text, out Ivalue))
                    {
                        ObjEBilling.PatientID = Ivalue;
                        ObjEBilling = ObjDBilling.GetPatientDue(ObjEBilling);
                        txtDue.Text = ObjEBilling.Due.ToString("F2");
                    }
                }
                else
                {
                    txtPatientID.Text = string.Empty;
                    txtMobileNumber.Text = string.Empty;
                    txtDiscount.Text = "0";
                    txtDue.Text = "0";
                    
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private decimal CalcGrandTotal()
        {
            decimal sum = 0;
            try
            {
                if(decimal.TryParse(Convert.ToString(dtBilling.Compute("SUM(Total)", string.Empty)),out sum))
                {
                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return sum;
        }

        private void txtGrandTotal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtGrandTotal.Text) && !string.IsNullOrEmpty(txtDiscount.Text))
                {
                    decimal GTotal = 0;
                    decimal Discount = 0;
                    if (decimal.TryParse(txtGrandTotal.Text, out GTotal) && decimal.TryParse(txtDiscount.Text, out Discount))
                        txtNetPayable.Text = (GTotal - Discount).ToString("F2");
                    else
                        txtNetPayable.Text = "0";
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void ClearFields()
        {
            try
            {
                dtBilling = new DataTable();
                dtBilling.Columns.Add("MedicineID", typeof(int));
                dtBilling.Columns.Add("MedicineName", typeof(string));
                dtBilling.Columns.Add("Unit", typeof(string));
                dtBilling.Columns.Add("BatchNoID", typeof(int));
                dtBilling.Columns.Add("BatchNumber", typeof(string));
                dtBilling.Columns.Add("MRP", typeof(decimal));
                dtBilling.Columns.Add("Quantity", typeof(int));
                dtBilling.Columns.Add("Total", typeof(decimal));
                gcBilling.DataSource = dtBilling;
                txtPatientID.Text = string.Empty;
                txtMobileNumber.Text = string.Empty;
                txtGrandTotal.Text = string.Empty;
                txtNetPayable.Text = string.Empty;
                txtDue.Text = string.Empty;
                txtPaid.Text = string.Empty;
                txtDiscount.Text = string.Empty;
                cmbPatientName.EditValue = null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(RequireFields))
                    return;
                if (dtBilling.Rows.Count > 0)
                {
                    int IValue = 0;
                    decimal DValue = 0;
                    ObjEBilling.BillID = -1;
                    if (int.TryParse(txtPatientID.Text, out IValue))
                        ObjEBilling.PatientID = IValue;
                    ObjEBilling.PatientName = cmbPatientName.Text;
                    ObjEBilling.MobileNumber = txtMobileNumber.Text;
                    if (decimal.TryParse(Convert.ToString(txtGrandTotal.EditValue), out DValue))
                        ObjEBilling.GrandTotal = DValue;
                    if (decimal.TryParse(Convert.ToString(txtNetPayable.EditValue), out DValue))
                        ObjEBilling.NetTotal = DValue;
                    if (decimal.TryParse(Convert.ToString(txtPaid.EditValue), out DValue))
                        ObjEBilling.PaidTotal = DValue;
                    if (decimal.TryParse(Convert.ToString(txtDue.EditValue), out DValue))
                        ObjEBilling.Due = DValue;
                    if (decimal.TryParse(Convert.ToString(txtDiscount.EditValue), out DValue))
                        ObjEBilling.Discount = DValue;
                    ObjEBilling.UserID = Utility.UserID;
                    ObjEBilling.dtBilling = dtBilling.Copy();
                    ObjEBilling = ObjDBilling.SaveBilling(ObjEBilling);

                    rptPatient rpt = new Reports.rptPatient();
                    ReportPrintTool printTool = new ReportPrintTool(rpt);
                    rpt.Parameters["BillID"].Value = ObjEBilling.BillID;
                    //rpt.Print();
                    rpt.ShowRibbonPreview();
                    BindMedicine();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbMedicineName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                    if (editor.EditValue != null)
                    {
                        DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                        if (row != null && cmbMedicineName.Text != string.Empty)
                        {
                            int IValue = 0;
                            decimal DValue = 0;
                            int MedicineID = 0;
                            int ICurrentStock = 0;
                            if (int.TryParse(Convert.ToString(row["MedicineID"]), out IValue))
                                MedicineID = IValue;
                            else
                                return;
                            if (int.TryParse(Convert.ToString(row["CurrentStock"]), out IValue))
                                ICurrentStock = IValue;
                            string strQuantity = string.Empty;
                            string strUnit = string.Empty;
                            decimal DPrice = 0;
                            if (MedicineID <= 0)
                            {
                                frmNewMedicine Obj = new frmNewMedicine();
                                Obj.ShowDialog();
                                strQuantity = Obj.strQuantity;
                                strUnit = Obj.strUnit;
                                DPrice = Obj.Price;
                            }
                            else
                            {
                                frmModelPopup Obj = new frmModelPopup("quantity");
                                Obj.CurretStock = ICurrentStock;
                                Obj.ShowDialog();
                                strQuantity = Obj.strValue;
                            }
                            if (!string.IsNullOrEmpty(strQuantity))
                            {
                                string MedicineName = string.Empty;
                                string Unit = string.Empty;
                                int BatchNoID = 0;
                                string BatchNumber = string.Empty;
                                decimal MRP = 0;
                                int Quantity = 0;
                                decimal Total = 0;

                                if (int.TryParse(strQuantity, out IValue))
                                    Quantity = IValue;
                                else
                                    return;

                                MedicineName = Convert.ToString(row["MedicineName"]);
                                if (MedicineID <= 0)
                                    Unit = strUnit;
                                else
                                    Unit = Convert.ToString(row["Unit"]);

                                if (int.TryParse(Convert.ToString(row["BatchNoID"]), out IValue))
                                    BatchNoID = IValue;
                                if (MedicineID <= 0)
                                    BatchNumber = "TESTBATCHNUMBER";
                                else
                                    BatchNumber = Convert.ToString(row["BatchNumber"]);

                                if (MedicineID <= 0)
                                    MRP = DPrice;
                                else
                                {
                                    if (decimal.TryParse(Convert.ToString(row["MRP"]), out DValue))
                                        MRP = DValue;
                                }

                                Total = MRP * Quantity;

                                DataRow dr = dtBilling.NewRow();
                                dr["MedicineID"] = MedicineID;
                                dr["MedicineName"] = MedicineName;
                                dr["Unit"] = Unit;
                                dr["BatchNoID"] = BatchNoID;
                                dr["BatchNumber"] = BatchNumber;
                                dr["MRP"] = MRP;
                                dr["Quantity"] = Quantity;
                                dr["Total"] = Total;
                                dtBilling.Rows.Add(dr);
                                gcBilling.DataSource = dtBilling;
                                cmbMedicineName.EditValue = null;
                                cmbMedicineName.Focus();
                                txtGrandTotal.Text = CalcGrandTotal().ToString("F2");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gcBilling_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                var grid = sender as GridControl;
                var view = grid.FocusedView as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    var dlgresult = XtraMessageBox.Show("You Want to delete Medicine..?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlgresult.ToString().ToLower() == "ok")
                        gvbilling.DeleteSelectedRows();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvbilling_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView gv = (GridView)sender;
                gv.IndicatorWidth = 40;
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Appearance.ForeColor = System.Drawing.Color.Black;
                GridView gw = sender as GridView;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    e.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void cmbPatientName_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                DataRow Row;
                RepositoryItemLookUpEdit Edit;
                Edit = ((LookUpEdit)sender).Properties;
                if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                    return;
                DataTable LookupTable = (DataTable)cmbPatientName.Properties.DataSource;
                DataRow[] dr = LookupTable.Select("PatientID= -1");
                foreach (DataRow row in dr)
                    LookupTable.Rows.Remove(row);
                Row = LookupTable.NewRow();
                Row["PatientID"] = -1;
                Row["PatientName"] = e.DisplayValue;
                LookupTable.Rows.Add(Row);
                e.Handled = true;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void txtPatientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    int IValue = 0;
                    if (int.TryParse(txtPatientID.Text, out IValue))
                    {
                        objEPatient.PatientID = IValue;
                        objEPatient = objDPatient.GetPatientDetails(objEPatient);
                        if (objEPatient.dtPatientDetails != null && objEPatient.dtPatientDetails.Rows.Count > 0)
                        {
                            txtMobileNumber.Text = Convert.ToString(objEPatient.dtPatientDetails.Rows[0]["MobileNumber"]);
                            cmbPatientName.EditValue = objEPatient.dtPatientDetails.Rows[0]["PatientID"];
                            txtDiscount.Text = "0";
                            int Ivalue = 0;
                            if (int.TryParse(txtPatientID.Text, out Ivalue))
                            {
                                ObjEBilling.PatientID = Ivalue;
                                ObjEBilling = ObjDBilling.GetPatientDue(ObjEBilling);
                                txtDue.Text = ObjEBilling.Due.ToString("F2");
                            }
                        }
                        else
                        {
                            txtMobileNumber.Text = string.Empty;
                            cmbPatientName.EditValue = null;
                            txtDue.Text = "0";
                            txtDiscount.Text = "0";
                        }
                    }
                    else
                    {
                        txtMobileNumber.Text = string.Empty;
                        cmbPatientName.EditValue = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void BindMedicine()
        {
            try
            {
                ObjEMedicine = ObjDMedicine.GetMedicineForBilling(ObjEMedicine);
                cmbMedicineName.Properties.DataSource = ObjEMedicine.dtMedicine;
                cmbMedicineName.Properties.DisplayMember = "MedicineName";
                cmbMedicineName.Properties.ValueMember = "BatchNoID";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void cmbMedicineName_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                DataRow Row;
                RepositoryItemLookUpEdit Edit;
                Edit = ((LookUpEdit)sender).Properties;
                if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                    return;
                DataTable LookupTable = (DataTable)cmbMedicineName.Properties.DataSource;
                DataRow[] dr = LookupTable.Select("MedicineID= -1");
                foreach (DataRow row in dr)
                    LookupTable.Rows.Remove(row);
                Row = LookupTable.NewRow();
                Row["MedicineID"] = -1;
                Row["BatchNoID"] = -1;
                Row["MedicineName"] = e.DisplayValue;
                LookupTable.Rows.Add(Row);
                e.Handled = true;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void txtNetPayable_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal Due = 0;
                decimal NetValue = 0;
                if(decimal.TryParse(txtNetPayable.Text,out NetValue) && decimal.TryParse(txtDue.Text,out Due))
                {
                    decimal Total = NetValue + Due;
                    txtnetWithdue.Text = Total.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
     }
}