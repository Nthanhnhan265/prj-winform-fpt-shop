using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop.classes
{
    internal class HoaDon
    {
        // fields
        private string _MaHD;
        private string _MaKH;
        private string _MaNV;
        private string _NgayTao;
        private string _MaCH;
        private string _PTThanhToan;
        private int _SoTienTT;

        // constructor
        public HoaDon(string maHD, string maKH, string maNV, string ngayTao, string maCH, string pTThanhToan, int soTienTT)
        {
            _MaHD = maHD;
            _MaKH = maKH;
            _MaNV = maNV;
            _NgayTao = ngayTao;
            _MaCH = maCH;
            _PTThanhToan = pTThanhToan;
            _SoTienTT = soTienTT;
        }

        // properties
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string NgayTao { get => _NgayTao; set => _NgayTao = value; }
        public string MaCH { get => _MaCH; set => _MaCH = value; }
        public string PTThanhToan { get => _PTThanhToan; set => _PTThanhToan = value; }
        public int SoTienTT { get => _SoTienTT; set => _SoTienTT = value; }
    }
}
