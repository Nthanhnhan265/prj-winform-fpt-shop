using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 
namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmNhaSanXuat : Form
    {
        public frmNhaSanXuat()
        {
            InitializeComponent();
        }
        string patternString = "^[a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ.,\\s-]+$";



        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            //load len datagrid 
            DataTable data= DBCuaHang.GetDataTable("sp_HienThiNhaSX");
            dgvNhaSX.DataSource = data;
            
        }
        /// <summary>
        /// random mã
        /// </summary>
        /// <returns></returns>
        private string RandomMa()
        {
            const string template = "NSXFPTXXX";
            Random random = new Random();

            // Thay thế XXXXXX bằng ký tự ngẫu nhiên
            string result = template
                .Replace("XXX", random.Next(100, 999).ToString());
            return result;
        }
        /// <summary>
        /// Tải lại dữ liệu 
        /// </summary>
        private void TaiLaiDuLieu()
        {
            //load len datagrid 
            DataTable data = DBCuaHang.GetDataTable("sp_HienThiNhaSX");
            dgvNhaSX.DataSource = data;
            txtTen.Text = ""; 
            txtMa.Text = "";
            errorProvider1.Clear(); 
        }
        
       
        private void dgvNhaSX_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvNhaSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = dgvNhaSX.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMa.Text = dgvNhaSX.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnTaoMoi_Click_1(object sender, EventArgs e)
        {
            txtMa.Text = RandomMa();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtTen.Text, patternString))
            {
                errorProvider1.SetError(txtTen, "Vui lòng chỉ nhập chữ cái và số");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (DBCuaHang.AddRowData("sp_ThemNhaSX",
                        new NhaSX(
                        txtMa.Text,
                        DBCuaHang.GetNvarcharText(txtTen.Text)
                        )) > 0)
                    {
                        TaiLaiDuLieu();
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (DBCuaHang.UpdateRowData("sp_SuaNhaSX", new NhaSX(
                        txtMa.Text,
                        DBCuaHang.GetNvarcharText(txtTen.Text))) > 0)
                    {
                        TaiLaiDuLieu();
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

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra đã chọn hàng nào hay chưa 
                if (txtTen.Text != "" && txtMa.Text != "")
                {
                    //Hỏi xem có chắc chắn muốn xóa 
                    DialogResult rs = MessageBox.Show("bạn có muốn xóa? ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        if (DBCuaHang.DelRowData("sp_XoaNhaSX", txtMa.Text))
                        {
                            TaiLaiDuLieu();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
