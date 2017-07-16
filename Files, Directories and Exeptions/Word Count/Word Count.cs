using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word_Count
{
    class Program
    {
        public static void Main()
        {
            string[] wordsToCheck = File.ReadAllText("words.txt").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] textToSearch = File.ReadAllText("text.txt").Split(new[] { '\n', '\r', ' ', '!', '.', '-', ',', '?'}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordOccurances = new Dictionary<string, int>();

            for (int i = 0; i < wordsToCheck.Length; i++)
            {
                for (int j = 0; j < textToSearch.Length; j++)
                {
                    if (wordsToCheck[i] == textToSearch[j].ToLower())
                    {
                        if (!wordOccurances.ContainsKey(wordsToCheck[i]))
                        {
                            wordOccurances.Add(wordsToCheck[i], 0);
                        }

                        wordOccurances[wordsToCheck[i]] += 1;
                    }
                }
            }

            foreach (var kvp in wordOccurances.OrderByDescending(x => x.Value))
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }

        }
    }
}
