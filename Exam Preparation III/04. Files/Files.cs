using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    public class Files
    {
        public static void Main(string[] args)
        {
            int numberOfFiles = int.Parse(Console.ReadLine());
            string[] files = new string[numberOfFiles];

            for (int i = 0; i < numberOfFiles; i++)
            {
                files[i] = Console.ReadLine();
            }

            string[] neededExtensionRoot = Console.ReadLine().Split();

            List<File> filesList = new List<File>();

            foreach (var file in files)
            {
                string[] fileParts = file.Split(new[] { ' ', '.', ';', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                string root = fileParts[0];
                long fileSize = long.Parse(fileParts.Last());
                fileParts = fileParts.Reverse().ToArray();
                string extention = fileParts[1];
                string fileName = fileParts[2];

                filesList.Add(new File
                {
                    root = root,
                    size = fileSize,
                    extention = extention,
                    name = fileName
                });
            }

            string neededRoot = neededExtensionRoot[2];
            string neededExtention = neededExtensionRoot[0];

            filesList = filesList
                .OrderByDescending(x => x.size)
                .ThenBy(x => x.name)
                .ToList();

            bool foundValidFile = false;

            foreach (var file in filesList)
            {
                if (file.root.Equals(neededRoot) && file.extention.Equals(neededExtention))
                {
                    foundValidFile = true;
                    Console.WriteLine($"{file.name}.{file.extention} - {file.size} KB");
                }
            }

            if (!foundValidFile)
            {
                Console.WriteLine("No");
            }
        }
    }
}
