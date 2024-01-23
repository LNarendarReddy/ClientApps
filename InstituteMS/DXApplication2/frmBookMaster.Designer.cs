namespace InstituteMS
{
    partial class frmBookMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookMaster));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCacnel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAuthorName = new DevExpress.XtraEditors.TextEdit();
            this.txtBookNAme = new DevExpress.XtraEditors.TextEdit();
            this.gcBookMaster = new DevExpress.XtraGrid.GridControl();
            this.gvBookMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrgID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BookName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AuthorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookNAme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBookMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 9F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnCacnel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtAuthorName);
            this.layoutControl1.Controls.Add(this.txtBookNAme);
            this.layoutControl1.Controls.Add(this.gcBookMaster);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(874, 157, 650, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(579, 405);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCacnel
            // 
            this.btnCacnel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCacnel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCacnel.ImageOptions.Image")));
            this.btnCacnel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCacnel.Location = new System.Drawing.Point(497, 64);
            this.btnCacnel.Name = "btnCacnel";
            this.btnCacnel.Size = new System.Drawing.Size(76, 22);
            this.btnCacnel.StyleController = this.layoutControl1;
            this.btnCacnel.TabIndex = 9;
            this.btnCacnel.Text = "Cancel";
            this.btnCacnel.Click += new System.EventHandler(this.btnCacnel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(417, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.EnterMoveNextControl = true;
            this.txtAuthorName.Location = new System.Drawing.Point(82, 30);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAuthorName.Size = new System.Drawing.Size(491, 20);
            this.txtAuthorName.StyleController = this.layoutControl1;
            this.txtAuthorName.TabIndex = 2;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Mandatory";
            this.dxValidationProvider1.SetValidationRule(this.txtAuthorName, conditionValidationRule1);
            // 
            // txtBookNAme
            // 
            this.txtBookNAme.EnterMoveNextControl = true;
            this.txtBookNAme.Location = new System.Drawing.Point(82, 6);
            this.txtBookNAme.Name = "txtBookNAme";
            this.txtBookNAme.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBookNAme.Size = new System.Drawing.Size(491, 20);
            this.txtBookNAme.StyleController = this.layoutControl1;
            this.txtBookNAme.TabIndex = 1;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Mandatory";
            this.dxValidationProvider1.SetValidationRule(this.txtBookNAme, conditionValidationRule2);
            // 
            // gcBookMaster
            // 
            this.gcBookMaster.Location = new System.Drawing.Point(6, 100);
            this.gcBookMaster.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcBookMaster.MainView = this.gvBookMaster;
            this.gcBookMaster.Name = "gcBookMaster";
            this.gcBookMaster.Size = new System.Drawing.Size(567, 299);
            this.gcBookMaster.TabIndex = 5;
            this.gcBookMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBookMaster});
            // 
            // gvBookMaster
            // 
            this.gvBookMaster.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvBookMaster.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvBookMaster.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvBookMaster.Appearance.Row.Options.UseFont = true;
            this.gvBookMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrgID,
            this.BranchID,
            this.BookName,
            this.CategoryID,
            this.AuthorName,
            this.CreatedBy,
            this.CreatedDate});
            this.gvBookMaster.GridControl = this.gcBookMaster;
            this.gvBookMaster.Name = "gvBookMaster";
            this.gvBookMaster.OptionsBehavior.Editable = false;
            this.gvBookMaster.OptionsView.ShowGroupPanel = false;
            // 
            // OrgID
            // 
            this.OrgID.Caption = "OrgID";
            this.OrgID.FieldName = "OrgID";
            this.OrgID.Name = "OrgID";
            // 
            // BranchID
            // 
            this.BranchID.Caption = "BranchID";
            this.BranchID.FieldName = "BranchID";
            this.BranchID.Name = "BranchID";
            // 
            // BookName
            // 
            this.BookName.Caption = "BookName";
            this.BookName.FieldName = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.Visible = true;
            this.BookName.VisibleIndex = 0;
            // 
            // CategoryID
            // 
            this.CategoryID.Caption = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            // 
            // AuthorName
            // 
            this.AuthorName.Caption = "AuthorName";
            this.AuthorName.FieldName = "AuthorName";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Visible = true;
            this.AuthorName.VisibleIndex = 1;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Caption = "CreatedBy";
            this.CreatedBy.FieldName = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Visible = true;
            this.CreatedBy.VisibleIndex = 2;
            // 
            // CreatedDate
            // 
            this.CreatedDate.Caption = "CreatedDate";
            this.CreatedDate.FieldName = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.Visible = true;
            this.CreatedDate.VisibleIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9F);
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(579, 405);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcBookMaster;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 94);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(571, 303);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtBookNAme;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(571, 24);
            this.layoutControlItem2.Text = "Book Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtAuthorName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(571, 24);
            this.layoutControlItem3.Text = "Author Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(411, 58);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCacnel;
            this.layoutControlItem5.Location = new System.Drawing.Point(491, 58);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 58);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(411, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(571, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(571, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmBookMaster
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCacnel;
            this.ClientSize = new System.Drawing.Size(579, 405);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookMaster";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book Master";
            this.Load += new System.EventHandler(this.frmBookMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBookNAme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBookMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBookMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcBookMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBookMaster;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn OrgID;
        private DevExpress.XtraGrid.Columns.GridColumn BranchID;
        private DevExpress.XtraGrid.Columns.GridColumn BookName;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn AuthorName;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn CreatedDate;
        private DevExpress.XtraEditors.TextEdit txtBookNAme;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtAuthorName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnCacnel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}