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
    public partial class StudentMain : Form
    {
        string Mail;
        Controller controllerObj;
        public StudentMain(string email)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Mail = email;
            label6.Text=controllerObj.GetWallet(Mail).ToString();
            label4.Text=controllerObj.Getrate(Mail).ToString();
            label5.Text=controllerObj.GetLevl(Mail).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGuardian d = new AddGuardian();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookASession d = new BookASession();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SHistory d = new SHistory();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportAProblem d = new ReportAProblem();
            d.Show();
        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentMain settings = new StudentMain(Mail);
            this.Close();
            settings.Close();
        }
    }
}
