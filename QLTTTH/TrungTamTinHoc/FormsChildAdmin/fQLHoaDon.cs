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

            DTO_HoaDon dto_hd = new DTO_HoaDon(0, "", DateTime.Today, 0);
            if (bHD.themHoaDon(dto_hd))
            {
                fHoaDon HDmoi = new fHoaDon();
                HDmoi.HdID = bHD.getCurrentMaHoaDon();
                
                HDmoi.ShowDialog();
                DTO_HoaDon updatedHD = new DTO_HoaDon(bHD.getCurrentMaHoaDon(), HDmoi.Ndt, DateTime.Today, HDmoi.TongTien);
                bHD.suaHoaDon(updatedHD);
                bHD.bindGridView(dgv_HoaDon);

            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại");
            }
            
            
        }

        private void fQLHoaDon_Load(object sender, EventArgs e)
        {
            bHD.bindGridView(dgv_HoaDon);
            dgv_HoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgv_HoaDon.Columns[1].HeaderText = "Người đóng";
            dgv_HoaDon.Columns[2].HeaderText = "Ngày lập";
            dgv_HoaDon.Columns[3].HeaderText = "Tổng học phí";
    
        }
    }
}
