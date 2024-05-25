using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Roulette
{
    internal class BetType
    {
        public static Dictionary<int, BetType> TypesFromLength = new Dictionary<int, BetType>()
        {
            { 1, new("На число", 36) },
            { 2, new("На 2 числа", 18) },
            { 3, new("На строку", 12) },
            { 4, new("На 4 числа", 9) },
            { 5, new("На угол", 7) },
            { 6, new("На 2 строки", 6)},
        }; 

        public string Type { get; private set; }
        public double Coefficient { get; private set; }
        public Func<Sector, bool> Condition { get; private set; }

        public BetType(string type, double coefficient) 
        {
            Type = type;
            Coefficient = coefficient;
        }

        public BetType(string type, double coefficient, Func<Sector, bool> condition)
        {
            Type = type;
            Coefficient = coefficient;
            Condition = condition;
        }

        public override string ToString()
        {
            return Type;
        }
    }
}
