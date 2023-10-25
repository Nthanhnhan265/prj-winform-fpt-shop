namespace winform_fpt_shop
{
    partial class frmThemCuaHang
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
            this.lblNhapTenCH = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.lblKhaiTruong = new System.Windows.Forms.Label();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.cboQuanLy = new System.Windows.Forms.ComboBox();
            this.dtpKhaiTruong = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(778, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NHẬP THÔNG TIN CỬA HÀNG MUỐN THÊM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNhapTenCH
            // 
            this.lblNhapTenCH.AutoSize = true;
            this.lblNhapTenCH.Location = new System.Drawing.Point(43, 82);
            this.lblNhapTenCH.Name = "lblNhapTenCH";
            this.lblNhapTenCH.Size = new System.Drawing.Size(143, 26);
            this.lblNhapTenCH.TabIndex = 1;
            this.lblNhapTenCH.Text = "Tên cửa hàng:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(43, 142);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(85, 26);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(43, 211);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(141, 26);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.Location = new System.Drawing.Point(43, 275);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(93, 26);
            this.lblQuanLy.TabIndex = 1;
            this.lblQuanLy.Text = "Quản lý:";
            // 
            // lblKhaiTruong
            // 
            this.lblKhaiTruong.AutoSize = true;
            this.lblKhaiTruong.Location = new System.Drawing.Point(43, 349);
            this.lblKhaiTruong.Name = "lblKhaiTruong";
            this.lblKhaiTruong.Size = new System.Drawing.Size(129, 26);
            this.lblKhaiTruong.TabIndex = 1;
            this.lblKhaiTruong.Text = "Khai trương:";
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(192, 79);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(328, 33);
            this.txtTenCH.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(192, 139);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(328, 33);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(192, 208);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(328, 33);
            this.txtSDT.TabIndex = 4;
            // 
            // cboQuanLy
            // 
            this.cboQuanLy.FormattingEnabled = true;
            this.cboQuanLy.Location = new System.Drawing.Point(192, 272);
            this.cboQuanLy.Name = "cboQuanLy";
            this.cboQuanLy.Size = new System.Drawing.Size(328, 33);
            this.cboQuanLy.TabIndex = 5;
            // 
            // dtpKhaiTruong
            // 
            this.dtpKhaiTruong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKhaiTruong.Location = new System.Drawing.Point(192, 343);
            this.dtpKhaiTruong.Name = "dtpKhaiTruong";
            this.dtpKhaiTruong.Size = new System.Drawing.Size(155, 33);
            this.dtpKhaiTruong.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(621, 79);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 58);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(621, 166);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 58);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThemCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 512);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpKhaiTruong);
            this.Controls.Add(this.cboQuanLy);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenCH);
            this.Controls.Add(this.lblKhaiTruong);
            this.Controls.Add(this.lblQuanLy);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNhapTenCH);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmThemCuaHang";
            this.Text = "Thêm cửa hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapTenCH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.Label lblKhaiTruong;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cboQuanLy;
        private System.Windows.Forms.DateTimePicker dtpKhaiTruong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}