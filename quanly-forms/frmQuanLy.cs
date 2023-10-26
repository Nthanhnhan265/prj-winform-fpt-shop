using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.manhinhchung_forms;
using winform_fpt_shop.nhanvien_forms;

namespace winform_fpt_shop
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {

            
        }

        private void mnuNhanVien_DS_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien danhSachNhanVien = new frmDanhSachNhanVien();
            danhSachNhanVien.Show();
        }

        private void mnuSanPham_DS_Click(object sender, EventArgs e)
        {
            frmSanPham_DanhSach danhSachSanPham = new frmSanPham_DanhSach();
            danhSachSanPham.Show();    
        }

        private void mnuCuaHang_TT_Click(object sender, EventArgs e)
        {
            frmThongTinCuaHang thongTinCuaHang = new frmThongTinCuaHang();
            thongTinCuaHang.Show();
        }

        private void mnuTK_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuTK_DoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau();
            doiMatKhau.Show();
        }

        private void mnuTK_ThongTIn_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan thongTinCaNhan = new frmThongTinCaNhan();
            thongTinCaNhan.Show();
        }

        private void mnuTK_DangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
            Close();
        }

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon_DanhSach frm = new frmHoaDon_DanhSach();
            frm.Show();
        }
    }
}
