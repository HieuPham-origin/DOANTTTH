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
    public partial class fThemGiangVien : Form
    {

        BUS_GiangVien bGV = new BUS_GiangVien();
        public fThemGiangVien()
        {
            InitializeComponent();
        }

        public void DisableLuuButton()
        {
            btn_Luu.Enabled = false;
        }


        public void DisableThemButton()
        {
            btn_Them.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO_GiangVien newGV = new DTO_GiangVien(null, txt_name.Texts, date_dob.Value, txt_phone.Texts, txt_home.Texts);
            if (bGV.themGiangVien(newGV))
            {
                MessageBox.Show("Thêm thành công");
                this.Close(); // close the current form
                fQLGiangVien reload = new fQLGiangVien();
                reload.Refresh(); // reload the fQLGiangVien form
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
