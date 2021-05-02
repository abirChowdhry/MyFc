using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFc
{
    public partial class MatchCalender : Form
    {
        public MatchCalender()
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
            MatchSchedule matchSchedule = new MatchSchedule();
            matchSchedule.Show();
            this.Hide();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (MatchdateTimePicker.Checked == false) { MessageBox.Show("Select a Match Date to Search", "ERROR"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "SELECT * FROM matches where matchdate = '" + MatchdateTimePicker.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Match> matches = new List<Match>();

                while (reader.Read())
                {
                    Match matches1 = new Match();

                    matches1.MatchDate = reader["matchdate"].ToString();
                    matches1.Tournament = reader["tournament"].ToString();
                    matches1.Region = reader["region"].ToString();
                    matches1.Result = reader["result"].ToString();

                    matches.Add(matches1);
                }

                MatchdataGridView.DataSource = matches;
                connection.Close();
            }
        }

        private void MatchCalender_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM matches";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Match> matches = new List<Match>();

            while (reader.Read())
            {
                Match matches1 = new Match();

                matches1.MatchDate = reader["matchdate"].ToString();
                matches1.Tournament = reader["tournament"].ToString();
                matches1.Region = reader["region"].ToString();
                matches1.Result = reader["result"].ToString();

                matches.Add(matches1);
            }

            MatchdataGridView.DataSource = matches;
            connection.Close();
        }
    }
}
