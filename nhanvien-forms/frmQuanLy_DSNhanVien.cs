﻿using System;
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
    public partial class frmQuanLy_DSNhanVien : Form
    {
        public frmQuanLy_DSNhanVien()
        {
            InitializeComponent();
        }
        string patternString = "^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
        string patternDiaChi = "^[a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ,\\s-]+$";
        string patternEmail = "^[a-zA-Z0-9@]+@gmail.com$";
        string patternNumber = "^[0-9]+$";

        private void frmDSNhanVien_Load(object sender, EventArgs e)
        {
            //hien thi du lieu khi load form 
            dgvNhanVien.DataSource = DBCuaHang.GetDataTable("sp_HienThiNhanVien");
            //hien thi len cbb 
            cboNoiLamViec.DataSource = DBCuaHang.GetDataTable("sp_HienThiCuaHangJoinQuanLy");
            cboNoiLamViec.DisplayMember = "TenCH";
            cboNoiLamViec.ValueMember = "MaCH";
            //hien thi quyen han 
            cboQuyenHan.Items.Add ("Nhân viên"); 
            cboQuyenHan.Items.Add ("Quản lý");
            cboQuyenHan.SelectedIndex = 0;
            //chọn nam 
            rdNam.Checked = true; 
        }

        private void cboQuyenHan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ấn để hiện lên control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        /// <summary>
        /// ấn để hiện thị lên control 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNQL = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString().Trim();
            if (maNQL!="")
            {
            DataTable dt = DBCuaHang.GetDataTableFromQuery($"SELECT * FROM NhanVien Where MaNV='{maNQL}'");
                if (dt.Rows.Count > 0)
                {
                    txtHoTenQL.Text = dt.Rows[0]["HoTen"].ToString();
                }
            }
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            txtCCCD.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            cboNoiLamViec.SelectedValue = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtMaNQL.Text = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.Rows[e.RowIndex].Cells[10].Value.ToString();
            cboQuyenHan.Text = dgvNhanVien.Rows[e.RowIndex].Cells[11].Value.ToString();
            errorProvider1.Clear(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Thêm nhân viên mới 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (DBCuaHang.AddRowData("sp_ThemNhanVien",
                        new NhanVien(
                        txtMaNV.Text, 
                        DBCuaHang.GetNvarcharText(txtHoTen.Text),
                        DBCuaHang.ChangeToDate(dtpNgaySinh.Text), 
                        DBCuaHang.GetNvarcharText(txtDiaChi.Text),
                        (rdNam.Checked == true) ? "Nam" : "N|Nữ",
                        txtCCCD.Text,
                        txtSDT.Text,
                        txtEmail.Text,
                        cboNoiLamViec.SelectedValue.ToString(),
                        txtHoTenQL.Text,
                        txtMatKhau.Text,
                        DBCuaHang.GetNvarcharText(cboQuyenHan.Text)
                        )
                        ) > 0)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (DBCuaHang.UpdateRowData("sp_CapNhatNhanVien", new NhanVien(
                        txtMaNV.Text,
                        DBCuaHang.GetNvarcharText(txtHoTen.Text),
                        DBCuaHang.ChangeToDate(dtpNgaySinh.Text),
                        DBCuaHang.GetNvarcharText(txtDiaChi.Text),
                        (rdNam.Checked == true) ? "Nam" : "N|Nữ",
                        txtCCCD.Text,
                        txtSDT.Text,
                        txtEmail.Text,
                        cboNoiLamViec.SelectedValue.ToString(),
                        txtMaNQL.Text,
                        txtMatKhau.Text,
                        DBCuaHang.GetNvarcharText(cboQuyenHan.Text)
                        )) > 0)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra đã chọn hàng nào hay chưa 
                if (txtMaNV.Text != "")
                {
                    //Hỏi xem có chắc chắn muốn xóa 
                    DialogResult rs = MessageBox.Show("bạn có muốn xóa? ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        if (DBCuaHang.DelRowData("sp_XoaNhanVien", txtMaNV.Text))
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
        /// Tạo mới mã 
        /// </summary>
        /// <returns></returns>
        private string RandomMa()
        {
            const string template = "NVFPTXXX";
            Random random = new Random();

            // Thay thế XXXXXX bằng ký tự ngẫu nhiên
            string result = template
                .Replace("XXX", random.Next(100, 999).ToString());
            return result;
        }

        private void TaiLaiDuLieu()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "1/1/1999";
            txtDiaChi.Text = "";
            rdNam.Checked = true;
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            cboNoiLamViec.SelectedIndex=0 ;
            txtMaNQL.Text = "";
            txtHoTenQL.Text = "";
            txtMatKhau.Text = "";
            cboQuyenHan.Text = "";
            errorProvider1.Clear(); 
            dgvNhanVien.DataSource = DBCuaHang.GetDataTable("sp_HienThiNhanVien"); 

        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = RandomMa(); 
        }
        private void btnTaoMoiMK_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "MK"+RandomMa(); 
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if(!Regex.IsMatch(txtHoTen.Text,patternString))
            {
                errorProvider1.SetError(txtHoTen,"Vui lòng nhập tên hợp lệ!"); 
            }else
            {
                errorProvider1.Clear(); 
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtCCCD.Text, patternNumber))
            {
                errorProvider1.SetError(txtCCCD, "Vui lòng chỉ nhập số và đủ 10 chữ số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSDT.Text, patternNumber))
            {
                errorProvider1.SetError(txtSDT, "Vui lòng chỉ nhập số và đủ 10 chữ số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtDiaChi.Text, patternDiaChi))
            {
                errorProvider1.SetError(txtDiaChi, "Vui lòng chỉ chữ,số và kí tự , - ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtEmail.Text, patternEmail))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng chỉ chữ,số và kí tự , - ");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtMatKhau.Text, "^[A-Z0-9a-z]+$"))
            {
                errorProvider1.SetError(txtEmail, "Vui lòng nhập trường này");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
