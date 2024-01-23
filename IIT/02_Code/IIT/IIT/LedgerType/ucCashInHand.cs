using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucCashInHand : ucLedgerTypeBase
    {
        public ucCashInHand(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance);
        }
        private void ucCashInHand_Load(object sender, EventArgs e)
        {
            cmbHavingPrettyCashAccount.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbHavingPrettyCashAccount.EditValue = ledger.CashinHandInfo.HavingPrettyCashAccount;
            txtDetails.EditValue = ledger.CashinHandInfo.Details;
            txtOpeningBalance.EditValue = ledger.CashinHandInfo.OpeningBalance;
            cmbSign.EditValue = ledger.CashinHandInfo.sign;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CashinHandInfo.HavingPrettyCashAccount = cmbHavingPrettyCashAccount.EditValue;
            ledger.CashinHandInfo.Details = txtDetails.EditValue;
            decimal.TryParse(txtDetails.Text, out decimal PettyCash);
            decimal.TryParse(txtOpeningBalance.Text, out decimal OpeningBalance);
            ledger.CashinHandInfo.OpeningBalance = PettyCash + OpeningBalance;
            ledger.CashinHandInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CashInHand;
            Save();
        }
        private void cmbHavingPrettyCashAccount_EditValueChanged(object sender, EventArgs e)
        {
            txtDetails.EditValue = null;
            txtDetails.Enabled = cmbHavingPrettyCashAccount.Text.Equals("Yes");
        }
    }
}
