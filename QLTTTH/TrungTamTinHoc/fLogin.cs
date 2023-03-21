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

    }
}
