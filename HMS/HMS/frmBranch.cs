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

namespace HMS
{
    public partial class frmBranch : DevExpress.XtraEditors.XtraForm
    {
        EBranch ObjEBranch = new EBranch();
        DBranch ObjDBranch = new DBranch();

        EUser ObjEUser = new EUser();
        DUser ObjDUser = new DUser();

        public frmBranch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                NameTextEdit.Text = NameTextEdit.Text.Trim();
                FullAddressMemoExEdit.Text = FullAddressMemoExEdit.Text.Trim();
                CPersonTextEdit.Text = CPersonTextEdit.Text.Trim();
                CNumberTextEdit.Text = CNumberTextEdit.Text.Trim();
                txtHindiAddress.Text = txtHindiAddress.Text.Trim();
                CNumberTextEdit.Text = CNumberTextEdit.Text.Trim();
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEBranch.Name = NameTextEdit.Text;
                ObjEBranch.FullAddress = FullAddressMemoExEdit.Text;
                ObjEBranch.CPerson = CPersonTextEdit.Text;
                ObjEBranch.CNumber = CNumberTextEdit.Text;
                ObjEBranch.HindiAddress = txtHindiAddress.EditValue;

                int ivalue = 0;
                if (int.TryParse(Convert.ToString(cmbOrg.EditValue), out ivalue))
                    ObjEBranch.OrgID = ivalue;
                else
                    throw new Exception("Please Select the Organization");

                ObjDBranch.SaveBranch(ObjEBranch);
                gcBranch.DataSource = ObjEBranch.dtBranch;
                Utility.Setfocus(gvBranch, "BranchID", ObjEBranch.BranchID);
                btnReset_Click(null, null);
            }
            catch (Exception ex){Utility.ShowError(ex);}   
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDUser.GetOrganization(ObjEUser);
                cmbOrg.Properties.DataSource = ObjEUser.dtOrg;
                cmbOrg.Properties.DisplayMember = "FullName";
                cmbOrg.Properties.ValueMember = "OrgID";

                ObjDBranch.GetBranch(ObjEBranch);
                gcBranch.DataSource = ObjEBranch.dtBranch;
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjEBranch.BranchID = -1;
            NameTextEdit.Text = string.Empty;
            FullAddressMemoExEdit.Text = string.Empty;
            CPersonTextEdit.Text = string.Empty;
            CNumberTextEdit.Text = string.Empty;
            cmbOrg.EditValue = null;
            cmbOrg.Focus();
        }   

        private void gvBranch_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                GridHitInfo info = view.CalcHitInfo(pt);
                if (info.InRow || info.InRowCell)
                {
                    int IValue = 0;
                    if (gvBranch.GetFocusedRowCellValue("BranchID") != null
                        && int.TryParse(Convert.ToString(gvBranch.GetFocusedRowCellValue("BranchID")), out IValue))
                    {
                        ObjEBranch.BranchID = IValue;
                        NameTextEdit.Text = Convert.ToString(gvBranch.GetFocusedRowCellValue("BName"));
                        FullAddressMemoExEdit.Text = Convert.ToString(gvBranch.GetFocusedRowCellValue("FullAddress"));
                        CPersonTextEdit.Text = Convert.ToString(gvBranch.GetFocusedRowCellValue("CPerson"));
                        CNumberTextEdit.Text = Convert.ToString(gvBranch.GetFocusedRowCellValue("CNumber"));
                        cmbOrg.EditValue = gvBranch.GetFocusedRowCellValue("OrgID");
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                int ivalue = 0;
                string strBranchID = Convert.ToString(gvBranch.GetFocusedRowCellValue("BranchID"));
                string strOrgID = Convert.ToString(gvBranch.GetFocusedRowCellValue("OrgID"));
                if (int.TryParse(strBranchID, out ivalue))
                    ObjEUser.BranchID = ivalue;
                else
                    return;

                if (int.TryParse(strOrgID, out ivalue))
                    ObjEUser.OrganizationID = ivalue;
                else
                    return;

                frmUser Obj = new frmUser(ObjEUser);
                Obj.StartPosition = FormStartPosition.CenterScreen;
                Obj.Show();

            }
            catch (Exception ex)
            {
                Utility.ShowError(ex);
            }
        }
    }
}