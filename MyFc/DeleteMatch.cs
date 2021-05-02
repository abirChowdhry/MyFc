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
    public partial class DeleteMatch : Form
    {
        public DeleteMatch()
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
            if (MatchdateTimePicker.Checked == false) { MessageBox.Show("Select a Match Date to Search"); }
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

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "delete from matches where matchdate = '" + MatchdateTimePicker.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            int flag = command.ExecuteNonQuery();


            if (flag == 0)
            {
                MessageBox.Show("Scheduled Match Not Deleted!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Scheduled Match Deleted", "SUCCESSFUL");
                this.Hide();
            }
            connection.Close();
        }
    }
}
