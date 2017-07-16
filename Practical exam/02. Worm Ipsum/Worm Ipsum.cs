using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("Worm Ipsum"))
            {
                string[] sentences = inputLine.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (sentences.Length == 1)
                {
                    string[] wordsInSentence = sentences[0].Split();

                    for (int i = 0; i < wordsInSentence.Length; i++)
                    {
                        char[] lettersInWord = wordsInSentence[i].ToCharArray();

                        char neededChar = 'a';
                        char specialChar = 'a';

                        long mostOccurances = 0;

                        bool specialCharFound = false;
                        bool validCharFound = false;

                        for (int j = 0; j < lettersInWord.Length; j++)
                        {
                            char currentChar = lettersInWord[j];
                            long currentCharCount = 0;

                            if (char.IsLetter(currentChar))
                            {
                                foreach (var letter in lettersInWord)
                                {
                                    if (currentChar.Equals(letter))
                                    {
                                        currentCharCount++;
                                    }
                                }

                                if (currentCharCount > mostOccurances && currentCharCount >= 2)
                                {
                                    mostOccurances = currentCharCount;
                                    neededChar = currentChar;
                                    validCharFound = true;
                                }
                            }
                            else
                            {
                                specialChar = currentChar;
                                specialCharFound = true;
                            }
                        }

                        if (validCharFound && specialCharFound)
                        {
                            string wordToReplace = new string(neededChar, wordsInSentence[i].Length - 1);
                            wordsInSentence[i] = wordToReplace + specialChar;
                        }
                        else if (validCharFound)
                        {
                            string wordToReplace = new string(neededChar, wordsInSentence[i].Length);
                            wordsInSentence[i] = wordToReplace;
                        }
                    }

                    Console.WriteLine(string.Join(" ", wordsInSentence) + ".");
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}