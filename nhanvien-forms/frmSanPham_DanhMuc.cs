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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmSanPham_DanhMucSP : Form
    {
        public frmSanPham_DanhMucSP()
        {
            InitializeComponent();
        }
        //Khai báo 
        DataGridViewRow hangDuocChon = null;
        string patternThuocTinh = "^[a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s,]+$";
        string patternTen = "^[a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";

        private string RandomMa()
        {
           
            const string template = "DMFPTXXX";
            Random random = new Random();

            // Thay thế XXXXXX bằng ký tự ngẫu nhiên
            string result = template
                .Replace("XXX", random.Next(100, 999).ToString());
            return result;
        }
        private void frmSanPham_DanhMucSP_Load(object sender, EventArgs e)
        {

            txtTenDM.Focus();
            dgvDanhMuc.DataSource = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
        }


        public void LamMoi()
        {
            txtMaDanhMuc.Text = "";
            txtTenDM.Text = "";
            txtThuocTinh.Text = "";
            txtTenDM.Focus();
        }
        /// <summary>
        /// Phương thức xóa hàm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDanhMuc.Text != "" && txtTenDM.Text != "" || txtThuocTinh.Text != "")
                {
                    DanhMuc danhMuc = new DanhMuc(txtMaDanhMuc.Text, txtTenDM.Text, DBCuaHang.GetNvarcharText(txtThuocTinh.Text));
                    int dong = DBCuaHang.AddRowData("sp_ThemDanhMuc", danhMuc);
                    if (dong != 0)
                    {
                        LamMoi();
                        dgvDanhMuc.DataSource = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
                        MessageBox.Show($"Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm thất bại: số dòng được thêm {dong}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (hangDuocChon != null)
                {
                    DialogResult = MessageBox.Show($"Bạn có muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //Trường hợp xác nhận rõ muốn xóa 
                    if (DialogResult == DialogResult.Yes)
                    {
                        if (DBCuaHang.DelRowData("sp_XoaDanhMuc", hangDuocChon.Cells["MaDM"].Value.ToString()))
                        {
                            //thông báo xóa thành công 
                            //DBCuaHang.DelRowData("sp_XoaDanhMuc", txtMaDanhMuc.Text);
                            LamMoi();
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMaDanhMuc.Text = "";
                            txtTenDM.Text = "";
                            txtThuocTinh.Text = "";
                            hangDuocChon = null;
                        }
                        else
                        {
                            MessageBox.Show($"Xóa thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }

                }
                //Trường hợp chưa chọn 
                else
                {
                    MessageBox.Show($"Có Lỗi xảy ra: \nBạn chưa chọn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                dgvDanhMuc.DataSource = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //Sua 
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show($"Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Trường hợp xác nhận rõ muốn xóa 
                if (DialogResult == DialogResult.Yes)
                {
                    if (DBCuaHang.UpdateRowData("sp_SuaDanhMuc", new DanhMuc(txtMaDanhMuc.Text,
                        DBCuaHang.GetNvarcharText(txtTenDM.Text),
                        DBCuaHang.GetNvarcharText(txtThuocTinh.Text))) != -1)
                    {
                        //thông báo xóa thành công 
                        LamMoi();
                        dgvDanhMuc.DataSource = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Xóa thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }


                //Trường hợp chưa chọn 
                else
                {
                    MessageBox.Show($"Có Lỗi xảy ra: \nBạn chưa chọn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhMuc.SelectedRows.Count > 0)
                {
                    // Lấy toàn bộ dữ liệu của hàng được click
                    hangDuocChon = dgvDanhMuc.SelectedRows[0];
                    txtMaDanhMuc.Text = hangDuocChon.Cells["MaDM"].Value.ToString();
                    txtTenDM.Text = hangDuocChon.Cells["TenDM"].Value.ToString();
                    txtThuocTinh.Text = hangDuocChon.Cells["ThuocTinhDanhMuc"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txtTenDM_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtTenDM.Text, patternTen))
                {
                    errorProvider1.SetError(txtTenDM, "Vui lòng nhập kí tự hợp lệ\nKí tự hợp lệ chỉ chứa kí tự trong bảng chữ cái tiếng Việt và dấu phẩy(,)");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Text = RandomMa();
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDanhMuc.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtThuocTinh.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtThuocTinh_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (!Regex.IsMatch(txtThuocTinh.Text, patternThuocTinh))
                {
                    errorProvider1.SetError(txtThuocTinh, "Vui lòng nhập kí tự hợp lệ\nKí tự hợp lệ chỉ chứa kí tự trong bảng chữ cái tiếng Việt và dấu phẩy(,)");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
            }

        }
        /// <summary>
        /// Bat su kien roi form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSanPham_DanhMucSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rd = MessageBox.Show("Bạn có muốn thoát không?","Chú ý",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
            if(rd==DialogResult.No)
            {
                e.Cancel = true;
            }
        
        }
    }
}
