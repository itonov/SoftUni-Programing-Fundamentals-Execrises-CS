using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();

            List<string> words = new List<string>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("end"))
            {
                Regex pattern = new Regex(@"\W+");
                string[] sentenceWords = pattern.Split(inputLine).Where(s => s != string.Empty).ToArray();

                char[] firstWordParts = sentenceWords[0].ToCharArray();
                bool validFirstWord = firstWordParts[0] == char.ToUpper(firstWordParts[0]);
                bool validSentenceEnd = inputLine[inputLine.Length - 1].Equals('!') || inputLine[inputLine.Length - 1].Equals('.') || inputLine[inputLine.Length - 1].Equals('?');
                bool validSentence = validFirstWord && validSentenceEnd;

                if (validSentence)
                {
                    char filterLetter = filter[0];
                    int filterLetterCount = (int)Char.GetNumericValue(filter[1]);

                    foreach (var word in sentenceWords)
                    {
                        int lettersCount = 0;

                        foreach (var letter in word)
                        {
                            if (letter.Equals(filterLetter))
                            {
                                lettersCount++;
                            }
                        }

                        if (lettersCount == filterLetterCount)
                        {
                            words.Add(word);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
