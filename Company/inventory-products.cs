﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Company
{
    public partial class inventory_products : Form
    {
        public inventory_products()
        {
            InitializeComponent();
        }

        private void inventory_products_Load(object sender, EventArgs e)
        {
            string con = "Data Source = DESKTOP-NKVT3VV\\SQLEXPRESS;Initial Catalog=Company;Integrated Security=true";
            SqlConnection conn = new SqlConnection(con);
            try
            {
                conn.Open();
                var sql_select = "select name_prod, amount_prod, price_prod from products;";
                using (SqlDataAdapter da = new SqlDataAdapter(sql_select, con))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                }
                
                MessageBox.Show("Ok");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        
    }
}
