namespace QuoteMaker.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCreateQuote = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnGST = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewQuote = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemList = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnCreateQuote,
            this.btnUsers,
            this.btnCategory,
            this.btnSubCategory,
            this.btnGST,
            this.btnViewQuote,
            this.btnItemList});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1267, 164);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnCreateQuote
            // 
            this.btnCreateQuote.Caption = "Create";
            this.btnCreateQuote.Id = 1;
            this.btnCreateQuote.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateQuote.ImageOptions.SvgImage")));
            this.btnCreateQuote.Name = "btnCreateQuote";
            this.btnCreateQuote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateQuote_ItemClick);
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Users";
            this.btnUsers.Id = 2;
            this.btnUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUsers.ImageOptions.SvgImage")));
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnCategory
            // 
            this.btnCategory.Caption = "Category";
            this.btnCategory.Id = 3;
            this.btnCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCategory.ImageOptions.SvgImage")));
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategory_ItemClick);
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.Caption = "Sub Category";
            this.btnSubCategory.Id = 4;
            this.btnSubCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSubCategory.ImageOptions.SvgImage")));
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubCategory_ItemClick);
            // 
            // btnGST
            // 
            this.btnGST.Caption = "GST";
            this.btnGST.Id = 5;
            this.btnGST.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGST.ImageOptions.SvgImage")));
            this.btnGST.Name = "btnGST";
            this.btnGST.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGST_ItemClick);
            // 
            // btnViewQuote
            // 
            this.btnViewQuote.Caption = "View";
            this.btnViewQuote.Id = 6;
            this.btnViewQuote.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewQuote.ImageOptions.SvgImage")));
            this.btnViewQuote.Name = "btnViewQuote";
            this.btnViewQuote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewQuote_ItemClick);
            // 
            // btnItemList
            // 
            this.btnItemList.Caption = "Item List";
            this.btnItemList.Id = 8;
            this.btnItemList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnItemList.ImageOptions.SvgImage")));
            this.btnItemList.Name = "btnItemList";
            this.btnItemList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemList_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnItemList);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Item";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCreateQuote);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnViewQuote);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quotation";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCategory);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSubCategory);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnGST);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Masters";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 819);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1267, 22);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 841);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.LargeImage = global::QuoteMaker.Properties.Resources.Icon;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quote Maker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnCreateQuote;
        private DevExpress.XtraBars.BarButtonItem btnUsers;
        private DevExpress.XtraBars.BarButtonItem btnCategory;
        private DevExpress.XtraBars.BarButtonItem btnSubCategory;
        private DevExpress.XtraBars.BarButtonItem btnGST;
        private DevExpress.XtraBars.BarButtonItem btnViewQuote;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnItemList;
    }
}