using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    internal partial class LeaderBoard : Form
    {
        private Game game;

        public LeaderBoard(Game game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = game.FindTop10Players();
        }
    }
}
