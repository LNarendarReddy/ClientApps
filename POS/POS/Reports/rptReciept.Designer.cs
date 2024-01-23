namespace POS.Reports
{
    partial class rptReciept
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.Remarks = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.Amount = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.RFID = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.StudentName = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.AdmissionNumber = new DevExpress.XtraReports.Parameters.Parameter();
            this.CNumber = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLine1,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel2});
            this.Detail.HeightF = 111.8371F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 57.23486F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(25.19F, 20F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "Rs.";
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 3F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 34.23484F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(180.2083F, 3F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Remarks, "Text", "")});
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(19.79166F, 77.23483F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(180.21F, 20F);
            this.xrLabel6.StylePriority.UseFont = false;
            // 
            // Remarks
            // 
            this.Remarks.Description = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.Visible = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Amount, "Text", "")});
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(44.98166F, 57.23483F);
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
            this.Amount.Type = typeof(decimal);
            this.Amount.ValueInfo = "0";
            this.Amount.Visible = false;
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
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AdmissionNumber
            // 
            this.AdmissionNumber.Description = "AdmissionNumber";
            this.AdmissionNumber.Name = "AdmissionNumber";
            this.AdmissionNumber.Type = typeof(int);
            this.AdmissionNumber.ValueInfo = "0";
            this.AdmissionNumber.Visible = false;
            // 
            // CNumber
            // 
            this.CNumber.Description = "CNumber";
            this.CNumber.Name = "CNumber";
            this.CNumber.Visible = false;
            // 
            // rptReciept
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(0, 626, 0, 0);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AdmissionNumber,
            this.StudentName,
            this.RFID,
            this.Remarks,
            this.CNumber,
            this.Amount});
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter AdmissionNumber;
        private DevExpress.XtraReports.Parameters.Parameter StudentName;
        private DevExpress.XtraReports.Parameters.Parameter RFID;
        private DevExpress.XtraReports.Parameters.Parameter Remarks;
        private DevExpress.XtraReports.Parameters.Parameter CNumber;
        private DevExpress.XtraReports.Parameters.Parameter Amount;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
