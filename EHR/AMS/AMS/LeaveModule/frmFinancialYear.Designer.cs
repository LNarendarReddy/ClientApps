namespace EHR
{
    partial class frmFinancialYear
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcFYear = new DevExpress.XtraGrid.GridControl();
            this.gvFYear = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EnableAssessment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkEnableAssessment = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableAssessment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcFYear);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(608, 515);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcFYear
            // 
            this.gcFYear.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcFYear.Location = new System.Drawing.Point(12, 12);
            this.gcFYear.MainView = this.gvFYear;
            this.gcFYear.Margin = new System.Windows.Forms.Padding(2);
            this.gcFYear.Name = "gcFYear";
            this.gcFYear.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dtpDate,
            this.chkEnableAssessment});
            this.gcFYear.Size = new System.Drawing.Size(584, 491);
            this.gcFYear.TabIndex = 4;
            this.gcFYear.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFYear});
            // 
            // gvFYear
            // 
            this.gvFYear.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvFYear.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvFYear.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvFYear.Appearance.Row.Options.UseFont = true;
            this.gvFYear.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.EnableAssessment});
            this.gvFYear.DetailHeight = 239;
            this.gvFYear.FixedLineWidth = 1;
            this.gvFYear.GridControl = this.gcFYear;
            this.gvFYear.Name = "gvFYear";
            this.gvFYear.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFYear.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvFYear.OptionsView.ShowGroupPanel = false;
            this.gvFYear.OptionsView.ShowIndicator = false;
            this.gvFYear.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvFYear_InitNewRow);
            this.gvFYear.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvFYear_RowUpdated);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "FYearID";
            this.gridColumn1.FieldName = "FYearID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Financial Year";
            this.gridColumn2.FieldName = "FYearName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "From";
            this.gridColumn3.ColumnEdit = this.dtpDate;
            this.gridColumn3.FieldName = "FromDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 170;
            // 
            // dtpDate
            // 
            this.dtpDate.AutoHeight = false;
            this.dtpDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.DisplayFormat.FormatString = "y";
            this.dtpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.EditFormat.FormatString = "y";
            this.dtpDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.Mask.EditMask = "y";
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dtpDate.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "To";
            this.gridColumn4.ColumnEdit = this.dtpDate;
            this.gridColumn4.FieldName = "ToDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 151;
            // 
            // EnableAssessment
            // 
            this.EnableAssessment.AppearanceHeader.Options.UseTextOptions = true;
            this.EnableAssessment.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.EnableAssessment.Caption = "Enable Assessment";
            this.EnableAssessment.ColumnEdit = this.chkEnableAssessment;
            this.EnableAssessment.FieldName = "EnableAssessment";
            this.EnableAssessment.Name = "EnableAssessment";
            this.EnableAssessment.Visible = true;
            this.EnableAssessment.VisibleIndex = 3;
            this.EnableAssessment.Width = 80;
            // 
            // chkEnableAssessment
            // 
            this.chkEnableAssessment.AutoHeight = false;
            this.chkEnableAssessment.Name = "chkEnableAssessment";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(608, 515);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcFYear;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(588, 495);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmFinancialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 515);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFinancialYear";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Year";
            this.Load += new System.EventHandler(this.frmFinancialYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEnableAssessment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcFYear;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtpDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn EnableAssessment;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEnableAssessment;
    }
}