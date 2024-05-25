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
    internal partial class FormRegister : Form
    {
        private Game game;

        public FormRegister(Game game)
        {
            this.game = game;
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxNamePlayer.Text != "")
            {
                string namePlayer = textBoxNamePlayer.Text;
                game.CreatePlayer(namePlayer);
                MainForm form = new MainForm(game);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя");
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            FormLoad form = new FormLoad(game);
            form.ShowDialog();
        }

        private void buttonLeaderBoard_Click(object sender, EventArgs e)
        {
            LeaderBoard form = new LeaderBoard(game);
            form.ShowDialog();
        }
    }
}
