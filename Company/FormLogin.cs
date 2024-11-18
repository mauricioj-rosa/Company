using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class FormLogin : Form
    {
        public int idUser;
        public string nameUser;
        public FormLogin()
        {
            InitializeComponent();



        }

        private void FormLogin_Load(object sender, EventArgs e)
        { 
            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strconn = "server=localhost; User id=root;password=;database=company";
            MySqlConnection conn = new MySqlConnection(strconn);
            try
            {

                string name = txtUser.Text;
                string pass = txtPass.Text;
                CriptoMD5 md5 = new CriptoMD5();
                name = md5.RetornarMD5(name);
                pass = md5.RetornarMD5(pass);

                string select = $"SELECT `user_type`,`user_id`, `user_name` FROM `users` WHERE `user_name` LIKE '{name}' AND `user_pass` LIKE '{pass}'"; 

                MySqlCommand cmd = new MySqlCommand(select,conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        

                        reader["user_id"].ToString();

                        
                        idUser =  (int)reader["user_type"];
                        nameUser = reader["user_name"].ToString();
                        
                        this.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Check your User Name Or Password!","Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text)&&!string.IsNullOrEmpty(txtPass.Text))
            {
                btnLogin.Enabled = true;
            }
        }

        private void linkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCreateUser f = new FormCreateUser();
            f.ShowDialog();
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass f = new ForgotPass();
            f.ShowDialog();
        }
    }
}
