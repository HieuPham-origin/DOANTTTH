using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_TaiKhoan
    {
        private DAL_TaiKhoan dal = new DAL_TaiKhoan();
        public bool checkLogin(string username, string pass, int userType)
        {
            return dal.checkLogin(username, pass, userType);
        }
    }
}
