using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;
using EL;

namespace EHR.Project.Reports
{
    public partial class rptQAHeader : DevExpress.XtraReports.UI.XtraReport
    {
        public rptQAHeader(EProject objEProject)
        {
            InitializeComponent();
            this.DataSource = objEProject.dsQAReport_DevBuild;
            this.rptProjectTeam.DataSource = objEProject.dsQAReport_ProjectTeam;
        }

    }
}
