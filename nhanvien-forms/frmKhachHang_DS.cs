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
            int dong = DBCuaHang.AddRowData("sp_ThemKhachHang", khachHang);

            // Kiểm tra
            if (dong > 0)
            {
                // Hiện thông báo sau khi thêm thành công
                MessageBox.Show("Đã thêm thành công!!!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo");
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
            txtMaKH.Enabled = false;

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
                txtMaKH.Enabled = false;

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
                txtMaKH.Enabled = true;

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
                MessageBox.Show("Đã sửa thành công!!!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công", "Thông báo");
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

            // Chặn nút sửa và xóa
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Bỏ chặn
            txtMaKH.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dl == DialogResult.Yes)
            {
                // Xóa
                bool del = DBCuaHang.DelRowData("sp_XoaKhachHang", txtMaKH.Text);

                // Kiểm tra
                if (del == true)
                {
                    MessageBox.Show("Đã xóa thành công!!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!!", "Thông báo");
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

                // Chặn nút sửa và xóa
                btnSua.Enabled = false; 
                btnXoa.Enabled = false;

                // Bỏ chặn
                txtMaKH.Enabled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmKhachhang_TraCuu frm = new frmKhachhang_TraCuu();
            frm.Show();
        }

        private void frmKhachHang_DS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // Kiểm tra ký tự nhập
        public bool KiemTraKyTuNhap()
        {
            bool isValid = true;
            // Kiểm tra ký tự nhập textbox maKH
            string maKH = txtMaKH.Text;
            Char[] arrMaKH = maKH.ToLower().ToCharArray();
            for (int i = 0; i < txtMaKH.Text.Length; i++)
            {
                if(arrMaKH[i] < 'a' || arrMaKH[i] > 'z')
                {
                    if (arrMaKH[i] < '0' || arrMaKH[i] > '9')
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            // liểm tra ký tự nhập họ tên
            string hoTen= txtHoTen.Text;
            Char[] arrHoTen = hoTen.ToCharArray();
            for (int i = 0; i < txtHoTen.Text.Length; i++)
            {
                if (arrHoTen[i] > '0' && arrHoTen[i] < '9')
                {
                    isValid = false;
                    break;
                }
            }

            string cCCD = txtCCCD.Text;
            Char[] arrCCCD = cCCD.ToCharArray();
            for (int i = 0; i < txtCCCD.Text.Length; i++)
            {
                if (arrCCCD[i] < '0' || arrCCCD[i] > '9')
                {
                    isValid = false;
                    break;
                }
            }

            string sdt = txtSDT.Text;
            Char[] arrSDT = sdt.ToCharArray();
            for(int i = 0; i < txtSDT.Text.Length; i++)
            {
                if (arrSDT[i] < '0' || arrSDT[i] > '9')
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        // Kiểm tra số ký tự nhập
        public bool KiemTraSoKyTuNhap()
        {
            bool isValid = true;
            // Kiểm tra textbox mã
            if (txtMaKH.Enabled == false)
            {
                isValid = false;
            }

            // Kiểm tra số ký tự nhập mã khách hàng
            if (txtMaKH.Text.Length == 0 || txtMaKH.Text.Length > 10)
            {
                isValid = false;
                this.errorProvider.SetError(txtMaKH, "Mã khách hàng không được rỗng và phải dưới 10 ký tự");
            }

            // Kiểm tra số ký tự nhập họ tên
            if (txtHoTen.Text.Length == 0 || txtHoTen.Text.Length > 50)
            {
                isValid = false;
                this.errorProvider.SetError(txtHoTen, "Họ tên không được rỗng và phải dưới 50 ký tự");
            }

            // Kiểm tra số ký tự nhập CCCD
            if (txtCCCD.Text.Length != 10)
            {
                isValid = false;
                this.errorProvider.SetError(txtCCCD, "CCCD phải có 10 ký tự");
            }

            // Kiểm tra số ký tự nhập SDT
            if (txtSDT.Text.Length != 10)
            {
                isValid = false;
                this.errorProvider.SetError(txtSDT, "SDT phải có 10 ký tự");
            }

            // KIểm tra số ký tự nhập địa chỉ
            if (txtDiaChi.Text.Length > 255)
            {
                isValid = false;
                this.errorProvider.SetError(txtDiaChi, "Địa chỉ không quá 255 ký tự");
            }

            // Kiểm tra số ký tự nhập Email
            if (txtEmail.Text.Length > 50)
            {
                isValid = false;
                this.errorProvider.SetError(txtEmail, "Email không quá 50 ký tự");
            }

            return isValid;
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true && txtMaKH.Enabled == true)
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
            if (KiemTraSoKyTuNhap() == true && KiemTraKyTuNhap() == true)
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
            if (KiemTraSoKyTuNhap() == true && KiemTraKyTuNhap() == true)
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
            if (KiemTraSoKyTuNhap() == true && KiemTraKyTuNhap() == true)
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
