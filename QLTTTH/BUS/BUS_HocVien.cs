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
    public class BUS_HocVien
    {
        DAL_HocVien dHocVien = new DAL_HocVien();
        public bool themHocVien(DTO_HocVien hv)
        {
            return dHocVien.themHocVien(hv);
        }


        public bool suaHocVien(DTO_HocVien hv)
        {
            return dHocVien.suaHocVien(hv);
        }

        public bool xoaHocVien(DTO_HocVien hv)
        {
            return dHocVien.xoaHocVien(hv);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dHocVien.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView gridView, string name)
        {
            dHocVien.bindGridViewbySearch(gridView, name);
        }


        public void bindLHComboBoxByKH(ComboBox cbx, string ten_kh)
        {
            dHocVien.bindLHComboBoxByKH(cbx, ten_kh);
        }
    }
}
