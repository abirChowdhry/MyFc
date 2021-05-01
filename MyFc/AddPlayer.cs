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
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void Browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Photo";
            openFileDialog.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|jpeg files(*.jpeg)|*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddPlayerpictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
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

        private void Addbutton_Click(object sender, EventArgs e)
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

                string sql = "Insert into Players(name,dateofBirth,photo,height,foot,wage,wageCurrency,price,priceCurrency,position) values('" + NametextBox.Text + "','" + DateOfBirthdateTimePicker.Text + "',@photo,'" + HeighttextBox.Text + "','" + PreferredFootcomboBox.Text + "','"+WagetextBox.Text+"','"+CurrencycomboBox1.Text+"','"+PricetextBox.Text+"','"+CurrencycomboBox2.Text+"','"+PositioncomboBox.Text+"') ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("photo", ConvertImageToByte(AddPlayerpictureBox.Image));

                int flag = command.ExecuteNonQuery();
               
                connection.Close();

                SqlConnection connection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection1.Open();

                string sql1 = "Insert into Active(name,dateofBirth,photo,height,foot,wage,wageCurrency,price,priceCurrency,position) values('" + NametextBox.Text + "','" + DateOfBirthdateTimePicker.Text + "',@photo,'" + HeighttextBox.Text + "','" + PreferredFootcomboBox.Text + "','" + WagetextBox.Text + "','" + CurrencycomboBox1.Text + "','" + PricetextBox.Text + "','" + CurrencycomboBox2.Text + "','" + PositioncomboBox.Text + "') ";
                SqlCommand command1 = new SqlCommand(sql1, connection1);
                command1.Parameters.AddWithValue("photo", ConvertImageToByte(AddPlayerpictureBox.Image));

                int flag1 = command1.ExecuteNonQuery();
                if (flag == 1 && flag1 == 1)
                {
                    connection.Close();
                    MessageBox.Show("Player Added", "Successful");
                    this.Hide();
                }
                else 
                {
                    connection.Close();
                    MessageBox.Show("Player Can't Be Added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void WagetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers or Digits", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers or Digits", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
