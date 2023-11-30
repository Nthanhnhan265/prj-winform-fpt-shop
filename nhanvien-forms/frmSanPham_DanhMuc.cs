using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_fpt_shop.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmSanPham_DanhMucSP : Form
    {
        public frmSanPham_DanhMucSP()
        {
            InitializeComponent();
        }
        //Khai báo 
        DataGridViewRow hangDuocChon=null;

        private string RandomMa()
        {
            const string template = "DMFPTXXXXXX";
            Random random = new Random();

            // Thay thế XXXXXX bằng ký tự ngẫu nhiên
            string result = template
                .Replace("XXXXXX", random.Next(100000, 999999).ToString());
            return result;
        }
        private void frmSanPham_DanhMucSP_Load(object sender, EventArgs e)
        {

            txtTenDM.Focus();    
            dgvDanhMuc.DataSource = DBCuaHang.GetDataTable("sp_HienThiDanhMuc"); 
        }
        /// <summary>
        /// Phương thức xóa hàm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaDanhMuc.Text!="" && txtTenDM.Text!="" || txtThuocTinh.Text!="")
                {                    
                    DanhMuc danhMuc = new DanhMuc(txtMaDanhMuc.Text, txtTenDM.Text, DBCuaHang.GetNvarcharText(txtThuocTinh.Text));
                    int dong = DBCuaHang.AddRowData("sp_ThemDanhMuc", danhMuc); 
                    if (dong!=0)
                    {
                        dgvDanhMuc.DataSource= DBCuaHang.GetDataTable("sp_HienThiDanhMuc"); 
                        MessageBox.Show($"Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Thêm thất bại: số dòng được thêm {dong}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(hangDuocChon!=null)
                {
                    DialogResult= MessageBox.Show($"Bạn có muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    //Trường hợp xác nhận rõ muốn xóa 
                    if(DialogResult==DialogResult.Yes)
                    {
                        if (DBCuaHang.DelRowData("sp_XoaDanhMuc", hangDuocChon.Cells["MaDM"].Value.ToString()))
                        {
                            //thông báo xóa thành công 
                            //DBCuaHang.DelRowData("sp_XoaDanhMuc", txtMaDanhMuc.Text);
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMaDanhMuc.Text ="";
                            txtTenDM.Text = "";
                            txtThuocTinh.Text = "";
                            hangDuocChon = null; 
                        } 
                        else
                        {
                            MessageBox.Show($"Xóa thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }

                }
                //Trường hợp chưa chọn 
                else
                {
                    MessageBox.Show($"Có Lỗi xảy ra: \nBạn chưa chọn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
                dgvDanhMuc.DataSource = DBCuaHang.GetDataTable("sp_HienThiDanhMuc"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        //Sua 
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (hangDuocChon != null)
                {
                    DialogResult = MessageBox.Show($"Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Trường hợp xác nhận rõ muốn xóa 
                    if (DialogResult == DialogResult.Yes)
                    {
                        if (DBCuaHang.UpdateRowData("sp_SuaDanhMuc", new DanhMuc(txtMaDanhMuc.Text, 
                            DBCuaHang.GetNvarcharText(txtTenDM.Text),
                            DBCuaHang.GetNvarcharText(txtThuocTinh.Text)))!=-1)
                        {
                            //thông báo xóa thành công 
                            dgvDanhMuc.DataSource = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Xóa thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }

                }
                //Trường hợp chưa chọn 
                else
                {
                    MessageBox.Show($"Có Lỗi xảy ra: \nBạn chưa chọn hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhMuc.SelectedRows.Count > 0)
                {
                    // Lấy toàn bộ dữ liệu của hàng được click
                    hangDuocChon = dgvDanhMuc.SelectedRows[0];
                    txtMaDanhMuc.Text = hangDuocChon.Cells["MaDM"].Value.ToString();
                    txtTenDM.Text = hangDuocChon.Cells["TenDM"].Value.ToString();
                    txtThuocTinh.Text = hangDuocChon.Cells["ThuocTinhDanhMuc"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void txtTenDM_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaDanhMuc.Text = RandomMa(); 
        }
    }
}
