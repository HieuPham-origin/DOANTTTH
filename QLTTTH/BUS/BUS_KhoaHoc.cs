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
    public class BUS_KhoaHoc
    {
        DAL_KhoaHoc dKhoaHoc = new DAL_KhoaHoc();

        public bool themKhoaHoc(DTO_KhoaHoc kh)
        {
            return dKhoaHoc.themKhoaHoc(kh);
        }

        public bool suaKhoaHoc(DTO_KhoaHoc kh)
        {
            return dKhoaHoc.suaKhoaHoc(kh);
        }

        public bool xoaKhoaHoc(DTO_KhoaHoc kh)
        {
            return dKhoaHoc.xoaKhoaHoc(kh);
        }

        public void bindGridView(DataGridView dataGridView)
        {
            dKhoaHoc.bindGridView(dataGridView);
        }

        public void bindGridViewbySearch(DataGridView gridView, string name)
        {
            dKhoaHoc.bindGridViewbySearch(gridView, name);
        }
    }
}
