namespace EHR
{
    partial class frmDashBoard
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue5 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue6 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule7 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue7 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule8 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue8 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            this.StateCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtpSelectedDate = new DevExpress.XtraEditors.DateEdit();
            this.gcDashBoard = new DevExpress.XtraGrid.GridControl();
            this.gvDashBoard = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserInfoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gcLogout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGoingforlunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBackFromLunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGoingforbreak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBackfromBreak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTotalSentTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLunchTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBreakTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDashBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // StateCode
            // 
            this.StateCode.Caption = "StateCode";
            this.StateCode.FieldName = "StateCode";
            this.StateCode.Name = "StateCode";
            // 
            // EmployeeStatus
            // 
            this.EmployeeStatus.Caption = "Status";
            this.EmployeeStatus.FieldName = "EmployeeStatus";
            this.EmployeeStatus.Name = "EmployeeStatus";
            this.EmployeeStatus.Visible = true;
            this.EmployeeStatus.VisibleIndex = 2;
            this.EmployeeStatus.Width = 93;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDisabled.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDisabled.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDownHeader.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDropDownHeader.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlFocused.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlFocused.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlReadOnly.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlReadOnly.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.dtpSelectedDate);
            this.layoutControl1.Controls.Add(this.gcDashBoard);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1585, 602, 975, 600);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(943, 649);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtpSelectedDate
            // 
            this.dtpSelectedDate.EditValue = null;
            this.dtpSelectedDate.Location = new System.Drawing.Point(104, 12);
            this.dtpSelectedDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSelectedDate.Name = "dtpSelectedDate";
            this.dtpSelectedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSelectedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSelectedDate.Size = new System.Drawing.Size(175, 22);
            this.dtpSelectedDate.StyleController = this.layoutControl1;
            this.dtpSelectedDate.TabIndex = 4;
            this.dtpSelectedDate.EditValueChanged += new System.EventHandler(this.dtpSelectedDate_EditValueChanged);
            // 
            // gcDashBoard
            // 
            this.gcDashBoard.Location = new System.Drawing.Point(12, 37);
            this.gcDashBoard.MainView = this.gvDashBoard;
            this.gcDashBoard.Name = "gcDashBoard";
            this.gcDashBoard.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dtpDate});
            this.gcDashBoard.Size = new System.Drawing.Size(919, 600);
            this.gcDashBoard.TabIndex = 0;
            this.gcDashBoard.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDashBoard});
            // 
            // gvDashBoard
            // 
            this.gvDashBoard.Appearance.FooterPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.FooterPanel.Options.UseFont = true;
            this.gvDashBoard.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.GroupFooter.Options.UseFont = true;
            this.gvDashBoard.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.GroupPanel.Options.UseFont = true;
            this.gvDashBoard.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.GroupRow.Options.UseFont = true;
            this.gvDashBoard.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvDashBoard.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDashBoard.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvDashBoard.Appearance.Row.Options.UseFont = true;
            this.gvDashBoard.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserInfoID,
            this.UserName,
            this.FullName,
            this.EmployeeStatus,
            this.StateCode,
            this.gcLogin,
            this.gcLogout,
            this.gcGoingforlunch,
            this.gcBackFromLunch,
            this.gcGoingforbreak,
            this.gcBackfromBreak,
            this.gcTotalSentTime,
            this.gcLunchTime,
            this.gcBreakTime});
            gridFormatRule1.Column = this.StateCode;
            gridFormatRule1.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule1.Name = "NotLoggedin";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "1";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.StateCode;
            gridFormatRule2.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule2.Name = "LoggedIn";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "4";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.Column = this.StateCode;
            gridFormatRule3.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule3.Name = "OnLunchBreak";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            formatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = "2";
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.Column = this.StateCode;
            gridFormatRule4.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule4.Name = "OnDayBreak";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.Yellow;
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = "3";
            gridFormatRule4.Rule = formatConditionRuleValue4;
            gridFormatRule5.Column = this.StateCode;
            gridFormatRule5.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule5.Name = "Loggedout";
            formatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.SlateGray;
            formatConditionRuleValue5.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue5.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue5.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = "5";
            gridFormatRule5.Rule = formatConditionRuleValue5;
            gridFormatRule6.Column = this.StateCode;
            gridFormatRule6.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule6.Name = "FullDayLeave";
            formatConditionRuleValue6.Appearance.BackColor = System.Drawing.Color.Teal;
            formatConditionRuleValue6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue6.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue6.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue6.Appearance.Options.UseFont = true;
            formatConditionRuleValue6.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue6.Value1 = "0";
            gridFormatRule6.Rule = formatConditionRuleValue6;
            gridFormatRule7.Column = this.StateCode;
            gridFormatRule7.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule7.Name = "FirstHalfLeave";
            formatConditionRuleValue7.Appearance.BackColor = System.Drawing.Color.Orange;
            formatConditionRuleValue7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue7.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue7.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue7.Appearance.Options.UseFont = true;
            formatConditionRuleValue7.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue7.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue7.Value1 = ((short)(6));
            gridFormatRule7.Rule = formatConditionRuleValue7;
            gridFormatRule8.Column = this.StateCode;
            gridFormatRule8.ColumnApplyTo = this.EmployeeStatus;
            gridFormatRule8.Name = "SecondHalfLeave";
            formatConditionRuleValue8.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            formatConditionRuleValue8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue8.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue8.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue8.Appearance.Options.UseFont = true;
            formatConditionRuleValue8.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue8.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue8.Value1 = ((short)(7));
            gridFormatRule8.Rule = formatConditionRuleValue8;
            this.gvDashBoard.FormatRules.Add(gridFormatRule1);
            this.gvDashBoard.FormatRules.Add(gridFormatRule2);
            this.gvDashBoard.FormatRules.Add(gridFormatRule3);
            this.gvDashBoard.FormatRules.Add(gridFormatRule4);
            this.gvDashBoard.FormatRules.Add(gridFormatRule5);
            this.gvDashBoard.FormatRules.Add(gridFormatRule6);
            this.gvDashBoard.FormatRules.Add(gridFormatRule7);
            this.gvDashBoard.FormatRules.Add(gridFormatRule8);
            this.gvDashBoard.GridControl = this.gcDashBoard;
            this.gvDashBoard.Name = "gvDashBoard";
            this.gvDashBoard.OptionsBehavior.Editable = false;
            this.gvDashBoard.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDashBoard.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvDashBoard.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvDashBoard.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // UserInfoID
            // 
            this.UserInfoID.Caption = "UserInfoID";
            this.UserInfoID.FieldName = "UserInfoID";
            this.UserInfoID.Name = "UserInfoID";
            // 
            // UserName
            // 
            this.UserName.Caption = "EmployeeID";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 0;
            this.UserName.Width = 84;
            // 
            // FullName
            // 
            this.FullName.Caption = "Name";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 1;
            this.FullName.Width = 140;
            // 
            // gcLogin
            // 
            this.gcLogin.Caption = "Log In";
            this.gcLogin.ColumnEdit = this.dtpDate;
            this.gcLogin.FieldName = "DayLogin";
            this.gcLogin.Name = "gcLogin";
            this.gcLogin.Width = 79;
            // 
            // dtpDate
            // 
            this.dtpDate.AutoHeight = false;
            this.dtpDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDate.DisplayFormat.FormatString = "HH:mm:ss";
            this.dtpDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.EditFormat.FormatString = "HH:mm:ss";
            this.dtpDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpDate.Mask.EditMask = "HH:mm:ss";
            this.dtpDate.Name = "dtpDate";
            // 
            // gcLogout
            // 
            this.gcLogout.Caption = "Log Out";
            this.gcLogout.ColumnEdit = this.dtpDate;
            this.gcLogout.FieldName = "DayLogout";
            this.gcLogout.Name = "gcLogout";
            this.gcLogout.Width = 101;
            // 
            // gcGoingforlunch
            // 
            this.gcGoingforlunch.Caption = "Going For Lunch";
            this.gcGoingforlunch.ColumnEdit = this.dtpDate;
            this.gcGoingforlunch.FieldName = "LunchLogin";
            this.gcGoingforlunch.Name = "gcGoingforlunch";
            this.gcGoingforlunch.Width = 79;
            // 
            // gcBackFromLunch
            // 
            this.gcBackFromLunch.Caption = "Back From Lunch";
            this.gcBackFromLunch.ColumnEdit = this.dtpDate;
            this.gcBackFromLunch.FieldName = "LunchLogout";
            this.gcBackFromLunch.Name = "gcBackFromLunch";
            this.gcBackFromLunch.Width = 79;
            // 
            // gcGoingforbreak
            // 
            this.gcGoingforbreak.Caption = "Going For Break";
            this.gcGoingforbreak.ColumnEdit = this.dtpDate;
            this.gcGoingforbreak.FieldName = "BreakLogin";
            this.gcGoingforbreak.Name = "gcGoingforbreak";
            this.gcGoingforbreak.Width = 79;
            // 
            // gcBackfromBreak
            // 
            this.gcBackfromBreak.Caption = "Back From Break";
            this.gcBackfromBreak.ColumnEdit = this.dtpDate;
            this.gcBackfromBreak.FieldName = "BreakLogout";
            this.gcBackfromBreak.Name = "gcBackfromBreak";
            this.gcBackfromBreak.Width = 79;
            // 
            // gcTotalSentTime
            // 
            this.gcTotalSentTime.Caption = "Total Spent Time";
            this.gcTotalSentTime.FieldName = "TodayHours";
            this.gcTotalSentTime.Name = "gcTotalSentTime";
            this.gcTotalSentTime.Width = 96;
            // 
            // gcLunchTime
            // 
            this.gcLunchTime.Caption = "Lunch Time";
            this.gcLunchTime.FieldName = "LunchHours";
            this.gcLunchTime.Name = "gcLunchTime";
            // 
            // gcBreakTime
            // 
            this.gcBreakTime.Caption = "Break Time";
            this.gcBreakTime.FieldName = "BreakHours";
            this.gcBreakTime.Name = "gcBreakTime";
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(943, 649);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcDashBoard;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(923, 604);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpSelectedDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(271, 25);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(271, 25);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(271, 25);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Selected Date";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(80, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(271, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(652, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 649);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmDashBoard";
            this.ShowInTaskbar = false;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDashBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcDashBoard;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDashBoard;
        private DevExpress.XtraGrid.Columns.GridColumn UserInfoID;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeStatus;
        private DevExpress.XtraGrid.Columns.GridColumn StateCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcLogin;
        private DevExpress.XtraGrid.Columns.GridColumn gcLogout;
        private DevExpress.XtraGrid.Columns.GridColumn gcGoingforlunch;
        private DevExpress.XtraGrid.Columns.GridColumn gcBackFromLunch;
        private DevExpress.XtraGrid.Columns.GridColumn gcGoingforbreak;
        private DevExpress.XtraGrid.Columns.GridColumn gcBackfromBreak;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dtpDate;
        private DevExpress.XtraEditors.DateEdit dtpSelectedDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalSentTime;
        private DevExpress.XtraGrid.Columns.GridColumn gcLunchTime;
        private DevExpress.XtraGrid.Columns.GridColumn gcBreakTime;
    }
}