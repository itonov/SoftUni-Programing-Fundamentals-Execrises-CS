using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> bankAccounts = new Dictionary<string, Dictionary<string, decimal>>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("end"))
            {
                string[] inputTokens = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string bank = inputTokens[0];
                string user = inputTokens[1];
                decimal balance = decimal.Parse(inputTokens[2]);

                if (!bankAccounts.ContainsKey(bank))
                {
                    bankAccounts.Add(bank, new Dictionary<string, decimal>());
                }

                if (!bankAccounts[bank].ContainsKey(user))
                {
                    bankAccounts[bank].Add(user, 0);
                }

                bankAccounts[bank][user] += balance;

                inputLine = Console.ReadLine();
            }

            bankAccounts
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(account => Console.WriteLine("{0} -> {1} ({2})", account.Key, account.Value, bank.Key)));
                
        }
    }
}
