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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmHoaDon_ChiTiet  frm = new frmHoaDon_ChiTiet();
            frm.ShowDialog(); 
        }
    }
}
