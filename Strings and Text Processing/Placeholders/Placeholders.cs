using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    public class Placeholders
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("end"))
            {
                string[] inputTokens = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string sentence = inputTokens[0].Trim();
                string[] elements = inputTokens[1].Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < elements.Length; i++)
                {
                    string currentPlaceholder = "{" + i + "}";

                    sentence = sentence.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
        }
    }
}
