using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.nhanvien_forms;

namespace winform_fpt_shop
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {


        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

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
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void mnuHoaDon_HDDaTao_Click(object sender, EventArgs e)
        {
            //mo form hoa don 
            frmHoaDon_DanhSach frmTao = new frmHoaDon_DanhSach();
            frmTao.Show();
        }

        private void traCứuThôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mo form hoa don 
            frmHoaDon_TraCuu frmTao = new frmHoaDon_TraCuu();
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
            //mo form san pham 
            frmSanPham_DS frmTao = new frmSanPham_DS();
            frmTao.Show();
        }

        private void mnuSanPham_TonKho_Click(object sender, EventArgs e)
        {
            //mo form san pham 
            frmSanPham_TonKho frmTao = new frmSanPham_TonKho();
            frmTao.Show();
        }

        private void traCứuThôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mo form san pham 
            frmSanPham_TraCuu frmTao = new frmSanPham_TraCuu();
            frmTao.Show();
        }


        private void mnuThongKe_DaBan_Click(object sender, EventArgs e)
        {
            //mo form san pham 
            frmThongKe_SP frmTao = new frmThongKe_SP();
            frmTao.Show();  
         
        }

        private void mnuThongKe_HDDaTao_Click(object sender, EventArgs e)
        {
            //mo form san pham 
            frmThongKe_HD frmTao = new frmThongKe_HD();
            frmTao.Show();
        }
    }

}