using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    public class Program
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long runnersNumber = int.Parse(Console.ReadLine());
            int averageLapsNumber = int.Parse(Console.ReadLine());
            long trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());

            double moneyPerKilometer = double.Parse(Console.ReadLine());

            long totalCapacity = trackCapacity * days;
            long totalKilometers = (Math.Min(runnersNumber, totalCapacity) * averageLapsNumber * trackLength) / 1000;

            double donation = totalKilometers * moneyPerKilometer;

            Console.WriteLine("Money raised: {0:F2}", donation);
        }
    }
}
