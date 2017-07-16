using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_stringify
{
    public class Program
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (!inputLine.Equals("stringify"))
            {
                string[] inputTokens = inputLine.Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);
                int[] grades = inputTokens.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student
                {
                    name = name,
                    age = age,
                    grades = grades
                };

                students.Add(newStudent);

                inputLine = Console.ReadLine();
            }

            string result = "[";

            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];

                result += $"{{name:\"{currentStudent.name}\",age:{currentStudent.age},grades:[{string.Join(", ", currentStudent.grades)}]}}";

                if (i < students.Count - 1)
                {
                    result += ",";
                }
            }

            result += "]";

            Console.WriteLine(result);
        }
    }
}
