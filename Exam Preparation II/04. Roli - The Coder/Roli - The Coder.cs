using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli___The_Coder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<int, Dictionary<string, HashSet<string>>> eventParticipants = new Dictionary<int, Dictionary<string, HashSet<string>>>();

            while (!inputLine.Equals("Time for Code"))
            {
                string[] inputTokens = inputLine.Split();
                int eventTag = int.Parse(inputTokens[0]);
                string eventName = inputTokens[1];
                HashSet<string> participants = new HashSet<string>();

                foreach (var token in inputTokens.Skip(2))
                {
                    participants.Add(token);
                }

                if (eventName[0].Equals('#'))
                {
                    string nameOfEvent = eventName.Remove(0, 1);

                    if (!eventParticipants.ContainsKey(eventTag))
                    {
                        eventParticipants.Add(eventTag, new Dictionary<string, HashSet<string>>());
                        eventParticipants[eventTag].Add(eventName, participants);
                    }
                    else if (eventParticipants[eventTag].ContainsKey(eventName))
                    {
                        foreach (var participant in participants)
                        {
                            eventParticipants[eventTag][eventName].Add(participant);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            Dictionary<string, HashSet<string>> result = new Dictionary<string, HashSet<string>>();

            foreach (var kvp in eventParticipants)
            {
                Dictionary<string, HashSet<string>> values = kvp.Value;

                foreach (var entry in values)
                {
                    result.Add(entry.Key.Remove(0, 1), entry.Value);
                }
            }

            result = result
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in result)
            {
                string name = kvp.Key;
                HashSet<string> participants = kvp.Value;
                var sortedParticipants = participants.OrderBy(x => x);

                Console.WriteLine("{0} - {1}", name, participants.Count);
                Console.WriteLine(string.Join(Environment.NewLine, sortedParticipants));

            }
        }
    }
}
