using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nether_Realms
{
    public class Program
    {
        public static void Main()
        {
            string[] demonNames = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<Demon> demons = new List<Demon>();

            Regex healthPattern = new Regex(@"[a-z]|[A-Z]");
            Regex damageNumbersPattern = new Regex(@"-?\d+\.?\d*");
            Regex damageSymbolsPattern = new Regex(@"\*|\/");

            foreach (var demon in demonNames)
            {
                int demonHealth = 0;
                MatchCollection healthMatches = healthPattern.Matches(demon);

                foreach (Match match in healthMatches)
                {
                    demonHealth += Convert.ToChar(match.Value);
                }

                double demonDamage = 0;
                MatchCollection damageNumbers = damageNumbersPattern.Matches(demon);
                MatchCollection damageSymbols = damageSymbolsPattern.Matches(demon);

                foreach (Match match in damageNumbers)
                {
                    double damageToAdd = 0;
                    double.TryParse(match.Value, out damageToAdd);
                    demonDamage += damageToAdd;
                }

                foreach (Match match in damageSymbols)
                {
                    if (match.Value.Equals("*"))
                    {
                        demonDamage *= 2;
                    }
                    else if (match.Value.Equals("/"))
                    {
                        demonDamage /= 2;
                    }
                }

                demons.Add(new Demon
                {
                    name = demon,
                    health = demonHealth,
                    damage = demonDamage
                });
            }

            demons
                .OrderBy(x => x.name)
                .ToList()
                .ForEach(demon => Console.WriteLine("{0} - {1} health, {2:F2} damage", demon.name, demon.health, demon.damage));
        }
    }
}
