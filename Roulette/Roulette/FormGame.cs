using System;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Roulette
{
    internal partial class MainForm : Form
    {

        delegate void ButtonFuncDelegate(object sender, EventArgs e);
        Dictionary<Panel, ButtonFuncDelegate> panelFunctionDictionary = new Dictionary<Panel, ButtonFuncDelegate>();

        Dictionary<Button, List<Sector>> buttonSectorsDictionary = new Dictionary<Button, List<Sector>>();

        Dictionary<Button, BetType> buttonBetTypeDictionary = new Dictionary<Button, BetType>();

        private Game game;

        public MainForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }


        private void HideControl(Control control, Control newParent)
        {
            Point screenPosition = control.Parent.PointToScreen(control.Location);
            Point newLocation = newParent.PointToClient(screenPosition);

            control.Parent = newParent;
            control.Location = newLocation;

            if (control is Button button)
            {
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Transparent;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseDownBackColor = Color.Transparent;
                button.FlatAppearance.MouseOverBackColor = Color.Transparent;
                button.Text = "";
            }
            else if (control is TextBox textBox)
            {
                textBox.BackColor = Color.Transparent;
            }
            else
            {
                control.BackColor = Color.Transparent;
            }
        }

        private void HidePanelsWithButtons()
        {
            foreach (Control control in panelBetTable.Controls.OfType<Panel>().ToList())
            {
                if (control is Panel panel)
                {
                    HideControl(panel, pictureBox1);
                    foreach (Button button in panel.Controls)
                    {
                        if (panel == panelSector)
                        {
                            buttonSectorsDictionary.Add(button, FindSectorsFromButton(button));
                        }

                        if (!panelFunctionDictionary.ContainsKey(panel))
                        {
                            button.Click += new EventHandler(DefaultButtonClick);
                        }
                        else
                        {
                            button.Click += new EventHandler(panelFunctionDictionary[panel]);
                        }
                        HideControl(button, panel);
                    }
                }
            }
        }

        private void FillDics()
        {
            panelFunctionDictionary.Add(panelSector, SectorButtonClick);
            panelFunctionDictionary.Add(panelBet1, BetButtonClick);
            panelFunctionDictionary.Add(panelBet2, BetButtonClick);

            buttonBetTypeDictionary.Add(buttonEven, new("На чётное", 2, sector => sector.Number % 2 == 0));
            buttonBetTypeDictionary.Add(buttonOdd, new("На нечётное", 2, sector => sector.Number % 2 != 0));
            buttonBetTypeDictionary.Add(buttonRed, new("На красное", 2, sector => sector.SectorColor == Sector.Color.Red));
            buttonBetTypeDictionary.Add(buttonBlack, new("На чёрное", 2, sector => sector.SectorColor == Sector.Color.Black));
            buttonBetTypeDictionary.Add(button1_12, new("На первую дюжину", 3, sector => sector.Number >= 1 && sector.Number <= 12));
            buttonBetTypeDictionary.Add(button13_24, new("На вторую дюжину", 3, sector => sector.Number >= 13 && sector.Number <= 24));
            buttonBetTypeDictionary.Add(button25_36, new("На третью дюжину", 2, sector => sector.Number >= 25 && sector.Number <= 36));
            buttonBetTypeDictionary.Add(button1_18, new("На первую половину", 2, sector => sector.Number >= 1 && sector.Number <= 18));
            buttonBetTypeDictionary.Add(button19_36, new("На вторую половину", 2, sector => sector.Number >= 19 && sector.Number <= 36));
            buttonBetTypeDictionary.Add(buttonColumn1, new("На первый столбец", 3, sector => sector.Column == 1));
            buttonBetTypeDictionary.Add(buttonColumn2, new("На второй столбец", 3, sector => sector.Column == 2));
            buttonBetTypeDictionary.Add(buttonColumn3, new("На третий столбец", 3, sector => sector.Column == 3));
        }

        private List<Sector> FindSectorsFromButton(Button button)
        {
            List<int> numbers = button.Text.Split(';').Select(int.Parse).ToList();
            List<Sector> sectors = game.FilterSectors(x => numbers.Contains(x.Number));
            return sectors;
        }

        private void PlayerBalanceUpdate()
        {
            labelPlayerBalance.Text = game.Player.Balance.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = game.Player.Name;
            PlayerBalanceUpdate();

            FillDics();
            HidePanelsWithButtons();
        }

        private void BetButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;

            double value = (double)numericUpDownBetValue.Value;

            BetType betType = buttonBetTypeDictionary[button];
            List<Sector> sectors = game.FilterSectors(betType);

            MakeBet(betType, value, sectors);
        }

        private void SectorButtonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            List<Sector> sectors = buttonSectorsDictionary[button];
            BetType type = BetType.TypesFromLength[sectors.Count];
            double value = (double)numericUpDownBetValue.Value;
            MakeBet(type, value, sectors);
        }

        private void MakeBet(BetType type, double value, List<Sector> sectors)
        {
            string response = game.Player.CreateBet(type, value, sectors);
            MessageBox.Show(response);
            PlayerBalanceUpdate();
            ListBoxUpdate();
        }

        private void DefaultButtonClick(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
            MessageBox.Show("default: " + senderButton.Name);
        }

        private void buttonConfirmBets_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.StartGame());
            PlayerBalanceUpdate();
            ListBoxUpdate();
        }

        private void ListBoxUpdate()
        {
            listBox1.Items.Clear();
            foreach (Bet bet in game.Player.Bets)
            {
                string betsString = bet.Sectors.Count >= 2 ? $"{bet.Sectors.First()} - {bet.Sectors.Last()}" : $"{bet.Sectors.First()}";
                listBox1.Items.Add($"{bet.Type.ToString()}: {betsString}, размером: {bet.Value.ToString()} ");
            }

        }

        private void buttonSaveGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.Save());
        }
    }
}
