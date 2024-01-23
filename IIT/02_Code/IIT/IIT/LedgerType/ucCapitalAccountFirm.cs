using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucCapitalAccountFirm : ucLedgerTypeBase
    {
        public ucCapitalAccountFirm(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance, txtCapitalShare);
        }
        private void ucCapitalAccountFirm_Load(object sender, EventArgs e)
        {

                cmbRemuneration.Properties.DataSource =
                cmbShareofProfit.Properties.DataSource =
                cmbInterestonCapital.Properties.DataSource = LookUpUtility.GetBoolType();

            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            txtCapitalShare.EditValue = ledger.CapitalAccountFirmInfo.CapitalShare;
            cmbRemuneration.EditValue = ledger.CapitalAccountFirmInfo.Remuneration;
            cmbShareofProfit.EditValue = ledger.CapitalAccountFirmInfo.ShareofProfit;
            cmbInterestonCapital.EditValue = ledger.CapitalAccountFirmInfo.InterestonCapital;
            txtOpeningBalance.EditValue = ledger.CapitalAccountFirmInfo.OpeningBalance;
            cmbSign.EditValue = ledger.CapitalAccountFirmInfo.sign;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountFirmInfo.CapitalShare = txtCapitalShare.EditValue;
            ledger.CapitalAccountFirmInfo.Remuneration = cmbRemuneration.EditValue;
            ledger.CapitalAccountFirmInfo.ShareofProfit = cmbShareofProfit.EditValue;
            ledger.CapitalAccountFirmInfo.InterestonCapital = cmbInterestonCapital.EditValue;
            ledger.CapitalAccountFirmInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.CapitalAccountFirmInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
            Save();
        }
    }
}
