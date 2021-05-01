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
    public partial class ExceptionCase : Form
    {
        public ExceptionCase()
        {
            InitializeComponent();
        }

        private void MovePlayerbutton_Click(object sender, EventArgs e)
        {
            InjuredPlayer injuredPlayer = new InjuredPlayer();
            injuredPlayer.Show();
            this.Hide();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void RecoverPlayerbutton_Click(object sender, EventArgs e)
        {
            RecoverPlayer recoverPlayer = new RecoverPlayer();
            recoverPlayer.Show();
            this.Hide();
        }
    }
}
