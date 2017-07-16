using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(((p1.X - p2.X) * (p1.X - p2.X)) + ((p1.Y - p2.Y) * (p1.Y - p2.Y)));
        }
    }
}
