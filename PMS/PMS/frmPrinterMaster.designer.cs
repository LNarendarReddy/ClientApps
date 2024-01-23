﻿namespace PMS
{
    partial class frmPrinterMaster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrinterMaster));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDetect = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSAve = new DevExpress.XtraEditors.SimpleButton();
            this.gcPrinters = new DevExpress.XtraGrid.GridControl();
            this.gvPrinters = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.cmbPrinterName = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbPrinterType = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrinters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrinters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrinterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrinterType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnDetect);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSAve);
            this.layoutControl1.Controls.Add(this.gcPrinters);
            this.layoutControl1.Controls.Add(this.txtUserName);
            this.layoutControl1.Controls.Add(this.cmbPrinterName);
            this.layoutControl1.Controls.Add(this.cmbPrinterType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(934, 175, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(613, 512);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(491, 60);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(118, 25);
            this.btnDetect.StyleController = this.layoutControl1;
            this.btnDetect.TabIndex = 7;
            this.btnDetect.Text = "Detect";
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(491, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 38);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSAve
            // 
            this.btnSAve.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSAve.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSAve.ImageOptions.SvgImage")));
            this.btnSAve.Location = new System.Drawing.Point(369, 89);
            this.btnSAve.Name = "btnSAve";
            this.btnSAve.Size = new System.Drawing.Size(118, 38);
            this.btnSAve.StyleController = this.layoutControl1;
            this.btnSAve.TabIndex = 4;
            this.btnSAve.Text = "Save";
            this.btnSAve.Click += new System.EventHandler(this.btnSAve_Click);
            // 
            // gcPrinters
            // 
            this.gcPrinters.Location = new System.Drawing.Point(4, 131);
            this.gcPrinters.MainView = this.gvPrinters;
            this.gcPrinters.Name = "gcPrinters";
            this.gcPrinters.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit});
            this.gcPrinters.Size = new System.Drawing.Size(605, 377);
            this.gcPrinters.TabIndex = 6;
            this.gcPrinters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrinters});
            // 
            // gvPrinters
            // 
            this.gvPrinters.Appearance.HeaderPanel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold);
            this.gvPrinters.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPrinters.Appearance.Row.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.gvPrinters.Appearance.Row.Options.UseFont = true;
            this.gvPrinters.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvPrinters.GridControl = this.gcPrinters;
            this.gvPrinters.Name = "gvPrinters";
            this.gvPrinters.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Printer Type";
            this.gridColumn1.FieldName = "PrinterType";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 204;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Printer Name";
            this.gridColumn2.FieldName = "PrinterName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 383;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "PrinterSettingsID";
            this.gridColumn3.FieldName = "PrinterSettingsID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "UserID";
            this.gridColumn4.FieldName = "UserID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "PrinterID";
            this.gridColumn5.FieldName = "PrinterID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "Edit";
            this.gridColumn6.ColumnEdit = this.btnEdit;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(80, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(529, 24);
            this.txtUserName.StyleController = this.layoutControl1;
            this.txtUserName.TabIndex = 1;
            // 
            // cmbPrinterName
            // 
            this.cmbPrinterName.EnterMoveNextControl = true;
            this.cmbPrinterName.Location = new System.Drawing.Point(80, 60);
            this.cmbPrinterName.Name = "cmbPrinterName";
            this.cmbPrinterName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPrinterName.Properties.NullText = "";
            this.cmbPrinterName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPrinterName.Size = new System.Drawing.Size(407, 24);
            this.cmbPrinterName.StyleController = this.layoutControl1;
            this.cmbPrinterName.TabIndex = 3;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Mandatory";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.cmbPrinterName, conditionValidationRule1);
            // 
            // cmbPrinterType
            // 
            this.cmbPrinterType.Enabled = false;
            this.cmbPrinterType.EnterMoveNextControl = true;
            this.cmbPrinterType.Location = new System.Drawing.Point(80, 32);
            this.cmbPrinterType.Name = "cmbPrinterType";
            this.cmbPrinterType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPrinterType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PrinterType", "Printer Type")});
            this.cmbPrinterType.Properties.NullText = "";
            this.cmbPrinterType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPrinterType.Size = new System.Drawing.Size(529, 24);
            this.cmbPrinterType.StyleController = this.layoutControl1;
            this.cmbPrinterType.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Mandatory";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.dxValidationProvider1.SetValidationRule(this.cmbPrinterType, conditionValidationRule2);
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
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(613, 512);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbPrinterType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(609, 28);
            this.layoutControlItem1.Text = "Printer Type";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmbPrinterName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(487, 29);
            this.layoutControlItem2.Text = "Printer Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtUserName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(609, 28);
            this.layoutControlItem3.Text = "User Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gcPrinters;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 127);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(609, 381);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSAve;
            this.layoutControlItem5.Location = new System.Drawing.Point(365, 85);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(122, 42);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(487, 85);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(122, 42);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 85);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(365, 42);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnDetect;
            this.layoutControlItem7.Location = new System.Drawing.Point(487, 56);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(122, 29);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // frmPrinterMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(613, 512);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrinterMaster";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Printer Master";
            this.Load += new System.EventHandler(this.frmPrinterMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrinters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrinters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrinterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrinterType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LookUpEdit cmbPrinterType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit cmbPrinterName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gcPrinters;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrinters;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnSAve;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnDetect;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
    }
}