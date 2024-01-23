namespace EHR.LeaveModule.Reports
{
    partial class frmYearlyReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearlyReport));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcLeaveBalance = new DevExpress.XtraGrid.GridControl();
            this.gvLeaveBalance = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLeaveTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLeaveTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTotalLeaves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProrataLeaves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLeavesAvailed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gccLeaveBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFYear = new DevExpress.XtraEditors.LookUpEdit();
            this.btnViewReport = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLeaveBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeaveBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
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
            this.layoutControl1.Controls.Add(this.gcLeaveBalance);
            this.layoutControl1.Controls.Add(this.cmbFYear);
            this.layoutControl1.Controls.Add(this.btnViewReport);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1009, 332, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(957, 584);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcLeaveBalance
            // 
            this.gcLeaveBalance.Location = new System.Drawing.Point(12, 54);
            this.gcLeaveBalance.MainView = this.gvLeaveBalance;
            this.gcLeaveBalance.Name = "gcLeaveBalance";
            this.gcLeaveBalance.Size = new System.Drawing.Size(933, 518);
            this.gcLeaveBalance.TabIndex = 0;
            this.gcLeaveBalance.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLeaveBalance});
            // 
            // gvLeaveBalance
            // 
            this.gvLeaveBalance.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvLeaveBalance.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLeaveBalance.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvLeaveBalance.Appearance.Row.Options.UseFont = true;
            this.gvLeaveBalance.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcUserName,
            this.gcFullName,
            this.gcEmployeeID,
            this.gcLeaveTypeID,
            this.gcLeaveTypeName,
            this.gcTotalLeaves,
            this.gcProrataLeaves,
            this.gcLeavesAvailed,
            this.gccLeaveBalance,
            this.gridColumn1,
            this.gridColumn2});
            this.gvLeaveBalance.GridControl = this.gcLeaveBalance;
            this.gvLeaveBalance.Name = "gvLeaveBalance";
            this.gvLeaveBalance.OptionsBehavior.Editable = false;
            this.gvLeaveBalance.OptionsView.ShowViewCaption = true;
            // 
            // gcUserName
            // 
            this.gcUserName.Caption = "UserName";
            this.gcUserName.FieldName = "UserName";
            this.gcUserName.Name = "gcUserName";
            // 
            // gcFullName
            // 
            this.gcFullName.Caption = "FullName";
            this.gcFullName.FieldName = "FullName";
            this.gcFullName.Name = "gcFullName";
            this.gcFullName.Visible = true;
            this.gcFullName.VisibleIndex = 0;
            // 
            // gcEmployeeID
            // 
            this.gcEmployeeID.Caption = "EmployeeID";
            this.gcEmployeeID.FieldName = "EmployeeID";
            this.gcEmployeeID.Name = "gcEmployeeID";
            // 
            // gcLeaveTypeID
            // 
            this.gcLeaveTypeID.Caption = "LeaveTypeID";
            this.gcLeaveTypeID.FieldName = "LeaveTypeID";
            this.gcLeaveTypeID.Name = "gcLeaveTypeID";
            // 
            // gcLeaveTypeName
            // 
            this.gcLeaveTypeName.Caption = "LeaveTypeName";
            this.gcLeaveTypeName.FieldName = "LeaveTypeName";
            this.gcLeaveTypeName.Name = "gcLeaveTypeName";
            this.gcLeaveTypeName.Visible = true;
            this.gcLeaveTypeName.VisibleIndex = 1;
            // 
            // gcTotalLeaves
            // 
            this.gcTotalLeaves.Caption = "TotalLeaves";
            this.gcTotalLeaves.FieldName = "TotalLeaves";
            this.gcTotalLeaves.Name = "gcTotalLeaves";
            this.gcTotalLeaves.Visible = true;
            this.gcTotalLeaves.VisibleIndex = 2;
            // 
            // gcProrataLeaves
            // 
            this.gcProrataLeaves.Caption = "ProrataLeaves";
            this.gcProrataLeaves.FieldName = "ProrataLeaves";
            this.gcProrataLeaves.Name = "gcProrataLeaves";
            this.gcProrataLeaves.Visible = true;
            this.gcProrataLeaves.VisibleIndex = 3;
            // 
            // gcLeavesAvailed
            // 
            this.gcLeavesAvailed.Caption = "LeavesAvailed";
            this.gcLeavesAvailed.FieldName = "LeavesAvailed";
            this.gcLeavesAvailed.Name = "gcLeavesAvailed";
            this.gcLeavesAvailed.Visible = true;
            this.gcLeavesAvailed.VisibleIndex = 4;
            // 
            // gccLeaveBalance
            // 
            this.gccLeaveBalance.Caption = "LeaveBalance";
            this.gccLeaveBalance.FieldName = "LeaveBalance";
            this.gccLeaveBalance.Name = "gccLeaveBalance";
            this.gccLeaveBalance.Visible = true;
            this.gccLeaveBalance.VisibleIndex = 5;
            // 
            // cmbFYear
            // 
            this.cmbFYear.Location = new System.Drawing.Point(12, 31);
            this.cmbFYear.Name = "cmbFYear";
            this.cmbFYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFYear.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FYearID", "FYearID", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FYearName", "FYearName", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FromDate", "FromDate", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ToDate", "ToDate", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbFYear.Properties.NullText = "";
            this.cmbFYear.Properties.ShowFooter = false;
            this.cmbFYear.Properties.ShowHeader = false;
            this.cmbFYear.Size = new System.Drawing.Size(313, 22);
            this.cmbFYear.StyleController = this.layoutControl1;
            this.cmbFYear.TabIndex = 4;
            this.cmbFYear.EditValueChanged += new System.EventHandler(this.cmbFYear_EditValueChanged);
            // 
            // btnViewReport
            // 
            this.btnViewReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnViewReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewReport.ImageOptions.SvgImage")));
            this.btnViewReport.Location = new System.Drawing.Point(779, 12);
            this.btnViewReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(166, 38);
            this.btnViewReport.StyleController = this.layoutControl1;
            this.btnViewReport.TabIndex = 5;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
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
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(957, 584);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcLeaveBalance;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(937, 522);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbFYear;
            this.layoutControlItem2.CustomizationFormText = "Finacial Year";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(317, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(317, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(317, 42);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Finacial Year";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnViewReport;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(767, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(170, 42);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(317, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(450, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "C F Leaves";
            this.gridColumn1.FieldName = "CFLeaves";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Encashed Leaves";
            this.gridColumn2.FieldName = "EncashedLeaves";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 7;
            // 
            // frmYearlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 584);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmYearlyReport";
            this.Text = "frmYearlyReport";
            this.Load += new System.EventHandler(this.frmYearlyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLeaveBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLeaveBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcLeaveBalance;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLeaveBalance;
        private DevExpress.XtraGrid.Columns.GridColumn gcUserName;
        private DevExpress.XtraGrid.Columns.GridColumn gcFullName;
        private DevExpress.XtraGrid.Columns.GridColumn gcEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn gcLeaveTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn gcLeaveTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalLeaves;
        private DevExpress.XtraGrid.Columns.GridColumn gcProrataLeaves;
        private DevExpress.XtraGrid.Columns.GridColumn gcLeavesAvailed;
        private DevExpress.XtraGrid.Columns.GridColumn gccLeaveBalance;
        private DevExpress.XtraEditors.LookUpEdit cmbFYear;
        private DevExpress.XtraEditors.SimpleButton btnViewReport;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}