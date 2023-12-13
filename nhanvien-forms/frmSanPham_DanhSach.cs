using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using winform_fpt_shop.classes;
using System.IO;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmSanPham_DanhSach : Form
    {
        //khai bao 
        string patternString = "^[a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễếệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ.,\\s-]+$";
        string patternNumber = "^[0-9]+$";
        string anhDuocChon = "";
        DataTable dataTable = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
        string[] thongTinSPDuocChon=null; 
        public frmSanPham_DanhSach()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Phương thức random mã 
        /// </summary>
        /// <returns></returns>
        private string RandomMa()
        {
            const string template = "SPFPTXXX";
            Random random = new Random();

            // Thay thế XXXXXX bằng ký tự ngẫu nhiên
            string result = template
                .Replace("XXX", random.Next(100, 999).ToString());
            return result;
        }
        public void Tailaidulieu()
        {
            try
            {
                //lấy các datasoure 
                dgvSanPham.DataSource = DBCuaHang.GetDataTable("sp_HienThiSanPham");
                DataTable tbDanhMuc = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
                DataTable tbNhaSX = DBCuaHang.GetDataTable("sp_HienThiNhaSX");
                //hiển thị lên combobox 
                cbbDanhMuc.DataSource = tbDanhMuc;
                cbbNhaSX.DataSource = tbNhaSX;
                //hiển thị tên 
                cbbNhaSX.DisplayMember = "TenNSX";
                cbbNhaSX.ValueMember = "MaNSX";
                cbbDanhMuc.DisplayMember = "TenDM";
                cbbDanhMuc.ValueMember = "MaDM";

                dgvThongTinSP.Rows.Clear();
                int dong = cbbDanhMuc.SelectedIndex;
                string thuocTinhDM = dataTable.Rows[dong][2].ToString();
                string[] thuocTinhs = thuocTinhDM.Split(',');
                for (int i = 0; i < thuocTinhs.Length; i++)
                {
                    dgvThongTinSP.Rows.Add();
                    dgvThongTinSP.Rows[i].Cells[0].Value = thuocTinhs[i].Trim();
                }
            }catch {  }
        }

        private void frmSanPham_DanhSach_Load(object sender, EventArgs e)
        {
            try
            {
                //lấy các datasoure 
                dgvSanPham.DataSource = DBCuaHang.GetDataTable("sp_HienThiSanPham");
                DataTable tbDanhMuc = DBCuaHang.GetDataTable("sp_HienThiDanhMuc");
                DataTable tbNhaSX = DBCuaHang.GetDataTable("sp_HienThiNhaSX");
                //hiển thị lên combobox 
                cbbDanhMuc.DataSource = tbDanhMuc;
                cbbNhaSX.DataSource = tbNhaSX;
                //hiển thị tên 
                cbbNhaSX.DisplayMember = "TenNSX";
                cbbNhaSX.ValueMember = "MaNSX";
                cbbDanhMuc.DisplayMember = "TenDM";
                cbbDanhMuc.ValueMember = "MaDM";
                dgvThongTinSP.Rows.Clear();
                int dong = cbbDanhMuc.SelectedIndex;
                string thuocTinhDM = dataTable.Rows[dong][2].ToString();
                string[] thuocTinhs = thuocTinhDM.Split(',');
                for (int i = 0; i < thuocTinhs.Length; i++)
                {
                    dgvThongTinSP.Rows.Add();
                    dgvThongTinSP.Rows[i].Cells[0].Value = thuocTinhs[i].Trim();
                }
            }
            catch { }

        }
        /// <summary>
        /// Kiem Tra cac o trong dgv thong tin san pham
        /// </summary>
        /// <returns></returns>
        private bool KiemTraCacOTrongThongTinSP()
        {
            try
            {
                for (int i = 0; i < dgvThongTinSP.Rows.Count; i++)
                {
                    if (dgvThongTinSP.Rows[i].Cells[1].Value == null)
                    {
                        errorProvider1.SetError(dgvThongTinSP, "Vui lòng nhập đầy đủ thông tin sản phẩm!");
                        return false;

                    }
                }
                errorProvider1.Clear();
            }
            catch { }
            return true; 
        }
        /// <summary>
        /// Lấy thông tin sản phẩm từ datagridview 
        /// </summary>
        /// <returns></returns>
        private string LayThongTinSPTuDGV()
        {
           
                string str = "";
                for (int i = 0; i < dgvThongTinSP.Rows.Count; i++)
                {
                    string key = dgvThongTinSP.Rows[i].Cells[0].Value.ToString();
                    string value = dgvThongTinSP.Rows[i].Cells[1].Value.ToString();
                    str += $"{key}:{value}|";
                }
                str = str.Substring(0, str.Length - 1);
     
            return str; 
        }
        /// <summary>
        /// Phương thức chỉnh sửa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraCacOTrongThongTinSP()&&txtMa.Text != "" && txtTenSanPham.Text != "" && cbbDanhMuc.Text != "" && cbbNhaSX.Text != "" && txtGiaBan.Text != "")
                {
                    SanPham sanPham =
                        new SanPham(txtMa.Text,
                        txtTenSanPham.Text,
                        DBCuaHang.GetNvarcharText(LayThongTinSPTuDGV()),
                        cbbDanhMuc.SelectedValue.ToString(),
                         cbbNhaSX.SelectedValue.ToString(),
                        int.Parse(txtGiaBan.Text),
                        anhDuocChon);
                    MessageBox.Show("Thong tin sP "+LayThongTinSPTuDGV  ()); 
                    int dong = DBCuaHang.UpdateRowData("sp_SuaSanPham", sanPham);
                    if (dong != 0)
                    {
                        LamMoi();
                        Tailaidulieu();
                        MessageBox.Show($"Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Cập nhật thất bại: số dòng được sửa {dong}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }
        /// <summary>
        /// PHương thức xóa 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra đã chọn hàng nào hay chưa 
                if (txtMa.Text != "")
                {
                    //Hỏi xem có chắc chắn muốn xóa 
                    DialogResult rs = MessageBox.Show("bạn có muốn xóa? ", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        ////xóa tồn kho liên quan đến sán phẩm 
                        //if(DBCuaHang.DelRowData("sp_XoaTonKho","1", txtMa.Text))
                        //{

                        //}
                        //xóa sản phẩm 
                        if (DBCuaHang.DelRowData("sp_XoaSanPham", txtMa.Text))
                        {
                            LamMoi();
                            Tailaidulieu();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Có Lỗi xảy ra: \n{ex}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Phương thức thêm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraCacOTrongThongTinSP() && txtMa.Text != "" && txtTenSanPham.Text != "" && cbbDanhMuc.Text != "" && cbbNhaSX.Text != "" && txtGiaBan.Text != "")
                {
                   
                    SanPham sanPham =
                        new SanPham(txtMa.Text,
                        txtTenSanPham.Text,
                        DBCuaHang.GetNvarcharText(LayThongTinSPTuDGV()),
                        cbbDanhMuc.SelectedValue.ToString(),
                         cbbNhaSX.SelectedValue.ToString(),
                        int.Parse(txtGiaBan.Text),
                        anhDuocChon);
                    int dong = DBCuaHang.AddRowData("sp_ThemSanPham", sanPham);
                    if (dong != 0)
                    {
                        LamMoi();
                        Tailaidulieu();
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

        /// <summary>
        /// Kiểm tra tên nhập vào
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string str = txtTenSanPham.Text;
                if (Regex.IsMatch(str, patternString) == false)
                {
                    errorProvider1.SetError(txtTenSanPham, "Vui lòng nhập chuỗi chỉ chứa kí tự a-z,A-Z,0-9! hoặc kí tự . , / -");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch { }
        }
        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string str = txtGiaBan.Text;
                if (Regex.IsMatch(str, patternNumber) == false)
                {
                    errorProvider1.SetError(txtGiaBan, "Vui lòng nhập chuỗi chỉ chứa kí tự 0-9");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            catch { }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMa.Text = RandomMa();
        }

        private void LamMoi()
        {
            try
            {
                txtMa.Text = "";
                txtTenSanPham.Text = "";
                //thoong tin tam cho qua 

                cbbDanhMuc.SelectedIndex = 0;

                cbbNhaSX.SelectedIndex = 0;
                txtGiaBan.Text = "";
                //hinh anh tam cho qua 

                errorProvider1.Clear();
            }
            catch { }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Click vào 1 ô để hiên thị thông tin của sản phầm đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMa.Text = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtGiaBan.Text = dgvSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTenSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                thongTinSPDuocChon = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString().Split('|');
                dgvThongTinSP.Rows.Clear();
                for (int i = 0; i < thongTinSPDuocChon.Length; i++)
                {
                    dgvThongTinSP.Rows.Add();
                    dgvThongTinSP.Rows[i].Cells[0].Value = thongTinSPDuocChon[i].Split(':')[0].Trim();
                    if (thongTinSPDuocChon != null)
                    {
                        string[] keysValues = thongTinSPDuocChon[i].Split(':');
                        dgvThongTinSP.Rows[i].Cells[1].Value = keysValues[1];
                    }
                }
                cbbDanhMuc.SelectedValue = dgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();

                cbbNhaSX.SelectedValue = dgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                //xử lý khi ấn vào hình ảnh 
                string path = Application.StartupPath + "/images/" + dgvSanPham.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                }
                else
                {
                    MessageBox.Show("hình ảnh không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {

            }

        }
        /// <summary>
        /// Ấn để duyệt hình ảnh từ máy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                //khai báo 
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                dialog.Title = "Chọn hình ảnh";

                //mở hộp thoại file 
                DialogResult rs = dialog.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    string selectedFilePath = dialog.FileName;

                    // Kiểm tra xem có thư mục để lưu trữ hình ảnh hay không
                    if (Directory.Exists(Application.StartupPath + "/images"))
                    {
                        // Lưu tên tệp hình ảnh
                        anhDuocChon = Path.GetFileName(selectedFilePath); ;
                        string fileName = Path.GetFileName(selectedFilePath);
                        string destinationPath = Path.Combine(Application.StartupPath + "/images/", fileName);  // Thay "YourFolderPath" bằng đường dẫn thư mục bạn muốn sử dụng

                        // Kiểm tra xem tệp đã tồn tại hay chưa
                        if (!File.Exists(destinationPath))
                        {
                            // Sao chép hình ảnh vào thư mục đích
                            File.Copy(selectedFilePath, destinationPath);

                            //hiển lên hình ảnh 
                            pictureBox1.Image = Image.FromFile(destinationPath);
                        }
                        else
                        {
                            //hiển lên hình ảnh có tromg thư mục
                            pictureBox1.Image = Image.FromFile(destinationPath);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thư mục đích không tồn tại!");
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// lưu ảnh vào folder
        /// </summary>
        /// <param name="path"></param>
        /// <param name="folder"></param>
        private void LuuHinhAnh(string tenFile, string pathFileCu)
        {
            try
            {
                // Lưu tên tệp hình ảnh

                string pathFileMoi = Path.Combine(Application.StartupPath + "/images/", tenFile);
                // Kiểm tra xem tệp đã tồn tại hay chưa

                // Sao chép hình ảnh vào file mới
                File.Copy(pathFileCu, pathFileMoi);

            }
            catch { }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThongTinSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Sửa combobox và hiển thị thông tin sản phẩm vào datagrid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvThongTinSP.Rows.Clear();
                int dong = cbbDanhMuc.SelectedIndex;
                string thuocTinhDM = dataTable.Rows[dong][2].ToString();
                string[] thuocTinhs = thuocTinhDM.Split(',');
                for (int i = 0; i < thuocTinhs.Length; i++)
                {
                    dgvThongTinSP.Rows.Add();
                    dgvThongTinSP.Rows[i].Cells[0].Value = thuocTinhs[i].Trim();
                }
                thongTinSPDuocChon = null;
            }
            catch { }
        }

        private void frmSanPham_DanhSach_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult rd = MessageBox.Show("Bạn có muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rd == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
