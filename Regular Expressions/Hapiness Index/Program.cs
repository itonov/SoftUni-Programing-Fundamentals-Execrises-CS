using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hapiness_Index
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Regex happyPattern = new Regex(@"\:\)|\:D|\;\)|\:\*|\:\]|\;\]|\:\}|\;\}|\(\:|\*\:|c\:|\[\:|\[\;");
            Regex sadPattern = new Regex(@"\:\(|D\:|\;\(|\:\[|\;\[|\:\{|\;\{|\)\:|\:c|\]\:|\]\;");

            int happyMatches = happyPattern.Matches(inputLine).Count;
            int sadMatches = sadPattern.Matches(inputLine).Count;

            double happinessIndex = happyMatches / (double)sadMatches;

            string emotionFace = string.Empty;

            if (happinessIndex >= 2)
            {
                emotionFace = ":D";
            }
            else if (happinessIndex > 1)
            {
                emotionFace = ":)";
            }
            else if (happinessIndex == 1)
            {
                emotionFace = ":|";
            }
            else if (happinessIndex < 1)
            {
                emotionFace = ":(";
            }

            Console.WriteLine("Happiness index: {0:F2} {1}", happinessIndex, emotionFace);
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happyMatches, sadMatches);

        }
    }
}
