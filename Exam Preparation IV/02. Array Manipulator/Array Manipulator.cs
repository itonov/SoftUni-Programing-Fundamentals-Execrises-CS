using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    public class Program
    {
        public static void Main()
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();

            string inputCommand = Console.ReadLine();

            while (!inputCommand.Equals("end"))
            {
                string[] commandParts = inputCommand.Split();
                string command = commandParts[0];

                switch (command)
                {
                    case "exchange":
                        int startingIndex = int.Parse(commandParts[1]);
                        if (startingIndex >= 0 && startingIndex < numbers.Count)
                        {
                            int tempIndex = 0; 
                            for (int i = startingIndex + 1; i < numbers.Count; i++)
                            {
                                long temp = numbers[i];
                                numbers.RemoveAt(i);
                                numbers.Insert(tempIndex, temp);
                                tempIndex++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        string type = commandParts[1];

                        switch (type)
                        {
                            case "even":
                                bool foundEvenElement = false;
                                long maxEvenNumber = 0;
                                int maxEvenNumberIndex = 0;

                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    long currentNumber = numbers[i];

                                    if (currentNumber > maxEvenNumber && currentNumber % 2 == 0)
                                    {
                                        maxEvenNumber = currentNumber;
                                        maxEvenNumberIndex = i;
                                        foundEvenElement = true;
                                    }
                                }

                                if (!foundEvenElement)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else
                                {
                                    Console.WriteLine(maxEvenNumberIndex);
                                }

                                break;
                            case "odd":
                                bool foundOddElement = false;
                                long maxOddNumber = 0;
                                int maxOddNumberIndex = 0;

                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    long currentNumber = numbers[i];

                                    if (currentNumber > maxOddNumber && currentNumber % 2 == 1)
                                    {
                                        maxOddNumber = currentNumber;
                                        maxOddNumberIndex = i;
                                        foundOddElement = true;
                                    }
                                }

                                if (!foundOddElement)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else
                                {
                                    Console.WriteLine(maxOddNumberIndex);
                                }

                                break;
                        }
                        break;
                    case "min":
                        type = commandParts[1];

                        switch (type)
                        {
                            case "even":
                                bool foundEvenElement = false;
                                long minEvenNumber = long.MaxValue;
                                int minEvenNumberIndex = 0;

                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    long currentNumber = numbers[i];

                                    if (currentNumber < minEvenNumber && currentNumber % 2 == 0)
                                    {
                                        minEvenNumber = currentNumber;
                                        minEvenNumberIndex = i;
                                        foundEvenElement = true;
                                    }
                                }

                                if (!foundEvenElement)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else
                                {
                                    Console.WriteLine(minEvenNumberIndex);
                                }

                                break;
                            case "odd":
                                bool foundOddElement = false;
                                long minOddNumber = long.MaxValue;
                                int minOddNumberIndex = 0;

                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    long currentNumber = numbers[i];

                                    if (currentNumber < minOddNumber && currentNumber % 2 == 1)
                                    {
                                        minOddNumber = currentNumber;
                                        minOddNumberIndex = i;
                                        foundOddElement = true;
                                    }
                                }

                                if (!foundOddElement)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else
                                {
                                    Console.WriteLine(minOddNumberIndex);
                                }

                                break;
                        }
                        break;
                    case "first":
                        int countElements = int.Parse(commandParts[1]);
                        type = commandParts[2];

                        switch (type)
                        {
                            case "even":
                                if (countElements > numbers.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    List<long> neededEvenNums = new List<long>();
                                    int addedNumbersCount = 0;

                                    for (int i = 0; i < numbers.Count; i++)
                                    {
                                        if (countElements == addedNumbersCount)
                                        {
                                            break;
                                        }

                                        if (numbers[i] % 2 == 0)
                                        {
                                            neededEvenNums.Add(numbers[i]);
                                            addedNumbersCount++;
                                        }
                                    }

                                    if (neededEvenNums.Any())
                                    {
                                        Console.WriteLine("[" + string.Join(", ", neededEvenNums) + "]");
                                    }
                                    else
                                    {
                                        Console.WriteLine("[]");
                                    }
                                }
                                break;
                            case "odd":
                                if (countElements > numbers.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    List<long> neededOddNums = new List<long>();
                                    int addedNumbersCount = 0;

                                    for (int i = 0; i < numbers.Count; i++)
                                    {
                                        if (countElements == addedNumbersCount)
                                        {
                                            break;
                                        }

                                        if (numbers[i] % 2 == 1)
                                        {
                                            neededOddNums.Add(numbers[i]);
                                            addedNumbersCount++;
                                        }
                                    }

                                    if (neededOddNums.Any())
                                    {
                                        Console.WriteLine("[" + string.Join(", ", neededOddNums) + "]");
                                    }
                                    else
                                    {
                                        Console.WriteLine("[]");
                                    }
                                }
                                break;
                        }
                        break;
                    case "last":
                        countElements = int.Parse(commandParts[1]);
                        type = commandParts[2];

                        switch (type)
                        {
                            case "even":
                                if (countElements > numbers.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    numbers.Reverse();
                                    List<long> neededEvenNums = new List<long>();
                                    int addedNumbersCount = 0;

                                    for (int i = 0; i < numbers.Count; i++)
                                    {
                                        if (countElements == addedNumbersCount)
                                        {
                                            break;
                                        }

                                        if (numbers[i] % 2 == 0)
                                        {
                                            neededEvenNums.Add(numbers[i]);
                                            addedNumbersCount++;
                                        }
                                    }

                                    neededEvenNums.Reverse();
                                    numbers.Reverse();

                                    if (neededEvenNums.Any())
                                    {
                                        Console.WriteLine("[" + string.Join(", ", neededEvenNums) + "]");
                                    }
                                    else
                                    {
                                        Console.WriteLine("[]");
                                    }
                                }
                                break;
                            case "odd":
                                if (countElements > numbers.Count)
                                {
                                    Console.WriteLine("Invalid count");
                                }
                                else
                                {
                                    if (countElements > numbers.Count)
                                    {
                                        Console.WriteLine("Invalid count");
                                    }
                                    else
                                    {
                                        numbers.Reverse();
                                        List<long> neededOddNums = new List<long>();
                                        int addedNumbersCount = 0;

                                        for (int i = 0; i < numbers.Count; i++)
                                        {
                                            if (countElements == addedNumbersCount)
                                            {
                                                break;
                                            }

                                            if (numbers[i] % 2 == 1)
                                            {
                                                neededOddNums.Add(numbers[i]);
                                                addedNumbersCount++;
                                            }
                                        }

                                        neededOddNums.Reverse();
                                        numbers.Reverse();

                                        if (neededOddNums.Any())
                                        {
                                            Console.WriteLine("[" + string.Join(", ", neededOddNums) + "]");
                                        }
                                        else
                                        {
                                            Console.WriteLine("[]");
                                        }
                                    }
                                }
                                break;
                        }
                        break;
                }
                
                inputCommand = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}