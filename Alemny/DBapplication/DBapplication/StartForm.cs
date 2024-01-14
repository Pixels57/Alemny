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
    public partial class StartForm : Form
    {
        Controller controllerObj;
        public StartForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student d = new Student();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instructor d = new Instructor();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLgIn d = new AdminLgIn();
            d.Show();
        }
    }
}
