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
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            nameUser = txtUser.Text;
            MessageBox.Show(txtUser.Text);
            this.Close();
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
