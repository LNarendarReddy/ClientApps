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
using HMS.Reports;
using DevExpress.XtraReports.UI;

namespace HMS
{
    public partial class frmVouchers : DevExpress.XtraEditors.XtraForm
    {
        EVoucher ObjEVoucher = new EVoucher();
        DVoucher ObjDVoucher = new DVoucher();

        public frmVouchers()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtAmount.EditValue = 0;
            txtReceived.EditValue = null;
            txtPurpose.EditValue = null;
            cmbCategory.EditValue = null;
            txtAmount.Focus();
            ObjDVoucher.GetNewItemCode(ObjEVoucher);
            txtVoucherNumber.EditValue = ObjEVoucher.VoucherNumber;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dxValidationProvider1.Validate())
                    return;
                ObjEVoucher.VoucherNumber = txtVoucherNumber.EditValue;
                ObjEVoucher.Amount = txtAmount.EditValue;
                ObjEVoucher.recievedBy = txtReceived.Text;
                ObjEVoucher.Purpose = txtPurpose.EditValue;
                ObjEVoucher.UserID = Utility.UserID;
                ObjEVoucher.VoucherCategoryID = Convert.ToInt32(cmbCategory.EditValue);
                ObjDVoucher.SaveVoucher(ObjEVoucher);

                 rptVoucher rpt = new rptVoucher();
                rpt.Parameters["VoucherNumber"].Value = txtVoucherNumber.EditValue;
                rpt.Parameters["OrgName"].Value = Utility.OrgName;
                rpt.Parameters["Address"].Value = Utility.OrgAddress;
                rpt.Parameters["RecievedBy"].Value = txtReceived.Text;
                rpt.Parameters["Amount"].Value = txtAmount.EditValue;
                rpt.Parameters["Mobile"].Value = Utility.OrgCNumber;
                rpt.Parameters["UserName"].Value = Utility.UserFullName;
                rpt.Parameters["Purpose"].Value = txtPurpose.EditValue;
                rpt.Parameters["Category"].Value = cmbCategory.Text;
                rpt.Print();

                gcVouchers.DataSource = ObjEVoucher.dtList;
                Utility.Setfocus(gvVouchers, "VoucherID", ObjEVoucher.VoucherID);
                ClearFields();
                
            }
            catch (Exception ex) { Utility.ShowError(ex); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void frmVouchers_Load(object sender, EventArgs e)
        {
            try
            {
                ObjDVoucher.GetItemList(ObjEVoucher);
                gcVouchers.DataSource = ObjEVoucher.dtList;

                LoadCategory();
                LoadPersonNames();

                ObjDVoucher.GetNewItemCode(ObjEVoucher);
                txtVoucherNumber.EditValue = ObjEVoucher.VoucherNumber;

            }
            catch (Exception ex){}
        }

        private void gcVouchers_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                frmVoucherCategory Obj = new frmVoucherCategory();
                Obj.ShowDialog();
                LoadCategory();
            }
            catch (Exception ex) { }
        }

        private void LoadCategory()
        {
            try
            {
                ObjEVoucher.BranchID = Utility.BranchID;
                ObjDVoucher. GetVoucherCategory(ObjEVoucher);
                cmbCategory.Properties.DataSource = ObjEVoucher.dtVoucherCategory;
                cmbCategory.Properties.ValueMember = "VoucherCategoryID";
                cmbCategory.Properties.DisplayMember = "CategoryName";
            }
            catch (Exception ex) { }
        }

        private void LoadPersonNames()
        {
            try
            {
                ObjDVoucher.GetPersonNames(ObjEVoucher);
                txtReceived.Properties.DataSource = ObjEVoucher.dtPersonNames;
                txtReceived.Properties.ValueMember = "PersonName";
                txtReceived.Properties.DisplayMember = "PersonName";
            }
            catch (Exception ex) { }
        }
    }
}