using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBillingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(namebox.Text == "ahanaf" && Passbox.Text=="12345")
            {
                Homepage hmp = new Homepage();
                hmp.Show();
                this.Hide();
            }
        }

      

    }
}
