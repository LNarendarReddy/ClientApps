namespace IMS
{
    partial class frmConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultation));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnAddService = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.cmbService = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbPatient = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMobileNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientID = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Mobile = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbnamekjkkljfdsa = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnamekjkkljfdsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnAddService);
            this.layoutControl1.Controls.Add(this.txtPrice);
            this.layoutControl1.Controls.Add(this.cmbService);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.cmbPatient);
            this.layoutControl1.Controls.Add(this.txtMobileNumber);
            this.layoutControl1.Controls.Add(this.txtPatientID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1096, 350, 450, 400);
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(646, 232);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnAddService
            // 
            this.btnAddService.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddService.ImageOptions.Image")));
            this.btnAddService.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAddService.Location = new System.Drawing.Point(526, 117);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(54, 22);
            this.btnAddService.StyleController = this.layoutControl1;
            this.btnAddService.TabIndex = 8;
            this.btnAddService.Text = "Add";
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.EnterMoveNextControl = true;
            this.txtPrice.Location = new System.Drawing.Point(116, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(464, 20);
            this.txtPrice.StyleController = this.layoutControl1;
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Tag = "Price";
            // 
            // cmbService
            // 
            this.cmbService.EnterMoveNextControl = true;
            this.cmbService.Location = new System.Drawing.Point(116, 117);
            this.cmbService.Name = "cmbService";
            this.cmbService.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbService.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServiceName", "ServiceName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cost", "Price"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServiceID", "ServiceID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cmbService.Properties.NullText = "[Select]";
            this.cmbService.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbService.Size = new System.Drawing.Size(406, 20);
            this.cmbService.StyleController = this.layoutControl1;
            this.cmbService.TabIndex = 4;
            this.cmbService.Tag = "Service";
            this.cmbService.EditValueChanged += new System.EventHandler(this.cmbService_EditValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(520, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(453, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbPatient
            // 
            this.cmbPatient.EnterMoveNextControl = true;
            this.cmbPatient.Location = new System.Drawing.Point(116, 69);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPatient.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PatientID", "PatientID"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PatientName", "PatientName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MobileNumber", "MobileNumber"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Age", "Age"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Gender", "Gender"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AadhaarNumber", "AadhaarNumber")});
            this.cmbPatient.Properties.NullText = "[Select]";
            this.cmbPatient.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbPatient.Size = new System.Drawing.Size(464, 20);
            this.cmbPatient.StyleController = this.layoutControl1;
            this.cmbPatient.TabIndex = 2;
            this.cmbPatient.Tag = "Patient Name";
            this.cmbPatient.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.cmbPatient_ProcessNewValue);
            this.cmbPatient.EditValueChanged += new System.EventHandler(this.cmbPatient_EditValueChanged);
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.EnterMoveNextControl = true;
            this.txtMobileNumber.Location = new System.Drawing.Point(116, 93);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(464, 20);
            this.txtMobileNumber.StyleController = this.layoutControl1;
            this.txtMobileNumber.TabIndex = 3;
            this.txtMobileNumber.Tag = "Mobile Number";
            // 
            // txtPatientID
            // 
            this.txtPatientID.EnterMoveNextControl = true;
            this.txtPatientID.Location = new System.Drawing.Point(116, 45);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(464, 20);
            this.txtPatientID.StyleController = this.layoutControl1;
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.Tag = "Patient ID";
            this.txtPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientID_KeyPress);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.Mobile,
            this.cmbnamekjkkljfdsa,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem8,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.emptySpaceItem5,
            this.emptySpaceItem4,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(646, 232);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtPatientID;
            this.layoutControlItem1.Location = new System.Drawing.Point(53, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(519, 24);
            this.layoutControlItem1.Text = "Patient ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
            // 
            // Mobile
            // 
            this.Mobile.Control = this.txtMobileNumber;
            this.Mobile.Location = new System.Drawing.Point(53, 81);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(519, 24);
            this.Mobile.TextSize = new System.Drawing.Size(48, 13);
            // 
            // cmbnamekjkkljfdsa
            // 
            this.cmbnamekjkkljfdsa.Control = this.cmbPatient;
            this.cmbnamekjkkljfdsa.Location = new System.Drawing.Point(53, 57);
            this.cmbnamekjkkljfdsa.Name = "cmbnamekjkkljfdsa";
            this.cmbnamekjkkljfdsa.Size = new System.Drawing.Size(519, 24);
            this.cmbnamekjkkljfdsa.Text = "Name";
            this.cmbnamekjkkljfdsa.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(441, 155);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(67, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(508, 155);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(64, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(53, 155);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(388, 26);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbService;
            this.layoutControlItem4.Location = new System.Drawing.Point(53, 105);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(461, 26);
            this.layoutControlItem4.Text = "Service";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(53, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(519, 33);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(53, 181);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(519, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtPrice;
            this.layoutControlItem5.Location = new System.Drawing.Point(53, 131);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(519, 24);
            this.layoutControlItem5.Text = "Price";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(572, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(54, 212);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(53, 212);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnAddService;
            this.layoutControlItem6.Location = new System.Drawing.Point(514, 105);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(58, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 232);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.frmConsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnamekjkkljfdsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPatientID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtMobileNumber;
        private DevExpress.XtraLayout.LayoutControlItem Mobile;
        private DevExpress.XtraEditors.LookUpEdit cmbPatient;
        private DevExpress.XtraLayout.LayoutControlItem cmbnamekjkkljfdsa;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraEditors.LookUpEdit cmbService;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnAddService;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}