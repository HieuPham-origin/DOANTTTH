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

namespace TrungTamTinHoc
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            registerEvent();
        }

        #region Event

        void registerEvent()
        {
            lblClose.Click += lblClose_Click;
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Tên đăng nhập")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Tên đăng nhập";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS_TaiKhoan tk = new BUS_TaiKhoan();

            if (tk.checkLogin(txtUser.Text, txtPassword.Text))
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
