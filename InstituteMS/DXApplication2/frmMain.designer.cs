namespace InstituteMS
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.accordionContentContainer2 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnModules = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOrganizationMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBranchMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUserMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCourseMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStudentMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnEmailConfiguration = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSMSConfiguration = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btbExpenses = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStudentEnquiry = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBookMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBookStockEntry = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBookSales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDailyCollection = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStudentReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDueReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnExpensesReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.rptEnquiryReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBookEntryReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBookSaleReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBookStockReport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.lblUserfdafda = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.accordionControl1.SuspendLayout();
            this.accordionContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.accordionContentContainer2.SuspendLayout();
            this.lblUserfdafda.SuspendLayout();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Item.Disabled.Font = new System.Drawing.Font("Tahoma", 9F);
            this.accordionControl1.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 9F);
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 9F);
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Controls.Add(this.accordionContentContainer1);
            this.accordionControl1.Controls.Add(this.accordionContentContainer2);
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnModules,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement4});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(199, 743);
            this.accordionControl1.TabIndex = 0;
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Controls.Add(this.pictureEdit1);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(180, 76);
            this.accordionContentContainer1.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::InstituteMS.Properties.Resources.Gyana;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(180, 76);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // accordionContentContainer2
            // 
            this.accordionContentContainer2.Controls.Add(this.labelControl1);
            this.accordionContentContainer2.Name = "accordionContentContainer2";
            this.accordionContentContainer2.Size = new System.Drawing.Size(180, 76);
            this.accordionContentContainer2.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Powered by Gyanasoft.com";
            // 
            // btnModules
            // 
            this.btnModules.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnOrganizationMaster,
            this.btnBranchMaster,
            this.btnUserMaster,
            this.btnCourseMaster,
            this.btnStudentMaster,
            this.btnEmailConfiguration,
            this.btnSMSConfiguration,
            this.btbExpenses,
            this.accordionControlElement6,
            this.btnStudentEnquiry,
            this.btnBookMaster,
            this.btnBookStockEntry,
            this.btnBookSales});
            this.btnModules.Expanded = true;
            this.btnModules.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModules.ImageOptions.Image")));
            this.btnModules.Name = "btnModules";
            this.btnModules.Text = "Modules";
            // 
            // btnOrganizationMaster
            // 
            this.btnOrganizationMaster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOrganizationMaster.ImageOptions.Image")));
            this.btnOrganizationMaster.Name = "btnOrganizationMaster";
            this.btnOrganizationMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOrganizationMaster.Text = "Orgnanization Master";
            this.btnOrganizationMaster.Visible = false;
            this.btnOrganizationMaster.Click += new System.EventHandler(this.btnOrganizationMaster_Click);
            // 
            // btnBranchMaster
            // 
            this.btnBranchMaster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBranchMaster.ImageOptions.Image")));
            this.btnBranchMaster.Name = "btnBranchMaster";
            this.btnBranchMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBranchMaster.Text = "Branch Master";
            this.btnBranchMaster.Visible = false;
            this.btnBranchMaster.Click += new System.EventHandler(this.btnBranchMaster_Click);
            // 
            // btnUserMaster
            // 
            this.btnUserMaster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserMaster.ImageOptions.Image")));
            this.btnUserMaster.Name = "btnUserMaster";
            this.btnUserMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUserMaster.Text = "User Master";
            this.btnUserMaster.Visible = false;
            this.btnUserMaster.Click += new System.EventHandler(this.btnUserMaster_Click);
            // 
            // btnCourseMaster
            // 
            this.btnCourseMaster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCourseMaster.ImageOptions.Image")));
            this.btnCourseMaster.Name = "btnCourseMaster";
            this.btnCourseMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCourseMaster.Text = "Course Master";
            this.btnCourseMaster.Click += new System.EventHandler(this.btnCourseMaster_Click);
            // 
            // btnStudentMaster
            // 
            this.btnStudentMaster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentMaster.ImageOptions.Image")));
            this.btnStudentMaster.Name = "btnStudentMaster";
            this.btnStudentMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStudentMaster.Text = "Student Master";
            this.btnStudentMaster.Click += new System.EventHandler(this.btnStudentMaster_Click);
            // 
            // btnEmailConfiguration
            // 
            this.btnEmailConfiguration.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmailConfiguration.ImageOptions.Image")));
            this.btnEmailConfiguration.Name = "btnEmailConfiguration";
            this.btnEmailConfiguration.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnEmailConfiguration.Text = "Email Configuration";
            this.btnEmailConfiguration.Visible = false;
            this.btnEmailConfiguration.Click += new System.EventHandler(this.btnEmailConfiguration_Click);
            // 
            // btnSMSConfiguration
            // 
            this.btnSMSConfiguration.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSMSConfiguration.ImageOptions.Image")));
            this.btnSMSConfiguration.Name = "btnSMSConfiguration";
            this.btnSMSConfiguration.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSMSConfiguration.Text = "SMS Configuration";
            this.btnSMSConfiguration.Visible = false;
            this.btnSMSConfiguration.Click += new System.EventHandler(this.btnSMSConfiguration_Click);
            // 
            // btbExpenses
            // 
            this.btbExpenses.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btbExpenses.ImageOptions.Image")));
            this.btbExpenses.Name = "btbExpenses";
            this.btbExpenses.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btbExpenses.Text = "Expenses";
            this.btbExpenses.Click += new System.EventHandler(this.btbExpenses_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Change Password";
            this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // btnStudentEnquiry
            // 
            this.btnStudentEnquiry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentEnquiry.ImageOptions.Image")));
            this.btnStudentEnquiry.Name = "btnStudentEnquiry";
            this.btnStudentEnquiry.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStudentEnquiry.Text = "Student Enquiry";
            this.btnStudentEnquiry.Click += new System.EventHandler(this.btnStudentEnquiry_Click);
            // 
            // btnBookMaster
            // 
            this.btnBookMaster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookMaster.ImageOptions.Image")));
            this.btnBookMaster.Name = "btnBookMaster";
            this.btnBookMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBookMaster.Text = "Book Master";
            this.btnBookMaster.Click += new System.EventHandler(this.btnBookMaster_Click);
            // 
            // btnBookStockEntry
            // 
            this.btnBookStockEntry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookStockEntry.ImageOptions.Image")));
            this.btnBookStockEntry.Name = "btnBookStockEntry";
            this.btnBookStockEntry.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBookStockEntry.Text = "Book Stock Entry";
            this.btnBookStockEntry.Click += new System.EventHandler(this.btnBookStockEntry_Click);
            // 
            // btnBookSales
            // 
            this.btnBookSales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSales.ImageOptions.Image")));
            this.btnBookSales.Name = "btnBookSales";
            this.btnBookSales.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBookSales.Text = "Book Sales";
            this.btnBookSales.Click += new System.EventHandler(this.btnBookSales_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnDailyCollection,
            this.btnStudentReport,
            this.btnDueReport,
            this.btnExpensesReport,
            this.rptEnquiryReport,
            this.btnBookEntryReport,
            this.btnBookSaleReport,
            this.btnBookStockReport});
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Reports";
            // 
            // btnDailyCollection
            // 
            this.btnDailyCollection.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDailyCollection.ImageOptions.Image")));
            this.btnDailyCollection.Name = "btnDailyCollection";
            this.btnDailyCollection.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDailyCollection.Text = "Daily Collection";
            this.btnDailyCollection.Click += new System.EventHandler(this.btnDailyCollection_Click);
            // 
            // btnStudentReport
            // 
            this.btnStudentReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentReport.ImageOptions.Image")));
            this.btnStudentReport.Name = "btnStudentReport";
            this.btnStudentReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStudentReport.Text = "Student Report";
            this.btnStudentReport.Click += new System.EventHandler(this.btnStudentReport_Click);
            // 
            // btnDueReport
            // 
            this.btnDueReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDueReport.ImageOptions.Image")));
            this.btnDueReport.Name = "btnDueReport";
            this.btnDueReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDueReport.Text = "Due Date Report";
            this.btnDueReport.Click += new System.EventHandler(this.btnDueReport_Click);
            // 
            // btnExpensesReport
            // 
            this.btnExpensesReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExpensesReport.ImageOptions.Image")));
            this.btnExpensesReport.Name = "btnExpensesReport";
            this.btnExpensesReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnExpensesReport.Text = "Expenses Report";
            this.btnExpensesReport.Click += new System.EventHandler(this.btnExpensesReport_Click);
            // 
            // rptEnquiryReport
            // 
            this.rptEnquiryReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rptEnquiryReport.ImageOptions.Image")));
            this.rptEnquiryReport.Name = "rptEnquiryReport";
            this.rptEnquiryReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.rptEnquiryReport.Text = "Enquiry Report";
            this.rptEnquiryReport.Click += new System.EventHandler(this.rptEnquiryReport_Click);
            // 
            // btnBookEntryReport
            // 
            this.btnBookEntryReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookEntryReport.ImageOptions.Image")));
            this.btnBookEntryReport.Name = "btnBookEntryReport";
            this.btnBookEntryReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBookEntryReport.Text = "Book Entry Report";
            this.btnBookEntryReport.Click += new System.EventHandler(this.btnBookEntryReport_Click);
            // 
            // btnBookSaleReport
            // 
            this.btnBookSaleReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSaleReport.ImageOptions.Image")));
            this.btnBookSaleReport.Name = "btnBookSaleReport";
            this.btnBookSaleReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBookSaleReport.Text = "Book Sale Report";
            this.btnBookSaleReport.Click += new System.EventHandler(this.btnBookSaleReport_Click);
            // 
            // btnBookStockReport
            // 
            this.btnBookStockReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookStockReport.ImageOptions.Image")));
            this.btnBookStockReport.Name = "btnBookStockReport";
            this.btnBookStockReport.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBookStockReport.Text = "Book Stock Report";
            this.btnBookStockReport.Click += new System.EventHandler(this.btnBookStockReport_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.HeaderVisible = false;
            this.accordionControlElement2.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Stretch;
            this.accordionControlElement2.Name = "accordionControlElement2";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ContentContainer = this.accordionContentContainer1;
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.HeaderVisible = false;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5});
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.HeaderVisible = false;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Powered by Gyanasoft.com";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.ContentContainer = this.accordionContentContainer2;
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.HeaderVisible = false;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Element5";
            // 
            // lblUserfdafda
            // 
            this.lblUserfdafda.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.lblUserfdafda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblUser,
            this.lblVersion});
            this.lblUserfdafda.Location = new System.Drawing.Point(199, 720);
            this.lblUserfdafda.Name = "lblUserfdafda";
            this.lblUserfdafda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserfdafda.Size = new System.Drawing.Size(996, 23);
            this.lblUserfdafda.TabIndex = 2;
            this.lblUserfdafda.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 0);
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 0);
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(143, 18);
            this.lblVersion.Text = "toolStripStatusLabel1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 743);
            this.Controls.Add(this.lblUserfdafda);
            this.Controls.Add(this.accordionControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMain.IconOptions.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Institute Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.accordionControl1.ResumeLayout(false);
            this.accordionContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.accordionContentContainer2.ResumeLayout(false);
            this.accordionContentContainer2.PerformLayout();
            this.lblUserfdafda.ResumeLayout(false);
            this.lblUserfdafda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnModules;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnOrganizationMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUserMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCourseMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStudentMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnEmailConfiguration;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSMSConfiguration;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDailyCollection;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStudentReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDueReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBranchMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btbExpenses;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnExpensesReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private System.Windows.Forms.StatusStrip lblUserfdafda;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement rptEnquiryReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStudentEnquiry;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBookMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBookStockEntry;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBookSales;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBookEntryReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBookSaleReport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBookStockReport;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    }
}