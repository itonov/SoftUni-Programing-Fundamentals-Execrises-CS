using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files__Directories_and_Exeptions
{
    class Program
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("Input.txt");

            for (int i = 1; i < inputLines.Length; i += 2)
            {
                File.AppendAllText("output.txt", inputLines[i] + Environment.NewLine);
            }

        }
    }
}
