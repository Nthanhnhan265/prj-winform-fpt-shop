namespace winform_fpt_shop
{
    partial class frmDanhSachSanPham
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.listSanPham = new System.Windows.Forms.ListView();
            this.cotMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotThongTinSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotDanhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotNhaSanXuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotGiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH SẢN PHẨM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listSanPham
            // 
            this.listSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cotMaSP,
            this.cotTenSP,
            this.cotThongTinSP,
            this.cotDanhMuc,
            this.cotNhaSanXuat,
            this.cotGiaBan});
            this.listSanPham.GridLines = true;
            this.listSanPham.HideSelection = false;
            this.listSanPham.Location = new System.Drawing.Point(50, 72);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.Size = new System.Drawing.Size(701, 321);
            this.listSanPham.TabIndex = 1;
            this.listSanPham.UseCompatibleStateImageBehavior = false;
            this.listSanPham.View = System.Windows.Forms.View.Details;
            // 
            // cotMaSP
            // 
            this.cotMaSP.Text = "Mã SP";
            this.cotMaSP.Width = 100;
            // 
            // cotTenSP
            // 
            this.cotTenSP.Text = "Tên SP";
            this.cotTenSP.Width = 150;
            // 
            // cotThongTinSP
            // 
            this.cotThongTinSP.Text = "Thông tin SP";
            this.cotThongTinSP.Width = 150;
            // 
            // cotDanhMuc
            // 
            this.cotDanhMuc.Text = "Danh mục";
            this.cotDanhMuc.Width = 100;
            // 
            // cotNhaSanXuat
            // 
            this.cotNhaSanXuat.Text = "Nhà sản xuất";
            this.cotNhaSanXuat.Width = 100;
            // 
            // cotGiaBan
            // 
            this.cotGiaBan.Text = "Giá bán";
            this.cotGiaBan.Width = 100;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(50, 410);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(340, 410);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(646, 410);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 43);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frmDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listSanPham);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDanhSachSanPham";
            this.Text = "Danh sách sản phẩm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listSanPham;
        private System.Windows.Forms.ColumnHeader cotMaSP;
        private System.Windows.Forms.ColumnHeader cotTenSP;
        private System.Windows.Forms.ColumnHeader cotThongTinSP;
        private System.Windows.Forms.ColumnHeader cotDanhMuc;
        private System.Windows.Forms.ColumnHeader cotNhaSanXuat;
        private System.Windows.Forms.ColumnHeader cotGiaBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}