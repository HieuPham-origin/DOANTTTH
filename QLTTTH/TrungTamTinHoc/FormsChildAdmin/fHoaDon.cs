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
        BUS_KhoaHoc bKH = new BUS_KhoaHoc();
        private int hdID;
        private string ndt = "";
        private int tongTien = 0;
        public fHoaDon()
        {
            InitializeComponent();
        }

        public int HdID { get => hdID; set => hdID = value; }
        public string Ndt { get => ndt; set => ndt = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            bCTHD.bindComboBox(cbx_KhoaHoc);
            txt_TongTien.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_ChiTietHoaDon cthd = new DTO_ChiTietHoaDon(hdID, bKH.getIdByName(cbx_KhoaHoc.SelectedItem.ToString()));
            if (bCTHD.themChiTietHoaDon(cthd))
            {

                DataGridViewRow row = dgv_KhoaHoc.Rows[dgv_KhoaHoc.Rows.Add()]; 
                row.Cells["col_MaKH"].Value = cthd.Ma_KH; 
                row.Cells["col_tenKH"].Value = bKH.getNameById(cthd.Ma_KH);
                row.Cells["col_hocPhi"].Value = bKH.getFeeById(cthd.Ma_KH);
                tongTien += bKH.getFeeById(cthd.Ma_KH);
                txt_TongTien.Texts = tongTien.ToString();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            Ndt = txt_TenKhach.Texts;
            MessageBox.Show("Tạo hóa đơn thành công");
            this.Close();
        }

    }
}
