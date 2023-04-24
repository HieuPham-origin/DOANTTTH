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
    public partial class fThemHocVien : Form
    {
        BUS_HocVien bHV = new BUS_HocVien();
        BUS_KhoaHoc bKH = new BUS_KhoaHoc();
        BUS_ChiTietDangKy bCTDK = new BUS_ChiTietDangKy();
        BUS_LopHoc bLH = new BUS_LopHoc();
        public fThemHocVien()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

        }

        private void fThemHocVien_Load(object sender, EventArgs e)
        {
            bKH.bindComboBox(cbx_KhoaHoc);
        }

        private void cbx_KhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten_kh = cbx_KhoaHoc.SelectedItem.ToString();
            bHV.bindLHComboBoxByKH(cbx_LopHoc, ten_kh);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            string selectedValue = cbx_LopHoc.SelectedItem.ToString();
            string[] parts = selectedValue.Split(new[] { ',', ']' }, StringSplitOptions.RemoveEmptyEntries);
            string tenLH = parts[1].Trim();

            DTO_ChiTietDangKy newCTDK = new DTO_ChiTietDangKy(DateTime.Today, bHV.getLatestMaHV(), bLH.getMaLHFromTenLH(tenLH));

            if (bCTDK.themChiTietDangKy(newCTDK))
            {
                DataGridViewRow row = dgv_ChiTiet.Rows[dgv_ChiTiet.Rows.Add()];
                row.Cells["col_MaHV"].Value = newCTDK.Ma_HV;
                row.Cells["col_tenLH"].Value = bLH.getNameById(newCTDK.Ma_LH);
                row.Cells["col_ngayDK"].Value = newCTDK.Ngay_Dang_Ky;
            }
            else
            {
                MessageBox.Show("Ghi danh thất bại");
                this.Close();
            }

        }

        private void btn_addHV_Click(object sender, EventArgs e)
        {
            lb_sdt.Visible = false;
            lb_tenhv.Visible = false;
            lb_diachi.Visible = false;
            DTO_HocVien newHV = new DTO_HocVien(null, txt_name.Texts, date_dob.Value, txt_home.Texts, txt_phone.Texts);
            if (bHV.checkSDTTonTai(txt_phone.Texts) || txt_phone.Texts == "")
            {
                lb_sdt.Visible = true;
                lb_tenhv.Visible = false;
                lb_diachi.Visible = false;
                return;
            }
            else if (txt_name.Texts == "")
            {
                lb_tenhv.Visible = true;
                lb_sdt.Visible = false;
                lb_diachi.Visible = false;
                return;
            }
            else if (txt_home.Texts == "")
            {
                lb_diachi.Visible = true;
                lb_sdt.Visible = false;
                lb_tenhv.Visible = false;
                return;
            }
            else
            {
                if (bHV.themHocVien(newHV))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    this.Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
