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
            frmDangNhap frm = new frmDangNhap(this);
            OpenChildForm(frm);
            //Thay đổi đường dẫn DB tại đây 
            DBCuaHang.sqlString= "Data Source=B202A-PC26\\SQLEXPRESS;Initial Catalog=QuanLyCuaHang;Integrated Security=True"; 

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
                frmDangNhap.DangXuat();
                frmDangNhap frm = new frmDangNhap(this);
                OpenChildForm(frm); 

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
        /// <summary>
        /// Phương thức hiện menu 
        /// </summary>
        public void HienMenu()
        {
            mnuNhanVien.Enabled = true; 

        }
        /// <summary>
        /// Phương thức hiển thị chức năng quản lý 
        /// </summary>
        public void HienQuanLy()
        {
            mnuQuanLy.Enabled = true;

        }
        /// <summary>
        /// Phương thức ẩn chức năng quan lý 
        /// </summary>
        public void AnQuanLy()
        {
            mnuQuanLy.Enabled = false;
        }
        /// <summary>
        /// Phương thức ẩn menu khi chưa đăng nhập 
        /// </summary>
        public void AnMenu()
        {
            mnuNhanVien.Enabled = false; 
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

        private void mnuQuanLy_CuaHang_Click(object sender, EventArgs e)
        {
            //mo form im
        }

        private void mnuQuanLy_NhanVien_TraCuu_Click(object sender, EventArgs e)
        {
            //mo form tra cuu 
            frmQuanLy_TraCuuNhanVien frm=new frmQuanLy_TraCuuNhanVien();
            OpenChildForm(frm); 
        }

        private void mnuQuanLy_NhanVien_DieuChuyen_Click(object sender, EventArgs e)
        {

        }

        private void mnuTaiKhoanTTCuaHang_Click(object sender, EventArgs e)
        {
            frmTaiKhoanThongTinCH frm =new  frmTaiKhoanThongTinCH();
            OpenChildForm(frm);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {

        }
    }

}