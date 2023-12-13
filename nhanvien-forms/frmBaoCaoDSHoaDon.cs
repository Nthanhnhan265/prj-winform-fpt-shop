using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared; 
using System.Windows.Forms;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmBaoCaoDSHoaDon : Form
    {
        public frmBaoCaoDSHoaDon()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDSHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument report = new ReportDocument();
                report.Load(frmNhanVien.path + "\\rptDSHoaDonDaTao.rpt");
                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            catch
            {

            }
        }
    }
}
