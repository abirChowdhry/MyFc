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
    public partial class CentralUserControl : UserControl
    {
        public CentralUserControl()
        {
            InitializeComponent();
        }

        private void MatchSchedulebutton_Click(object sender, EventArgs e)
        {
            MatchSchedule matchSchedule = new MatchSchedule();
            matchSchedule.Show();
        }

        private void UpdateRatingbutton_Click(object sender, EventArgs e)
        {
            PlayerRating playerRating = new PlayerRating();
            playerRating.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eleven eleven = new Eleven();
            eleven.Show();
        }

        private void CentralUserControl_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM matches";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Match> matches = new List<Match>();

            while (reader.Read())
            {
                string result = reader["result"].ToString();
                if (result != "")
                {
                    Match matches1 = new Match();

                    matches1.MatchDate = reader["matchdate"].ToString();
                    matches1.Tournament = reader["tournament"].ToString();
                    matches1.Region = reader["region"].ToString();
                    matches1.Result = reader["result"].ToString();


                    matches.Add(matches1);
                }
            }

            MatchHistorydataGridView.DataSource = matches;
            connection.Close();
        }
    }
}
