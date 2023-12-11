namespace winform_fpt_shop
{
    partial class frmHoaDon_DanhSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon_DanhSach));
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiemHoaDon = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblXemChiTiet = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
      
            this.cboTimKiem.Location = new System.Drawing.Point(109, 86);
            this.cboTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(121, 28);
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Mã khách hàng",
            "Mã nhân viên",
            "Mã cửa hàng",
            "PT Thanh toán",
            "Số tiền TT"});
            this.cboTimKiem.Location = new System.Drawing.Point(67, 70);
            this.cboTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(142, 24);
            this.cboTimKiem.TabIndex = 11;
            // 
            // txtTimKiemHoaDon
            // 
            this.txtTimKiemHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiemHoaDon.Location = new System.Drawing.Point(273, 88);
            this.txtTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            this.txtTimKiemHoaDon.Size = new System.Drawing.Size(308, 26);
            this.txtTimKiemHoaDon.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Image = global::winform_fpt_shop.Properties.Resources.icons8_find_24;
            this.btnTimKiem.Location = new System.Drawing.Point(610, 81);
            this.btnTimKiem.Location = new System.Drawing.Point(542, 65);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(166, 41);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm theo\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // lblXemChiTiet
            // 
            this.lblXemChiTiet.AutoSize = true;
            this.lblXemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXemChiTiet.ForeColor = System.Drawing.Color.IndianRed;
            this.lblXemChiTiet.Location = new System.Drawing.Point(739, 168);
            this.lblXemChiTiet.Name = "lblXemChiTiet";
            this.lblXemChiTiet.Size = new System.Drawing.Size(138, 20);
            this.lblXemChiTiet.TabIndex = 13;
            this.lblXemChiTiet.Text = "Ấn để xem chi tiết ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(285, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "DANH SÁCH HÓA ĐƠN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 192);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(890, 308);
            this.dgvHoaDon.TabIndex = 25;
            this.dgvHoaDon.Click += new System.EventHandler(this.dgvHoaDon_Click);
            // 
            // frmHoaDon_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblXemChiTiet);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.txtTimKiemHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHoaDon_DanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_DanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblXemChiTiet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}