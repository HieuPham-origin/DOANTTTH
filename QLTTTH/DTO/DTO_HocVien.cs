using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocVien
    {
        private string Ma_HV;
        private string Ten_HV;
        private DateTime Nam_sinh;
        private string Dia_chi;
        private string sdt;

        public DTO_HocVien() { }

        public DTO_HocVien(string ma_HV, string ten_HV, DateTime nam_sinh, string dia_chi, string sdt)
        {
            Ma_HV = ma_HV;
            Ten_HV = ten_HV;
            Nam_sinh = nam_sinh;
            Dia_chi = dia_chi;
            this.sdt = sdt;
        }

        public string Ma_HV1 { get => Ma_HV; set => Ma_HV = value; }
        public string Ten_HV1 { get => Ten_HV; set => Ten_HV = value; }
        public DateTime Nam_sinh1 { get => Nam_sinh; set => Nam_sinh = value; }
        public string Dia_chi1 { get => Dia_chi; set => Dia_chi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
