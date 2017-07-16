using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Websites
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Website> websitesList = new List<Website>();

            while (!inputLine.Equals("end"))
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                websitesList.Add(websiteParse(inputParams));

                inputLine = Console.ReadLine();
            }

            foreach (var website in websitesList)
            {
                if (website.queries != null)
                {
                    Console.Write("https://www.{0}.{1}/query?=", website.host, website.domain);

                    for (int i = 0; i < website.queries.Count; i++)
                    {
                        if (i + 1 == website.queries.Count)
                        {
                            Console.Write("[{0}]", website.queries[i]);
                        }
                        else
                        {
                            Console.Write("[{0}]&", website.queries[i]);
                        }
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("https://www.{0}.{1}", website.host, website.domain);
                }
            }
        }

        private static Website websiteParse(string[] inputParams)
        {
            Website newSite = new Website();

            string currentHost = inputParams[0];
            string currentDomain = inputParams[1];

            newSite.domain = currentDomain;
            newSite.host = currentHost;

            if (inputParams.Length > 2)
            {
                List<string> queries = inputParams.Skip(2).ToList();

                newSite.queries = queries;
            }

            return newSite;
        }
    }
}
