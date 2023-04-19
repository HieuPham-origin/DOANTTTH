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
    public partial class fQLGiangVien : Form
    {

        private DTO_GiangVien selectedGV;
        BUS_GiangVien bGV = new BUS_GiangVien();
        public fQLGiangVien()
        {
            InitializeComponent();
        }

        private void btn_ThemGV_Click(object sender, EventArgs e)
        {
            fThemGiangVien addGV = new fThemGiangVien();
            addGV.Show();
        }

        private void fQLGiangVien_Load(object sender, EventArgs e)
        {
            bGV.bindGridView(dgv_GiangVien);
            dgv_GiangVien.Columns[0].HeaderText = "Mã GV";
            dgv_GiangVien.Columns[1].HeaderText = "Họ và tên";
            dgv_GiangVien.Columns[2].HeaderText = "Ngày sinh";
            dgv_GiangVien.Columns[3].HeaderText = "SĐT";
            dgv_GiangVien.Columns[4].HeaderText = "Quê quán";
        }

        private void btn_XoaGV_Click(object sender, EventArgs e)
        {
            if (selectedGV != null)
            {
                if (bGV.xoaGiangVien(selectedGV))
                {
                    MessageBox.Show("Xóa thành công");
                    dgv_GiangVien.Rows.RemoveAt(dgv_GiangVien.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void dgv_GiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_GiangVien.Rows[e.RowIndex];

                // Kiểm tra rỗng sau đó mới truyền data
                string maGV = "";
                if (row.Cells[0].Value != null)
                    maGV = row.Cells[0].Value.ToString();

                string tenGV = "";
                if (row.Cells[1].Value != null)
                    tenGV = row.Cells[1].Value.ToString();

                DateTime ngaySinh = DateTime.MinValue;
                DateTime.TryParse(row.Cells[2].Value.ToString(), out ngaySinh);

                string gioiTinh = "";
                if (row.Cells[3].Value != null)
                    gioiTinh = row.Cells[3].Value.ToString();

                string diaChi = "";
                if (row.Cells[4].Value != null)
                    diaChi = row.Cells[4].Value.ToString();

                selectedGV = new DTO_GiangVien(maGV, tenGV, ngaySinh, gioiTinh, diaChi);
            }
        }


        private void dgv_GiangVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string maGV = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["Ma_GV"].Value != null)
                maGV = dgv_GiangVien.Rows[e.RowIndex].Cells["Ma_GV"].Value.ToString();

            string tenGV = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["Ten_GV"].Value != null)
                tenGV = dgv_GiangVien.Rows[e.RowIndex].Cells["Ten_GV"].Value.ToString();

            DateTime namSinh = DateTime.MinValue;
            DateTime.TryParse(dgv_GiangVien.Rows[e.RowIndex].Cells["Nam_sinh"].Value.ToString(), out namSinh);

            string sdt = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["sdt"].Value != null)
                sdt = dgv_GiangVien.Rows[e.RowIndex].Cells["sdt"].Value.ToString();

            string queQuan = "";
            if (dgv_GiangVien.Rows[e.RowIndex].Cells["Que_quan"].Value != null)
                queQuan = dgv_GiangVien.Rows[e.RowIndex].Cells["Que_quan"].Value.ToString();

            DTO_GiangVien newGV = new DTO_GiangVien(maGV, tenGV, namSinh, sdt, queQuan);
            bGV.suaGiangVien(newGV);

            // Refresh
            dgv_GiangVien.Refresh();
        }


        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bGV.bindGridViewbySearch(dgv_GiangVien, txt_TimKiem.Texts);
        }
    }
}
