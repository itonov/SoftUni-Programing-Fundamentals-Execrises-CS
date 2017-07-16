using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string reversedText = string.Empty;

            for (int i = inputLine.Length - 1; i >= 0; i--)
            {
                reversedText += inputLine[i];
            }

            Console.WriteLine(reversedText);
        }
    }
}
