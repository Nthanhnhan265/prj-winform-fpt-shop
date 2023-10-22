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
    public partial class frmDanhSachNhanVien : Form
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (listNhanVien.SelectedItems.Count > 0)
                {
                    listNhanVien.Items.Remove(listNhanVien.SelectedItems[0]);
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn nhân viên");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThem them = new frmThem();
            them.Show();
        }
    }
}
