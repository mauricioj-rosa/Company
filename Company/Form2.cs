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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_name.Text) & !string.IsNullOrEmpty(txt_details.Text) && !string.IsNullOrEmpty(txt_price.Text) & !string.IsNullOrEmpty(txt_size.Text) & !string.IsNullOrEmpty(txt_weight.Text))
            {
                string sqlstring = "Data Source = DESKTOP-NKVT3VV\\SQLEXPRESS;Initial Catalog=company;Integrated Security=true";
                SqlConnection con = new SqlConnection(sqlstring);
                string query_create = $"insert into products(name_prod,amount_prod,price_prod,weight_prod,size_prod,details_prod,data_prod) values(@product,@amount,@price,@weight,@size,@details,@date);";
                SqlCommand command_ = new SqlCommand(query_create,con);

                try
                {
                    con.Open();
                    command_.Parameters.AddWithValue("@product",txt_name.Text);
                    command_.Parameters.AddWithValue("@price", Convert.ToDouble(txt_price.Text));
                    command_.Parameters.AddWithValue("@amount", Convert.ToInt32(num_amount.Value));
                    command_.Parameters.AddWithValue("@details", txt_details.Text);
                    command_.Parameters.AddWithValue("@size", Convert.ToDouble(txt_size.Text));
                    command_.Parameters.AddWithValue("@weight",Convert.ToDouble(txt_weight.Text));
                    command_.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    command_.ExecuteNonQuery();
                    MessageBox.Show("Product added!");
                    this.Close();  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
            }
            else
            {
                MessageBox.Show("Please Fill all the components");
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar)&& (e.KeyChar!=','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
