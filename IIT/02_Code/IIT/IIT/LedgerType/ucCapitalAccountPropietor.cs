using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucCapitalAccountPropietor : ucLedgerTypeBase
    {
        public ucCapitalAccountPropietor(Ledger _ledger, bool isCallFromAddButton,string caption) 
            : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance);
        }

        private void ucCpaitalAccountPropietor_Load(object sender, EventArgs e)
        {
            cmbRecieptForAdditions.Properties.DataSource =
                cmbDrawings.Properties.DataSource =
                cmbInterestonCapital.Properties.DataSource =
                cmbOthersifany.Properties.DataSource = LookUpUtility.GetBoolType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbRecieptForAdditions.EditValue = ledger.CapitalAccountPropietorInfo.RecieptforAdditions;
            cmbDrawings.EditValue = ledger.CapitalAccountPropietorInfo.Drawings;
            cmbInterestonCapital.EditValue = ledger.CapitalAccountPropietorInfo.InterestonCaptital;
            cmbOthersifany.EditValue = ledger.CapitalAccountPropietorInfo.OthersifAny;
            txtOpeningBalance.EditValue = ledger.CapitalAccountPropietorInfo.OpeningBalance;
            cmbSign.EditValue = ledger.CapitalAccountPropietorInfo.sign;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.CapitalAccountPropietorInfo.RecieptforAdditions = cmbRecieptForAdditions.EditValue;
            ledger.CapitalAccountPropietorInfo.Drawings = cmbDrawings.EditValue;
            ledger.CapitalAccountPropietorInfo.InterestonCaptital = cmbInterestonCapital.EditValue;
            ledger.CapitalAccountPropietorInfo.OthersifAny = cmbOthersifany.EditValue;
            ledger.CapitalAccountPropietorInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.CapitalAccountPropietorInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_CapitalAccount;
            Save();
        }
    }
}
