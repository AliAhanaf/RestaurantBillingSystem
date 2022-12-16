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
    public partial class addItems_UC1 : UserControl
    {
        DatabaseConnection ob1 = new DatabaseConnection();
        String query;

        public addItems_UC1()
        {
            InitializeComponent();
        }

        private void additembtn_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,category,price) values ('" + itembox.Text + "', '" + categorybox.Text + "', " + pricebox.Text + ")";
            ob1.datainsert(query);
            clear();
        }

        public void clear()
        {
            categorybox.SelectedIndex = -1;
            itembox.Clear();
            pricebox.Clear();

        }

        private void addItems_UC1_Leave(object sender, EventArgs e)
        {
            clear();
        }
    }
}
