using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.classes;
using winform_fpt_shop.nhanvien_forms;

namespace winform_fpt_shop
{
    public partial class frmKhachHang_DS : Form
    {
        public frmKhachHang_DS()
        {
            InitializeComponent();
        }


        private void frmKhachHang_DS_Load(object sender, EventArgs e)
        {
            txtMaKH.Focus();
            dgvKhachHang.DataSource = DBCuaHang.GetDataTable("sp_HienThiKhachHang");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo object Khách hàng
            KhachHang khachHang = new KhachHang(txtMaKH.Text, DBCuaHang.GetNvarcharText(txtHoTen.Text), txtCCCD.Text, txtSDT.Text, DBCuaHang.GetNvarcharText(txtDiaChi.Text), txtEmail.Text);
            int dong = DBCuaHang.AddRowData("sp_ThemKhachHang", khachHang); // Số dòng thêm vào

            // Kiểm tra
            if (dong > 0)
            {
                // Hiện thông báo sau khi thêm thành công
                MessageBox.Show("Đã thêm thành công!!!");
            }
            else
            {
                dgvKhachHang.DataSource = null;
            }

            // Tải lại danh sách khách hàng
            dgvKhachHang.DataSource = DBCuaHang.GetDataTable("sp_HienThiKhachHang");

            // Clear các textbox
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             // Lấy dòng
            int dong = dgvKhachHang.CurrentCell.RowIndex;

            // Đưa lên các textbox
            txtMaKH.Text = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.Rows[dong].Cells[1].Value.ToString();
            txtCCCD.Text = dgvKhachHang.Rows[dong].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[dong].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[dong].Cells[4].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[dong].Cells[5].Value.ToString();

            // Ngăn chặn sửa mã
            txtMaKH.ReadOnly = true;

            // Ngăn chặn nút thêm;
            btnThem.Enabled = false;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            // Lấy dòng
            int dong = dgvKhachHang.CurrentCell.RowIndex;

            // Đưa lên các textbox
            txtMaKH.Text = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.Rows[dong].Cells[1].Value.ToString();
            txtCCCD.Text = dgvKhachHang.Rows[dong].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[dong].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[dong].Cells[4].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[dong].Cells[5].Value.ToString();

            if (txtMaKH.Text != "")
            {
                // Ngăn chặn sửa mã
                txtMaKH.ReadOnly = true;

                // Ngăn chặn nút thêm;
                btnThem.Enabled = false;

                // Bỏ chặn nút xóa
                btnXoa.Enabled = true;

                // Bỏ chặn nút sửa
                btnSua.Enabled = true;
            }
            else
            {
                // Bỏ chặn sửa mã
                txtMaKH.ReadOnly = false;

                // Ngăn chặn nút xóa
                btnXoa.Enabled = false;

                // Ngăn chặn nút sửa
                btnSua.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Tạo object Khách hàng
            KhachHang khachHang = new KhachHang(txtMaKH.Text, DBCuaHang.GetNvarcharText(txtHoTen.Text), txtCCCD.Text, txtSDT.Text, DBCuaHang.GetNvarcharText(txtDiaChi.Text), txtEmail.Text);

            // Số dòng ảnh đã sữ
            int dong = DBCuaHang.UpdateRowData("sp_SuaKhachHang", khachHang);

            // Kiểm tra
            if (dong > 0)
            {
                // Hiện thông báo sau khi thêm thành công
                MessageBox.Show("Đã sửa thành công!!!");
            }
            else
            {
                dgvKhachHang.DataSource = null;
            }

            // Tải lại danh sách khách hàng
            dgvKhachHang.DataSource = DBCuaHang.GetDataTable("sp_HienThiKhachHang");

            // Clear các textbox
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();

            // Bỏ chặn
            txtMaKH.ReadOnly = false;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa
            bool del = DBCuaHang.DelRowData("sp_XoaKhachHang", txtMaKH.Text);

            // Kiểm tra
            if (del == true)
            {
                MessageBox.Show("Đã xóa thành công!!!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!!");
                dgvKhachHang.DataSource = null;
            }

            // Tải lại danh sách khách hàng
            dgvKhachHang.DataSource = DBCuaHang.GetDataTable("sp_HienThiKhachHang");

            // Clear các textbox
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtCCCD.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();

            // Bỏ chặn
            txtMaKH.ReadOnly = false;
            btnThem.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmKhachhang_TraCuu frm = new frmKhachhang_TraCuu();
            frm.Show();
        }

        private void frmKhachHang_DS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        // Kiểm tra số ký tự nhập
        public bool KiemTraSoKyTuNhap()
        {
            bool isValid = true;
            if (txtMaKH.Text.Length == 0 || txtMaKH.Text.Length > 10)
            {
                isValid = false;
            }
            else
            {
                if (txtHoTen.Text.Length == 0 || txtHoTen.Text.Length > 50)
                {
                    isValid = false;
                }
                if (txtCCCD.Text.Length != 10)
                {
                    isValid = false;
                }
                if (txtSDT.Text.Length != 10)
                {
                    isValid = false;
                }
                if (txtDiaChi.Text.Length > 255)
                {
                    isValid = false;
                }
                if (txtEmail.Text.Length > 50)
                {
                    isValid = false;
                }
            }
           
            return isValid;
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }
    }
}
