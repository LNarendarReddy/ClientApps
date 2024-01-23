using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DL;
using System.IO;
using NumbertoWords;

namespace InstituteMS.ReportDesign
{
    public partial class FeeRecieptAkshaya : DevExpress.XtraReports.UI.XtraReport
    {
        public FeeRecieptAkshaya()
        {
            InitializeComponent();
            this.sqlDataSource1.ConnectionParameters = new 
                DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters(SQLCon.ServerName, 
                SQLCon.DBName, SQLCon.UserName, SQLCon.Password, DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer);
            this.Watermark.Image = BinaryToImage(Utility.Imagedata);
            this.Watermark.ImageAlign = ContentAlignment.TopCenter;
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

        private void xrTableCell27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                long lValue = 0;
                decimal dValue = 0;
                if (decimal.TryParse(txtAmount.Text, out dValue))
                {
                    if (long.TryParse(Convert.ToString(Math.Round(dValue,0)) , out lValue))
                    {
                        xrTableCell27.Text = NumeriCon.ConvertNum(lValue);
                    }
                }
            }
            catch (Exception ex){}
        }

        private void xrTableCell17_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                long lValue = 0;
                decimal dValue = 0;
                if (decimal.TryParse(txtAmount1.Text, out dValue))
                {
                    if (long.TryParse(Convert.ToString(Math.Round(dValue, 0)), out lValue))
                    {
                        xrTableCell17.Text = NumeriCon.ConvertNum(lValue);
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}
