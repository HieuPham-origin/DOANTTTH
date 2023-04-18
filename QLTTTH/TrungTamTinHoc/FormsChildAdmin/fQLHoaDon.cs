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
using DTO;
namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fQLHoaDon : Form
    {
        BUS_HoaDon bHD = new BUS_HoaDon();
        public fQLHoaDon()
        {
            InitializeComponent();
        }

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            DTO_HoaDon dto_hd = new DTO_HoaDon(0, DateTime.Today, 0);
            if (bHD.themHoaDon(dto_hd))
            {
                fHoaDon HDmoi = new fHoaDon();
                HDmoi.HdID = bHD.getCurrentMaHoaDon()
                HDmoi.ShowDialog();

                BUS_ChiTietHoaDon bCTHD = new BUS_ChiTietHoaDon();

            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại");
            }
            
            
        }
    }
}
