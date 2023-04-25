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
namespace TrungTamTinHoc.FormsChildGiangVien
{
    public partial class fLopHoc : Form
    {
        BUS_LopHoc bLH = new BUS_LopHoc();
        BUS_ChiTietDangKy bCTDK = new BUS_ChiTietDangKy();
        BUS_HocVien bHV = new BUS_HocVien();
        private string id;
        public fLopHoc(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            int maLH = bLH.getMaLHFromTenLH(cbx_LH.SelectedItem.ToString());
            List<string> list_hv = bCTDK.getMaHVByMaLH(maLH);

            if (list_hv.Count > 0)
            {
                dgv_LopHoc.Rows.Clear(); 

                foreach (string maHV in list_hv)
                {
                    DataTable dt = bHV.getDataTableByMaHV(maHV);
                    foreach (DataRow row in dt.Rows)
                    {
                        dgv_LopHoc.Rows.Add(row.ItemArray);
                    }
                }
            }
        }



        private void fLopHoc_Load(object sender, EventArgs e)
        {
            bLH.bindLHComboBoxByGV(cbx_LH, this.id);

        }
    }
}
