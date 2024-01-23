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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace IMS
{
    public partial class frmPatient : DevExpress.XtraEditors.XtraForm
    {
        EPatient ObjEPatient = new EPatient();
        DPatient ObjDPatient = new DPatient();
        List<Control> Requirefields = new List<Control>();
        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            try
            {
                Requirefields.Add(txtPatientName);
                Requirefields.Add(txtMobileNumber);
                Requirefields.Add(txtAge);
                //Requirefields.Add(txtAadhaarNumber);
                //Requirefields.Add(txtCPerson1);
                //Requirefields.Add(txtCPMobile1);
                //Requirefields.Add(txtCPerson2);
                //Requirefields.Add(txtCPMobile2);
                //Requirefields.Add(txtEmail);

                ObjEPatient = ObjDPatient.GetPatient(ObjEPatient);
                gcPatient.DataSource = ObjEPatient.dtPatient;
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

                ObjEPatient.PatientName = txtPatientName.Text;
                ObjEPatient.MobileNumber = txtMobileNumber.Text;
                int IValue = 0;
                if (int.TryParse(txtAge.Text, out IValue))
                    ObjEPatient.Age = IValue;
                else
                    ObjEPatient.Age = 0;
                if (rgGender.SelectedIndex == 0)
                    ObjEPatient.Gender = "Male";
                else
                    ObjEPatient.Gender = "Female";
                ObjEPatient.Email = txtEmail.Text;
                ObjEPatient.CPerson1 = txtCPerson1.Text;
                ObjEPatient.CPMobile1 = txtCPMobile1.Text;
                ObjEPatient.CPerson2 = txtCPerson2.Text;
                ObjEPatient.CPMobile2 = txtCPMobile2.Text;
                ObjEPatient.AadhaarNumber = txtAadhaarNumber.Text;
                ObjEPatient.UserID = Utility.UserID;
                ObjEPatient = ObjDPatient.SavePatient(ObjEPatient);
                gcPatient.DataSource = ObjEPatient.dtPatient;
                Utility.Setfocus(gvPatient, "PatientID", ObjEPatient.PatientID);
                ClearFields();
                txtPatientName.Focus();
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

        private void ClearFields()
        {
            ObjEPatient.PatientID = -1;
            txtPatientName.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtAadhaarNumber.Text = string.Empty;
            txtCPerson1.Text = string.Empty;
            txtCPMobile1.Text = string.Empty;
            txtCPerson2.Text = string.Empty;
            txtCPMobile2.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void frmPatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                btnCancel_Click(null, null);
            }
        }

        private void gvPatient_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvPatient.GetFocusedRowCellValue("PatientID") != null
                        && int.TryParse(Convert.ToString(gvPatient.GetFocusedRowCellValue("PatientID")), out IValue))
                    {
                        ObjEPatient.PatientID = IValue;
                        txtPatientName.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("PatientName"));
                         txtMobileNumber.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("MobileNumber"));
                        txtAge.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("Age"));
                        string strGender = Convert.ToString(gvPatient.GetFocusedRowCellValue("Gender"));
                        if (strGender.ToLower() == "male")
                            rgGender.SelectedIndex = 0;
                        else
                            rgGender.SelectedIndex = 1;
                        txtEmail.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("Email"));
                        txtCPerson1.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("CPerson1"));
                        txtCPMobile1.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("CPMobile1"));
                        txtCPerson2.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("CPerson2"));
                        txtCPMobile2.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("CPMobile2"));
                        txtAadhaarNumber.Text = Convert.ToString(gvPatient.GetFocusedRowCellValue("AadhaarNumber"));
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void gcPatient_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                var grid = sender as GridControl;
                var view = grid.FocusedView as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int IValue = 0;
                    if (gvPatient.GetFocusedRowCellValue("PatientID") != null
                        && int.TryParse(Convert.ToString(gvPatient.GetFocusedRowCellValue("PatientID")), out IValue))
                    {
                        var dlgresult = XtraMessageBox.Show("You Want to delete Patient..?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dlgresult.ToString().ToLower() == "ok")
                        {
                            ObjEPatient.PatientID = IValue;
                            ObjEPatient = ObjDPatient.DeletePatient(ObjEPatient);
                            gvPatient.DeleteSelectedRows();
                            ObjEPatient.PatientID = -1;
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
    }
}