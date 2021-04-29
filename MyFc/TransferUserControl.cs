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
    public partial class TransferUserControl : UserControl
    {
        public TransferUserControl()
        {
            InitializeComponent();
        }

        private void AddPlayerbutton_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayer = new AddPlayer();
            addPlayer.Show();
        }

        private void RemovePlayerbutton_Click(object sender, EventArgs e)
        {
            RemovePlayer removePlayer = new RemovePlayer();
            removePlayer.Show();
        }
    }
}
