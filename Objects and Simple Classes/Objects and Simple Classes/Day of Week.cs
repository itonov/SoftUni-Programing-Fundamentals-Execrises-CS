using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Simple_Classes
{
    class Program
    {
        public static void Main()
        {
            string inputDate = Console.ReadLine();

            DateTime dateToCheck = new DateTime();

            dateToCheck = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateToCheck.DayOfWeek);
        }
    }
}
