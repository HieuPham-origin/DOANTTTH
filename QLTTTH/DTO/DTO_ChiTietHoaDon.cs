using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_ChiTietHoaDon
    {
        private int Ma_hd;
        private int Ma_KH;

        public DTO_ChiTietHoaDon(int ma_hd, int ma_KH)
        {
            Ma_hd = ma_hd;
            Ma_KH = ma_KH;
        }

        public int Ma_hd1 { get => Ma_hd; set => Ma_hd = value; }
        public int Ma_KH1 { get => Ma_KH; set => Ma_KH = value; }
    }
}
