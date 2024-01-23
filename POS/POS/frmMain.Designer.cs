namespace POS
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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbUserMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.nbPosMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.nbStudentMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.nbPOSLogin = new DevExpress.XtraNavBar.NavBarItem();
            this.nbOrgLogo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbSMSConfiguration = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgReports = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbTansactionReport = new DevExpress.XtraNavBar.NavBarItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pcorgLogo = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcorgLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = true;
            this.navBarControl1.Appearance.Item.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.navBarControl1.Appearance.Item.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemActive.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.navBarControl1.Appearance.ItemActive.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemHotTracked.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseFont = true;
            this.navBarControl1.Appearance.ItemPressed.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline);
            this.navBarControl1.Appearance.ItemPressed.Options.UseFont = true;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.nbgReports});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbUserMaster,
            this.nbPosMaster,
            this.nbStudentMaster,
            this.nbPOSLogin,
            this.nbTansactionReport,
            this.nbOrgLogo,
            this.nbSMSConfiguration});
            this.navBarControl1.Location = new System.Drawing.Point(2, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 218;
            this.navBarControl1.Size = new System.Drawing.Size(218, 707);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Modules";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.SmallImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbUserMaster),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPosMaster),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbStudentMaster),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPOSLogin),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbOrgLogo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbSMSConfiguration)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbUserMaster
            // 
            this.nbUserMaster.Caption = "User Master";
            this.nbUserMaster.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbUserMaster.ImageOptions.SmallImage")));
            this.nbUserMaster.Name = "nbUserMaster";
            this.nbUserMaster.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbUserMaster_LinkClicked);
            // 
            // nbPosMaster
            // 
            this.nbPosMaster.Caption = "POS Master";
            this.nbPosMaster.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbPosMaster.ImageOptions.SmallImage")));
            this.nbPosMaster.Name = "nbPosMaster";
            this.nbPosMaster.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbPosMaster_LinkClicked);
            // 
            // nbStudentMaster
            // 
            this.nbStudentMaster.Caption = "Student Master";
            this.nbStudentMaster.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbStudentMaster.ImageOptions.SmallImage")));
            this.nbStudentMaster.Name = "nbStudentMaster";
            this.nbStudentMaster.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbStudentMaster_LinkPressed);
            // 
            // nbPOSLogin
            // 
            this.nbPOSLogin.Caption = "POS Login";
            this.nbPOSLogin.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbPOSLogin.ImageOptions.SmallImage")));
            this.nbPOSLogin.Name = "nbPOSLogin";
            this.nbPOSLogin.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbPOSLogin_LinkClicked);
            // 
            // nbOrgLogo
            // 
            this.nbOrgLogo.Caption = "Organization Logo";
            this.nbOrgLogo.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbOrgLogo.ImageOptions.SmallImage")));
            this.nbOrgLogo.Name = "nbOrgLogo";
            this.nbOrgLogo.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbOrgLogo_LinkClicked);
            // 
            // nbSMSConfiguration
            // 
            this.nbSMSConfiguration.Caption = "SMS Configuration";
            this.nbSMSConfiguration.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbSMSConfiguration.ImageOptions.SmallImage")));
            this.nbSMSConfiguration.Name = "nbSMSConfiguration";
            this.nbSMSConfiguration.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbSMSConfiguration_LinkClicked);
            // 
            // nbgReports
            // 
            this.nbgReports.Caption = "Reports";
            this.nbgReports.Expanded = true;
            this.nbgReports.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgReports.ImageOptions.SmallImage")));
            this.nbgReports.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTansactionReport)});
            this.nbgReports.Name = "nbgReports";
            // 
            // nbTansactionReport
            // 
            this.nbTansactionReport.Caption = "Transaction Report";
            this.nbTansactionReport.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbTansactionReport.ImageOptions.SmallImage")));
            this.nbTansactionReport.Name = "nbTansactionReport";
            this.nbTansactionReport.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTansactionReport_LinkClicked);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pcorgLogo);
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1283, 443, 650, 380);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1163, 711);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pcorgLogo
            // 
            this.pcorgLogo.Location = new System.Drawing.Point(224, 2);
            this.pcorgLogo.Name = "pcorgLogo";
            this.pcorgLogo.Properties.ShowMenu = false;
            this.pcorgLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pcorgLogo.Size = new System.Drawing.Size(937, 707);
            this.pcorgLogo.StyleController = this.layoutControl1;
            this.pcorgLogo.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1163, 711);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navBarControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(222, 711);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(222, 711);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(222, 711);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pcorgLogo;
            this.layoutControlItem2.Location = new System.Drawing.Point(222, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(941, 711);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1163, 711);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcorgLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbUserMaster;
        private DevExpress.XtraNavBar.NavBarItem nbPosMaster;
        private DevExpress.XtraNavBar.NavBarItem nbStudentMaster;
        private DevExpress.XtraNavBar.NavBarGroup nbgReports;
        private DevExpress.XtraNavBar.NavBarItem nbPOSLogin;
        private DevExpress.XtraNavBar.NavBarItem nbTansactionReport;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PictureEdit pcorgLogo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraNavBar.NavBarItem nbOrgLogo;
        private DevExpress.XtraNavBar.NavBarItem nbSMSConfiguration;
    }
}

