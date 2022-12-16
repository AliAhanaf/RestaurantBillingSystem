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
    public partial class updateitems_UC : UserControl
    {
        DatabaseConnection obj = new DatabaseConnection();
        String query;

        public updateitems_UC()
        {
            InitializeComponent();
        }

        private void updateitems_UC_Load(object sender, EventArgs e)
        {
            query = "Select * from items";
            obj.datafetch(query);
            DataSet dset = obj.datafetch(query);

            dataGridView1.DataSource = dset.Tables[0];
        }

        private void searchitembox_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from items where name like '" + searchitembox.Text + "%' ";
            DataSet dset = obj.datafetch(query);
            dataGridView1.DataSource = dset.Tables[0];
        }
    }
}
