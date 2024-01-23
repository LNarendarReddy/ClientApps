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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace IMS
{
    public partial class frmDistributor : DevExpress.XtraEditors.XtraForm
    {
        EDistributor ObjEDistributor = new EDistributor();
        DDistributor ObjDDistributor = new DDistributor();
        List<Control> Requirefields = new List<Control>();
        public frmDistributor()
        {
            InitializeComponent();
        }

        private void frmDistributor_Load(object sender, EventArgs e)
        {
            try
            {
                Requirefields.Add(txtDistributorName);
                //Requirefields.Add(txtCPerson);
                //Requirefields.Add(txtEmailID);
                //Requirefields.Add(txtGSTIN);
                //Requirefields.Add(txtMobileNumber);
                //Requirefields.Add(txtBranchName);
                //Requirefields.Add(txtAddress);
                //Requirefields.Add(txtRemarks);

                ObjEDistributor = ObjDDistributor.GetDistributor(ObjEDistributor);
                gcDistributor.DataSource = ObjEDistributor.dtDistributor;
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cleatfields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Utility.ValidateRequiredFields(Requirefields))
                    return;
                ObjEDistributor.DistributorName = txtDistributorName.Text;
                ObjEDistributor.ContactPerson = txtCPerson.Text;
                ObjEDistributor.EmailID = txtEmailID.Text;
                ObjEDistributor.GSTIN = txtGSTIN.Text;
                ObjEDistributor.MobileNumber = txtMobileNumber.Text;
                ObjEDistributor.BranchName = txtBranchName.Text;
                ObjEDistributor.BAddress = txtAddress.Text;
                ObjEDistributor.Remarks = txtRemarks.Text;
                ObjEDistributor.UserID = Utility.UserID;
                ObjEDistributor = ObjDDistributor.SaveDistributor(ObjEDistributor);
                gcDistributor.DataSource = ObjEDistributor.dtDistributor;
                Utility.Setfocus(gvDistributor, "DistributorID", ObjEDistributor.DistributorID);
                Cleatfields();
                txtDistributorName.Focus();
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void Cleatfields()
        {
            ObjEDistributor.DistributorID = -1;
            txtDistributorName.Text = string.Empty;
            txtCPerson.Text = string.Empty;
            txtEmailID.Text = string.Empty;
            txtGSTIN.Text = string.Empty;
            txtMobileNumber.Text = string.Empty;
            txtBranchName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRemarks.Text = string.Empty;
        }

        private void frmDistributor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                btnCancel_Click(null, null);
        }

        private void gcDistributor_ProcessGridKey(object sender, KeyEventArgs e)
        {
            try
            {
                var grid = sender as GridControl;
                var view = grid.FocusedView as GridView;
                if (e.KeyData == Keys.Delete)
                {
                    int IValue = 0;
                    if (gvDistributor.GetFocusedRowCellValue("DistributorID") != null
                        && int.TryParse(Convert.ToString(gvDistributor.GetFocusedRowCellValue("DistributorID")), out IValue))
                    {
                        var dlgresult = XtraMessageBox.Show("You Want to delete Distributor..?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dlgresult.ToString().ToLower() == "ok")
                        {
                            ObjEDistributor.DistributorID = IValue;
                            ObjEDistributor = ObjDDistributor.DeleteDistributor(ObjEDistributor);
                            gvDistributor.DeleteSelectedRows();
                            ObjEDistributor.DistributorID = -1;
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

        private void gvDistributor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvDistributor.GetFocusedRowCellValue("DistributorID") != null
                        && int.TryParse(Convert.ToString(gvDistributor.GetFocusedRowCellValue("DistributorID")), out IValue))
                    {
                        ObjEDistributor.DistributorID = IValue;
                        txtDistributorName.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("DistributorName"));
                        txtCPerson.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("ContactPerson"));
                        txtEmailID.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("EmailID"));
                        txtGSTIN.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("GSTIN"));
                        txtMobileNumber.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("MobileNumber"));
                        txtBranchName.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("BranchName"));
                        txtAddress.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("BAddress"));
                        txtRemarks.Text = Convert.ToString(gvDistributor.GetFocusedRowCellValue("Remarks"));
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}