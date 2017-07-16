using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HTML_Contents
{
    public class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string title = string.Empty;
            List<string> bodyParts = new List<string>();

            foreach (var line in lines)
            {
                if (line.Equals("exit"))
                {
                    break;
                }

                string[] lineParts = line.Split(' ');
                string tag = lineParts[0];
                string tagContent = lineParts[1];

                if (tag.Equals("title"))
                {
                    title = tagContent;
                }
                else
                {
                    bodyParts.Add($"<{tag}>{tagContent}</{tag}>");
                }

                StringBuilder result = new StringBuilder();

                result.Append("<!DOCTYPE html>");
                result.Append("<html>");
                result.Append("<head>");

                if (!title.Equals(string.Empty))
                {
                    result.Append($"\t<title>{title}</title>");
                }

                result.Append("</head>");
                result.Append("<body>");

                if (bodyParts.Any())
                {
                    result.Append(string.Join(Environment.NewLine, bodyParts));
                }

                result.Append("</body");
                result.Append("</html");

                File.WriteAllText("output.html", result.ToString());
            }
        }
    }
}
