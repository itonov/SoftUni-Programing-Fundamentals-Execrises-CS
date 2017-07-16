using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputLine = Console.ReadLine().ToUpper();

            List<string> neededExpressions = new List<string>();

            Regex newRegex = new Regex(@"(\D+)(\d+)");
            MatchCollection matches = newRegex.Matches(inputLine);

            foreach (Match match in matches)
            {
                neededExpressions.Add(match.Value);
            }
            
            string result = string.Empty;

            foreach (var expression in neededExpressions)
            {
                int repeats = 0;
                string neededText = string.Empty;

                for (int i = 0; i < expression.Length; i++)
                {
                    if (i + 1 == expression.Length)
                    {
                        repeats = int.Parse(expression[i].ToString());
                    }
                    else
                    {
                        neededText += expression[i];
                    }
                }

                for (int i = 0; i < repeats; i++)
                {
                    result += neededText;
                }
            }
            
            int uniqueLettersCount = result
                .ToCharArray()
                .Distinct()
                .Count();
            
            Console.WriteLine("Unique symbols used: {0}", uniqueLettersCount);
            Console.WriteLine(result);
        }
    }
}
