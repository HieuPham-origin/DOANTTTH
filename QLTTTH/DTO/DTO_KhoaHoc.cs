using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhoaHoc
    {
        private int Ma_KH;
        private string Ten_KH;
        private int Ma_PH;
        private int Ma_ca;
        private string Ma_GV;
        private DateTime Ngay_bat_dau;
        private DateTime Ngay_ket_thuc;
        private bool Dang_Mo;
        private int Hoc_phi;
        private int So_buoi;
        private int Soluong;

        public DTO_KhoaHoc()
        {

        }

        public DTO_KhoaHoc(int ma_KH, string ten_KH, int ma_PH, int ma_ca, string ma_GV, DateTime ngay_bat_dau, DateTime ngay_ket_thuc, bool dang_Mo, int hoc_phi, int so_buoi, int soluong)
        {
            Ma_KH = ma_KH;
            Ten_KH = ten_KH;
            Ma_PH = ma_PH;
            Ma_ca = ma_ca;
            Ma_GV = ma_GV;
            Ngay_bat_dau = ngay_bat_dau;
            Ngay_ket_thuc = ngay_ket_thuc;
            Dang_Mo = dang_Mo;
            Hoc_phi = hoc_phi;
            So_buoi = so_buoi;
            Soluong = soluong;
        }

        public int Ma_KH1 { get => Ma_KH; set => Ma_KH = value; }
        public string Ten_KH1 { get => Ten_KH; set => Ten_KH = value; }
        public int Ma_PH1 { get => Ma_PH; set => Ma_PH = value; }
        public int Ma_ca1 { get => Ma_ca; set => Ma_ca = value; }
        public string Ma_GV1 { get => Ma_GV; set => Ma_GV = value; }
        public DateTime Ngay_bat_dau1 { get => Ngay_bat_dau; set => Ngay_bat_dau = value; }
        public DateTime Ngay_ket_thuc1 { get => Ngay_ket_thuc; set => Ngay_ket_thuc = value; }
        public bool Dang_Mo1 { get => Dang_Mo; set => Dang_Mo = value; }
        public int Hoc_phi1 { get => Hoc_phi; set => Hoc_phi = value; }
        public int So_buoi1 { get => So_buoi; set => So_buoi = value; }
        public int Soluong1 { get => Soluong; set => Soluong = value; }
    }
}
