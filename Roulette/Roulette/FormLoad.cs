using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Roulette
{
    internal partial class FormLoad : Form
    {
        private Game game;

        public FormLoad(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void FillComboBoxSaves()
        {
            List<SaveFile> saveFiles = game.ReadSaveFiles();
            List<KeyValuePair<string, SaveFile>> items = new List<KeyValuePair<string, SaveFile>>();
            foreach (SaveFile saveFile in saveFiles)
            {
                items.Add(new KeyValuePair<string, SaveFile>(saveFile.FileName, saveFile));
            }
            comboBoxSaves.DataSource = items;
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            comboBoxSaves.DisplayMember = "Key";
            comboBoxSaves.ValueMember = "Value";
            FillComboBoxSaves();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (comboBoxSaves.SelectedItem != null)
            {
                KeyValuePair<string, SaveFile> selectedItem = (KeyValuePair<string, SaveFile>)comboBoxSaves.SelectedItem;
                SaveFile selectedSaveFile = selectedItem.Value;
                Player player = game.LoadSaveFile(selectedSaveFile);
                game.CreatePlayer(player);
                MainForm form = new MainForm(game);
                form.Show();
            }
        }

        private void comboBoxSaves_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
