using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_parse
{
    public class Program
    {
        public static void Main()
        {
            List<string> inputLine = Console.ReadLine().Split(new[] { '{', '}'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<Student> students = new List<Student>();

            for (int i = 0; i < inputLine.Count; i++)
            {
                if (inputLine[i] == "[" || inputLine[i] == "," || inputLine[i] == "]")
                {
                    inputLine.Remove(inputLine[i]);
                }
            }

            foreach (var line in inputLine)
            {
                string[] studentTokens = line.Split(new[] { ',', ':', '"', ' ', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                string name = studentTokens[1];
                int age = int.Parse(studentTokens[3]);
                int[] grades = studentTokens.Skip(5).Select(int.Parse).ToArray();

                Student newStudent = new Student
                {
                    name = name,
                    age = age,
                    grades = grades
                };

                students.Add(newStudent);
            }

            foreach (var student in students)
            {
                if (student.grades.Length > 0)
                {
                    Console.WriteLine("{0} : {1} -> {2}", student.name, student.age, string.Join(", ", student.grades));
                }
                else
                {
                    Console.WriteLine("{0} : {1} -> {2}", student.name, student.age, "None");
                }
            }
        }
    }
}
