using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    internal class Game
    {
        public Player Player { get; private set; }
        Dictionary<int, Sector> sectors = new Dictionary<int, Sector>();

        public Game() 
        {
            GenerateSectors();
        }

        public Player CreatePlayer(Player player)
        {
            Player = player;
            return player;
        }

        public Player CreatePlayer(string playerName, double balance = 500)
        { 
            Player player = new Player (playerName, balance);
            Player = player;
            return player;
        }

        private void GenerateSectors() 
        {
            sectors.Clear();
            sectors.Add(0, new Sector(0, 0, 0));
            for (int i = 1; i <= 36; i++) 
            {
                Sector sector = new Sector(i);
                sectors.Add(i, sector);
            }
        }

        public List<Sector> FilterSectors(Func<Sector, bool> condition)
        {
            List<Sector> result = new List<Sector>();
            foreach (var pair in sectors)
            {
                if (condition(pair.Value))
                { 
                    result.Add(pair.Value);
                }
            }
            return result;
        }

        public List<Sector> FilterSectors(BetType betType)
        {
            Func<Sector, bool> condition = betType.Condition;
            return FilterSectors(condition);
        }

        public Sector GenerateWinSector() 
        {
            Random random = new Random();
            Sector winSector = sectors[random.Next(sectors.Count)];    
            return winSector;
        }

        public string StartGame()
        {
            Sector winSector = GenerateWinSector();
            double winSum = Player.PlayRound(winSector);
            return $"Выпавший сектор: {winSector.Number} \nВаш выигрыш: {winSum}";
        }

        public string Save() 
        {
            SaveFile saveFile = FileReader.CreateSaveFile(Player);
            return "Файл успешно сохранён под названием: "+ saveFile.FileName;
        }

        public DataTable FindTop10Players()
        {
            List<SaveFile> saveFiles = FileReader.ReadSaveFiles();
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Игрок", typeof(string));
            dataTable.Columns.Add("Баланс", typeof(double));

            List<Player> players = new List<Player>();

            foreach (SaveFile saveFile in saveFiles)
            {
                Player player = FileReader.LoadSaveFile(saveFile);
                players.Add(player);
            }
            players = players.OrderByDescending(p => p.Balance).ToList();

            foreach (Player player in players.Take(10))
            {
                dataTable.Rows.Add(player.Name, player.Balance);
            }

            return dataTable;
        }

        public Player LoadSaveFile(SaveFile saveFile)
        {
            return FileReader.LoadSaveFile(saveFile);
        }

        public List<SaveFile> ReadSaveFiles() 
        {
            return FileReader.ReadSaveFiles();
        }
    }
}
