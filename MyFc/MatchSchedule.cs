﻿using System;
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

        private void AddMatchbutton_Click(object sender, EventArgs e)
        {
            AddMatch addMatch = new AddMatch();
            addMatch.Show();
            this.Hide();
        }

        private void UpdateMatchbutton_Click(object sender, EventArgs e)
        {
            UpdateMatch updateMatch = new UpdateMatch();
            updateMatch.Show();
            this.Hide();
        }
    }
}
