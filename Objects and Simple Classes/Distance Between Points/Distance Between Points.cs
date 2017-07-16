using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Points
{
    public class Program
    {
        public static void Main()
        {
            int[] firstPointParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondPointParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstPoint = new Point();
            Point secondPoint = new Point();

            firstPoint.X = firstPointParams[0];
            firstPoint.Y = firstPointParams[1];

            secondPoint.X = secondPointParams[0];
            secondPoint.Y = secondPointParams[1];

            double distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine("{0:F3}", distance);

        }

        static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            return Math.Sqrt(((firstPoint.X - secondPoint.X)*(firstPoint.X - secondPoint.X))
                + ((firstPoint.Y - secondPoint.Y)* (firstPoint.Y - secondPoint.Y)));
        }
    }
}
