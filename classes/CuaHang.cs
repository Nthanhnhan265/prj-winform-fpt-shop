using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop
{
    internal class CuaHang
    {
        //khai bao 
        string maCH;
        string tenCH;
        string diaChi;
        string soDienThoai;
        string ngayKhaiTruong;
        string quanLy;
        //constructor 
        public CuaHang(string maCH, string tenCH, string diaChi, string soDienThoai, string ngayKhaiTruong, string quanLy)
        {
            this.maCH = maCH;
            this.tenCH = tenCH;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.ngayKhaiTruong = ngayKhaiTruong;
            this.quanLy = quanLy;
        }
        //properties 
        public string MaCH { get => maCH; set => maCH = value; }
        public string TenCH { get => tenCH; set => tenCH = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string NgayKhaiTruong { get => ngayKhaiTruong; set => ngayKhaiTruong = value; }
        public string QuanLy { get => quanLy; set => quanLy = value; }
    }
}
