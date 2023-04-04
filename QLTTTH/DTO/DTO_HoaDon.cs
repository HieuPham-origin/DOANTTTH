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
	    private DateTime Ngay_lap;

        public DTO_HoaDon() { }

        public DTO_HoaDon(int ma_hd, string ten_hd, DateTime ngay_lap)
        {
            Ma_hd = ma_hd;
            Ten_hd = ten_hd;
            Ngay_lap = ngay_lap;
        }

        public int Ma_hd1 { get => Ma_hd; set => Ma_hd = value; }
        public string Ten_hd1 { get => Ten_hd; set => Ten_hd = value; }
        public DateTime Ngay_lap1 { get => Ngay_lap; set => Ngay_lap = value; }
    }
}
