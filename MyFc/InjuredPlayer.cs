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
    public partial class InjuredPlayer : Form
    {
        public InjuredPlayer()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
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

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "Select * from PLAYERS where playerId = '" + PlayerIdtextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                NametextBox.Text = reader["name"].ToString();
                DateOfBirthdateTimePicker.Text = reader["dateOfBirth"].ToString();
                InjuryPlayerpictureBox.Image = GetPhoto((byte[])reader["photo"]);
                HeighttextBox.Text = reader["height"].ToString();
                PreferredFootcomboBox.Text = reader["foot"].ToString();
                WagetextBox.Text = reader["wage"].ToString();
                CurrencycomboBox1.Text = reader["wageCurrency"].ToString();
                PricetextBox.Text = reader["price"].ToString();
                CurrencycomboBox2.Text = reader["priceCurrency"].ToString();
                PositioncomboBox.Text = reader["position"].ToString();

            }

            else
            {
                NametextBox.Text = PositioncomboBox.Text = "";
                MessageBox.Show("Player Not Found!", "ERROR");
            }

            connection.Close();
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Injuredbutton_Click(object sender, EventArgs e)
        {
            if (EventcomboBox.Text == "") { MessageBox.Show("Event Must Be Selected", "ERROR"); }

            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Insert into Injuries(name,dateofBirth,photo,height,foot,wage,wageCurrency,price,priceCurrency,position,playerId,event) values('" + NametextBox.Text + "','" + DateOfBirthdateTimePicker.Text + "',@photo,'" + HeighttextBox.Text + "','" + PreferredFootcomboBox.Text + "','" + WagetextBox.Text + "','" + CurrencycomboBox1.Text + "','" + PricetextBox.Text + "','" + CurrencycomboBox2.Text + "','" + PositioncomboBox.Text + "','" + PlayerIdtextBox.Text + "','"+EventcomboBox.Text+"') ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("photo", ConvertImageToByte(InjuryPlayerpictureBox.Image));

                int flag1 = command.ExecuteNonQuery();

                connection.Close();

                SqlConnection connection2 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection2.Open();

                string sql2 = "delete from active where playerId = '" + PlayerIdtextBox.Text + "'";
                SqlCommand command2 = new SqlCommand(sql2, connection2);
                int flag = command2.ExecuteNonQuery();

                if (flag == 0 && flag1 == 0)
                {
                    MessageBox.Show("Player Not Added To Injured List!", "ERROR");
                }
                else
                {
                    MessageBox.Show("Player Added To Injured List", "SUCCESSFUL");
                }

                connection2.Close();

                SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection3.Open();

                string sql3 = "SELECT * FROM injuries";
                SqlCommand command3 = new SqlCommand(sql3, connection3);
                SqlDataReader reader = command3.ExecuteReader();

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
        }

        private byte[] ConvertImageToByte(Image reciecve)
        {
            MemoryStream memoryStream = new MemoryStream();
            reciecve.Save(memoryStream, reciecve.RawFormat);
            byte[] img = memoryStream.GetBuffer();
            memoryStream.Close();
            return img;
        }

        private void Recoveredbutton_Click(object sender, EventArgs e)
        {

        }

        private void InjuredPlayer_Load(object sender, EventArgs e)
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
    }
}
