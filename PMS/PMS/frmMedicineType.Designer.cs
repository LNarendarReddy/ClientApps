namespace PMS
{
    partial class frmMedicineType
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
            this.gcMedicineType = new DevExpress.XtraGrid.GridControl();
            this.gvMedicineType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolMedicineTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMedicineType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMedicineType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcMedicineType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(525, 334);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcMedicineType
            // 
            this.gcMedicineType.Location = new System.Drawing.Point(4, 4);
            this.gcMedicineType.MainView = this.gvMedicineType;
            this.gcMedicineType.Name = "gcMedicineType";
            this.gcMedicineType.Size = new System.Drawing.Size(517, 326);
            this.gcMedicineType.TabIndex = 4;
            this.gcMedicineType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMedicineType});
            // 
            // gvMedicineType
            // 
            this.gvMedicineType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolMedicineTypeID,
            this.gcolTypeName,
            this.gcolCreatedBy,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvMedicineType.GridControl = this.gcMedicineType;
            this.gvMedicineType.Name = "gvMedicineType";
            this.gvMedicineType.OptionsNavigation.AutoFocusNewRow = true;
            this.gvMedicineType.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvMedicineType.OptionsView.ShowFooter = true;
            this.gvMedicineType.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvMedicineType_InitNewRow);
            this.gvMedicineType.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvMedicineType_RowUpdated);
            // 
            // gcolMedicineTypeID
            // 
            this.gcolMedicineTypeID.Caption = "gridColumn1";
            this.gcolMedicineTypeID.FieldName = "MedicineTypeID";
            this.gcolMedicineTypeID.Name = "gcolMedicineTypeID";
            // 
            // gcolTypeName
            // 
            this.gcolTypeName.Caption = "Medicine Type";
            this.gcolTypeName.FieldName = "TypeName";
            this.gcolTypeName.Name = "gcolTypeName";
            this.gcolTypeName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TypeName", "Count: {0:n2}")});
            this.gcolTypeName.Visible = true;
            this.gcolTypeName.VisibleIndex = 0;
            // 
            // gcolCreatedBy
            // 
            this.gcolCreatedBy.Caption = "gridColumn3";
            this.gcolCreatedBy.FieldName = "CreatedBy";
            this.gcolCreatedBy.Name = "gcolCreatedBy";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "CreatedDate";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "BranchID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "OrgID";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(525, 334);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcMedicineType;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(521, 330);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmMedicineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 334);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMedicineType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Medicine Type";
            this.Load += new System.EventHandler(this.frmMedicineType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMedicineType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMedicineType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcMedicineType;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMedicineType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMedicineTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn gcolCreatedBy;
    }
}