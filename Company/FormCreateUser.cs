using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Company
{
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPass.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                btnCreate.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string strconn = "server=localhost;User id=root;password=;database=company";
            MySqlConnection conn = new MySqlConnection(strconn);
            try
            {

                CriptoMD5 mD5 = new CriptoMD5();
                string criptoName = mD5.RetornarMD5(txtUser.Text);
                string criptoPass = mD5.RetornarMD5(txtPass.Text);
                string criptoEmail = mD5.RetornarMD5(txtEmail.Text);
                string create = $"INSERT INTO users (user_name,user_pass,user_email) VALUES ('{criptoName}','{criptoPass}','{criptoEmail}')";

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(create,conn);


                
                cmd.ExecuteNonQuery();
                MessageBox.Show($"User ADD With Sucess");
                this.Close();

                
                
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
