namespace winform_fpt_shop
{
    partial class frmDanhSachNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listNhanVien = new System.Windows.Forms.ListView();
            this.cotMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotHoTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotMaCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotQuanLy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotQuyenHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnlDanhSachNhanVien = new System.Windows.Forms.Panel();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.pnlDanhSachNhanVien.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // listNhanVien
            // 
            this.listNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cotMaNV,
            this.cotHoTenNV,
            this.cotNgaySinh,
            this.cotDiaChi,
            this.cotGioiTinh,
            this.cotCCCD,
            this.cotSDT,
            this.cotEmail,
            this.cotMaCH,
            this.cotQuanLy,
            this.cotQuyenHan});
            this.listNhanVien.GridLines = true;
            this.listNhanVien.HideSelection = false;
            this.listNhanVien.Location = new System.Drawing.Point(18, 12);
            this.listNhanVien.Name = "listNhanVien";
            this.listNhanVien.Size = new System.Drawing.Size(1184, 534);
            this.listNhanVien.TabIndex = 0;
            this.listNhanVien.UseCompatibleStateImageBehavior = false;
            this.listNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // cotMaNV
            // 
            this.cotMaNV.Text = "Mã NV";
            this.cotMaNV.Width = 100;
            // 
            // cotHoTenNV
            // 
            this.cotHoTenNV.Text = "Họ tên NV";
            this.cotHoTenNV.Width = 200;
            // 
            // cotNgaySinh
            // 
            this.cotNgaySinh.Text = "Ngày sinh";
            this.cotNgaySinh.Width = 100;
            // 
            // cotDiaChi
            // 
            this.cotDiaChi.Text = "Địa chỉ";
            this.cotDiaChi.Width = 150;
            // 
            // cotGioiTinh
            // 
            this.cotGioiTinh.Text = "GT";
            this.cotGioiTinh.Width = 50;
            // 
            // cotCCCD
            // 
            this.cotCCCD.Text = "CCCD";
            this.cotCCCD.Width = 100;
            // 
            // cotSDT
            // 
            this.cotSDT.Text = "SDT";
            this.cotSDT.Width = 100;
            // 
            // cotEmail
            // 
            this.cotEmail.Text = "Email";
            this.cotEmail.Width = 100;
            // 
            // cotMaCH
            // 
            this.cotMaCH.Text = "Mã CH";
            this.cotMaCH.Width = 100;
            // 
            // cotQuanLy
            // 
            this.cotQuanLy.Text = "Quản lý";
            this.cotQuanLy.Width = 80;
            // 
            // cotQuyenHan
            // 
            this.cotQuyenHan.Text = "Quyền hạn";
            this.cotQuyenHan.Width = 100;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1233, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Danh sách nhân viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(230, 56);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(507, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(230, 56);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(972, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(230, 56);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // pnlDanhSachNhanVien
            // 
            this.pnlDanhSachNhanVien.Controls.Add(this.listNhanVien);
            this.pnlDanhSachNhanVien.Location = new System.Drawing.Point(7, 53);
            this.pnlDanhSachNhanVien.Name = "pnlDanhSachNhanVien";
            this.pnlDanhSachNhanVien.Size = new System.Drawing.Size(1214, 560);
            this.pnlDanhSachNhanVien.TabIndex = 3;
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnSua);
            this.pnlCRUD.Controls.Add(this.btnThem);
            this.pnlCRUD.Controls.Add(this.btnXoa);
            this.pnlCRUD.Location = new System.Drawing.Point(7, 619);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(1214, 59);
            this.pnlCRUD.TabIndex = 1;
            // 
            // frmDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 688);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.pnlDanhSachNhanVien);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDanhSachNhanVien";
            this.Text = "Danh sách nhân viên";
            this.pnlDanhSachNhanVien.ResumeLayout(false);
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listNhanVien;
        private System.Windows.Forms.ColumnHeader cotMaNV;
        private System.Windows.Forms.ColumnHeader cotHoTenNV;
        private System.Windows.Forms.ColumnHeader cotNgaySinh;
        private System.Windows.Forms.ColumnHeader cotDiaChi;
        private System.Windows.Forms.ColumnHeader cotGioiTinh;
        private System.Windows.Forms.ColumnHeader cotCCCD;
        private System.Windows.Forms.ColumnHeader cotSDT;
        private System.Windows.Forms.ColumnHeader cotEmail;
        private System.Windows.Forms.ColumnHeader cotMaCH;
        private System.Windows.Forms.ColumnHeader cotQuanLy;
        private System.Windows.Forms.ColumnHeader cotQuyenHan;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel pnlDanhSachNhanVien;
        private System.Windows.Forms.Panel pnlCRUD;
    }
}