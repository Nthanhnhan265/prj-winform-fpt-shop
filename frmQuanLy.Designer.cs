namespace winform_fpt_shop
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_ThongTIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_DoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTK_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaHang_TT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaHang_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan,
            this.mnuCuaHang,
            this.mnuNhanVien,
            this.mnuSanPham,
            this.mnuThongKe,
            this.mnuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTK_ThongTIn,
            this.mnuTK_DoiMK,
            this.mnuTK_Thoat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(87, 24);
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
            // mnuTK_Thoat
            // 
            this.mnuTK_Thoat.Name = "mnuTK_Thoat";
            this.mnuTK_Thoat.Size = new System.Drawing.Size(265, 34);
            this.mnuTK_Thoat.Text = "Thoát";
            this.mnuTK_Thoat.Click += new System.EventHandler(this.mnuTK_Thoat_Click);
            // 
            // mnuCuaHang
            // 
            this.mnuCuaHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCuaHang_TT,
            this.mnuCuaHang_DoanhThu});
            this.mnuCuaHang.Name = "mnuCuaHang";
            this.mnuCuaHang.Size = new System.Drawing.Size(86, 24);
            this.mnuCuaHang.Text = "Cửa hàng";
            // 
            // mnuCuaHang_TT
            // 
            this.mnuCuaHang_TT.Name = "mnuCuaHang_TT";
            this.mnuCuaHang_TT.Size = new System.Drawing.Size(226, 26);
            this.mnuCuaHang_TT.Text = "Thông tin cửa hàng";
            this.mnuCuaHang_TT.Click += new System.EventHandler(this.mnuCuaHang_TT_Click);
            // 
            // mnuCuaHang_DoanhThu
            // 
            this.mnuCuaHang_DoanhThu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemHóaĐơnToolStripMenuItem});
            this.mnuCuaHang_DoanhThu.Name = "mnuCuaHang_DoanhThu";
            this.mnuCuaHang_DoanhThu.Size = new System.Drawing.Size(226, 26);
            this.mnuCuaHang_DoanhThu.Text = "Doanh thu cửa hàng";
            // 
            // xemHóaĐơnToolStripMenuItem
            // 
            this.xemHóaĐơnToolStripMenuItem.Name = "xemHóaĐơnToolStripMenuItem";
            this.xemHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.xemHóaĐơnToolStripMenuItem.Text = "Xem hóa đơn";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien_DS});
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(91, 24);
            this.mnuNhanVien.Text = "Nhân Viên";
            // 
            // mnuNhanVien_DS
            // 
            this.mnuNhanVien_DS.Name = "mnuNhanVien_DS";
            this.mnuNhanVien_DS.Size = new System.Drawing.Size(227, 26);
            this.mnuNhanVien_DS.Text = "Danh sách nhân viên";
            this.mnuNhanVien_DS.Click += new System.EventHandler(this.mnuNhanVien_DS_Click);
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham_DS});
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(88, 24);
            this.mnuSanPham.Text = "Sản Phẩm";
            // 
            // mnuSanPham_DS
            // 
            this.mnuSanPham_DS.Name = "mnuSanPham_DS";
            this.mnuSanPham_DS.Size = new System.Drawing.Size(228, 26);
            this.mnuSanPham_DS.Text = "Danh sách sản phẩm";
            this.mnuSanPham_DS.Click += new System.EventHandler(this.mnuSanPham_DS_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(90, 24);
            this.mnuThongKe.Text = "Thống Kê ";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(79, 24);
            this.mnuBaoCao.Text = "Báo Cáo";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn Hình Quản Lý";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem mnuCuaHang;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaHang_TT;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaHang_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien_DS;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem xemHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham_DS;
    }
}

