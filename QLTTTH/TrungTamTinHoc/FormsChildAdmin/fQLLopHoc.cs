using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fQLLopHoc : Form
    {

        BUS_LopHoc bLH = new BUS_LopHoc();
        public fQLLopHoc()
        {
            InitializeComponent();
        }

        private void btn_ThemLopHoc_Click(object sender, EventArgs e)
        {
            fThemLopHoc lophoc = new fThemLopHoc();
            lophoc.Show();
        }

        private void fQLLopHoc_Load(object sender, EventArgs e)
        {
            bLH.bindGridView(dgv_LopHoc);
            dgv_LopHoc.Columns[0].HeaderText = "Mã lớp";
            dgv_LopHoc.Columns[1].HeaderText = "Tên lớp";
            dgv_LopHoc.Columns[2].HeaderText = "Mã Khóa học";
            dgv_LopHoc.Columns[3].HeaderText = "Mã phòng";
            dgv_LopHoc.Columns[4].HeaderText = "Mã ca";
            dgv_LopHoc.Columns[5].HeaderText = "Mã GV";
            dgv_LopHoc.Columns[6].HeaderText = "Bắt đầu";
            dgv_LopHoc.Columns[7].HeaderText = "Kết thúc";
            dgv_LopHoc.Columns[8].HeaderText = "Đang mở";
            dgv_LopHoc.Columns[9].HeaderText = "Số buổi";
            dgv_LopHoc.Columns[10].HeaderText = "Số lượng";
        }
    }
}
