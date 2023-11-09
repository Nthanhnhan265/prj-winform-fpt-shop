using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.manhinhchung_forms;

namespace winform_fpt_shop
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        static bool Thoat = false;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
             string quyenHan = txtUser.Text;
                if (rdQuanLy.Checked == true) // quản lý
                {
                    frmNhanVien mainForm = new frmNhanVien();
                    mainForm.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
                else if (rdNhanVien.Checked == true) // nhân viên
                {
                    frmNhanVien mainForm = new frmNhanVien();
                    mainForm.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
           

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {

        }

        private void rdQuanLy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_Layout(object sender, LayoutEventArgs e)
        {

        }

        

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true ;
            }
            else
            {
                Environment.Exit(1); 
                Thoat = true; 
            }
        }
    }
}
