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
    public partial class SeasonUserControl : UserControl
    {
        public SeasonUserControl()
        {
            InitializeComponent();
        }

        private void UpdateRatingbutton_Click(object sender, EventArgs e)
        {
            RatingUpdate ratingUpdate = new RatingUpdate();
            ratingUpdate.Show();
        }

        private void TopRatedPlayerbutton_Click(object sender, EventArgs e)
        {
            TopRatedPlayer topRatedPlayer = new TopRatedPlayer();
            topRatedPlayer.Show();
        }
    }
}
