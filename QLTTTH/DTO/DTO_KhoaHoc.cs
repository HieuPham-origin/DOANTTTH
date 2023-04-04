using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class DTO_KhoaHoc
    {
        private int Ma_KH;
        private string Ten_KH;
        private int Hoc_phi;

        public DTO_KhoaHoc(int ma_KH, string ten_KH, int hoc_phi)
        {
            Ma_KH1 = ma_KH;
            Ten_KH1 = ten_KH;
            Hoc_phi1 = hoc_phi;
        }

        public int Ma_KH1 { get => Ma_KH; set => Ma_KH = value; }
        public string Ten_KH1 { get => Ten_KH; set => Ten_KH = value; }
        public int Hoc_phi1 { get => Hoc_phi; set => Hoc_phi = value; }
    }
}
