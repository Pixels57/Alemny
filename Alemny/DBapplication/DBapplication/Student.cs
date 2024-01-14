using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    
    public partial class Student : Form
    {
        private string[] arr = { "Cairo", "Maadi", "New Cairo", "Zamalek", "Zayed" };
        Controller controllerObj;
        public Student()
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox1.DataSource = arr;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char gender='U';
            if (radioButton1.Checked)
                gender = 'M';
            else if (radioButton2.Checked)
                gender = 'F';
            else
                MessageBox.Show("Please select a gender");
            

            if(gender=='M' || gender=='F')
            {
                int result = controllerObj.InsertStudent(fn.Text, ln.Text, gender, Int16.Parse(age.Text), email.Text, pn.Text, pass.Text, comboBox1.SelectedValue.ToString(), city.Text);
                MessageBox.Show("Sign up successful, you can now log in to your account!");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.checkauth(em.Text, textBox4.Text);
            if(dt!=null)
            {
                StudentMain v = new StudentMain(em.Text);
                v.Show();
            }
            else
            {
                MessageBox.Show("Username or Password are incorrect");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void em_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
