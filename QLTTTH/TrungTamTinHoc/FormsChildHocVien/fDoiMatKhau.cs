﻿using System;
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
namespace TrungTamTinHoc.FormsChildHocVien
{
    public partial class fDoiMatKhau : Form
    {
        private string id;
        BUS_TaiKhoan bTK = new BUS_TaiKhoan();
        public fDoiMatKhau(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            lb_saimkcu.Visible = false;
            lb_dodaimk.Visible = false;
            lb_saixacnhan.Visible = false;
            if (bTK.getMKByTaiKhoan(this.id) != txt_mkcu.Texts)
            {
                lb_saimkcu.Visible = true;
                return;
            }
            else if (txt_mkmoi.Texts.Length < 8)
            {
                lb_dodaimk.Visible = true;
                return;
            }
            else if (txt_mkmoi.Texts != txt_nhaplaimkmoi.Texts)
            {
                lb_saixacnhan.Visible = true;
                return;
            }
            else
            {
                string newPass = txt_mkmoi.Texts;
                bool result = bTK.updateMatKhau(this.id, newPass);
                if (result)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                }
            }
        }


    }
}
