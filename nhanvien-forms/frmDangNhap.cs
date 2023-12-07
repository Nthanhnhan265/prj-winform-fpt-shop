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

namespace winform_fpt_shop
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(frmNhanVien nhanVien)
        {
            frmChinh = nhanVien; 
            InitializeComponent();
            nhanVien.AnQuanLy();
            nhanVien.AnMenu(); 
        }
        //khai bao 
        static NhanVien taiKhoan; 
        static bool Thoat = false;
        bool hoatDong = false;
        frmNhanVien frmChinh;
    
        
        //ấn để đăng nhập 
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //lấy thông tin  
            string maNV = txtUser.Text; 
            string matKhau=txtMatKhau.Text;
            string quyenHan = ""; 
            if (rdQuanLy.Checked == true) // quản lý
            {
                quyenHan = rdQuanLy.Text; 
            }
            else if (rdNhanVien.Checked == true) // nhân viên
            {
                quyenHan = rdNhanVien.Text; 
            }
            //kiểm tra dữ liệu truyền vào 
            taiKhoan = DBCuaHang.DangNhap(maNV,matKhau,quyenHan);
            if(taiKhoan!=null)
            {
                frmChinh.HienMenu(); 
                if(taiKhoan.QuyenHan=="Quản lý")
                {
                    frmChinh.HienQuanLy();
                }
                hoatDong = true;
                this.Hide(); 
                MessageBox.Show($"Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show($"Đăng nhập không thành công!\nSai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus(); 
            rdNhanVien.Checked = true; 
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }

        private void rdQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Layout(object sender, LayoutEventArgs e)
        {

        }
        /// <summary>
        /// gọiphương thức này để xóa tài khoản đã đăng nhập 
        /// </summary>
        public static void DangXuat()
        {
            taiKhoan = null; 
        }


        /// <summary>
        /// lấy mã cửa hàng từ tài khoản đã đăng nhập 
        /// </summary>
        /// <returns></returns>
        public static bool QuyenQuanLy()
        {
            if(taiKhoan!=null && taiKhoan.QuyenHan=="Quản lý")
            {
            return true; 

            }
            return false ; 
        }

        /// <summary>
        /// Trả về true hoặc false ứng với quyền quản lý và nhân viên  
        /// </summary>
        /// <returns></returns>
        public static string LayMaCH()
        {
            if (taiKhoan != null)
            {
                return taiKhoan.MaCH;

            }
            return "";
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(!hoatDong)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Environment.Exit(0);  
                    Thoat = true;
                }
            }
        }

        private void rdNhanVien_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
