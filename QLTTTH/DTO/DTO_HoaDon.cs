using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private int Ma_hd;
	    private string Ten_hd;
        private int Ma_KH;
	    private DateTime Ngay_thu;

        public DTO_HoaDon() { }

        public DTO_HoaDon(int ma_hd, string ten_hd, int ma_KH, DateTime ngay_thu)
        {
            Ma_hd = ma_hd;
            Ten_hd = ten_hd;
            Ma_KH = ma_KH;
            Ngay_thu = ngay_thu;
        }

        public int Ma_hd1 { get => Ma_hd; set => Ma_hd = value; }
        public string Ten_hd1 { get => Ten_hd; set => Ten_hd = value; }
        public int Ma_KH1 { get => Ma_KH; set => Ma_KH = value; }
        public DateTime Ngay_thu1 { get => Ngay_thu; set => Ngay_thu = value; }
    }
}
