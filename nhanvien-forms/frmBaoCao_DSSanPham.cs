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
            ReportDocument report = new ReportDocument();
            report.Load(frmNhanVien.path + "\\nhanvien-forms\\rptDSSanPham.rpt");

            ////tạo đối tượng để truyền tham số 
            //ParameterFields parameterFields = new ParameterFields();

            ////Tạo tham số 
            //ParameterField parameterField = new ParameterField();
            //ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            ////đặt tên cho tham số 
            //parameterField.Name = "srcImg";

            ////đặt giá trị cho tham số 
            //parameterDiscreteValue.Value = frmNhanVien.path;
            //parameterField.CurrentValues.Add(parameterDiscreteValue);

            ////thêm vào danh sách tham số 
            //parameterFields.Add(parameterField);
            ////truyền tham số vào báo cáo 

            report.SetParameterValue("srcImg",frmNhanVien.path); 

            //hiển thị lên 
            crystalReportViewer1.ReportSource = report;
        }
    }
}
