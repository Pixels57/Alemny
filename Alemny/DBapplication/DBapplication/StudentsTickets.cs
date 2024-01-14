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
    public partial class StudentsTickets : Form
    {
        Controller obj;
        public StudentsTickets()
        {
            InitializeComponent();
            obj = new Controller();
            DataTable dt = obj.GetStudentTickets();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageTicket v = new ManageTicket(int.Parse(textBox1.Text));
            v.Show();
        }
    }
}
