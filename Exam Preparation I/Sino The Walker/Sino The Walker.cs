using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sino_The_Walker
{
    public class Program
    {
        public static void Main()
        {
            string timeFormat = @"hh\:mm\:ss";
            TimeSpan start = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);

            int steps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());

            int secondsInADay = 60 * 60 * 24;
            int totalNeededSeconds = (int)(((double)steps * secondsPerStep) % secondsInADay);

            TimeSpan end = start.Add(new TimeSpan(0, 0, totalNeededSeconds));

            Console.WriteLine("Time Arrival: " + end.ToString(timeFormat));

        }
    }
}
