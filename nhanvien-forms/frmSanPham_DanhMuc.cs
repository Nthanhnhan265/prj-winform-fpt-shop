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

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmSanPham_DanhMucSP : Form
    {
        public frmSanPham_DanhMucSP()
        {
            InitializeComponent();
        }
        DBCuaHang dBCuaHang = new DBCuaHang();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmSanPham_DanhMucSP_Load(object sender, EventArgs e)
        {
            
            dgvDanhMuc.DataSource = dBCuaHang.GetDataTable("sp_HienThiDanhMuc"); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaDanhMuc.Text!="" && txtTenDM.Text!="" || txtThuocTinh.Text!="")
                {
                    DanhMuc danhMuc = new DanhMuc(txtMaDanhMuc.Text,txtTenDM.Text,txtThuocTinh.Text);
                    int dong = dBCuaHang.AddRowData("sp_ThemDanhMuc", danhMuc); 
                    if (dong!=0)
                    {
                        dgvDanhMuc.DataSource= dBCuaHang.GetDataTable("sp_HienThiDanhMuc"); 
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
    }
}
