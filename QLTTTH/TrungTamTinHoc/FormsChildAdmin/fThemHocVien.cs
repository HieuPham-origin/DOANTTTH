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

        public fThemHocVien()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DTO_HocVien newHV = new DTO_HocVien(null, txt_name.Texts, date_dob.Value, txt_phone.Texts, txt_home.Texts);
            if (bHV.themHocVien(newHV))
            {
                MessageBox.Show("Thêm thành công");
                this.Close(); // close the current form
                fQLHocVien reload = new fQLHocVien();
                reload.Refresh(); // reload the fQLGiangVien form
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        
    }
}
