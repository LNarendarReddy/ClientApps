namespace CMS
{
    partial class frmAppointments
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
            this.txtPName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtRegNo = new DevExpress.XtraEditors.TextEdit();
            this.dtAppointment = new DevExpress.XtraEditors.DateEdit();
            this.cmbDoctor = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAppointment = new DevExpress.XtraEditors.SimpleButton();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblAppointmentDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblName = new DevExpress.XtraLayout.LayoutControlItem();
            this.Address = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAppointmentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.txtPName);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.txtRegNo);
            this.layoutControl1.Controls.Add(this.dtAppointment);
            this.layoutControl1.Controls.Add(this.cmbDoctor);
            this.layoutControl1.Controls.Add(this.btnAppointment);
            this.layoutControl1.Controls.Add(this.txtAddress);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(641, 338);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(123, 32);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(514, 24);
            this.txtPName.StyleController = this.layoutControl1;
            this.txtPName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(311, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 25);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(123, 4);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Properties.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_Properties_KeyPress);
            this.txtRegNo.Size = new System.Drawing.Size(514, 24);
            this.txtRegNo.StyleController = this.layoutControl1;
            this.txtRegNo.TabIndex = 1;
            // 
            // dtAppointment
            // 
            this.dtAppointment.EditValue = null;
            this.dtAppointment.EnterMoveNextControl = true;
            this.dtAppointment.Location = new System.Drawing.Point(123, 281);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAppointment.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAppointment.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtAppointment.Properties.Mask.EditMask = "g";
            this.dtAppointment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtAppointment.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtAppointment.Size = new System.Drawing.Size(514, 24);
            this.dtAppointment.StyleController = this.layoutControl1;
            this.dtAppointment.TabIndex = 6;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.EnterMoveNextControl = true;
            this.cmbDoctor.Location = new System.Drawing.Point(123, 253);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDoctor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DName", "Name1")});
            this.cmbDoctor.Properties.NullText = "";
            this.cmbDoctor.Properties.PopupSizeable = false;
            this.cmbDoctor.Properties.ShowHeader = false;
            this.cmbDoctor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbDoctor.Size = new System.Drawing.Size(514, 24);
            this.cmbDoctor.StyleController = this.layoutControl1;
            this.cmbDoctor.TabIndex = 5;
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(479, 309);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(158, 25);
            this.btnAppointment.StyleController = this.layoutControl1;
            this.btnAppointment.TabIndex = 2;
            this.btnAppointment.Text = "Book Appointment";
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(123, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(514, 189);
            this.txtAddress.StyleController = this.layoutControl1;
            this.txtAddress.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lblAppointmentDate,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.lblName,
            this.Address});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(641, 338);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbDoctor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 249);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(637, 28);
            this.layoutControlItem1.Text = "Select Doctor";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(116, 18);
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.Control = this.dtAppointment;
            this.lblAppointmentDate.Location = new System.Drawing.Point(0, 277);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(637, 28);
            this.lblAppointmentDate.Text = "Date of Appointment";
            this.lblAppointmentDate.TextSize = new System.Drawing.Size(116, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAppointment;
            this.layoutControlItem2.Location = new System.Drawing.Point(475, 305);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(162, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 305);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(307, 29);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtRegNo;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(637, 28);
            this.layoutControlItem3.Text = "Patient Reg No";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(116, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(307, 305);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(168, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lblName
            // 
            this.lblName.Control = this.txtPName;
            this.lblName.Location = new System.Drawing.Point(0, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(637, 28);
            this.lblName.Text = "Name";
            this.lblName.TextSize = new System.Drawing.Size(116, 18);
            // 
            // Address
            // 
            this.Address.Control = this.txtAddress;
            this.Address.Location = new System.Drawing.Point(0, 56);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(637, 193);
            this.Address.TextSize = new System.Drawing.Size(116, 18);
            // 
            // frmAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(641, 338);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppointments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Old Booking";
            this.Load += new System.EventHandler(this.frmAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAppointmentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit dtAppointment;
        private DevExpress.XtraEditors.LookUpEdit cmbDoctor;
        private DevExpress.XtraEditors.SimpleButton btnAppointment;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lblAppointmentDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.TextEdit txtRegNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txtPName;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private DevExpress.XtraLayout.LayoutControlItem lblName;
        private DevExpress.XtraLayout.LayoutControlItem Address;
    }
}