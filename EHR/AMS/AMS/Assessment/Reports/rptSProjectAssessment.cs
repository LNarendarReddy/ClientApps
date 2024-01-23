using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;

namespace EHR.Reports
{
    public partial class rptSProjectAssessment : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSProjectAssessment()
        {
            InitializeComponent();
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
