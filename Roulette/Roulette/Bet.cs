using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    internal class Bet
    {

        public BetType Type { get; private set; }
        public double Value { get; private set; }
        public List<Sector> Sectors { get; private set; }
        public Player Player { get; private set; }

        internal Bet(Player player,BetType type, double value, List<Sector> sectors) 
        {
            Type = type;
            Value = value;
            Sectors = sectors;
            Player = player;
        }

        public double GetWinValue(Sector winSector)
        { 
            if(Sectors.Contains(winSector))
            {
                return Value * Type.Coefficient;
            }
            else 
            {
                return 0;
            }
        }



    }
}
