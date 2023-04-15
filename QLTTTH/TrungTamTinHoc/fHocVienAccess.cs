using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrungTamTinHoc
{
    public partial class fHocVienAccess : Form
    {
        //Fields
        private IconButton currBtn;
        private Panel leftBorderBtn;
        private Form currChildForm;
        //Constructor
        public fHocVienAccess()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelNav.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        public static Color colorActive = Color.RoyalBlue;

        //methods
        private void ActivateButton(object senderBTN, Color color)
        {
            if (senderBTN != null)
            {
                DisableButton();
                currBtn = (IconButton)senderBTN;
                currBtn.BackColor = Color.RoyalBlue;
                currBtn.ForeColor = Color.White;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = color;
                currBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currBtn.ImageAlign = ContentAlignment.MiddleRight;

                //leftBorder btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon curr child form
                iconCurrChildForm.IconChar = currBtn.IconChar;
                iconCurrChildForm.IconColor = Color.White;
                lbTitle.Text = currBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currBtn != null)
            {
                currBtn.BackColor = Color.RoyalBlue;
                currBtn.ForeColor = Color.White;
                currBtn.TextAlign = ContentAlignment.MiddleCenter;
                currBtn.IconColor = Color.White;
                currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currChildForm != null)
            {
                // open only form
                currChildForm.Close();
            }
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Thongtincanhan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);
            OpenChildForm(new FormsChildHocVien.ThongtinCaNhan());
        }

        private void btn_KhoaHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);

        }

        private void btn_Xemlichhoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);

        }

        private void btn_DangKiKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);

        }

        private void btn_Xemdiem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);

        }

        private void btn_HdSudung_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorActive);

        }

        private void btn_Dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogin newLogin = new fLogin();
            newLogin.Show();
        }

    }
}
