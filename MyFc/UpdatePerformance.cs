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
    public partial class UpdatePerformance : Form
    {
        public UpdatePerformance()
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

        private void AssisttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers or Digits");
            }
        }

        private void GoaltextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers or Digits");
            }
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

        private void SquaddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Eleven";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                PlayerNametextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                PositioncomboBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                GoaltextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                AssisttextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (PlayerNametextBox.Text == "") { MessageBox.Show("Player Name Can't Be Empty", "ERROR"); }
            else if (PositioncomboBox.Text == "") { MessageBox.Show("Position Can't Be Empty", "ERROR"); }
            else if (GoaltextBox.Text == "" || AssisttextBox.Text == "") { MessageBox.Show("Goals and Assists Must Be Given To Update Performance", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();


                string sql = "Update eleven set goal = @goal, assist = @assist where name = '" + PlayerNametextBox.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);

                //command.Parameters.AddWithValue("rating", ((Convert.ToSingle(comboBox2.Text) + Convert.ToSingle(comboBox3.Text)) / 2));
                command.Parameters.AddWithValue("goal", GoaltextBox.Text);
                command.Parameters.AddWithValue("assist", AssisttextBox.Text);

                int flag = command.ExecuteNonQuery();

                if (flag == 1) { MessageBox.Show("Performance Updated", "SUCCESSFUL"); }
                else if (flag == 0) { MessageBox.Show("Performance Not Updated!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                connection.Close();

                SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection1.Open();
                string sql1 = "SELECT * FROM eleven where matchdate = '"+MatchDatedateTimePicker.Text+"'";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                SqlDataReader reader1 = command1.ExecuteReader();

                List<Team> teams = new List<Team>();

                while (reader1.Read())
                {
                    Team teams1 = new Team();

                    teams1.Name = reader1["name"].ToString();
                    teams1.Position = reader1["position"].ToString();
                    teams1.Goals = reader1["goal"].ToString();
                    teams1.Assists = reader1["assist"].ToString();

                    teams.Add(teams1);
                }

                SquaddataGridView.DataSource = teams;

                connection1.Close();
            }
        }
    }
}
