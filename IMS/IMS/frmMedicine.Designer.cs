namespace IMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicine));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnAddUnit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddManufacturer = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCategory = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtMedicineName = new DevExpress.XtraEditors.TextEdit();
            this.gcMedicine = new DevExpress.XtraGrid.GridControl();
            this.gvMedicine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedicineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedicineName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReOrderLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCategoryName = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbMName = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.txtReOrderLevel = new DevExpress.XtraEditors.TextEdit();
            this.txtLocation = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCategoryName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForUnit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForReOrderLevel = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLocation = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicineName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrderLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReOrderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnAddUnit);
            this.dataLayoutControl1.Controls.Add(this.btnAddManufacturer);
            this.dataLayoutControl1.Controls.Add(this.btnAddCategory);
            this.dataLayoutControl1.Controls.Add(this.btnCancel);
            this.dataLayoutControl1.Controls.Add(this.btnSave);
            this.dataLayoutControl1.Controls.Add(this.txtMedicineName);
            this.dataLayoutControl1.Controls.Add(this.gcMedicine);
            this.dataLayoutControl1.Controls.Add(this.cmbCategoryName);
            this.dataLayoutControl1.Controls.Add(this.cmbMName);
            this.dataLayoutControl1.Controls.Add(this.cmbUnit);
            this.dataLayoutControl1.Controls.Add(this.txtReOrderLevel);
            this.dataLayoutControl1.Controls.Add(this.txtLocation);
            this.dataLayoutControl1.DataMember = "P_Get_Medicine";
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(848, 429, 450, 400);
            this.dataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(978, 648);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUnit.ImageOptions.Image")));
            this.btnAddUnit.Location = new System.Drawing.Point(710, 88);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(92, 22);
            this.btnAddUnit.StyleController = this.dataLayoutControl1;
            this.btnAddUnit.TabIndex = 12;
            this.btnAddUnit.Text = "Add";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // btnAddManufacturer
            // 
            this.btnAddManufacturer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddManufacturer.ImageOptions.Image")));
            this.btnAddManufacturer.Location = new System.Drawing.Point(710, 62);
            this.btnAddManufacturer.Name = "btnAddManufacturer";
            this.btnAddManufacturer.Size = new System.Drawing.Size(92, 22);
            this.btnAddManufacturer.StyleController = this.dataLayoutControl1;
            this.btnAddManufacturer.TabIndex = 11;
            this.btnAddManufacturer.Text = "Add";
            this.btnAddManufacturer.Click += new System.EventHandler(this.btnAddManufacturer_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.ImageOptions.Image")));
            this.btnAddCategory.Location = new System.Drawing.Point(710, 36);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(92, 22);
            this.btnAddCategory.StyleController = this.dataLayoutControl1;
            this.btnAddCategory.TabIndex = 10;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(743, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 22);
            this.btnCancel.StyleController = this.dataLayoutControl1;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(679, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 22);
            this.btnSave.StyleController = this.dataLayoutControl1;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.EnterMoveNextControl = true;
            this.txtMedicineName.Location = new System.Drawing.Point(241, 12);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(561, 20);
            this.txtMedicineName.StyleController = this.dataLayoutControl1;
            this.txtMedicineName.TabIndex = 1;
            this.txtMedicineName.Tag = "Medicine Name";
            // 
            // gcMedicine
            // 
            this.gcMedicine.DataMember = "P_Get_Medicine";
            this.gcMedicine.Location = new System.Drawing.Point(12, 188);
            this.gcMedicine.MainView = this.gvMedicine;
            this.gcMedicine.Name = "gcMedicine";
            this.gcMedicine.Size = new System.Drawing.Size(954, 448);
            this.gcMedicine.TabIndex = 9;
            this.gcMedicine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMedicine});
            this.gcMedicine.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcMedicine_ProcessGridKey);
            // 
            // gvMedicine
            // 
            this.gvMedicine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMedicineID,
            this.colMedicineName,
            this.colCategoryID,
            this.colCategoryName,
            this.colMID,
            this.colMName,
            this.colUnitID,
            this.colUnit,
            this.colReOrderLevel,
            this.colLocation,
            this.colCreatedBy,
            this.colCreatedDate});
            this.gvMedicine.GridControl = this.gcMedicine;
            this.gvMedicine.Name = "gvMedicine";
            this.gvMedicine.OptionsBehavior.Editable = false;
            this.gvMedicine.DoubleClick += new System.EventHandler(this.gvMedicine_DoubleClick);
            // 
            // colMedicineID
            // 
            this.colMedicineID.FieldName = "MedicineID";
            this.colMedicineID.Name = "colMedicineID";
            // 
            // colMedicineName
            // 
            this.colMedicineName.Caption = "Medicine";
            this.colMedicineName.FieldName = "MedicineName";
            this.colMedicineName.Name = "colMedicineName";
            this.colMedicineName.Visible = true;
            this.colMedicineName.VisibleIndex = 0;
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "Category";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // colMID
            // 
            this.colMID.FieldName = "MID";
            this.colMID.Name = "colMID";
            // 
            // colMName
            // 
            this.colMName.Caption = "Manufacturer";
            this.colMName.FieldName = "MName";
            this.colMName.Name = "colMName";
            this.colMName.Visible = true;
            this.colMName.VisibleIndex = 2;
            // 
            // colUnitID
            // 
            this.colUnitID.FieldName = "UnitID";
            this.colUnitID.Name = "colUnitID";
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 3;
            // 
            // colReOrderLevel
            // 
            this.colReOrderLevel.FieldName = "ReOrderLevel";
            this.colReOrderLevel.Name = "colReOrderLevel";
            this.colReOrderLevel.Visible = true;
            this.colReOrderLevel.VisibleIndex = 4;
            // 
            // colLocation
            // 
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 5;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.EnterMoveNextControl = true;
            this.cmbCategoryName.Location = new System.Drawing.Point(241, 36);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategoryName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "CategoryName")});
            this.cmbCategoryName.Properties.NullText = "";
            this.cmbCategoryName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbCategoryName.Size = new System.Drawing.Size(465, 20);
            this.cmbCategoryName.StyleController = this.dataLayoutControl1;
            this.cmbCategoryName.TabIndex = 2;
            this.cmbCategoryName.Tag = "Category";
            // 
            // cmbMName
            // 
            this.cmbMName.EnterMoveNextControl = true;
            this.cmbMName.Location = new System.Drawing.Point(241, 62);
            this.cmbMName.Name = "cmbMName";
            this.cmbMName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaufacturerName", "Maufacturer")});
            this.cmbMName.Properties.NullText = "";
            this.cmbMName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbMName.Size = new System.Drawing.Size(465, 20);
            this.cmbMName.StyleController = this.dataLayoutControl1;
            this.cmbMName.TabIndex = 3;
            this.cmbMName.Tag = "Manufacturer";
            // 
            // cmbUnit
            // 
            this.cmbUnit.EnterMoveNextControl = true;
            this.cmbUnit.Location = new System.Drawing.Point(241, 88);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Unit", "Unit")});
            this.cmbUnit.Properties.NullText = "";
            this.cmbUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbUnit.Size = new System.Drawing.Size(465, 20);
            this.cmbUnit.StyleController = this.dataLayoutControl1;
            this.cmbUnit.TabIndex = 4;
            this.cmbUnit.Tag = "Unit";
            // 
            // txtReOrderLevel
            // 
            this.txtReOrderLevel.EnterMoveNextControl = true;
            this.txtReOrderLevel.Location = new System.Drawing.Point(241, 114);
            this.txtReOrderLevel.Name = "txtReOrderLevel";
            this.txtReOrderLevel.Properties.Mask.EditMask = "N0";
            this.txtReOrderLevel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReOrderLevel.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtReOrderLevel.Size = new System.Drawing.Size(561, 20);
            this.txtReOrderLevel.StyleController = this.dataLayoutControl1;
            this.txtReOrderLevel.TabIndex = 5;
            this.txtReOrderLevel.Tag = "Re Order Level";
            // 
            // txtLocation
            // 
            this.txtLocation.EnterMoveNextControl = true;
            this.txtLocation.Location = new System.Drawing.Point(241, 138);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(561, 20);
            this.txtLocation.StyleController = this.dataLayoutControl1;
            this.txtLocation.TabIndex = 6;
            this.txtLocation.Tag = "Location";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(978, 648);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCategoryName,
            this.ItemForMName,
            this.ItemForUnit,
            this.ItemForReOrderLevel,
            this.ItemForLocation,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(958, 628);
            // 
            // ItemForCategoryName
            // 
            this.ItemForCategoryName.Control = this.cmbCategoryName;
            this.ItemForCategoryName.Location = new System.Drawing.Point(151, 24);
            this.ItemForCategoryName.Name = "ItemForCategoryName";
            this.ItemForCategoryName.Size = new System.Drawing.Size(547, 26);
            this.ItemForCategoryName.Text = "Category Name";
            this.ItemForCategoryName.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForMName
            // 
            this.ItemForMName.Control = this.cmbMName;
            this.ItemForMName.Location = new System.Drawing.Point(151, 50);
            this.ItemForMName.Name = "ItemForMName";
            this.ItemForMName.Size = new System.Drawing.Size(547, 26);
            this.ItemForMName.Text = "Manufacturer";
            this.ItemForMName.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForUnit
            // 
            this.ItemForUnit.Control = this.cmbUnit;
            this.ItemForUnit.Location = new System.Drawing.Point(151, 76);
            this.ItemForUnit.Name = "ItemForUnit";
            this.ItemForUnit.Size = new System.Drawing.Size(547, 26);
            this.ItemForUnit.Text = "Unit";
            this.ItemForUnit.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForReOrderLevel
            // 
            this.ItemForReOrderLevel.Control = this.txtReOrderLevel;
            this.ItemForReOrderLevel.Location = new System.Drawing.Point(151, 102);
            this.ItemForReOrderLevel.Name = "ItemForReOrderLevel";
            this.ItemForReOrderLevel.Size = new System.Drawing.Size(643, 24);
            this.ItemForReOrderLevel.Text = "Re Order Level";
            this.ItemForReOrderLevel.TextSize = new System.Drawing.Size(75, 13);
            // 
            // ItemForLocation
            // 
            this.ItemForLocation.Control = this.txtLocation;
            this.ItemForLocation.Location = new System.Drawing.Point(151, 126);
            this.ItemForLocation.Name = "ItemForLocation";
            this.ItemForLocation.Size = new System.Drawing.Size(643, 24);
            this.ItemForLocation.Text = "Location";
            this.ItemForLocation.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcMedicine;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 176);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(958, 452);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtMedicineName;
            this.layoutControlItem2.Location = new System.Drawing.Point(151, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(643, 24);
            this.layoutControlItem2.Text = "Medicine Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(667, 150);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(64, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(731, 150);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(63, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(151, 150);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(516, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnAddCategory;
            this.layoutControlItem5.Location = new System.Drawing.Point(698, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(96, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAddManufacturer;
            this.layoutControlItem6.Location = new System.Drawing.Point(698, 50);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(96, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnAddUnit;
            this.layoutControlItem7.Location = new System.Drawing.Point(698, 76);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(96, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(794, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(164, 176);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(151, 176);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 648);
            this.Controls.Add(this.dataLayoutControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMedicine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Medicine";
            this.Load += new System.EventHandler(this.frmMedicine_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMedicine_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMedicineName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrderLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForReOrderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit cmbCategoryName;
        private DevExpress.XtraEditors.LookUpEdit cmbMName;
        private DevExpress.XtraEditors.LookUpEdit cmbUnit;
        private DevExpress.XtraEditors.TextEdit txtReOrderLevel;
        private DevExpress.XtraEditors.TextEdit txtLocation;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCategoryName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUnit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForReOrderLevel;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLocation;
        private DevExpress.XtraGrid.GridControl gcMedicine;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMedicine;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicineID;
        private DevExpress.XtraGrid.Columns.GridColumn colMedicineName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMID;
        private DevExpress.XtraGrid.Columns.GridColumn colMName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitID;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colReOrderLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraEditors.TextEdit txtMedicineName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnAddUnit;
        private DevExpress.XtraEditors.SimpleButton btnAddManufacturer;
        private DevExpress.XtraEditors.SimpleButton btnAddCategory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;

    }
}