using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    internal class Player
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public List<Bet> Bets { get; private set; } = new List<Bet>();

        public Player(string name, double balance = 500) 
        {
            Name = name;
            Balance = balance;
        }

        public string CreateBet(BetType type, double betValue, List<Sector> sectors)
        {
            if(Balance < betValue) { return "Ошибка, ваш баланс меньше размера ставки."; }
            else 
            {
                Bet bet = new Bet(this, type, betValue, sectors);
                Balance  -= betValue;
                Bets.Add(bet);
                return "Ставка \""+type+"\" на сумму " + betValue + " успешно создана.";
            }
        }

        private void IncreaseBalance (double winSum) 
        {
            Balance += winSum;
        }

        private double GetWinSum(Sector winSector)
        {
            double winSum = 0;

            foreach (Bet bet in Bets)
            {
                winSum += bet.GetWinValue(winSector);
            }

            return winSum;
        }

        public double PlayRound (Sector winSector) 
        {
            double winSum = GetWinSum (winSector);

            Bets.Clear();
            IncreaseBalance(winSum);

            return winSum;
        }
    }
}
