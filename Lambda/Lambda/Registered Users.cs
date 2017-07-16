using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> userDate = new Dictionary<string, DateTime>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("end"))
            {
                string[] inputParams = inputLine.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputParams[0];
                DateTime registeredDate = DateTime.ParseExact(inputParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!userDate.ContainsKey(name))
                {
                    userDate.Add(name, new DateTime());
                }

                userDate[name] = registeredDate;

                inputLine = Console.ReadLine();
            }

            Dictionary<string, DateTime> sortedNames = userDate
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach(var kvp in sortedNames)
            {
                Console.WriteLine("{0}", kvp.Key);
            }
        }
    }
}
