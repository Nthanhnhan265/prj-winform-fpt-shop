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
using winform_fpt_shop.nhanvien_forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

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
            string maSP = "";
            string[] tenSP = new string[bangMaSP.Rows.Count];
            for (int i = 0; i < bangMaSP.Rows.Count; i++)
            {
                maSP = bangMaSP.Rows[i].Field<string>(0);
                if (maSP != "")
                {
                    tenSP[i] = LayThongTinSanPham(maSP, 1);
                    // Kiểm tra số lượng trong kho
                    if (int.Parse(LaySoLuongSanPhamTonKho(maSP, txtMaCH.Text, 0)) > 0)
                    {
                        cboTenSP.Items.Add(tenSP[i]);
                    }
                }
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
                if (arrHD[i] < 'a' || arrHD[i] > 'z')
                {
                    if (arrHD[i] < '0' || arrHD[i] > '9')
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            // Kiểm tra ký tự nhập textbox số lượng
            string soLuong = txtSoLuong.Text;
            Char[] arrSoLuong = soLuong.ToCharArray();
            for (int i = 0; i < txtSoLuong.Text.Length; i++)
            {
                if (arrSoLuong[i] < '1' || arrSoLuong[i] > '9')
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

            // Kiểm tra số ký tự nhập mã hóa đơn
            if (txtMaHD.Text.Length == 0 || txtMaHD.Text.Length > 10)
            {
                isValid = false;
            }

            // Kiểm tra số lượng nhập
            if (txtSoLuong.Text != "")
            {
                int soLuongConLai = int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text, txtMaCH.Text, 1));
                if (int.Parse(txtSoLuong.Text) > soLuongConLai || soLuongConLai == 0)
                {
                    return false;
                }
            }

            // Kiểm tra số ký tự nhập mã chi tiết
            if (txtMaChiTiet.Text.Length > 10)
            {
                isValid = false;
            }

            // Kiểm tra số ký tự nhập textbox số lượng
            if (txtSoLuong.Text.Length == 0)
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
            txtMaKH.Text = LayThongTinHoaDon(txtMaHD.Text, 1);
            cboPhuongThucTT.Text = LayThongTinHoaDon(txtMaHD.Text, 5);
            dtpNgayTao.Text = LayThongTinHoaDon(txtMaHD.Text, 3);

            // Hiển thị thành tiền
            if (txtSoLuong.Text.Length > 0)
            {
                txtThanhTien.Text = TinhThanhTien(int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text)) + "";
            }

            // Hiển thị tên sản phẩm
            cboTenSP.Text = LayThongTinSanPham(txtMaSP.Text, 1);

            // Hiển thị tên khách hàng
            cboTenKH.Text = LayThongTinKhachHang(txtMaKH.Text, 1);

            if (txtMaChiTiet.Text.Length > 0)
            {
                // Bỏ chặn nút in
                btnInHoaDon.Enabled = true;

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
                // Bỏ chặn nút in
                btnInHoaDon.Enabled = true;

                // Bỏ chặn sửa mã hóa đơn
                txtMaHD.Enabled = true;

                // Chặn nút xóa hóa đơn
                btnXoa.Enabled = false;

                // Chặn nút sửa hóa đơn
                btnSua.Enabled = false;

                // Chặn nút hủy hóa đơn
                btnHuy.Enabled = false;

                // Lấy lại mã sản phẩm
                if (LayThongTinSanPhamTheoTen(cboTenSP.Text, 0) != "")
                {
                    txtMaSP.Text = LayThongTinSanPhamTheoTen(cboTenSP.Text, 0);
                }

                // Lấy lại mã Khách hàng
                txtMaKH.Text = cboTenKH.SelectedValue.ToString();

                // Cập nhật lại thành tiền và tổng tiền
                txtThanhTien.Text = "0";
                txtTongTien.Text = "0";
            }

            // Kiểm tra hóa đơn có bị hủy hay chưa
            if (txtMaHD.Text.Contains("#"))
            {
                btnSua.Enabled = false;
                btnHuy.Enabled = false;
                btnInHoaDon.Enabled = false;
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

        // Lấy mã hóa đơn
        public DataTable LayDSChiTietHD(string ma)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TraCuuChiTietHDTheoMaHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", ma);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return data;
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
        public string LaySoLuongSanPhamTonKho(string maSP, string maCH, int soCot)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LaySoLuongSanPham", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@MaCH", maCH);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data.Rows[0].Field<int>(soCot).ToString();
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

        // Lấy ngày nhập kho
        public string LayNgayNhapKho(string maSP, string maCH)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_LayNgayNhapKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@MaCH", maCH);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);
                return data.Rows[0].Field<DateTime>(0).ToString();
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
            if (LayThongTinSanPhamTheoTen(cboTenSP.Text, 0) != "")
            {
                txtMaSP.Text = LayThongTinSanPhamTheoTen(cboTenSP.Text, 0);
            }

            // Lấy giá sản phẩm
            txtDonGia.Text = LayThongTinSanPham(txtMaSP.Text, 5);
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (KiemTraKyTuNhap() == true && KiemTraSoKyTuNhap() == true)
            {
                btnThem.Enabled = true;
                // Hiển thị thành tiền
                txtThanhTien.Text = TinhThanhTien(int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text)).ToString();
            }
            else
            {
                btnThem.Enabled = false;
            }
        }

        // Tính thành tiền
        public long TinhThanhTien(int soLuong, int donGia)
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
                txtThanhTien.Text = TinhThanhTien(int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text)) + "";
            }
            else
            {
                btnThem.Enabled = false;

            }

            // Tạo tự động mã hóa đơn
            if (KiemTraHoaDonDaTonTai(txtMaHD.Text) == false)
            {
                txtMaChiTiet.Text = "1";
            }
            else
            {
                DataTable dataTable = LayDSChiTietHD(txtMaHD.Text);
                // Lấy mã chi tiết ở vị trí cuối cùng + 1
                int maChiTiet = int.Parse(dataTable.Rows[dataTable.Rows.Count - 1].Field<string>(0)) + 1;
                txtMaChiTiet.Text = maChiTiet.ToString();
            }
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
            txtMaChiTiet.Clear();
            txtSoLuong.Clear();

            // Chặn nút thêm
            btnThem.Enabled = false;

            // Cập nhật lại thảnh tiển
            txtThanhTien.Text = "0";
        }

        // Tạo hóa đơn
        public void TaoHoaDon()
        {
            // Tạo hóa đơn mới
            HoaDon hoaDon = new HoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, DBCuaHang.ChangeToDate(dtpNgayTao.Text), txtMaCH.Text, DBCuaHang.GetNvarcharText(cboPhuongThucTT.Text), 0);
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
                HoaDon hoaDon = new HoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, DBCuaHang.ChangeToDate(dtpNgayTao.Text), txtMaCH.Text, DBCuaHang.GetNvarcharText(cboPhuongThucTT.Text), int.Parse(txtTongTien.Text));
                // Cập nhật vào hóa đơn
                int capNhatHD = DBCuaHang.UpdateRowData("sp_SuaHoaDon", hoaDon);

                // Lấy số lượng
                int soLuong = int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text, txtMaCH.Text, 0));
                int soLuongConLai = int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text, txtMaCH.Text, 1)) - int.Parse(txtSoLuong.Text);

                // Cập nhật số lượng
                //TonKho tonKho = new TonKho(txtMaCH.Text, txtMaSP.Text, DBCuaHang.ChangeToDate(LayNgayNhapKho(txtMaSP.Text, txtMaCH.Text)), soLuong, txtMaCH.Text, txtMaSP.Text,  soLuongConLai);
                //int capNhatSL = DBCuaHang.UpdateRowData("sp_SuaTonKho", tonKho);
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
            // Cập nhật số lượng
            DataTable dataTable = LayDSChiTietHD(txtMaHD.Text);
            int soLuong = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                soLuong += int.Parse(dataTable.Rows[i].Field<int>(3).ToString());
            }
            int soLuongConLai = int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text, txtMaCH.Text, 1));
            //TonKho tonKho = new TonKho(txtMaCH.Text, txtMaSP.Text, DBCuaHang.ChangeToDate(LayNgayNhapKho(txtMaSP.Text, txtMaCH.Text)), int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text, txtMaCH.Text, 0)), txtMaCH.Text, txtMaSP.Text, (soLuongConLai + soLuong));
            //int capNhatSL = DBCuaHang.UpdateRowData("sp_SuaTonKho", tonKho);

            XoaChiTietHD();
            XoaHoaDon();

            // Tải lại danh sách
            dgvChiTietHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiChiTietHD");

            // Xóa các textbox
            txtMaHD.Clear();
            txtMaChiTiet.Clear();
            txtSoLuong.Clear();

            // Bỏ chặn sửa mã hoá đơn
            txtMaHD.Enabled = true;

            // Chặn nút xóa hóa đơn
            btnXoa.Enabled = false;

            // Chặn nút sửa hóa đơn
            btnSua.Enabled = false;

            // Chặn nút hủy hóa đơn
            btnHuy.Enabled = false;

            // Chặn nút in
            btnInHoaDon.Enabled = false;
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
            HoaDon hoaDon = new HoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, DBCuaHang.ChangeToDate(dtpNgayTao.Text), txtMaCH.Text, DBCuaHang.GetNvarcharText(cboPhuongThucTT.Text), int.Parse(txtTongTien.Text));
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

            if (dong > 0)
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thành công!!!", "Thông báo");

                //DataTable data = LayDSChiTietHD(txtMaHD.Text);
                //// Tính tổng số lượng đã mua
                //int tongSoLuong = 0;
                //long tongTien = 0;
                //for (int i = 0; i < data.Rows.Count; i++)
                //{
                //    tongSoLuong += data.Rows[i].Field<int>(3);
                //    tongTien += TinhThanhTien(data.Rows[0].Field<int>(3), int.Parse(LayThongTinSanPham(txtMaSP.Text, 5)));
                //}
                //int soLuongBanDau = int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text, txtMaCH.Text, 0));

                //// Cập nhật số lượng
                //TonKho tonKho = new TonKho(txtMaCH.Text, txtMaSP.Text, DBCuaHang.ChangeToDate(LayNgayNhapKho(txtMaSP.Text, txtMaCH.Text)), int.Parse(LaySoLuongSanPhamTonKho(txtMaSP.Text, txtMaCH.Text, 0)), txtMaCH.Text, txtMaSP.Text, (soLuongBanDau - tongSoLuong));
                //int capNhatSL = DBCuaHang.UpdateRowData("sp_SuaTonKho", tonKho);

                //// Cập nhật thành tiền
                //HoaDon hoaDon = new HoaDon(txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, DBCuaHang.ChangeToDate(dtpNgayTao.Text), txtMaCH.Text, DBCuaHang.GetNvarcharText(cboPhuongThucTT.Text), (int)tongTien);
                //int dongHD = DBCuaHang.UpdateRowData("sp_SuaHoaDon", hoaDon);
            }
            else
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thất bại", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Sửa chi tiết hóa đơn
            SuaChiTietHoaDon();

            // Sửa hóa đơn
            SuaHoaDon();

            // Tải lại danh sách
            dgvChiTietHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiChiTietHD");

            // Xóa các textbox
            txtMaChiTiet.Clear();
            txtSoLuong.Clear();

            // Bỏ chặn sửa mã hóa đơn
            txtMaHD.Enabled = true;

            // Chặn nút xóa hóa đơn
            btnXoa.Enabled = false;

            // Chặn nút sửa hóa đơn
            btnSua.Enabled = false;

            // Chặn nút hủy hóa đơn
            btnHuy.Enabled = false;

            // Chặn nút in
            btnInHoaDon.Enabled = false;
        }

        private void txtMaHD_Leave(object sender, EventArgs e)
        {
            if (KiemTraSoKyTuNhap() == true && KiemTraKyTuNhap() == true)
            {
                btnThem.Enabled = true;
                // Hiển thị thành tiền
                txtThanhTien.Text = TinhThanhTien(int.Parse(txtSoLuong.Text), int.Parse(txtDonGia.Text)) + "";
            }
            else
            {
                btnThem.Enabled = false;
            }

            // Tạo tự động mã hóa đơn
            if (KiemTraHoaDonDaTonTai(txtMaHD.Text) == false)
            {
                txtMaChiTiet.Text = "1";
            }
            else
            {
                DataTable dataTable = LayDSChiTietHD(txtMaHD.Text);
                // Lấy mã chi tiết ở vị trí cuối cùng + 1
                int maChiTiet = int.Parse(dataTable.Rows[dataTable.Rows.Count - 1].Field<string>(0)) + 1;
                txtMaChiTiet.Text = maChiTiet.ToString();
            }
        }
        public static string maHD = "";
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            frmBaoCao_DSChiTietHD frmBaoCao_ChiTiet = new frmBaoCao_DSChiTietHD();
            maHD = txtMaHD.Text;
            frmBaoCao_ChiTiet.Show();
        }
    }
}