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

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();

            string sql = "Select * from active where playerId = '" + PlayerIdtextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read()) { MessageBox.Show("Player is Already Under Exception Player List!! You Can Only Recover Him", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); connection.Close(); }

            else
            {
                SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection1.Open();

                string sql1 = "Select * from active where playerId = '" + PlayerIdtextBox.Text + "'";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                SqlDataReader reader1 = command1.ExecuteReader();

                if (reader1.Read())
                {
                    NametextBox.Text = reader1["name"].ToString();
                    DateOfBirthdateTimePicker.Text = reader1["dateOfBirth"].ToString();
                    InjuryPlayerpictureBox.Image = GetPhoto((byte[])reader1["photo"]);
                    HeighttextBox.Text = reader1["height"].ToString();
                    PreferredFootcomboBox.Text = reader1["foot"].ToString();
                    WagetextBox.Text = reader1["wage"].ToString();
                    CurrencycomboBox1.Text = reader1["wageCurrency"].ToString();
                    PricetextBox.Text = reader1["price"].ToString();
                    CurrencycomboBox2.Text = reader1["priceCurrency"].ToString();
                    PositioncomboBox.Text = reader1["position"].ToString();

                }

                else
                {
                    NametextBox.Text = PositioncomboBox.Text = "";
                    MessageBox.Show("Player Not Found!", "ERROR");
                }

                connection1.Close();
            }
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Injuredbutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "") { MessageBox.Show("Player Name Can't Be Empty", "ERROR"); }
            else if (PositioncomboBox.Text == "") { MessageBox.Show("Player Position Can't Be Empty", "ERROR"); }
            else if (EventcomboBox.Text == "") { MessageBox.Show("Event Must Be Selected", "ERROR"); }

            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();

                string sql = "Insert into Injuries(name,dateofBirth,photo,height,foot,wage,wageCurrency,price,priceCurrency,position,playerId,event) values('" + NametextBox.Text + "','" + DateOfBirthdateTimePicker.Text + "',@photo,'" + HeighttextBox.Text + "','" + PreferredFootcomboBox.Text + "','" + WagetextBox.Text + "','" + CurrencycomboBox1.Text + "','" + PricetextBox.Text + "','" + CurrencycomboBox2.Text + "','" + PositioncomboBox.Text + "','" + PlayerIdtextBox.Text + "','" + EventcomboBox.Text + "') ";
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
                    MessageBox.Show("Player Not Added To The Exception Case List!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Player Added To The Exception Case List", "SUCCESSFUL");
                    ExceptionCase exceptionCase = new ExceptionCase();
                    exceptionCase.Show();
                    this.Hide();
                }

                connection2.Close();
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

