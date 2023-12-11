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

namespace winform_fpt_shop.manhinhchung_forms
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Kiểm tra số ký tự nhập
        public bool KiemTraSoKyTuNhap()
        {
            // Khai báo
            bool isValid = true;

            // Kiểm tra textbox mật khẩu cũ
            if (txtTaiKhoan.Text.Length == 0 || txtTaiKhoan.Text.Length > 10)
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

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
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
                if (cmd.ExecuteNonQuery() > 0)
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
