using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    public class Program
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guestsNumber = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            int portionSets = (guestsNumber + 5) / 6;
            decimal cashPerSet = (2 * bananasPrice) + (4 * eggsPrice) + ((decimal)0.2 * berriesPrice);

            decimal totalNeededCash = cashPerSet * portionSets;

            if (cash > totalNeededCash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", totalNeededCash);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", Math.Abs(totalNeededCash - cash));
            }

        }
    }
}
