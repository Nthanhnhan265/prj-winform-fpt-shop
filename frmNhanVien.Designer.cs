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
            this.mnuTK_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon_Tao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang_DanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_DS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham_TonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon_HDDaTao = new System.Windows.Forms.ToolStripMenuItem();
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
            // 
            // mnuTK_DoiMK
            // 
            this.mnuTK_DoiMK.Name = "mnuTK_DoiMK";
            this.mnuTK_DoiMK.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_DoiMK.Text = "Đổi mật khẩu";
            // 
            // mnuTK_Thoat
            // 
            this.mnuTK_Thoat.Name = "mnuTK_Thoat";
            this.mnuTK_Thoat.Size = new System.Drawing.Size(270, 34);
            this.mnuTK_Thoat.Text = "Thoát";
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
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachHang_DanhSach});
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(123, 29);
            this.mnuKhachHang.Text = "Khách Hàng";
            // 
            // mnuKhachHang_DanhSach
            // 
            this.mnuKhachHang_DanhSach.Name = "mnuKhachHang_DanhSach";
            this.mnuKhachHang_DanhSach.Size = new System.Drawing.Size(292, 34);
            this.mnuKhachHang_DanhSach.Text = "Danh sách khách hàng";
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham_DS,
            this.mnuSanPham_TonKho});
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(107, 29);
            this.mnuSanPham.Text = "Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // mnuSanPham_DS
            // 
            this.mnuSanPham_DS.Name = "mnuSanPham_DS";
            this.mnuSanPham_DS.Size = new System.Drawing.Size(279, 34);
            this.mnuSanPham_DS.Text = "Danh sách sản phẩm";
            // 
            // mnuSanPham_TonKho
            // 
            this.mnuSanPham_TonKho.Name = "mnuSanPham_TonKho";
            this.mnuSanPham_TonKho.Size = new System.Drawing.Size(279, 34);
            this.mnuSanPham_TonKho.Text = "Sản phẩm tồn kho";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(102, 29);
            this.mnuThongKe.Text = "Thống kê";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(91, 29);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuHoaDon_HDDaTao
            // 
            this.mnuHoaDon_HDDaTao.Name = "mnuHoaDon_HDDaTao";
            this.mnuHoaDon_HDDaTao.Size = new System.Drawing.Size(270, 34);
            this.mnuHoaDon_HDDaTao.Text = "Hóa đơn đã tạo";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng";
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
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon_Tao;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang_DanhSach;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon_HDDaTao;
    }
}

