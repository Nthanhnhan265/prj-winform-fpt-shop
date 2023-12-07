using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop
{
    internal class NhaSX
    {
        //khai bao
        string maNSX;
        string tenNSX;
        //properties
        public string MaNSX { get => maNSX; private set => maNSX = value; }
        public string TenNSX { get => tenNSX;private set => tenNSX = value; }
        //constructor 
        public NhaSX(string maNSX, string tenNSX)
        {
            MaNSX = maNSX;
            TenNSX = tenNSX;
        }

    }
}
