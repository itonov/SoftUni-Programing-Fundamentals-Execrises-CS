using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            Point[] closestTwoPoints = FindClosestTwoPoints(points);
            double minDistance = Distance(closestTwoPoints[0], closestTwoPoints[1]);
            
            Console.WriteLine("{0:F3}", minDistance);
            Console.WriteLine("(" + closestTwoPoints[0].X + ", " + closestTwoPoints[0].Y + ")");
            Console.WriteLine("(" + closestTwoPoints[1].X + ", " + closestTwoPoints[1].Y + ")");
        }

        public static Point ReadPoint()
        {
            int[] pointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }

        public static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    var currentPoint = points[p1];
                    var nextPoint = points[p2];

                    if (Distance(currentPoint, nextPoint) < minDistance)
                    {
                        closestPoints = new Point[] {
                            points[p1], points[p2] };

                        minDistance = Distance(currentPoint, nextPoint);
                    }
                }
            }

            return closestPoints;
        }

        public static double Distance(Point first, Point second)
        {
            double firstSecondX = Math.Pow(first.X - second.X, 2);
            double firstSecondY = Math.Pow(first.Y - second.Y, 2);

            double distance = Math.Sqrt(firstSecondX + firstSecondY);
            return distance;
        }
    }
}
