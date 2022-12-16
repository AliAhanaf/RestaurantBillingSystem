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
    public partial class RemoveItem_UC : UserControl
    {
        DatabaseConnection obj = new DatabaseConnection();
        String query;

        public RemoveItem_UC()
        {
            InitializeComponent();
        }

        private void RemoveItem_UC_Load(object sender, EventArgs e)
        {
            query = "select * from items";
            DataSet dset = obj.datafetch(query);
            dataGridView1.DataSource = dset.Tables[0];
        }

        private void itemnamebox_TextChanged(object sender, EventArgs e)
        {
            query = "Select * from items where name like '"+itemnamebox.Text+"%' ";
            DataSet dset = obj.datafetch(query);
            dataGridView1.DataSource = dset.Tables[0];
        }

        int id ;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void removeitembtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure Delete this Item", "Item Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                query = "Delete from items where id = "+id+" ";
                obj.datainsert(query);
            }

            query = "select * from items";
            DataSet dset = obj.datafetch(query);
            dataGridView1.DataSource = dset.Tables[0];
        }





    }
}
