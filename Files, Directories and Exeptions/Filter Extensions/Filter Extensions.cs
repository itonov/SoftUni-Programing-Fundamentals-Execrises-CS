using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filter_Extensions
{
    public class Program
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("input");
            List<string> neededFiles = new List<string>();

            string neededExtension = Console.ReadLine();

            foreach (var file in files)
            {
                string[] fileParts = file.Split('.');
                string fileExtension = fileParts[fileParts.Length - 1];

                if (fileExtension.Equals(neededExtension))
                {
                    neededFiles.Add(file);
                }
            }

            foreach (var file in neededFiles)
            {
                FileInfo newInfo = new FileInfo(file);
                Console.WriteLine(newInfo.Name);
            }

        }
    }
}
