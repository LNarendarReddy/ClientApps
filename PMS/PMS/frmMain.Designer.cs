namespace PMS
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biPatients = new DevExpress.XtraBars.BarButtonItem();
            this.biCategories = new DevExpress.XtraBars.BarButtonItem();
            this.biDoctors = new DevExpress.XtraBars.BarButtonItem();
            this.biMedicines = new DevExpress.XtraBars.BarButtonItem();
            this.biOrganization = new DevExpress.XtraBars.BarButtonItem();
            this.biBranch = new DevExpress.XtraBars.BarButtonItem();
            this.biUsers = new DevExpress.XtraBars.BarButtonItem();
            this.biTreatment = new DevExpress.XtraBars.BarButtonItem();
            this.biStockUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.biPatientHistory = new DevExpress.XtraBars.BarButtonItem();
            this.biEmailConfig = new DevExpress.XtraBars.BarButtonItem();
            this.biSMSConfig = new DevExpress.XtraBars.BarButtonItem();
            this.biChangepwd = new DevExpress.XtraBars.BarButtonItem();
            this.biCurrentDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.biDayCollections = new DevExpress.XtraBars.BarButtonItem();
            this.btnBookAppointments = new DevExpress.XtraBars.BarButtonItem();
            this.btnAppointments = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrinterMaster = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatabaseBackup = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpdAdmin = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biPatients,
            this.biCategories,
            this.biDoctors,
            this.biMedicines,
            this.biOrganization,
            this.biBranch,
            this.biUsers,
            this.biTreatment,
            this.biStockUpdate,
            this.biPatientHistory,
            this.biEmailConfig,
            this.biSMSConfig,
            this.biChangepwd,
            this.biCurrentDate,
            this.biDayCollections,
            this.btnBookAppointments,
            this.btnAppointments,
            this.btnPrinterMaster,
            this.btnDatabaseBackup});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 26;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemDateEdit3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1253, 133);
            // 
            // biPatients
            // 
            this.biPatients.Caption = "Patients";
            this.biPatients.Id = 1;
            this.biPatients.ImageOptions.SvgImage = global::PMS.Properties.Resources.Patient;
            this.biPatients.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biPatients.ItemAppearance.Hovered.Options.UseFont = true;
            this.biPatients.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biPatients.ItemAppearance.Normal.Options.UseFont = true;
            this.biPatients.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biPatients.ItemAppearance.Pressed.Options.UseFont = true;
            this.biPatients.Name = "biPatients";
            this.biPatients.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biPatients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biPatients_ItemClick);
            // 
            // biCategories
            // 
            this.biCategories.Caption = "Investigations";
            this.biCategories.Id = 2;
            this.biCategories.ImageOptions.Image = global::PMS.Properties.Resources.Category;
            this.biCategories.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biCategories.ItemAppearance.Hovered.Options.UseFont = true;
            this.biCategories.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biCategories.ItemAppearance.Normal.Options.UseFont = true;
            this.biCategories.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biCategories.ItemAppearance.Pressed.Options.UseFont = true;
            this.biCategories.Name = "biCategories";
            this.biCategories.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biCategories_ItemClick);
            // 
            // biDoctors
            // 
            this.biDoctors.Caption = "Doctors";
            this.biDoctors.Id = 3;
            this.biDoctors.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biDoctors.ImageOptions.Image")));
            this.biDoctors.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biDoctors.ItemAppearance.Hovered.Options.UseFont = true;
            this.biDoctors.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biDoctors.ItemAppearance.Normal.Options.UseFont = true;
            this.biDoctors.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biDoctors.ItemAppearance.Pressed.Options.UseFont = true;
            this.biDoctors.Name = "biDoctors";
            this.biDoctors.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biDoctors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDoctors_ItemClick);
            // 
            // biMedicines
            // 
            this.biMedicines.Caption = "Medicines";
            this.biMedicines.Id = 7;
            this.biMedicines.ImageOptions.Image = global::PMS.Properties.Resources.Medicine;
            this.biMedicines.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biMedicines.ItemAppearance.Hovered.Options.UseFont = true;
            this.biMedicines.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biMedicines.ItemAppearance.Normal.Options.UseFont = true;
            this.biMedicines.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biMedicines.ItemAppearance.Pressed.Options.UseFont = true;
            this.biMedicines.Name = "biMedicines";
            this.biMedicines.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biMedicines.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biMedicines_ItemClick);
            // 
            // biOrganization
            // 
            this.biOrganization.Caption = "Organization";
            this.biOrganization.Id = 8;
            this.biOrganization.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biOrganization.ImageOptions.SvgImage")));
            this.biOrganization.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biOrganization.ItemAppearance.Hovered.Options.UseFont = true;
            this.biOrganization.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biOrganization.ItemAppearance.Normal.Options.UseFont = true;
            this.biOrganization.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biOrganization.ItemAppearance.Pressed.Options.UseFont = true;
            this.biOrganization.Name = "biOrganization";
            this.biOrganization.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biOrganization.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.biOrganization.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biOrganization_ItemClick);
            // 
            // biBranch
            // 
            this.biBranch.Caption = "Branch";
            this.biBranch.Id = 9;
            this.biBranch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biBranch.ImageOptions.Image")));
            this.biBranch.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biBranch.ImageOptions.LargeImage")));
            this.biBranch.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biBranch.ItemAppearance.Hovered.Options.UseFont = true;
            this.biBranch.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biBranch.ItemAppearance.Normal.Options.UseFont = true;
            this.biBranch.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biBranch.ItemAppearance.Pressed.Options.UseFont = true;
            this.biBranch.Name = "biBranch";
            this.biBranch.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biBranch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.biBranch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biBranch_ItemClick);
            // 
            // biUsers
            // 
            this.biUsers.Caption = "Users";
            this.biUsers.Id = 10;
            this.biUsers.ImageOptions.Image = global::PMS.Properties.Resources.users;
            this.biUsers.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biUsers.ItemAppearance.Hovered.Options.UseFont = true;
            this.biUsers.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biUsers.ItemAppearance.Normal.Options.UseFont = true;
            this.biUsers.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biUsers.ItemAppearance.Pressed.Options.UseFont = true;
            this.biUsers.Name = "biUsers";
            this.biUsers.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.biUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biUsers_ItemClick);
            // 
            // biTreatment
            // 
            this.biTreatment.Caption = "Treatment";
            this.biTreatment.Id = 12;
            this.biTreatment.ImageOptions.Image = global::PMS.Properties.Resources.Treatment;
            this.biTreatment.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biTreatment.ItemAppearance.Hovered.Options.UseFont = true;
            this.biTreatment.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biTreatment.ItemAppearance.Normal.Options.UseFont = true;
            this.biTreatment.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biTreatment.ItemAppearance.Pressed.Options.UseFont = true;
            this.biTreatment.Name = "biTreatment";
            this.biTreatment.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biTreatment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biTreatment_ItemClick);
            // 
            // biStockUpdate
            // 
            this.biStockUpdate.Caption = "Stock Update";
            this.biStockUpdate.Id = 13;
            this.biStockUpdate.ImageOptions.Image = global::PMS.Properties.Resources.Stock;
            this.biStockUpdate.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biStockUpdate.ItemAppearance.Hovered.Options.UseFont = true;
            this.biStockUpdate.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biStockUpdate.ItemAppearance.Normal.Options.UseFont = true;
            this.biStockUpdate.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biStockUpdate.ItemAppearance.Pressed.Options.UseFont = true;
            this.biStockUpdate.Name = "biStockUpdate";
            this.biStockUpdate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biStockUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biStockUpdate_ItemClick);
            // 
            // biPatientHistory
            // 
            this.biPatientHistory.Caption = "Patient History";
            this.biPatientHistory.Id = 14;
            this.biPatientHistory.ImageOptions.SvgImage = global::PMS.Properties.Resources.history;
            this.biPatientHistory.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biPatientHistory.ItemAppearance.Hovered.Options.UseFont = true;
            this.biPatientHistory.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biPatientHistory.ItemAppearance.Normal.Options.UseFont = true;
            this.biPatientHistory.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biPatientHistory.ItemAppearance.Pressed.Options.UseFont = true;
            this.biPatientHistory.Name = "biPatientHistory";
            this.biPatientHistory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biPatientHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biPatientHistory_ItemClick);
            // 
            // biEmailConfig
            // 
            this.biEmailConfig.Caption = "Email Configuration";
            this.biEmailConfig.Id = 15;
            this.biEmailConfig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biEmailConfig.ImageOptions.Image")));
            this.biEmailConfig.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biEmailConfig.ImageOptions.LargeImage")));
            this.biEmailConfig.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biEmailConfig.ItemAppearance.Hovered.Options.UseFont = true;
            this.biEmailConfig.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biEmailConfig.ItemAppearance.Normal.Options.UseFont = true;
            this.biEmailConfig.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biEmailConfig.ItemAppearance.Pressed.Options.UseFont = true;
            this.biEmailConfig.Name = "biEmailConfig";
            this.biEmailConfig.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biEmailConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.biEmailConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biEmailConfig_ItemClick);
            // 
            // biSMSConfig
            // 
            this.biSMSConfig.Caption = "SMS Configuration";
            this.biSMSConfig.Id = 16;
            this.biSMSConfig.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biSMSConfig.ImageOptions.SvgImage")));
            this.biSMSConfig.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biSMSConfig.ItemAppearance.Hovered.Options.UseFont = true;
            this.biSMSConfig.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biSMSConfig.ItemAppearance.Normal.Options.UseFont = true;
            this.biSMSConfig.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biSMSConfig.ItemAppearance.Pressed.Options.UseFont = true;
            this.biSMSConfig.Name = "biSMSConfig";
            this.biSMSConfig.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biSMSConfig.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.biSMSConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSMSConfig_ItemClick);
            // 
            // biChangepwd
            // 
            this.biChangepwd.Caption = "Change Password";
            this.biChangepwd.Id = 17;
            this.biChangepwd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biChangepwd.ImageOptions.Image")));
            this.biChangepwd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biChangepwd.ImageOptions.LargeImage")));
            this.biChangepwd.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biChangepwd.ItemAppearance.Hovered.Options.UseFont = true;
            this.biChangepwd.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biChangepwd.ItemAppearance.Normal.Options.UseFont = true;
            this.biChangepwd.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biChangepwd.ItemAppearance.Pressed.Options.UseFont = true;
            this.biChangepwd.Name = "biChangepwd";
            this.biChangepwd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biChangepwd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biChangepwd_ItemClick);
            // 
            // biCurrentDate
            // 
            this.biCurrentDate.Caption = "Current Date";
            this.biCurrentDate.Edit = this.repositoryItemDateEdit3;
            this.biCurrentDate.EditWidth = 200;
            this.biCurrentDate.Id = 20;
            this.biCurrentDate.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biCurrentDate.ItemAppearance.Hovered.Options.UseFont = true;
            this.biCurrentDate.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biCurrentDate.ItemAppearance.Normal.Options.UseFont = true;
            this.biCurrentDate.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biCurrentDate.ItemAppearance.Pressed.Options.UseFont = true;
            this.biCurrentDate.Name = "biCurrentDate";
            this.biCurrentDate.EditValueChanged += new System.EventHandler(this.biCurrentDate_EditValueChanged);
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.DisplayFormat.FormatString = "f";
            this.repositoryItemDateEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.Mask.EditMask = "f";
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // biDayCollections
            // 
            this.biDayCollections.Caption = "Day Collections";
            this.biDayCollections.Id = 21;
            this.biDayCollections.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biDayCollections.ImageOptions.Image")));
            this.biDayCollections.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biDayCollections.ImageOptions.LargeImage")));
            this.biDayCollections.ItemAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biDayCollections.ItemAppearance.Hovered.Options.UseFont = true;
            this.biDayCollections.ItemAppearance.Normal.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biDayCollections.ItemAppearance.Normal.Options.UseFont = true;
            this.biDayCollections.ItemAppearance.Pressed.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.biDayCollections.ItemAppearance.Pressed.Options.UseFont = true;
            this.biDayCollections.Name = "biDayCollections";
            this.biDayCollections.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.biDayCollections.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDayCollections_ItemClick);
            // 
            // btnBookAppointments
            // 
            this.btnBookAppointments.Caption = "Book Appointment";
            this.btnBookAppointments.Id = 22;
            this.btnBookAppointments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBookAppointments.ImageOptions.Image")));
            this.btnBookAppointments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBookAppointments.ImageOptions.LargeImage")));
            this.btnBookAppointments.Name = "btnBookAppointments";
            this.btnBookAppointments.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnBookAppointments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBookAppointments_ItemClick);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Caption = "Appointments";
            this.btnAppointments.Id = 23;
            this.btnAppointments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointments.ImageOptions.Image")));
            this.btnAppointments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAppointments.ImageOptions.LargeImage")));
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnAppointments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAppointments_ItemClick);
            // 
            // btnPrinterMaster
            // 
            this.btnPrinterMaster.Caption = "Printer Master";
            this.btnPrinterMaster.Id = 24;
            this.btnPrinterMaster.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinterMaster.ImageOptions.Image")));
            this.btnPrinterMaster.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrinterMaster.ImageOptions.LargeImage")));
            this.btnPrinterMaster.Name = "btnPrinterMaster";
            this.btnPrinterMaster.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnPrinterMaster.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrinterMaster_ItemClick);
            // 
            // btnDatabaseBackup
            // 
            this.btnDatabaseBackup.Caption = "Database Backup";
            this.btnDatabaseBackup.Id = 25;
            this.btnDatabaseBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDatabaseBackup.ImageOptions.SvgImage")));
            this.btnDatabaseBackup.Name = "btnDatabaseBackup";
            this.btnDatabaseBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnDatabaseBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatabaseBackup_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 8F);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.rpdAdmin,
            this.ribbonPageGroup6,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Clinic Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.biDoctors);
            this.ribbonPageGroup1.ItemLinks.Add(this.biCategories);
            this.ribbonPageGroup1.ItemLinks.Add(this.biUsers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPrinterMaster);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Masters";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.biPatients);
            this.ribbonPageGroup2.ItemLinks.Add(this.biTreatment);
            this.ribbonPageGroup2.ItemLinks.Add(this.biPatientHistory);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBookAppointments);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAppointments);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Patient";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.biMedicines);
            this.ribbonPageGroup3.ItemLinks.Add(this.biStockUpdate);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Medicine";
            // 
            // rpdAdmin
            // 
            this.rpdAdmin.ItemLinks.Add(this.biEmailConfig);
            this.rpdAdmin.ItemLinks.Add(this.biSMSConfig);
            this.rpdAdmin.ItemLinks.Add(this.biChangepwd);
            this.rpdAdmin.ItemLinks.Add(this.biOrganization);
            this.rpdAdmin.ItemLinks.Add(this.biBranch);
            this.rpdAdmin.ItemLinks.Add(this.btnDatabaseBackup);
            this.rpdAdmin.Name = "rpdAdmin";
            this.rpdAdmin.Text = "Admin";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.biDayCollections);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Reports";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.biCurrentDate);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Consultation Date";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 587);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Patient Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem biPatients;
        private DevExpress.XtraBars.BarButtonItem biCategories;
        private DevExpress.XtraBars.BarButtonItem biDoctors;
        private DevExpress.XtraBars.BarButtonItem biMedicines;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem biOrganization;
        private DevExpress.XtraBars.BarButtonItem biBranch;
        private DevExpress.XtraBars.BarButtonItem biUsers;
        private DevExpress.XtraBars.BarButtonItem biTreatment;
        private DevExpress.XtraBars.BarButtonItem biStockUpdate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem biPatientHistory;
        private DevExpress.XtraBars.BarButtonItem biEmailConfig;
        private DevExpress.XtraBars.BarButtonItem biSMSConfig;
        private DevExpress.XtraBars.BarButtonItem biChangepwd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpdAdmin;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem biCurrentDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem biDayCollections;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnBookAppointments;
        private DevExpress.XtraBars.BarButtonItem btnAppointments;
        private DevExpress.XtraBars.BarButtonItem btnPrinterMaster;
        private DevExpress.XtraBars.BarButtonItem btnDatabaseBackup;
    }
}

