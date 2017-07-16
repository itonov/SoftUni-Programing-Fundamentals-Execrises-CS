using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    public class Ladybugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int[] field = new int[fieldSize];

            foreach (var index in initialIndexes)
            {
                if (index < 0 || index >= fieldSize)
                {
                    continue;
                }

                field[index] = 1;
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("end"))
                {
                    break;
                }

                string[] commandParts = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int startIndex = int.Parse(commandParts[0]);
                string direction = commandParts[1];
                int power = int.Parse(commandParts[2]);

                if (startIndex < 0 || startIndex >= fieldSize)
                {
                    continue;
                }

                if (field[startIndex] == 0)
                {
                    continue;
                }

                field[startIndex] = 0;
                int position = startIndex;

                while (true)
                {
                    if (direction.Equals("right"))
                    {
                        position += power;
                    }
                    else
                    {
                        position -= power;
                    }

                    if (position < 0 || position >= fieldSize)
                    {
                        break;
                    }

                    if (field[position] == 0)
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
