using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_String
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            char[] letters = inputLine.Distinct().ToArray();

            foreach (var letter in letters)
            {
                List<int> indexes = new List<int>();

                for (int i = 0; i < inputLine.Length; i++)
                {
                    if (inputLine[i].Equals(letter))
                    {
                        indexes.Add(i);
                    }
                }

                Console.WriteLine("{0}:{1}", letter, string.Join("/", indexes));
            }
        }
    }
}
