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
    }
}
