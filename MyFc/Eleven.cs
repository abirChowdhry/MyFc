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
    public partial class Eleven : Form
    {
        public Eleven()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MovePlayerbutton_Click(object sender, EventArgs e)
        {
            TeamSelection teamSelection = new TeamSelection();
            teamSelection.Show();
            this.Hide();
        }

        private void RecoverPlayerbutton_Click(object sender, EventArgs e)
        {
            UpdatePerformance updatePerformance = new UpdatePerformance();
            updatePerformance.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteTeam deleteTeam = new DeleteTeam();
            deleteTeam.Show();
        }
    }
}
