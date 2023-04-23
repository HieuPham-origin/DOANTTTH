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
    public partial class fQLLopHoc : Form
    {
        public fQLLopHoc()
        {
            InitializeComponent();
        }

        private void btn_ThemLopHoc_Click(object sender, EventArgs e)
        {
            fThemLopHoc lophoc = new fThemLopHoc();
            lophoc.Show();
        }
    }
}
