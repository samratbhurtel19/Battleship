using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameReviews
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'videoGameReviewsDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.videoGameReviewsDataSet.Games);

        }
    }
}
