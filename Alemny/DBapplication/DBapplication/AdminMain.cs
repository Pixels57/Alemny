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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentsTickets v = new StudentsTickets();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMain settings = new AdminMain();
            this.Close();
            settings.Close();
        }
    }
}
