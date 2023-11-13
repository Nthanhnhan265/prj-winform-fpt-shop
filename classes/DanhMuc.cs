using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop.classes
{
    internal class DanhMuc
    {
        //khai bao 
        private string maDM;
        private string tenDM;
        private string thuocTinhDanhMuc;

        //properties 
        public string MaDM { get => maDM; private set => maDM = value; }
        public string TenDM { get => tenDM; private set => tenDM = value; }
        public string ThuocTinhDanhMuc { get => thuocTinhDanhMuc; private set => thuocTinhDanhMuc = value; }

        //constructor 
        public DanhMuc(string ma, string ten, string thuocTinh)
        {
            MaDM = ma;
            TenDM = ten;
            thuocTinhDanhMuc = thuocTinh;
        }
   
    }
}
