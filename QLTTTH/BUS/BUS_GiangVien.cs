﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_GiangVien
    {

        DAL_GiangVien dGiangVien = new DAL_GiangVien();
        public bool themGiangVien(DTO_GiangVien gv)
        {
            return dGiangVien.themGiangVien(gv);
        }


        public bool suaGiangVien(DTO_GiangVien gv)
        {
            return dGiangVien.suaGiangVien(gv);
        }

        public bool xoaGiangVien(DTO_GiangVien gv)
        {
            return dGiangVien.xoaGiangVien(gv);
        }


        public void bindGridView(DataGridView dataGridView)
        {
            dGiangVien.bindGridView(dataGridView);
        }


    }
}
