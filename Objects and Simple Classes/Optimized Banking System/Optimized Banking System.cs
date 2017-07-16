using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized_Banking_System
{
    class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<BankAccount> accountsList = new List<BankAccount>();

            while (!inputLine.Equals("end"))
            {
                accountsList.Add(newAccount(inputLine));

                inputLine = Console.ReadLine();
            }

            accountsList
                .OrderByDescending(x => x.accountBalance)
                .ThenBy(x => x.bank.Length)
                .ToList()
                .ForEach(x => Console.WriteLine("{0} -> {1} ({2})", x.accountName, x.accountBalance, x.bank));
            
        }

        public static BankAccount newAccount(string inputTokens)
        {
            string[] accountParts = inputTokens.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            return new BankAccount
            {
                bank = accountParts[0],
                accountName = accountParts[1],
                accountBalance = decimal.Parse(accountParts[2])
            };
        }
    }
}
