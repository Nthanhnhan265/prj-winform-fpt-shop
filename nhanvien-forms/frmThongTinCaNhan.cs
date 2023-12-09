using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_fpt_shop.manhinhchung_forms
{
    public partial class frmThongTinCaNhan : Form
    {
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            NhanVien taiKhoan = frmDangNhap.TaiKhoan;
            DataTable dt = DBCuaHang.GetDataTableFromQuery($"SELECT * FROM CuaHang Where MaCH='{taiKhoan.MaCH}'"); 
            txtMaNV.Text = taiKhoan.MaNV;
            txtHoTen.Text = taiKhoan.HoTen;
            dtpNgaySinh.Text = taiKhoan.NgaySinh;
            txtDiaChi.Text = taiKhoan.DiaChi;
            if(taiKhoan.GioiTinh=="Nam")
            {
                rdNam.Checked = true; 
            }else
            {
                rdNu.Checked = true; 
            }
                txtSoDT.Text = taiKhoan.SDT;
                txtEmail.Text = taiKhoan.Email;
                txtCCCD.Text = taiKhoan.CCCD;
                txtChucVu.Text = taiKhoan.QuyenHan; 
            if(dt.Rows.Count>0)
            {
                txtTenCH.Text = dt.Rows[0]["TenCH"].ToString();
                txtDiaDiem.Text = dt.Rows[0]["DiaChi"].ToString();
                txtDiaChi.Text = taiKhoan.DiaChi; 
            }else
            {
                txtTenCH.Text = "Không"; 
                txtDiaDiem.Text = "Không";
                txtDiaChi.Text = "Không"; 

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtDiaDiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
