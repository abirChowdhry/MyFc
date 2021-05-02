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
    public partial class SquadUserControl : UserControl
    {
        public SquadUserControl()
        {
            InitializeComponent();
        }

        private void WholeSquadbutton_Click(object sender, EventArgs e)
        {
            MySquad mySquad = new MySquad();
            mySquad.Show();
        }

        private void UpdateSquadbutton_Click(object sender, EventArgs e)
        {
            UpdateSquad updateSquad = new UpdateSquad();
            updateSquad.Show();
        }

        private void SquadByPositionbutton_Click(object sender, EventArgs e)
        {
            SquadByPosition squadByPosition = new SquadByPosition();
            squadByPosition.Show();
        }

        private void Injurybutton_Click(object sender, EventArgs e)
        {
            ExceptionCase exceptionCase = new ExceptionCase();
            exceptionCase.Show();
        }

        private void ActiveSquadbutton_Click(object sender, EventArgs e)
        {
            ActiveSquad activeSquad = new ActiveSquad();
            activeSquad.Show();
        }

    }
}
