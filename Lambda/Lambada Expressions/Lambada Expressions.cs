using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Contains("lambada"))
            {
                string[] inputTokens = inputLine.Split(new[] { '=', '>', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if(inputTokens.Length > 1)
                {
                    string selector = inputTokens[0];
                    string selectorObject = inputTokens[1];
                    string property = inputTokens[2];

                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions.Add(selector, new Dictionary<string, string>());
                    }

                    lambadaExpressions[selector][selectorObject] = property;
                }
                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selectorObject.Key, selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                inputLine = Console.ReadLine();
            }

            lambadaExpressions
                .ToList()
                .ForEach(selector => selector.Value
                .ToList()
                .ForEach(selectorObject => Console.WriteLine("{0} => {1}.{2}", selector.Key, selectorObject.Key, selectorObject.Value)));

            //foreach(var kvp in lambadaExpressions)
            //{
            //    Dictionary<string, string> objectPropertyPair = kvp.Value;

            //    foreach(var pair in objectPropertyPair)
            //    {
            //        Console.WriteLine("{0} => {1}.{2}", kvp.Key, pair.Key, pair.Value);
            //    }
            //}
        }
    }
}
