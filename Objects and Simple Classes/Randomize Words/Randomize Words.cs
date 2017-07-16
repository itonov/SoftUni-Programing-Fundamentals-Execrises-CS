using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        public static void Main()
        {
            string[] inputWords = Console.ReadLine().Split();

            Random randomize = new Random();

            for (int i = 0; i < inputWords.Length; i++)
            {
                string currentWord = inputWords[i];
                int randomPosition = randomize.Next(0, inputWords.Length);

                string temp = inputWords[randomPosition];
                inputWords[randomPosition] = currentWord;
                inputWords[i] = temp;
                
            }

            Console.WriteLine(string.Join(Environment.NewLine, inputWords));
        }
    }
}
