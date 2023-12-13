using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_fpt_shop
{
    public class ThongBaoCapNhat
    {
        public event EventHandler tenSuKien; 

        public void ThongBaoCapNhatDuLieu()
        {
            tenSuKien?.Invoke(this, EventArgs.Empty); 
        }

    }
}
