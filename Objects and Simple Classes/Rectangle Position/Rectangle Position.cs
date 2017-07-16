using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    class Program
    {
        public static void Main()
        {
            Rectangle firstRectangle = new Rectangle();
            Rectangle secondrectangle = new Rectangle();

            firstRectangle = ReadRectangle();
            secondrectangle = ReadRectangle();

            Console.WriteLine(firstRectangle.isInside(secondrectangle) ? "Inside" : "Not inside");

        }

        private static Rectangle ReadRectangle()
        {
            int[] rectangleParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle newRectangle = new Rectangle
            {
                left = rectangleParams[0],
                top = rectangleParams[1],
                width = rectangleParams[2],
                height = rectangleParams[3]
            };

            return newRectangle;
        }
    }

}
