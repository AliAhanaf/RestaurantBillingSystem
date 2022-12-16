using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantBillingSystem
{
    internal class DatabaseConnection
    {

        protected SqlConnection dbconnect()
        {
            SqlConnection db = new SqlConnection();
            db.ConnectionString = "Data Source=DESKTOP-A13V3U5\\SQLEXPRESS; database=billingsystem; Integrated security = True";
            return db;
        }

        public DataSet datafetch(String query)
        {
            SqlConnection obj = dbconnect();
            SqlCommand comm = new SqlCommand();
            comm.Connection = obj;
            comm.CommandText = query;
            SqlDataAdapter Dadp = new SqlDataAdapter(comm);
            DataSet Dset = new DataSet();
            Dadp.Fill(Dset);
            return Dset;
        }

        public void datainsert(String query) 
        { 
            SqlConnection obj = dbconnect();
            SqlCommand comm = new SqlCommand();
            comm.Connection = obj;
            obj.Open();
            comm.CommandText = query;
            comm.ExecuteNonQuery();
            obj.Close();

            MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

    }
}
