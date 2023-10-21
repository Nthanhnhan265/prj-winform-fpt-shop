namespace winform_fpt_shop
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_ThongTIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon_Tao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon_HDDaTao = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngTinHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang_DanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKH_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_TonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuThôngTinSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe_DaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe_HDDaTao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuHoaDon,
            this.mnuKhachHang,
            this.mnuSanPham,
            this.mnuThongKe,
            this.mnuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTK_ThongTIn,
            this.mnuTK_DoiMK,
            this.đăngXuấtToolStripMenuItem,
            this.mnuTK_Thoat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(103, 29);
            this.mnuTaiKhoan.Text = "Tài Khoản";
            // 
            // mnuTK_ThongTIn
            // 
            this.mnuTK_ThongTIn.Name = "mnuTK_ThongTIn";
            this.mnuTK_ThongTIn.Size = new System.Drawing.Size(265, 34);
            this.mnuTK_ThongTIn.Text = "Thông Tin Cá Nhân";
            // 
            // mnuTK_DoiMK
            // 
            this.mnuTK_DoiMK.Name = "mnuTK_DoiMK";
            this.mnuTK_DoiMK.Size = new System.Drawing.Size(265, 34);
            this.mnuTK_DoiMK.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(265, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // mnuTK_Thoat
            // 
            this.mnuTK_Thoat.Name = "mnuTK_Thoat";
            this.mnuTK_Thoat.Size = new System.Drawing.Size(265, 34);
            this.mnuTK_Thoat.Text = "Thoát";
            this.mnuTK_Thoat.Click += new System.EventHandler(this.mnuTK_Thoat_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDon_Tao,
            this.mnuHoaDon_HDDaTao,
            this.traCứuThôngTinHóaĐơnToolStripMenuItem});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(100, 29);
            this.mnuHoaDon.Text = "Hóa Đơn";
            // 
            // mnuHoaDon_Tao
            // 
            this.mnuHoaDon_Tao.Name = "mnuHoaDon_Tao";
            this.mnuHoaDon_Tao.Size = new System.Drawing.Size(320, 34);
            this.mnuHoaDon_Tao.Text = "Tạo hóa đơn ";
            this.mnuHoaDon_Tao.Click += new System.EventHandler(this.mnuHoaDon_Tao_Click);
            // 
            // mnuHoaDon_HDDaTao
            // 
            this.mnuHoaDon_HDDaTao.Name = "mnuHoaDon_HDDaTao";
            this.mnuHoaDon_HDDaTao.Size = new System.Drawing.Size(320, 34);
            this.mnuHoaDon_HDDaTao.Text = "Hóa đơn đã tạo";
            this.mnuHoaDon_HDDaTao.Click += new System.EventHandler(this.mnuHoaDon_HDDaTao_Click);
            // 
            // traCứuThôngTinHóaĐơnToolStripMenuItem
            // 
            this.traCứuThôngTinHóaĐơnToolStripMenuItem.Name = "traCứuThôngTinHóaĐơnToolStripMenuItem";
            this.traCứuThôngTinHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(320, 34);
            this.traCứuThôngTinHóaĐơnToolStripMenuItem.Text = "Tra cứu thông tin hóa đơn";
            this.traCứuThôngTinHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.traCứuThôngTinHóaĐơnToolStripMenuItem_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachHang_DanhSach,
            this.mnuKH_TraCuu});
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(123, 29);
            this.mnuKhachHang.Text = "Khách Hàng";
            // 
            // mnuKhachHang_DanhSach
            // 
            this.mnuKhachHang_DanhSach.Name = "mnuKhachHang_DanhSach";
            this.mnuKhachHang_DanhSach.Size = new System.Drawing.Size(292, 34);
            this.mnuKhachHang_DanhSach.Text = "Danh sách khách hàng";
            this.mnuKhachHang_DanhSach.Click += new System.EventHandler(this.mnuKhachHang_DanhSach_Click);
            // 
            // mnuKH_TraCuu
            // 
            this.mnuKH_TraCuu.Name = "mnuKH_TraCuu";
            this.mnuKH_TraCuu.Size = new System.Drawing.Size(292, 34);
            this.mnuKH_TraCuu.Text = "Tra cứu Khách hàng";
            this.mnuKH_TraCuu.Click += new System.EventHandler(this.mnuKH_TraCuu_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham_DS,
            this.mnuSanPham_TonKho,
            this.traCứuThôngTinSảnPhẩmToolStripMenuItem});
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(107, 29);
            this.mnuSanPham.Text = "Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // mnuSanPham_DS
            // 
            this.mnuSanPham_DS.Name = "mnuSanPham_DS";
            this.mnuSanPham_DS.Size = new System.Drawing.Size(331, 34);
            this.mnuSanPham_DS.Text = "Danh sách sản phẩm";
            this.mnuSanPham_DS.Click += new System.EventHandler(this.mnuSanPham_DS_Click);
            // 
            // mnuSanPham_TonKho
            // 
            this.mnuSanPham_TonKho.Name = "mnuSanPham_TonKho";
            this.mnuSanPham_TonKho.Size = new System.Drawing.Size(331, 34);
            this.mnuSanPham_TonKho.Text = "Sản phẩm tồn kho";
            this.mnuSanPham_TonKho.Click += new System.EventHandler(this.mnuSanPham_TonKho_Click);
            // 
            // traCứuThôngTinSảnPhẩmToolStripMenuItem
            // 
            this.traCứuThôngTinSảnPhẩmToolStripMenuItem.Name = "traCứuThôngTinSảnPhẩmToolStripMenuItem";
            this.traCứuThôngTinSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.traCứuThôngTinSảnPhẩmToolStripMenuItem.Text = "Tra cứu thông tin sản phẩm";
            this.traCứuThôngTinSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.traCứuThôngTinSảnPhẩmToolStripMenuItem_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKe_DaBan,
            this.mnuThongKe_HDDaTao});
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(102, 29);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // mnuThongKe_DaBan
            // 
            this.mnuThongKe_DaBan.Name = "mnuThongKe_DaBan";
            this.mnuThongKe_DaBan.Size = new System.Drawing.Size(278, 34);
            this.mnuThongKe_DaBan.Text = "Số sản phẩm đã bán";
            this.mnuThongKe_DaBan.Click += new System.EventHandler(this.mnuThongKe_DaBan_Click);
            // 
            // mnuThongKe_HDDaTao
            // 
            this.mnuThongKe_HDDaTao.Name = "mnuThongKe_HDDaTao";
            this.mnuThongKe_HDDaTao.Size = new System.Drawing.Size(278, 34);
            this.mnuThongKe_HDDaTao.Text = "Hóa đơn đã tạo";
            this.mnuThongKe_HDDaTao.Click += new System.EventHandler(this.mnuThongKe_HDDaTao_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(91, 29);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_DoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_ThongTIn;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_DS;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_TonKho;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon_Tao;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang_DanhSach;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon_HDDaTao;
        private System.Windows.Forms.ToolStripMenuItem mnuKH_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe_DaBan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe_HDDaTao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuThôngTinSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}

