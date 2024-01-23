using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucRegular : ucLedgerTypeBase
    {
        public ucRegular(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton,caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance);
        }
        private void ucRegular_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbNameoftheBank.Properties.DataSource = LookUpUtility.GetBanks();
            cmbTDSRates.Properties.DataSource = LookUpUtility.GetTDSRates();
            cmbRegistrationStatus.Properties.DataSource = LookUpUtility.GetRegType();
            cmbTDSApplicable.Properties.DataSource = LookUpUtility.GetBoolType();
            cmbProvisionEntryRequired.Properties.DataSource = LookUpUtility.GetBoolType();

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbRegistrationStatus.EditValue = ledger.RegularInfo.GSTRegistrationStatus;
            txtGSTNumber.EditValue = ledger.RegularInfo.GSTNumber;
            txtPANNumber.EditValue = ledger.RegularInfo.PANNumber;
            cmbTDSApplicable.EditValue = ledger.RegularInfo.IsTDSApplicable;
            cmbTDSRates.EditValue = ledger.RegularInfo.TDSRate;
            cmbProvisionEntryRequired.EditValue = ledger.RegularInfo.ProvisionalEntryRequired;
            txtOpeningBalance.EditValue = ledger.RegularInfo.OpeningBalance;
            cmbSign.EditValue = ledger.RegularInfo.sign;
            cmbNameoftheBank.EditValue = ledger.RegularInfo.BankID;
            txtAccountNumber.EditValue = ledger.RegularInfo.AccountNumber;
            txtAccountHolderName.EditValue = ledger.RegularInfo.AccountHolderName;
            txtIFSCCode.EditValue = ledger.RegularInfo.IFSCCode;
            txtBranch.EditValue = ledger.RegularInfo.BranchName;
            txtDoorNumber.EditValue = ledger.RegularInfo.DoorNumber;
            txtArea.EditValue = ledger.RegularInfo.Area;
            txtCity.EditValue = ledger.RegularInfo.City;
            txtPinCode.EditValue = ledger.RegularInfo.PinCode;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.RegularInfo.GSTRegistrationStatus = cmbRegistrationStatus.EditValue;
            ledger.RegularInfo.GSTNumber = txtGSTNumber.EditValue;
            ledger.RegularInfo.PANNumber = txtPANNumber.EditValue;
            ledger.RegularInfo.IsTDSApplicable = cmbTDSApplicable .EditValue;
            ledger.RegularInfo.TDSRate = cmbTDSRates.EditValue;
            ledger.RegularInfo.ProvisionalEntryRequired = cmbProvisionEntryRequired.EditValue;
            ledger.RegularInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.RegularInfo.sign = cmbSign.EditValue;
            ledger.RegularInfo.BankID = cmbNameoftheBank.EditValue;
            ledger.RegularInfo.AccountNumber = txtAccountNumber.EditValue;
            ledger.RegularInfo.AccountHolderName = txtAccountHolderName.EditValue;
            ledger.RegularInfo.IFSCCode = txtIFSCCode.EditValue;
            ledger.RegularInfo.BranchName = txtBranch.EditValue;
            ledger.RegularInfo.DoorNumber = txtDoorNumber.EditValue;
            ledger.RegularInfo.Area = txtArea.EditValue;
            ledger.RegularInfo.City = txtCity.EditValue;
            ledger.RegularInfo.PinCode = txtPinCode.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Regular;
            Save();
        }
        private void txtGSTNumber_Leave(object sender, EventArgs e)
        {
            if (txtGSTNumber.Text.Length < 12)
                return;
            txtPANNumber.EditValue = txtGSTNumber.Text.Substring(2, 10);
        }
        private void cmbRegistrationStatus_EditValueChanged(object sender, EventArgs e)
        {
            txtGSTNumber.EditValue = null;
            txtGSTNumber.Enabled = cmbRegistrationStatus.Text.Equals("Registered");
        }
        private void cmbTDSApplicable_EditValueChanged(object sender, EventArgs e)
        {
            cmbTDSRates.EditValue = null;
            cmbTDSRates.Enabled = cmbTDSApplicable.Text.Equals("Yes");
        }
    }
}
