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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }



        private void frmMain_Resize(object sender, EventArgs e)
        {


        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //frmDangNhap frm = new frmDangNhap();
            //frm.ShowDialog();

            //Thay đổi đường dẫn DB tại đây 
            DBCuaHang.sqlString="Data Source=local;Initial Catalog=QuanLyCuaHang;Integrated Security=True;"; 

        }
        /// <summary>
        /// Dong ung dung khi click vao thoat 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTK_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnuHoaDon_Tao_Click(object sender, EventArgs e)
        {
            //mo form hoa don 
            frmHoaDon_Tao frmTao = new frmHoaDon_Tao();
            frmTao.Show();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rs == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void mnuHoaDon_HDDaTao_Click(object sender, EventArgs e)
        {
            //mo form hoa don 
            frmHoaDon_DanhSach frmTao = new frmHoaDon_DanhSach();
            frmTao.Show();
        }



        private void mnuKhachHang_DanhSach_Click(object sender, EventArgs e)
        {
            //mo form khach hang
            frmKhachHang_DS frmTao = new frmKhachHang_DS();
            frmTao.Show();
        }

        private void mnuKH_TraCuu_Click(object sender, EventArgs e)
        {
            //mo form khach hang
            frmKhachhang_TraCuu frmTao = new frmKhachhang_TraCuu();
            frmTao.Show();
        }

        private void mnuSanPham_DS_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_DanhSach frmTao = new frmSanPham_DanhSach();
            frmTao.Show();
        }





        private void mnuThongKe_DaBan_Click(object sender, EventArgs e)
        {
            //mo form
            frmThongKe_HD frmTao = new frmThongKe_HD();
            frmTao.Show();

        }

        private void mnuThongKe_HDDaTao_Click(object sender, EventArgs e)
        {
            //mo form 
            frmThongKe_HD frmTao = new frmThongKe_HD();
            frmTao.Show();
        }

        private void mnuTK_DoiMK_Click(object sender, EventArgs e)
        {
            //mo form 
            frmDoiMatKhau frmTao = new frmDoiMatKhau();
            frmTao.ShowDialog();
        }

        private void mnuTK_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new frmDangNhap().Show();
                this.Close();
            }

        }

        private void mnuTK_ThongTIn_Click(object sender, EventArgs e)
        {
            //mo form
            frmThongTinCaNhan frmTao = new frmThongTinCaNhan();
            frmTao.ShowDialog();
        }

        private void mnuSanPham_Them_Click(object sender, EventArgs e)
        {
            //mo form
            frmSanPham_Them frmTao = new frmSanPham_Them();
            frmTao.Show();
        }



        private void mnuSanPham_DanhMuc_Them_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_DanhMucSP frmTao = new frmSanPham_DanhMucSP();
            frmTao.Show();
        }


        private void mnuNhaSanXuat_Click(object sender, EventArgs e)
        {
            //mo form 
            frmNhaSanXuat frmTao = new frmNhaSanXuat();
            frmTao.Show();
        }
        private void mnuSanPham_TraCuu_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_TraCuu frmTao = new frmSanPham_TraCuu();
            frmTao.Show();
        }

        private void mnuSanPham_TonKho_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_TonKho frmTao = new frmSanPham_TonKho();
            frmTao.Show();
        }

        private void mnuQuanLy_DSNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mo form  
            frmQuanLy_DSNhanVien frmTao = new frmQuanLy_DSNhanVien();
            frmTao.Show();
        }

        public void HideQuanLy()
        {
            mnuQuanLy.Enabled = false;
        }

    }

}