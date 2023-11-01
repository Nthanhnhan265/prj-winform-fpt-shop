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
            this.pnlNhapSP = new System.Windows.Forms.Panel();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblThongTinSP = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblNhaSanXuat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtThongTInSP = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.pnlNhapSP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1109, 52);
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
            this.listSanPham.Location = new System.Drawing.Point(9, 3);
            this.listSanPham.Name = "listSanPham";
            this.listSanPham.Size = new System.Drawing.Size(710, 313);
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
            this.btnThem.Location = new System.Drawing.Point(0, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(257, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(124, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // pnlNhapSP
            // 
            this.pnlNhapSP.Controls.Add(this.listSanPham);
            this.pnlNhapSP.Location = new System.Drawing.Point(386, 55);
            this.pnlNhapSP.Name = "pnlNhapSP";
            this.pnlNhapSP.Size = new System.Drawing.Size(809, 323);
            this.pnlNhapSP.TabIndex = 3;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(23, 73);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(61, 18);
            this.lblTenSP.TabIndex = 4;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // lblThongTinSP
            // 
            this.lblThongTinSP.AutoSize = true;
            this.lblThongTinSP.Location = new System.Drawing.Point(23, 118);
            this.lblThongTinSP.Name = "lblThongTinSP";
            this.lblThongTinSP.Size = new System.Drawing.Size(97, 18);
            this.lblThongTinSP.TabIndex = 5;
            this.lblThongTinSP.Text = "Thông tin SP:";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(22, 208);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(80, 18);
            this.lblDanhMuc.TabIndex = 6;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // lblNhaSanXuat
            // 
            this.lblNhaSanXuat.AutoSize = true;
            this.lblNhaSanXuat.Location = new System.Drawing.Point(23, 253);
            this.lblNhaSanXuat.Name = "lblNhaSanXuat";
            this.lblNhaSanXuat.Size = new System.Drawing.Size(98, 18);
            this.lblNhaSanXuat.TabIndex = 7;
            this.lblNhaSanXuat.Text = "Nhà sản xuất:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtNhaSX);
            this.panel1.Controls.Add(this.txtGiaBan);
            this.panel1.Controls.Add(this.lblGiaBan);
            this.panel1.Controls.Add(this.txtThongTInSP);
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.lblTenSP);
            this.panel1.Controls.Add(this.lblNhaSanXuat);
            this.panel1.Controls.Add(this.lblDanhMuc);
            this.panel1.Controls.Add(this.lblThongTinSP);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Location = new System.Drawing.Point(7, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 323);
            this.panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(124, 250);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(212, 24);
            this.txtNhaSX.TabIndex = 13;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(124, 292);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(212, 24);
            this.txtGiaBan.TabIndex = 12;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(23, 295);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(63, 18);
            this.lblGiaBan.TabIndex = 9;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // txtThongTInSP
            // 
            this.txtThongTInSP.Location = new System.Drawing.Point(128, 115);
            this.txtThongTInSP.Multiline = true;
            this.txtThongTInSP.Name = "txtThongTInSP";
            this.txtThongTInSP.Size = new System.Drawing.Size(208, 74);
            this.txtThongTInSP.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(128, 70);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(208, 24);
            this.txtTen.TabIndex = 10;
            // 
            // frmDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNhapSP);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDanhSachSanPham";
            this.Text = "Danh sách sản phẩm";
            this.pnlNhapSP.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel pnlNhapSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblThongTinSP;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblNhaSanXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtThongTInSP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.TextBox txtGiaBan;
    }
}