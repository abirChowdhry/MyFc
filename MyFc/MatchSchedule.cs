using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFc
{
    public partial class MatchSchedule : Form
    {
        public MatchSchedule()
        {
            InitializeComponent();
        }

        private void Maximisebutton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            else this.WindowState = FormWindowState.Maximized;
        }

        private void Minimisebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MatchSchedule_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
