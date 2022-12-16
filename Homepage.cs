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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fn1 = new Form1();
            this.Hide();
            fn1.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            addItems_UC11.Visible = false;
            placeorder_uc1.Visible = false;
            updateitems_UC1.Visible = false;
        }

        private void additembtn_Click(object sender, EventArgs e)
        {
            addItems_UC11.Visible= true;
            addItems_UC11.BringToFront();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            placeorder_uc1.Visible = true;
            placeorder_uc1.BringToFront();


        }
        private void updateitembtn_Click(object sender, EventArgs e)
        {
            updateitems_UC1.Visible = true;
            updateitems_UC1.BringToFront();
        }
    }
}
