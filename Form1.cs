using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerScienceTrivia
{
    public partial class frmHomePage : Form
    {
        
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmGamePage frm = new frmGamePage();
            this.Hide();
            frm.Show();
            



        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            frmHowToPage frm = new frmHowToPage();
            this.Hide();
            frm.Show();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
