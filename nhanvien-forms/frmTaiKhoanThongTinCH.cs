﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmTaiKhoanThongTinCH : Form
    {
        public frmTaiKhoanThongTinCH()
        {
            InitializeComponent();
        }

        private void dgvCuaHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTaiKhoanThongTinCH_Load(object sender, EventArgs e)
        {
            //Hiển thị nút sửa thông tin cửa hàng
            if (frmDangNhap.QuyenQuanLy())
            {
                btnChinhSua.Enabled = true;
            }
            else
            {
                btnChinhSua.Enabled = false;
            }
            //Hiển thị thông tin cửa hàng của nhân viên 
            DataTable table = DBCuaHang.FindBy("sp_TimCuaHangQuaMaCH",frmDangNhap.LayMaCH());
    
            cboTenQL.DataSource = DBCuaHang.GetDataTable("sp_HienThiNhanVien");
            cboTenQL.DisplayMember = "HoTen";
            cboTenQL.ValueMember = "MaNV"; 

            if(table!=null)
            {
                LbMaCh.Text = table.Rows[0]["MaCH"].ToString(); 
                LbTenCH.Text = table.Rows[0]["TenCH"].ToString(); 
                LbDiaChi.Text = table.Rows[0]["DiaChi"].ToString(); 
                LbNgayKhaiTruong.Text = table.Rows[0]["NgayKhaiTruong"].ToString(); 
                LbTenQL.Text = table.Rows[0]["QuanLy"].ToString();
                cboTenQL.SelectedValue = LbTenQL.Text; 
                LbSDTQuanLy.Text = table.Rows[0]["SoDienThoai"].ToString(); 
            }
        }


        public void TaiLaiForm()
        {
            //Hiển thị nút sửa thông tin cửa hàng
            if (frmDangNhap.QuyenQuanLy())
            {
                btnChinhSua.Enabled = true;
            }
            else
            {
                btnChinhSua.Enabled = false;
            }
            //Hiển thị thông tin cửa hàng của nhân viên 
            DataTable table = DBCuaHang.FindBy("sp_TimCuaHangQuaMaCH", frmDangNhap.LayMaCH());

            cboTenQL.DataSource = DBCuaHang.GetDataTable("sp_HienThiNhanVien");
            cboTenQL.DisplayMember = "HoTen";
            cboTenQL.ValueMember = "MaNV";

            if (table != null)
            {
                LbMaCh.Text = table.Rows[0]["MaCH"].ToString();
                LbTenCH.Text = table.Rows[0]["TenCH"].ToString();
                LbDiaChi.Text = table.Rows[0]["DiaChi"].ToString();
                LbNgayKhaiTruong.Text = table.Rows[0]["NgayKhaiTruong"].ToString();
                LbTenQL.Text = table.Rows[0]["QuanLy"].ToString();
                cboTenQL.SelectedValue = LbTenQL.Text;
                LbSDTQuanLy.Text = table.Rows[0]["SoDienThoai"].ToString();
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ấn để mở form chỉnh sửa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            frmheThongChinhSuaCH frm = new frmheThongChinhSuaCH(this); 
            frm.MdiParent = this.Owner;
            frm.ShowDialog(); 

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
