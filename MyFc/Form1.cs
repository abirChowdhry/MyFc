using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFc
{
    public partial class MyFc : Form
    {
        static MyFc myFc;

        public static MyFc Instance 
        {
            get 
            {
                if (myFc == null) 
                {
                    myFc = new MyFc();
                }
                return myFc;
            }
        }

        public Panel PanelContainer 
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public MyFc()
        {
            InitializeComponent();
            Sidepanel.Height = Centralbutton.Height;
            Sidepanel.Top = Centralbutton.Top;
        }

        private void MyFc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Centralbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Centralbutton.Height;
            Sidepanel.Top = Centralbutton.Top;

            if (!MyFc.Instance.PanelContainer.Controls.ContainsKey("CentralUserControl"))
            {
                CentralUserControl centralUserControl = new CentralUserControl();
                centralUserControl.Dock = DockStyle.Fill;
                MyFc.Instance.panelContainer.Controls.Add(centralUserControl);
            }
            MyFc.Instance.PanelContainer.Controls["CentralUserControl"].BringToFront();

        }

        private void Squadbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Squadbutton.Height;
            Sidepanel.Top = Squadbutton.Top;

            if (!MyFc.Instance.PanelContainer.Controls.ContainsKey("SquadUserControl"))
            {
                SquadUserControl squadUserControl = new SquadUserControl();
                squadUserControl.Dock = DockStyle.Fill;
                MyFc.Instance.panelContainer.Controls.Add(squadUserControl);
            }
            MyFc.Instance.PanelContainer.Controls["SquadUserControl"].BringToFront();
        }

        private void Transferbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Transferbutton.Height;
            Sidepanel.Top = Transferbutton.Top;

            if (!MyFc.Instance.PanelContainer.Controls.ContainsKey("TransferUserControl"))
            {
                TransferUserControl transferUserControl = new TransferUserControl();
                transferUserControl.Dock = DockStyle.Fill;
                MyFc.Instance.panelContainer.Controls.Add(transferUserControl);
            }
            MyFc.Instance.PanelContainer.Controls["TransferUserControl"].BringToFront();
        }

        private void Seasonbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Seasonbutton.Height;
            Sidepanel.Top = Seasonbutton.Top;

            if (!MyFc.Instance.PanelContainer.Controls.ContainsKey("SeasonUserControl"))
            {
                SeasonUserControl seasonUserControl = new SeasonUserControl();
                seasonUserControl.Dock = DockStyle.Fill;
                MyFc.Instance.panelContainer.Controls.Add(seasonUserControl);
            }
            MyFc.Instance.PanelContainer.Controls["SeasonUserControl"].BringToFront();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = Logoutbutton.Height;
            Sidepanel.Top = Logoutbutton.Top;
            Login login = new Login();
            login.Show();
            this.Hide();
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

        private void MyFc_Load(object sender, EventArgs e)
        {
            myFc = this;

            CentralUserControl centralUserControl = new CentralUserControl();
            centralUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(centralUserControl);
        }
    }
}
