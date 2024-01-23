namespace IMS
{
    partial class frmOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrganization));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ContactNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GSTINTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.HnoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StreetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DistrictTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CountryTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PinCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForContactNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGSTIN = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHno = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStreet = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDistrict = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCountry = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPinCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSTINTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HnoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistrictTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGSTIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDistrict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPinCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnSave);
            this.dataLayoutControl1.Controls.Add(this.btnBrowse);
            this.dataLayoutControl1.Controls.Add(this.pictureEdit1);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ContactNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GSTINTextEdit);
            this.dataLayoutControl1.Controls.Add(this.HnoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StreetTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DistrictTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CountryTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PinCodeTextEdit);
            this.dataLayoutControl1.DataMember = "P_Get_Organization";
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(647, 216);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(484, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 22);
            this.btnSave.StyleController = this.dataLayoutControl1;
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(484, 156);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(151, 22);
            this.btnBrowse.StyleController = this.dataLayoutControl1;
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Location = new System.Drawing.Point(484, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(151, 140);
            this.pictureEdit1.StyleController = this.dataLayoutControl1;
            this.pictureEdit1.TabIndex = 12;
            this.pictureEdit1.Tag = "Icon";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.EnterMoveNextControl = true;
            this.NameTextEdit.Location = new System.Drawing.Point(93, 12);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(387, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 1;
            this.NameTextEdit.Tag = "Name";
            // 
            // ContactNumberTextEdit
            // 
            this.ContactNumberTextEdit.EnterMoveNextControl = true;
            this.ContactNumberTextEdit.Location = new System.Drawing.Point(93, 36);
            this.ContactNumberTextEdit.Name = "ContactNumberTextEdit";
            this.ContactNumberTextEdit.Size = new System.Drawing.Size(387, 20);
            this.ContactNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.ContactNumberTextEdit.TabIndex = 2;
            this.ContactNumberTextEdit.Tag = "Contact Number";
            // 
            // GSTINTextEdit
            // 
            this.GSTINTextEdit.EnterMoveNextControl = true;
            this.GSTINTextEdit.Location = new System.Drawing.Point(93, 60);
            this.GSTINTextEdit.Name = "GSTINTextEdit";
            this.GSTINTextEdit.Size = new System.Drawing.Size(387, 20);
            this.GSTINTextEdit.StyleController = this.dataLayoutControl1;
            this.GSTINTextEdit.TabIndex = 3;
            this.GSTINTextEdit.Tag = "GSTIN";
            // 
            // HnoTextEdit
            // 
            this.HnoTextEdit.EnterMoveNextControl = true;
            this.HnoTextEdit.Location = new System.Drawing.Point(93, 84);
            this.HnoTextEdit.Name = "HnoTextEdit";
            this.HnoTextEdit.Size = new System.Drawing.Size(387, 20);
            this.HnoTextEdit.StyleController = this.dataLayoutControl1;
            this.HnoTextEdit.TabIndex = 4;
            this.HnoTextEdit.Tag = "H No";
            // 
            // StreetTextEdit
            // 
            this.StreetTextEdit.EnterMoveNextControl = true;
            this.StreetTextEdit.Location = new System.Drawing.Point(93, 108);
            this.StreetTextEdit.Name = "StreetTextEdit";
            this.StreetTextEdit.Size = new System.Drawing.Size(387, 20);
            this.StreetTextEdit.StyleController = this.dataLayoutControl1;
            this.StreetTextEdit.TabIndex = 5;
            this.StreetTextEdit.Tag = "Street";
            // 
            // CityTextEdit
            // 
            this.CityTextEdit.EnterMoveNextControl = true;
            this.CityTextEdit.Location = new System.Drawing.Point(93, 132);
            this.CityTextEdit.Name = "CityTextEdit";
            this.CityTextEdit.Size = new System.Drawing.Size(387, 20);
            this.CityTextEdit.StyleController = this.dataLayoutControl1;
            this.CityTextEdit.TabIndex = 6;
            this.CityTextEdit.Tag = "City";
            // 
            // DistrictTextEdit
            // 
            this.DistrictTextEdit.EnterMoveNextControl = true;
            this.DistrictTextEdit.Location = new System.Drawing.Point(93, 156);
            this.DistrictTextEdit.Name = "DistrictTextEdit";
            this.DistrictTextEdit.Size = new System.Drawing.Size(150, 20);
            this.DistrictTextEdit.StyleController = this.dataLayoutControl1;
            this.DistrictTextEdit.TabIndex = 7;
            this.DistrictTextEdit.Tag = "District";
            // 
            // StateTextEdit
            // 
            this.StateTextEdit.EnterMoveNextControl = true;
            this.StateTextEdit.Location = new System.Drawing.Point(328, 156);
            this.StateTextEdit.Name = "StateTextEdit";
            this.StateTextEdit.Size = new System.Drawing.Size(152, 20);
            this.StateTextEdit.StyleController = this.dataLayoutControl1;
            this.StateTextEdit.TabIndex = 8;
            this.StateTextEdit.Tag = "State";
            // 
            // CountryTextEdit
            // 
            this.CountryTextEdit.EnterMoveNextControl = true;
            this.CountryTextEdit.Location = new System.Drawing.Point(93, 182);
            this.CountryTextEdit.Name = "CountryTextEdit";
            this.CountryTextEdit.Size = new System.Drawing.Size(150, 20);
            this.CountryTextEdit.StyleController = this.dataLayoutControl1;
            this.CountryTextEdit.TabIndex = 9;
            this.CountryTextEdit.Tag = "Country";
            // 
            // PinCodeTextEdit
            // 
            this.PinCodeTextEdit.EnterMoveNextControl = true;
            this.PinCodeTextEdit.Location = new System.Drawing.Point(328, 182);
            this.PinCodeTextEdit.Name = "PinCodeTextEdit";
            this.PinCodeTextEdit.Size = new System.Drawing.Size(152, 20);
            this.PinCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.PinCodeTextEdit.TabIndex = 10;
            this.PinCodeTextEdit.Tag = "Pin Code";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(647, 216);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForContactNumber,
            this.ItemForGSTIN,
            this.ItemForHno,
            this.ItemForStreet,
            this.ItemForCity,
            this.ItemForDistrict,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForState,
            this.ItemForCountry,
            this.ItemForPinCode,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(627, 196);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(472, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForContactNumber
            // 
            this.ItemForContactNumber.Control = this.ContactNumberTextEdit;
            this.ItemForContactNumber.Location = new System.Drawing.Point(0, 24);
            this.ItemForContactNumber.Name = "ItemForContactNumber";
            this.ItemForContactNumber.Size = new System.Drawing.Size(472, 24);
            this.ItemForContactNumber.Text = "Contact Number";
            this.ItemForContactNumber.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForGSTIN
            // 
            this.ItemForGSTIN.Control = this.GSTINTextEdit;
            this.ItemForGSTIN.Location = new System.Drawing.Point(0, 48);
            this.ItemForGSTIN.Name = "ItemForGSTIN";
            this.ItemForGSTIN.Size = new System.Drawing.Size(472, 24);
            this.ItemForGSTIN.Text = "GSTIN";
            this.ItemForGSTIN.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForHno
            // 
            this.ItemForHno.Control = this.HnoTextEdit;
            this.ItemForHno.Location = new System.Drawing.Point(0, 72);
            this.ItemForHno.Name = "ItemForHno";
            this.ItemForHno.Size = new System.Drawing.Size(472, 24);
            this.ItemForHno.Text = "Hno";
            this.ItemForHno.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForStreet
            // 
            this.ItemForStreet.Control = this.StreetTextEdit;
            this.ItemForStreet.Location = new System.Drawing.Point(0, 96);
            this.ItemForStreet.Name = "ItemForStreet";
            this.ItemForStreet.Size = new System.Drawing.Size(472, 24);
            this.ItemForStreet.Text = "Street";
            this.ItemForStreet.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForCity
            // 
            this.ItemForCity.Control = this.CityTextEdit;
            this.ItemForCity.Location = new System.Drawing.Point(0, 120);
            this.ItemForCity.Name = "ItemForCity";
            this.ItemForCity.Size = new System.Drawing.Size(472, 24);
            this.ItemForCity.Text = "City";
            this.ItemForCity.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForDistrict
            // 
            this.ItemForDistrict.Control = this.DistrictTextEdit;
            this.ItemForDistrict.Location = new System.Drawing.Point(0, 144);
            this.ItemForDistrict.Name = "ItemForDistrict";
            this.ItemForDistrict.Size = new System.Drawing.Size(235, 26);
            this.ItemForDistrict.Text = "District";
            this.ItemForDistrict.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(472, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(155, 144);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnBrowse;
            this.layoutControlItem2.Location = new System.Drawing.Point(472, 144);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ItemForState
            // 
            this.ItemForState.Control = this.StateTextEdit;
            this.ItemForState.Location = new System.Drawing.Point(235, 144);
            this.ItemForState.Name = "ItemForState";
            this.ItemForState.Size = new System.Drawing.Size(237, 26);
            this.ItemForState.Text = "State";
            this.ItemForState.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForCountry
            // 
            this.ItemForCountry.Control = this.CountryTextEdit;
            this.ItemForCountry.Location = new System.Drawing.Point(0, 170);
            this.ItemForCountry.Name = "ItemForCountry";
            this.ItemForCountry.Size = new System.Drawing.Size(235, 26);
            this.ItemForCountry.Text = "Country";
            this.ItemForCountry.TextSize = new System.Drawing.Size(78, 13);
            // 
            // ItemForPinCode
            // 
            this.ItemForPinCode.Control = this.PinCodeTextEdit;
            this.ItemForPinCode.Location = new System.Drawing.Point(235, 170);
            this.ItemForPinCode.Name = "ItemForPinCode";
            this.ItemForPinCode.Size = new System.Drawing.Size(237, 26);
            this.ItemForPinCode.Text = "Pin Code";
            this.ItemForPinCode.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(472, 170);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 216);
            this.Controls.Add(this.dataLayoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organization";
            this.Load += new System.EventHandler(this.frmOrganization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GSTINTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HnoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StreetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistrictTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PinCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForContactNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGSTIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDistrict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPinCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit ContactNumberTextEdit;
        private DevExpress.XtraEditors.TextEdit GSTINTextEdit;
        private DevExpress.XtraEditors.TextEdit HnoTextEdit;
        private DevExpress.XtraEditors.TextEdit StreetTextEdit;
        private DevExpress.XtraEditors.TextEdit CityTextEdit;
        private DevExpress.XtraEditors.TextEdit DistrictTextEdit;
        private DevExpress.XtraEditors.TextEdit StateTextEdit;
        private DevExpress.XtraEditors.TextEdit CountryTextEdit;
        private DevExpress.XtraEditors.TextEdit PinCodeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForContactNumber;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGSTIN;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHno;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStreet;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDistrict;
        private DevExpress.XtraLayout.LayoutControlItem ItemForState;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCountry;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPinCode;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}