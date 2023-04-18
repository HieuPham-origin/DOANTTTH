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
    public class BUS_HoaDon
    {
        DAL_HoaDon dHoaDon = new DAL_HoaDon();
        public bool themHoaDon(DTO_HoaDon hd)
        {
            return dHoaDon.themHoaDon(hd);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dHoaDon.bindGridView(dataGridView);
        }

        public int getCurrentMaHoaDon()
        {
            return dHoaDon.getCurrentMaHoaDon();
        }
    }
}
