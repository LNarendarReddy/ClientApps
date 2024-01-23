namespace PMS
{
    partial class frmPatientHistory
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientHistory));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcPatientHistory = new DevExpress.XtraGrid.GridControl();
            this.gvPatientHistory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcTreatmentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riView = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riPrint = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cmbPatient = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.gcPatientHistory);
            this.layoutControl1.Controls.Add(this.cmbPatient);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1205, 232, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(969, 605);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcPatientHistory
            // 
            this.gcPatientHistory.Location = new System.Drawing.Point(3, 45);
            this.gcPatientHistory.MainView = this.gvPatientHistory;
            this.gcPatientHistory.Name = "gcPatientHistory";
            this.gcPatientHistory.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riView,
            this.riEdit,
            this.riPrint});
            this.gcPatientHistory.Size = new System.Drawing.Size(963, 556);
            this.gcPatientHistory.TabIndex = 2;
            this.gcPatientHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPatientHistory});
            // 
            // gvPatientHistory
            // 
            this.gvPatientHistory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcTreatmentID,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvPatientHistory.GridControl = this.gcPatientHistory;
            this.gvPatientHistory.Name = "gvPatientHistory";
            this.gvPatientHistory.OptionsView.ShowFooter = true;
            this.gvPatientHistory.OptionsView.ShowGroupPanel = false;
            // 
            // gcTreatmentID
            // 
            this.gcTreatmentID.Caption = "TreatmentID";
            this.gcTreatmentID.FieldName = "TreatmentID";
            this.gcTreatmentID.Name = "gcTreatmentID";
            this.gcTreatmentID.OptionsColumn.AllowEdit = false;
            this.gcTreatmentID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TreatmentID", "Count: {0:n2}")});
            this.gcTreatmentID.Visible = true;
            this.gcTreatmentID.VisibleIndex = 0;
            this.gcTreatmentID.Width = 123;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PName";
            this.gridColumn2.FieldName = "PName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 275;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TreatmentDate";
            this.gridColumn3.FieldName = "TreatmentDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 151;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "AppointmentDate";
            this.gridColumn4.FieldName = "AppointmentDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 149;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "View";
            this.gridColumn5.ColumnEdit = this.riView;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 79;
            // 
            // riView
            // 
            this.riView.AutoHeight = false;
            editorButtonImageOptions1.Image = global::PMS.Properties.Resources.View16;
            this.riView.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riView.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.riView.Name = "riView";
            this.riView.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riView.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.riView_ButtonClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Edit";
            this.gridColumn6.ColumnEdit = this.riEdit;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 79;
            // 
            // riEdit
            // 
            this.riEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = global::PMS.Properties.Resources.Edit16;
            this.riEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.riEdit.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("riEdit.ContextImageOptions.Image")));
            this.riEdit.Name = "riEdit";
            this.riEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.riEdit_ButtonClick);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Print";
            this.gridColumn7.ColumnEdit = this.riPrint;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 89;
            // 
            // riPrint
            // 
            this.riPrint.AutoHeight = false;
            editorButtonImageOptions3.Image = global::PMS.Properties.Resources.print16;
            this.riPrint.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.riPrint.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.riPrint.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("riPrint.ContextImageOptions.Image")));
            this.riPrint.Name = "riPrint";
            this.riPrint.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.riPrint.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.riPrint_ButtonClick);
            // 
            // cmbPatient
            // 
            this.cmbPatient.EnterMoveNextControl = true;
            this.cmbPatient.Location = new System.Drawing.Point(89, 4);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPatient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PatientID", "PatientID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RegNo", "RegNo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PName", "PName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DOB", "DOB"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FatheName", "FatheName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CNumber", "CNumber")});
            this.cmbPatient.Properties.NullText = "";
            this.cmbPatient.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPatient.Properties.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lookUpEdit1_Properties_KeyPress);
            this.cmbPatient.Size = new System.Drawing.Size(877, 24);
            this.cmbPatient.StyleController = this.layoutControl1;
            this.cmbPatient.TabIndex = 1;
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
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 2, 2);
            this.Root.Size = new System.Drawing.Size(969, 605);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbPatient;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(967, 28);
            this.layoutControlItem1.Text = "Search Patient";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(83, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcPatientHistory;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 41);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(967, 560);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 13);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 13);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(967, 13);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmPatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 605);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPatientHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient History";
            this.Load += new System.EventHandler(this.frmPatientHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPatientHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPatientHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit cmbPatient;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gcPatientHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPatientHistory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcTreatmentID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit riPrint;
    }
}