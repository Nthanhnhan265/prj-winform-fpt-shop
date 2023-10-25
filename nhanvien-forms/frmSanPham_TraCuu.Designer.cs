namespace winform_fpt_shop.nhanvien_forms
{
    partial class frmSanPham_TraCuu
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
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDanhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clThongTinSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNhaSX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHinhAnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Location = new System.Drawing.Point(184, 96);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(121, 28);
            this.cboTimKiem.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(348, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Location = new System.Drawing.Point(685, 91);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(167, 41);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm theo\r\n";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(357, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "TRA CỨU SẢN PHẨM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaSP,
            this.clTenSP,
            this.clDanhMuc,
            this.clThongTinSP,
            this.clNhaSX,
            this.clGiaBan,
            this.clHinhAnh});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(930, 317);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clMaSP
            // 
            this.clMaSP.Text = "Mã sản phẩm";
            this.clMaSP.Width = 135;
            // 
            // clTenSP
            // 
            this.clTenSP.Text = "Tên sản phẩm";
            this.clTenSP.Width = 132;
            // 
            // clDanhMuc
            // 
            this.clDanhMuc.Text = "Danh mục";
            this.clDanhMuc.Width = 118;
            // 
            // clThongTinSP
            // 
            this.clThongTinSP.Text = "Thông tin sản phẩm";
            this.clThongTinSP.Width = 184;
            // 
            // clNhaSX
            // 
            this.clNhaSX.Text = "Nhà sản xuất";
            this.clNhaSX.Width = 126;
            // 
            // clGiaBan
            // 
            this.clGiaBan.Text = "Giá bán";
            this.clGiaBan.Width = 112;
            // 
            // clHinhAnh
            // 
            this.clHinhAnh.Text = "Hình ảnh";
            this.clHinhAnh.Width = 122;
            // 
            // frmSanPham_TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 478);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "frmSanPham_TraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Sản Phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clMaSP;
        private System.Windows.Forms.ColumnHeader clTenSP;
        private System.Windows.Forms.ColumnHeader clDanhMuc;
        private System.Windows.Forms.ColumnHeader clThongTinSP;
        private System.Windows.Forms.ColumnHeader clNhaSX;
        private System.Windows.Forms.ColumnHeader clGiaBan;
        private System.Windows.Forms.ColumnHeader clHinhAnh;
    }
}