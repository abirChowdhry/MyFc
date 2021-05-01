using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFc
{
    public partial class RecoverPlayer : Form
    {
        public RecoverPlayer()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            ExceptionCase exceptionCase = new ExceptionCase();
            exceptionCase.Show();
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

        private void RecoverPlayer_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM injuries";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Injured> injury = new List<Injured>();

            while (reader.Read())
            {
                Injured injury1 = new Injured();

                injury1.Name = reader["name"].ToString();
                injury1.Image = (byte[])reader["photo"];
                injury1.Position = reader["position"].ToString();
                injury1.Id = Convert.ToInt32(reader["playerId"]);
                injury1.Event = reader["event"].ToString();

                injury.Add(injury1);
            }
            SquaddataGridView.DataSource = injury;
            connection.Close();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM injuries where name = '" + NametextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Injured> players = new List<Injured>();

            while (reader.Read())
            {
                Injured players1 = new Injured();

                players1.Name = reader["name"].ToString();
                players1.Image = (byte[])reader["photo"];
                players1.Position = reader["position"].ToString();
                players1.Id = Convert.ToInt32(reader["playerId"]);

                players.Add(players1);
            }

            SquaddataGridView.DataSource = players;

            connection.Close();
        }

        private void SquaddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Injuries";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                PlayerNametextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                InjuryPlayerpictureBox.Image = GetPhoto((byte[])SquaddataGridView.Rows[e.RowIndex].Cells[1].Value);
                PositioncomboBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                PlayerIdtextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                EventcomboBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

            connection.Close();

            SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection1.Open();
            string sql1 = "select * from injuries where playerid = '" + PlayerIdtextBox.Text + "'";
            SqlCommand command1 = new SqlCommand(sql1,connection1);
            SqlDataReader reader1 = command1.ExecuteReader();

            if (reader1.Read()) 
            {
                DateOfBirthdateTimePicker.Text = reader1["dateofbirth"].ToString();
                HeighttextBox.Text = reader1["height"].ToString();
                PreferredFootcomboBox.Text = reader1["foot"].ToString();
                WagetextBox.Text = reader1["wage"].ToString();
                CurrencycomboBox1.Text = reader1["wagecurrency"].ToString();
                PricetextBox.Text = reader1["price"].ToString();
                CurrencycomboBox2.Text = reader1["pricecurrency"].ToString();
            }

            connection1.Close();
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Injuredbutton_Click(object sender, EventArgs e)
        {
            if (PlayerNametextBox.Text == "") { MessageBox.Show("Player Name Can't Be Empty", "ERROR"); }
            else if (PositioncomboBox.Text == "") { MessageBox.Show("Player Position Can't Be Empty", "ERROR"); }
            //else if (EventcomboBox.Text == "") { MessageBox.Show("Event Can't Be Empty", "ERROR"); }

            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Insert into Active(name,dateofBirth,photo,height,foot,wage,wageCurrency,price,priceCurrency,position) values('" + PlayerNametextBox.Text + "','" + DateOfBirthdateTimePicker.Text + "',@photo,'" + HeighttextBox.Text + "','" + PreferredFootcomboBox.Text + "','" + WagetextBox.Text + "','" + CurrencycomboBox1.Text + "','" + PricetextBox.Text + "','" + CurrencycomboBox2.Text + "','" + PositioncomboBox.Text + "') ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("photo", ConvertImageToByte(InjuryPlayerpictureBox.Image));

                int flag1 = command.ExecuteNonQuery();

                connection.Close();

                SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection2.Open();

                string sql2 = "delete from injuries where playerId = '" + PlayerIdtextBox.Text + "'";
                SqlCommand command2 = new SqlCommand(sql2, connection2);
                int flag = command2.ExecuteNonQuery();

                connection2.Close();

                SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection3.Open();

                string sql3 = "delete from players where playerId = '" + PlayerIdtextBox.Text + "'";
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                int flag3 = command3.ExecuteNonQuery();

                connection3.Close();

                SqlConnection connection4 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection4.Open();

                string sql4 = "Insert into Players(name,dateofBirth,photo,height,foot,wage,wageCurrency,price,priceCurrency,position) values('" + PlayerNametextBox.Text + "','" + DateOfBirthdateTimePicker.Text + "',@photo,'" + HeighttextBox.Text + "','" + PreferredFootcomboBox.Text + "','" + WagetextBox.Text + "','" + CurrencycomboBox1.Text + "','" + PricetextBox.Text + "','" + CurrencycomboBox2.Text + "','" + PositioncomboBox.Text + "') ";
                SqlCommand command4 = new SqlCommand(sql4, connection4);
                command4.Parameters.AddWithValue("photo", ConvertImageToByte(InjuryPlayerpictureBox.Image));

                int flag4 = command4.ExecuteNonQuery();
                connection4.Close();

                SqlConnection connection5 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection5.Open();

                string sql5 = "select playerid from players where name = '" + PlayerNametextBox.Text + "' and dateofBirth = '" + DateOfBirthdateTimePicker.Text + "' and height = '" + HeighttextBox.Text + "' and foot = '" + PreferredFootcomboBox.Text + "'and wage = '" + WagetextBox.Text + "'and wageCurrency = '" + CurrencycomboBox1.Text + "'and price = '" + PricetextBox.Text + "'and priceCurrency = '" + CurrencycomboBox2.Text + "'and position = '" + PositioncomboBox.Text + "'";
                SqlCommand command5 = new SqlCommand(sql5, connection5);
               // command5.Parameters.AddWithValue("photo", ConvertImageToByte(InjuryPlayerpictureBox.Image));

                SqlDataReader reader = command5.ExecuteReader();

                if (reader.Read()) { NewIDtextBox.Text = reader["playerid"].ToString(); }

                connection5.Close();

                SqlConnection connection6 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection6.Open();

                string sql6 = " Update ratings set playerid = @playerid where playerid = '"+PlayerIdtextBox.Text+"'";
                SqlCommand command6 = new SqlCommand(sql6, connection6);

                command6.Parameters.AddWithValue("playerid", NewIDtextBox.Text);

                int flag5 = command6.ExecuteNonQuery();

                connection6.Close();

                if (flag == 0 && flag1 == 0 && flag3 == 0 && flag4 == 0 && flag5 == 0)
                {
                    MessageBox.Show("Player Can't Be Moved To The Active List!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Player Moved To The Active List", "SUCCESSFUL");
                }

                
            }
        }

        private byte[] ConvertImageToByte(Image reciecve)
        {
            MemoryStream memoryStream = new MemoryStream();
            reciecve.Save(memoryStream, reciecve.RawFormat);
            byte[] img = memoryStream.GetBuffer();
            memoryStream.Close();
            return img;
        }
    }
}
