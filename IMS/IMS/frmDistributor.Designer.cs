namespace IMS
{
    partial class frmDistributor
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.gcDistributor = new DevExpress.XtraGrid.GridControl();
            this.gvDistributor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDistributorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistributorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGSTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBranchName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDistributorName = new DevExpress.XtraEditors.TextEdit();
            this.txtCPerson = new DevExpress.XtraEditors.TextEdit();
            this.txtEmailID = new DevExpress.XtraEditors.TextEdit();
            this.txtGSTIN = new DevExpress.XtraEditors.TextEdit();
            this.txtMobileNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtBranchName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDistributorName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContactPerson = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmailID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGSTIN = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForMobileNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForBranchName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDistributor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDistributor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistributorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDistributorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmailID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGSTIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobileNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnCancel);
            this.dataLayoutControl1.Controls.Add(this.btnSave);
            this.dataLayoutControl1.Controls.Add(this.txtRemarks);
            this.dataLayoutControl1.Controls.Add(this.txtAddress);
            this.dataLayoutControl1.Controls.Add(this.gcDistributor);
            this.dataLayoutControl1.Controls.Add(this.txtDistributorName);
            this.dataLayoutControl1.Controls.Add(this.txtCPerson);
            this.dataLayoutControl1.Controls.Add(this.txtEmailID);
            this.dataLayoutControl1.Controls.Add(this.txtGSTIN);
            this.dataLayoutControl1.Controls.Add(this.txtMobileNumber);
            this.dataLayoutControl1.Controls.Add(this.txtBranchName);
            this.dataLayoutControl1.DataMember = "Distributor";
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(865, 421, 450, 400);
            this.dataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(956, 614);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(875, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 22);
            this.btnCancel.StyleController = this.dataLayoutControl1;
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(803, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 22);
            this.btnSave.StyleController = this.dataLayoutControl1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.EnterMoveNextControl = true;
            this.txtRemarks.Location = new System.Drawing.Point(656, 77);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(288, 49);
            this.txtRemarks.StyleController = this.dataLayoutControl1;
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.Tag = "Remarks";
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(656, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(288, 61);
            this.txtAddress.StyleController = this.dataLayoutControl1;
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Tag = "Address";
            // 
            // gcDistributor
            // 
            this.gcDistributor.DataMember = "P_Get_Distributor";
            this.gcDistributor.Location = new System.Drawing.Point(12, 156);
            this.gcDistributor.MainView = this.gvDistributor;
            this.gcDistributor.Name = "gcDistributor";
            this.gcDistributor.Size = new System.Drawing.Size(932, 446);
            this.gcDistributor.TabIndex = 14;
            this.gcDistributor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDistributor});
            this.gcDistributor.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gcDistributor_ProcessGridKey);
            // 
            // gvDistributor
            // 
            this.gvDistributor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDistributorID,
            this.colDistributorName,
            this.colContactPerson,
            this.colEmailID,
            this.colGSTIN,
            this.colMobileNumber,
            this.colBranchName,
            this.colBAddress,
            this.colRemarks,
            this.colCreatedBy,
            this.colCreatedDate});
            this.gvDistributor.GridControl = this.gcDistributor;
            this.gvDistributor.Name = "gvDistributor";
            this.gvDistributor.OptionsBehavior.Editable = false;
            this.gvDistributor.DoubleClick += new System.EventHandler(this.gvDistributor_DoubleClick);
            // 
            // colDistributorID
            // 
            this.colDistributorID.FieldName = "DistributorID";
            this.colDistributorID.Name = "colDistributorID";
            // 
            // colDistributorName
            // 
            this.colDistributorName.Caption = "Name";
            this.colDistributorName.FieldName = "DistributorName";
            this.colDistributorName.Name = "colDistributorName";
            this.colDistributorName.Visible = true;
            this.colDistributorName.VisibleIndex = 0;
            // 
            // colContactPerson
            // 
            this.colContactPerson.FieldName = "ContactPerson";
            this.colContactPerson.Name = "colContactPerson";
            this.colContactPerson.Visible = true;
            this.colContactPerson.VisibleIndex = 1;
            // 
            // colEmailID
            // 
            this.colEmailID.FieldName = "EmailID";
            this.colEmailID.Name = "colEmailID";
            this.colEmailID.Visible = true;
            this.colEmailID.VisibleIndex = 2;
            // 
            // colGSTIN
            // 
            this.colGSTIN.FieldName = "GSTIN";
            this.colGSTIN.Name = "colGSTIN";
            this.colGSTIN.Visible = true;
            this.colGSTIN.VisibleIndex = 3;
            // 
            // colMobileNumber
            // 
            this.colMobileNumber.FieldName = "MobileNumber";
            this.colMobileNumber.Name = "colMobileNumber";
            this.colMobileNumber.Visible = true;
            this.colMobileNumber.VisibleIndex = 4;
            // 
            // colBranchName
            // 
            this.colBranchName.FieldName = "BranchName";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.Visible = true;
            this.colBranchName.VisibleIndex = 5;
            // 
            // colBAddress
            // 
            this.colBAddress.Caption = "Address";
            this.colBAddress.FieldName = "BAddress";
            this.colBAddress.Name = "colBAddress";
            this.colBAddress.Visible = true;
            this.colBAddress.VisibleIndex = 6;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 7;
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
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 8;
            // 
            // txtDistributorName
            // 
            this.txtDistributorName.EnterMoveNextControl = true;
            this.txtDistributorName.Location = new System.Drawing.Point(95, 12);
            this.txtDistributorName.Name = "txtDistributorName";
            this.txtDistributorName.Size = new System.Drawing.Size(474, 20);
            this.txtDistributorName.StyleController = this.dataLayoutControl1;
            this.txtDistributorName.TabIndex = 4;
            this.txtDistributorName.Tag = "Name";
            // 
            // txtCPerson
            // 
            this.txtCPerson.EnterMoveNextControl = true;
            this.txtCPerson.Location = new System.Drawing.Point(95, 36);
            this.txtCPerson.Name = "txtCPerson";
            this.txtCPerson.Size = new System.Drawing.Size(474, 20);
            this.txtCPerson.StyleController = this.dataLayoutControl1;
            this.txtCPerson.TabIndex = 5;
            this.txtCPerson.Tag = "Contact Person";
            // 
            // txtEmailID
            // 
            this.txtEmailID.EnterMoveNextControl = true;
            this.txtEmailID.Location = new System.Drawing.Point(95, 60);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(474, 20);
            this.txtEmailID.StyleController = this.dataLayoutControl1;
            this.txtEmailID.TabIndex = 6;
            this.txtEmailID.Tag = "Email ID";
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.EnterMoveNextControl = true;
            this.txtGSTIN.Location = new System.Drawing.Point(95, 84);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.Size = new System.Drawing.Size(474, 20);
            this.txtGSTIN.StyleController = this.dataLayoutControl1;
            this.txtGSTIN.TabIndex = 7;
            this.txtGSTIN.Tag = "GSTIN";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.EnterMoveNextControl = true;
            this.txtMobileNumber.Location = new System.Drawing.Point(95, 108);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(474, 20);
            this.txtMobileNumber.StyleController = this.dataLayoutControl1;
            this.txtMobileNumber.TabIndex = 8;
            this.txtMobileNumber.Tag = "Mobile Number";
            // 
            // txtBranchName
            // 
            this.txtBranchName.EnterMoveNextControl = true;
            this.txtBranchName.Location = new System.Drawing.Point(95, 132);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(474, 20);
            this.txtBranchName.StyleController = this.dataLayoutControl1;
            this.txtBranchName.TabIndex = 9;
            this.txtBranchName.Tag = "Branch Name";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(956, 614);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDistributorName,
            this.ItemForContactPerson,
            this.ItemForEmailID,
            this.ItemForGSTIN,
            this.ItemForMobileNumber,
            this.ItemForBranchName,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(936, 594);
            // 
            // ItemForDistributorName
            // 
            this.ItemForDistributorName.Control = this.txtDistributorName;
            this.ItemForDistributorName.Location = new System.Drawing.Point(0, 0);
            this.ItemForDistributorName.Name = "ItemForDistributorName";
            this.ItemForDistributorName.Size = new System.Drawing.Size(561, 24);
            this.ItemForDistributorName.Text = "Distributor Name";
            this.ItemForDistributorName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForContactPerson
            // 
            this.ItemForContactPerson.Control = this.txtCPerson;
            this.ItemForContactPerson.Location = new System.Drawing.Point(0, 24);
            this.ItemForContactPerson.Name = "ItemForContactPerson";
            this.ItemForContactPerson.Size = new System.Drawing.Size(561, 24);
            this.ItemForContactPerson.Text = "Contact Person";
            this.ItemForContactPerson.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForEmailID
            // 
            this.ItemForEmailID.Control = this.txtEmailID;
            this.ItemForEmailID.Location = new System.Drawing.Point(0, 48);
            this.ItemForEmailID.Name = "ItemForEmailID";
            this.ItemForEmailID.Size = new System.Drawing.Size(561, 24);
            this.ItemForEmailID.Text = "Email ID";
            this.ItemForEmailID.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForGSTIN
            // 
            this.ItemForGSTIN.Control = this.txtGSTIN;
            this.ItemForGSTIN.Location = new System.Drawing.Point(0, 72);
            this.ItemForGSTIN.Name = "ItemForGSTIN";
            this.ItemForGSTIN.Size = new System.Drawing.Size(561, 24);
            this.ItemForGSTIN.Text = "GSTIN";
            this.ItemForGSTIN.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForMobileNumber
            // 
            this.ItemForMobileNumber.Control = this.txtMobileNumber;
            this.ItemForMobileNumber.Location = new System.Drawing.Point(0, 96);
            this.ItemForMobileNumber.Name = "ItemForMobileNumber";
            this.ItemForMobileNumber.Size = new System.Drawing.Size(561, 24);
            this.ItemForMobileNumber.Text = "Mobile Number";
            this.ItemForMobileNumber.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ItemForBranchName
            // 
            this.ItemForBranchName.Control = this.txtBranchName;
            this.ItemForBranchName.Location = new System.Drawing.Point(0, 120);
            this.ItemForBranchName.Name = "ItemForBranchName";
            this.ItemForBranchName.Size = new System.Drawing.Size(561, 24);
            this.ItemForBranchName.Text = "Branch Name";
            this.ItemForBranchName.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDistributor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(936, 450);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtAddress;
            this.layoutControlItem2.Location = new System.Drawing.Point(561, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(375, 65);
            this.layoutControlItem2.Text = "Address";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtRemarks;
            this.layoutControlItem3.Location = new System.Drawing.Point(561, 65);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(375, 53);
            this.layoutControlItem3.Text = "Remarks";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(791, 118);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(72, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(863, 118);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(73, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(561, 118);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(230, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmDistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 614);
            this.Controls.Add(this.dataLayoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDistributor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Distributor";
            this.Load += new System.EventHandler(this.frmDistributor_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDistributor_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDistributor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDistributor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDistributorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDistributorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmailID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGSTIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMobileNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForBranchName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gcDistributor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDistributor;
        private DevExpress.XtraEditors.TextEdit txtDistributorName;
        private DevExpress.XtraEditors.TextEdit txtCPerson;
        private DevExpress.XtraEditors.TextEdit txtEmailID;
        private DevExpress.XtraEditors.TextEdit txtGSTIN;
        private DevExpress.XtraEditors.TextEdit txtMobileNumber;
        private DevExpress.XtraEditors.TextEdit txtBranchName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDistributorName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactPerson;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmailID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGSTIN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForMobileNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForBranchName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributorID;
        private DevExpress.XtraGrid.Columns.GridColumn colDistributorName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colEmailID;
        private DevExpress.XtraGrid.Columns.GridColumn colGSTIN;
        private DevExpress.XtraGrid.Columns.GridColumn colMobileNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colBranchName;
        private DevExpress.XtraGrid.Columns.GridColumn colBAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}