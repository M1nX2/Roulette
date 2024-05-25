using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    internal class Sector
    {
        public enum Color { Red, Black, Green };

        private static readonly Dictionary<Color, int[]> Colors = new Dictionary<Color, int[]>
        {
            { Color.Green, new int[] { 0 } },
            { Color.Red, new int[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 } },
            { Color.Black, new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 } }
        };

        public int Number { get; private set; }
        public Color SectorColor { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }

        public Sector(int number, int row, int column) : this(number)
        {
            Row = row;
            Column = column;
        }

        public Sector(int number) 
        {
            Number = number;
            SectorColor = DetermineColor(number);
            Row = (Number - 1) / 3 + 1;
            Column = (Number - 1)  % 3 + 1;
        }

        private Color DetermineColor(int number)
        {
            foreach (var kvp in Colors)
            {
                if (kvp.Value.Contains(number))
                {
                    return kvp.Key;
                }
            }
            throw new ArgumentException($"Invalid number {number} for a sector.");
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
