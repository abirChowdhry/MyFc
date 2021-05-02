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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Startup startup = new Startup();
            startup.Show();
            this.Hide();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            if (SignupUsernametextBox.Text == "") { MessageBox.Show("Usernamne Can't Be Empty!", "ERROR"); }
            else if (SignupPasstextBox.Text == "") { MessageBox.Show("Password Can't Be Empty!", "ERROR"); }
            else if (SignupConfirmPasstextBox.Text == "") { MessageBox.Show("Confirm Password Can't Be Empty!", "ERROR"); }
            else if (UserTypecomboBox.Text == "") { MessageBox.Show("User Type Must Be Selected!", "ERROR"); }
            else if (SignupConfirmPasstextBox.Text != SignupPasstextBox.Text) { MessageBox.Show("Password & Confirm Password Have to Be Same!", "ERROR"); }
            else  
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "Insert into users(username, password,usertype) values('" + SignupUsernametextBox.Text + "','" + SignupPasstextBox.Text + "','"+UserTypecomboBox.Text+"') ";
                SqlCommand command = new SqlCommand(sql, connection);
                int flag = command.ExecuteNonQuery();
                if (flag == 1)
                {
                    connection.Close();
                    MessageBox.Show("Account Created", "SUCCESSFUL");
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                else if (flag == 0)
                {
                    connection.Close();
                    MessageBox.Show("Account Not Created!", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                connection.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
