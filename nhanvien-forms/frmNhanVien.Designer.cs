using System.Security.Cryptography.X509Certificates;

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
            this.mnuTaiKhoanTTCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_ThongTIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy_DSNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy_NhanVien_DanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy_NhanVien_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy_CuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_HoaDon_Tao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_HoaDon_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_NhaSX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_SanPham_Them = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_SanPham_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_SanPham_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_SanPham_TonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_SanPham_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_KhachHang_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNang_KhachHang_TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe_DaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe_HDDaTao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnuChucNang,
            this.mnuThongKe,
            this.mnuBaoCao});
            this.mnuNhanVien.Location = new System.Drawing.Point(0, 0);
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(1042, 33);
            this.mnuNhanVien.TabIndex = 2;
            this.mnuNhanVien.Text = "menuStrip1";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoanTTCuaHang,
            this.mnuTK_ThongTIn,
            this.mnuTK_DoiMK,
            this.mnuTK_DangXuat,
            this.mnuTK_Thoat});
            this.mnuTaiKhoan.Image = global::winform_fpt_shop.Properties.Resources.icons8_setting_24;
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(127, 29);
            this.mnuTaiKhoan.Text = "Tài Khoản";
            // 
            // mnuTaiKhoanTTCuaHang
            // 
            this.mnuTaiKhoanTTCuaHang.Image = global::winform_fpt_shop.Properties.Resources.icons8_information_24;
            this.mnuTaiKhoanTTCuaHang.Name = "mnuTaiKhoanTTCuaHang";
            this.mnuTaiKhoanTTCuaHang.Size = new System.Drawing.Size(268, 34);
            this.mnuTaiKhoanTTCuaHang.Text = "Thông tin cửa hàng";
            this.mnuTaiKhoanTTCuaHang.Click += new System.EventHandler(this.mnuTaiKhoanTTCuaHang_Click);
            // 
            // mnuTK_ThongTIn
            // 
            this.mnuTK_ThongTIn.Image = global::winform_fpt_shop.Properties.Resources.icons8_information_24;
            this.mnuTK_ThongTIn.Name = "mnuTK_ThongTIn";
            this.mnuTK_ThongTIn.Size = new System.Drawing.Size(268, 34);
            this.mnuTK_ThongTIn.Text = "Thông tin cá nhân";
            this.mnuTK_ThongTIn.Click += new System.EventHandler(this.mnuTK_ThongTIn_Click);
            // 
            // mnuTK_DoiMK
            // 
            this.mnuTK_DoiMK.Image = global::winform_fpt_shop.Properties.Resources.icons8_password_24;
            this.mnuTK_DoiMK.Name = "mnuTK_DoiMK";
            this.mnuTK_DoiMK.Size = new System.Drawing.Size(268, 34);
            this.mnuTK_DoiMK.Text = "Đổi mật khẩu";
            this.mnuTK_DoiMK.Click += new System.EventHandler(this.mnuTK_DoiMK_Click);
            // 
            // mnuTK_DangXuat
            // 
            this.mnuTK_DangXuat.Image = global::winform_fpt_shop.Properties.Resources.icons8_log_out_24;
            this.mnuTK_DangXuat.Name = "mnuTK_DangXuat";
            this.mnuTK_DangXuat.Size = new System.Drawing.Size(268, 34);
            this.mnuTK_DangXuat.Text = "Đăng xuất";
            this.mnuTK_DangXuat.Click += new System.EventHandler(this.mnuTK_DangXuat_Click);
            // 
            // mnuTK_Thoat
            // 
            this.mnuTK_Thoat.Image = global::winform_fpt_shop.Properties.Resources.icons8_quit_24;
            this.mnuTK_Thoat.Name = "mnuTK_Thoat";
            this.mnuTK_Thoat.Size = new System.Drawing.Size(268, 34);
            this.mnuTK_Thoat.Text = "Thoát";
            this.mnuTK_Thoat.Click += new System.EventHandler(this.mnuTK_Thoat_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy_DSNhanVien,
            this.mnuQuanLy_CuaHang});
            this.mnuQuanLy.Image = global::winform_fpt_shop.Properties.Resources.icons8_lock_24;
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(116, 29);
            this.mnuQuanLy.Text = "Quản Lý";
            // 
            // mnuQuanLy_DSNhanVien
            // 
            this.mnuQuanLy_DSNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy_NhanVien_DanhSach,
            this.mnuQuanLy_NhanVien_TraCuu});
            this.mnuQuanLy_DSNhanVien.Image = global::winform_fpt_shop.Properties.Resources.icons8_staff_24;
            this.mnuQuanLy_DSNhanVien.Name = "mnuQuanLy_DSNhanVien";
            this.mnuQuanLy_DSNhanVien.Size = new System.Drawing.Size(268, 34);
            this.mnuQuanLy_DSNhanVien.Text = "Nhân viên";
            this.mnuQuanLy_DSNhanVien.Click += new System.EventHandler(this.mnuQuanLy_DSNhanVien_Click);
            // 
            // mnuQuanLy_NhanVien_DanhSach
            // 
            this.mnuQuanLy_NhanVien_DanhSach.Image = global::winform_fpt_shop.Properties.Resources.icons8_list_of_thumbnails_24;
            this.mnuQuanLy_NhanVien_DanhSach.Name = "mnuQuanLy_NhanVien_DanhSach";
            this.mnuQuanLy_NhanVien_DanhSach.Size = new System.Drawing.Size(277, 34);
            this.mnuQuanLy_NhanVien_DanhSach.Text = "Danh sách nhân viên";
            this.mnuQuanLy_NhanVien_DanhSach.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // mnuQuanLy_NhanVien_TraCuu
            // 
            this.mnuQuanLy_NhanVien_TraCuu.Image = global::winform_fpt_shop.Properties.Resources.icons8_find_24;
            this.mnuQuanLy_NhanVien_TraCuu.Name = "mnuQuanLy_NhanVien_TraCuu";
            this.mnuQuanLy_NhanVien_TraCuu.Size = new System.Drawing.Size(277, 34);
            this.mnuQuanLy_NhanVien_TraCuu.Text = "Tra cứu nhân viên";
            this.mnuQuanLy_NhanVien_TraCuu.Click += new System.EventHandler(this.mnuQuanLy_NhanVien_TraCuu_Click);
            // 
            // mnuQuanLy_CuaHang
            // 
            this.mnuQuanLy_CuaHang.Image = global::winform_fpt_shop.Properties.Resources.icons8_information_24__1_;
            this.mnuQuanLy_CuaHang.Name = "mnuQuanLy_CuaHang";
            this.mnuQuanLy_CuaHang.Size = new System.Drawing.Size(268, 34);
            this.mnuQuanLy_CuaHang.Text = "Thông tin cửa hàng";
            this.mnuQuanLy_CuaHang.Click += new System.EventHandler(this.mnuQuanLy_CuaHang_Click);
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang_HoaDon,
            this.mnuChucNang_NhaSX,
            this.mnuChucNang_SanPham,
            this.mnuChucNang_KhachHang});
            this.mnuChucNang.Image = global::winform_fpt_shop.Properties.Resources.icons8_list_of_thumbnails_24;
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(140, 29);
            this.mnuChucNang.Text = "Chức Năng";
            // 
            // mnuChucNang_HoaDon
            // 
            this.mnuChucNang_HoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang_HoaDon_Tao,
            this.mnuChucNang_HoaDon_DS});
            this.mnuChucNang_HoaDon.Image = global::winform_fpt_shop.Properties.Resources.icons8_bill_24;
            this.mnuChucNang_HoaDon.Name = "mnuChucNang_HoaDon";
            this.mnuChucNang_HoaDon.Size = new System.Drawing.Size(216, 34);
            this.mnuChucNang_HoaDon.Text = "Hóa đơn";
            // 
            // mnuChucNang_HoaDon_Tao
            // 
            this.mnuChucNang_HoaDon_Tao.Image = global::winform_fpt_shop.Properties.Resources.icons8_new_24;
            this.mnuChucNang_HoaDon_Tao.Name = "mnuChucNang_HoaDon_Tao";
            this.mnuChucNang_HoaDon_Tao.Size = new System.Drawing.Size(240, 34);
            this.mnuChucNang_HoaDon_Tao.Text = "Tạo hóa đơn";
            this.mnuChucNang_HoaDon_Tao.Click += new System.EventHandler(this.mnuChucNang_HoaDon_Tao_Click);
            // 
            // mnuChucNang_HoaDon_DS
            // 
            this.mnuChucNang_HoaDon_DS.Image = global::winform_fpt_shop.Properties.Resources.icons8_list_of_thumbnails_24;
            this.mnuChucNang_HoaDon_DS.Name = "mnuChucNang_HoaDon_DS";
            this.mnuChucNang_HoaDon_DS.Size = new System.Drawing.Size(240, 34);
            this.mnuChucNang_HoaDon_DS.Text = "Hóa đơn đã tạo";
            this.mnuChucNang_HoaDon_DS.Click += new System.EventHandler(this.mnuChucNang_HoaDon_DS_Click);
            // 
            // mnuChucNang_NhaSX
            // 
            this.mnuChucNang_NhaSX.Image = global::winform_fpt_shop.Properties.Resources.icons8_factory_24;
            this.mnuChucNang_NhaSX.Name = "mnuChucNang_NhaSX";
            this.mnuChucNang_NhaSX.Size = new System.Drawing.Size(216, 34);
            this.mnuChucNang_NhaSX.Text = "Nhà sản xuất";
            this.mnuChucNang_NhaSX.Click += new System.EventHandler(this.mnuChucNang_NhaSX_Click);
            // 
            // mnuChucNang_SanPham
            // 
            this.mnuChucNang_SanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang_SanPham_Them,
            this.mnuChucNang_SanPham_DS,
            this.mnuChucNang_SanPham_TraCuu,
            this.mnuChucNang_SanPham_TonKho,
            this.mnuChucNang_SanPham_DanhMuc});
            this.mnuChucNang_SanPham.Image = global::winform_fpt_shop.Properties.Resources.icons8_product_26;
            this.mnuChucNang_SanPham.Name = "mnuChucNang_SanPham";
            this.mnuChucNang_SanPham.Size = new System.Drawing.Size(216, 34);
            this.mnuChucNang_SanPham.Text = "Sản phẩm";
            // 
            // mnuChucNang_SanPham_Them
            // 
            this.mnuChucNang_SanPham_Them.Name = "mnuChucNang_SanPham_Them";
            this.mnuChucNang_SanPham_Them.Size = new System.Drawing.Size(331, 34);
            this.mnuChucNang_SanPham_Them.Text = "Thêm sản phẩm";
            this.mnuChucNang_SanPham_Them.Click += new System.EventHandler(this.mnuChucNang_NhaSX_Them_Click);
            // 
            // mnuChucNang_SanPham_DS
            // 
            this.mnuChucNang_SanPham_DS.Image = global::winform_fpt_shop.Properties.Resources.icons8_list_of_thumbnails_24;
            this.mnuChucNang_SanPham_DS.Name = "mnuChucNang_SanPham_DS";
            this.mnuChucNang_SanPham_DS.Size = new System.Drawing.Size(331, 34);
            this.mnuChucNang_SanPham_DS.Text = "Danh sách sản phẩm";
            this.mnuChucNang_SanPham_DS.Click += new System.EventHandler(this.mnuChucNang_SanPham_DS_Click);
            // 
            // mnuChucNang_SanPham_TraCuu
            // 
            this.mnuChucNang_SanPham_TraCuu.Image = global::winform_fpt_shop.Properties.Resources.icons8_find_24;
            this.mnuChucNang_SanPham_TraCuu.Name = "mnuChucNang_SanPham_TraCuu";
            this.mnuChucNang_SanPham_TraCuu.Size = new System.Drawing.Size(331, 34);
            this.mnuChucNang_SanPham_TraCuu.Text = "Tra cứu thông tin sản phẩm";
            this.mnuChucNang_SanPham_TraCuu.Click += new System.EventHandler(this.mnuChucNang_SanPham_TraCuu_Click);
            // 
            // mnuChucNang_SanPham_TonKho
            // 
            this.mnuChucNang_SanPham_TonKho.Image = global::winform_fpt_shop.Properties.Resources.icons8_product_24;
            this.mnuChucNang_SanPham_TonKho.Name = "mnuChucNang_SanPham_TonKho";
            this.mnuChucNang_SanPham_TonKho.Size = new System.Drawing.Size(331, 34);
            this.mnuChucNang_SanPham_TonKho.Text = "Sản phẩm tồn kho";
            this.mnuChucNang_SanPham_TonKho.Click += new System.EventHandler(this.mnuChucNang_SanPham_TonKho_Click);
            // 
            // mnuChucNang_SanPham_DanhMuc
            // 
            this.mnuChucNang_SanPham_DanhMuc.Image = global::winform_fpt_shop.Properties.Resources.icons8_tag_24;
            this.mnuChucNang_SanPham_DanhMuc.Name = "mnuChucNang_SanPham_DanhMuc";
            this.mnuChucNang_SanPham_DanhMuc.Size = new System.Drawing.Size(331, 34);
            this.mnuChucNang_SanPham_DanhMuc.Text = "Danh mục ";
            this.mnuChucNang_SanPham_DanhMuc.Click += new System.EventHandler(this.mnuChucNang_SanPham_DanhMuc_Click);
            // 
            // mnuChucNang_KhachHang
            // 
            this.mnuChucNang_KhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang_KhachHang_DS,
            this.mnuChucNang_KhachHang_TraCuu});
            this.mnuChucNang_KhachHang.Image = global::winform_fpt_shop.Properties.Resources.icons8_staff_24;
            this.mnuChucNang_KhachHang.Name = "mnuChucNang_KhachHang";
            this.mnuChucNang_KhachHang.Size = new System.Drawing.Size(216, 34);
            this.mnuChucNang_KhachHang.Text = "Khách hàng";
            // 
            // mnuChucNang_KhachHang_DS
            // 
            this.mnuChucNang_KhachHang_DS.Image = global::winform_fpt_shop.Properties.Resources.icons8_list_of_thumbnails_24;
            this.mnuChucNang_KhachHang_DS.Name = "mnuChucNang_KhachHang_DS";
            this.mnuChucNang_KhachHang_DS.Size = new System.Drawing.Size(196, 34);
            this.mnuChucNang_KhachHang_DS.Text = "Danh sách";
            this.mnuChucNang_KhachHang_DS.Click += new System.EventHandler(this.mnuChucNang_KhachHang_DS_Click);
            // 
            // mnuChucNang_KhachHang_TraCuu
            // 
            this.mnuChucNang_KhachHang_TraCuu.Image = global::winform_fpt_shop.Properties.Resources.icons8_find_24;
            this.mnuChucNang_KhachHang_TraCuu.Name = "mnuChucNang_KhachHang_TraCuu";
            this.mnuChucNang_KhachHang_TraCuu.Size = new System.Drawing.Size(196, 34);
            this.mnuChucNang_KhachHang_TraCuu.Text = "Tra cứu ";
            this.mnuChucNang_KhachHang_TraCuu.Click += new System.EventHandler(this.mnuChucNang_KhachHang_TraCuu_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKe_DaBan,
            this.mnuThongKe_HDDaTao});
            this.mnuThongKe.Image = global::winform_fpt_shop.Properties.Resources.icons8_chart_24;
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(126, 29);
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
            this.mnuBaoCao.Image = global::winform_fpt_shop.Properties.Resources.icons8_report_24;
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(115, 29);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 562);
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

        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_ThongTIn;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_DoiMK;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuTK_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy_DSNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy_NhanVien_DanhSach;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy_NhanVien_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy_CuaHang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_HoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_HoaDon_Tao;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_HoaDon_DS;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_NhaSX;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_SanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_SanPham_Them;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_SanPham_DS;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_SanPham_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_SanPham_TonKho;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_SanPham_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_KhachHang_DS;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang_KhachHang_TraCuu;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe_DaBan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe_HDDaTao;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.MenuStrip mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoanTTCuaHang;

        public object getMenu()
        {
            return this.mnuNhanVien; 
        }
    }
}

