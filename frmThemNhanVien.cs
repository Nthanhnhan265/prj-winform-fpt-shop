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
    public partial class frmThem : Form
    {
        bool valid = false;
        public frmThem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (valid == true)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Lỗi");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            // Kiểm tra thông tin nhập
            if (hoTen.Length > 0)
            {
                // Ký tự nhập vào phải khác ký tự số, ký tự đặc biệt
                if (hoTen[hoTen.Length - 1] >= 'a' && hoTen[hoTen.Length - 1] <= 'z' || hoTen[hoTen.Length - 1] >= 'A' && hoTen[hoTen.Length - 1] <= 'Z')
                {
                    this.errorProvider1.Clear();
                    valid = true;
                }
                else
                {
                    this.errorProvider1.SetError(txtHoTen, "Invalid name!!!");
                    valid = false;
                }
            }
            else
            {
                // Báo lỗi dữ liệu rỗng (sau khi xóa hết dữ liệu vừa nhập)
                this.errorProvider1.SetError(txtHoTen, "Invalid name!!!");
                valid = false;
            }
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            txtHoTen.Focus();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text;
            // Kiểm tra thông tin nhập
            if (cccd.Length > 0)
            {
                // Ký tự nhập vào phải khác ký tự đặc biệt
                if (cccd[cccd.Length - 1] >= 'a' && cccd[cccd.Length - 1] <= 'z' || cccd[cccd.Length - 1] >= 'A' && cccd[cccd.Length - 1] <= 'Z' || cccd[cccd.Length - 1] >= '0' && cccd[cccd.Length - 1] <= '9')
                {
                    this.errorProvider1.Clear();
                    valid = true;
                }
                else
                {
                    this.errorProvider1.SetError(txtCCCD, "Invalid ID!!!");
                    valid = false;
                }
            }
            else 
            {
                // Báo lỗi dữ liệu rỗng (sau khi xóa hết dữ liệu vừa nhập)
                this.errorProvider1.SetError(txtCCCD, "Invalid ID!!!");
                valid = false;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            // Kiểm tra thông tin nhập
            if (sdt.Length > 0)
            {
                // Ký tự nhập vào phải khác là ký tự số
                if (sdt[sdt.Length - 1] >= '0' && sdt[sdt.Length - 1] <= '9')
                {
                    this.errorProvider1.Clear();
                    valid = true;
                }
                else
                {
                    this.errorProvider1.SetError(txtSDT, "Invalid Phone Number!!!");
                    valid = false;
                }
            }
            else
            {
                // Báo lỗi dữ liệu rỗng (sau khi xóa hết dữ liệu vừa nhập)
                this.errorProvider1.SetError(txtSDT, "Invalid Phone Number!!!");
                valid = false;
            }
        }
    }
}
