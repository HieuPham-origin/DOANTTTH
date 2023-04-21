using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{   
    class BUS_LopHoc
    {
        DAL_LopHoc dLH = new DAL_LopHoc();


        public void bindComboBox(ComboBox cbx)
        {
            dLH.bindComboBox(cbx);
        }


        public bool themLopHoc(DTO_LopHoc lh)
        {
            return dLH.themLopHoc(lh);
        }


        public bool suaLopHoc(DTO_LopHoc lh)
        {
            return dLH.suaLopHoc(lh);
        }


        public bool xoaLopHoc(DTO_LopHoc lh)
        {
            return dLH.xoaLopHoc(lh);
        }


    }
}
