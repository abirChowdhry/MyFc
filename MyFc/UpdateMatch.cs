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
    public partial class UpdateMatch : Form
    {
        public UpdateMatch()
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
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (MatchdateTimePicker.Checked == false) { MessageBox.Show("Date of Match Day isn't Given!", "ERROR"); }
            else if (OpponenttextBox.Text == "") { MessageBox.Show("Opponent  isn't Given!", "ERROR"); }
            else if (TournamenttextBox.Text == "") { MessageBox.Show("Tournament isn't Given!", "ERROR"); }
            else if (RegioncomboBox1.Text == "") { MessageBox.Show("Region Must Be Selected!", "ERROR"); }
            else if (ResultcomboBox1.Text == "") { MessageBox.Show("Result Must Be Seleted!", "ERROR"); }

            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);//error
                connection.Open();

                string sql = "Update Matches set MatchDate = @matchDate, Opponent = @opponent, Tournament = @tournament, Region = @region, Result=@result where matchdate = '"+MatchdateTimePicker.Text+"'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("matchDate", MatchdateTimePicker.Text);
                command.Parameters.AddWithValue("opponent", OpponenttextBox.Text);
                command.Parameters.AddWithValue("tournament", TournamenttextBox.Text);
                command.Parameters.AddWithValue("region", RegioncomboBox1.Text);
                command.Parameters.AddWithValue("result", ResultcomboBox1.Text);

                int flag = command.ExecuteNonQuery();

                if (flag == 0)
                {
                    MessageBox.Show("Match Not Updated!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }

                else
                {
                    MessageBox.Show("Match Updated", "SUCCESSFUL");
                    Application.Restart();
                    connection.Close();
                }

                /*SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection1.Open();
                string sql1 = "SELECT * FROM matches";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                SqlDataReader reader = command1.ExecuteReader();

                List<Match> matches = new List<Match>();

                while (reader.Read())
                {
                        Match matches1 = new Match();

                        matches1.MatchDate = reader["matchdate"].ToString();
                        matches1.Tournament = reader["tournament"].ToString();
                        matches1.Region = reader["region"].ToString();
                        matches1.Result = reader["result"].ToString();

                        matches.Add(matches1);
                }*/

            }
        }

        private void Searchbutton_Click_1(object sender, EventArgs e)
        {
            if (MatchdateTimePicker.Checked == false) { MessageBox.Show("Select a Match Date to Search","ERROR"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Select * from Matches where matchdate = '" + MatchdateTimePicker.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    OpponenttextBox.Text = reader["opponent"].ToString();
                    TournamenttextBox.Text = reader["tournament"].ToString();
                    RegioncomboBox1.Text = reader["region"].ToString();
                }

                else
                {
                    OpponenttextBox.Text = TournamenttextBox.Text = RegioncomboBox1.Text = " ";
                    MessageBox.Show("Match Day Not Found!", "ERROR");
                }

                connection.Close();
            }
        }
    }
}
