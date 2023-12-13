namespace winform_fpt_shop
{
    partial class frmKhachHang_DS
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
            this.components = new System.ComponentModel.Container();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDIaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTItle = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaKH
            // 
            this.lblMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(45, 88);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(98, 16);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(97, 144);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblCCCD
            // 
            this.lblCCCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(99, 200);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblSDT
            // 
            this.lblSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(361, 88);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(35, 16);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SDT";
            // 
            // lblDIaChi
            // 
            this.lblDIaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDIaChi.AutoSize = true;
            this.lblDIaChi.Location = new System.Drawing.Point(349, 144);
            this.lblDIaChi.Name = "lblDIaChi";
            this.lblDIaChi.Size = new System.Drawing.Size(47, 16);
            this.lblDIaChi.TabIndex = 0;
            this.lblDIaChi.Text = "Địa chỉ";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(355, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaKH.Location = new System.Drawing.Point(161, 85);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(155, 22);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHoTen.Location = new System.Drawing.Point(161, 141);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(155, 22);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCCCD.Location = new System.Drawing.Point(161, 197);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(155, 22);
            this.txtCCCD.TabIndex = 2;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Location = new System.Drawing.Point(418, 82);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 22);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Location = new System.Drawing.Point(418, 141);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(155, 22);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(418, 197);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Enabled = false;
            this.btnThem.Image = global::winform_fpt_shop.Properties.Resources.icons8_add_24;
            this.btnThem.Location = new System.Drawing.Point(652, 69);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 49);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Enabled = false;
            this.btnSua.Image = global::winform_fpt_shop.Properties.Resources.icons8_edit_24;
            this.btnSua.Location = new System.Drawing.Point(651, 128);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 49);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Enabled = false;
            this.btnXoa.Image = global::winform_fpt_shop.Properties.Resources.icons8_delete_24;
            this.btnXoa.Location = new System.Drawing.Point(652, 183);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 50);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Image = global::winform_fpt_shop.Properties.Resources.icons8_find_24;
            this.btnTimKiem.Location = new System.Drawing.Point(809, 69);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(127, 49);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTItle
            // 
            this.lblTItle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTItle.AutoSize = true;
            this.lblTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItle.Location = new System.Drawing.Point(308, 25);
            this.lblTItle.Name = "lblTItle";
            this.lblTItle.Size = new System.Drawing.Size(288, 25);
            this.lblTItle.TabIndex = 0;
            this.lblTItle.Text = "DANH SÁCH KHÁCH HÀNG";
            this.lblTItle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 292);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.Size = new System.Drawing.Size(971, 288);
            this.dgvKhachHang.TabIndex = 10;
            this.dgvKhachHang.Click += new System.EventHandler(this.dgvKhachHang_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmKhachHang_DS
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 580);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.lblTItle);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDIaChi);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaKH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKhachHang_DS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khách Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_DS_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_DS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDIaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTItle;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}