using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;

namespace Company
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are You sure you want to close?", "Close?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sqlstring = "Data Source = DESKTOP-NKVT3VV\\SQLEXPRESS;Initial Catalog=testdb;Integrated Security=true";
            SqlConnection con = new SqlConnection(sqlstring);
            try
            {
                con.Open();
                MessageBox.Show("Connected");

                string query_create_user = $"INSERT INTO products(name_prod,amount_prod,price_prod,weight_prod,size_prod,details_prod) values({},{},{},{},{},{})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
