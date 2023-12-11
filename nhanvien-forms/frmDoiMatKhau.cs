using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.nhanvien_forms;

namespace winform_fpt_shop.manhinhchung_forms
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs=MessageBox.Show("Bạn có muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(rs==DialogResult.Yes)
            {
                this.Close(); 
            }
        
        }

        // Kiểm tra số ký tự nhập
        public bool KiemTraSoKyTuNhap()
        {
            // Khai báo
            bool isValid = true;

            // Kiểm tra textbox mật khẩu cũ
            if (txtMatKhauCu.Text.Length == 0 || txtMatKhauCu.Text.Length > 30)
            {
                isValid = false;
            }

            // Kiểm tra textbox mật khẩu mới
            if (txtMatKhauMoi.Text.Length == 0 || txtMatKhauMoi.Text.Length > 30)
            {
                isValid = false;
            }

            // Kiểm tra textbox nhập lại mật khẩu
            if (txtNhapLai.Text.Length == 0 || txtNhapLai.Text.Length > 30)
            {
                isValid = false;
            }

            return isValid;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == true)
            {
                DoiMatKhau(txtMatKhauCu.Text, txtMatKhauMoi.Text);
                txtMatKhauCu.Clear();
                txtMatKhauMoi.Clear();
                txtNhapLai.Clear();
                // Đóng form để đăng nhập lại
                Close();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Xóa các textbox
                txtMatKhauMoi.Clear();
                txtNhapLai.Clear();
                txtMatKhauCu.Focus();
            }
        }

        // Sửa mật khẩu
        public void DoiMatKhau(string matKhauCu, string matKhauMoi)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DoiMatKhau", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MatKhauCu", matKhauCu);
                cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo");
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close(); 
            }
        }

        // Kiểm tra dữ liệu nhập
        public bool KiemTraDuLieuNhap()
        {
            bool isValid = true;

            // Kiểm tra mật khẩu cũ
            if (txtMatKhauCu.Text.Trim() != frmDangNhap.LayMatkhau())
            {
                isValid = false;

                // Hiện thông báo lỗi
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Kiểm tra mật khẩu mới
            if (txtMatKhauMoi.Text.Trim() == txtMatKhauCu.Text.Trim())
            {
                isValid = false;

                // Hiện thông báo lỗi
                this.errorProvider.SetError(txtMatKhauMoi, "Mật khẩu phải khác mật khẩu cũ");
            }

            // Kiểm tra mật khẩu nhập lại
            if (txtNhapLai.Text.Trim() != txtMatKhauMoi.Text.Trim())
            {
                isValid = false;

                // Hiện thông báo lỗi
                this.errorProvider.SetError(txtNhapLai, "Mật khẩu phải khớp với mật khẩu mới");
            }

            return isValid;
        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true)
            {
                btnXacNhan.Enabled = true;
            }
            else
            {
                btnXacNhan.Enabled = false;
            }
        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true)
            {
                btnXacNhan.Enabled = true;
            }
            else
            {
                btnXacNhan.Enabled = false;
            }
        }

        private void txtNhapLai_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true)
            {
                btnXacNhan.Enabled = true;
            }
            else
            {
                btnXacNhan.Enabled = false;
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.Focus();
        }
    }
}
