namespace CMS
{
    partial class frmBookAppointment
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dtAppointment = new DevExpress.XtraEditors.DateEdit();
            this.cmbDoctor = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAppointment = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblPatientName = new DevExpress.XtraLayout.SimpleLabelItem();
            this.lblAddress = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblAppointmentDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblPatientID = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPatientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAppointmentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPatientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.dtAppointment);
            this.layoutControl1.Controls.Add(this.cmbDoctor);
            this.layoutControl1.Controls.Add(this.btnAppointment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(448, 281);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(357, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 25);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtAppointment
            // 
            this.dtAppointment.EditValue = null;
            this.dtAppointment.EnterMoveNextControl = true;
            this.dtAppointment.Location = new System.Drawing.Point(127, 224);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAppointment.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAppointment.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtAppointment.Properties.Mask.EditMask = "g";
            this.dtAppointment.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtAppointment.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtAppointment.Size = new System.Drawing.Size(317, 24);
            this.dtAppointment.StyleController = this.layoutControl1;
            this.dtAppointment.TabIndex = 2;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.EnterMoveNextControl = true;
            this.cmbDoctor.Location = new System.Drawing.Point(127, 196);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDoctor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DName", "Name1")});
            this.cmbDoctor.Properties.NullText = "";
            this.cmbDoctor.Properties.PopupSizeable = false;
            this.cmbDoctor.Properties.ShowHeader = false;
            this.cmbDoctor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbDoctor.Size = new System.Drawing.Size(317, 24);
            this.cmbDoctor.StyleController = this.layoutControl1;
            this.cmbDoctor.TabIndex = 1;
            // 
            // btnAppointment
            // 
            this.btnAppointment.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAppointment.Location = new System.Drawing.Point(241, 252);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(112, 25);
            this.btnAppointment.StyleController = this.layoutControl1;
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.Text = "Book Appointment";
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblPatientName,
            this.lblAddress,
            this.layoutControlItem1,
            this.lblAppointmentDate,
            this.lblPatientID,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(448, 281);
            this.Root.TextVisible = false;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AllowHotTrack = false;
            this.lblPatientName.Location = new System.Drawing.Point(0, 22);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(444, 22);
            this.lblPatientName.Text = "Name of the Patient: ";
            this.lblPatientName.TextSize = new System.Drawing.Size(120, 18);
            // 
            // lblAddress
            // 
            this.lblAddress.AllowHotTrack = false;
            this.lblAddress.Location = new System.Drawing.Point(0, 44);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(444, 22);
            this.lblAddress.Text = "Address: ";
            this.lblAddress.TextSize = new System.Drawing.Size(120, 18);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbDoctor;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(444, 28);
            this.layoutControlItem1.Text = "Select Doctor";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(120, 18);
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.Control = this.dtAppointment;
            this.lblAppointmentDate.Location = new System.Drawing.Point(0, 220);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(444, 28);
            this.lblAppointmentDate.Text = "Date of Appointment";
            this.lblAppointmentDate.TextSize = new System.Drawing.Size(120, 18);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AllowHotTrack = false;
            this.lblPatientID.Location = new System.Drawing.Point(0, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(444, 22);
            this.lblPatientID.Text = "PatientID: ";
            this.lblPatientID.TextSize = new System.Drawing.Size(120, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 66);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(444, 126);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAppointment;
            this.layoutControlItem2.Location = new System.Drawing.Point(237, 248);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(116, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 248);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(237, 29);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(353, 248);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(91, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // frmBookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(448, 281);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBookAppointment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Appointment";
            this.Load += new System.EventHandler(this.frmBookAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPatientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblAppointmentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPatientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit dtAppointment;
        private DevExpress.XtraEditors.LookUpEdit cmbDoctor;
        private DevExpress.XtraLayout.SimpleLabelItem lblPatientID;
        private DevExpress.XtraLayout.SimpleLabelItem lblPatientName;
        private DevExpress.XtraLayout.SimpleLabelItem lblAddress;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lblAppointmentDate;
        private DevExpress.XtraEditors.SimpleButton btnAppointment;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}