namespace winform_fpt_shop
{
    partial class frmThemSanPham
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
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblThongTinSP = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblNhaSX = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtThongTinSP = new System.Windows.Forms.TextBox();
            this.cboDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(784, 57);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "NHẬP THÔNG TIN SẢN PHẨM MUỐN THÊM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(46, 87);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(86, 26);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên SP:";
            // 
            // lblThongTinSP
            // 
            this.lblThongTinSP.AutoSize = true;
            this.lblThongTinSP.Location = new System.Drawing.Point(46, 146);
            this.lblThongTinSP.Name = "lblThongTinSP";
            this.lblThongTinSP.Size = new System.Drawing.Size(141, 26);
            this.lblThongTinSP.TabIndex = 2;
            this.lblThongTinSP.Text = "Thông tin SP:";
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(46, 257);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(114, 26);
            this.lblDanhMuc.TabIndex = 3;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // lblNhaSX
            // 
            this.lblNhaSX.AutoSize = true;
            this.lblNhaSX.Location = new System.Drawing.Point(46, 308);
            this.lblNhaSX.Name = "lblNhaSX";
            this.lblNhaSX.Size = new System.Drawing.Size(91, 26);
            this.lblNhaSX.TabIndex = 4;
            this.lblNhaSX.Text = "Nhà SX:";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(46, 361);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(90, 26);
            this.lblGiaBan.TabIndex = 5;
            this.lblGiaBan.Text = "Giá bán:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(193, 84);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(363, 33);
            this.txtTenSP.TabIndex = 6;
            // 
            // txtThongTinSP
            // 
            this.txtThongTinSP.Location = new System.Drawing.Point(193, 143);
            this.txtThongTinSP.Multiline = true;
            this.txtThongTinSP.Name = "txtThongTinSP";
            this.txtThongTinSP.Size = new System.Drawing.Size(363, 87);
            this.txtThongTinSP.TabIndex = 7;
            // 
            // cboDanhMuc
            // 
            this.cboDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanhMuc.FormattingEnabled = true;
            this.cboDanhMuc.Location = new System.Drawing.Point(193, 254);
            this.cboDanhMuc.Name = "cboDanhMuc";
            this.cboDanhMuc.Size = new System.Drawing.Size(363, 33);
            this.cboDanhMuc.TabIndex = 8;
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.Location = new System.Drawing.Point(193, 305);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(363, 33);
            this.txtNhaSX.TabIndex = 9;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(193, 358);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(363, 33);
            this.txtGiaBan.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(615, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 56);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(615, 174);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(124, 56);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 458);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtNhaSX);
            this.Controls.Add(this.cboDanhMuc);
            this.Controls.Add(this.txtThongTinSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblNhaSX);
            this.Controls.Add(this.lblDanhMuc);
            this.Controls.Add(this.lblThongTinSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThemSanPham";
            this.Text = "Thêm sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblThongTinSP;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblNhaSX;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtThongTinSP;
        private System.Windows.Forms.ComboBox cboDanhMuc;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}