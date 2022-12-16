using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantBillingSystem
{
    public partial class placeorder_uc : UserControl
    {
        DatabaseConnection ob1 = new DatabaseConnection();
        String query;

        public placeorder_uc()
        {
            InitializeComponent();
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select name from items where category ='" + comboBox1.Text + "'";
            DataSet dset = ob1.datafetch(query);

            int i;
            for (i = 0; i < dset.Tables[0].Rows.Count;i++)
            {
                listBox1.Items.Add(dset.Tables[0].Rows[i][0].ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select name from items where category ='"+ comboBox1.Text + "' and name like '"+textBox1.Text+"%'";
            DataSet dset = ob1.datafetch(query);

            int i;
            for (i = 0; i < dset.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(dset.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            numericUpDown1.ResetText();
            textBox5.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            textBox2.Text = text;
            query = "select price from items where name = '" + text + "' ";
            DataSet dset = ob1.datafetch(query);

            try
            {
                textBox4.Text = dset.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quantity = Int64.Parse(numericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(textBox4.Text);
            textBox5.Text = (quantity * price).ToString();
        }


       protected int i, total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox5.Text != "0" && textBox5.Text != "")
            {
                i = dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = textBox2.Text;
                dataGridView1.Rows[i].Cells[1].Value = textBox4.Text;
                dataGridView1.Rows[i].Cells[2].Value = numericUpDown1.Value;
                dataGridView1.Rows[i].Cells[3].Value = textBox5.Text;

                total = total + int.Parse(textBox5.Text);
                label8.Text = "BDT. " + total;
            }
            else 
            {
                MessageBox.Show("You Need to Select Minimum 1 item","Select Item",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        int amount;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }

            total = total - amount;
            label8.Text = "BDT " + total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "My Restaurant Bill";
            print.SubTitle = string.Format("Date {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Price " + label8.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);

            total = 0;
            dataGridView1.Rows.Clear();
            label8.Text= "BDT "+total;
            numericUpDown1.ResetText();
            textBox5.Clear();
            textBox4.Clear();
            textBox2.Clear();

        }







    }
}
