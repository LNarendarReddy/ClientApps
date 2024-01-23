namespace IIT
{
    partial class ucMultiVoucher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMultiVoucher));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gcVouchers = new DevExpress.XtraGrid.GridControl();
            this.gvVouchers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdeVoucherDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gcPaymentFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluPaymentFrom = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcPaymentTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluPaymentTo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcPurpose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rteAmount = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rbtnAddNew = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolChequeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcModeOfTransfer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rluModeOfTransfer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblVoucherTypeHeader = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVouchers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdeVoucherDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdeVoucherDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluPaymentFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluPaymentTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rteAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnAddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluModeOfTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.gcVouchers);
            this.layoutControl1.Controls.Add(this.lblVoucherTypeHeader);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1087, 561);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(930, 517);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 36);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gcVouchers
            // 
            this.gcVouchers.Location = new System.Drawing.Point(4, 42);
            this.gcVouchers.MainView = this.gvVouchers;
            this.gcVouchers.Name = "gcVouchers";
            this.gcVouchers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rluPaymentFrom,
            this.rluPaymentTo,
            this.rbtnAddNew,
            this.rdeVoucherDate,
            this.rteAmount,
            this.rluModeOfTransfer});
            this.gcVouchers.Size = new System.Drawing.Size(1079, 467);
            this.gcVouchers.TabIndex = 5;
            this.gcVouchers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVouchers});
            // 
            // gvVouchers
            // 
            this.gvVouchers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gcPaymentFrom,
            this.gcPaymentTo,
            this.gcPurpose,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn4,
            this.gridColumn5,
            this.gcolChequeNumber,
            this.gridColumn9,
            this.gcModeOfTransfer});
            this.gvVouchers.GridControl = this.gcVouchers;
            this.gvVouchers.Name = "gvVouchers";
            this.gvVouchers.OptionsNavigation.AutoFocusNewRow = true;
            this.gvVouchers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvVouchers.OptionsView.ShowGroupPanel = false;
            this.gvVouchers.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvVouchers_InitNewRow);
            this.gvVouchers.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvVouchers_InvalidRowException);
            this.gvVouchers.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvVouchers_ValidateRow);
            this.gvVouchers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvVouchers_KeyPress);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "VOUCHERTYPEID";
            this.gridColumn2.FieldName = "VoucherTypeID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Voucher Date";
            this.gridColumn3.ColumnEdit = this.rdeVoucherDate;
            this.gridColumn3.FieldName = "VoucherDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 83;
            // 
            // rdeVoucherDate
            // 
            this.rdeVoucherDate.AutoHeight = false;
            this.rdeVoucherDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdeVoucherDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdeVoucherDate.Name = "rdeVoucherDate";
            // 
            // gcPaymentFrom
            // 
            this.gcPaymentFrom.Caption = "Payment From";
            this.gcPaymentFrom.ColumnEdit = this.rluPaymentFrom;
            this.gcPaymentFrom.FieldName = "PaymentFrom";
            this.gcPaymentFrom.Name = "gcPaymentFrom";
            this.gcPaymentFrom.Visible = true;
            this.gcPaymentFrom.VisibleIndex = 4;
            this.gcPaymentFrom.Width = 199;
            // 
            // rluPaymentFrom
            // 
            this.rluPaymentFrom.AutoHeight = false;
            this.rluPaymentFrom.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluPaymentFrom.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LEDGERID", "LEDGERID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LEDGERNAME", "Ledger")});
            this.rluPaymentFrom.Name = "rluPaymentFrom";
            this.rluPaymentFrom.NullText = "";
            // 
            // gcPaymentTo
            // 
            this.gcPaymentTo.Caption = "Payment To";
            this.gcPaymentTo.ColumnEdit = this.rluPaymentTo;
            this.gcPaymentTo.FieldName = "PaymentTo";
            this.gcPaymentTo.Name = "gcPaymentTo";
            this.gcPaymentTo.Visible = true;
            this.gcPaymentTo.VisibleIndex = 1;
            this.gcPaymentTo.Width = 144;
            // 
            // rluPaymentTo
            // 
            this.rluPaymentTo.AutoHeight = false;
            this.rluPaymentTo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluPaymentTo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LEDGERID", "LEDGERID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LEDGERNAME", "Ledger")});
            this.rluPaymentTo.Name = "rluPaymentTo";
            this.rluPaymentTo.NullText = "";
            // 
            // gcPurpose
            // 
            this.gcPurpose.Caption = "Purpose";
            this.gcPurpose.FieldName = "Purpose";
            this.gcPurpose.Name = "gcPurpose";
            this.gcPurpose.Visible = true;
            this.gcPurpose.VisibleIndex = 5;
            this.gcPurpose.Width = 232;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Amount";
            this.gridColumn6.ColumnEdit = this.rteAmount;
            this.gridColumn6.FieldName = "Amount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 138;
            // 
            // rteAmount
            // 
            this.rteAmount.AutoHeight = false;
            this.rteAmount.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.rteAmount.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.rteAmount.MaskSettings.Set("mask", "n2");
            this.rteAmount.Name = "rteAmount";
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Add New";
            this.gridColumn7.ColumnEdit = this.rbtnAddNew;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 73;
            // 
            // rbtnAddNew
            // 
            this.rbtnAddNew.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions2.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.rbtnAddNew.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.rbtnAddNew.Name = "rbtnAddNew";
            this.rbtnAddNew.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rbtnAddNew.Click += new System.EventHandler(this.rbtnAddNew_Click);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "UserName";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "EntityID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gcolChequeNumber
            // 
            this.gcolChequeNumber.Caption = "Cheque Number";
            this.gcolChequeNumber.FieldName = "ChequeNumber";
            this.gcolChequeNumber.Name = "gcolChequeNumber";
            this.gcolChequeNumber.Visible = true;
            this.gcolChequeNumber.VisibleIndex = 2;
            this.gcolChequeNumber.Width = 87;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "ChequeRegisterID";
            this.gridColumn9.FieldName = "ChequeRegisterID";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gcModeOfTransfer
            // 
            this.gcModeOfTransfer.Caption = "Payment Mode";
            this.gcModeOfTransfer.ColumnEdit = this.rluModeOfTransfer;
            this.gcModeOfTransfer.FieldName = "PaymentMode";
            this.gcModeOfTransfer.Name = "gcModeOfTransfer";
            this.gcModeOfTransfer.Visible = true;
            this.gcModeOfTransfer.VisibleIndex = 3;
            this.gcModeOfTransfer.Width = 84;
            // 
            // rluModeOfTransfer
            // 
            this.rluModeOfTransfer.AutoHeight = false;
            this.rluModeOfTransfer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rluModeOfTransfer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentModeID", "PaymentModeID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PaymentModeText", "Payment Mode")});
            this.rluModeOfTransfer.DisplayMember = "PaymentModeText";
            this.rluModeOfTransfer.Name = "rluModeOfTransfer";
            this.rluModeOfTransfer.NullText = "";
            this.rluModeOfTransfer.ValueMember = "PaymentModeID";
            // 
            // lblVoucherTypeHeader
            // 
            this.lblVoucherTypeHeader.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblVoucherTypeHeader.Appearance.Options.UseFont = true;
            this.lblVoucherTypeHeader.Appearance.Options.UseTextOptions = true;
            this.lblVoucherTypeHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblVoucherTypeHeader.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblVoucherTypeHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVoucherTypeHeader.Location = new System.Drawing.Point(4, 4);
            this.lblVoucherTypeHeader.Name = "lblVoucherTypeHeader";
            this.lblVoucherTypeHeader.Padding = new System.Windows.Forms.Padding(6);
            this.lblVoucherTypeHeader.Size = new System.Drawing.Size(1079, 34);
            this.lblVoucherTypeHeader.StyleController = this.layoutControl1;
            this.lblVoucherTypeHeader.TabIndex = 4;
            this.lblVoucherTypeHeader.Text = "Voucher Type Header";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(1087, 561);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lblVoucherTypeHeader;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1083, 38);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcVouchers;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1083, 471);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(922, 509);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(161, 48);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(161, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem3.Size = new System.Drawing.Size(161, 48);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 509);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(922, 48);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucMultiVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucMultiVoucher";
            this.Size = new System.Drawing.Size(1087, 561);
            this.Load += new System.EventHandler(this.ucMultiVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVouchers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdeVoucherDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdeVoucherDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluPaymentFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluPaymentTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rteAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnAddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rluModeOfTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl lblVoucherTypeHeader;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gcVouchers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVouchers;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gcPaymentFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gcPaymentTo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluPaymentFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluPaymentTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rbtnAddNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rdeVoucherDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcPurpose;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rteAmount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gcolChequeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gcModeOfTransfer;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rluModeOfTransfer;
    }
}
