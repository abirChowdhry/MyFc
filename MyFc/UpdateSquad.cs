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
    public partial class UpdateSquad : Form
    {
        public UpdateSquad()
        {
            InitializeComponent();
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
                UpdatePlayerpictureBox.Image = GetPhoto((byte[])reader["photo"]);
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
                NametextBox.Text = DateOfBirthdateTimePicker.Text = HeighttextBox.Text = PreferredFootcomboBox.Text = WagetextBox.Text = CurrencycomboBox1.Text = PricetextBox.Text = CurrencycomboBox2.Text = PositioncomboBox.Text = "";
                MessageBox.Show("Player Not Found!", "ERROR");
            }

            connection.Close();
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Minimisebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximisebutton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

            else this.WindowState = FormWindowState.Maximized;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
          this.Hide();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "") { MessageBox.Show("Name isn't Given!", "ERROR"); }
            else if (DateOfBirthdateTimePicker.Checked == false) { MessageBox.Show("Date of Birth isn't Given!", "ERROR"); }
            else if (HeighttextBox.Text == "") { MessageBox.Show("Height isn't Given!", "ERROR"); }
            else if (PositioncomboBox.Text == "") { MessageBox.Show("Position Must Be Selected!", "ERROR"); }
            else if (PreferredFootcomboBox.Text == "") { MessageBox.Show("Preferred Foot Must Be Seleted!", "ERROR"); }
            else if (WagetextBox.Text == "") { MessageBox.Show("Wage isn't Given!", "ERROR"); }
            else if (WagetextBox.Text == "") { MessageBox.Show("Weekly Wage isn't Given!", "ERROR"); }
            else if (CurrencycomboBox1.Text == "") { MessageBox.Show("Weekly Wage Currency Must Be Seleted!", "ERROR"); }
            else if (PricetextBox.Text == "") { MessageBox.Show("Price isn't Given!", "ERROR"); }
            else if (CurrencycomboBox2.Text == "") { MessageBox.Show("Price Currency Must Be Seleted!", "ERROR"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Update players set name = @name, dateOfBirth = @dateOfBirth, photo = @photo, height = @height, foot = @foot, wage = @wage, wageCurrency = @wageCurrency, price = @price, priceCurrency = @priceCurrency, position = @position where playerId = '" + PlayerIdtextBox.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("photo", ConvertImageToByte(UpdatePlayerpictureBox.Image));
                command.Parameters.AddWithValue("dateOfBirth", DateOfBirthdateTimePicker.Text);
                command.Parameters.AddWithValue("name", NametextBox.Text);
                command.Parameters.AddWithValue("height", HeighttextBox.Text);
                command.Parameters.AddWithValue("foot", PreferredFootcomboBox.Text);
                command.Parameters.AddWithValue("wage", WagetextBox.Text);
                command.Parameters.AddWithValue("wageCurrency", CurrencycomboBox1.Text);
                command.Parameters.AddWithValue("price", PricetextBox.Text);
                command.Parameters.AddWithValue("priceCurrency", CurrencycomboBox2.Text);
                command.Parameters.AddWithValue("position", PositioncomboBox.Text);

                int flag = command.ExecuteNonQuery();
                connection.Close();

                SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection1.Open();

                string sql1 = "Update active set name = @name, dateOfBirth = @dateOfBirth, photo = @photo, height = @height, foot = @foot, wage = @wage, wageCurrency = @wageCurrency, price = @price, priceCurrency = @priceCurrency, position = @position where playerId = '" + PlayerIdtextBox.Text + "'";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                command1.Parameters.AddWithValue("photo", ConvertImageToByte(UpdatePlayerpictureBox.Image));
                command1.Parameters.AddWithValue("dateOfBirth", DateOfBirthdateTimePicker.Text);
                command1.Parameters.AddWithValue("name", NametextBox.Text);
                command1.Parameters.AddWithValue("height", HeighttextBox.Text);
                command1.Parameters.AddWithValue("foot", PreferredFootcomboBox.Text);
                command1.Parameters.AddWithValue("wage", WagetextBox.Text);
                command1.Parameters.AddWithValue("wageCurrency", CurrencycomboBox1.Text);
                command1.Parameters.AddWithValue("price", PricetextBox.Text);
                command1.Parameters.AddWithValue("priceCurrency", CurrencycomboBox2.Text);
                command1.Parameters.AddWithValue("position", PositioncomboBox.Text);

                int flag1 = command1.ExecuteNonQuery();
                connection1.Close();

                if (flag == 0 && flag1 == 0)
                {
                    MessageBox.Show("Player Not Updated!", "ERROR");
                }

                else
                {
                    MessageBox.Show("Player Updated", "SUCCESSFUL");
                    this.Hide();
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

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Photo";
            openFileDialog.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string piclocation = openFileDialog.FileName.ToString();
                UpdatePlayerpictureBox.ImageLocation = piclocation;
            }
        }
    }
}
