using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop.classes
{
    internal class ChiTietHoaDon
    {
        // fields
        private string _MaChiTiet;
        private string _MaHD;
        private string _MaSP;
        private int _SoLuong;

        // constructor
        public ChiTietHoaDon(string maChiTiet, string maHD, string maSP, int soLuong)
        {
            _MaChiTiet = maChiTiet;
            _MaHD = maHD;
            _MaSP = maSP;
            _SoLuong = soLuong;
        }

        // properties
        public string MaChiTiet { get => _MaChiTiet; set => _MaChiTiet = value; }
        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}
