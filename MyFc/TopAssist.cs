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
    public partial class TopAssist : Form
    {
        public TopAssist()
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

        private void TopAssist_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
            connection.Open();


            string sql = "select * from eleven order by assist desc";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Assist> assists = new List<Assist>();

            while (reader.Read())
            {
                Assist assists1 = new Assist();

                assists1.Name = reader["name"].ToString();
                assists1.Position = reader["position"].ToString();
                assists1.Assists = reader["ASSIST"].ToString(); 

                assists.Add(assists1);
            }

            SquaddataGridView.DataSource = assists;
            connection.Close();
        }
    }
}
