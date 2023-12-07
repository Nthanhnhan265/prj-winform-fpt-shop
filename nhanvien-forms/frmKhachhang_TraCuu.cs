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
    public partial class frmKhachhang_TraCuu : Form
    {
        public frmKhachhang_TraCuu()
        {
            InitializeComponent();
        }

        private void frmKhachhang_TraCuu_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = DBCuaHang.GetDataTable("sp_HienThiKhachHang");
        }

        private void frmKhachhang_TraCuu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                SqlConnection conn = new SqlConnection(DBCuaHang.sqlString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                if (cboTimKiem.SelectedIndex == 0)
                {
                    cmd.CommandText = "sp_TraCuuKhachHangTheoMa";
                    SqlParameter param = new SqlParameter("@MaKH", txtTraCuuKH.Text);
                    cmd.Parameters.Add(param);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                }
                else
                {
                    cmd.CommandText = "sp_TraCuuKhachHangTheoTen";
                    SqlParameter param = new SqlParameter("@HoTenKH", $"%{txtTraCuuKH.Text}%");
                    cmd.Parameters.Add(param);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                }
                conn.Close();
                dgvKhachHang.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvKhachHang.DataSource = null;
            }
        }

        private void txtTraCuuKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTraCuuKH.Text.Length > 0)
            {
                btnTimKiem.Enabled = true;
            }
            else
            { 
                btnTimKiem.Enabled = false;
            }
        }
    }
}
