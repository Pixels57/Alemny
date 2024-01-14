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
    public partial class ManageSlots : Form
    {
        Controller obj;
        int idint;
        public ManageSlots(int id)
        {
            InitializeComponent();
            obj = new Controller();
            idint = id;
            DataTable d = obj.GetSlotsDate(id);
            comboBox1.DataSource = d;
            comboBox1.ValueMember = "Dt";
            string selectedDate = comboBox1.SelectedValue?.ToString();
            DataTable dt = obj.GetSlotsTime(selectedDate);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "Tm";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
