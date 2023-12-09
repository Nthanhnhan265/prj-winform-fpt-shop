using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_fpt_shop
{
    public partial class frmSanPham_TonKho : Form
    {
        //khai báo 
        private string maSP_Cu ;
        private string maCH_Cu;
        private int hangDuocChon = -1;

        public frmSanPham_TonKho()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void frmSanPham_TonKho_Load(object sender, EventArgs e)
        {
            try
            {

                //lấy các bản để hiển thị ra danh sách và cbb 
                DataTable tbDanhSachTonKho = DBCuaHang.GetDataTable("sp_CuaHangJoinSanPham");
                DataTable tbCuaHang = DBCuaHang.GetDataTable("sp_HienThiCuaHang");
                DataTable tbSanPham = DBCuaHang.GetDataTable("sp_HienThiSanPham");
                //gán các datasource cho bảng 
                dgvDanhSachTonKho.DataSource = tbDanhSachTonKho;
                cbbTenCH.DataSource = tbCuaHang;
                cbbTenSP.DataSource = tbSanPham;
                //hiển thị tên nhưng chọn mã
                cbbTenCH.DisplayMember = "TenCH";
                cbbTenCH.ValueMember = "MaCH";
                cbbTenSP.DisplayMember = "TenSP";
                cbbTenSP.ValueMember = "MaSP";
                //Hiển thị lên combobox 
                txtMaCh.Text = dgvDanhSachTonKho.Rows[0].Cells[0].Value.ToString();
                txtDiaChi.Text = dgvDanhSachTonKho.Rows[cbbTenCH.SelectedIndex].Cells[2].Value.ToString();
                txtMaSP.Text = cbbTenSP.SelectedValue.ToString();
                txtSoLuong.Text = dgvDanhSachTonKho.Rows[0].Cells[5].Value.ToString();

            }
            catch
            {

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDanhSachTonKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMaCh.Text = dgvDanhSachTonKho.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaSP.Text = dgvDanhSachTonKho.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvDanhSachTonKho.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvDanhSachTonKho.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbbTenCH.Text= dgvDanhSachTonKho.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbbTenSP.Text= dgvDanhSachTonKho.Rows[e.RowIndex].Cells[4].Value.ToString();
            hangDuocChon = e.RowIndex;
            maCH_Cu = txtMaCh.Text; 
            maSP_Cu = txtMaSP.Text; 
        
        }
        /// <summary>
        /// Nút xóa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                //Kiểm tra đã chọn hàng nào hay chưa 
                if (txtMaCh.Text != "" && txtMaSP.Text != "")
                {
                    //Hỏi xem có chắc chắn muốn xóa 
                    DialogResult rs = MessageBox.Show("bạn có muốn xóa? ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        if (DBCuaHang.DelRowData("sp_XoaTonKho", txtMaCh.Text, txtMaSP.Text))
                        {
                            MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            taiLaiDuLieu();
                        }
                        else
                        {
                            MessageBox.Show("Xóa Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Hãy chọn 1 hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Không thành công" + ex.Message);
            }
        }
        /// <summary>
        /// Ấn để thêm dữ liệu tồn kho 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuong = 0;
                try
                {
                    soLuong = int.Parse(txtSoLuong.Text.ToString());
                    if (DBCuaHang.AddRowData("sp_ThemTonKho", new TonKho(txtMaCh.Text, txtMaSP.Text, soLuong,"","")) > 0)
                    {
                        taiLaiDuLieu();
                        MessageBox.Show($"Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show($"Có Lỗi xảy ra: \n Hoặc dữ liệu đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có Lỗi xảy ra: dữ liệu nhập vào không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                int soLuong = 0;
                try
                {
                    soLuong = int.Parse(txtSoLuong.Text.ToString());
                    if (DBCuaHang.UpdateRowData("sp_SuaTonKho", new TonKho(txtMaCh.Text, txtMaSP.Text, soLuong,maCH_Cu,maSP_Cu)) > 0)
                    {
                        taiLaiDuLieu();
                        MessageBox.Show($"Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show($"Có Lỗi xảy ra: \n Hoặc dữ liệu đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có Lỗi xảy ra: dữ liệu nhập vào không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        /// <summary>
        /// Load lại mã khi chọn cbb 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTenCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenCH.SelectedValue.ToString() != "")
            {
                txtMaCh.Text = cbbTenCH.SelectedValue.ToString();
                txtDiaChi.Text = dgvDanhSachTonKho.Rows[cbbTenCH.SelectedIndex].Cells[2].Value.ToString();

            }
        }
        /// <summary>
        /// Load lại mã khi chọn cbb 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenSP.SelectedValue.ToString() != "")
            {
                txtMaSP.Text = cbbTenSP.SelectedValue.ToString();

            }

        }
        /// <summary>
        /// tải lại dữ liệu cho bảng 
        /// </summary>
        private void taiLaiDuLieu()
        {
            //lấy các bản để hiển thị ra danh sách và cbb 
            DataTable tbDanhSachTonKho = DBCuaHang.GetDataTable("sp_CuaHangJoinSanPham");
            DataTable tbCuaHang = DBCuaHang.GetDataTable("sp_HienThiCuaHang");
            DataTable tbSanPham = DBCuaHang.GetDataTable("sp_HienThiSanPham");
            //gán các datasource cho bảng 
            dgvDanhSachTonKho.DataSource = tbDanhSachTonKho;
            cbbTenCH.DataSource = tbCuaHang;
            cbbTenSP.DataSource = tbSanPham;
            //hiển thị tên nhưng chọn mã
            cbbTenCH.DisplayMember = "TenCH";
            cbbTenCH.ValueMember = "MaCH";
            cbbTenSP.DisplayMember = "TenSP";
            cbbTenSP.ValueMember = "MaSP";
            //
            txtMaCh.Text = dgvDanhSachTonKho.Rows[0].Cells[0].Value.ToString();
            txtDiaChi.Text = dgvDanhSachTonKho.Rows[cbbTenCH.SelectedIndex].Cells[2].Value.ToString();
            txtMaSP.Text = cbbTenSP.SelectedValue.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            string str = txtSoLuong.Text;
            if(int.TryParse(str,out _))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "Vui lòng nhập số!");
            }
        }
    }
}
