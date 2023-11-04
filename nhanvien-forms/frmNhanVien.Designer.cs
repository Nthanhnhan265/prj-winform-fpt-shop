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
            this.mnuNhanVien = new System.Windows.Forms.MenuStrip();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_ThongTIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon_Tao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon_HDDaTao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaSX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_Them = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_TonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_DanhMuc_Them = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang_DanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKH_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe_DaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe_HDDaTao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy_DSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy_CuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điềuChuyểnNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuNhanVien.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuQuanLy,
            this.mnuHoaDon,
            this.mnuNhaSX,
            this.mnuSanPham,
            this.mnuKhachHang,
            this.mnuThongKe,
            this.mnuBaoCao});
            this.mnuNhanVien.Location = new System.Drawing.Point(0, 0);
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(906, 33);
            this.mnuNhanVien.TabIndex = 2;
            this.mnuNhanVien.Text = "menuStrip1";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTK_ThongTIn,
            this.mnuTK_DoiMK,
            this.mnuTK_DangXuat,
            this.mnuTK_Thoat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(103, 29);
            this.mnuTaiKhoan.Text = "Tài Khoản";
            // 
            // mnuTK_ThongTIn
            // 
            this.mnuTK_ThongTIn.Name = "mnuTK_ThongTIn";
            this.mnuTK_ThongTIn.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_ThongTIn.Text = "Thông Tin Cá Nhân";
            this.mnuTK_ThongTIn.Click += new System.EventHandler(this.mnuTK_ThongTIn_Click);
            // 
            // mnuTK_DoiMK
            // 
            this.mnuTK_DoiMK.Name = "mnuTK_DoiMK";
            this.mnuTK_DoiMK.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_DoiMK.Text = "Đổi mật khẩu";
            this.mnuTK_DoiMK.Click += new System.EventHandler(this.mnuTK_DoiMK_Click);
            // 
            // mnuTK_DangXuat
            // 
            this.mnuTK_DangXuat.Name = "mnuTK_DangXuat";
            this.mnuTK_DangXuat.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_DangXuat.Text = "Đăng xuất";
            this.mnuTK_DangXuat.Click += new System.EventHandler(this.mnuTK_DangXuat_Click);
            // 
            // mnuTK_Thoat
            // 
            this.mnuTK_Thoat.Name = "mnuTK_Thoat";
            this.mnuTK_Thoat.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_Thoat.Text = "Thoát";
            this.mnuTK_Thoat.Click += new System.EventHandler(this.mnuTK_Thoat_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDon_Tao,
            this.mnuHoaDon_HDDaTao});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(100, 29);
            this.mnuHoaDon.Text = "Hóa Đơn";
            // 
            // mnuHoaDon_Tao
            // 
            this.mnuHoaDon_Tao.Name = "mnuHoaDon_Tao";
            this.mnuHoaDon_Tao.Size = new System.Drawing.Size(270, 34);
            this.mnuHoaDon_Tao.Text = "Tạo hóa đơn ";
            this.mnuHoaDon_Tao.Click += new System.EventHandler(this.mnuHoaDon_Tao_Click);
            // 
            // mnuHoaDon_HDDaTao
            // 
            this.mnuHoaDon_HDDaTao.Name = "mnuHoaDon_HDDaTao";
            this.mnuHoaDon_HDDaTao.Size = new System.Drawing.Size(270, 34);
            this.mnuHoaDon_HDDaTao.Text = "Hóa đơn đã tạo";
            this.mnuHoaDon_HDDaTao.Click += new System.EventHandler(this.mnuHoaDon_HDDaTao_Click);
            // 
            // mnuNhaSX
            // 
            this.mnuNhaSX.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhaSanXuat});
            this.mnuNhaSX.Name = "mnuNhaSX";
            this.mnuNhaSX.Size = new System.Drawing.Size(135, 29);
            this.mnuNhaSX.Text = "Nhà Sản Xuất";
            // 
            // mnuNhaSanXuat
            // 
            this.mnuNhaSanXuat.Name = "mnuNhaSanXuat";
            this.mnuNhaSanXuat.Size = new System.Drawing.Size(300, 34);
            this.mnuNhaSanXuat.Text = "Danh sách nhà sản xuất";
            this.mnuNhaSanXuat.Click += new System.EventHandler(this.mnuNhaSanXuat_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham_Them,
            this.mnuSanPham_DS,
            this.mnuSanPham_TraCuu,
            this.mnuSanPham_TonKho,
            this.danhMụcSảnPhẩmToolStripMenuItem});
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(107, 29);
            this.mnuSanPham.Text = "Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // mnuSanPham_Them
            // 
            this.mnuSanPham_Them.Name = "mnuSanPham_Them";
            this.mnuSanPham_Them.Size = new System.Drawing.Size(331, 34);
            this.mnuSanPham_Them.Text = "Thêm sản phẩm";
            this.mnuSanPham_Them.Click += new System.EventHandler(this.mnuSanPham_Them_Click);
            // 
            // mnuSanPham_DS
            // 
            this.mnuSanPham_DS.Name = "mnuSanPham_DS";
            this.mnuSanPham_DS.Size = new System.Drawing.Size(331, 34);
            this.mnuSanPham_DS.Text = "Danh sách sản phẩm";
            this.mnuSanPham_DS.Click += new System.EventHandler(this.mnuSanPham_DS_Click);
            // 
            // mnuSanPham_TraCuu
            // 
            this.mnuSanPham_TraCuu.Name = "mnuSanPham_TraCuu";
            this.mnuSanPham_TraCuu.Size = new System.Drawing.Size(331, 34);
            this.mnuSanPham_TraCuu.Text = "Tra cứu thông tin sản phẩm";
            this.mnuSanPham_TraCuu.Click += new System.EventHandler(this.mnuSanPham_TraCuu_Click);
            // 
            // mnuSanPham_TonKho
            // 
            this.mnuSanPham_TonKho.Name = "mnuSanPham_TonKho";
            this.mnuSanPham_TonKho.Size = new System.Drawing.Size(331, 34);
            this.mnuSanPham_TonKho.Text = "Sản phẩm tồn kho";
            this.mnuSanPham_TonKho.Click += new System.EventHandler(this.mnuSanPham_TonKho_Click);
            // 
            // danhMụcSảnPhẩmToolStripMenuItem
            // 
            this.danhMụcSảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham_DanhMuc_Them});
            this.danhMụcSảnPhẩmToolStripMenuItem.Name = "danhMụcSảnPhẩmToolStripMenuItem";
            this.danhMụcSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(331, 34);
            this.danhMụcSảnPhẩmToolStripMenuItem.Text = "Danh mục sản phẩm";
            // 
            // mnuSanPham_DanhMuc_Them
            // 
            this.mnuSanPham_DanhMuc_Them.Name = "mnuSanPham_DanhMuc_Them";
            this.mnuSanPham_DanhMuc_Them.Size = new System.Drawing.Size(194, 34);
            this.mnuSanPham_DanhMuc_Them.Text = "Thêm mới";
            this.mnuSanPham_DanhMuc_Them.Click += new System.EventHandler(this.mnuSanPham_DanhMuc_Them_Click);
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
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy_DSNhanVien,
            this.mnuQuanLy_CuaHang});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(92, 29);
            this.mnuQuanLy.Text = "Quản Lý";
            // 
            // mnuQuanLy_DSNhanVien
            // 
            this.mnuQuanLy_DSNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem,
            this.traCứuNhânViênToolStripMenuItem,
            this.điềuChuyểnNhânViênToolStripMenuItem});
            this.mnuQuanLy_DSNhanVien.Name = "mnuQuanLy_DSNhanVien";
            this.mnuQuanLy_DSNhanVien.Size = new System.Drawing.Size(270, 34);
            this.mnuQuanLy_DSNhanVien.Text = "Nhân viên";
            this.mnuQuanLy_DSNhanVien.Click += new System.EventHandler(this.mnuQuanLy_DSNhanVien_Click);
            // 
            // mnuQuanLy_CuaHang
            // 
            this.mnuQuanLy_CuaHang.Name = "mnuQuanLy_CuaHang";
            this.mnuQuanLy_CuaHang.Size = new System.Drawing.Size(270, 34);
            this.mnuQuanLy_CuaHang.Text = "Thông tin cửa hàng";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            // 
            // traCứuNhânViênToolStripMenuItem
            // 
            this.traCứuNhânViênToolStripMenuItem.Name = "traCứuNhânViênToolStripMenuItem";
            this.traCứuNhânViênToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.traCứuNhânViênToolStripMenuItem.Text = "Tra cứu nhân viên";
            // 
            // điềuChuyểnNhânViênToolStripMenuItem
            // 
            this.điềuChuyểnNhânViênToolStripMenuItem.Name = "điềuChuyểnNhânViênToolStripMenuItem";
            this.điềuChuyểnNhânViênToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.điềuChuyểnNhânViênToolStripMenuItem.Text = "Điều chuyển nhân viên";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.mnuNhanVien);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuNhanVien;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.mnuNhanVien.ResumeLayout(false);
            this.mnuNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_DoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_ThongTIn;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_DS;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon_Tao;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang_DanhSach;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon_HDDaTao;
        private System.Windows.Forms.ToolStripMenuItem mnuKH_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem danhMụcSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaSX;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaSanXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_DanhMuc_Them;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_Them;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe_DaBan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe_HDDaTao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_TonKho;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy_DSNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy_CuaHang;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điềuChuyểnNhânViênToolStripMenuItem;
    }
}

