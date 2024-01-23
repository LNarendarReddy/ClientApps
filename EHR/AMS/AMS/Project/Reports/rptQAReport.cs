using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;
using EL;

namespace EHR.Project.Reports
{
    public partial class rptQAReport : DevExpress.XtraReports.UI.XtraReport
    {
        public rptQAReport(EProject objEProject)
        {
            InitializeComponent();
            this.DataSource = objEProject.dsQAReport_DevBuild;
            this.drProjectTeam.DataSource = objEProject.dsQAReport_ProjectTeam;
            this.drTestcase.DataSource = objEProject.dsQAReport_TestExecution;
        }
    }
}
