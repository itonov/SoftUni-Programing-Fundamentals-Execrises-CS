using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();
            
            while (!inputLine.Equals("end"))
            {
                string[] inputTokens = inputLine.Split(' ');

                if(inputTokens.Length == 3)
                {
                    string key = inputTokens[0];
                    string value = inputTokens[1];
                    string innerValue = inputTokens[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }

                    dictionary[key][value] = innerValue;

                }
                else
                {
                    string keyToFlatten = inputTokens[1];

                    dictionary[keyToFlatten] = dictionary[keyToFlatten]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }
                
                inputLine = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, string>> orderedDictionary = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in orderedDictionary)
            {
                Console.WriteLine("{0}", kvp.Key);

                Dictionary<string, string> orderedInnerDictionary = kvp.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string, string> flattenedValues =
                    kvp.Value
                        .Where(x => x.Value == "flattened")
                        .ToDictionary(x => x.Key, x => x.Value);

                int counter = 1;

                foreach (var keyValuePair in orderedInnerDictionary)
                {
                    Console.WriteLine("{0}. {1} - {2}", counter, keyValuePair.Key, keyValuePair.Value);
                    counter++;
                }

                foreach(var flattenedPairs in flattenedValues)
                {
                    Console.WriteLine("{0}. {1}", counter, flattenedPairs.Key);
                    counter++;
                }
            }
        }
    }
}
