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
using winform_fpt_shop.classes;
using winform_fpt_shop.nhanvien_forms;

namespace winform_fpt_shop
{
    public partial class frmHoaDon_DanhSach : Form
    {
        public frmHoaDon_DanhSach()
        {
            InitializeComponent();
        }
        // Khai báo
        public static string maHD;

        private void frmHoaDon_DanhSach_Load(object sender, EventArgs e)
        {
            txtTimKiemHoaDon.Focus();
            dgvHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiHoaDon");
            cboTimKiem.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiemHoaDon.Text != "")
            {
                TimKiemHoaDon();
            }
            else
            {
                // Tải lại danh sách
                dgvHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiHoaDon");
            }
        }

        public void TimKiemHoaDon()
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                switch (cboTimKiem.SelectedIndex)
                {
                    case 0:
                        cmd.CommandText = "sp_TraCuuHoaDonTheoMaHD";
                        SqlParameter paramHD = new SqlParameter("@MaHD", txtTimKiemHoaDon.Text);
                        cmd.Parameters.Add(paramHD);
                        SqlDataAdapter adapterHD = new SqlDataAdapter(cmd);
                        adapterHD.Fill(dataTable);
                        dgvHoaDon.DataSource = dataTable;
                    break;

                    case 1:
                        cmd.CommandText = "sp_TraCuuHoaDonTheoMaKH";
                        SqlParameter paramKH = new SqlParameter("@MaKH", txtTimKiemHoaDon.Text);
                        cmd.Parameters.Add(paramKH);
                        SqlDataAdapter adapterKH = new SqlDataAdapter(cmd);
                        adapterKH.Fill(dataTable);
                        dgvHoaDon.DataSource = dataTable;
                    break;

                    case 2:
                        cmd.CommandText = "sp_TraCuuHoaDonTheoMaNV";
                        SqlParameter paramNV = new SqlParameter("@MaNV", txtTimKiemHoaDon.Text);
                        cmd.Parameters.Add(paramNV);
                        SqlDataAdapter adapterNV = new SqlDataAdapter(cmd);
                        adapterNV.Fill(dataTable);
                        dgvHoaDon.DataSource = dataTable;
                    break;

                    case 3:
                        cmd.CommandText = "sp_TraCuuHoaDonTheoMaCH";
                        SqlParameter paramCH = new SqlParameter("@MaCH", txtTimKiemHoaDon.Text);
                        cmd.Parameters.Add(paramCH);
                        SqlDataAdapter adapterCH = new SqlDataAdapter(cmd);
                        adapterCH.Fill(dataTable);
                        dgvHoaDon.DataSource = dataTable;
                    break;


                    case 4:
                        cmd.CommandText = "sp_TraCuuHoaDonTheoPTThanhToan";
                        SqlParameter paramPTTT = new SqlParameter("@PTThanhToan", $"%{txtTimKiemHoaDon.Text}%");
                        cmd.Parameters.Add(paramPTTT);
                        SqlDataAdapter adapterPTTT = new SqlDataAdapter(cmd);
                        adapterPTTT.Fill(dataTable);
                        dgvHoaDon.DataSource = dataTable;
                    break;


                    case 5:
                        cmd.CommandText = "sp_TraCuuHoaDonTheoSoTienTT";
                        SqlParameter paramSTTT = new SqlParameter("@SoTienTT", int.Parse(txtTimKiemHoaDon.Text));
                        cmd.Parameters.Add(paramSTTT);
                        SqlDataAdapter adapterSTTT = new SqlDataAdapter(cmd);
                        adapterSTTT.Fill(dataTable);
                        dgvHoaDon.DataSource = dataTable;
                    break;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dgvHoaDon = null;
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            // Lấy số dòng được chọn
            int dong = dgvHoaDon.CurrentCell.RowIndex;
            maHD = dgvHoaDon.Rows[dong].Cells[0].Value.ToString();

            // Sang form chi tiết hóa đơn
            frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet();
            chiTiet.Show();
        }
    }
}
