﻿namespace EHR
{
    partial class frmWorkType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkType));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gcWorkType = new DevExpress.XtraGrid.GridControl();
            this.gvWorkType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WorkTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkTypedescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubTaskID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSubTask = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSubTask1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtWorktype = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubTask1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorktype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcWorkType
            // 
            this.gcWorkType.Location = new System.Drawing.Point(12, 104);
            this.gcWorkType.MainView = this.gvWorkType;
            this.gcWorkType.Name = "gcWorkType";
            this.gcWorkType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbSubTask,
            this.btnEdit});
            this.gcWorkType.Size = new System.Drawing.Size(703, 586);
            this.gcWorkType.TabIndex = 6;
            this.gcWorkType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkType});
            // 
            // gvWorkType
            // 
            this.gvWorkType.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.GroupFooter.Options.UseFont = true;
            this.gvWorkType.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.GroupPanel.Options.UseFont = true;
            this.gvWorkType.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.GroupRow.Options.UseFont = true;
            this.gvWorkType.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvWorkType.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvWorkType.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvWorkType.Appearance.Row.Options.UseFont = true;
            this.gvWorkType.Appearance.TopNewRow.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvWorkType.Appearance.TopNewRow.Options.UseFont = true;
            this.gvWorkType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WorkTypeID,
            this.WorkTypedescription,
            this.SubTaskID,
            this.gridColumn1});
            this.gvWorkType.GridControl = this.gcWorkType;
            this.gvWorkType.Name = "gvWorkType";
            this.gvWorkType.OptionsView.EnableAppearanceEvenRow = true;
            this.gvWorkType.OptionsView.ShowGroupPanel = false;
            this.gvWorkType.OptionsView.ShowIndicator = false;
            // 
            // WorkTypeID
            // 
            this.WorkTypeID.Caption = "WorkTypeID";
            this.WorkTypeID.FieldName = "WorkTypeID";
            this.WorkTypeID.Name = "WorkTypeID";
            // 
            // WorkTypedescription
            // 
            this.WorkTypedescription.Caption = "Work Type";
            this.WorkTypedescription.FieldName = "WorkTypedescription";
            this.WorkTypedescription.Name = "WorkTypedescription";
            this.WorkTypedescription.OptionsColumn.AllowEdit = false;
            this.WorkTypedescription.Visible = true;
            this.WorkTypedescription.VisibleIndex = 0;
            // 
            // SubTaskID
            // 
            this.SubTaskID.Caption = "Sub Task";
            this.SubTaskID.ColumnEdit = this.cmbSubTask;
            this.SubTaskID.FieldName = "SubTaskID";
            this.SubTaskID.Name = "SubTaskID";
            this.SubTaskID.OptionsColumn.AllowEdit = false;
            this.SubTaskID.Visible = true;
            this.SubTaskID.VisibleIndex = 1;
            this.SubTaskID.Width = 302;
            // 
            // cmbSubTask
            // 
            this.cmbSubTask.AutoHeight = false;
            this.cmbSubTask.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubTask.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubTaskID", "SubTaskID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubTaskDescription", "Sub Task")});
            this.cmbSubTask.Name = "cmbSubTask";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Edit";
            this.gridColumn1.ColumnEdit = this.btnEdit;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 79;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnReset);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.cmbSubTask1);
            this.layoutControl1.Controls.Add(this.txtWorktype);
            this.layoutControl1.Controls.Add(this.gcWorkType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1065, 454, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(727, 702);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(594, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 36);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReset.ImageOptions.SvgImage")));
            this.btnReset.Location = new System.Drawing.Point(473, 64);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 36);
            this.btnReset.StyleController = this.layoutControl1;
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(358, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 36);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSubTask1
            // 
            this.cmbSubTask1.EnterMoveNextControl = true;
            this.cmbSubTask1.Location = new System.Drawing.Point(75, 38);
            this.cmbSubTask1.Name = "cmbSubTask1";
            this.cmbSubTask1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSubTask1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubTaskID", "SubTaskID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubTaskDescription", "SubTaskDescription")});
            this.cmbSubTask1.Properties.NullText = "Select";
            this.cmbSubTask1.Properties.ShowHeader = false;
            this.cmbSubTask1.Size = new System.Drawing.Size(640, 22);
            this.cmbSubTask1.StyleController = this.layoutControl1;
            this.cmbSubTask1.TabIndex = 2;
            // 
            // txtWorktype
            // 
            this.txtWorktype.EnterMoveNextControl = true;
            this.txtWorktype.Location = new System.Drawing.Point(75, 12);
            this.txtWorktype.Name = "txtWorktype";
            this.txtWorktype.Size = new System.Drawing.Size(640, 22);
            this.txtWorktype.StyleController = this.layoutControl1;
            this.txtWorktype.TabIndex = 1;
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
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(727, 702);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcWorkType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 92);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(707, 590);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtWorktype;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(707, 26);
            this.layoutControlItem2.Text = "Work Type";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbSubTask1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(707, 26);
            this.layoutControlItem3.Text = "Sub Task";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(346, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(115, 40);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnReset;
            this.layoutControlItem5.Location = new System.Drawing.Point(461, 52);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(121, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(582, 52);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(125, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(346, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmWorkType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(727, 702);
            this.Controls.Add(this.layoutControl1);
            this.ShowIcon = false;
            this.Name = "frmWorkType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work Type";
            this.Load += new System.EventHandler(this.frmSubTaskMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSubTask1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorktype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcWorkType;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkType;
        private DevExpress.XtraGrid.Columns.GridColumn WorkTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn WorkTypedescription;
        private DevExpress.XtraGrid.Columns.GridColumn SubTaskID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cmbSubTask;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit cmbSubTask1;
        private DevExpress.XtraEditors.TextEdit txtWorktype;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
    }
}