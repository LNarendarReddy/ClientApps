namespace EHR.Timesheet.Reports
{
    partial class frmEmployeeTimings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeTimings));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.gcEmployeeTimings = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeTimings = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLogDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDayLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gcDayLogout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLunchLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLunchLogout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDayMins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLunchMins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBreakMins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnViewReport = new DevExpress.XtraEditors.SimpleButton();
            this.dtpToDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpFromDate = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeTimings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeTimings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnGenerate);
            this.layoutControl1.Controls.Add(this.gcEmployeeTimings);
            this.layoutControl1.Controls.Add(this.btnViewReport);
            this.layoutControl1.Controls.Add(this.dtpToDate);
            this.layoutControl1.Controls.Add(this.dtpFromDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1456, 451, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1384, 814);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGenerate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGenerate.ImageOptions.SvgImage")));
            this.btnGenerate.Location = new System.Drawing.Point(560, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(305, 58);
            this.btnGenerate.StyleController = this.layoutControl1;
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gcEmployeeTimings
            // 
            this.gcEmployeeTimings.Location = new System.Drawing.Point(12, 74);
            this.gcEmployeeTimings.MainView = this.gvEmployeeTimings;
            this.gcEmployeeTimings.Name = "gcEmployeeTimings";
            this.gcEmployeeTimings.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1});
            this.gcEmployeeTimings.Size = new System.Drawing.Size(1360, 728);
            this.gcEmployeeTimings.TabIndex = 7;
            this.gcEmployeeTimings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeTimings});
            // 
            // gvEmployeeTimings
            // 
            this.gvEmployeeTimings.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvEmployeeTimings.Appearance.Row.Options.UseFont = true;
            this.gvEmployeeTimings.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcEmployeeID,
            this.gcLogDate,
            this.gcDayLogin,
            this.gcDayLogout,
            this.gcLunchLogin,
            this.gcLunchLogout,
            this.gcDayMins,
            this.gcLunchMins,
            this.gcBreakMins,
            this.gcUserName,
            this.gcFullName});
            this.gvEmployeeTimings.GridControl = this.gcEmployeeTimings;
            this.gvEmployeeTimings.Name = "gvEmployeeTimings";
            this.gvEmployeeTimings.OptionsBehavior.Editable = false;
            // 
            // gcEmployeeID
            // 
            this.gcEmployeeID.Caption = "EmployeeID";
            this.gcEmployeeID.FieldName = "EmployeeID";
            this.gcEmployeeID.MinWidth = 30;
            this.gcEmployeeID.Name = "gcEmployeeID";
            this.gcEmployeeID.Width = 112;
            // 
            // gcLogDate
            // 
            this.gcLogDate.Caption = "LogDate";
            this.gcLogDate.FieldName = "LogDate";
            this.gcLogDate.MinWidth = 30;
            this.gcLogDate.Name = "gcLogDate";
            this.gcLogDate.Visible = true;
            this.gcLogDate.VisibleIndex = 2;
            this.gcLogDate.Width = 112;
            // 
            // gcDayLogin
            // 
            this.gcDayLogin.Caption = "Log in";
            this.gcDayLogin.ColumnEdit = this.repositoryItemTimeEdit1;
            this.gcDayLogin.FieldName = "DayLogin";
            this.gcDayLogin.MinWidth = 30;
            this.gcDayLogin.Name = "gcDayLogin";
            this.gcDayLogin.Visible = true;
            this.gcDayLogin.VisibleIndex = 3;
            this.gcDayLogin.Width = 112;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // gcDayLogout
            // 
            this.gcDayLogout.Caption = "Log Out";
            this.gcDayLogout.ColumnEdit = this.repositoryItemTimeEdit1;
            this.gcDayLogout.FieldName = "DayLogout";
            this.gcDayLogout.MinWidth = 30;
            this.gcDayLogout.Name = "gcDayLogout";
            this.gcDayLogout.Visible = true;
            this.gcDayLogout.VisibleIndex = 4;
            this.gcDayLogout.Width = 112;
            // 
            // gcLunchLogin
            // 
            this.gcLunchLogin.Caption = "Going for Lunch";
            this.gcLunchLogin.ColumnEdit = this.repositoryItemTimeEdit1;
            this.gcLunchLogin.FieldName = "LunchLogin";
            this.gcLunchLogin.MinWidth = 30;
            this.gcLunchLogin.Name = "gcLunchLogin";
            this.gcLunchLogin.Visible = true;
            this.gcLunchLogin.VisibleIndex = 5;
            this.gcLunchLogin.Width = 112;
            // 
            // gcLunchLogout
            // 
            this.gcLunchLogout.Caption = "Back from Lunch";
            this.gcLunchLogout.ColumnEdit = this.repositoryItemTimeEdit1;
            this.gcLunchLogout.FieldName = "LunchLogout";
            this.gcLunchLogout.MinWidth = 30;
            this.gcLunchLogout.Name = "gcLunchLogout";
            this.gcLunchLogout.Visible = true;
            this.gcLunchLogout.VisibleIndex = 6;
            this.gcLunchLogout.Width = 112;
            // 
            // gcDayMins
            // 
            this.gcDayMins.Caption = "Total Spent Time";
            this.gcDayMins.FieldName = "DayMins";
            this.gcDayMins.MinWidth = 30;
            this.gcDayMins.Name = "gcDayMins";
            this.gcDayMins.Visible = true;
            this.gcDayMins.VisibleIndex = 7;
            this.gcDayMins.Width = 112;
            // 
            // gcLunchMins
            // 
            this.gcLunchMins.Caption = "Lunch Time";
            this.gcLunchMins.FieldName = "LunchMins";
            this.gcLunchMins.MinWidth = 30;
            this.gcLunchMins.Name = "gcLunchMins";
            this.gcLunchMins.Visible = true;
            this.gcLunchMins.VisibleIndex = 8;
            this.gcLunchMins.Width = 112;
            // 
            // gcBreakMins
            // 
            this.gcBreakMins.Caption = "Break Time";
            this.gcBreakMins.FieldName = "BreakMins";
            this.gcBreakMins.MinWidth = 30;
            this.gcBreakMins.Name = "gcBreakMins";
            this.gcBreakMins.Visible = true;
            this.gcBreakMins.VisibleIndex = 9;
            this.gcBreakMins.Width = 112;
            // 
            // gcUserName
            // 
            this.gcUserName.Caption = "User Name";
            this.gcUserName.FieldName = "UserName";
            this.gcUserName.MinWidth = 30;
            this.gcUserName.Name = "gcUserName";
            this.gcUserName.Visible = true;
            this.gcUserName.VisibleIndex = 0;
            this.gcUserName.Width = 112;
            // 
            // gcFullName
            // 
            this.gcFullName.Caption = "Employee name";
            this.gcFullName.FieldName = "FullName";
            this.gcFullName.MinWidth = 30;
            this.gcFullName.Name = "gcFullName";
            this.gcFullName.Visible = true;
            this.gcFullName.VisibleIndex = 1;
            this.gcFullName.Width = 112;
            // 
            // btnViewReport
            // 
            this.btnViewReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnViewReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewReport.ImageOptions.SvgImage")));
            this.btnViewReport.Location = new System.Drawing.Point(1070, 12);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(302, 58);
            this.btnViewReport.StyleController = this.layoutControl1;
            this.btnViewReport.TabIndex = 6;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.EditValue = null;
            this.dtpToDate.Location = new System.Drawing.Point(281, 39);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpToDate.Size = new System.Drawing.Size(265, 30);
            this.dtpToDate.StyleController = this.layoutControl1;
            this.dtpToDate.TabIndex = 5;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.EditValue = null;
            this.dtpFromDate.Location = new System.Drawing.Point(12, 39);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFromDate.Size = new System.Drawing.Size(265, 30);
            this.dtpFromDate.StyleController = this.layoutControl1;
            this.dtpFromDate.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1384, 814);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtpFromDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(269, 61);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(269, 61);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(269, 62);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "From Date";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 24);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpToDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(269, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(269, 61);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(269, 61);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(269, 62);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "To Date";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 24);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnViewReport;
            this.layoutControlItem3.Location = new System.Drawing.Point(1058, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(306, 62);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(306, 62);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(306, 62);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(857, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(201, 62);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcEmployeeTimings;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1364, 732);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnGenerate;
            this.layoutControlItem5.Location = new System.Drawing.Point(548, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(309, 62);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(309, 62);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(309, 62);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(538, 0);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 62);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmEmployeeTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 814);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmEmployeeTimings";
            this.Text = "Employee Timings";
            this.Load += new System.EventHandler(this.frmEmployeeTimings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeTimings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeTimings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnViewReport;
        private DevExpress.XtraEditors.DateEdit dtpToDate;
        private DevExpress.XtraEditors.DateEdit dtpFromDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.GridControl gcEmployeeTimings;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeTimings;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn gcLogDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcDayLogin;
        private DevExpress.XtraGrid.Columns.GridColumn gcDayLogout;
        private DevExpress.XtraGrid.Columns.GridColumn gcLunchLogin;
        private DevExpress.XtraGrid.Columns.GridColumn gcLunchLogout;
        private DevExpress.XtraGrid.Columns.GridColumn gcDayMins;
        private DevExpress.XtraGrid.Columns.GridColumn gcLunchMins;
        private DevExpress.XtraGrid.Columns.GridColumn gcBreakMins;
        private DevExpress.XtraGrid.Columns.GridColumn gcUserName;
        private DevExpress.XtraGrid.Columns.GridColumn gcFullName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}