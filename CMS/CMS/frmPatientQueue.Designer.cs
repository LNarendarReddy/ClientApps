namespace CMS
{
    partial class frmPatientQueue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientQueue));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnReresh = new DevExpress.XtraEditors.SimpleButton();
            this.lblOldPatients = new DevExpress.XtraEditors.LabelControl();
            this.lblNewPatients = new DevExpress.XtraEditors.LabelControl();
            this.gcNonTreatedNewPatients = new DevExpress.XtraGrid.GridControl();
            this.gvNonTreatedNewPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTreatedNewPatients = new DevExpress.XtraGrid.GridControl();
            this.gvTreatedNewPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNonTreatedOldPatients = new DevExpress.XtraGrid.GridControl();
            this.gvNonTreatedOldPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTreatedOldPatients = new DevExpress.XtraGrid.GridControl();
            this.gvTreatedOldPatients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNonTreatedNewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNonTreatedNewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTreatedNewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTreatedNewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNonTreatedOldPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNonTreatedOldPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTreatedOldPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTreatedOldPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnReresh);
            this.layoutControl1.Controls.Add(this.lblOldPatients);
            this.layoutControl1.Controls.Add(this.lblNewPatients);
            this.layoutControl1.Controls.Add(this.gcNonTreatedNewPatients);
            this.layoutControl1.Controls.Add(this.gcTreatedNewPatients);
            this.layoutControl1.Controls.Add(this.gcNonTreatedOldPatients);
            this.layoutControl1.Controls.Add(this.gcTreatedOldPatients);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 412, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1121, 739);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(950, 687);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 38);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReresh
            // 
            this.btnReresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReresh.ImageOptions.SvgImage")));
            this.btnReresh.Location = new System.Drawing.Point(779, 687);
            this.btnReresh.Name = "btnReresh";
            this.btnReresh.Size = new System.Drawing.Size(167, 38);
            this.btnReresh.StyleController = this.layoutControl1;
            this.btnReresh.TabIndex = 7;
            this.btnReresh.Text = "Refresh";
            this.btnReresh.Click += new System.EventHandler(this.btnReresh_Click);
            // 
            // lblOldPatients
            // 
            this.lblOldPatients.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblOldPatients.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblOldPatients.Appearance.Options.UseFont = true;
            this.lblOldPatients.Appearance.Options.UseForeColor = true;
            this.lblOldPatients.Location = new System.Drawing.Point(4, 687);
            this.lblOldPatients.Name = "lblOldPatients";
            this.lblOldPatients.Size = new System.Drawing.Size(100, 22);
            this.lblOldPatients.StyleController = this.layoutControl1;
            this.lblOldPatients.TabIndex = 6;
            this.lblOldPatients.Text = "labelControl2";
            // 
            // lblNewPatients
            // 
            this.lblNewPatients.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblNewPatients.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblNewPatients.Appearance.Options.UseFont = true;
            this.lblNewPatients.Appearance.Options.UseForeColor = true;
            this.lblNewPatients.Location = new System.Drawing.Point(4, 713);
            this.lblNewPatients.Name = "lblNewPatients";
            this.lblNewPatients.Size = new System.Drawing.Size(100, 22);
            this.lblNewPatients.StyleController = this.layoutControl1;
            this.lblNewPatients.TabIndex = 5;
            this.lblNewPatients.Text = "labelControl1";
            // 
            // gcNonTreatedNewPatients
            // 
            this.gcNonTreatedNewPatients.Location = new System.Drawing.Point(4, 370);
            this.gcNonTreatedNewPatients.MainView = this.gvNonTreatedNewPatients;
            this.gcNonTreatedNewPatients.Name = "gcNonTreatedNewPatients";
            this.gcNonTreatedNewPatients.Size = new System.Drawing.Size(541, 302);
            this.gcNonTreatedNewPatients.TabIndex = 4;
            this.gcNonTreatedNewPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNonTreatedNewPatients});
            // 
            // gvNonTreatedNewPatients
            // 
            this.gvNonTreatedNewPatients.Appearance.FooterPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvNonTreatedNewPatients.Appearance.FooterPanel.Options.UseFont = true;
            this.gvNonTreatedNewPatients.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvNonTreatedNewPatients.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNonTreatedNewPatients.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.gvNonTreatedNewPatients.Appearance.Row.Options.UseFont = true;
            this.gvNonTreatedNewPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvNonTreatedNewPatients.GridControl = this.gcNonTreatedNewPatients;
            this.gvNonTreatedNewPatients.Name = "gvNonTreatedNewPatients";
            this.gvNonTreatedNewPatients.OptionsBehavior.Editable = false;
            this.gvNonTreatedNewPatients.OptionsView.ShowFooter = true;
            this.gvNonTreatedNewPatients.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Token ID";
            this.gridColumn7.FieldName = "TockenID";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TockenID", "{0}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 100;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Name";
            this.gridColumn8.FieldName = "PName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 286;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Reg No";
            this.gridColumn9.FieldName = "RegNo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 120;
            // 
            // gcTreatedNewPatients
            // 
            this.gcTreatedNewPatients.Location = new System.Drawing.Point(549, 370);
            this.gcTreatedNewPatients.MainView = this.gvTreatedNewPatients;
            this.gcTreatedNewPatients.Name = "gcTreatedNewPatients";
            this.gcTreatedNewPatients.Size = new System.Drawing.Size(568, 302);
            this.gcTreatedNewPatients.TabIndex = 3;
            this.gcTreatedNewPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTreatedNewPatients});
            // 
            // gvTreatedNewPatients
            // 
            this.gvTreatedNewPatients.Appearance.FooterPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvTreatedNewPatients.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTreatedNewPatients.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvTreatedNewPatients.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTreatedNewPatients.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.gvTreatedNewPatients.Appearance.Row.Options.UseFont = true;
            this.gvTreatedNewPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gvTreatedNewPatients.GridControl = this.gcTreatedNewPatients;
            this.gvTreatedNewPatients.Name = "gvTreatedNewPatients";
            this.gvTreatedNewPatients.OptionsBehavior.Editable = false;
            this.gvTreatedNewPatients.OptionsView.ShowFooter = true;
            this.gvTreatedNewPatients.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Token ID";
            this.gridColumn10.FieldName = "TockenID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TockenID", "{0}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 100;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Reg No";
            this.gridColumn11.FieldName = "RegNo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 120;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Name";
            this.gridColumn12.FieldName = "PName";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 263;
            // 
            // gcNonTreatedOldPatients
            // 
            this.gcNonTreatedOldPatients.Location = new System.Drawing.Point(4, 25);
            this.gcNonTreatedOldPatients.MainView = this.gvNonTreatedOldPatients;
            this.gcNonTreatedOldPatients.Name = "gcNonTreatedOldPatients";
            this.gcNonTreatedOldPatients.Size = new System.Drawing.Size(541, 320);
            this.gcNonTreatedOldPatients.TabIndex = 2;
            this.gcNonTreatedOldPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNonTreatedOldPatients});
            // 
            // gvNonTreatedOldPatients
            // 
            this.gvNonTreatedOldPatients.Appearance.FooterPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvNonTreatedOldPatients.Appearance.FooterPanel.Options.UseFont = true;
            this.gvNonTreatedOldPatients.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvNonTreatedOldPatients.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvNonTreatedOldPatients.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.gvNonTreatedOldPatients.Appearance.Row.Options.UseFont = true;
            this.gvNonTreatedOldPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvNonTreatedOldPatients.GridControl = this.gcNonTreatedOldPatients;
            this.gvNonTreatedOldPatients.Name = "gvNonTreatedOldPatients";
            this.gvNonTreatedOldPatients.OptionsBehavior.Editable = false;
            this.gvNonTreatedOldPatients.OptionsView.ShowFooter = true;
            this.gvNonTreatedOldPatients.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Token ID";
            this.gridColumn1.FieldName = "TockenID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TockenID", "{0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Reg No";
            this.gridColumn2.FieldName = "RegNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Name";
            this.gridColumn3.FieldName = "PName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 286;
            // 
            // gcTreatedOldPatients
            // 
            this.gcTreatedOldPatients.Location = new System.Drawing.Point(549, 25);
            this.gcTreatedOldPatients.MainView = this.gvTreatedOldPatients;
            this.gcTreatedOldPatients.Name = "gcTreatedOldPatients";
            this.gcTreatedOldPatients.Size = new System.Drawing.Size(568, 320);
            this.gcTreatedOldPatients.TabIndex = 0;
            this.gcTreatedOldPatients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTreatedOldPatients});
            // 
            // gvTreatedOldPatients
            // 
            this.gvTreatedOldPatients.Appearance.FooterPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvTreatedOldPatients.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTreatedOldPatients.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvTreatedOldPatients.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTreatedOldPatients.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.gvTreatedOldPatients.Appearance.Row.Options.UseFont = true;
            this.gvTreatedOldPatients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvTreatedOldPatients.GridControl = this.gcTreatedOldPatients;
            this.gvTreatedOldPatients.Name = "gvTreatedOldPatients";
            this.gvTreatedOldPatients.OptionsBehavior.Editable = false;
            this.gvTreatedOldPatients.OptionsView.ShowFooter = true;
            this.gvTreatedOldPatients.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Token ID";
            this.gridColumn4.FieldName = "TockenID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TockenID", "{0}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 100;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Reg No";
            this.gridColumn5.FieldName = "RegNo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 120;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Name";
            this.gridColumn6.FieldName = "PName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 263;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(1121, 739);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcTreatedOldPatients;
            this.layoutControlItem1.Location = new System.Drawing.Point(545, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(572, 345);
            this.layoutControlItem1.Text = "Treated Old Patients";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(147, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gcTreatedNewPatients;
            this.layoutControlItem3.Location = new System.Drawing.Point(545, 345);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(572, 327);
            this.layoutControlItem3.Text = "Treated New Patients";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(147, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lblNewPatients;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 709);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lblOldPatients;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 683);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(104, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnReresh;
            this.layoutControlItem7.Location = new System.Drawing.Point(775, 683);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(171, 52);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(104, 683);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(671, 52);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnCancel;
            this.layoutControlItem8.Location = new System.Drawing.Point(946, 683);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(171, 52);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcNonTreatedOldPatients;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(545, 345);
            this.layoutControlItem2.Text = "Non Treated Old Patients";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(147, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcNonTreatedNewPatients;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 345);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(545, 327);
            this.layoutControlItem4.Text = "Non Treated New Patients";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(147, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 672);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1117, 11);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmPatientQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 739);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.Name = "frmPatientQueue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Patients Queue";
            this.Load += new System.EventHandler(this.frmPatientQueue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNonTreatedNewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNonTreatedNewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTreatedNewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTreatedNewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNonTreatedOldPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNonTreatedOldPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTreatedOldPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTreatedOldPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcNonTreatedNewPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNonTreatedNewPatients;
        private DevExpress.XtraGrid.GridControl gcTreatedNewPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTreatedNewPatients;
        private DevExpress.XtraGrid.GridControl gcNonTreatedOldPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNonTreatedOldPatients;
        private DevExpress.XtraGrid.GridControl gcTreatedOldPatients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTreatedOldPatients;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl lblOldPatients;
        private DevExpress.XtraEditors.LabelControl lblNewPatients;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReresh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
    }
}