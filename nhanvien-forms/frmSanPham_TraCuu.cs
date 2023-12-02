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
    public partial class frmSanPham_TraCuu : Form
    {
        public frmSanPham_TraCuu()
        {
            InitializeComponent();
        }
        string[] cbo = new string[] { "Mã sản phẩm","Tên sản phẩm","Thông tin sản phẩm" }; 

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text!="")
            {
                if (cboTimKiem.Text == cbo[0])
                {

                }else if (cboTimKiem.Text == cbo[1])
                {  

                }
            }else
            {
                errorProvider1.SetError(txtTimKiem,"Vui lòng nhập trường này"); 
            }
        }

        private void frmSanPham_TraCuu_Load(object sender, EventArgs e)
        {
            cboTimKiem.DataSource = cbo;
            dgvTraCuu.DataSource = DBCuaHang.GetDataTable("sp_HienThiSanPham"); 
        }
    }
}
