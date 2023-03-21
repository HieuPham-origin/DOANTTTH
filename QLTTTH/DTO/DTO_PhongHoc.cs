using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhongHoc
    {
        private int Ma_PH;
        private string Ten_PH;

        public DTO_PhongHoc() { }

        public DTO_PhongHoc(int ma_PH, string ten_PH)
        {
            Ma_PH = ma_PH;
            Ten_PH = ten_PH;
        }

        public int Ma_PH1 { get => Ma_PH; set => Ma_PH = value; }
        public string Ten_PH1 { get => Ten_PH; set => Ten_PH = value; }
    }
}
