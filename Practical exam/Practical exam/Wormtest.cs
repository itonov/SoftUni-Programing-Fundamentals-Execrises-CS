using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_exam
{
    public class Wormtest
    {
        public static void Main(string[] args)
        {
            long length = long.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());

            if (length != 0 && width != 0)
            {
                long convertedLength = length * 100;

                decimal result = ((decimal)convertedLength * 100) / width;

                if (convertedLength % width == 0)
                {
                    Console.WriteLine("{0:F2}", convertedLength * width);
                }
                else
                {
                    Console.WriteLine($"{result:F2}%");
                }
            }
            else
            {
                Console.WriteLine("0.00");
            }
        }
    }
}
