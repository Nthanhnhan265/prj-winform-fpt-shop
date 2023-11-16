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
    public partial class frmSanPham_DanhSach : Form
    {
        public frmSanPham_DanhSach()
        {
            InitializeComponent();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSanPham_DanhSach_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = DBCuaHang.GetDataTable("sp_HienThiSanPham");
        }
    }
}
