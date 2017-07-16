using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Boxes
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (!inputLine.Equals("end"))
            {
                string[] inputTokens = inputLine.Split(new[] { ':', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                boxes.Add(boxParse(inputTokens));

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine("Box: {0}, {1}", box.width, box.height);
                Console.WriteLine("Perimeter: " + Box.calculatePerimeter(box.width, box.height));
                Console.WriteLine("Area: " + Box.calculateArea(box.width, box.height));
            }
        }

        private static Box boxParse(string[] inputTokens)
        {
            return new Box
            {
                upperLeft = new Point
                {
                    X = int.Parse(inputTokens[0]),
                    Y = int.Parse(inputTokens[1])
                },

                upperRight = new Point
                {
                    X = int.Parse(inputTokens[2]),
                    Y = int.Parse(inputTokens[3])
                },

                bottomLeft = new Point
                {
                    X = int.Parse(inputTokens[4]),
                    Y = int.Parse(inputTokens[5])
                },

                bottomRight = new Point
                {
                    X = int.Parse(inputTokens[6]),
                    Y = int.Parse(inputTokens[7])
                }
            };
        }
    }
}
