﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;

namespace CMS.Reports
{
    public partial class rptTreatment : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTreatment()
        {
            InitializeComponent();
            this.sqlDataSource1.ConnectionParameters = new
                DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(SQLCon.ServerName,
                SQLCon.DBName, SQLCon.UserName, SQLCon.Password, DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);

            this.sqlDataSource2.ConnectionParameters = new
                DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(SQLCon.ServerName,
                SQLCon.DBName, SQLCon.UserName, SQLCon.Password, DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
        }

    }
}
