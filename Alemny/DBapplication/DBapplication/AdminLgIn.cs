using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AdminLgIn : Form
    {
        Controller obj;
        public AdminLgIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new Controller(); 
            DataTable dt = obj.checkauthAdmin(em.Text, textBox4.Text);
            if (dt != null)
            {
                AdminMain v = new AdminMain();
                v.Show();
            }
            else
            {
                MessageBox.Show("Username or Password are incorrect");
            }
        }

        private void em_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
