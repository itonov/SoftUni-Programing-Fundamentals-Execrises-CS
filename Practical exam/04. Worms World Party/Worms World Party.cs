using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> teams = new Dictionary<string, Dictionary<string, long>>();
            List<string> registeredWorms = new List<string>();

            while (inputLine != "quit")
            {
                string[] inputTokens = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string wormName = inputTokens[0];
                string teamName = inputTokens[1];
                long score = long.Parse(inputTokens[2]);

                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new Dictionary<string, long>());
                }

                if (!registeredWorms.Contains(wormName))
                {
                    teams[teamName].Add(wormName, score);
                    registeredWorms.Add(wormName);
                }

                inputLine = Console.ReadLine();
            }

            teams = teams
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Keys.Count)
                .ToDictionary(x => x.Key, y => y.Value);

            long teamCounter = 1;

            foreach (var team in teams)
            {
                string currentTeam = team.Key;
                Dictionary<string, long> participators = team.Value;
                long totalTeamScore = 0;

                foreach (var value in participators.Values)
                {
                    totalTeamScore += value;
                }

                Console.WriteLine("{0}. Team:{1}- {2}", teamCounter, currentTeam, totalTeamScore);

                participators = participators.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

                foreach (var kvp in participators)
                {
                    Console.WriteLine("###{0}: {1}", kvp.Key, kvp.Value);
                }

                teamCounter++;
            }
        }
    }
}
