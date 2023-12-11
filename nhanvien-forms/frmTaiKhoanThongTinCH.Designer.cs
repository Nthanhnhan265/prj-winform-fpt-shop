using System.Windows.Forms;

namespace winform_fpt_shop.nhanvien_forms
{
    partial class frmTaiKhoanThongTinCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoanThongTinCH));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboTenQL = new System.Windows.Forms.ComboBox();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.lbTenQL = new System.Windows.Forms.Label();
            this.lbSDTQuanLy = new System.Windows.Forms.Label();
            this.lbNgayKhaiTruong = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTenCH = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.lbMaCh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 92);
            this.panel1.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(372, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 29);
            this.label12.TabIndex = 43;
            this.label12.Text = "THÔNG TIN CỬA HÀNG";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cboTenQL);
            this.panel3.Controls.Add(this.btnChinhSua);
            this.panel3.Controls.Add(this.lbTenQL);
            this.panel3.Controls.Add(this.lbSDTQuanLy);
            this.panel3.Controls.Add(this.lbNgayKhaiTruong);
            this.panel3.Controls.Add(this.lbDiaChi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbTenCH);
            this.panel3.Controls.Add(this.label99);
            this.panel3.Controls.Add(this.lbMaCh);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 463);
            this.panel3.TabIndex = 44;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cboTenQL
            // 
            this.cboTenQL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenQL.Enabled = false;
            this.cboTenQL.FormattingEnabled = true;
            this.cboTenQL.Location = new System.Drawing.Point(701, 68);
            this.cboTenQL.Name = "cboTenQL";
            this.cboTenQL.Size = new System.Drawing.Size(172, 28);
            this.cboTenQL.TabIndex = 3;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Image = global::winform_fpt_shop.Properties.Resources.icons8_edit_24;
            this.btnChinhSua.Location = new System.Drawing.Point(915, 388);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(157, 63);
            this.btnChinhSua.TabIndex = 2;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // lbTenQL
            // 
            this.lbTenQL.AutoSize = true;
            this.lbTenQL.Location = new System.Drawing.Point(697, 23);
            this.lbTenQL.Name = "lbTenQL";
            this.lbTenQL.Size = new System.Drawing.Size(51, 20);
            this.lbTenQL.TabIndex = 0;
            this.lbTenQL.Text = "label1";
            this.lbTenQL.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbSDTQuanLy
            // 
            this.lbSDTQuanLy.AutoSize = true;
            this.lbSDTQuanLy.Location = new System.Drawing.Point(697, 111);
            this.lbSDTQuanLy.Name = "lbSDTQuanLy";
            this.lbSDTQuanLy.Size = new System.Drawing.Size(51, 20);
            this.lbSDTQuanLy.TabIndex = 0;
            this.lbSDTQuanLy.Text = "label1";
            this.lbSDTQuanLy.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbNgayKhaiTruong
            // 
            this.lbNgayKhaiTruong.AutoSize = true;
            this.lbNgayKhaiTruong.Location = new System.Drawing.Point(259, 179);
            this.lbNgayKhaiTruong.Name = "lbNgayKhaiTruong";
            this.lbNgayKhaiTruong.Size = new System.Drawing.Size(51, 20);
            this.lbNgayKhaiTruong.TabIndex = 0;
            this.lbNgayKhaiTruong.Text = "label1";
            this.lbNgayKhaiTruong.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(259, 125);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(51, 20);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "label1";
            this.lbDiaChi.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Quản Lý";
            // 
            // lbTenCH
            // 
            this.lbTenCH.AutoSize = true;
            this.lbTenCH.Location = new System.Drawing.Point(259, 73);
            this.lbTenCH.Name = "lbTenCH";
            this.lbTenCH.Size = new System.Drawing.Size(51, 20);
            this.lbTenCH.TabIndex = 0;
            this.lbTenCH.Text = "label1";
            this.lbTenCH.Click += new System.EventHandler(this.label2_Click);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(518, 23);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(42, 22);
            this.label99.TabIndex = 0;
            this.label99.Text = "Mã ";
            // 
            // lbMaCh
            // 
            this.lbMaCh.AutoSize = true;
            this.lbMaCh.Location = new System.Drawing.Point(259, 25);
            this.lbMaCh.Name = "lbMaCh";
            this.lbMaCh.Size = new System.Drawing.Size(51, 20);
            this.lbMaCh.TabIndex = 0;
            this.lbMaCh.Text = "label1";
            this.lbMaCh.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(518, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày khai trương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên cửa hàng";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(56, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(124, 22);
            this.label.TabIndex = 0;
            this.label.Text = "Mã cửa hàng";
            // 
            // frmTaiKhoanThongTinCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaiKhoanThongTinCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cửa hàng";
            this.Load += new System.EventHandler(this.frmTaiKhoanThongTinCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTenQL;
        private System.Windows.Forms.Label lbSDTQuanLy;
        private System.Windows.Forms.Label lbNgayKhaiTruong;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbTenCH;
        private System.Windows.Forms.Label lbMaCh;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private Label label1;
        private ComboBox cboTenQL;

        public Label LbTenQL { get => lbTenQL; set => lbTenQL = value; }
        public Label LbSDTQuanLy { get => lbSDTQuanLy; set => lbSDTQuanLy = value; }
        public Label LbNgayKhaiTruong { get => lbNgayKhaiTruong; set => lbNgayKhaiTruong = value; }
        public Label LbDiaChi { get => lbDiaChi; set => lbDiaChi = value; }
        public Label LbTenCH { get => lbTenCH; set => lbTenCH = value; }
        public Label LbMaCh { get => lbMaCh; set => lbMaCh = value; }
    }
}