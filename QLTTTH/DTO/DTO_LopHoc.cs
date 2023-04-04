using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LopHoc
    {
        private int Ma_LH;
        private string Ten_LH;
        private int Ma_KH;
        private int Ma_PH;
        private int Ma_ca;
        private string Ma_GV;
        private DateTime Ngay_bat_dau;
        private DateTime Ngay_ket_thuc;
        private bool Dang_Mo;
        private int So_buoi;
        private int Soluong;
        public DTO_LopHoc()
        {

        }

        
        public DTO_LopHoc(int ma_LH, string ten_LH, int ma_KH, int ma_PH, int ma_ca, string ma_GV, DateTime ngay_bat_dau, DateTime ngay_ket_thuc, bool dang_Mo, int so_buoi, int soluong)
        {
            Ma_LH1 = ma_LH;
            Ten_LH1 = ten_LH;
            Ma_KH1 = ma_KH;
            Ma_PH1 = ma_PH;
            Ma_ca1 = ma_ca;
            Ma_GV1 = ma_GV;
            Ngay_bat_dau1 = ngay_bat_dau;
            Ngay_ket_thuc1 = ngay_ket_thuc;
            Dang_Mo1 = dang_Mo;
            So_buoi1 = so_buoi;
            Soluong1 = soluong;
        }

        public int Ma_LH1 { get => Ma_LH; set => Ma_LH = value; }
        public string Ten_LH1 { get => Ten_LH; set => Ten_LH = value; }
        public int Ma_KH1 { get => Ma_KH; set => Ma_KH = value; }
        public int Ma_PH1 { get => Ma_PH; set => Ma_PH = value; }
        public int Ma_ca1 { get => Ma_ca; set => Ma_ca = value; }
        public string Ma_GV1 { get => Ma_GV; set => Ma_GV = value; }
        public DateTime Ngay_bat_dau1 { get => Ngay_bat_dau; set => Ngay_bat_dau = value; }
        public DateTime Ngay_ket_thuc1 { get => Ngay_ket_thuc; set => Ngay_ket_thuc = value; }
        public bool Dang_Mo1 { get => Dang_Mo; set => Dang_Mo = value; }
        public int So_buoi1 { get => So_buoi; set => So_buoi = value; }
        public int Soluong1 { get => Soluong; set => Soluong = value; }
    }
}
