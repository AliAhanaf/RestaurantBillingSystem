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

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String categor = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            CategoryBox.Text = categor;
            Itemnameboxbottom.Text = name;
            PriceBox.Text = price.ToString();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            query = "update items set name = '"+Itemnameboxbottom.Text+"',category = '"+CategoryBox.Text+"', price = "+PriceBox.Text+" where id = "+id+" ";
            obj.datainsert(query);

            query = "Select * from items";
            DataSet dset = obj.datafetch(query);
            dataGridView1.DataSource = dset.Tables[0];
            CategoryBox.Clear();
            Itemnameboxbottom.Clear();
            PriceBox.Clear();
        }




    }
}
