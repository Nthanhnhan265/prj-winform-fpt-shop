using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.classes;

namespace winform_fpt_shop
{
    public partial class frmHoaDon_Tao : Form
    {
        public frmHoaDon_Tao()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Tao_Load(object sender, EventArgs e)
        {
            txtMaHD.Focus();

            // Hiển thị phương thức thanh toán mặc định
            cboPhuongThucTT.SelectedIndex = 0;

            // Hiển thị danh sách chi tiết hóa đơn
            dgvChiTietHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiChiTietHD");

            // Hiển thị tổng tiền mặc định
            txtTongTien.Text = "0";

            // Lấy thông tin nhân viên sau khi đăng nhập
            txtMaNV.Text = frmDangNhap.LayMaNhanVien();
            txtMaCH.Text = frmDangNhap.LayMaCH();
            txtTenNV.Text = frmDangNhap.LayTenNhanVien();
            txtSDT.Text = frmDangNhap.LaySoDienThoai();

            // Lấy mã, tên khách hàng cho cboMaKhachHang
            cboTenKH.DataSource = DBCuaHang.GetDataTable("sp_HienThiKhachHang");
            cboTenKH.ValueMember = "MaKH";
            cboTenKH.DisplayMember = "HoTenKH";

            // Lấy mã, tên sản phẩm cho cboMaSP
            DataTable bangMaSP = LayMaSanPhamTuTonKho(txtMaCH.Text);
            string[] tenSP = new string[bangMaSP.Rows.Count];
            for(int i = 0; i < bangMaSP.Rows.Count; i++)
            {
                tenSP[i] = LayThongTinSanPham(bangMaSP.Rows[i].Field<string>(0), 1);
                cboTenSP.Items.Add(tenSP[i]);
            }
            if (cboTenSP.Items.Count > 0)
            {
                cboTenSP.SelectedIndex = 0;
            }
        }

        private void cboPhuongThucTT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Kiểm tra ký tự nhập
        public bool KiemTraKyTuNhap()
        {
            bool isValid = true;

            // Kiểm tra ký tự nhập textbox mã hóa đơn
            string maHoaDon = txtMaHD.Text;
            Char[] arrHD = maHoaDon.ToLower().ToCharArray();
            for (int i = 0; i < maHoaDon.Length; i++)
            {
                if (arrHD[i] < '0' || arrHD[i] > '9')
                {
                    isValid = false;
                    break;
                }
            }

            // Kiểm tra ký tự nhập textbox mã chi tiết
            string maChiTiet = txtMaChiTiet.Text;
            Char[] arrChiTiet = maChiTiet.ToLower().ToCharArray();
            for (int i = 0; i < maChiTiet.Length; i++)
            {
                if (arrChiTiet[i] < '0' || arrChiTiet[i] > '9')
                {
                    isValid = false;
                    break;
                }
            }

            // Kiểm tra ký tự nhập textbox số lượng
            string soLuong = txtSoLuong.Text;
            Char[] arrSoLuong = soLuong.ToCharArray();
            for (int i = 0; i < txtSoLuong.Text.Length; i++)
            {
                if (arrSoLuong[i] < '0' || arrSoLuong[i] > '9')
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

            // Kiểm tra textbox mã chi tiết hóa đơn
            if (txtMaChiTiet.Enabled == false)
            {
                isValid = false;
            }

            // Kiểm tra số ký tự nhập mã hóa đơn
            if (txtMaHD.Text.Length == 0 || txtMaHD.Text.Length > 10)
            {
                isValid = false;
            }

            // Kiểm tra số ký tự nhập mã chi tiết
            if (txtMaChiTiet.Text.Length == 0 || txtMaChiTiet.Text.Length > 10)
            {
                isValid = false;
            }

            // Kiểm tra số ký tự nhập textbox số lượng
            if (txtSoLuong.Text.Length == 0 || txtSoLuong.Text.Length > 2)
            {
                isValid = false;
            }

            return isValid;
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            // Số dòng của hóa đơn và chi tiết hóa đơn
            int dong = dgvChiTietHoaDon.CurrentCell.RowIndex;
            txtMaChiTiet.Text = dgvChiTietHoaDon.Rows[dong].Cells[0].Value.ToString();
            txtMaHD.Text = dgvChiTietHoaDon.Rows[dong].Cells[1].Value.ToString();
            txtMaSP.Text = dgvChiTietHoaDon.Rows[dong].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvChiTietHoaDon.Rows[dong].Cells[3].Value.ToString();
            txtTongTien.Text = LayThongTinHoaDon(txtMaHD.Text, 6).ToString();
            txtMaKH.Text = LayThongTinHoaDon(txtMaHD.Text,1);
            cboPhuongThucTT.Text = LayThongTinHoaDon(txtMaHD.Text, 5);
            dtpNgayTao.Text = LayThongTinHoaDon(txtMaHD.Text, 3);

            // Hiển thị thành tiền
            if (txtSoLuong.Text.Length > 0)
            {
                txtThanhTien.Text = TinhThanhien(int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text)) + "";
            }

            // Hiển thị tên sản phẩm
            cboTenSP.Text = LayThongTinSanPham(txtMaSP.Text, 1);

            // Hiển thị tên khách hàng
            cboTenKH.Text = LayThongTinKhachHang(txtMaKH.Text, 1);

            if (txtMaChiTiet.Text.Length > 0)
            {
                // Chặn sửa mã chi tiết
                txtMaChiTiet.Enabled = false;

                // Chặn sửa mã hóa đơn
                txtMaHD.Enabled = false;

                // Bỏ chặn nút xóa hóa đơn
                btnXoa.Enabled = true;

                // Bỏ chặn nút sửa hóa đơn
                btnSua.Enabled = true;

                // Bỏ chặn nút hủy hóa đơn
                btnHuy.Enabled = true;
            }
            else
            {
                // Bỏ chặn sửa mã chi tiết
                txtMaChiTiet.Enabled = true;

                // Bỏ chặn sửa mã hóa đơn
                txtMaHD.Enabled = true;

                // Chặn nút xóa hóa đơn
                btnXoa.Enabled = false;

                // Chặn nút sửa hóa đơn
                btnSua.Enabled = false;

                // Chặn nút hủy hóa đơn
                btnHuy.Enabled = false;

                // Lấy lại mã sản phẩm
                txtMaSP.Text = LayThongTinSanPhamTheoTen(cboTenSP.Text,0);

                // Lấy lại mã Khách hàng
                txtMaKH.Text = cboTenKH.SelectedValue.ToString();

                // Cập nhật lại thành tiền và tổng tiền
                txtThanhTien.Text = "0";
                txtTongTien.Text = "0";
            }
        }

        //Lấy thông tin tồn kho
        public DataTable LayMaSanPhamTuTonKho(string maCH)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimMaSPTuMaCH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaCH", maCH);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // Lấy thông tin hóa đơn
        public string LayThongTinHoaDon(string maHD, int soCot)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TraCuuHoaDonTheoMaHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (soCot == 6)
                {
                    return dataTable.Rows[0].Field<int>(soCot).ToString();
                }
                if (soCot == 3)
                {
                    return dataTable.Rows[0].Field<DateTime>(soCot).ToString();
                }
                return dataTable.Rows[0].Field<string>(soCot);

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return "";
        }

        // Lấy thông tin khách hàng
        public string LayThongTinKhachHang(string maKH, int soCot)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TraCuuKhachHangTheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable.Rows[0].Field<string>(soCot);

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return "";
        }

        // Lấy thông tin sản phẩm
        public string LayThongTinSanPham(string ma, int soCot)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemSanPhamTheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChuoiCanTim", ma);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (soCot == 5)
                {
                    return dataTable.Rows[0].Field<int>(soCot).ToString();
                }
                return dataTable.Rows[0].Field<string>(soCot);

            }
            catch (Exception)
            { 
            }
            finally
            {
                conn.Close();   
            }

            return "";
        }

        public string LayThongTinSanPhamTheoTen(string ten, int soCot)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TimKiemSanPhamTheoTen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ChuoiCanTim", ten);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (soCot == 5)
                {
                    return dataTable.Rows[0].Field<int>(soCot).ToString();
                }
                return dataTable.Rows[0].Field<string>(soCot);

            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return "";
        }

        // Lấy số lượng sản phẩm
        public string LaySoLuongSanPhamTonKho(string maSP)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LaySoLuongSanPham", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data.Rows[0].Field<string>(0);
            }
            catch (Exception) 
            {
            }
            finally
            {
                conn.Close(); 
            }
            return "";
        }

        private void cboTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = cboTenKH.SelectedValue.ToString();
        }

        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm
            txtMaSP.Text = LayThongTinSanPhamTheoTen(cboTenSP.Text, 0);

            // Lấy giá sản phẩm
            txtDonGia.Text = LayThongTinSanPham(txtMaSP.Text, 5);
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if(KiemTraKyTuNhap() == true && KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
                // Hiển thị thành tiền
                txtThanhTien.Text = TinhThanhien(int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text)).ToString();
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        // Tính thành tiền
        public long TinhThanhien(int soLuong, int donGia)
        {
            return soLuong * donGia;
        }

        private void txtMaChiTiet_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraKyTuNhap() == true && KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true && KiemTraKyTuNhap() == true)
            {
                btnThem.Enabled = true;
                // Hiển thị thành tiền
                txtThanhTien.Text = TinhThanhien(int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text)) + "";
            }
            else
            {
                btnThem.Enabled = false;
            }
            MessageBox.Show("" + LaySoLuongSanPhamTonKho(txtMaSP.Text));
        }

        private void frmHoaDon_Tao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraKyTuNhap() == true && KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo hóa đơn mới nếu hóa đơn chưa có sẵn
            if (KiemTraHoaDonDaTonTai(txtMaHD.Text) == false)
            {
                TaoHoaDon();
            }

            // Tạo chi tiết hóa dơn
            TaoChiTietHoaDon();

            // Tải lại danh sách
            dgvChiTietHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiChiTietHD");

            // Xóa các textbox
            txtMaHD.Clear();
            txtMaChiTiet.Clear();
            txtSoLuong.Clear();

            // Cập nhật lại thảnh tiển
            txtThanhTien.Text = "0";
        }

        // Tạo hóa đơn
        public void TaoHoaDon()
        {
            // Tạo hóa đơn mới
            HoaDon hoaDon = new HoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, dtpNgayTao.Value, txtMaCH.Text, DBCuaHang.GetNvarcharText(cboPhuongThucTT.Text), 0);
            int dongHD = DBCuaHang.AddRowData("sp_ThemHoaDon", hoaDon);

            // Kiểm tra
            if (dongHD > 0)
            {
                // Hiện thông báo sau khi thêm thành công
                MessageBox.Show("Đã thêm hóa đơn thành công!!!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn không thành công", "Thông báo");
            }
        }

        // Tạo chi tiết hóa đơn
        public void TaoChiTietHoaDon()
        {
            // Tạo object chi tiết hóa đơn
            ChiTietHoaDon chiTiet = new ChiTietHoaDon(txtMaChiTiet.Text, txtMaHD.Text, txtMaSP.Text, int.Parse(txtSoLuong.Text));
            int dong = DBCuaHang.AddRowData("sp_ThemChiTietHD", chiTiet); // Thêm chi tiết hóa đơn

            // Kiem tra
            if (dong > 0)
            {
                // Hiện thông báo sau khi thêm thành công
                MessageBox.Show("Đã thêm chi tiết HD thành công !!!", "Thông báo");

                // Hiển thị tổng tiền
                long tongTien = int.Parse(LayThongTinHoaDon(txtMaHD.Text, 6)) + int.Parse(txtThanhTien.Text);
                txtTongTien.Text = tongTien.ToString();

                // Tạo object hóa đơn
                HoaDon hoaDon = new HoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, dtpNgayTao.Value, txtMaCH.Text, DBCuaHang.GetNvarcharText(cboPhuongThucTT.Text), int.Parse(txtTongTien.Text));
                // Cập nhật vào hóa đơn
                int capNhatHD = DBCuaHang.UpdateRowData("sp_SuaHoaDon", hoaDon);

                // Lấy số lượng
                int soLuong = int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text)) - int.Parse(txtSoLuong.Text);

                // Cập nhật số lượng
                TonKho tonKho = new TonKho(txtMaCH.Text, txtMaSP.Text, soLuong);
                int capNhatSL = DBCuaHang.UpdateRowData("sp_SuaTonKho", tonKho);
            }
            else
            {
                MessageBox.Show("Thêm chi tiết HD không thành công", "Thông báo");
            }
        }

        // Kiểm tra hóa đơn
        public bool KiemTraHoaDonDaTonTai(string maHD)
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TraCuuHoaDonTheoMaHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception) 
            {
            }
            finally
            {
                conn.Close();
            }

            return dataTable.Rows.Count > 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaChiTietHD();
            XoaHoaDon();
            // Xóa các textbox
            txtMaChiTiet.Clear();
            txtMaSP.Clear();

            // Bỏ chặn sửa mã chi tiết
            txtMaChiTiet.Enabled = true;

            // Chặn nút xóa hóa đơn
            btnXoa.Enabled = false;

            // Chặn nút sửa hóa đơn
            btnSua.Enabled = false;

            // Chặn nút hủy hóa đơn
            btnHuy.Enabled = false;
        }

        // Xóa chi tiết HD
        public void XoaChiTietHD()
        {
            bool xoa = DBCuaHang.DelRowData("sp_XoaChiTietHD", txtMaHD.Text);
        }

        // Xóa hóa đơn
        public void XoaHoaDon()
        {
            bool xoa = DBCuaHang.DelRowData("sp_XoaHoaDon", txtMaHD.Text);

            if (xoa)
            {
                MessageBox.Show("Đã xóa hóa đơn thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Sửa hóa đơn
        public void SuaHoaDon()
        {
            HoaDon hoaDon = new HoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, dtpNgayTao.Value, txtMaCH.Text, DBCuaHang.GetNvarcharText(cboPhuongThucTT.Text), int.Parse(txtTongTien.Text));
            int dong = DBCuaHang.UpdateRowData("sp_SuaHoaDon", hoaDon);

            if (dong > 0)
            {
                MessageBox.Show("Sửa hóa đơn thành công!!!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa hóa đơn thất bại", "Thông báo");
            }
        }

        // Sửa chi tiết hóa đơn
        public void SuaChiTietHoaDon()
        {
            ChiTietHoaDon chiTiet = new ChiTietHoaDon(txtMaChiTiet.Text, txtMaHD.Text, txtMaSP.Text, int.Parse(txtSoLuong.Text));
            int dong = DBCuaHang.UpdateRowData("sp_SuaChiTietHD", chiTiet);

            // Cập nhật tổng tiền

            if (dong > 0)
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thành công!!!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thất bại", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Sửa hóa đơn
            SuaHoaDon();

            // Sửa chi tiết hóa đơn
            SuaChiTietHoaDon();

            // Tải lại danh sách
            dgvChiTietHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiChiTietHD");

            // Xóa các textbox
            txtMaChiTiet.Clear();
            txtSoLuong.Clear();

            // Bỏ chặn sửa mã hóa đơn

            // Chặn nút xóa hóa đơn
            btnXoa.Enabled = false;

            // Chặn nút sửa hóa đơn
            btnSua.Enabled = false;

            // Chặn nút hủy hóa đơn
            btnHuy.Enabled = false;
        }
    }
}