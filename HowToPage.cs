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
    public partial class frmHowToPage : Form
    {
        public frmHowToPage()
        {
            InitializeComponent();
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHomePage frm = new frmHomePage();
            this.Hide();
            frm.Show();
        }
    }
}
