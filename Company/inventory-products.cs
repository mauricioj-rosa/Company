using System;
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
                var sql_select = "select id_prod as id,name_prod as nome, amount_prod as estoque, price_prod as preço, details_prod as details from products;";
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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
            
            lbl_preco.Text = $"Valor entre {trackBar1.Value.ToString() +",00"} - {trackBar2.Value.ToString()+"0,00"}";

        }
    }
}
