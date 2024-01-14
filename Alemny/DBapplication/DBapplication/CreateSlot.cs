using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class Create_Slot : Form
    {
        Controller controllerobj;
        private string[] arr = { "Cairo", "Maadi", "New Cairo", "Zamalek", "Zayed" };

        int intid;
        public Create_Slot(int id)
        {
            InitializeComponent();
            intid = id;
            controllerobj = new Controller();
            comboBox1.DataSource = arr;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerobj.InsertSlot(intid, textBox1.Text, comboBox1.Text, textBox3.Text);
            //int rresult = controllerObj.RemSuperSSN(int.Parse(textBox1.Text));
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Slot failed");
            }
            else
            {
                MessageBox.Show("The Slot is inserted successfully!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
