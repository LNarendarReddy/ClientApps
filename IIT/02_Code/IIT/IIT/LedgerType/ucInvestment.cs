using DevExpress.XtraLayout.Utils;
using Entity;
using Repository;
using Repository.Utility;
using System;
using System.Data;
using System.Windows.Forms;

namespace IIT
{
    public partial class ucInvestment : ucLedgerTypeBase
    {
        public ucInvestment(Ledger ledger,bool callfromEvent,string caption):base(ledger, callfromEvent, caption)
        {
            InitializeComponent();
            RegisterTextEdits(txtOpeningBalance);

            requiredFields.AddRange(new Control[] { txtRateOfInterest, txtNameOfCompany, txtNoOfSharesHeld, txtBuyingValue
                , txtCommission, txtNameOfPlan, txtTenureOfPlan, txtInstallmentAmt, txtMoratoriumPeriod, rgTenure});

        }
        private void ucInvestment_Load(object sender, EventArgs e)
        {
            base.AddControls(layoutControl1);
            cmbTypeOfInvestment.Properties.DataSource = LookUpUtility.GetInvestmentType();

            DataTable dtInvestmentTenure = LookUpUtility.GetTenureOfInvestment();
            foreach (DataRow drInvestmentTenure in dtInvestmentTenure.Rows)
            {
                rgTenure.Properties.Items.Add(
                    new DevExpress.XtraEditors.Controls.RadioGroupItem(
                        drInvestmentTenure["ENTITYLOOKUPID"], drInvestmentTenure["LOOKUPVALUE"].ToString()));
            }

            cmbTypeOfInvestment_EditValueChanged(null, null);
            if (ledger?.ID == null) return;
            txtLedgerName.EditValue = ledger.Name;
            cmbTypeOfInvestment.EditValue = ledger.InvestmentInfo.TypeOfInvestment;
            rgTenure.EditValue = ledger.InvestmentInfo.Tenure;
            txtOpeningBalance.EditValue = ledger.InvestmentInfo.OpeningBalance;
            cmbSign.EditValue = ledger.InvestmentInfo.sign;
            txtRateOfInterest.EditValue = ledger.InvestmentInfo.RateOfInterest;
            txtNameOfCompany.EditValue = ledger.InvestmentInfo.NameOfCompany;
            txtNoOfSharesHeld.EditValue = ledger.InvestmentInfo.NoOfSharesHeld;
            txtBuyingValue.EditValue = ledger.InvestmentInfo.BuyingValueOfShare;
            txtCommission.EditValue = ledger.InvestmentInfo.Commission;
            txtNameOfPlan.EditValue = ledger.InvestmentInfo.NameOfPlan;
            txtTenureOfPlan.EditValue = ledger.InvestmentInfo.TenureOfPlan;
            txtInstallmentAmt.EditValue = ledger.InvestmentInfo.InstallmentAmount;
            txtMoratoriumPeriod.EditValue = ledger.InvestmentInfo.MoratoriumPeriod;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!base.ValidateControls())
                return;
            ledger.Name = ledger.Description = txtLedgerName.EditValue;
            ledger.InvestmentInfo.TypeOfInvestment = cmbTypeOfInvestment.EditValue;
            ledger.InvestmentInfo.Tenure = rgTenure.EditValue;
            ledger.InvestmentInfo.OpeningBalance = txtOpeningBalance.EditValue;
            ledger.InvestmentInfo.sign = cmbSign.EditValue;
            ledger.InvestmentInfo.RateOfInterest = txtRateOfInterest.EditValue;
            ledger.InvestmentInfo.NameOfCompany = txtNameOfCompany.EditValue;
            ledger.InvestmentInfo.NoOfSharesHeld = txtNoOfSharesHeld.EditValue;
            ledger.InvestmentInfo.BuyingValueOfShare = txtBuyingValue.EditValue;
            ledger.InvestmentInfo.Commission = txtCommission.EditValue;
            ledger.InvestmentInfo.NameOfPlan = txtNameOfPlan.EditValue;
            ledger.InvestmentInfo.TenureOfPlan = txtTenureOfPlan.EditValue;
            ledger.InvestmentInfo.InstallmentAmount = txtInstallmentAmt.EditValue;
            ledger.InvestmentInfo.MoratoriumPeriod = txtMoratoriumPeriod.EditValue;

            ledger.LedgerTypeID = LookUpIDMap.LedgerType_Investment;
            Save();
        }

        private void cmbTypeOfInvestment_EditValueChanged(object sender, EventArgs e)
        {
            tpInvestmentDetails.Rows[0].Visible = tpInvestmentDetails.Rows[1].Visible = tpInvestmentDetails.Rows[2].Visible = false;

            txtRateOfInterest.EditValue = null;
            txtNameOfCompany.EditValue = null;
            txtNoOfSharesHeld.EditValue = null;
            txtBuyingValue.EditValue = null;
            txtCommission.EditValue = null;
            txtNameOfPlan.EditValue = null;
            txtTenureOfPlan.EditValue = null;
            txtInstallmentAmt.EditValue = null;
            txtMoratoriumPeriod.EditValue = null;

            if (cmbTypeOfInvestment.EditValue == null) return;

            if (cmbTypeOfInvestment.EditValue.Equals(LookUpIDMap.InvestmentType_Equity))
                tpInvestmentDetails.Rows[1].Visible = true;
            else if (cmbTypeOfInvestment.EditValue.Equals(LookUpIDMap.InvestmentType_ULIPorMF))
                tpInvestmentDetails.Rows[2].Visible = true;
            else
                tpInvestmentDetails.Rows[0].Visible = true;

            gcInvestmentDetails.AutoSize = true;
            lciInvestmentDetails.Visibility = LayoutVisibility.Always;
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            txtCostOfShares.EditValue = null;
            txtValueOfInvestment.EditValue = null;

            if (decimal.TryParse(txtNoOfSharesHeld.EditValue?.ToString(), out decimal noOfShares)
                && decimal.TryParse(txtBuyingValue.EditValue?.ToString(), out decimal buyingValue))
            {
                decimal costOfShares = noOfShares * buyingValue;
                txtCostOfShares.EditValue = costOfShares;
                if (decimal.TryParse(txtCommission.EditValue?.ToString(), out decimal commission))
                {
                    txtValueOfInvestment.EditValue = costOfShares - commission;
                }
            }
        }
    }
}
