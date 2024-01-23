namespace EHR.LeaveModule
{
    partial class frmApproveLeave
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
            this.gcLeaveHistory = new DevExpress.XtraGrid.GridControl();
            this.gvLeaveHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcLeaveHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeaveHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcLeaveHistory
            // 
            this.gcLeaveHistory.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcLeaveHistory.Location = new System.Drawing.Point(18, 18);
            this.gcLeaveHistory.MainView = this.gvLeaveHistory;
            this.gcLeaveHistory.Name = "gcLeaveHistory";
            this.gcLeaveHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gcLeaveHistory.Size = new System.Drawing.Size(1618, 920);
            this.gcLeaveHistory.TabIndex = 0;
            this.gcLeaveHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLeaveHistory});
            // 
            // gvLeaveHistory
            // 
            this.gvLeaveHistory.Appearance.FooterPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvLeaveHistory.Appearance.FooterPanel.Options.UseFont = true;
            this.gvLeaveHistory.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvLeaveHistory.Appearance.GroupFooter.Options.UseFont = true;
            this.gvLeaveHistory.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvLeaveHistory.Appearance.GroupPanel.Options.UseFont = true;
            this.gvLeaveHistory.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvLeaveHistory.Appearance.GroupRow.Options.UseFont = true;
            this.gvLeaveHistory.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvLeaveHistory.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLeaveHistory.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvLeaveHistory.Appearance.Row.Options.UseFont = true;
            this.gvLeaveHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20});
            this.gvLeaveHistory.DetailHeight = 349;
            this.gvLeaveHistory.FixedLineWidth = 1;
            this.gvLeaveHistory.GridControl = this.gcLeaveHistory;
            this.gvLeaveHistory.Name = "gvLeaveHistory";
            this.gvLeaveHistory.OptionsBehavior.Editable = false;
            this.gvLeaveHistory.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "EmployeeLeaveID";
            this.gridColumn1.FieldName = "EmployeeLeaveID";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "LeaveTypeID";
            this.gridColumn2.FieldName = "LeaveTypeID";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "From Date";
            this.gridColumn3.FieldName = "LeaveFromDate";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "To Date";
            this.gridColumn4.FieldName = "LeaveToDate";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Reason";
            this.gridColumn5.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn5.FieldName = "LeaveReason";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 112;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IsProjectDeliveryProject Delivery \\n\\r Exists";
            this.gridColumn6.FieldName = "ProjectDeliveryText";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 112;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Release Work \\n\\r Completed";
            this.gridColumn7.FieldName = "CompletedText";
            this.gridColumn7.MinWidth = 30;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 112;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Release plan if not completed";
            this.gridColumn8.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn8.FieldName = "ProjectPlan";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 112;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Emergeny Contact";
            this.gridColumn9.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn9.FieldName = "EmergencyContact";
            this.gridColumn9.MinWidth = 30;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Width = 112;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Days";
            this.gridColumn10.FieldName = "LeaveDays";
            this.gridColumn10.MinWidth = 30;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 112;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "LeaveStatusID";
            this.gridColumn11.FieldName = "LeaveStatusID";
            this.gridColumn11.MinWidth = 30;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Width = 112;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "FYearID";
            this.gridColumn12.FieldName = "FYearID";
            this.gridColumn12.MinWidth = 30;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Width = 112;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "LeaveCategoryID";
            this.gridColumn13.FieldName = "LeaveCategoryID";
            this.gridColumn13.MinWidth = 30;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Width = 112;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Leave Type";
            this.gridColumn14.FieldName = "LeaveTypeName";
            this.gridColumn14.MinWidth = 30;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 112;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Status";
            this.gridColumn15.FieldName = "LeaveStatusName";
            this.gridColumn15.MinWidth = 30;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 7;
            this.gridColumn15.Width = 112;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Category";
            this.gridColumn16.FieldName = "LeaveCategory";
            this.gridColumn16.MinWidth = 30;
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 5;
            this.gridColumn16.Width = 112;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Leave Duration";
            this.gridColumn17.FieldName = "LeaveDuration";
            this.gridColumn17.MinWidth = 30;
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 6;
            this.gridColumn17.Width = 112;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "LeaveDurationID";
            this.gridColumn18.FieldName = "LeaveDurationID";
            this.gridColumn18.MinWidth = 30;
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Width = 112;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Employee Name";
            this.gridColumn19.FieldName = "EmployeeName";
            this.gridColumn19.MinWidth = 30;
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 0;
            this.gridColumn19.Width = 112;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "EMail";
            this.gridColumn20.FieldName = "EMail";
            this.gridColumn20.MinWidth = 30;
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Width = 168;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDisabled.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDisabled.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDownHeader.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDropDownHeader.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlFocused.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlFocused.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlReadOnly.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlReadOnly.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.gcLeaveHistory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(995, 410, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1654, 956);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1654, 956);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcLeaveHistory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1624, 926);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmApproveLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 956);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmApproveLeave";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Approve Leaves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLeaveHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLeaveHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeaveHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcLeaveHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLeaveHistory;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
    }
}