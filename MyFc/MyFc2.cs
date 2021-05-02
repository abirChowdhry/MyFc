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
    public partial class MyFc2 : Form
    {
        public MyFc2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void WholeSquadbutton_Click(object sender, EventArgs e)
        {
            MySquad mySquad = new MySquad();
            mySquad.Show();
        }

        private void UpdateRatingbutton_Click(object sender, EventArgs e)
        {
            PlayerRating playerRating = new PlayerRating();
            playerRating.Show();
        }

        private void Casesbutton_Click(object sender, EventArgs e)
        {
            ExceptionCase exceptionCase = new ExceptionCase();
            exceptionCase.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RatingUpdate ratingUpdate = new RatingUpdate();
            ratingUpdate.Show();
        }

        private void MatchSchedulebutton_Click(object sender, EventArgs e)
        {
            MatchSchedule matchSchedule = new MatchSchedule();
            matchSchedule.Show();
        }
    }
}
