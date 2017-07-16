using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("Input.txt");

            int lineCount = 1;

            for (int i = 0; i < inputLines.Length; i++)
            {
                File.AppendAllText("output.txt", lineCount + ". " + inputLines[i] + Environment.NewLine);
                lineCount++;
            }
        }
    }
}
