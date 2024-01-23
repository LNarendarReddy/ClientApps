namespace EHR.Assessment
{
    partial class frmMAssessmentDashBoard
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
            this.cmbAssessmentMode = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbAssessmentYear = new DevExpress.XtraEditors.LookUpEdit();
            this.gcAllTeamMembers = new DevExpress.XtraGrid.GridControl();
            this.gvAllTeamMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcYourTeamMembers = new DevExpress.XtraGrid.GridControl();
            this.gvYourTeamMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAssessmentMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAssessmentYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAllTeamMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllTeamMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcYourTeamMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvYourTeamMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.cmbAssessmentMode);
            this.layoutControl1.Controls.Add(this.cmbAssessmentYear);
            this.layoutControl1.Controls.Add(this.gcAllTeamMembers);
            this.layoutControl1.Controls.Add(this.gcYourTeamMembers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(551, 719);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbAssessmentMode
            // 
            this.cmbAssessmentMode.Location = new System.Drawing.Point(277, 33);
            this.cmbAssessmentMode.Name = "cmbAssessmentMode";
            this.cmbAssessmentMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAssessmentMode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssessmentModeID", "Assessment Type", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssessmentModeName", "AssessmentModeName")});
            this.cmbAssessmentMode.Properties.NullText = "";
            this.cmbAssessmentMode.Size = new System.Drawing.Size(262, 24);
            this.cmbAssessmentMode.StyleController = this.layoutControl1;
            this.cmbAssessmentMode.TabIndex = 10;
            this.cmbAssessmentMode.EditValueChanged += new System.EventHandler(this.cmbAssessmentYear_EditValueChanged);
            // 
            // cmbAssessmentYear
            // 
            this.cmbAssessmentYear.Location = new System.Drawing.Point(12, 33);
            this.cmbAssessmentYear.Name = "cmbAssessmentYear";
            this.cmbAssessmentYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAssessmentYear.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssessmentYearID", "AssessmentYearID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AssessmentYearName", "Assessment Year")});
            this.cmbAssessmentYear.Properties.NullText = "";
            this.cmbAssessmentYear.Size = new System.Drawing.Size(261, 24);
            this.cmbAssessmentYear.StyleController = this.layoutControl1;
            this.cmbAssessmentYear.TabIndex = 9;
            this.cmbAssessmentYear.EditValueChanged += new System.EventHandler(this.cmbAssessmentYear_EditValueChanged);
            // 
            // gcAllTeamMembers
            // 
            this.gcAllTeamMembers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcAllTeamMembers.Location = new System.Drawing.Point(12, 371);
            this.gcAllTeamMembers.MainView = this.gvAllTeamMembers;
            this.gcAllTeamMembers.Margin = new System.Windows.Forms.Padding(2);
            this.gcAllTeamMembers.Name = "gcAllTeamMembers";
            this.gcAllTeamMembers.Size = new System.Drawing.Size(527, 336);
            this.gcAllTeamMembers.TabIndex = 5;
            this.gcAllTeamMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAllTeamMembers});
            // 
            // gvAllTeamMembers
            // 
            this.gvAllTeamMembers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvAllTeamMembers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAllTeamMembers.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.gvAllTeamMembers.Appearance.Row.Options.UseFont = true;
            this.gvAllTeamMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gvAllTeamMembers.DetailHeight = 239;
            this.gvAllTeamMembers.GridControl = this.gcAllTeamMembers;
            this.gvAllTeamMembers.Name = "gvAllTeamMembers";
            this.gvAllTeamMembers.OptionsBehavior.Editable = false;
            this.gvAllTeamMembers.OptionsView.ShowGroupPanel = false;
            this.gvAllTeamMembers.DoubleClick += new System.EventHandler(this.gvAllTeamMembers_DoubleClick);
            // 
            // gcYourTeamMembers
            // 
            this.gcYourTeamMembers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcYourTeamMembers.Location = new System.Drawing.Point(12, 82);
            this.gcYourTeamMembers.MainView = this.gvYourTeamMembers;
            this.gcYourTeamMembers.Margin = new System.Windows.Forms.Padding(2);
            this.gcYourTeamMembers.Name = "gcYourTeamMembers";
            this.gcYourTeamMembers.Size = new System.Drawing.Size(527, 264);
            this.gcYourTeamMembers.TabIndex = 4;
            this.gcYourTeamMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvYourTeamMembers});
            // 
            // gvYourTeamMembers
            // 
            this.gvYourTeamMembers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvYourTeamMembers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvYourTeamMembers.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.gvYourTeamMembers.Appearance.Row.Options.UseFont = true;
            this.gvYourTeamMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gvYourTeamMembers.DetailHeight = 239;
            this.gvYourTeamMembers.GridControl = this.gcYourTeamMembers;
            this.gvYourTeamMembers.Name = "gvYourTeamMembers";
            this.gvYourTeamMembers.OptionsBehavior.Editable = false;
            this.gvYourTeamMembers.OptionsView.ShowGroupPanel = false;
            this.gvYourTeamMembers.DoubleClick += new System.EventHandler(this.gvYourTeamMembers_DoubleClick);
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(551, 719);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcYourTeamMembers;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(531, 289);
            this.layoutControlItem1.Text = "Your Team Memebers";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(120, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcAllTeamMembers;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 338);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(531, 361);
            this.layoutControlItem2.Text = "All Team Members";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(120, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbAssessmentYear;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(265, 49);
            this.layoutControlItem3.Text = "Assessment Year";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(120, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbAssessmentMode;
            this.layoutControlItem4.Location = new System.Drawing.Point(265, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(266, 49);
            this.layoutControlItem4.Text = "Assessment Mode";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(120, 18);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "UserInfoID";
            this.gridColumn1.FieldName = "UserInfoID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FullName";
            this.gridColumn2.FieldName = "FullName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "UserInfoID";
            this.gridColumn3.FieldName = "UserInfoID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "FullName";
            this.gridColumn4.FieldName = "FullName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // frmMAssessmentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 719);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMAssessmentDashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.frmMAssessmentDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbAssessmentMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAssessmentYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAllTeamMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAllTeamMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcYourTeamMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvYourTeamMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcAllTeamMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAllTeamMembers;
        private DevExpress.XtraGrid.GridControl gcYourTeamMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvYourTeamMembers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit cmbAssessmentYear;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit cmbAssessmentMode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}