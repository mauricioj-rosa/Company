using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Company
{
    class User
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string TypeUser { get; set; }


        public int id
        {
            get => Id;
            set => Id = value;
        }
        public string name
        {
            get => Name;
            set => Name = value;
        }
        public string email
        {
            get => Email;
            set => Email = value;
        }
        public string typeUser
        {
            get => TypeUser;
            set => TypeUser = value;
        }
        
        public void IdType()
        {
            Form1 f = new Form1();
            
            if (Id == 1)
            {
                MessageBox.Show("Hello, Manager");
            }
            else if (Id == 2)
            {
                MessageBox.Show("Olá, Boa tarde!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
