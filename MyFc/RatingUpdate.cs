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
    public partial class RatingUpdate : Form
    {
        public RatingUpdate()
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

        private void RatingUpdate_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM ratings";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Rating> players = new List<Rating>();

            while (reader.Read())
            {
                Rating players1 = new Rating();

                players1.Name = reader["name"].ToString();
                players1.Image = (byte[])reader["photo"];
                //players1.Rate = Convert.ToSingle(reader["rate"]);
                players1.PreRate = Convert.ToSingle(reader["prerate"]);
                players1.UploadDate = reader["uploaddate"].ToString();
                players1.LastModified = reader["updatedate"].ToString();
                players1.Id = Convert.ToInt32(reader["playerId"]);

                players.Add(players1);
            }

            SquaddataGridView.DataSource = players;
            connection.Close();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SquaddataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM ratings";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                PlayerNametextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                PlayerIdtextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                ShowPlayerpictureBox.Image = GetPhoto((byte[])SquaddataGridView.Rows[e.RowIndex].Cells[2].Value);
                RatingtextBox.Text = SquaddataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private Image GetPhoto(byte[] value)
        {
            MemoryStream memoryStream = new MemoryStream(value);
            return Image.FromStream(memoryStream);
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM ratings where name = '" + NametextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();


            List<Rating> players = new List<Rating>();

            while (reader.Read())
            {
                Rating players1 = new Rating();

                players1.Name = reader["name"].ToString();
                players1.Image = (byte[])reader["photo"];
                players1.Rate = Convert.ToSingle(reader["prerate"]);
                players1.UploadDate = reader["uploaddate"].ToString();
                players1.LastModified = reader["updatedate"].ToString();
                players1.Id = Convert.ToInt32(reader["playerId"]);

                players.Add(players1);
            }

            SquaddataGridView.DataSource = players;
            connection.Close();
        }
    }
}
