using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fish_Statistics
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Regex regex = new Regex(@"(>+)?<(\(+)(['-x])>");

            List<Fish> fishes = new List<Fish>();

            MatchCollection matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                string status = string.Empty;

                switch (match.Groups[3].Value)
                {
                    case "'":
                        status = "Awake";
                        break;
                    case "-":
                        status = "Asleep";
                        break;
                    case "x":
                        status = "Dead";
                        break;
                }
                fishes.Add(new Fish
                {
                    tailLength = match.Groups[1].Length,
                    bodyLength = match.Groups[2].Length,
                    status = status,
                });
            }

            int fishCount = 1;

            if (fishes.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                for (int i = 0; i < fishes.Count; i++)
                {
                    string tailType = checkTail(fishes[i]);
                    string bodyType = checkBody(fishes[i]);
                    string status = fishes[i].status;

                    int tailSize = fishes[i].tailLength * 2;
                    int bodySize = fishes[i].bodyLength * 2;

                    Console.WriteLine("Fish {0}: {1}", fishCount, matches[i]);
                    if (tailType.Equals("None"))
                    {
                        Console.WriteLine("  Tail type: {0}", tailType);
                    }
                    else
                    {
                        Console.WriteLine("  Tail type: {0} ({1} cm)", tailType, tailSize);
                    }
                    Console.WriteLine("  Body type: {0} ({1} cm)", bodyType, bodySize);
                    Console.WriteLine("  Status: {0}", status);
                    fishCount++;
                }
            }
        }

        private static string checkBody(Fish fish)
        {
            string bodyType = string.Empty;

            if (fish.bodyLength > 10)
            {
                bodyType = "Long";
            }
            else if (fish.bodyLength > 5)
            {
                bodyType = "Medium";
            }
            else
            {
                bodyType = "Short";
            }

            return bodyType;
        }

        private static string checkTail(Fish fish)
        {
            string lengthOfTail = string.Empty;
            if (fish.tailLength > 5)
            {
                lengthOfTail = "Long";
            }
            else if (fish.tailLength > 1)
            {
                lengthOfTail = "Medium";
            }
            else if (fish.tailLength == 1)
            {
                lengthOfTail = "Short";
            }
            else
            {
                lengthOfTail = "None";
            }

            return lengthOfTail;
        }
    }
}
