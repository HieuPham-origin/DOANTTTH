using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS;

namespace TrungTamTinHoc.FormsChildAdmin
{
    public partial class fBaoCao : Form
    {
        BUS_HoaDon hd = new BUS_HoaDon();

        public fBaoCao()
        {
            InitializeComponent();
        }

        private void load_Data()
        {
            cht_Doanhthu.DataSource = hd.getDoanhThu(Convert.ToDateTime(date_batdau.Value), Convert.ToDateTime(date_ketthuc.Value));
            Series doanhThuSeries = cht_Doanhthu.Series.FindByName("DoanhThu");

            // Remove the series if it exists
            if (doanhThuSeries != null)
            {
                cht_Doanhthu.Series.Remove(doanhThuSeries);
            }
            cht_Doanhthu.Series.Add("DoanhThu");
            cht_Doanhthu.Series["DoanhThu"].XValueMember = "ngaylap";
            cht_Doanhthu.Series["DoanhThu"].YValueMembers = "doanhthu";
            cht_Doanhthu.DataBind();
            cht_Doanhthu.Titles.Add("Tổng doanh thu");
            Legend doanhThuLegend = cht_Doanhthu.Legends.FindByName("Doanh thu");

            if (doanhThuLegend != null)
            {
                cht_Doanhthu.Legends.Remove(doanhThuLegend);
            }
            cht_Doanhthu.Legends.Add("Doanh thu");
            cht_Doanhthu.ChartAreas[0].AxisX.Title = "Ngày";
            cht_Doanhthu.ChartAreas[0].AxisY.Title = "Doanh thu";
            cht_Doanhthu.Dock = DockStyle.Fill;
            this.Controls.Add(cht_Doanhthu);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            load_Data();
        }

        private void fBaoCao_Load(object sender, EventArgs e)
        {
            load_Data();
        }
    }
}
