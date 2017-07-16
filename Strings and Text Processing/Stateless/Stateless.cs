using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            string state = Console.ReadLine();
            string fiction = string.Empty;

            if (!state.Equals("collapse"))
            {
                fiction = Console.ReadLine();
            }

            while (!state.Equals("collapse"))
            {
                while (fiction.Length > 0)
                {
                    if (state.Contains(fiction))
                    {
                        state = state.Replace(fiction, string.Empty);
                    }

                    List<char> fictionElements = fiction.ToList();
                    fictionElements = fictionElements.Skip(1).Reverse().Skip(1).Reverse().ToList();
                    fiction = string.Empty;

                    foreach (var element in fictionElements)
                    {
                        fiction += element;
                    }
                }

                if (state.Length == 0)
                {
                    Console.WriteLine("(void)");
                }
                else
                {
                    Console.WriteLine(state.Trim());
                }
                
                state = Console.ReadLine();

                if (!state.Equals("collapse"))
                {
                    fiction = Console.ReadLine();
                }
            }
        }
    }
}
