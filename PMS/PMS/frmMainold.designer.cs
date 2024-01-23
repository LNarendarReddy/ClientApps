namespace PMS
{
    partial class frmMainold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainold));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionContentContainer1 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.accordionContentContainer2 = new DevExpress.XtraBars.Navigation.AccordionContentContainer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnModules = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnOrganizationMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBranchMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUserMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnEmailConfiguration = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSMSConfiguration = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnInvestigationMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnDoctorMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPatientMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnMedicineMaster = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnStockUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnTreatment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPatientHistory = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.lblUserfdafda = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionContentContainer1
            // 
            this.accordionContentContainer1.Controls.Add(this.pictureEdit1);
            this.accordionContentContainer1.Name = "accordionContentContainer1";
            this.accordionContentContainer1.Size = new System.Drawing.Size(182, 76);
            this.accordionContentContainer1.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.EditValue = global::PMS.Properties.Resources.Gyana;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(182, 76);
            this.pictureEdit1.TabIndex = 0;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // accordionContentContainer2
            // 
            this.accordionContentContainer2.Controls.Add(this.labelControl1);
            this.accordionContentContainer2.Name = "accordionContentContainer2";
            this.accordionContentContainer2.Size = new System.Drawing.Size(182, 76);
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
            this.btnEmailConfiguration,
            this.btnSMSConfiguration,
            this.accordionControlElement6,
            this.btnInvestigationMaster,
            this.btnDoctorMaster,
            this.btnPatientMaster,
            this.btnMedicineMaster,
            this.btnStockUpdate,
            this.btnTreatment,
            this.btnPatientHistory});
            this.btnModules.Expanded = true;
            this.btnModules.Name = "btnModules";
            this.btnModules.Text = "Modules";
            // 
            // btnOrganizationMaster
            // 
            this.btnOrganizationMaster.Name = "btnOrganizationMaster";
            this.btnOrganizationMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnOrganizationMaster.Text = "Orgnanization Master";
            this.btnOrganizationMaster.Visible = false;
            this.btnOrganizationMaster.Click += new System.EventHandler(this.btnOrganizationMaster_Click);
            // 
            // btnBranchMaster
            // 
            this.btnBranchMaster.Name = "btnBranchMaster";
            this.btnBranchMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnBranchMaster.Text = "Branch Master";
            this.btnBranchMaster.Visible = false;
            this.btnBranchMaster.Click += new System.EventHandler(this.btnBranchMaster_Click);
            // 
            // btnUserMaster
            // 
            this.btnUserMaster.Name = "btnUserMaster";
            this.btnUserMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUserMaster.Text = "User Master";
            this.btnUserMaster.Visible = false;
            this.btnUserMaster.Click += new System.EventHandler(this.btnUserMaster_Click);
            // 
            // btnEmailConfiguration
            // 
            this.btnEmailConfiguration.Name = "btnEmailConfiguration";
            this.btnEmailConfiguration.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnEmailConfiguration.Text = "Email Configuration";
            this.btnEmailConfiguration.Visible = false;
            this.btnEmailConfiguration.Click += new System.EventHandler(this.btnEmailConfiguration_Click);
            // 
            // btnSMSConfiguration
            // 
            this.btnSMSConfiguration.Name = "btnSMSConfiguration";
            this.btnSMSConfiguration.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSMSConfiguration.Text = "SMS Configuration";
            this.btnSMSConfiguration.Visible = false;
            this.btnSMSConfiguration.Click += new System.EventHandler(this.btnSMSConfiguration_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Change Password";
            this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // btnInvestigationMaster
            // 
            this.btnInvestigationMaster.Name = "btnInvestigationMaster";
            this.btnInvestigationMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnInvestigationMaster.Text = "Investigation Master";
            this.btnInvestigationMaster.Click += new System.EventHandler(this.btnInvestigationMaster_Click);
            // 
            // btnDoctorMaster
            // 
            this.btnDoctorMaster.Name = "btnDoctorMaster";
            this.btnDoctorMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnDoctorMaster.Text = "Doctor Master";
            this.btnDoctorMaster.Click += new System.EventHandler(this.btnDoctorMaster_Click);
            // 
            // btnPatientMaster
            // 
            this.btnPatientMaster.Name = "btnPatientMaster";
            this.btnPatientMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPatientMaster.Text = "Patient Master";
            this.btnPatientMaster.Click += new System.EventHandler(this.btnPatientMaster_Click);
            // 
            // btnMedicineMaster
            // 
            this.btnMedicineMaster.Name = "btnMedicineMaster";
            this.btnMedicineMaster.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnMedicineMaster.Text = "Medicine Master";
            this.btnMedicineMaster.Click += new System.EventHandler(this.btnMedicineMaster_Click);
            // 
            // btnStockUpdate
            // 
            this.btnStockUpdate.Name = "btnStockUpdate";
            this.btnStockUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnStockUpdate.Text = "Stock Update";
            this.btnStockUpdate.Click += new System.EventHandler(this.btnStockUpdate_Click);
            // 
            // btnTreatment
            // 
            this.btnTreatment.Name = "btnTreatment";
            this.btnTreatment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnTreatment.Text = "Treatment";
            this.btnTreatment.Click += new System.EventHandler(this.btnTreatment_Click);
            // 
            // btnPatientHistory
            // 
            this.btnPatientHistory.Name = "btnPatientHistory";
            this.btnPatientHistory.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPatientHistory.Text = "Patient History";
            this.btnPatientHistory.Click += new System.EventHandler(this.btnPatientHistory_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Reports";
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
            this.lblUser});
            this.lblUserfdafda.Location = new System.Drawing.Point(199, 721);
            this.lblUserfdafda.Name = "lblUserfdafda";
            this.lblUserfdafda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserfdafda.Size = new System.Drawing.Size(996, 22);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 743);
            this.Controls.Add(this.lblUserfdafda);
            this.Controls.Add(this.accordionControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "BetaParentSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Management System";
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnEmailConfiguration;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSMSConfiguration;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBranchMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraBars.Navigation.AccordionContentContainer accordionContentContainer2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private System.Windows.Forms.StatusStrip lblUserfdafda;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnInvestigationMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnDoctorMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPatientMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnMedicineMaster;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnStockUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnTreatment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPatientHistory;
    }
}