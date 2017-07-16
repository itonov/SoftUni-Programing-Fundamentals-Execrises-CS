using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cards
{
    public class Cards
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();
            
            Regex newRegex = new Regex("([1]?[0-9JQKA])([SHDC])");

            MatchCollection matches = newRegex.Matches(inputLine);
            List<string> cards = new List<string>();

            foreach (Match card in matches)
            {
                int power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                
                cards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
