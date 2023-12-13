using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared; 
namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmBaoCao_SanPhamNSX : Form
    {
        public frmBaoCao_SanPhamNSX()
        {
            InitializeComponent();
        }

        private void frmBaoCao_SanPhamNSX_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(frmNhanVien.path+"\\nhanvien-forms\\rptBaoCaoSanPhamTheoNSX.rpt");
            report.SetParameterValue("nguoiTao", frmDangNhap.TaiKhoan.HoTen);
            crystalReportViewer1.ReportSource = report; 
        }
    }
}
