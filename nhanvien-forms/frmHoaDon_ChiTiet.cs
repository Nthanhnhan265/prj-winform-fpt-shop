using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        public frmHoaDon_ChiTiet()
        {
            InitializeComponent();
        }
        frmNhanVien frmNhanVien;
        public static string maHD; 

        public frmNhanVien FrmNhanVien { get => frmNhanVien; set => frmNhanVien = value; }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            //load thong tin chung ve hoa don 
            DataTable dataTable = LayThongTinHD(frmHoaDon_DanhSach.maHD); 
            if(dataTable.Rows.Count>0)
            {
                txtMaHD.Text = dataTable.Rows[0][0].ToString();
                txtMaCH.Text = dataTable.Rows[0][4].ToString(); 
                txtMaNV.Text=dataTable.Rows[0][2].ToString();
                txtTenNV.Text = dataTable.Rows[0][8].ToString();
                txtMaKH.Text = dataTable.Rows[0][1].ToString();
                txtTenKH.Text = dataTable.Rows[0][20].ToString();
                dateTimePicker1.Text = dataTable.Rows[0][3].ToString();
                cboPhuongThucTT.Text = dataTable.Rows[0][5].ToString();
                txtSDT.Text = dataTable.Rows[0][23].ToString(); 
            }


            //load chi tiet san pham da mua 
            dgvChiTietHD.DataSource = LayDSChiTietHD(frmHoaDon_DanhSach.maHD);
        }

        // Lấy dang sách chi tiết hóa đơn
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

        //lấy thông tin chung từ chi tiết hoá đơn 
        public DataTable LayThongTinHD(string ma)
        {
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_HienThiThongTinHoaDon", conn);
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

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            maHD = txtMaHD.Text; 
            frmNhanVien.MoFormInHoaDon(); 
        }
    }
}
