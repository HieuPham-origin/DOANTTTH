using System;
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
    public partial class fQLHocVien : Form
    {
        public fQLHocVien()
        {
            InitializeComponent();
        }

        private void btn_Ghidanh_Click(object sender, EventArgs e)
        {
            fGhiDanh ghidanh = new fGhiDanh();
            ghidanh.Show();
        }
    }
}
