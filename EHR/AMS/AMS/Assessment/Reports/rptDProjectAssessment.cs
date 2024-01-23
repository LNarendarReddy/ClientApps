using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;

namespace EHR.Reports
{
    public partial class rptDProjectAssessment : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDProjectAssessment()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
