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
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fQLHocVien : Form
    {
        private DTO_HocVien selectedHV;
        BUS_HocVien bHV = new BUS_HocVien();

        public fQLHocVien()
        {
            InitializeComponent();
        }

        private void btn_Ghidanh_Click(object sender, EventArgs e)
        {
            fThemHocVien ghidanh = new fThemHocVien();
            ghidanh.Show();
        }

        private void fQLHocVien_Load(object sender, EventArgs e)
        {
            bHV.bindGridView(dgv_HocVien);
            dgv_HocVien.Columns[0].HeaderText = "Mã Học Viên";
            dgv_HocVien.Columns[1].HeaderText = "Họ và tên";
            dgv_HocVien.Columns[2].HeaderText = "Ngày sinh";
            dgv_HocVien.Columns[3].HeaderText = "Địa chỉ";
            dgv_HocVien.Columns[4].HeaderText = "Số điện thoại";
        }

        private void btn_XoaHV_Click(object sender, EventArgs e)
        {
            if (selectedHV != null)
            {

                if (bHV.xoaHocVien(selectedHV))
                {   

                    MessageBox.Show("Xóa thành công");
                    dgv_HocVien.Rows.RemoveAt(dgv_HocVien.CurrentRow.Index);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void dgv_HocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_HocVien.Rows[e.RowIndex];
                selectedHV = new DTO_HocVien(
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                Convert.ToDateTime(row.Cells[2].Value),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString());
            }
        }

        private void dgv_HocVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string maHV = dgv_HocVien.Rows[e.RowIndex].Cells["Ma_HV"].Value.ToString();
            string tenHV = dgv_HocVien.Rows[e.RowIndex].Cells["Ten_HV"].Value.ToString();
            DateTime namSinh = Convert.ToDateTime(dgv_HocVien.Rows[e.RowIndex].Cells["Nam_sinh"].Value);
            string diaChi = dgv_HocVien.Rows[e.RowIndex].Cells["Dia_chi"].Value.ToString();
            string sdt = dgv_HocVien.Rows[e.RowIndex].Cells["sdt"].Value.ToString();

            DTO_HocVien newHV = new DTO_HocVien(maHV, tenHV, namSinh, diaChi, sdt);
            bHV.suaHocVien(newHV);

            // Refresh the DataGridView to show the updated data
            dgv_HocVien.Refresh();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bHV.bindGridViewbySearch(dgv_HocVien, txt_TimKiem.Texts);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true; 
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            if (dgv_HocVien.Rows.Count > 0) 
            {
                // Add header
                worksheet.Cells[1, 1] = "Mã Học Viên";
                worksheet.Cells[1, 2] = "Họ và tên";
                worksheet.Cells[1, 3] = "Ngày sinh";
                worksheet.Cells[1, 4] = "Địa chỉ";
                worksheet.Cells[1, 5] = "Số điện thoại";

                // Add data 
                for (int i = 0; i < dgv_HocVien.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_HocVien.Columns.Count; j++)
                    {
                        if (dgv_HocVien.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv_HocVien.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }


                // Autofit columns
                worksheet.Columns.AutoFit();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất");
            }
        }



    }
}
