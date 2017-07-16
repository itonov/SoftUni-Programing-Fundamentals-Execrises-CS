namespace Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                Sale inputSale = ReadSale();
                string currentTown = inputSale.town;
                decimal currentSaleValue = inputSale.price * (decimal)inputSale.quantity;

                if (!salesByTown.ContainsKey(currentTown))
                {
                    salesByTown.Add(currentTown, 0);
                }

                salesByTown[currentTown] += currentSaleValue;
            }

            foreach (var kvp in salesByTown)
            {
                Console.WriteLine("{0} -> {1:F2}", kvp.Key, kvp.Value);
            }
        }

        public static Sale ReadSale()
        {
            string[] inputParams = Console.ReadLine().Split().ToArray();

            Sale newSale = new Sale
            {
                town = inputParams[0],
                product = inputParams[1],
                price = decimal.Parse(inputParams[2]),
                quantity = double.Parse(inputParams[3])
            };

            return newSale;
        }
    }
}
