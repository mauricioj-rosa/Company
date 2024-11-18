using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            f.ShowDialog();
            User user = new User();
            try
            {
                user.id = f.idUser;
                user.name = f.nameUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                user.IdType();
                lblUser.Text = $"Welcome {user.name}";
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
