namespace winform_fpt_shop
{
    partial class frmThongTinCuaHang
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lswCuaHang = new System.Windows.Forms.ListView();
            this.cotMaCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotTenCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotQuanLy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotKhaiTruong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlThongTinCuaHang = new System.Windows.Forms.Panel();
            this.pnlNhapCH = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboQuanLy = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.lblKhaiTruong = new System.Windows.Forms.Label();
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenCH = new System.Windows.Forms.Label();
            this.pnlThongTinCuaHang.SuspendLayout();
            this.pnlNhapCH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1116, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN CỬA HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 37);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(305, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(148, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 37);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // lswCuaHang
            // 
            this.lswCuaHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cotMaCH,
            this.cotTenCH,
            this.cotDiaChi,
            this.cotSDT,
            this.cotQuanLy,
            this.cotKhaiTruong});
            this.lswCuaHang.GridLines = true;
            this.lswCuaHang.HideSelection = false;
            this.lswCuaHang.Location = new System.Drawing.Point(16, 3);
            this.lswCuaHang.Name = "lswCuaHang";
            this.lswCuaHang.Size = new System.Drawing.Size(651, 389);
            this.lswCuaHang.TabIndex = 1;
            this.lswCuaHang.UseCompatibleStateImageBehavior = false;
            this.lswCuaHang.View = System.Windows.Forms.View.Details;
            this.lswCuaHang.SelectedIndexChanged += new System.EventHandler(this.lswCuaHang_SelectedIndexChanged);
            // 
            // cotMaCH
            // 
            this.cotMaCH.Text = "Mã CH";
            this.cotMaCH.Width = 100;
            // 
            // cotTenCH
            // 
            this.cotTenCH.Text = "Tên cửa hàng";
            this.cotTenCH.Width = 150;
            // 
            // cotDiaChi
            // 
            this.cotDiaChi.Text = "Địa chỉ";
            this.cotDiaChi.Width = 100;
            // 
            // cotSDT
            // 
            this.cotSDT.Text = "Số điện thoại";
            this.cotSDT.Width = 100;
            // 
            // cotQuanLy
            // 
            this.cotQuanLy.Text = "Quản lý";
            this.cotQuanLy.Width = 100;
            // 
            // cotKhaiTruong
            // 
            this.cotKhaiTruong.Text = "Khai trương";
            this.cotKhaiTruong.Width = 100;
            // 
            // pnlThongTinCuaHang
            // 
            this.pnlThongTinCuaHang.Controls.Add(this.lswCuaHang);
            this.pnlThongTinCuaHang.Location = new System.Drawing.Point(443, 71);
            this.pnlThongTinCuaHang.Name = "pnlThongTinCuaHang";
            this.pnlThongTinCuaHang.Size = new System.Drawing.Size(671, 405);
            this.pnlThongTinCuaHang.TabIndex = 3;
            // 
            // pnlNhapCH
            // 
            this.pnlNhapCH.Controls.Add(this.dateTimePicker1);
            this.pnlNhapCH.Controls.Add(this.cboQuanLy);
            this.pnlNhapCH.Controls.Add(this.txtSDT);
            this.pnlNhapCH.Controls.Add(this.txtDiaChi);
            this.pnlNhapCH.Controls.Add(this.txtTenCH);
            this.pnlNhapCH.Controls.Add(this.lblKhaiTruong);
            this.pnlNhapCH.Controls.Add(this.lblQuanLy);
            this.pnlNhapCH.Controls.Add(this.lblSDT);
            this.pnlNhapCH.Controls.Add(this.lblDiaChi);
            this.pnlNhapCH.Controls.Add(this.lblTenCH);
            this.pnlNhapCH.Controls.Add(this.btnThem);
            this.pnlNhapCH.Controls.Add(this.btnSua);
            this.pnlNhapCH.Controls.Add(this.btnXoa);
            this.pnlNhapCH.Location = new System.Drawing.Point(7, 71);
            this.pnlNhapCH.Name = "pnlNhapCH";
            this.pnlNhapCH.Size = new System.Drawing.Size(420, 295);
            this.pnlNhapCH.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 241);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // cboQuanLy
            // 
            this.cboQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuanLy.FormattingEnabled = true;
            this.cboQuanLy.Location = new System.Drawing.Point(127, 202);
            this.cboQuanLy.Name = "cboQuanLy";
            this.cboQuanLy.Size = new System.Drawing.Size(264, 26);
            this.cboQuanLy.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(127, 158);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(264, 24);
            this.txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(127, 115);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(264, 24);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(127, 73);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(264, 24);
            this.txtTenCH.TabIndex = 8;
            // 
            // lblKhaiTruong
            // 
            this.lblKhaiTruong.AutoSize = true;
            this.lblKhaiTruong.Location = new System.Drawing.Point(24, 246);
            this.lblKhaiTruong.Name = "lblKhaiTruong";
            this.lblKhaiTruong.Size = new System.Drawing.Size(87, 18);
            this.lblKhaiTruong.TabIndex = 7;
            this.lblKhaiTruong.Text = "Khai trương:";
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.Location = new System.Drawing.Point(24, 205);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(62, 18);
            this.lblQuanLy.TabIndex = 6;
            this.lblQuanLy.Text = "Quản lý:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(24, 161);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(42, 18);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "SDT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(24, 118);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 18);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenCH
            // 
            this.lblTenCH.AutoSize = true;
            this.lblTenCH.Location = new System.Drawing.Point(24, 76);
            this.lblTenCH.Name = "lblTenCH";
            this.lblTenCH.Size = new System.Drawing.Size(63, 18);
            this.lblTenCH.TabIndex = 3;
            this.lblTenCH.Text = "Tên CH:";
            // 
            // frmThongTinCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 506);
            this.Controls.Add(this.pnlNhapCH);
            this.Controls.Add(this.pnlThongTinCuaHang);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongTinCuaHang";
            this.Text = "Thông tin cửa hàng";
            this.Load += new System.EventHandler(this.frmThongTinCuaHang_Load);
            this.pnlThongTinCuaHang.ResumeLayout(false);
            this.pnlNhapCH.ResumeLayout(false);
            this.pnlNhapCH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ListView lswCuaHang;
        private System.Windows.Forms.ColumnHeader cotMaCH;
        private System.Windows.Forms.ColumnHeader cotTenCH;
        private System.Windows.Forms.ColumnHeader cotDiaChi;
        private System.Windows.Forms.ColumnHeader cotSDT;
        private System.Windows.Forms.ColumnHeader cotQuanLy;
        private System.Windows.Forms.ColumnHeader cotKhaiTruong;
        private System.Windows.Forms.Panel pnlThongTinCuaHang;
        private System.Windows.Forms.Panel pnlNhapCH;
        private System.Windows.Forms.Label lblKhaiTruong;
        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenCH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.ComboBox cboQuanLy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}