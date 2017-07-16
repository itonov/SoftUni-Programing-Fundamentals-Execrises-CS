using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Split
{
    public class Program
    {
        public static void Main()
        {
            string inputSentence = Console.ReadLine();

            string delimiter = Console.ReadLine();

            string[] elements = inputSentence.Split(new[] { delimiter }, StringSplitOptions.None).ToArray();

            Console.WriteLine("[{0}]", string.Join(", ", elements));
        }
    }
}
