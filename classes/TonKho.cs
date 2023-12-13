using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop
{
    internal class TonKho
    {
        //khai bao
        string maCH;
        string maSP;
        int soLuong;
        string maCH_Cu; 
        string maSP_Cu;
        string ngayNhap; 
        //properties 
        public string MaCH { get => maCH;private set => maCH = value; }
        public string MaSP { get => maSP; private set => maSP = value; }
        public string MaSP_Cu { get => maSP_Cu; private set => maSP_Cu= value; }
        public string MaCH_Cu { get => maCH_Cu; private set => maCH_Cu= value; }
        public int SoLuong { get => soLuong; private set => soLuong = value; }
        public string NgayNhap { get => ngayNhap; private set => ngayNhap = value; }

        //constructor
        public TonKho(string maCH, string maSP, int soLuong)
        {
            MaCH = maCH;
            MaSP = maSP;
            SoLuong = soLuong;
        }
        public TonKho(string maCH, string maSP,string ngayNhap, int soLuong, string maCH_Cu, string maSP_Cu)
        {
            MaCH = maCH;
            MaSP = maSP;
            this.NgayNhap=ngayNhap;
            SoLuong = soLuong;
            this.maCH_Cu = maCH_Cu;
            this.maSP_Cu = maSP_Cu;  
        }
    }
}
