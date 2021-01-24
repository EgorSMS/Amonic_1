using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amonic_
{
    public partial class UserForms : Form
    {
        public UserForms()
        {
            InitializeComponent();

            dataGridView1.Columns[1].HeaderText = "Date";
            dataGridView1.Columns[2].HeaderText = "Login time";
            dataGridView1.Columns[3].HeaderText = "Logout time";
            dataGridView1.Columns[4].HeaderText = "Time spent on system";
            dataGridView1.Columns[5].HeaderText = "Unsuccessful logout reason";
            //label1.Text = $"Hi {}, Welcome to AMONIC Airlines.";
            label2.Text = $"Time spent on system: ";
            var sw = new Stopwatch();
            sw.Start();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartPage frm = new StartPage();
            frm.Show();
            Hide();
        }
    }
}
