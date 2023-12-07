using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.nhanvien_forms;

namespace winform_fpt_shop
{
    public partial class frmHoaDon_DanhSach : Form
    {
        public frmHoaDon_DanhSach()
        {
            InitializeComponent();
        }


        private void txtTimKiemHoaDon_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemHoaDon.Text.Length  > 0)
            {
                btnTimKiem.Enabled = true;
            }
            else
            {
                btnTimKiem.Enabled = false;
            }
        }

        private void frmHoaDon_DanhSach_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = DBCuaHang.GetDataTable("sp_HienThiHoaDon");
        }
    }
}
