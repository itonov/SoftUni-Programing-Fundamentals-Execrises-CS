using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalize_Words
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("end"))
            {
                string[] words = inputLine.Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '"', '\n', ']', '[', '{', '}', '-' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    string capitalizedWord = letters[0].ToString();

                    foreach (var letter in letters.Skip(1))
                    {
                        capitalizedWord += char.ToLower(letter);
                    }

                    words[i] = capitalizedWord;
                }

                Console.WriteLine(string.Join(", ", words));

                inputLine = Console.ReadLine();
            }
        }
    }
}
