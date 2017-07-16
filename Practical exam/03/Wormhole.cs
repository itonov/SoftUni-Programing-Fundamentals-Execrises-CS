using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int stepsCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                stepsCount++;

                if (numbers[i] != 0)
                {
                    int tempIndex = i - 1;
                    i = numbers[i];
                    numbers[tempIndex + 1] = 0;
                }
            }

            Console.WriteLine(stepsCount);
        }
    }
}
