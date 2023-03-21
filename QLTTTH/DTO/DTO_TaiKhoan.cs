using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string TaiKhoan;
        private string pass;
        private int loai;

        public DTO_TaiKhoan() { }

        public DTO_TaiKhoan(string taiKhoan, string pass, int loai)
        {
            TaiKhoan = taiKhoan;
            this.pass = pass;
            this.loai = loai;
        }

        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Loai { get => loai; set => loai = value; }
    }
}
