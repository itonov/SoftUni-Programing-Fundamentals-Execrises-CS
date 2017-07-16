using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercises
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Exercise> exercisesList = new List<Exercise>();

            while (!inputLine.Equals("go go go"))
            { 
                exercisesList.Add(newExercise(inputLine));

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in exercisesList)
            {
                Console.WriteLine("Exercises: " + exercise.topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", exercise.courseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.judgeContestLink);

                int counter = 1;

                foreach (var problem in exercise.problems)
                {
                    Console.WriteLine(counter + ". " + problem);
                    counter++;
                }
            }
        }

        public static Exercise newExercise(string inputParams)
        {
            List<string> exerciseTokens = inputParams.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Exercise newExercise = new Exercise();

            newExercise.topic = exerciseTokens[0];
            newExercise.courseName = exerciseTokens[1];
            newExercise.judgeContestLink = exerciseTokens[2];
            newExercise.problems = exerciseTokens.Skip(3).ToList();

            return newExercise;
        }
    }
}
