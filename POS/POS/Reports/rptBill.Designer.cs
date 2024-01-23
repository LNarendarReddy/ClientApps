namespace POS.Reports
{
    partial class rptBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.PosName = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.StudentName = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.RFID = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.Amount = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.Ramarks = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.AdmissionNumber = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0.2976145F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLine1,
            this.xrLabel1});
            this.Detail.HeightF = 134.375F;
            this.Detail.Name = "Detail";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.PosName, "Text", "")});
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 57.23484F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(180.21F, 20F);
            this.xrLabel4.StylePriority.UseFont = false;
            // 
            // PosName
            // 
            this.PosName.Description = "PosName";
            this.PosName.Name = "PosName";
            this.PosName.Visible = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.StudentName, "Text", "")});
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 37.23484F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(180.21F, 20F);
            this.xrLabel2.StylePriority.UseFont = false;
            // 
            // StudentName
            // 
            this.StudentName.Description = "StudentName";
            this.StudentName.Name = "StudentName";
            this.StudentName.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.RFID, "Text", "")});
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 14.23484F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(180.21F, 20F);
            this.xrLabel3.StylePriority.UseFont = false;
            // 
            // RFID
            // 
            this.RFID.Description = "RFID";
            this.RFID.Name = "RFID";
            this.RFID.Visible = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Amount, "Text", "")});
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(44.98166F, 77.23484F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(155.0183F, 20F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.TextFormatString = "{0:n2}";
            // 
            // Amount
            // 
            this.Amount.Description = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Ramarks, "Text", "")});
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 97.23484F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(180.21F, 20F);
            this.xrLabel6.StylePriority.UseFont = false;
            // 
            // Ramarks
            // 
            this.Ramarks.Description = "Ramarks";
            this.Ramarks.Name = "Ramarks";
            this.Ramarks.Visible = false;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 3F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 34.23484F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(180.2083F, 3F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 77.23487F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(25.19F, 20F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Rs.";
            // 
            // AdmissionNumber
            // 
            this.AdmissionNumber.Description = "AdmissionNumber";
            this.AdmissionNumber.Name = "AdmissionNumber";
            this.AdmissionNumber.Type = typeof(int);
            this.AdmissionNumber.ValueInfo = "0";
            this.AdmissionNumber.Visible = false;
            // 
            // rptBill
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(0, 626, 0, 0);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AdmissionNumber,
            this.StudentName,
            this.RFID,
            this.Amount,
            this.PosName,
            this.Ramarks});
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter AdmissionNumber;
        private DevExpress.XtraReports.Parameters.Parameter StudentName;
        private DevExpress.XtraReports.Parameters.Parameter RFID;
        private DevExpress.XtraReports.Parameters.Parameter Amount;
        private DevExpress.XtraReports.Parameters.Parameter PosName;
        private DevExpress.XtraReports.Parameters.Parameter Ramarks;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    }
}
