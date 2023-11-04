namespace winform_fpt_shop.nhanvien_forms
{
    partial class frmQuanLy_TraCuuNhanVien
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvwKhachHang = new System.Windows.Forms.ListView();
            this.clMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNoiLamViec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHoTenQuanLy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(417, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 29);
            this.label12.TabIndex = 31;
            this.label12.Text = "TRA CỨU NHÂN VIÊN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 62);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.cboTimKiem);
            this.panel2.Controls.Add(this.lvwKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 604);
            this.panel2.TabIndex = 57;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lvwKhachHang
            // 
            this.lvwKhachHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaNV,
            this.clHoTen,
            this.clNgaySinh,
            this.clGioiTinh,
            this.clCCCD,
            this.clSoDT,
            this.clDiaChi,
            this.clEmail,
            this.clNoiLamViec,
            this.clHoTenQuanLy});
            this.lvwKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwKhachHang.FullRowSelect = true;
            this.lvwKhachHang.GridLines = true;
            this.lvwKhachHang.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwKhachHang.HideSelection = false;
            this.lvwKhachHang.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwKhachHang.Location = new System.Drawing.Point(0, 146);
            this.lvwKhachHang.Name = "lvwKhachHang";
            this.lvwKhachHang.Size = new System.Drawing.Size(1104, 458);
            this.lvwKhachHang.TabIndex = 56;
            this.lvwKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvwKhachHang.View = System.Windows.Forms.View.Details;
            // 
            // clMaNV
            // 
            this.clMaNV.Text = "Mã NV";
            this.clMaNV.Width = 108;
            // 
            // clHoTen
            // 
            this.clHoTen.Text = "Họ tên";
            this.clHoTen.Width = 134;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.Text = "Ngày sinh";
            this.clNgaySinh.Width = 96;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.Text = "Giới tính";
            this.clGioiTinh.Width = 79;
            // 
            // clCCCD
            // 
            this.clCCCD.Text = "CCCD";
            this.clCCCD.Width = 120;
            // 
            // clSoDT
            // 
            this.clSoDT.Text = "Số ĐT";
            this.clSoDT.Width = 117;
            // 
            // clDiaChi
            // 
            this.clDiaChi.Text = "Địa chỉ";
            this.clDiaChi.Width = 130;
            // 
            // clEmail
            // 
            this.clEmail.Text = "Email";
            this.clEmail.Width = 109;
            // 
            // clNoiLamViec
            // 
            this.clNoiLamViec.Text = "Nơi làm việc";
            this.clNoiLamViec.Width = 102;
            // 
            // clHoTenQuanLy
            // 
            this.clHoTenQuanLy.Text = "Quản lý";
            this.clHoTenQuanLy.Width = 129;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Location = new System.Drawing.Point(758, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(167, 41);
            this.btnTimKiem.TabIndex = 58;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tìm kiếm theo\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(417, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 59;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Location = new System.Drawing.Point(253, 24);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(121, 28);
            this.cboTimKiem.TabIndex = 60;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 86;
            this.label13.Text = "Sắp xếp theo\n";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 28);
            this.comboBox1.TabIndex = 87;
            // 
            // frmQuanLy_TraCuuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuanLy_TraCuuNhanVien";
            this.Text = "frmTraCuuNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvwKhachHang;
        private System.Windows.Forms.ColumnHeader clMaNV;
        private System.Windows.Forms.ColumnHeader clHoTen;
        private System.Windows.Forms.ColumnHeader clNgaySinh;
        private System.Windows.Forms.ColumnHeader clGioiTinh;
        private System.Windows.Forms.ColumnHeader clCCCD;
        private System.Windows.Forms.ColumnHeader clSoDT;
        private System.Windows.Forms.ColumnHeader clDiaChi;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clNoiLamViec;
        private System.Windows.Forms.ColumnHeader clHoTenQuanLy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}