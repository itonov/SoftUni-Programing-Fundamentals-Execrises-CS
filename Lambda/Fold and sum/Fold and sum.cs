using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = inputNumbers.Length / 4;

            int[] upperRowRight = inputNumbers
                .Take(k)
                .Reverse()
                .ToArray();

            int[] upperRowLeft = inputNumbers
                .Reverse()
                .Take(k)
                .ToArray();

            int[] upperRow = upperRowRight
                .Concat(upperRowLeft)
                .ToArray();
        
            int[] lowerRow = inputNumbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            int[] sum = upperRow
                .Select((x, index) => x + lowerRow[index])
                .ToArray();

            Console.WriteLine("{0}", string.Join(" ", sum));

        }
    }
}
