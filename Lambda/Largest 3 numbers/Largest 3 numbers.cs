using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            numbers.OrderByDescending(x => x).Take(3).ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
