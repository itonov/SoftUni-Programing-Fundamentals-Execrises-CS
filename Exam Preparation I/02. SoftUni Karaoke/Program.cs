using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    public class Program
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string inputSongs = Console.ReadLine();
            string[] songs = Regex.Split(inputSongs, ", ");

            Dictionary<string, List<string>> participantAward = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("dawn"))
            {
                string[] inputParams = Regex.Split(inputLine, ", ");
                string participant = inputParams[0];
                string song = inputParams[1];
                string award = inputParams[2];

                if (participants.Contains(participant))
                {
                    if (songs.Contains(song))
                    {
                        if (!participantAward.ContainsKey(participant))
                        {
                            participantAward.Add(participant, new List<string>());
                        }

                        if (!participantAward[participant].Contains(award))
                        {
                            participantAward[participant].Add(award);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            if (participantAward.Keys.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                participantAward = participantAward
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, y => y.Value);

                foreach (var kvp in participantAward)
                {
                    string name = kvp.Key;
                    List<string> awards = kvp.Value;
                    awards.Sort();

                    Console.WriteLine("{0}: {1} awards", name, awards.Count);

                    foreach (var award in awards)
                    {
                        Console.WriteLine("--" + award);
                    }
                }
            }
        }
    }
}
