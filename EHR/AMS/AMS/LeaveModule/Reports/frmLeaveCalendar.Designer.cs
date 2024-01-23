namespace EHR.LeaveModule.Reports
{
    partial class frmLeaveCalendar
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
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule1 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings1 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule2 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings2 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule3 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings3 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule4 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings4 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule5 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue5 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings5 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule6 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue6 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings6 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule7 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue7 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings7 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            DevExpress.XtraPivotGrid.PivotGridFormatRule pivotGridFormatRule8 = new DevExpress.XtraPivotGrid.PivotGridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue8 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings formatRuleTotalTypeSettings8 = new DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings();
            this.fdEmployeeOnLeave = new DevExpress.XtraPivotGrid.PivotGridField();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fdFullName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fdDateField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fdDayNme = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dtpSelectedMonth = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // fdEmployeeOnLeave
            // 
            this.fdEmployeeOnLeave.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fdEmployeeOnLeave.AreaIndex = 0;
            this.fdEmployeeOnLeave.Caption = "Employee On Leave";
            this.fdEmployeeOnLeave.FieldName = "EmployeeOnLeave";
            this.fdEmployeeOnLeave.Name = "fdEmployeeOnLeave";
            this.fdEmployeeOnLeave.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            this.fdEmployeeOnLeave.Width = 54;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.Control.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.Control.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDisabled.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDisabled.Options.UseFont = true;
            this.layoutControl1.Appearance.ControlDropDown.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.layoutControl1.Appearance.ControlDropDown.Options.UseFont = true;
            this.layoutControl1.Controls.Add(this.pivotGridControl1);
            this.layoutControl1.Controls.Add(this.dtpSelectedMonth);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1255, 352, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(913, 604);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.Cell.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.pivotGridControl1.Appearance.Cell.Options.UseFont = true;
            this.pivotGridControl1.Appearance.Cell.Options.UseTextOptions = true;
            this.pivotGridControl1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.DataHeaderArea.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.pivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldHeader.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseTextOptions = true;
            this.pivotGridControl1.Appearance.FieldHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridControl1.Appearance.FieldValue.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.pivotGridControl1.Appearance.FieldValue.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldValue.Options.UseTextOptions = true;
            this.pivotGridControl1.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pivotGridControl1.Appearance.RowHeaderArea.Font = new System.Drawing.Font("Bahnschrift", 8F);
            this.pivotGridControl1.Appearance.RowHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fdFullName,
            this.fdDateField,
            this.fdDayNme,
            this.fdEmployeeOnLeave});
            pivotGridFormatRule1.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule1.Name = "frPaidLeave";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Yellow;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Black;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "P/L";
            pivotGridFormatRule1.Rule = formatConditionRuleValue1;
            pivotGridFormatRule1.Settings = formatRuleTotalTypeSettings1;
            pivotGridFormatRule1.StopIfTrue = true;
            pivotGridFormatRule2.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule2.Name = "frCasualLeave";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Green;
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "C/L";
            pivotGridFormatRule2.Rule = formatConditionRuleValue2;
            pivotGridFormatRule2.Settings = formatRuleTotalTypeSettings2;
            pivotGridFormatRule2.StopIfTrue = true;
            pivotGridFormatRule3.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule3.Name = "frmSickLeave";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue3.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = "S/L";
            pivotGridFormatRule3.Rule = formatConditionRuleValue3;
            pivotGridFormatRule3.Settings = formatRuleTotalTypeSettings3;
            pivotGridFormatRule3.StopIfTrue = true;
            pivotGridFormatRule4.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule4.Name = "frCompensatoryLeave";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.Teal;
            formatConditionRuleValue4.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = "COMP/L";
            pivotGridFormatRule4.Rule = formatConditionRuleValue4;
            pivotGridFormatRule4.Settings = formatRuleTotalTypeSettings4;
            pivotGridFormatRule4.StopIfTrue = true;
            pivotGridFormatRule5.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule5.Name = "frLOP";
            formatConditionRuleValue5.Appearance.BackColor = System.Drawing.Color.Black;
            formatConditionRuleValue5.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue5.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue5.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue5.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue5.Value1 = "LOP";
            pivotGridFormatRule5.Rule = formatConditionRuleValue5;
            pivotGridFormatRule5.Settings = formatRuleTotalTypeSettings5;
            pivotGridFormatRule5.StopIfTrue = true;
            pivotGridFormatRule6.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule6.Name = "frmShiftingLeave";
            formatConditionRuleValue6.Appearance.BackColor = System.Drawing.Color.Blue;
            formatConditionRuleValue6.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue6.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue6.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue6.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue6.Value1 = "SHIF/L";
            pivotGridFormatRule6.Rule = formatConditionRuleValue6;
            pivotGridFormatRule6.Settings = formatRuleTotalTypeSettings6;
            pivotGridFormatRule6.StopIfTrue = true;
            pivotGridFormatRule7.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule7.Name = "frML";
            formatConditionRuleValue7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            formatConditionRuleValue7.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleValue7.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue7.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue7.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue7.Value1 = "M/L";
            pivotGridFormatRule7.Rule = formatConditionRuleValue7;
            pivotGridFormatRule7.Settings = formatRuleTotalTypeSettings7;
            pivotGridFormatRule7.StopIfTrue = true;
            pivotGridFormatRule8.Measure = this.fdEmployeeOnLeave;
            pivotGridFormatRule8.Name = "frPaternityLeave";
            formatConditionRuleValue8.Appearance.BackColor = System.Drawing.Color.DarkOrange;
            formatConditionRuleValue8.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue8.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue8.Value1 = "PAT/L";
            pivotGridFormatRule8.Rule = formatConditionRuleValue8;
            pivotGridFormatRule8.Settings = formatRuleTotalTypeSettings8;
            pivotGridFormatRule8.StopIfTrue = true;
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule1);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule2);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule3);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule4);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule5);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule6);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule7);
            this.pivotGridControl1.FormatRules.Add(pivotGridFormatRule8);
            this.pivotGridControl1.Location = new System.Drawing.Point(4, 30);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterSeparatorBar = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(905, 570);
            this.pivotGridControl1.TabIndex = 5;
            // 
            // fdFullName
            // 
            this.fdFullName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fdFullName.AreaIndex = 0;
            this.fdFullName.Caption = "Employee Name";
            this.fdFullName.FieldName = "FullName";
            this.fdFullName.Name = "fdFullName";
            this.fdFullName.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            this.fdFullName.Width = 206;
            // 
            // fdDateField
            // 
            this.fdDateField.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fdDateField.AreaIndex = 0;
            this.fdDateField.Caption = "Date";
            this.fdDateField.FieldName = "DateField";
            this.fdDateField.Name = "fdDateField";
            this.fdDateField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            this.fdDateField.Width = 54;
            // 
            // fdDayNme
            // 
            this.fdDayNme.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fdDayNme.AreaIndex = 1;
            this.fdDayNme.Caption = "Day";
            this.fdDayNme.FieldName = "DayNme";
            this.fdDayNme.Name = "fdDayNme";
            this.fdDayNme.Width = 54;
            // 
            // dtpSelectedMonth
            // 
            this.dtpSelectedMonth.EditValue = null;
            this.dtpSelectedMonth.Location = new System.Drawing.Point(81, 4);
            this.dtpSelectedMonth.Name = "dtpSelectedMonth";
            this.dtpSelectedMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSelectedMonth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpSelectedMonth.Properties.DisplayFormat.FormatString = "y";
            this.dtpSelectedMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpSelectedMonth.Properties.EditFormat.FormatString = "y";
            this.dtpSelectedMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpSelectedMonth.Properties.Mask.EditMask = "y";
            this.dtpSelectedMonth.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearView;
            this.dtpSelectedMonth.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.dtpSelectedMonth.Size = new System.Drawing.Size(165, 22);
            this.dtpSelectedMonth.StyleController = this.layoutControl1;
            this.dtpSelectedMonth.TabIndex = 4;
            this.dtpSelectedMonth.EditValueChanged += new System.EventHandler(this.dtpSelectedMonth_EditValueChanged);
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
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.Root.Size = new System.Drawing.Size(913, 604);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dtpSelectedMonth;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(246, 26);
            this.layoutControlItem1.Text = "Select Month";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.pivotGridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(909, 574);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(246, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(663, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmLeaveCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmLeaveCalendar";
            this.Text = "Leave Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSelectedMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.DateEdit dtpSelectedMonth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraPivotGrid.PivotGridField fdFullName;
        private DevExpress.XtraPivotGrid.PivotGridField fdDateField;
        private DevExpress.XtraPivotGrid.PivotGridField fdEmployeeOnLeave;
        private DevExpress.XtraPivotGrid.PivotGridField fdDayNme;
    }
}