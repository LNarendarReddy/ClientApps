using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucReservesAndSurplus : ucLedgerTypeBase
    {
        public ucReservesAndSurplus(Ledger _ledger, bool isCallFromAddButton,string caption) : base(_ledger, isCallFromAddButton,caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance);
        }
        private void ucReservesAndSurplus_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbNatureOfReserve.Properties.DataSource = LookUpUtility.GetNatureOfReserves();

            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;

            txtLedgerName.EditValue = ledger.Name;
            cmbNatureOfReserve.EditValue = ledger.ReservesAndSurplusInfo.NatureOfReserves;
            txtOpeningBalance.EditValue = ledger.ReservesAndSurplusInfo.OpeningBalance;
            cmbSign.EditValue = ledger.ReservesAndSurplusInfo.sign;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.ReservesAndSurplusInfo.NatureOfReserves = cmbNatureOfReserve.EditValue;
            ledger.ReservesAndSurplusInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.ReservesAndSurplusInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_ReservesandSurplus;
            Save();
        }
    }
}
