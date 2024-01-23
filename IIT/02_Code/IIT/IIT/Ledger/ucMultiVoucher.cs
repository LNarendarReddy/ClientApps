using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucMultiVoucher : NavigationBase
    {
        private readonly object voucherTypeID;
        BindingList<Voucher> vouchersList = new BindingList<Voucher>();
        DataTable paymentFromSource = null;
        DataTable paymentToSource = null;
        bool isBankPaymentVoucher;

        public override string Caption => "Multiple Voucher Entry";

        private readonly List<ActionText> helpText = new List<ActionText>()
            {
                new ActionText("Save", buildShort: false, shortCut: "Ctrl + S")
            };

        public override IEnumerable<ActionText> HelpText => helpText;

        public ucMultiVoucher(MultiVoucherSettings multiVoucherSettings)
        {
            InitializeComponent();
            voucherTypeID = multiVoucherSettings.VoucherTypeID;
            lblVoucherTypeHeader.Text = $"Multiple voucher creation for : {multiVoucherSettings.VoucherTypeHeader}";
            gcPaymentFrom.Caption = multiVoucherSettings.FromPaymentHeader;
            gcPaymentTo.Caption = multiVoucherSettings.ToPaymentHeader;
            gcPurpose.Caption = multiVoucherSettings.PurposeText;
            paymentFromSource = multiVoucherSettings.FromPaymentSource as DataTable;
            paymentToSource = multiVoucherSettings.ToPaymentSource as DataTable;
            isBankPaymentVoucher = multiVoucherSettings.IsBankPaymentVoucher;
            gcolChequeNumber.Visible = isBankPaymentVoucher;
            gcModeOfTransfer.Visible = isBankPaymentVoucher;

            rluPaymentFrom.DataSource = paymentFromSource;
            rluPaymentFrom.DisplayMember = "LEDGERNAME";
            rluPaymentFrom.ValueMember = "LEDGERID";

            rluPaymentTo.DataSource = paymentToSource;
            rluPaymentTo.DisplayMember = "LEDGERNAME";
            rluPaymentTo.ValueMember = "LEDGERID";

            rluPaymentFrom.ReadOnly = paymentFromSource.Rows.Count == 1;
            rluPaymentTo.ReadOnly = paymentToSource.Rows.Count == 1;

            DataTable dtPaymentModes = new DataTable();
            dtPaymentModes.Columns.Add("PaymentModeID", typeof(int));
            dtPaymentModes.Columns.Add("PaymentModeText", typeof(string));

            List<string> modes = new List<string>() { "RTGS", "NEFT", "PDC", "DD" };
            int i = 1;
            modes.ForEach(x => dtPaymentModes.Rows.Add(i++, x));

            rluModeOfTransfer.DataSource = dtPaymentModes;
            rluModeOfTransfer.DisplayMember = "PaymentModeText";
            rluModeOfTransfer.ValueMember = "PaymentModeID";
        }

        private void ucMultiVoucher_Load(object sender, EventArgs e)
        {
            Utility.SetGridFormatting(gvVouchers);
            gcVouchers.DataSource = vouchersList;
            gvVouchers.AddNewRow();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!gvVouchers.UpdateCurrentRow())
            {
                XtraMessageBox.Show("Some of the values are not entered", "Error");
                return;
            }

            new VoucherRepository().Save(vouchersList.ToList());
            frmSingularMain.Instance.RollbackControl(false);
        }

        private void gvVouchers_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gvVouchers.SetRowCellValue(e.RowHandle, "VoucherTypeID", voucherTypeID);
            gvVouchers.SetRowCellValue(e.RowHandle, "VoucherDate", DateTime.Now);

            if (paymentFromSource.Rows.Count == 1)
                gvVouchers.SetRowCellValue(e.RowHandle, "PaymentFrom", paymentFromSource.Rows[0]["LEDGERID"]);
            if (paymentToSource.Rows.Count == 1)
                gvVouchers.SetRowCellValue(e.RowHandle, "PaymentTo", paymentToSource.Rows[0]["LEDGERID"]);

            gvVouchers.SetRowCellValue(e.RowHandle, "UserName", Utility.UserName);
            gvVouchers.SetRowCellValue(e.RowHandle, "EntityID", Utility.CurrentEntity.ID);
        }

        private void rbtnAddNew_Click(object sender, EventArgs e)
        {
            gvVouchers.AddNewRow();
        }

        private void gvVouchers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)Keys.Enter)
            {
                return;
            }

            try
            {
                if (gvVouchers.FocusedColumn.FieldName == "Amount")
                {
                    gvVouchers.AddNewRow();
                }
            }
            catch { }

            gvVouchers.MoveNext();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSave_Click(null, null);
                return true;
            }
           
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gvVouchers_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            Voucher currentVoucherObj = gvVouchers.GetFocusedRow() as Voucher;
                        
            CheckColumnValue(currentVoucherObj.VoucherDate, "VoucherDate", e);
            CheckColumnValue(currentVoucherObj.PaymentFrom, "PaymentFrom", e);
            CheckColumnValue(currentVoucherObj.PaymentTo, "PaymentTo", e);

            if (string.IsNullOrEmpty(currentVoucherObj.Purpose?.ToString()))
            {
                e.Valid = false;
                gvVouchers.SetColumnError(gvVouchers.Columns["Purpose"], "Value cannot be empty");
            }

            if (currentVoucherObj.Amount == null || Convert.ToDecimal(currentVoucherObj.Amount) == 0)
            {
                e.Valid = false;
                gvVouchers.SetColumnError(gvVouchers.Columns["Amount"], "Value cannot be empty");
            }

            if(isBankPaymentVoucher && !string.IsNullOrEmpty(currentVoucherObj.ChequeNumber?.ToString())
                && !string.IsNullOrEmpty(currentVoucherObj.PaymentFrom?.ToString()))
            {
                currentVoucherObj.ChequeRegisterID = new BankingRepository().ValidateChequeNumber(currentVoucherObj.PaymentFrom, currentVoucherObj.ChequeNumber);
                if (currentVoucherObj.ChequeRegisterID == null &&
                    XtraMessageBox.Show("Entered cheque number is not exists cheque register.Are sure want to continue?", "Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Valid = false;
                    gvVouchers.SetColumnError(gvVouchers.Columns["ChequeNumber"], "Entered cheque number is not exists cheque register");
                }
            }
        }

        private void CheckColumnValue(object value, string columnName, ValidateRowEventArgs e)
        {
            if (value != null) return;
            e.Valid = false;
            gvVouchers.SetColumnError(gvVouchers.Columns[columnName], "Value cannot be empty");
        }

        private void gvVouchers_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            //Suppress displaying the error message box
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }

    public class MultiVoucherSettings
    {
        public object VoucherTypeID { get; set; }

        public string VoucherTypeHeader { get; set; } 

        public object FromPaymentSource { get; set; }

        public object ToPaymentSource { get; set; }

        public string PurposeText { get; set; }

        public string ToPaymentHeader { get; set; }

        public string FromPaymentHeader { get; set; }

        public bool IsBankPaymentVoucher { get; set; }
    }
}
