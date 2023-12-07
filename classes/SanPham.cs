using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop
{
    internal class SanPham
    {
        //khai bao 
        string maSP;
        string tenSP;
        string thongTinSP;
        string maDM;
        string maNSX;
        int giaBan;
        string image;
        //properties 
        public string MaSP { get => maSP;private set => maSP = value; }
        public string TenSP { get => tenSP; private set => tenSP = value; }
        public string ThongTinSP { get => thongTinSP; private set => thongTinSP = value; }
        public string MaDM { get => maDM; private set => maDM = value; }
        public string MaNSX { get => maNSX; private set => maNSX = value; }
        public int GiaBan { get => giaBan; private set => giaBan = value; }
        public string Image { get => image; private set => image = value; }
         //constructor 
        public SanPham(string maSP, string tenSP, string thongTinSP, string maDM, string maNSX, int giaBan, string image)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.thongTinSP = thongTinSP;
            this.maDM = maDM;
            this.maNSX = maNSX;
            this.giaBan = giaBan;
            this.image = image;
        }

      

    }
}
