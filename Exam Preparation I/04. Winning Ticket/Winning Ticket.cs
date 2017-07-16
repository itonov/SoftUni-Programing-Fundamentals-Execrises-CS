using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    public class Program
    {
        public static void Main()
        {
            const string pattern = @"([$#^@])\1{5,}";

            Regex ticketRegex = new Regex(pattern);
            
            string[] inputTickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in inputTickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                
                string leftHalf = ticket.Substring(0, ticket.Length / 2);
                string rightHalf = ticket.Substring(ticket.Length / 2);

                Match leftMatch = ticketRegex.Match(leftHalf);
                Match rightMatch = ticketRegex.Match(rightHalf);

                if (leftMatch.Success && rightMatch.Success)
                {
                    char winningSymbol = leftMatch.Value[0];
                    int shorterMatch = Math.Min(leftMatch.Length, rightMatch.Length);

                    string jackpot = string.Empty;

                    if (shorterMatch == 10)
                    {
                        jackpot = " Jackpot!";
                    }

                    Console.WriteLine("ticket \"{0}\" - {1}{2}{3}", ticket, shorterMatch, winningSymbol, jackpot);
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }

            }
            
        }
    }
}
