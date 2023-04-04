using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietDangKy
    {
        private DateTime Ngay_Dang_Ky;
        private string Ma_HV;
        private int Ma_LH;

        public DTO_ChiTietDangKy() { }

        public DTO_ChiTietDangKy(DateTime ngay_Dang_Ky, string ma_HV, int ma_LH)
        {
            Ngay_Dang_Ky = ngay_Dang_Ky;
            Ma_HV = ma_HV;
            Ma_LH = ma_LH;
        }

        public DateTime Ngay_Dang_Ky1 { get => Ngay_Dang_Ky; set => Ngay_Dang_Ky = value; }
        public string Ma_HV1 { get => Ma_HV; set => Ma_HV = value; }
        public int Ma_LH1 { get => Ma_LH; set => Ma_LH = value; }
    }
}
