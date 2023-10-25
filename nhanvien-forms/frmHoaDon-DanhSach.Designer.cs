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
            System.Windows.Forms.ColumnHeader clMaCH;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"}, -1);
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clMaHD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNgayTao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPhuongThucTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clSoTienTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            clMaCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // clMaCH
            // 
            clMaCH.Text = "Mã CH";
            clMaCH.Width = 96;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Location = new System.Drawing.Point(109, 86);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(121, 28);
            this.cboTimKiem.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(273, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Location = new System.Drawing.Point(610, 81);
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
            this.label1.Location = new System.Drawing.Point(105, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm theo\r\n";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaHD,
            this.clMaNV,
            this.clMaKH,
            clMaCH,
            this.clNgayTao,
            this.clPhuongThucTT,
            this.clSoTienTT});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(2, 190);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(888, 298);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clMaHD
            // 
            this.clMaHD.Text = "Mã HD";
            this.clMaHD.Width = 118;
            // 
            // clMaNV
            // 
            this.clMaNV.Text = "Mã NV";
            this.clMaNV.Width = 114;
            // 
            // clMaKH
            // 
            this.clMaKH.Text = "Mã KH";
            this.clMaKH.Width = 90;
            // 
            // clNgayTao
            // 
            this.clNgayTao.Text = "Ngày tạo";
            this.clNgayTao.Width = 101;
            // 
            // clPhuongThucTT
            // 
            this.clPhuongThucTT.Text = "Phương thức thanh toán";
            this.clPhuongThucTT.Width = 195;
            // 
            // clSoTienTT
            // 
            this.clSoTienTT.Text = "Số tiền thanh toán";
            this.clSoTienTT.Width = 169;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.IndianRed;
            this.label17.Location = new System.Drawing.Point(739, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Ấn để xem chi tiết ";
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
            // frmHoaDon_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHoaDon_DanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clMaHD;
        private System.Windows.Forms.ColumnHeader clMaNV;
        private System.Windows.Forms.ColumnHeader clMaKH;
        private System.Windows.Forms.ColumnHeader clNgayTao;
        private System.Windows.Forms.ColumnHeader clPhuongThucTT;
        private System.Windows.Forms.ColumnHeader clSoTienTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
    }
}