using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_full_name
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";

                var result = Regex.Replace(input, pattern, replace);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
