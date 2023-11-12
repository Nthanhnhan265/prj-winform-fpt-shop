namespace winform_fpt_shop.manhinhchung_forms
{
    partial class frmXemTonKho
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cotMaCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotMaSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotNgayNhapKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotNgayXuatKho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMaCH = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.dtpNhapKho = new System.Windows.Forms.DateTimePicker();
            this.dtpXuatKho = new System.Windows.Forms.DateTimePicker();
            this.lblNhapKho = new System.Windows.Forms.Label();
            this.lblXuatKho = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN HÀNG TỒN KHO";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cotMaCH,
            this.cotMaSP,
            this.cotSoLuong,
            this.cotNgayNhapKho,
            this.cotNgayXuatKho});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 252);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cotMaCH
            // 
            this.cotMaCH.Text = "Mã cửa hàng";
            this.cotMaCH.Width = 150;
            // 
            // cotMaSP
            // 
            this.cotMaSP.Text = "Mã sản phẩm";
            this.cotMaSP.Width = 150;
            // 
            // cotSoLuong
            // 
            this.cotSoLuong.Text = "Số lượng";
            this.cotSoLuong.Width = 100;
            // 
            // cotNgayNhapKho
            // 
            this.cotNgayNhapKho.Text = "Ngày nhập kho";
            this.cotNgayNhapKho.Width = 150;
            // 
            // cotNgayXuatKho
            // 
            this.cotNgayXuatKho.Text = "Ngày xuất kho";
            this.cotNgayXuatKho.Width = 150;
            // 
            // lblMaCH
            // 
            this.lblMaCH.AutoSize = true;
            this.lblMaCH.Location = new System.Drawing.Point(89, 66);
            this.lblMaCH.Name = "lblMaCH";
            this.lblMaCH.Size = new System.Drawing.Size(87, 16);
            this.lblMaCH.TabIndex = 2;
            this.lblMaCH.Text = "Mã cửa hàng:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(89, 122);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(91, 16);
            this.lblMaSP.TabIndex = 3;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(182, 63);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.Size = new System.Drawing.Size(100, 22);
            this.txtMaCH.TabIndex = 4;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(186, 120);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 22);
            this.txtMaSP.TabIndex = 5;
            // 
            // dtpNhapKho
            // 
            this.dtpNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNhapKho.Location = new System.Drawing.Point(439, 66);
            this.dtpNhapKho.Name = "dtpNhapKho";
            this.dtpNhapKho.Size = new System.Drawing.Size(114, 22);
            this.dtpNhapKho.TabIndex = 6;
            // 
            // dtpXuatKho
            // 
            this.dtpXuatKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpXuatKho.Location = new System.Drawing.Point(439, 122);
            this.dtpXuatKho.Name = "dtpXuatKho";
            this.dtpXuatKho.Size = new System.Drawing.Size(114, 22);
            this.dtpXuatKho.TabIndex = 7;
            // 
            // lblNhapKho
            // 
            this.lblNhapKho.AutoSize = true;
            this.lblNhapKho.Location = new System.Drawing.Point(332, 66);
            this.lblNhapKho.Name = "lblNhapKho";
            this.lblNhapKho.Size = new System.Drawing.Size(101, 16);
            this.lblNhapKho.TabIndex = 8;
            this.lblNhapKho.Text = "Ngày nhập kho:";
            // 
            // lblXuatKho
            // 
            this.lblXuatKho.AutoSize = true;
            this.lblXuatKho.Location = new System.Drawing.Point(338, 122);
            this.lblXuatKho.Name = "lblXuatKho";
            this.lblXuatKho.Size = new System.Drawing.Size(95, 16);
            this.lblXuatKho.TabIndex = 9;
            this.lblXuatKho.Text = "Ngày xuất kho:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(641, 66);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(641, 124);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmXemTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblXuatKho);
            this.Controls.Add(this.lblNhapKho);
            this.Controls.Add(this.dtpXuatKho);
            this.Controls.Add(this.dtpNhapKho);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblMaCH);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmXemTonKho";
            this.Text = "Xem tồn kho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cotMaCH;
        private System.Windows.Forms.ColumnHeader cotMaSP;
        private System.Windows.Forms.ColumnHeader cotSoLuong;
        private System.Windows.Forms.ColumnHeader cotNgayNhapKho;
        private System.Windows.Forms.ColumnHeader cotNgayXuatKho;
        private System.Windows.Forms.Label lblMaCH;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.DateTimePicker dtpNhapKho;
        private System.Windows.Forms.DateTimePicker dtpXuatKho;
        private System.Windows.Forms.Label lblNhapKho;
        private System.Windows.Forms.Label lblXuatKho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}