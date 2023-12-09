namespace winform_fpt_shop.nhanvien_forms
{
    partial class frmheThongChinhSuaCH
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtpNgayKhaiTruong = new System.Windows.Forms.DateTimePicker();
            this.cboQuanLy = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCuaHang = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuaHang)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(452, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "THÔNG TIN CỬA HÀNG";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(154, 88);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 22);
            this.label.TabIndex = 1;
            this.label.Text = "Mã cửa hàng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên cửa hàng";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày khai trương";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(634, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số điện thoại";
            // 
            // label99
            // 
            this.label99.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(634, 85);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(79, 22);
            this.label99.TabIndex = 10;
            this.label99.Text = "Quản lý";
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChinhSua.Image = global::winform_fpt_shop.Properties.Resources.icons8_edit_24;
            this.btnChinhSua.Location = new System.Drawing.Point(799, 198);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(120, 48);
            this.btnChinhSua.TabIndex = 15;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.Image = global::winform_fpt_shop.Properties.Resources.icons8_delete_24;
            this.btnXoa.Location = new System.Drawing.Point(944, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 48);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaCH
            // 
            this.txtMaCH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaCH.Location = new System.Drawing.Point(326, 88);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.ReadOnly = true;
            this.txtMaCH.Size = new System.Drawing.Size(198, 26);
            this.txtMaCH.TabIndex = 2;
            // 
            // txtTenCH
            // 
            this.txtTenCH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenCH.Location = new System.Drawing.Point(326, 136);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(198, 26);
            this.txtTenCH.TabIndex = 5;
            this.txtTenCH.TextChanged += new System.EventHandler(this.txtTenCH_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Location = new System.Drawing.Point(326, 182);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(198, 26);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSDT.Location = new System.Drawing.Point(783, 133);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(198, 26);
            this.txtSDT.TabIndex = 13;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // dtpNgayKhaiTruong
            // 
            this.dtpNgayKhaiTruong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayKhaiTruong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhaiTruong.Location = new System.Drawing.Point(328, 237);
            this.dtpNgayKhaiTruong.Name = "dtpNgayKhaiTruong";
            this.dtpNgayKhaiTruong.Size = new System.Drawing.Size(200, 26);
            this.dtpNgayKhaiTruong.TabIndex = 9;
            this.dtpNgayKhaiTruong.ValueChanged += new System.EventHandler(this.dtpNgayKhaiTruong_ValueChanged);
            // 
            // cboQuanLy
            // 
            this.cboQuanLy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuanLy.FormattingEnabled = true;
            this.cboQuanLy.Location = new System.Drawing.Point(785, 91);
            this.cboQuanLy.Name = "cboQuanLy";
            this.cboQuanLy.Size = new System.Drawing.Size(196, 28);
            this.cboQuanLy.TabIndex = 11;
            this.cboQuanLy.SelectedIndexChanged += new System.EventHandler(this.cboQuanLy_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboQuanLy);
            this.panel1.Controls.Add(this.dtpNgayKhaiTruong);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenCH);
            this.panel1.Controls.Add(this.txtMaCH);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnChinhSua);
            this.panel1.Controls.Add(this.label99);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 301);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCuaHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 304);
            this.panel2.TabIndex = 48;
            // 
            // dgvCuaHang
            // 
            this.dgvCuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuaHang.Location = new System.Drawing.Point(0, 0);
            this.dgvCuaHang.Name = "dgvCuaHang";
            this.dgvCuaHang.RowHeadersWidth = 62;
            this.dgvCuaHang.RowTemplate.Height = 28;
            this.dgvCuaHang.Size = new System.Drawing.Size(1181, 304);
            this.dgvCuaHang.TabIndex = 0;
            this.dgvCuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuaHang_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.Image = global::winform_fpt_shop.Properties.Resources.icons8_add_24;
            this.btnThem.Location = new System.Drawing.Point(652, 198);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 48);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = global::winform_fpt_shop.Properties.Resources.icons8_synchronize_24;
            this.button1.Location = new System.Drawing.Point(534, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 42);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmheThongChinhSuaCH
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmheThongChinhSuaCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin cửa hàng";
            this.Load += new System.EventHandler(this.frmheThongChinhSuaCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuaHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCuaHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboQuanLy;
        private System.Windows.Forms.DateTimePicker dtpNgayKhaiTruong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}