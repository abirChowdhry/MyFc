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
    public partial class ActiveSquad : Form
    {
        public ActiveSquad()
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
            this.Hide();
        }

        private void ActiveSquad_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM active";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Players> players = new List<Players>();

            while (reader.Read())
            {
                Players players1 = new Players();

                players1.Name = reader["name"].ToString();
                players1.Dob = reader["dateofBirth"].ToString();
                players1.Image = (byte[])reader["photo"];
                players1.Height = reader["height"].ToString();
                players1.Foot = reader["foot"].ToString();
                players1.Wage = Convert.ToDouble(reader["wage"]);
                players1.WageCurrency = reader["wageCurrency"].ToString();
                players1.Price = Convert.ToDouble(reader["price"]);
                players1.PriceCurrency = reader["priceCurrency"].ToString();
                players1.Position = reader["position"].ToString();
                players1.Id = Convert.ToInt32(reader["playerId"]);

                players.Add(players1);
            }

            SquaddataGridView.DataSource = players;
            connection.Close();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (NametextBox.Text == "") { MessageBox.Show("Player Name Must Be Given to Search"); }
            else
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "SELECT * FROM active where name = '" + NametextBox.Text + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                List<Players> players = new List<Players>();

                while (reader.Read())
                {
                    Players players1 = new Players();

                    players1.Name = reader["name"].ToString();
                    players1.Dob = reader["dateofBirth"].ToString();
                    players1.Image = (byte[])reader["photo"];
                    players1.Height = reader["height"].ToString();
                    players1.Foot = reader["foot"].ToString();
                    players1.Wage = Convert.ToDouble(reader["wage"]);
                    players1.WageCurrency = reader["wageCurrency"].ToString();
                    players1.Price = Convert.ToDouble(reader["price"]);
                    players1.PriceCurrency = reader["priceCurrency"].ToString();
                    players1.Position = reader["position"].ToString();
                    players1.Id = Convert.ToInt32(reader["playerId"]);

                    players.Add(players1);
                }

                SquaddataGridView.DataSource = players;

                connection.Close();
            }
        }

        private void SquaddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Players";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                PlayerNametextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateOfBirthdateTimePicker.Text = SquaddataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ShowPlayerpictureBox.Image = GetPhoto((byte[])SquaddataGridView.Rows[e.RowIndex].Cells[2].Value);
                HeighttextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                PreferredFootcomboBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                WagetextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                CurrencycomboBox1.Text = SquaddataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                PricetextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                CurrencycomboBox2.Text = SquaddataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                PositioncomboBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                PlayerIdtextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }
    }
}
