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
    public partial class InstructorMain : Form
    {
        string Mail;
        int id;
        Controller obj;
        public InstructorMain(string email)
        {
            InitializeComponent();
            obj = new Controller();
            Mail = email;
            id = int.Parse(obj.GetInstId(Mail).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Slot f = new Create_Slot(id);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstPrevSessions f = new InstPrevSessions();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj = new Controller();
            obj.GetSlotsDate(id);
            if (obj == null)
            {
                MessageBox.Show("You don't have any slots");
            }
            else
            {
                ManageSlots f = new ManageSlots(id);
                f.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportProbForInt f = new ReportProbForInt();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InstructorMain settings = new InstructorMain(Mail);
            this.Close();
            settings.Close();
        }
    }
}
