namespace EHR.LeaveModule
{
    partial class frmViewCompOff
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
            this.gcCompoff = new DevExpress.XtraGrid.GridControl();
            this.gvCompOff = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcCompoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCompoff
            // 
            this.gcCompoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCompoff.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcCompoff.Location = new System.Drawing.Point(0, 0);
            this.gcCompoff.MainView = this.gvCompOff;
            this.gcCompoff.Margin = new System.Windows.Forms.Padding(2);
            this.gcCompoff.Name = "gcCompoff";
            this.gcCompoff.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gcCompoff.Size = new System.Drawing.Size(1066, 654);
            this.gcCompoff.TabIndex = 0;
            this.gcCompoff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCompOff});
            // 
            // gvCompOff
            // 
            this.gvCompOff.Appearance.FooterPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvCompOff.Appearance.FooterPanel.Options.UseFont = true;
            this.gvCompOff.Appearance.GroupFooter.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvCompOff.Appearance.GroupFooter.Options.UseFont = true;
            this.gvCompOff.Appearance.GroupPanel.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvCompOff.Appearance.GroupPanel.Options.UseFont = true;
            this.gvCompOff.Appearance.GroupRow.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvCompOff.Appearance.GroupRow.Options.UseFont = true;
            this.gvCompOff.Appearance.HeaderPanel.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.gvCompOff.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCompOff.Appearance.Row.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.gvCompOff.Appearance.Row.Options.UseFont = true;
            this.gvCompOff.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gvCompOff.DetailHeight = 239;
            this.gvCompOff.FixedLineWidth = 1;
            this.gvCompOff.GridControl = this.gcCompoff;
            this.gvCompOff.Name = "gvCompOff";
            this.gvCompOff.OptionsBehavior.Editable = false;
            this.gvCompOff.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCompOff.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gvCompOff_PopupMenuShowing);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "CompensatoryLeaveID";
            this.gridColumn1.FieldName = "CompensatoryLeaveID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Worked Date";
            this.gridColumn2.FieldName = "LeaveDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 155;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Reason For Working";
            this.gridColumn3.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn3.FieldName = "LeaveReason";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 325;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Status";
            this.gridColumn4.FieldName = "LeaveStatusName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 126;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Leave Duration";
            this.gridColumn5.FieldName = "LeaveDuration";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 147;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "LeaveDurationID";
            this.gridColumn6.FieldName = "LeaveDurationID";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 50;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Leave Days";
            this.gridColumn7.FieldName = "leavedays";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 76;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "LeaveStatus";
            this.gridColumn8.FieldName = "LeaveStatus";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Availed Days";
            this.gridColumn9.FieldName = "AvailedDays";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 70;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Availed On";
            this.gridColumn10.FieldName = "Availeddate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 149;
            // 
            // frmViewCompOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 654);
            this.Controls.Add(this.gcCompoff);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewCompOff";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Compensatory Leaves";
            this.Load += new System.EventHandler(this.frmViewCompOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCompoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCompOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCompoff;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCompOff;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}