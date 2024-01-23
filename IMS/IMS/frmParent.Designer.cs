namespace IMS
{
    partial class frmParent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbNewDistributor = new DevExpress.XtraNavBar.NavBarItem();
            this.bnNewCategory = new DevExpress.XtraNavBar.NavBarItem();
            this.nbAddPatient = new DevExpress.XtraNavBar.NavBarItem();
            this.nbNewMedicine = new DevExpress.XtraNavBar.NavBarItem();
            this.nbNewUser = new DevExpress.XtraNavBar.NavBarItem();
            this.nbResetPassword = new DevExpress.XtraNavBar.NavBarItem();
            this.bOrganization = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbBilling = new DevExpress.XtraNavBar.NavBarItem();
            this.nbStockEntry = new DevExpress.XtraNavBar.NavBarItem();
            this.nbConsultation = new DevExpress.XtraNavBar.NavBarItem();
            this.nbExpenses = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbCurrentStock = new DevExpress.XtraNavBar.NavBarItem();
            this.nbPatientBills = new DevExpress.XtraNavBar.NavBarItem();
            this.nbInvoice = new DevExpress.XtraNavBar.NavBarItem();
            this.nbReOrderReport = new DevExpress.XtraNavBar.NavBarItem();
            this.nbPriceComparision = new DevExpress.XtraNavBar.NavBarItem();
            this.nbConsultationReport = new DevExpress.XtraNavBar.NavBarItem();
            this.nbExpensesReport = new DevExpress.XtraNavBar.NavBarItem();
            this.nbAccount = new DevExpress.XtraNavBar.NavBarItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.BackColor = System.Drawing.Color.White;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup4,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.bnNewCategory,
            this.nbNewDistributor,
            this.nbAddPatient,
            this.nbNewMedicine,
            this.nbStockEntry,
            this.nbBilling,
            this.nbPatientBills,
            this.nbInvoice,
            this.nbCurrentStock,
            this.nbReOrderReport,
            this.nbPriceComparision,
            this.nbConsultation,
            this.nbConsultationReport,
            this.nbNewUser,
            this.nbExpenses,
            this.nbExpensesReport,
            this.nbResetPassword,
            this.bOrganization,
            this.nbAccount});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 223;
            this.navBarControl1.Size = new System.Drawing.Size(223, 732);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Masters";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbNewDistributor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bnNewCategory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbAddPatient),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbNewMedicine),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbNewUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbResetPassword),
            new DevExpress.XtraNavBar.NavBarItemLink(this.bOrganization)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbNewDistributor
            // 
            this.nbNewDistributor.Caption = "New Distributor";
            this.nbNewDistributor.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbNewDistributor.ImageOptions.SmallImage")));
            this.nbNewDistributor.Name = "nbNewDistributor";
            this.nbNewDistributor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbNewDistributor_LinkClicked);
            // 
            // bnNewCategory
            // 
            this.bnNewCategory.Caption = "New Category";
            this.bnNewCategory.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnNewCategory.ImageOptions.LargeImage")));
            this.bnNewCategory.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("bnNewCategory.ImageOptions.SmallImage")));
            this.bnNewCategory.Name = "bnNewCategory";
            this.bnNewCategory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bnNewCategory_LinkClicked);
            // 
            // nbAddPatient
            // 
            this.nbAddPatient.Caption = "Add Patient";
            this.nbAddPatient.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbAddPatient.ImageOptions.SmallImage")));
            this.nbAddPatient.Name = "nbAddPatient";
            this.nbAddPatient.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbAddPatient_LinkClicked);
            // 
            // nbNewMedicine
            // 
            this.nbNewMedicine.Caption = "New Medicine";
            this.nbNewMedicine.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbNewMedicine.ImageOptions.SmallImage")));
            this.nbNewMedicine.Name = "nbNewMedicine";
            this.nbNewMedicine.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbNewMedicine_LinkClicked);
            // 
            // nbNewUser
            // 
            this.nbNewUser.Caption = "New User";
            this.nbNewUser.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbNewUser.ImageOptions.SmallImage")));
            this.nbNewUser.Name = "nbNewUser";
            this.nbNewUser.Visible = false;
            this.nbNewUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbNewUser_LinkClicked);
            // 
            // nbResetPassword
            // 
            this.nbResetPassword.Caption = "Change Password";
            this.nbResetPassword.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbResetPassword.ImageOptions.SmallImage")));
            this.nbResetPassword.Name = "nbResetPassword";
            this.nbResetPassword.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbResetPassword_LinkClicked);
            // 
            // bOrganization
            // 
            this.bOrganization.Caption = "Organization";
            this.bOrganization.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("bOrganization.ImageOptions.SmallImage")));
            this.bOrganization.Name = "bOrganization";
            this.bOrganization.Visible = false;
            this.bOrganization.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.bOrganization_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Transactions";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbBilling),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbStockEntry),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbConsultation),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbExpenses)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // nbBilling
            // 
            this.nbBilling.Caption = "Billing";
            this.nbBilling.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbBilling.ImageOptions.SmallImage")));
            this.nbBilling.Name = "nbBilling";
            this.nbBilling.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbBilling_LinkClicked);
            // 
            // nbStockEntry
            // 
            this.nbStockEntry.Caption = "Invoice";
            this.nbStockEntry.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbStockEntry.ImageOptions.SmallImage")));
            this.nbStockEntry.Name = "nbStockEntry";
            this.nbStockEntry.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbStockEntry_LinkClicked);
            // 
            // nbConsultation
            // 
            this.nbConsultation.Caption = "Consultation";
            this.nbConsultation.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbConsultation.ImageOptions.SmallImage")));
            this.nbConsultation.Name = "nbConsultation";
            this.nbConsultation.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbConsultation_LinkClicked);
            // 
            // nbExpenses
            // 
            this.nbExpenses.Caption = "Add Expenses";
            this.nbExpenses.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbExpenses.ImageOptions.SmallImage")));
            this.nbExpenses.Name = "nbExpenses";
            this.nbExpenses.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbExpenses_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Reports";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbCurrentStock),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPatientBills),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbInvoice),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbReOrderReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPriceComparision),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbConsultationReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbExpensesReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbAccount)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbCurrentStock
            // 
            this.nbCurrentStock.Caption = "Stock Report";
            this.nbCurrentStock.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbCurrentStock.ImageOptions.SmallImage")));
            this.nbCurrentStock.Name = "nbCurrentStock";
            this.nbCurrentStock.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbCurrentStock_LinkClicked);
            // 
            // nbPatientBills
            // 
            this.nbPatientBills.Caption = "Patient Bills";
            this.nbPatientBills.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbPatientBills.ImageOptions.SmallImage")));
            this.nbPatientBills.Name = "nbPatientBills";
            this.nbPatientBills.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbPatientBills_LinkClicked);
            // 
            // nbInvoice
            // 
            this.nbInvoice.Caption = "Invoice Bills";
            this.nbInvoice.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbInvoice.ImageOptions.SmallImage")));
            this.nbInvoice.Name = "nbInvoice";
            this.nbInvoice.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbInvoice_LinkClicked);
            // 
            // nbReOrderReport
            // 
            this.nbReOrderReport.Caption = "ReOrder Report";
            this.nbReOrderReport.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbReOrderReport.ImageOptions.SmallImage")));
            this.nbReOrderReport.Name = "nbReOrderReport";
            this.nbReOrderReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbReOrderReport_LinkClicked);
            // 
            // nbPriceComparision
            // 
            this.nbPriceComparision.Caption = "Price Comparision";
            this.nbPriceComparision.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbPriceComparision.ImageOptions.SmallImage")));
            this.nbPriceComparision.Name = "nbPriceComparision";
            this.nbPriceComparision.Visible = false;
            this.nbPriceComparision.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbPriceComparision_LinkClicked);
            // 
            // nbConsultationReport
            // 
            this.nbConsultationReport.Caption = "Consultation Report";
            this.nbConsultationReport.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbConsultationReport.ImageOptions.SmallImage")));
            this.nbConsultationReport.Name = "nbConsultationReport";
            this.nbConsultationReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbConsultationReport_LinkClicked);
            // 
            // nbExpensesReport
            // 
            this.nbExpensesReport.Caption = "Expenses Report";
            this.nbExpensesReport.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbExpensesReport.ImageOptions.SmallImage")));
            this.nbExpensesReport.Name = "nbExpensesReport";
            this.nbExpensesReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbExpensesReport_LinkClicked);
            // 
            // nbAccount
            // 
            this.nbAccount.Caption = "Account";
            this.nbAccount.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbAccount.ImageOptions.SmallImage")));
            this.nbAccount.Name = "nbAccount";
            this.nbAccount.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbAccount_LinkClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTime});
            this.statusStrip1.Location = new System.Drawing.Point(223, 710);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(841, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsTime
            // 
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmParent
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = global::IMS.Properties.Resources.NameTItle;
            this.ClientSize = new System.Drawing.Size(1064, 732);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.navBarControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmParent";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.frmParent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem bnNewCategory;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem nbNewDistributor;
        private DevExpress.XtraNavBar.NavBarItem nbAddPatient;
        private DevExpress.XtraNavBar.NavBarItem nbNewMedicine;
        private DevExpress.XtraNavBar.NavBarItem nbStockEntry;
        private DevExpress.XtraNavBar.NavBarItem nbBilling;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbPatientBills;
        private DevExpress.XtraNavBar.NavBarItem nbInvoice;
        private DevExpress.XtraNavBar.NavBarItem nbCurrentStock;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraNavBar.NavBarItem nbReOrderReport;
        private DevExpress.XtraNavBar.NavBarItem nbPriceComparision;
        private DevExpress.XtraNavBar.NavBarItem nbConsultation;
        private DevExpress.XtraNavBar.NavBarItem nbConsultationReport;
        private DevExpress.XtraNavBar.NavBarItem nbNewUser;
        private DevExpress.XtraNavBar.NavBarItem nbExpenses;
        private DevExpress.XtraNavBar.NavBarItem nbExpensesReport;
        private DevExpress.XtraNavBar.NavBarItem nbResetPassword;
        private DevExpress.XtraNavBar.NavBarItem bOrganization;
        private DevExpress.XtraNavBar.NavBarItem nbAccount;



    }
}

