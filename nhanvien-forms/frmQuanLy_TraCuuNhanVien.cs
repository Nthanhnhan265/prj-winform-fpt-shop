using System;
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
    public partial class frmQuanLy_TraCuuNhanVien : Form
    {
        public frmQuanLy_TraCuuNhanVien()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmQuanLy_TraCuuNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = DBCuaHang.GetDataTable("sp_HienThiNhanVien");
            //
            cboTimKiem.DataSource = new string[] {
                "Mã nhân viên",
                "Tên nhân viên",
                "CCCD",
                "Số điện thoại",
                "Email",
                "Địa chỉ"};

            cboTimKiem.SelectedIndex = 0; 

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = DBCuaHang.GetDataTable("sp_HienThiNhanVien"); 
        }
            //ấn tìm kiếm khi nhập đủ thông tin 
            private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if(txtTimKiem.Text!="")
            {
                DataTable dt = new DataTable(); 
                string str =txtTimKiem.Text;
                str = str.Trim();
                if(str.Contains("  "))
                {
                    for (int i = 1; i < str.Length - 1; i++)
                    {
                        if(str.Contains("  "))
                        {
                           str= str.Replace("  "," "); 
                        }
                    }
                    
                }else
                {

                }
                txtTimKiem.Text = str; 
                switch(cboTimKiem.SelectedIndex)
                {
                    //mã 
                    case 0:
                        dt=DBCuaHang.FindBy("sp_TimKiemNhanVienTheoMaNV",txtTimKiem.Text); 
                        break;
                    //tên 
                    case 1:
                        dt=DBCuaHang.FindBy("sp_TimKiemNhanVienTheoTenNV", 
                            DBCuaHang.GetNvarcharText(txtTimKiem.Text)); 
                        break;
                    //cccd 
                    case 2:
                        dt=DBCuaHang.FindBy("sp_TimKiemNhanVienTheoCCCD", txtTimKiem.Text); 

                        break;

                    //sdt 
                    case 3:
                        dt=DBCuaHang.FindBy("sp_TimKiemNvhanVienTheoSDT", txtTimKiem.Text); 


                        break;
                    //email 
                    case 4:
                        dt=DBCuaHang.FindBy("sp_TimKiemNhanVienTheoEmail", txtTimKiem.Text); 

                        break;

                    //dia chi 
                    case 5:
                        dt=DBCuaHang.FindBy("sp_TimKiemNhanVienTheoDiaChi", DBCuaHang.GetNvarcharText(txtTimKiem.Text)); 

                        break;
                }
                dgvNhanVien.DataSource=dt;
            }else
            {
                errorProvider1.SetError(txtTimKiem,"Vui lòng nhập thông tin cần tìm!"); 
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text!="")
            {
                errorProvider1.Clear(); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmQuanLy_TraCuuNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult rd = MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rd == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
