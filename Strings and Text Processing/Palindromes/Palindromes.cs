using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            string[] inputWords = Console.ReadLine().Split(new[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (var word in inputWords)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                if (word.Equals(reversedWord))
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();
            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
