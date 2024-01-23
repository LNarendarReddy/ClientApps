namespace CMS
{
    partial class frmDoctorAvailability
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gvDoctorAvail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gdFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gdTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riFromTimeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.riTOTimeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctorAvail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riFromTimeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riTOTimeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(315, 274);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 4);
            this.gridControl1.MainView = this.gvDoctorAvail;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riDateEdit,
            this.riFromTimeEdit,
            this.riTOTimeEdit});
            this.gridControl1.Size = new System.Drawing.Size(307, 266);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDoctorAvail});
            // 
            // gvDoctorAvail
            // 
            this.gvDoctorAvail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gdFrom,
            this.gdTo,
            this.gcID});
            this.gvDoctorAvail.GridControl = this.gridControl1;
            this.gvDoctorAvail.Name = "gvDoctorAvail";
            this.gvDoctorAvail.OptionsNavigation.AutoFocusNewRow = true;
            this.gvDoctorAvail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDoctorAvail.OptionsView.ShowFooter = true;
            this.gvDoctorAvail.OptionsView.ShowGroupPanel = false;
            this.gvDoctorAvail.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDoctorAvail_InitNewRow);
            this.gvDoctorAvail.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDoctorAvail_RowUpdated);
            // 
            // gdFrom
            // 
            this.gdFrom.Caption = "Date";
            this.gdFrom.ColumnEdit = this.riDateEdit;
            this.gdFrom.FieldName = "FromDate";
            this.gdFrom.Name = "gdFrom";
            this.gdFrom.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FromDate", "Count: {0:n2}")});
            this.gdFrom.Visible = true;
            this.gdFrom.VisibleIndex = 0;
            // 
            // riDateEdit
            // 
            this.riDateEdit.AutoHeight = false;
            this.riDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riDateEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.riDateEdit.Mask.UseMaskAsDisplayFormat = true;
            this.riDateEdit.Name = "riDateEdit";
            this.riDateEdit.NullValuePromptShowForEmptyValue = true;
            // 
            // gdTo
            // 
            this.gdTo.Caption = "To";
            this.gdTo.ColumnEdit = this.riDateEdit;
            this.gdTo.FieldName = "ToDate";
            this.gdTo.Name = "gdTo";
            // 
            // gcID
            // 
            this.gcID.FieldName = "DoctorAvailabilityID";
            this.gcID.Name = "gcID";
            // 
            // riFromTimeEdit
            // 
            this.riFromTimeEdit.AutoHeight = false;
            this.riFromTimeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riFromTimeEdit.Name = "riFromTimeEdit";
            // 
            // riTOTimeEdit
            // 
            this.riTOTimeEdit.AutoHeight = false;
            this.riTOTimeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riTOTimeEdit.Name = "riTOTimeEdit";
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(315, 274);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(311, 270);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmDoctorAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 274);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoctorAvailability";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Availability";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoctorAvail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riFromTimeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riTOTimeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDoctorAvail;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit riDateEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gdFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit riFromTimeEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gdTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit riTOTimeEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcID;
    }
}