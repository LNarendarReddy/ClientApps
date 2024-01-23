using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;

namespace InstituteMS.ReportDesign
{
    public partial class IDCard : DevExpress.XtraReports.UI.XtraReport
    {
        public IDCard()
        {
            InitializeComponent();
            this.sqlDataSource1.ConnectionParameters = new
                DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(SQLCon.ServerName,
                SQLCon.DBName, SQLCon.UserName, SQLCon.Password, DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
        }

    }
}
