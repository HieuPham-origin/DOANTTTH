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
    public partial class Menu : Form
    {
        //Fields
        bool visible = false;
        
        //Constructor
        public Menu()
        {
            InitializeComponent();

        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonSetting_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (!visible)
            {
                panelInfo.Visible = true;
                visible = true;
            }
            else
            {
                panelInfo.Visible = false;
                visible = false;
            }

        }

        



        /*private void iconButtonSetting_MouseClick(object sender, MouseEventArgs e)
        {
            panelInfo.Show();
        }*/
















        //Structs



    }
}
