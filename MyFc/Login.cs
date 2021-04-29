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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (UsernametextBox.Text == "") { MessageBox.Show("Username Not Given!", "ERROR"); }
            else if (PasstextBox.Text == "") { MessageBox.Show("Password Not Given!", "ERROR"); }

            else 
            {
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
                connection.Open();
                string sql = "Select * from Users where username = '" + UsernametextBox.Text + "' and password = '" + PasstextBox.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string usertype = reader["usertype"].ToString();

                    if (usertype == "Manager")
                    {
                        MyFc myFc = new MyFc();
                        myFc.Show();
                        this.Hide();
                    }
                    
                }

                else
                {
                    MessageBox.Show("Incorrect Username or Password!", "ERROR");
                }
            }
        }
    }
}
