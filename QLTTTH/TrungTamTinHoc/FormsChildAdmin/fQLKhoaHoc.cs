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
    public partial class fQLKhoaHoc : Form
    {
        private DTO_KhoaHoc selectedKH;
        BUS_KhoaHoc bKH = new BUS_KhoaHoc();

        public fQLKhoaHoc()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_KhoaHoc newKH = new DTO_KhoaHoc(0, txt_name.Texts, Convert.ToInt32(txt_fee.Texts));
            if (bKH.themKhoaHoc(newKH))
            {
                MessageBox.Show("Thêm thành công");
                this.fQLKhoaHoc_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void fQLKhoaHoc_Load(object sender, EventArgs e)
        {
            bKH.bindGridView(dgv_KhoaHoc);
            dgv_KhoaHoc.Columns[0].HeaderText = "Mã khóa học";
            dgv_KhoaHoc.Columns[1].HeaderText = "Tên khóa học";
            dgv_KhoaHoc.Columns[2].HeaderText = "Học phí";
        }

        private void dgv_KhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_KhoaHoc.Rows[e.RowIndex];
                selectedKH = new DTO_KhoaHoc(
                    Convert.ToInt32(row.Cells[0].Value.ToString()),
                    row.Cells[1].Value.ToString(),
                    Convert.ToInt32(row.Cells[2].Value.ToString()));
            }
        }

        private void dgv_KhoaHoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int maKH = Convert.ToInt32(dgv_KhoaHoc.Rows[e.RowIndex].Cells["Ma_KH"].Value.ToString());
            string tenKH = dgv_KhoaHoc.Rows[e.RowIndex].Cells["Ten_KH"].Value.ToString();
            int hocPhi = Convert.ToInt32(dgv_KhoaHoc.Rows[e.RowIndex].Cells["Hoc_phi"].Value.ToString());
            DTO_KhoaHoc newKH = new DTO_KhoaHoc(maKH, tenKH, hocPhi);
            bKH.suaKhoaHoc(newKH);

            // Refresh the DataGridView to show the updated data
            dgv_KhoaHoc.Refresh();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            bKH.bindGridViewbySearch(dgv_KhoaHoc, txt_Search.Texts);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (selectedKH != null)
            {
                if (bKH.xoaKhoaHoc(selectedKH))
                {
                    MessageBox.Show("Xóa khóa học thành công");
                    dgv_KhoaHoc.Rows.RemoveAt(dgv_KhoaHoc.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
    }
}
