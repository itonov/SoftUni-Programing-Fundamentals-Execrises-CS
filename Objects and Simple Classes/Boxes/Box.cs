using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class Box
    {
        public Point upperLeft { get; set; }

        public Point upperRight { get; set; }

        public Point bottomLeft { get; set; }

        public Point bottomRight { get; set; }

        public int width
        {
            get
            {
                return (int)Point.CalculateDistance(upperLeft, upperRight);
            }
        }

        public int height
        {
            get
            {
                return (int)Point.CalculateDistance(upperLeft, bottomLeft);
            }
        }

        public static int calculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }

        public static int calculateArea(int width, int height)
        {
            return width * height;
        }
    }
}
