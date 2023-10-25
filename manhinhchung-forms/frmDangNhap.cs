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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string quyenHan = txtUser.Text; 
            if(quyenHan=="0") //quan ly
            {
                frmQuanLy frmNhanVien = new frmQuanLy();
                frmNhanVien.Show();
                this.Hide();
            } else //nhan vien 
            {
                frmNhanVien frmNhanVien = new frmNhanVien();
                frmNhanVien.Show(); 
                this.Hide();

            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                new frmDangNhap().Show();
                this.Close();
            }
        }
    }
}
