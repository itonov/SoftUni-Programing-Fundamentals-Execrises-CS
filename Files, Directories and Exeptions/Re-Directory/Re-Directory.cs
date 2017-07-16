using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Re_Directory
{
    public class Program
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("input");

            Directory.CreateDirectory("output");

            foreach (var file in files)
            {
                string[] fileParts = file.Split(new[] { '.', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                string extension = fileParts[fileParts.Length - 1];

                string newFolder = $"{extension}s";
                string fileName = fileParts[1];

                string fileToMove = $"{fileName}.{extension}";
                string pathToMove = $"output/{newFolder}/{fileName}.{extension}";

                Directory.CreateDirectory($"output/{newFolder}");
                File.Move($"input/{fileToMove}", $"{pathToMove}");
            }
        }
    }
}
