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
namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fThemHVVaoLH : Form
    {
        BUS_HocVien bHV = new BUS_HocVien();
        BUS_LopHoc bLH = new BUS_LopHoc();
        public fThemHVVaoLH()
        {
            InitializeComponent();
        }

        private void fThemHVVaoLH_Load(object sender, EventArgs e)
        {
            bHV.bindGridView(dgv_HocVien);
            dgv_HocVien.Columns[0].HeaderText = "Mã Học Viên";
            dgv_HocVien.Columns[1].HeaderText = "Họ và tên";
            dgv_HocVien.Columns[2].HeaderText = "Ngày sinh";
            dgv_HocVien.Columns[3].HeaderText = "Địa chỉ";
            dgv_HocVien.Columns[4].HeaderText = "Số điện thoại";
            bLH.bindOpenLHComboBox(cbx_LopHoc);
        }






    }
}
