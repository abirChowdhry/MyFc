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
    public partial class TopRatedPlayer : Form
    {
        public TopRatedPlayer()
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

        private void TopRatedPlayer_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();


            string sql = "select * from ratings order by prerate desc";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<TopPlayers> players = new List<TopPlayers>();

            while (reader.Read())
            {
                TopPlayers players1 = new TopPlayers();

                players1.Name = reader["name"].ToString();
                players1.Rate = Convert.ToSingle(reader["prerate"]);
                players1.Id = Convert.ToInt32(reader["playerId"]);

                players.Add(players1);
            }

            SquaddataGridView.DataSource = players;
            connection.Close();
        }
    }
}
