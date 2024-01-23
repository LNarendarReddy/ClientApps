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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using IMS.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors.Repository;

namespace IMS
{
    public partial class frmConsultation : DevExpress.XtraEditors.XtraForm
    {
        DPatient objDPatient = new DPatient();
        EPatient objEPatient = new EPatient();
        List<Control> RequireFields = new List<Control>();

        public frmConsultation()
        {
            InitializeComponent();
        }

        private void frmConsultation_Load(object sender, EventArgs e)
        {
            try
            {
                objEPatient = objDPatient.GetPatient(objEPatient);
                cmbPatient.Properties.DataSource = objEPatient.dtPatient;
                cmbPatient.Properties.DisplayMember = "PatientName";
                cmbPatient.Properties.ValueMember = "PatientID";
                objEPatient = objDPatient.GetServices(objEPatient);
                Bindservice();
                RequireFields.Add(txtPatientID);
                RequireFields.Add(cmbPatient);
                RequireFields.Add(txtMobileNumber);
                RequireFields.Add(cmbService);
                RequireFields.Add(txtPrice);
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void Bindservice()
        {
            try
            {
                cmbService.Properties.DataSource = objEPatient.dtService;
                cmbService.Properties.DisplayMember = "ServiceName";
                cmbService.Properties.ValueMember = "ServiceID";
            }
            catch (Exception ex)
            {
                throw;
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
                            cmbPatient.EditValue = objEPatient.dtPatientDetails.Rows[0]["PatientID"];
                        }
                        else
                        {
                            txtMobileNumber.Text = string.Empty;
                            cmbPatient.EditValue = null;
                        }
                    }
                    else
                    {
                        txtMobileNumber.Text = string.Empty;
                        cmbPatient.EditValue = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbPatient_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                if (editor.EditValue != null)
                {
                    DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                    txtPatientID.Text = Convert.ToString(row["PatientID"]);
                    txtMobileNumber.Text = Convert.ToString(row["MobileNumber"]);
                }
                else
                {
                    txtPatientID.Text = string.Empty;
                    txtMobileNumber.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbService_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                    if (editor.EditValue != null)
                    {
                        DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                        if (row != null && cmbService.Text != string.Empty)
                        {
                            int IValue = 0;
                            if (int.TryParse(Convert.ToString(row["ServiceID"]), out IValue))
                            {
                                txtPrice.Text = Convert.ToString(row["Price"]);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(RequireFields))
                    return;
                int IValue = 0;
                decimal DValue = 0;
                if (int.TryParse(txtPatientID.Text, out IValue))
                    objEPatient.PatientID = IValue;
                objEPatient.PatientName = cmbPatient.Text;
                objEPatient.MobileNumber = txtMobileNumber.Text;
                if (int.TryParse(Convert.ToString(cmbService.EditValue), out IValue))
                    objEPatient.ServiceID = IValue;
                objEPatient.ServiceName = cmbService.Text;
                if (decimal.TryParse(Convert.ToString(txtPrice.EditValue), out DValue))
                    objEPatient.Price = DValue;
                objEPatient.UserID = Utility.UserID;
                objEPatient = objDPatient.SaveConsultation(objEPatient);

                rptConsultation rpt = new rptConsultation();
                ReportPrintTool printTool = new ReportPrintTool(rpt);
                rpt.Parameters["ConsultationID"].Value = objEPatient.ConsultationID;
                rpt.ShowRibbonPreview();
                //rpt.Print();
                cmbPatient.EditValue = null;
                cmbService.EditValue = null;
                txtPatientID.Focus();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbService_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.LookUpEdit editor = (sender as DevExpress.XtraEditors.LookUpEdit);
                if (editor.EditValue != null)
                {
                    DataRowView row = editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue) as DataRowView;
                    if (row != null && cmbService.Text != string.Empty)
                    {
                        int IValue = 0;
                        if (int.TryParse(Convert.ToString(row["ServiceID"]), out IValue))
                        {
                            txtPrice.Text = Convert.ToString(row["Cost"]);
                        }
                    }
                }
                else
                    txtPrice.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void cmbPatient_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            try
            {
                DataRow Row;
                RepositoryItemLookUpEdit Edit;
                Edit = ((LookUpEdit)sender).Properties;
                if (e.DisplayValue == null || Edit.NullText.Equals(e.DisplayValue) || string.Empty.Equals(e.DisplayValue))
                    return;
                DataTable LookupTable = (DataTable)cmbPatient.Properties.DataSource;
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

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                objEPatient = new EPatient();
                frmNewService Obj = new frmNewService(objEPatient);
                Obj.ShowDialog();
                if(!string.IsNullOrEmpty(objEPatient.ServiceName))
                {
                    objEPatient = objDPatient.SaveService(objEPatient);
                    Bindservice();
                    cmbService.EditValue = objEPatient.ServiceID;
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}