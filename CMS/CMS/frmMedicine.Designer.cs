namespace CMS
{
    partial class frmMedicine
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
            this.MedicineLayer = new DevExpress.XtraLayout.LayoutControl();
            this.gdMedicine = new DevExpress.XtraGrid.GridControl();
            this.gvMedicine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMedicineCode = new DevExpress.XtraEditors.TextEdit();
            this.txtMedName = new DevExpress.XtraEditors.TextEdit();
            this.cmbType = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtGenericName = new DevExpress.XtraEditors.TextEdit();
            this.btnNewMedicine = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.lblCheck = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineLayer)).BeginInit();
            this.MedicineLayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicineCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenericName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineLayer
            // 
            this.MedicineLayer.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.MedicineLayer.Appearance.Control.Options.UseFont = true;
            this.MedicineLayer.Controls.Add(this.gdMedicine);
            this.MedicineLayer.Controls.Add(this.txtMedicineCode);
            this.MedicineLayer.Controls.Add(this.txtMedName);
            this.MedicineLayer.Controls.Add(this.cmbType);
            this.MedicineLayer.Controls.Add(this.txtPrice);
            this.MedicineLayer.Controls.Add(this.btnAdd);
            this.MedicineLayer.Controls.Add(this.txtGenericName);
            this.MedicineLayer.Controls.Add(this.btnNewMedicine);
            this.MedicineLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicineLayer.Location = new System.Drawing.Point(0, 0);
            this.MedicineLayer.Name = "MedicineLayer";
            this.MedicineLayer.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(911, 240, 650, 400);
            this.MedicineLayer.OptionsFocus.EnableAutoTabOrder = false;
            this.MedicineLayer.Root = this.Root;
            this.MedicineLayer.Size = new System.Drawing.Size(670, 476);
            this.MedicineLayer.TabIndex = 0;
            this.MedicineLayer.Text = "layoutControl1";
            // 
            // gdMedicine
            // 
            this.gdMedicine.Location = new System.Drawing.Point(12, 181);
            this.gdMedicine.MainView = this.gvMedicine;
            this.gdMedicine.Name = "gdMedicine";
            this.gdMedicine.Size = new System.Drawing.Size(646, 283);
            this.gdMedicine.TabIndex = 15;
            this.gdMedicine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMedicine});
            // 
            // gvMedicine
            // 
            this.gvMedicine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.ID,
            this.gridColumn3});
            this.gvMedicine.GridControl = this.gdMedicine;
            this.gvMedicine.Name = "gvMedicine";
            this.gvMedicine.OptionsBehavior.Editable = false;
            this.gvMedicine.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gvMedicine.OptionsView.ShowFooter = true;
            this.gvMedicine.OptionsView.ShowGroupPanel = false;
            this.gvMedicine.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvMedicine_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "MedicineCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MedicineCode", "Count: {0:n2}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 20;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Name";
            this.gridColumn2.FieldName = "MedicineName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 80;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Generic Name";
            this.gridColumn4.FieldName = "GenericName";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "MedicineID";
            this.ID.Name = "ID";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Category";
            this.gridColumn3.FieldName = "TypeName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // txtMedicineCode
            // 
            this.txtMedicineCode.EnterMoveNextControl = true;
            this.txtMedicineCode.Location = new System.Drawing.Point(100, 12);
            this.txtMedicineCode.Name = "txtMedicineCode";
            this.txtMedicineCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedicineCode.Size = new System.Drawing.Size(558, 24);
            this.txtMedicineCode.StyleController = this.MedicineLayer;
            this.txtMedicineCode.TabIndex = 0;
            // 
            // txtMedName
            // 
            this.txtMedName.EnterMoveNextControl = true;
            this.txtMedName.Location = new System.Drawing.Point(100, 40);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedName.Size = new System.Drawing.Size(558, 24);
            this.txtMedName.StyleController = this.MedicineLayer;
            this.txtMedName.TabIndex = 1;
            // 
            // cmbType
            // 
            this.cmbType.EnterMoveNextControl = true;
            this.cmbType.Location = new System.Drawing.Point(100, 96);
            this.cmbType.Name = "cmbType";
            this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TypeName", "Name7")});
            this.cmbType.Properties.NullText = "";
            this.cmbType.Properties.ShowHeader = false;
            this.cmbType.Size = new System.Drawing.Size(558, 24);
            this.cmbType.StyleController = this.MedicineLayer;
            this.cmbType.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.EnterMoveNextControl = true;
            this.txtPrice.Location = new System.Drawing.Point(100, 124);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Mask.EditMask = "n";
            this.txtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrice.Size = new System.Drawing.Size(558, 24);
            this.txtPrice.StyleController = this.MedicineLayer;
            this.txtPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(540, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 25);
            this.btnAdd.StyleController = this.MedicineLayer;
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Save Medicine";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGenericName
            // 
            this.txtGenericName.EnterMoveNextControl = true;
            this.txtGenericName.Location = new System.Drawing.Point(100, 68);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGenericName.Size = new System.Drawing.Size(558, 24);
            this.txtGenericName.StyleController = this.MedicineLayer;
            this.txtGenericName.TabIndex = 2;
            // 
            // btnNewMedicine
            // 
            this.btnNewMedicine.Location = new System.Drawing.Point(414, 152);
            this.btnNewMedicine.Name = "btnNewMedicine";
            this.btnNewMedicine.Size = new System.Drawing.Size(112, 25);
            this.btnNewMedicine.StyleController = this.MedicineLayer;
            this.btnNewMedicine.TabIndex = 10;
            this.btnNewMedicine.Text = "New Medicine";
            this.btnNewMedicine.Click += new System.EventHandler(this.btnNewMedicine_Click);
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
            this.layoutControlItem7,
            this.layoutControlItem15,
            this.layoutControlItem14,
            this.layoutControlItem16,
            this.layoutControlItem21,
            this.emptySpaceItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(670, 476);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMedicineCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(650, 28);
            this.layoutControlItem1.Text = "Medicine Code";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMedName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(650, 28);
            this.layoutControlItem2.Text = "Medicine Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbType;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(650, 28);
            this.layoutControlItem3.Text = "Category";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtPrice;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(650, 28);
            this.layoutControlItem7.Text = "Price";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.btnAdd;
            this.layoutControlItem15.Location = new System.Drawing.Point(528, 140);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(122, 29);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.txtGenericName;
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(650, 28);
            this.layoutControlItem14.Text = "Generic Name";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(85, 18);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.gdMedicine;
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 169);
            this.layoutControlItem16.Name = "layoutControlItem16";
            this.layoutControlItem16.Size = new System.Drawing.Size(650, 287);
            this.layoutControlItem16.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem16.TextVisible = false;
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.btnNewMedicine;
            this.layoutControlItem21.Location = new System.Drawing.Point(402, 140);
            this.layoutControlItem21.Name = "layoutControlItem21";
            this.layoutControlItem21.Size = new System.Drawing.Size(116, 29);
            this.layoutControlItem21.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem21.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(518, 140);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 29);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // lblCheck
            // 
            this.lblCheck.AllowHotTrack = false;
            this.lblCheck.Location = new System.Drawing.Point(0, 375);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(356, 17);
            this.lblCheck.TextSize = new System.Drawing.Size(60, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 140);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(402, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 476);
            this.Controls.Add(this.MedicineLayer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMedicine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine Record History";
            this.Load += new System.EventHandler(this.frmMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineLayer)).EndInit();
            this.MedicineLayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicineCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGenericName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtMedicineCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtMedName;
        private DevExpress.XtraEditors.LookUpEdit cmbType;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.TextEdit txtGenericName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraGrid.GridControl gdMedicine;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMedicine;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnNewMedicine;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleLabelItem lblCheck;
        public DevExpress.XtraLayout.LayoutControl MedicineLayer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}