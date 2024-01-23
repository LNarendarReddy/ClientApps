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

namespace IMS
{
    public partial class frmPayment : DevExpress.XtraEditors.XtraForm
    {
        DInvoice ObjDInvoice = new DInvoice();
        EInvoice ObjEInvoice = null;
        public frmPayment(EInvoice _ObjEInvoice)
        {
            InitializeComponent();
            ObjEInvoice = _ObjEInvoice;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            try
            {
                txtInvoiceNumber.Text = ObjEInvoice.InvoiceNumber;
                txtInvoiceTotal.Text = ObjEInvoice.GrandTotal.ToString();
                txtDue.Text = ObjEInvoice.Due.ToString();
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
                if (string.IsNullOrEmpty(txtPaid.Text.Trim()))
                    throw new Exception("Please enter the amount");
                if(string.IsNullOrEmpty(txtRemarks.Text.Trim()))
                    throw new Exception("Please enter Payment Description");
                decimal DValue = 0;
                if (decimal.TryParse(txtPaid.Text, out DValue))
                    ObjEInvoice.Paid = DValue;
                ObjEInvoice.PaymentMode = rgPaymentMode.SelectedIndex;
                ObjEInvoice.Remarks = txtRemarks.Text;
                ObjEInvoice = ObjDInvoice.SavePayment(ObjEInvoice);
                this.Close();
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
    }
}