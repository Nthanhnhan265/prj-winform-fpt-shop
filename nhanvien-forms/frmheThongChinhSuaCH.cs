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
    public partial class frmheThongChinhSuaCH : Form
    {
        public frmheThongChinhSuaCH()
        {
            InitializeComponent();
        }
        
        public frmheThongChinhSuaCH(frmTaiKhoanThongTinCH thongTinCH )
        {
            thongTinCh=thongTinCH;  
            InitializeComponent();
        }
        frmTaiKhoanThongTinCH thongTinCh;

        //khai bao 
        string patternNumber = "^[0-9]+$";
        string patternString = "^[a-z0-9A-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
        string patternDiaChi = "^[a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ,\\s-]+$";
        DateTime homNay = DateTime.Now; 

        /// <summary>
        /// Hiển thị khi form được hiển thị 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmheThongChinhSuaCH_Load(object sender, EventArgs e)
        {
            try
            {
                //hiển thị dữ liệu khi thuộc cửa hàng nào đó 
                dgvCuaHang.DataSource = DBCuaHang.GetDataTable("sp_HienThiCuaHang");
                cboQuanLy.DataSource = DBCuaHang.GetDataTableFromQuery("SELECT * FROM NHANVIEN WHERE QuyenHan=N'Quản Lý'");
                cboQuanLy.DisplayMember = "HoTen";
                cboQuanLy.ValueMember = "MaNV";
                if (frmDangNhap.LayMaCH() != "" && thongTinCh != null)
                {
                    //hiển thị dữ liệu từ màn hình chỉnh sửa 
                    txtMaCH.Text = thongTinCh.LbMaCh.Text;
                    txtDiaChi.Text = thongTinCh.LbDiaChi.Text;
                    txtTenCH.Text = thongTinCh.LbTenCH.Text;
                    txtSDT.Text = thongTinCh.LbSDTQuanLy.Text;
                    cboQuanLy.Text = thongTinCh.LbTenQL.Text;
                    dtpNgayKhaiTruong.Text = thongTinCh.LbNgayKhaiTruong.Text;
                }
            }
            catch { }
            }
        /// <summary>
        /// Hàm random mã theo cấu trúc 
        /// </summary>
        /// <returns></returns>
        private string RandomMa()
        {
            const string template = "CHFPTXXX";
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
            dgvCuaHang.DataSource = DBCuaHang.GetDataTable("sp_HienThiCuaHang");
            txtMaCH.Text = "";
            txtTenCH.Text = "";
            txtSDT.Text = "";
            cboQuanLy.SelectedIndex = 0;
            dtpNgayKhaiTruong.Text = homNay.ToString();
            txtDiaChi.Text = "";
            txtTenCH.Focus(); 
            errorProvider1.Clear();
            frmDangNhap.TaiLaiTaiKhoan();
            //thongTinCh.TaiLaiForm();
            frmNhanVien.thongBao.ThongBaoCapNhatDuLieu(); 

        }

        private void cboQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ấn vào để tạo mã cho textbox mã 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txtMaCH.Text = RandomMa(); 
        }
        /// <summary>
        /// an de them vao dp 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                try
                {
                    if (
                        txtMaCH.Text != "" && txtTenCH.Text!="" && dtpNgayKhaiTruong.Text!="" && txtDiaChi.Text!="" && cboQuanLy.Text!=""
                        &&txtSDT.Text!="" 
                        && errorProvider1.GetError(txtTenCH)=="" 
                        && errorProvider1.GetError(txtDiaChi) == ""
                        && errorProvider1.GetError(txtSDT) == "" 
                        &&errorProvider1.GetError(dtpNgayKhaiTruong)==""
                        )
                    {
                        txtTenCH.Text = XuLyChuoi(txtTenCH.Text); 
                        txtDiaChi.Text = XuLyChuoi(txtDiaChi.Text); 
                        CuaHang ch = new CuaHang(
                        txtMaCH.Text,
                        DBCuaHang.GetNvarcharText(txtTenCH.Text),
                        DBCuaHang.GetNvarcharText(txtDiaChi.Text),
                        txtSDT.Text,
                        DBCuaHang.ChangeToDate(dtpNgayKhaiTruong.Text),
                        cboQuanLy.SelectedValue.ToString()
                        );
                        if (DBCuaHang.AddRowData("sp_ThemCuaHang",ch)>0)
                        {

                            TaiLaiDuLieu();
                            MessageBox.Show($"Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Có Lỗi xảy ra: \n Hoặc dữ liệu đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

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
        /// Chỉnh sửa dữ liệu vào DB 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (
                        txtMaCH.Text != "" && txtTenCH.Text != "" && dtpNgayKhaiTruong.Text != "" && txtDiaChi.Text != "" && cboQuanLy.Text != ""
                        && txtSDT.Text != ""
                        && errorProvider1.GetError(txtTenCH) == ""
                        && errorProvider1.GetError(txtDiaChi) == ""
                        && errorProvider1.GetError(txtSDT) == ""
                        && errorProvider1.GetError(dtpNgayKhaiTruong) == ""
                        )
                    {
                        txtTenCH.Text = XuLyChuoi(txtTenCH.Text);
                        txtDiaChi.Text = XuLyChuoi(txtDiaChi.Text);
                        CuaHang ch = new CuaHang(
                            txtMaCH.Text,
                            DBCuaHang.GetNvarcharText(txtTenCH.Text),
                            DBCuaHang.GetNvarcharText(txtDiaChi.Text),
                            txtSDT.Text,
                            DBCuaHang.ChangeToDate(dtpNgayKhaiTruong.Text),
                            cboQuanLy.SelectedValue.ToString()
                            );
                        if (DBCuaHang.UpdateRowData("sp_SuaCuaHang", ch) > 0)
                        {
                            TaiLaiDuLieu();
                            MessageBox.Show($"Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show($"Có Lỗi xảy ra: \n Hoặc dữ liệu đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
        /// Xóa 1 cửa hàng từ DB 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra đã chọn hàng nào hay chưa 
                if (txtMaCH.Text!="")
                {
                    //Hỏi xem có chắc chắn muốn xóa 
                    DialogResult rs = MessageBox.Show("bạn có muốn xóa? ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        if (DBCuaHang.DelRowData("sp_XoaCuaHang", txtMaCH.Text))
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
        /// <summary>
        /// ấn để hiển thị 1 cửa hàng lên các control 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvCuaHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgvCuaHangrow = dgvCuaHang.Rows[e.RowIndex];
                txtMaCH.Text = dgvCuaHangrow.Cells[0].Value.ToString();
                txtTenCH.Text = dgvCuaHangrow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvCuaHangrow.Cells[2].Value.ToString();
                txtSDT.Text = dgvCuaHangrow.Cells[3].Value.ToString();
                cboQuanLy.SelectedValue = dgvCuaHangrow.Cells[4].Value.ToString();
                dtpNgayKhaiTruong.Text = dgvCuaHangrow.Cells[5].Value.ToString();
            }
            catch { }
        
        }
        /// <summary>
        /// Ràng buộc cho trường tên CH bằng regex 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTenCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtTenCH.Text, patternString))
                {
                    errorProvider1.SetError(txtTenCH, "Vui lòng nhập tên hợp lệ!\n Tên hợp lệ chỉ chứa kí tự A-Z,0-9 hoặc kí tự trong bảng chữ cái tiếng Việt");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch { }
        }
        /// <summary>
        /// Ràng buộc cho trường địa chỉ bằng regex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtDiaChi.Text, patternDiaChi))
                {
                    errorProvider1.SetError(txtDiaChi, "Vui lòng nhập địa chỉ hợp lệ!\n Tên hợp lệ chỉ chứa kí tự A-Z hoặc kí tự trong bảng chữ cái tiếng Việt và kí tự phẩy (,) gạch ngang(-), dấu cách( )");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch { }
        }
        /// <summary>
        /// Ràng buộc cho trường số điện thoại bằng regex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtSDT.Text, patternNumber) && txtSDT.Text.Length > 10)
                {
                    errorProvider1.SetError(txtSDT, "Vui lòng chỉ nhập số và chỉ tối đa 10 kí tự!");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch { }
        }
        /// <summary>
        /// Ràng buộc cho trường ngày khai trương 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpNgayKhaiTruong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (homNay.CompareTo(DateTime.Parse(dtpNgayKhaiTruong.Text.ToString())) < 0)
                {
                    errorProvider1.SetError(dtpNgayKhaiTruong, "Ngày không hợp lệ!\nngày được chọn phải nhỏ hơn hôm nay");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch { }
        }
        /// <summary>
        /// xu ly chuoi truyen vao 
        /// </summary>
        /// <param name="chuoi"></param>
        /// <returns></returns>
        private string XuLyChuoi(string chuoi) 
        {
            string str = chuoi;
            str = str.Trim();
            if (str.Contains("  "))
            {
                for (int i = 1; i < str.Length - 1; i++)
                {
                    if (str.Contains("  "))
                    {
                        str = str.Replace("  ", " ");
                    }
                }

            }
            return str;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmheThongChinhSuaCH_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult rd = MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rd == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
