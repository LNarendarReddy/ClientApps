using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucCapitalAccount : ucLedgerTypeBase
    {
        public ucCapitalAccount(Ledger _ledger, bool isCallFromAddButton,string caption) :base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtPercentageOfPrefarence, txtPremiumValueofShare, txtNoOfShares, txtFaceValueOfShare, txtOpeningBalance, txtAuthorizedCapitalAmount);           
        }

        private void ucCapitalAccount_Load(object sender, EventArgs e)
        {
            cmbNatureOfCapital.Properties.DataSource = LookUpUtility.GetCapitalType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbNatureOfCapital.EditValue = ledger.CapitalAccountInfo.NatureoftheCapital;
            txtAuthorizedCapitalAmount.EditValue = ledger.CapitalAccountInfo.AuthorizedCapitalAmount;
            txtNoOfShares.EditValue = ledger.CapitalAccountInfo.NoOfShares;
            txtFaceValueOfShare.EditValue = ledger.CapitalAccountInfo.FaceValue;
            txtPremiumValueofShare.EditValue = ledger.CapitalAccountInfo.PremiumValue;
            txtPercentageOfPrefarence.EditValue = ledger.CapitalAccountInfo.PercentageOfPreference;
            txtOpeningBalance.EditValue = ledger.CapitalAccountInfo.OpeningBalance;
            cmbSign.EditValue = ledger.CapitalAccountInfo.sign;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountInfo.NatureoftheCapital = cmbNatureOfCapital.EditValue;
            ledger.CapitalAccountInfo.AuthorizedCapitalAmount = txtAuthorizedCapitalAmount.EditValue;
            ledger.CapitalAccountInfo.NoOfShares = txtNoOfShares.EditValue;
            ledger.CapitalAccountInfo.FaceValue = txtFaceValueOfShare.EditValue;
            ledger.CapitalAccountInfo.PremiumValue = txtPremiumValueofShare.EditValue;
            ledger.CapitalAccountInfo.PercentageOfPreference = txtPercentageOfPrefarence.EditValue;
            ledger.CapitalAccountInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.CapitalAccountInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
            Save();
        }

        private void cmbNatureOfCapital_EditValueChanged(object sender, EventArgs e)
        {
            txtPercentageOfPrefarence.EditValue = null;
            txtPercentageOfPrefarence.Enabled = cmbNatureOfCapital.Text.Equals("Preference");
        }
    }
}
