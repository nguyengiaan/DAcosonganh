namespace frmlogin
{
    partial class GiaoDienChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bar_taikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar_danhsachtaikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bar_hoadon = new DevExpress.XtraBars.BarButtonItem();
            this.bar_hanghoa = new DevExpress.XtraBars.BarButtonItem();
            this.bar_sanpham = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pn_ql = new System.Windows.Forms.Panel();
            this.bar_trangchu = new DevExpress.XtraBars.BarButtonItem();
            this.bar_out = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bar_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(111);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bar_taikhoan,
            this.barButtonItem2,
            this.bar_danhsachtaikhoan,
            this.barButtonItem1,
            this.skinRibbonGalleryBarItem1,
            this.bar_hoadon,
            this.bar_hanghoa,
            this.bar_sanpham,
            this.bar_trangchu,
            this.bar_dangxuat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 1257;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.QuickToolbarItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbon.Size = new System.Drawing.Size(1162, 181);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // bar_taikhoan
            // 
            this.bar_taikhoan.Caption = "Tài Khoản";
            this.bar_taikhoan.Id = 1;
            this.bar_taikhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_taikhoan.ImageOptions.Image")));
            this.bar_taikhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_taikhoan.ImageOptions.LargeImage")));
            this.bar_taikhoan.LargeWidth = 80;
            this.bar_taikhoan.Name = "bar_taikhoan";
            this.bar_taikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_taikhoan_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bar_danhsachtaikhoan
            // 
            this.bar_danhsachtaikhoan.Caption = "Danh sách nhân viên";
            this.bar_danhsachtaikhoan.Id = 3;
            this.bar_danhsachtaikhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_danhsachtaikhoan.ImageOptions.Image")));
            this.bar_danhsachtaikhoan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_danhsachtaikhoan.ImageOptions.LargeImage")));
            this.bar_danhsachtaikhoan.LargeWidth = 80;
            this.bar_danhsachtaikhoan.Name = "bar_danhsachtaikhoan";
            this.bar_danhsachtaikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_danhsachtaikhoan_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Khách hàng";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.LargeWidth = 80;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 5;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bar_hoadon
            // 
            this.bar_hoadon.Caption = "Hóa Đơn";
            this.bar_hoadon.Id = 6;
            this.bar_hoadon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_hoadon.ImageOptions.Image")));
            this.bar_hoadon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_hoadon.ImageOptions.LargeImage")));
            this.bar_hoadon.LargeWidth = 80;
            this.bar_hoadon.Name = "bar_hoadon";
            this.bar_hoadon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_hoadon_ItemClick);
            // 
            // bar_hanghoa
            // 
            this.bar_hanghoa.Caption = "Hàng hóa";
            this.bar_hanghoa.Id = 7;
            this.bar_hanghoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_hanghoa.ImageOptions.Image")));
            this.bar_hanghoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_hanghoa.ImageOptions.LargeImage")));
            this.bar_hanghoa.LargeWidth = 80;
            this.bar_hanghoa.Name = "bar_hanghoa";
            this.bar_hanghoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_hanghoa_ItemClick);
            // 
            // bar_sanpham
            // 
            this.bar_sanpham.Caption = "Sản phẩm";
            this.bar_sanpham.Id = 8;
            this.bar_sanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bar_sanpham.ImageOptions.Image")));
            this.bar_sanpham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bar_sanpham.ImageOptions.LargeImage")));
            this.bar_sanpham.LargeWidth = 80;
            this.bar_sanpham.Name = "bar_sanpham";
            this.bar_sanpham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_sanpham_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.bar_out});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang Chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_taikhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_danhsachtaikhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_hoadon);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_hanghoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_sanpham);
            this.ribbonPageGroup1.ItemLinks.Add(this.bar_trangchu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức Năng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 554);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1162, 27);
            // 
            // pn_ql
            // 
            this.pn_ql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ql.Location = new System.Drawing.Point(0, 181);
            this.pn_ql.Name = "pn_ql";
            this.pn_ql.Size = new System.Drawing.Size(1162, 373);
            this.pn_ql.TabIndex = 2;
            // 
            // bar_trangchu
            // 
            this.bar_trangchu.Caption = "Trang chủ";
            this.bar_trangchu.Id = 9;
            this.bar_trangchu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.bar_trangchu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.bar_trangchu.LargeWidth = 80;
            this.bar_trangchu.Name = "bar_trangchu";
            this.bar_trangchu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_trangchu_ItemClick);
            // 
            // bar_out
            // 
            this.bar_out.ItemLinks.Add(this.bar_dangxuat);
            this.bar_out.Name = "bar_out";
            this.bar_out.Text = "Thoát";
            // 
            // bar_dangxuat
            // 
            this.bar_dangxuat.Caption = "Đăng xuất";
            this.bar_dangxuat.Id = 10;
            this.bar_dangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image1")));
            this.bar_dangxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage1")));
            this.bar_dangxuat.Name = "bar_dangxuat";
            this.bar_dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bar_dangxuat_ItemClick);
            // 
            // GiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 581);
            this.Controls.Add(this.pn_ql);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "GiaoDienChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Load += new System.EventHandler(this.GiaoDienChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bar_taikhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.Panel pn_ql;
        private DevExpress.XtraBars.BarButtonItem bar_danhsachtaikhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem bar_hoadon;
        private DevExpress.XtraBars.BarButtonItem bar_hanghoa;
        private DevExpress.XtraBars.BarButtonItem bar_sanpham;
        private DevExpress.XtraBars.BarButtonItem bar_trangchu;
        private DevExpress.XtraBars.BarButtonItem bar_dangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup bar_out;
    }
}