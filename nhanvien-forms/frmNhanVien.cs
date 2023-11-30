using System;
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



        private void mnuQuanLy_DSNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
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

      

        private void mnuTK_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new frmDangNhap().Show();
                this.Close();
            }

        }
        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rs == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void mnuThongKe_DaBan_Click(object sender, EventArgs e)
        {
            //mo form
            frmThongKe_HD frmTao = new frmThongKe_HD();
            OpenChildForm(frmTao);
        }

        private void mnuThongKe_HDDaTao_Click(object sender, EventArgs e)
        {
            //mo form 
            frmThongKe_HD frmTao = new frmThongKe_HD();
            OpenChildForm(frmTao);
        }

        private void mnuTK_DoiMK_Click(object sender, EventArgs e)
        {
            //mo form 
            frmDoiMatKhau frmTao = new frmDoiMatKhau();
            OpenChildForm(frmTao);
        }

        private void mnuTK_ThongTIn_Click(object sender, EventArgs e)
        {
            //mo form
            frmThongTinCaNhan frmTao = new frmThongTinCaNhan();
            OpenChildForm(frmTao);
        }

        private void mnuSanPham_DanhMuc_Them_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_DanhMucSP frmTao = new frmSanPham_DanhMucSP();
            OpenChildForm(frmTao);
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mo form  
            frmQuanLy_DSNhanVien frmTao = new frmQuanLy_DSNhanVien();
            OpenChildForm(frmTao);
        }

        public void HideQuanLy()
        {
            mnuQuanLy.Enabled = false;
        }

        private void mnuChucNang_HoaDon_Tao_Click(object sender, EventArgs e)
        {
            //mo form hoa don 
            frmHoaDon_Tao frmTao = new frmHoaDon_Tao();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_HoaDon_DS_Click(object sender, EventArgs e)
        {
            //mo form hoa don 
            frmHoaDon_DanhSach frmTao = new frmHoaDon_DanhSach();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_NhaSX_Click(object sender, EventArgs e)
        {
            //mo form 
            frmNhaSanXuat frmTao = new frmNhaSanXuat();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_NhaSX_Them_Click(object sender, EventArgs e)
        {
            //mo form
            frmSanPham_Them frmTao = new frmSanPham_Them();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_SanPham_DS_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_DanhSach frmTao = new frmSanPham_DanhSach();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_SanPham_TraCuu_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_TraCuu frmTao = new frmSanPham_TraCuu();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_SanPham_TonKho_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_TonKho frmTao = new frmSanPham_TonKho();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_SanPham_DanhMuc_Click(object sender, EventArgs e)
        {
            //mo form 
            frmSanPham_DanhMucSP frmTao = new frmSanPham_DanhMucSP();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_KhachHang_DS_Click(object sender, EventArgs e)
        {
            //mo form khach hang
            frmKhachHang_DS frmTao = new frmKhachHang_DS();
            OpenChildForm(frmTao);
        }

        private void mnuChucNang_KhachHang_TraCuu_Click(object sender, EventArgs e)
        {
            //mo form khach hang
            frmKhachhang_TraCuu frmTao = new frmKhachhang_TraCuu();
            OpenChildForm(frmTao); 
        }
        private void OpenChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.Show();
        }

    }

}