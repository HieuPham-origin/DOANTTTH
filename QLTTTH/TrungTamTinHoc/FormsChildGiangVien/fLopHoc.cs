using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace TrungTamTinHoc.FormsChildGiangVien
{
    public partial class fLopHoc : Form
    {
        BUS_LopHoc bLH = new BUS_LopHoc();

        public fLopHoc()
        {
            InitializeComponent();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {

        }

        private void fLopHoc_Load(object sender, EventArgs e)
        {
            bLH.bindLHComboBox(cbx_LH);

        }
    }
}
