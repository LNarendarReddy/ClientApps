using Entity;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucDepreciation : ucLedgerTypeBase
    {
        public ucDepreciation(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance);
        }
        private void ucDepreciation_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            txtOpeningBalance.EditValue = ledger.DepreciationInfo.OpeningBalance;
            cmbSign.EditValue = ledger.DepreciationInfo.sign;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.DepreciationInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.DepreciationInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Depreciation;
            Save();
        }
    }
}
