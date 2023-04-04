using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CaHoc
    {
        private int Ma_ca;
        private int Buoi;
        private string GioHoc;


        public DTO_CaHoc() { }
        public DTO_CaHoc(int ma_ca, int buoi, string gioHoc)
        {
            Ma_ca1 = ma_ca;
            Buoi1 = buoi;
            GioHoc1 = gioHoc;
        }

        public int Ma_ca1 { get => Ma_ca; set => Ma_ca = value; }
        public int Buoi1 { get => Buoi; set => Buoi = value; }
        public string GioHoc1 { get => GioHoc; set => GioHoc = value; }
    }
}
