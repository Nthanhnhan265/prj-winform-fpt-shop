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
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiemHoaDon = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Location = new System.Drawing.Point(97, 69);
            this.cboTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(108, 24);
            this.cboTimKiem.TabIndex = 11;
            // 
            // txtTimKiemHoaDon
            // 
            this.txtTimKiemHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiemHoaDon.Location = new System.Drawing.Point(243, 70);
            this.txtTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            this.txtTimKiemHoaDon.Size = new System.Drawing.Size(274, 22);
            this.txtTimKiemHoaDon.TabIndex = 10;
            this.txtTimKiemHoaDon.TextChanged += new System.EventHandler(this.txtTimKiemHoaDon_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Location = new System.Drawing.Point(542, 65);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(148, 33);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm theo\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.IndianRed;
            this.label17.Location = new System.Drawing.Point(657, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Ấn để xem chi tiết ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(269, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "DANH SÁCH HÓA ĐƠN";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 154);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(791, 246);
            this.dgvHoaDon.TabIndex = 25;
            // 
            // frmHoaDon_DanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 400);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.txtTimKiemHoaDon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}