using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiangVien
    {
        private string Ma_GV;
        private string Ten_GV;
        private DateTime Nam_sinh;
        private string sdt;
        private string Que_quan;

        public DTO_GiangVien() { }
        public DTO_GiangVien(string ma_GV, string ten_GV, DateTime nam_sinh, string sdt, string que_quan)
        {
            Ma_GV = ma_GV;
            Ten_GV = ten_GV;
            Nam_sinh = nam_sinh;
            this.sdt = sdt;
            Que_quan = que_quan;
        }

        public string Ma_GV1 { get => Ma_GV; set => Ma_GV = value; }
        public string Ten_GV1 { get => Ten_GV; set => Ten_GV = value; }
        public DateTime Nam_sinh1 { get => Nam_sinh; set => Nam_sinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Que_quan1 { get => Que_quan; set => Que_quan = value; }
    }
}
