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
            this.listCuaHang = new System.Windows.Forms.ListView();
            this.cotMaCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotTenCH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotQuanLy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotKhaiTruong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN CỬA HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listCuaHang
            // 
            this.listCuaHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cotMaCH,
            this.cotTenCH,
            this.cotDiaChi,
            this.cotSDT,
            this.cotQuanLy,
            this.cotKhaiTruong});
            this.listCuaHang.GridLines = true;
            this.listCuaHang.HideSelection = false;
            this.listCuaHang.Location = new System.Drawing.Point(89, 82);
            this.listCuaHang.Name = "listCuaHang";
            this.listCuaHang.Size = new System.Drawing.Size(652, 302);
            this.listCuaHang.TabIndex = 1;
            this.listCuaHang.UseCompatibleStateImageBehavior = false;
            this.listCuaHang.View = System.Windows.Forms.View.Details;
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
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(89, 404);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 44);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(338, 404);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 44);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(625, 404);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 44);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frmThongTinCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listCuaHang);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongTinCuaHang";
            this.Text = "Thông tin cửa hàng";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listCuaHang;
        private System.Windows.Forms.ColumnHeader cotMaCH;
        private System.Windows.Forms.ColumnHeader cotTenCH;
        private System.Windows.Forms.ColumnHeader cotDiaChi;
        private System.Windows.Forms.ColumnHeader cotSDT;
        private System.Windows.Forms.ColumnHeader cotQuanLy;
        private System.Windows.Forms.ColumnHeader cotKhaiTruong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}