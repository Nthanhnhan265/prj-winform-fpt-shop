using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmBaoCao_DSSanPham : Form
    {
        public frmBaoCao_DSSanPham()
        {
            InitializeComponent();
        }

        private void frmBaoCao_DSSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument report = new ReportDocument();
                report.Load(frmNhanVien.path + "\\nhanvien-forms\\rptDSSanPham.rpt");

                report.SetParameterValue("nguoiTao", frmDangNhap.TaiKhoan.HoTen);
                report.SetParameterValue("srcImg", frmNhanVien.path);

                //hiển thị lên 
                crystalReportViewer1.ReportSource = report;
            }
            catch
            {
                MessageBox.Show("Mở thát bại!", "Thông báo");
            }
        }
    }
}
