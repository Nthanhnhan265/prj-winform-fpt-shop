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
            dgvHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiChiTietHD");
            
            // Lấy mã, tên nhân viên cho cboTenNV
            cboTenNV.DataSource = DBCuaHang.GetDataTable("sp_HienThiNhanVien");
            cboTenNV.ValueMember = "MaNV";
            cboTenNV.DisplayMember = "HoTen";

            // Lấy mã, tên khách hàng cho cboMaKhachHang
            cboTenKH.DataSource = DBCuaHang.GetDataTable("sp_HienThiKhachHang");
            cboTenKH.ValueMember = "MaKH";
            cboTenKH.DisplayMember = "HoTenKH";

            // Lấy mã, tên sản phẩm cho cboMaSP
            cboMaSP.DataSource = DBCuaHang.GetDataTable("sp_HienThiSanPham");
            cboMaSP.ValueMember = "MaSP";
            cboMaSP.DisplayMember = "MaSP";
        }

        private void cboPhuongThucTT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            // Số dòng của hóa đơn và chi tiết hóa đơn
            int dong = dgvHoaDon.CurrentCell.RowIndex;

            // Lấy thông tin chi tiết hóa đơn từ datagridview lên


            // Lấy thông tin hóa đơn ở dòng tương ứng với chi tiết hóa đơn
        }

        private void cboTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị mã nhân viên ỡ cboMaNV
            txtMaNV.Text = cboTenNV.SelectedValue.ToString();

            // Hiển thị mã cửa hàng
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            SqlCommand cmd = new SqlCommand("sp_HienThiNhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            conn.Open();
            da.Fill(dataTable);
            conn.Close();
            txtMaCH.Text = dataTable.Columns[8].Table.Rows[0].Field<string>(0);
        }

        private void cboTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaKH.Text = cboTenKH.SelectedValue.ToString();
        }
    }
}
