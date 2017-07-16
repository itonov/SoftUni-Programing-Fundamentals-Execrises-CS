using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> inputText = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            while (true)
            {
                string commands = Console.ReadLine();

                if (commands.Equals("end"))
                {
                    break;
                }

                string[] commandsParts = commands.Split();
                string command = commandsParts[0];

                switch (command)
                {
                    case "reverse":
                        int startingIndex = int.Parse(commandsParts[2]);
                        int moveCount = int.Parse(commandsParts[4]);

                        if (isValid(inputText, startingIndex, moveCount))
                        {
                            inputText.Reverse(startingIndex, moveCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        
                        break;
                    case "sort":
                        startingIndex = int.Parse(commandsParts[2]);
                        moveCount = int.Parse(commandsParts[4]);

                        if (isValid(inputText, startingIndex, moveCount))
                        {
                            inputText.Sort(startingIndex, moveCount, null);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        break;
                    case "rollLeft":
                        int countTimes = int.Parse(commandsParts[1]);

                        if (countTimes >= 0)
                        {
                            int rotations = countTimes % 4;
                            for (int i = 0; i < rotations; i++)
                            {
                                string first = inputText.First();
                                inputText.RemoveAt(0);
                                inputText.Add(first);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        break;
                    case "rollRight":
                        countTimes = int.Parse(commandsParts[1]);

                        if (countTimes >= 0)
                        {
                            int rotations = countTimes % 4;

                            for (int i = 0; i < rotations; i++)
                            {
                                string last = inputText.Last();
                                inputText.RemoveAt(inputText.Count - 1);
                                inputText.Insert(0, last);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        break;
                }
            }

            Console.WriteLine("[" + string.Join(", ", inputText) + "]");
        }

        private static bool isValid(List<string> inputText, int startingIndex, int moveCount)
        {
            bool result = startingIndex >= 0 && startingIndex < inputText.Count && moveCount >= 0 && startingIndex + moveCount <= inputText.Count;
            return result;
        }
    }
}
