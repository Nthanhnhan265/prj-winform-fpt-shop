using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop.classes
{
    internal class KhachHang
    {
        //fields
        private string _MaKH;
        private string _HoTenKH;
        private string _CCCD;
        private string _SDT;
        private string _DiaChi;
        private string _Email;

        // constructor
        public KhachHang(string maKH, string hoTenKH, string cCCD, string sDT, string diaChi, string email)
        {
            _MaKH = maKH;
            _HoTenKH = hoTenKH;
            _CCCD = cCCD;
            _SDT = sDT;
            _DiaChi = diaChi;
            _Email = email;
        }

        // properties
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string HoTenKH { get => _HoTenKH; set => _HoTenKH = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
