using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop
{
    internal class NhanVien
    {
        //khai bao 
        string maNV;
        string hoTen;
        string diaChi; 
        string ngaySinh;
        string gioiTinh;
        string cCCD;
        string sdt;
        string email;
        string maCH;
        string quanLy;
        string matKhau;
        string quyenHan;
        //properties
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string MaCH { get => maCH; set => maCH = value; }
        public string QuanLy { get => quanLy; set => quanLy = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string QuyenHan { get => quyenHan; set => quyenHan = value; }

        //constructor 
        public NhanVien(string maNV, string hoTen, string ngaySinh,string diaChi, string gioiTinh, string cCCD, string sdt, string email, string maCH, string quanLy, string matKhau, string quyenHan)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.cCCD = cCCD;
            this.sdt = sdt;
            this.email = email;
            this.maCH = maCH;
            this.quanLy = quanLy;
            this.matKhau = matKhau;
            this.quyenHan = quyenHan;
        }

        public NhanVien ()
        {

        }


    }
}
