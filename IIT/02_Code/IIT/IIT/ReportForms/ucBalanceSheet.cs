
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace IIT.ReportForms
{
    public partial class ucBalanceSheet : NavigationBase
    {
        AdminSettings currentSettings = null;

        private List<ActionText> helpText = new List<ActionText>() {
            new ActionText("Navigate", buildShort: false, shortCut: "Up/Down"),
            new ActionText("F2", buildShort: false, shortCut: "Date Settings"),
            //new ActionText("Expand", buildShort: false, shortCut: "Enter"),
            //new ActionText("Collapse", buildShort: false, shortCut: "Esc")
        };

        public ucBalanceSheet() : base("Balance Sheet")
        {
            InitializeComponent();
        }

        public override IEnumerable<ActionText> HelpText => helpText;

        //public override bool HandlesESC => true;

        private void ucBalanceSheet_Load(object sender, EventArgs e)
        {
            Utility.SetTreeListFormatting(tlAssets, tlcBalanceSheetAssetsLevel);
            Utility.SetTreeListFormatting(tlLiabilities, tlcBalanceSheetLiabilitiesLevel);
            

            currentSettings = Utility.GetAdminSettings();
            FetchAndBindData();
        }

        private void FetchAndBindData()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "FromDate", currentSettings.FromDate },
                { "ToDate", currentSettings.ToDate },
                { "EntityID", Utility.CurrentEntity.ID }
            };

            DataSet dsBalanceSheet = new ReportRepository().GetReportDataset("USP_RPT_BALANCESHEET", parameters);

            tlAssets.DataSource = dsBalanceSheet.Tables[0];
            tlAssets.KeyFieldName = "BSID";
            tlAssets.ParentFieldName = "PARENTID";
            tlAssets.ExpandToLevel(0);

            tlLiabilities.DataSource = dsBalanceSheet.Tables[1];
            tlLiabilities.KeyFieldName = "BSID";
            tlLiabilities.ParentFieldName = "PARENTID";
            tlLiabilities.ExpandToLevel(0);

            lblHeader.Text = $"Balance sheet as on {currentSettings.ToDate.ToShortDateString()}";
        }

        private void ucBalanceSheet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 &&
                Utility.ShowDialog(new frmSettings(currentSettings, true)) == DialogResult.OK)
            {
                FetchAndBindData();
            }
        }
    }
}
