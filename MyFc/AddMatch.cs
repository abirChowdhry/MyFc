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
    public partial class AddMatch : Form
    {
        public AddMatch()
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
            MatchSchedule matchSchedule = new MatchSchedule();
            matchSchedule.Show();
            this.Hide();
        }


        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (AddMatchdateTimePicker2.Checked == false) { MessageBox.Show("Date of Match Day isn't Given!", "ERROR"); }
            else if (OpponenttextBox.Text == "") { MessageBox.Show("Opponent isn't Given!", "ERROR"); }
            else if (TournamenttextBox.Text == "") { MessageBox.Show("Tournament isn't Given!", "ERROR"); }
            else if (RegioncomboBox1.Text == "") { MessageBox.Show("Region Must Be Selected!", "ERROR"); }

            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection1.Open();

            string sql1 = "Select * from matches where matchdate = '" + AddMatchdateTimePicker2.Text + "'";
            SqlCommand command1 = new SqlCommand(sql1,connection1);
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read()) { MessageBox.Show("Already a Match Scheduled on this Date"); }

            else if(!reader.Read())
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Insert into Matches(MatchDate,Opponent,Tournament,Region) values('" + AddMatchdateTimePicker2.Text + "','" + OpponenttextBox.Text + "','" + TournamenttextBox.Text + "','" + RegioncomboBox1.Text + "')";
                SqlCommand command = new SqlCommand(sql, connection);

                int flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    MessageBox.Show("Match Scheduled", "Successful");
                    this.Hide();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Match Not Scheduled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    connection.Close();
                }
            }
        }
    }
}

