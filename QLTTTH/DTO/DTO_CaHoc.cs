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
        private DateTime Gio_bat_dau;
        private DateTime Gio_ket_thuc;

        public DTO_CaHoc() { }

        public DTO_CaHoc(int ma_ca, int buoi, DateTime gio_bat_dau, DateTime gio_ket_thuc)
        {
            Ma_ca = ma_ca;
            Buoi = buoi;
            Gio_bat_dau = gio_bat_dau;
            Gio_ket_thuc = gio_ket_thuc;
        }

        public int Ma_ca1 { get => Ma_ca; set => Ma_ca = value; }
        public int Buoi1 { get => Buoi; set => Buoi = value; }
        public DateTime Gio_bat_dau1 { get => Gio_bat_dau; set => Gio_bat_dau = value; }
        public DateTime Gio_ket_thuc1 { get => Gio_ket_thuc; set => Gio_ket_thuc = value; }
    }
}
