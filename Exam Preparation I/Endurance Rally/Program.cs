using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    public class Program
    {
        public static void Main()
        {
            string[] drivers = Console.ReadLine().Split(' ');
            double[] trackZones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpointIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver[0];

                for (int i = 0; i < trackZones.Length; i++)
                {
                    if (checkpointIndexes.Contains(i))
                    {
                        fuel += trackZones[i];
                    }
                    else
                    {
                        fuel -= trackZones[i];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine("{0} - reached {1}", driver, i);
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", driver, fuel);
                }
            }
        }
    }
}
