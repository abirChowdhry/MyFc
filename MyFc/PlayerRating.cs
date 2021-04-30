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
    public partial class PlayerRating : Form
    {
        public PlayerRating()
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

            string sql = "Select * from ratings where playerId = '" + PlayerIdtextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) { MessageBox.Show("Player is Already in the Rating List!! You Can Only Update His Rating","WARNING!",MessageBoxButtons.OK,MessageBoxIcon.Warning); connection.Close(); }

            else
            {
                SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection1.Open();

                string sql1 = "Select * from PLAYERS where playerId = '" + PlayerIdtextBox.Text + "'";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                SqlDataReader reader1 = command1.ExecuteReader();

                if (reader1.Read())
                {
                    NametextBox.Text = reader1["name"].ToString();
                    PlayerRatingpictureBox.Image = GetPhoto((byte[])reader1["photo"]);
                }

                else
                {
                    NametextBox.Text = "";
                    MessageBox.Show("Player Not Found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
        }
        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (RatingUploaddateTimePicker.Checked == false) { MessageBox.Show("Upload Date isn't Given!", "ERROR"); }
            else if (RatingtextBox.Text == "") { MessageBox.Show("Rating Must Be Given!", "ERROR"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Insert into Ratings(name,prerate,playerid,uploaddate,photo) values('" + NametextBox.Text + "','" + RatingtextBox.Text + "','"+PlayerIdtextBox.Text+"','" + RatingUploaddateTimePicker.Text + "', @photo)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("photo", ConvertImageToByte(PlayerRatingpictureBox.Image));

                int flag = command.ExecuteNonQuery();

                if (flag == 1)
                {
                    connection.Close();
                    MessageBox.Show("Rating Uploaded", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("Rating Can't Be Uploaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers or Digits","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
