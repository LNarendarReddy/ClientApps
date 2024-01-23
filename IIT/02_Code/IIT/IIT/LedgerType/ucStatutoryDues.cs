using Entity;
using Repository;
using Repository.Utility;
using System;

namespace IIT
{
    public partial class ucStatutoryDues : ucLedgerTypeBase
    {
        public ucStatutoryDues(Ledger _ledger, bool isCallFromAddButton, string caption) : base(_ledger, isCallFromAddButton, caption)
        {
            InitializeComponent();
        }
        private void ucStatutoryDues_Load(object sender, EventArgs e)
        {
            cmbTypeofDue.Properties.DataSource = LookUpUtility.GetDueType();
            base.AddControls(layoutControl1);
            lblHeader.Text = Caption;
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbTypeofDue.EditValue = ledger.StatutoryDuesInfo.TypeofDue;
            txtOpeningBalance.EditValue = ledger.StatutoryDuesInfo.OpeningBalance;
            cmbSign.EditValue = ledger.StatutoryDuesInfo.sign;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.StatutoryDuesInfo.TypeofDue = cmbTypeofDue.EditValue;
            ledger.StatutoryDuesInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.StatutoryDuesInfo.sign = cmbSign.EditValue;
            ledger.LedgerTypeID = LookUpIDMap.LedgerType_StatutoryDues;
            Save();
        }
        private void cmbTypeofDue_EditValueChanged(object sender, EventArgs e)
        {
            txtLedgerName.Enabled = cmbTypeofDue.Text.Equals("Other");
            txtLedgerName.Text = cmbTypeofDue.Text;
        }
    }
}
