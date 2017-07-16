using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_substring_occurances
{
    public class Program
    {
        public static void Main()
        {
            string inputText = Console.ReadLine().ToLower();

            string searchText = Console.ReadLine().ToLower();
            int counter = 0;
            int index = -1;

            while (true)
            { 
                index = inputText.IndexOf(searchText, index + 1);
                if (index < 0)
                {
                    break;
                }

                counter++;
            }

            Console.WriteLine(counter);

        }
    }
}