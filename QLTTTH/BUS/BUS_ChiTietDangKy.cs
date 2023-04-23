using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class BUS_ChiTietDangKy 
    {
        DAL_ChiTietDangKy dCTDK = new DAL_ChiTietDangKy();
        public bool themChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
    
            return dCTDK.themChiTietDangKy(ctdk);
        }

        public bool xoaChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {

            return dCTDK.xoaChiTietDangKy(ctdk);
        }

        public bool suaChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
            return dCTDK.suaChiTietDangKy(ctdk);
        }
    }
}
