namespace EHR
{
    partial class frmLookupSettings
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtCompOffExpiryDay = new DevExpress.XtraEditors.TextEdit();
            this.txtLeaveBalanceDay = new DevExpress.XtraEditors.TextEdit();
            this.txtJobRunTime = new DevExpress.XtraEditors.TextEdit();
            this.txtReminderDays = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcReminderDays = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompOffExpiryDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeaveBalanceDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobRunTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReminderDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcReminderDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtCompOffExpiryDay);
            this.layoutControl1.Controls.Add(this.txtLeaveBalanceDay);
            this.layoutControl1.Controls.Add(this.txtJobRunTime);
            this.layoutControl1.Controls.Add(this.txtReminderDays);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(506, 295);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(376, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 22);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCompOffExpiryDay
            // 
            this.txtCompOffExpiryDay.EnterMoveNextControl = true;
            this.txtCompOffExpiryDay.Location = new System.Drawing.Point(20, 100);
            this.txtCompOffExpiryDay.Name = "txtCompOffExpiryDay";
            this.txtCompOffExpiryDay.Properties.BeepOnError = false;
            this.txtCompOffExpiryDay.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtCompOffExpiryDay.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtCompOffExpiryDay.Properties.MaskSettings.Set("mask", "n0");
            this.txtCompOffExpiryDay.Size = new System.Drawing.Size(466, 22);
            this.txtCompOffExpiryDay.StyleController = this.layoutControl1;
            this.txtCompOffExpiryDay.TabIndex = 2;
            // 
            // txtLeaveBalanceDay
            // 
            this.txtLeaveBalanceDay.EnterMoveNextControl = true;
            this.txtLeaveBalanceDay.Location = new System.Drawing.Point(20, 222);
            this.txtLeaveBalanceDay.Name = "txtLeaveBalanceDay";
            this.txtLeaveBalanceDay.Properties.BeepOnError = false;
            this.txtLeaveBalanceDay.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtLeaveBalanceDay.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtLeaveBalanceDay.Properties.MaskSettings.Set("mask", "n0");
            this.txtLeaveBalanceDay.Size = new System.Drawing.Size(466, 22);
            this.txtLeaveBalanceDay.StyleController = this.layoutControl1;
            this.txtLeaveBalanceDay.TabIndex = 4;
            // 
            // txtJobRunTime
            // 
            this.txtJobRunTime.EnterMoveNextControl = true;
            this.txtJobRunTime.Location = new System.Drawing.Point(20, 161);
            this.txtJobRunTime.Name = "txtJobRunTime";
            this.txtJobRunTime.Size = new System.Drawing.Size(466, 22);
            this.txtJobRunTime.StyleController = this.layoutControl1;
            this.txtJobRunTime.TabIndex = 3;
            // 
            // txtReminderDays
            // 
            this.txtReminderDays.EnterMoveNextControl = true;
            this.txtReminderDays.Location = new System.Drawing.Point(20, 39);
            this.txtReminderDays.Name = "txtReminderDays";
            this.txtReminderDays.Properties.BeepOnError = false;
            this.txtReminderDays.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtReminderDays.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtReminderDays.Properties.MaskSettings.Set("mask", "n0");
            this.txtReminderDays.Size = new System.Drawing.Size(466, 22);
            this.txtReminderDays.StyleController = this.layoutControl1;
            this.txtReminderDays.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcReminderDays,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(506, 295);
            this.Root.TextVisible = false;
            // 
            // lcReminderDays
            // 
            this.lcReminderDays.Control = this.txtReminderDays;
            this.lcReminderDays.Location = new System.Drawing.Point(0, 0);
            this.lcReminderDays.Name = "lcReminderDays";
            this.lcReminderDays.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.lcReminderDays.Size = new System.Drawing.Size(486, 61);
            this.lcReminderDays.Text = "ReminderDays";
            this.lcReminderDays.TextLocation = DevExpress.Utils.Locations.Top;
            this.lcReminderDays.TextSize = new System.Drawing.Size(137, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 244);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(243, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCompOffExpiryDay;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(486, 61);
            this.layoutControlItem4.Text = "Comp Off Expiry Days";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(137, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtJobRunTime;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(486, 61);
            this.layoutControlItem2.Text = "Jub Run Time";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(137, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtLeaveBalanceDay;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 183);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(486, 61);
            this.layoutControlItem3.Text = "Leave Balance Mail Day";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(137, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnSave;
            this.layoutControlItem5.Location = new System.Drawing.Point(243, 244);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(121, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(364, 244);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(122, 31);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmLookupSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(506, 295);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmLookupSettings";
            this.Text = "Lookup Settings";
            this.Load += new System.EventHandler(this.frmLookupSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCompOffExpiryDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeaveBalanceDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobRunTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReminderDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcReminderDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtCompOffExpiryDay;
        private DevExpress.XtraEditors.TextEdit txtLeaveBalanceDay;
        private DevExpress.XtraEditors.TextEdit txtJobRunTime;
        private DevExpress.XtraEditors.TextEdit txtReminderDays;
        private DevExpress.XtraLayout.LayoutControlItem lcReminderDays;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}