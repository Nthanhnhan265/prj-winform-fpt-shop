using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_fpt_shop
{
    public partial class frmThongTinCuaHang : Form
    {
        public frmThongTinCuaHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemCuaHang frmThemCuaHang = new frmThemCuaHang();
            frmThemCuaHang.Show();
        }
    }
}
