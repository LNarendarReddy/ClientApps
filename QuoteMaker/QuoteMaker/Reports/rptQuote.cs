using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QuoteMaker.UI.Reports
{
    public partial class rptQuote : DevExpress.XtraReports.UI.XtraReport
    {
        public rptQuote(DataTable dtQuotation,DataTable dtItems)
        {
            InitializeComponent();
            this.DataSource = dtQuotation;
            drItems.DataSource = dtItems;
        }

    }
}
