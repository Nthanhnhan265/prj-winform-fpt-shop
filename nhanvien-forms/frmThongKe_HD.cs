using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmThongKe_HD : Form
    {
        public frmThongKe_HD()
        {
            InitializeComponent();
        }

        private void frmThongKe_HD_Load(object sender, EventArgs e)
        {
            ReportDocument reportHD = new ReportDocument();
            reportHD.Load(frmNhanVien.path + "\\nhanvien-forms\\rptDSHoaDonDaTao.rpt");
            crystalReportViewer1.ReportSource = reportHD;
            crystalReportViewer1.Refresh();
        }
    }
}
