using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;
using System.IO;

namespace InstituteMS.ReportDesign
{
    public partial class FeeReciept : DevExpress.XtraReports.UI.XtraReport
    {
        public FeeReciept()
        {
            InitializeComponent();
            this.sqlDataSource1.ConnectionParameters = new 
                DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(SQLCon.ServerName, 
                SQLCon.DBName, SQLCon.UserName, SQLCon.Password, DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
            this.Watermark.Image = BinaryToImage(Utility.Imagedata);
            this.Watermark.ImageAlign = ContentAlignment.MiddleCenter;
            this.Watermark.ImageTransparency = 240;
        }
        private Image BinaryToImage(byte[] b)
        {
            if (b == null)
                return null;

            MemoryStream memStream = new MemoryStream();
            memStream.Write(b, 0, b.Length);
            return Image.FromStream(memStream);
        }
    }
}
