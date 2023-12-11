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

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        public frmHoaDon_ChiTiet()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
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
    }
}
