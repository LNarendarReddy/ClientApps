using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucDividend : ucLedgerTypeBase
    {
        public ucDividend(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance);
        }
        private void ucDividend_Load(object sender, EventArgs e)
        {
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            cmbTDSApplicable.EditValue = ledger.DividendInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.DividendInfo.TDSRate;
            txtNameOfTheCompany.EditValue = ledger.DividendInfo.NameofCompany;
            cmbIsFromIndia.EditValue = ledger.DividendInfo.isDividendRecievedFromIndia;
            txtOpeningBalance.EditValue = ledger.DividendInfo.OpeningBalance;
            cmbSign.EditValue = ledger.DividendInfo.sign;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DividendInfo.IsTDSApplicable = cmbTDSApplicable.EditValue;
            ledger.DividendInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.DividendInfo.NameofCompany = txtNameOfTheCompany.EditValue;
            ledger.DividendInfo.isDividendRecievedFromIndia = cmbIsFromIndia.EditValue;
            ledger.DividendInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.DividendInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Dividend;
            Save();
        }
        private void cmbTDSApplicable_EditValueChanged(object sender, EventArgs e)
        {
            cmbTDSRates.EditValue = null;
            cmbTDSRates.Enabled = cmbTDSApplicable.Text.Equals("Yes");
        }
    }
}
