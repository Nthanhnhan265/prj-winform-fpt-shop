using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmDanhSachSanPham danhSachSanPham = new frmDanhSachSanPham();
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
    }
}
