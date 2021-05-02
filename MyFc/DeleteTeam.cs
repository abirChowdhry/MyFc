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
    public partial class DeleteTeam : Form
    {
        public DeleteTeam()
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
            Eleven eleven = new Eleven();
            eleven.Show();
            this.Hide();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (MatchDatedateTimePicker.Checked == false) { MessageBox.Show("Match Date Must Be Given To See The Team", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "SELECT * FROM Eleven where matchdate = '" + MatchDatedateTimePicker.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Team> players = new List<Team>();

                while (reader.Read())
                {
                    Team players1 = new Team();

                    players1.Name = reader["name"].ToString();
                    players1.Position = reader["position"].ToString();
                    players1.Goals = reader["goal"].ToString();
                    players1.Assists = reader["assist"].ToString();

                    players.Add(players1);
                }

                SquaddataGridView.DataSource = players;

                connection.Close();
            }
        }


        private void Addbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection4.Open();

            string sql4 = "delete from ELEVEN where matchdate = '" + MatchDatedateTimePicker.Text + "'";
            SqlCommand command4 = new SqlCommand(sql4, connection4);
            int flag4 = command4.ExecuteNonQuery();

            if (flag4 == 0)
            {
                MessageBox.Show("Team Not Deleted!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection4.Close();
            }
            else
            {
                MessageBox.Show("Team Deleted", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection4.Close();
                this.Hide();
            }
        }
    }
}
