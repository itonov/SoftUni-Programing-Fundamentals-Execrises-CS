using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        public static void Main()
        {
            string[] firstInput = File.ReadAllLines("FileOne.txt");
            string[] secondInput = File.ReadAllLines("FileTwo.txt");

            for (int i = 0; i < firstInput.Length; i++)
            {
                File.AppendAllText("output.txt", firstInput[i] + Environment.NewLine);
                File.AppendAllText("output.txt", secondInput[i] + Environment.NewLine);
            }
        }
    }
}
