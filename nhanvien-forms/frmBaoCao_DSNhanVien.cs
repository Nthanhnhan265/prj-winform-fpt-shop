using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace winform_fpt_shop.nhanvien_forms
{
    public partial class frmBaoCao_DSNhanVien : Form
    {
        public frmBaoCao_DSNhanVien()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDSNhanVien_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(frmNhanVien.path + "\\nhanvien-forms\\rptDSNhanVien.rpt");
            crystalReportViewer1.ReportSource = report;
            
        }
    }
}
