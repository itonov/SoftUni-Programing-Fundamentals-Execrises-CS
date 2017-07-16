using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Softuni_Coffee_Orders
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string dateFormat = "d/M/yyyy";

            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(inputDate.Year, inputDate.Month);

                decimal currentPrice = ((daysInMonth * (long)capsulesCount) * pricePerCapsule);
                totalPrice += currentPrice;

                Console.WriteLine("The price for the coffee is: ${0:F2}", currentPrice);
            }

            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
