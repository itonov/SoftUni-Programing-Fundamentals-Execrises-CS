using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
