﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fQLGiangVien : Form
    {
        public fQLGiangVien()
        {
            InitializeComponent();
        }

        private void btn_ThemGV_Click(object sender, EventArgs e)
        {
            fAddGV addGV = new fAddGV();
            addGV.Show();
        }
    }
}
