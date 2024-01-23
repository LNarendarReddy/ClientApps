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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using System.IO;

namespace IMS
{
    public partial class frmStockEntry : DevExpress.XtraEditors.XtraForm
    {
        EDistributor ObjEDistributor = new EDistributor();
        DDistributor ObjDDistributor = new DDistributor();
        DMedicine ObjDMedicine = new DMedicine();
        EMedicine ObjEMedicine = new EMedicine();
        DInvoice ObjDInvoice = new DInvoice();
        EInvoice ObjEInvoice = new EInvoice();
        public bool _IsLoad = false;
        public int _InvoiceID = 0;

        List<Control> RequireFields = new List<Control>();
        List<Control> StockRequireFields = new List<Control>();

        DataTable dtStockEntry = null;

        public frmStockEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(RequireFields))
                    return;
                if (dtStockEntry.Rows.Count > 0)
                {
                    ObjEInvoice.InvoiceNumber = txtInvoiceNumber.Text;
                    int IValue = 0;
                    if (int.TryParse(Convert.ToString(cmbDistributor.EditValue), out IValue))
                        ObjEInvoice.DistributorID = IValue;
                    else
                        throw new Exception("Please Select Distributor");
                    decimal DValue = 0;
                    if (decimal.TryParse(Convert.ToString(txtGrandTotal.EditValue), out DValue))
                        ObjEInvoice.GrandTotal = DValue;
                    if (decimal.TryParse(Convert.ToString(txtCGST.EditValue), out DValue))
                        ObjEInvoice.CGST = DValue;
                    if (decimal.TryParse(Convert.ToString(txtSGST.EditValue), out DValue))
                        ObjEInvoice.SGST = DValue;
                    if (File.Exists(txtImagePath.Text))
                        ObjEInvoice.ImageData = File.ReadAllBytes(txtImagePath.Text);
                    ObjEInvoice.ImagePath = txtImagePath.Text;
                    ObjEInvoice.InvoiceDate = dtpInvoiceDate.DateTime;
                    ObjEInvoice.dtStockEntry = dtStockEntry.Copy();
                    ObjEInvoice = ObjDInvoice.SaveInvoice(ObjEInvoice);
                    ClearFields();
                }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMedicine.EditValue != null)
                {
                    if (!Utility.ValidateRequiredFields(StockRequireFields))
                        return;
                    DataRowView row = cmbMedicine.Properties.GetDataSourceRowByKeyValue(cmbMedicine.EditValue) as DataRowView;
                    if (row != null && cmbMedicine.Text != string.Empty)
                    {
                        int IValue = 0;
                        decimal DValue = 0;
                        int MedicineID = 0;
                        string MedicineName = string.Empty;
                        decimal MRP = 0;
                        decimal PPrice = 0;
                        int Quantity = 0;
                        decimal Total = 0;

                        if (int.TryParse(Convert.ToString(row["MedicineID"]), out IValue))
                            MedicineID = IValue;
                        MedicineName = Convert.ToString(row["MedicineName"]);
                        if (int.TryParse(Convert.ToString(txtQuantity.EditValue), out IValue))
                            Quantity = IValue;
                        else
                            return;
                        if (decimal.TryParse(Convert.ToString(txtMRP.EditValue), out DValue))
                            MRP = DValue;
                        if (decimal.TryParse(Convert.ToString(txtPPrice.EditValue), out DValue))
                            PPrice = DValue;
                        Total = MRP * Quantity;
                        
                        DataRow dr = dtStockEntry.NewRow();
                        dr["MedicineID"] = MedicineID;
                        dr["MedicineName"] = MedicineName;
                        dr["MName"] = txtManufacturer.Text;
                        dr["BatchNoID"] = cmbBatchNumber.EditValue;
                        dr["BatchNumber"] = cmbBatchNumber.Text;
                        dr["MRP"] = MRP;
                        dr["PPrice"] = PPrice;
                        dr["Quantity"] = Quantity;
                        dr["Total"] = Total;
                        dr["ExpiryDate"] = dtpExpiryDate.DateTime;

                        dtStockEntry.Rows.Add(dr);
                        gcStockEntry.DataSource = dtStockEntry;
                        txtGrandTotal.Text = CalcGrandTotal().ToString("F2");
                        ClearStockFields();
                        cmbMedicine.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void frmStockEntry_Load(object sender, EventArgs e)
        {
            try
            {

                ObjEDistributor = ObjDDistributor.GetDistributor(ObjEDistributor);
                cmbDistributor.Properties.DataSource = ObjEDistributor.dtDistributor;
                cmbDistributor.Properties.DisplayMember = "DistributorName";
                cmbDistributor.Properties.ValueMember = "DistributorID";

                ObjEMedicine = ObjDMedicine.GetMedicine(ObjEMedicine);
                cmbMedicine.Properties.DataSource = ObjEMedicine.dtMedicine;
                cmbMedicine.Properties.ValueMember = "MedicineID";
                cmbMedicine.Properties.DisplayMember = "MedicineName";

                if (!_IsLoad)
                {
                    IntializeDataTable();
                    RequireFields.Add(cmbDistributor);
                    RequireFields.Add(txtInvoiceNumber);
                    RequireFields.Add(txtGrandTotal);
                    RequireFields.Add(txtCGST);
                    RequireFields.Add(txtSGST);

                    StockRequireFields.Add(cmbMedicine);
                    StockRequireFields.Add(cmbBatchNumber);
                    StockRequireFields.Add(txtMRP);
                    StockRequireFields.Add(txtPPrice);
                    StockRequireFields.Add(txtQuantity);

                    dtpInvoiceDate.DateTime = DateTime.Now;
                    dtpExpiryDate.DateTime = DateTime.Now;
                }
                else
                {
                    ObjEInvoice.InvoiceID = _InvoiceID;
                    ObjEInvoice = ObjDInvoice.GetInvoiceDetails(ObjEInvoice);
                    cmbDistributor.EditValue = ObjEInvoice.DistributorID;
                    txtInvoiceNumber.Text = ObjEInvoice.InvoiceNumber;
                    dtpInvoiceDate.DateTime = ObjEInvoice.InvoiceDate;
                    txtGrandTotal.Text = ObjEInvoice.GrandTotal.ToString("F2");
                    txtCGST.Text = ObjEInvoice.CGST.ToString("F2");
                    txtSGST.Text = ObjEInvoice.SGST.ToString("F2");
                    gcStockEntry.DataSource = ObjEInvoice.dtInvoiceDetails;
                    btnAdd.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
               }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbMedicine_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                if (editor.EditValue != null)
                {
                    DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                    txtManufacturer.Text = Convert.ToString(row["MName"]);
                    int IValue = 0;
                    if (int.TryParse(Convert.ToString(editor.EditValue), out IValue))
                    {
                        ObjEInvoice.MedicineID = IValue;
                        ObjEInvoice = ObjDInvoice.GetBatchNumbers(ObjEInvoice);
                        cmbBatchNumber.Properties.DataSource = ObjEInvoice.dtBatchNumber;
                        cmbBatchNumber.Properties.ValueMember = "BatchNoID";
                        cmbBatchNumber.Properties.DisplayMember = "BatchNumber";
                    }
                    else
                        cmbBatchNumber.Properties.DataSource = null;
                }
                else
                {
                    txtManufacturer.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gvStockEntry_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView gv = (GridView)sender;
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                e.Appearance.ForeColor = System.Drawing.Color.Black;
                GridView gw = sender as GridView;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void ClearFields()
        {
            IntializeDataTable();
            gcStockEntry.DataSource = dtStockEntry;
            txtInvoiceNumber.Text = string.Empty;
            dtpInvoiceDate.DateTime = DateTime.Now;
            cmbDistributor.EditValue = null;
        }

        private void ClearStockFields()
        {
            txtManufacturer.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            cmbBatchNumber.EditValue = null;
            txtMRP.Text = string.Empty;
            txtPPrice.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            cmbMedicine.EditValue = null;
            cmbBatchNumber.Properties.DataSource = null;
        }

        private void txtQuantity_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int Quantity = 0;
                decimal PPrice = 0;
                if(int.TryParse(txtQuantity.Text,out Quantity) 
                    && decimal.TryParse(txtPPrice.Text,out PPrice))
                {
                    decimal Total = Quantity * PPrice;
                    txtTotal.Text = Total.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gcStockEntry_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                var grid = sender as GridControl;
                var view = grid.FocusedView as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    var dlgresult = XtraMessageBox.Show("You Want to delete Medicine..?", "Confirmation",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlgresult.ToString().ToLower() == "ok")
                        gvStockEntry.DeleteSelectedRows();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void IntializeDataTable()
        {
            dtStockEntry = new DataTable();
            dtStockEntry.Columns.Add("MedicineID", typeof(int));
            dtStockEntry.Columns.Add("MedicineName", typeof(string));
            dtStockEntry.Columns.Add("MName", typeof(string));
            dtStockEntry.Columns.Add("BatchNoID", typeof(int));
            dtStockEntry.Columns.Add("BatchNumber", typeof(string));
            dtStockEntry.Columns.Add("MRP", typeof(decimal));
            dtStockEntry.Columns.Add("PPrice", typeof(decimal));
            dtStockEntry.Columns.Add("Quantity", typeof(int));
            dtStockEntry.Columns.Add("Total", typeof(decimal));
            dtStockEntry.Columns.Add("ExpiryDate", typeof(DateTime));
        }

        private void cmbBatchNumber_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                DataRow Row;
                RepositoryItemLookUpEdit Edit;
                Edit = ((LookUpEdit)sender).Properties;
                if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                    return;
                DataTable LookupTable = (DataTable)cmbBatchNumber.Properties.DataSource;
                DataRow[] dr = LookupTable.Select("BatchNoID= -1");
                foreach (DataRow row in dr)
                    LookupTable.Rows.Remove(row);
                Row = LookupTable.NewRow();
                Row["BatchNoID"] = -1;
                Row["BatchNumber"] = e.DisplayValue;
                LookupTable.Rows.Add(Row);
                e.Handled = true;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbBatchNumber_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if(int.TryParse(Convert.ToString(cmbBatchNumber.EditValue),out IValue) && IValue > 0)
                {
                    ObjEInvoice.BatchNoID = IValue;
                    ObjEInvoice = ObjDInvoice.GetBatchDetails(ObjEInvoice);
                    if(ObjEInvoice.dtBatchDetails != null && ObjEInvoice.dtBatchDetails.Rows.Count > 0)
                    {
                        DateTime dt = DateTime.Now;
                        txtMRP.Text = Convert.ToString(ObjEInvoice.dtBatchDetails.Rows[0]["MRP"]);
                        txtPPrice.Text = Convert.ToString(ObjEInvoice.dtBatchDetails.Rows[0]["PPrice"]);
                        if (DateTime.TryParse(Convert.ToString(ObjEInvoice.dtBatchDetails.Rows[0]["ExpiryDate"]), out dt))
                            dtpExpiryDate.DateTime = dt;
                        else
                            dtpExpiryDate.DateTime = dt;
                    }
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
                if (decimal.TryParse(Convert.ToString(dtStockEntry.Compute("SUM(Total)", string.Empty)), out sum))
                {

                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
            return sum;
        }

        private void cmbDistributor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int IValue = 0;
                if(int.TryParse(Convert.ToString(cmbDistributor.EditValue),out IValue))
                {
                    ObjEInvoice.DistributorID = IValue;
                    ObjEInvoice = ObjDInvoice.GetDistributorDue(ObjEInvoice);
                    txtCGST.Text = "0";
                    txtSGST.Text = "0";
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    txtImagePath.Text = openFileDialog1.FileName;
                } 
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void frmStockEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
    }
}