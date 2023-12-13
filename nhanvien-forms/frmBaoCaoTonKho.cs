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
    public partial class frmBaoCaoTonKho : Form
    {
        public frmBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void frmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(frmNhanVien.path+"\\nhanvien-forms\\rptBaoCaoTonKho.rpt");
            report.SetParameterValue("nguoiTao",frmDangNhap.TaiKhoan.HoTen);
            report.SetParameterValue("@MaCH",frmDangNhap.TaiKhoan.MaCH);
            report.SetParameterValue("@Thang",DateTime.Now.ToString("yyyy-MM-dd"));
            report.SetParameterValue("thang",DateTime.Now.Month+"/"+DateTime.Now.Year); 
            crystalReportViewer1.ReportSource = report; 
        }
    }
}
