using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("end"))
            {
                string[] inputTokens = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string key = inputTokens[0];
                string value = inputTokens[1];

                dictionary[key] = value;

                inputLine = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> changedValues = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach(var kvp in unchangedValues)
            {
                Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
            }

            foreach(var kvp in changedValues)
            {
                Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
