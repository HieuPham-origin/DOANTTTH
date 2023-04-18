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
    public partial class fHoaDon : Form
    {
        BUS_ChiTietHoaDon bCTHD = new BUS_ChiTietHoaDon();
        private int hdID;

        public fHoaDon()
        {
            InitializeComponent();
        }

        public int HdID { get => hdID; set => hdID = value; }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            bCTHD.bindComboBox(cbx_KhoaHoc);
            /*ct.bindGridView(dgv_HoaDon, hd.getCurrentMaHoaDon());*/
        }
    }
}
