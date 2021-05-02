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
    public partial class TeamSelection : Form
    {
        public TeamSelection()
        {
            InitializeComponent();
            FillCombo();
        }

        public void FillCombo() 
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM active";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                Player1comboBox.Items.Add(name);
                Player2comboBox.Items.Add(name);
                Player3comboBox.Items.Add(name);
                Player4comboBox.Items.Add(name);
                Player5comboBox.Items.Add(name);
                Player6comboBox.Items.Add(name);
                Player7comboBox.Items.Add(name);
                Player8comboBox.Items.Add(name);
                Player9comboBox.Items.Add(name);
                Player10comboBox.Items.Add(name);
                Player11comboBox.Items.Add(name);
                Player12comboBox.Items.Add(name);
                Player13comboBox.Items.Add(name);
                Player14comboBox.Items.Add(name);
                Player15comboBox.Items.Add(name);
                Player16comboBox.Items.Add(name);
            }
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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (Player1comboBox.Text == "") { MessageBox.Show("Player 1 Not Selected!", "ERROR"); }
            else if (Player2comboBox.Text == "") { MessageBox.Show("Player 2 Not Selected!", "ERROR"); }
            else if (Player3comboBox.Text == "") { MessageBox.Show("Player 3 Not Selected!", "ERROR"); }
            else if (Player4comboBox.Text == "") { MessageBox.Show("Player 4 Not Selected!", "ERROR"); }
            else if (Player5comboBox.Text == "") { MessageBox.Show("Player 5 Not Selected!", "ERROR"); }
            else if (Player6comboBox.Text == "") { MessageBox.Show("Player 6 Not Selected!", "ERROR"); }
            else if (Player7comboBox.Text == "") { MessageBox.Show("Player 7 Not Selected!", "ERROR"); }
            else if (Player8comboBox.Text == "") { MessageBox.Show("Player 8 Not Selected!", "ERROR"); }
            else if (Player9comboBox.Text == "") { MessageBox.Show("Player 9 Not Selected!", "ERROR"); }
            else if (Player10comboBox.Text == "") { MessageBox.Show("Player 10 Not Selected!", "ERROR"); }
            else if (Player11comboBox.Text == "") { MessageBox.Show("Player 11 Not Selected!", "ERROR"); }
            else if (Player12comboBox.Text == "") { MessageBox.Show("Substitute Player 1 Not Selected!", "ERROR"); }
            else if (Player13comboBox.Text == "") { MessageBox.Show("Substitute Player 2 Not Selected!", "ERROR"); }
            else if (Player14comboBox.Text == "") { MessageBox.Show("Substitute Player 3 Not Selected!", "ERROR"); }
            else if (Player15comboBox.Text == "") { MessageBox.Show("Substitute Player 4 Not Selected!", "ERROR"); }
            else if (Player16comboBox.Text == "") { MessageBox.Show("Substitute Player 5 Not Selected!", "ERROR"); }
            //else if (Player12comboBox.Text == "" && Player13comboBox.Text == "" && Player14comboBox.Text == "" && Player15comboBox.Text == "" && Player16comboBox.Text == "") { MessageBox.Show("Any Substitute Player is Not Selected!", "ERROR"); }
            else if (PP1comboBox.Text == "") { MessageBox.Show("Player 1 Position Not Selected!", "ERROR"); }
            else if (PP2comboBox.Text == "") { MessageBox.Show("Player 2 Position Not Selected!", "ERROR"); }
            else if (PP3comboBox.Text == "") { MessageBox.Show("Player 3 Position Not Selected!", "ERROR"); }
            else if (PP4comboBox.Text == "") { MessageBox.Show("Player 4 Position Not Selected!", "ERROR"); }
            else if (PP5comboBox.Text == "") { MessageBox.Show("Player 5 Position Not Selected!", "ERROR"); }
            else if (PP6comboBox.Text == "") { MessageBox.Show("Player 6 Position Not Selected!", "ERROR"); }
            else if (PP7comboBox.Text == "") { MessageBox.Show("Player 7 Position Not Selected!", "ERROR"); }
            else if (PP8comboBox.Text == "") { MessageBox.Show("Player 8 Position Not Selected!", "ERROR"); }
            else if (PP9comboBox.Text == "") { MessageBox.Show("Player 9 Position Not Selected!", "ERROR"); }
            else if (PP10comboBox.Text == "") { MessageBox.Show("Player 10 Position Not Selected!", "ERROR"); }
            else if (PP11comboBox.Text == "") { MessageBox.Show("Player 11 Position Not Selected!", "ERROR"); }
            //else if (PP12comboBox.Text == "" && PP13comboBox.Text == "" && PP14comboBox.Text == "" && PP15comboBox.Text == "" && PP16comboBox.Text == "") { MessageBox.Show("Position of Any Substitute Player is Not Selected!", "ERROR"); }
            else if (PP12comboBox.Text == "") { MessageBox.Show("Substitute 1 Position Not Selected","ERROR"); }
            else if (PP13comboBox.Text == "") { MessageBox.Show("Substitute 2 Position Not Selected","ERROR"); }
            else if (PP14comboBox.Text == "") { MessageBox.Show("Substitute 3 Position Not Selected","ERROR"); }
            else if (PP15comboBox.Text == "") { MessageBox.Show("Substitute 4 Position Not Selected","ERROR"); }
            else if (PP16comboBox.Text == "") { MessageBox.Show("Substitute 5 Position Not Selected","ERROR"); }
            else if (PP1comboBox.Text != "Goalkeeper" && PP2comboBox.Text != "Goalkeeper" && PP3comboBox.Text != "Goalkeeper" && PP4comboBox.Text != "Goalkeeper" && PP5comboBox.Text != "Goalkeeper" && PP6comboBox.Text != "Goalkeeper" && PP7comboBox.Text != "Goalkeeper" && PP8comboBox.Text != "Goalkeeper" && PP9comboBox.Text != "Goalkeeper" && PP10comboBox.Text != "Goalkeeper" && PP11comboBox.Text != "Goalkeeper") { MessageBox.Show("One Goalkeeper Must Be Selected In The Main Team!", "ERROR"); }
            else if (MatchDatedateTimePicker.Checked == false) { MessageBox.Show("Match Date Must Be Given", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Insert into Eleven(name,position,matchdate) values('" + Player1comboBox.Text + "','" + PP1comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command = new SqlCommand(sql, connection);
                int flag = command.ExecuteNonQuery();

                string sql1 = "Insert into Eleven(name,position,matchdate) values('" + Player2comboBox.Text + "','" + PP2comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command1 = new SqlCommand(sql1, connection);
                int flag1 = command1.ExecuteNonQuery();

                string sql2 = "Insert into Eleven(name,position,matchdate) values('" + Player3comboBox.Text + "','" + PP3comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command2 = new SqlCommand(sql2, connection);
                int flag2 = command2.ExecuteNonQuery();

                string sql3 = "Insert into Eleven(name,position,matchdate) values('" + Player4comboBox.Text + "','" + PP4comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command3 = new SqlCommand(sql3, connection);
                int flag3 = command3.ExecuteNonQuery();

                string sql4 = "Insert into Eleven(name,position,matchdate) values('" + Player5comboBox.Text + "','" + PP5comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command4 = new SqlCommand(sql4, connection);
                int flag4 = command4.ExecuteNonQuery();

                string sql5 = "Insert into Eleven(name,position,matchdate) values('" + Player6comboBox.Text + "','" + PP6comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command5 = new SqlCommand(sql5, connection);
                int flag5 = command5.ExecuteNonQuery();

                string sql6 = "Insert into Eleven(name,position,matchdate) values('" + Player7comboBox.Text + "','" + PP7comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command6 = new SqlCommand(sql6, connection);
                int flag6 = command6.ExecuteNonQuery();

                string sql7 = "Insert into Eleven(name,position,matchdate) values('" + Player8comboBox.Text + "','" + PP8comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command7 = new SqlCommand(sql7, connection);
                int flag7 = command7.ExecuteNonQuery();

                string sql8 = "Insert into Eleven(name,position,matchdate) values('" + Player9comboBox.Text + "','" + PP9comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command8 = new SqlCommand(sql8, connection);
                int flag8 = command8.ExecuteNonQuery();

                string sql9 = "Insert into Eleven(name,position,matchdate) values('" + Player10comboBox.Text + "','" + PP10comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command9 = new SqlCommand(sql9, connection);
                int flag9 = command9.ExecuteNonQuery();

                string sql10 = "Insert into Eleven(name,position,matchdate) values('" + Player11comboBox.Text + "','" + PP11comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command10 = new SqlCommand(sql10, connection);
                int flag10 = command10.ExecuteNonQuery();

                string sql11 = "Insert into Eleven(name,position,matchdate) values('" + Player12comboBox.Text + "','" + PP12comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command11 = new SqlCommand(sql11, connection);
                int flag11 = command11.ExecuteNonQuery();

                string sql12 = "Insert into Eleven(name,position,matchdate) values('" + Player13comboBox.Text + "','" + PP13comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command12 = new SqlCommand(sql12, connection);
                int flag12 = command12.ExecuteNonQuery();

                string sql13 = "Insert into Eleven(name,position,matchdate) values('" + Player14comboBox.Text + "','" + PP14comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command13 = new SqlCommand(sql13, connection);
                int flag13 = command13.ExecuteNonQuery();

                string sql14 = "Insert into Eleven(name,position,matchdate) values('" + Player15comboBox.Text + "','" + PP15comboBox.Text + "','" + MatchDatedateTimePicker.Text + "') ";
                SqlCommand command14 = new SqlCommand(sql14, connection);
                int flag14 = command14.ExecuteNonQuery();

                string sql15 = "Insert into Eleven(name,position,matchdate) values('" + Player16comboBox.Text + "','" + PP16comboBox.Text + "', '"+MatchDatedateTimePicker.Text+"') ";
                SqlCommand command15 = new SqlCommand(sql15, connection);
                int flag15 = command15.ExecuteNonQuery();

                if (flag == 1 && flag1 == 1 && flag2 == 1 && flag3 == 1 && flag4 == 1 && flag5 == 1 && flag6 == 1 && flag7 == 1 && flag8 == 1 && flag9 == 1 && flag10 == 1 && flag11 == 1 && flag12 == 1 && flag13 == 1 && flag14 == 1 && flag15 == 1)
                {
                    connection.Close();
                    MessageBox.Show("Team Uploaded", "Successful");
                    Eleven eleven = new Eleven();
                    eleven.Show();
                    this.Hide();
                }
                else if (flag == 0 || flag1 == 0 || flag2 == 0 || flag3 == 0 || flag4 == 0 || flag5 == 0 || flag6 == 0 || flag7 == 0 || flag8 == 0 || flag9 == 0 || flag10 == 0 || flag11 == 0 || flag12 == 0 || flag12 == 0 || flag14 == 0 || flag15 == 0)
                {
                    connection.Close();
                    MessageBox.Show("Team Can't Be Uploaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
