using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animals
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, Dog> dogsList = new Dictionary<string, Dog>();
            Dictionary<string, Cat> catsList = new Dictionary<string, Cat>();
            Dictionary<string, Snake> snakesList = new Dictionary<string, Snake>();

            while (!inputLine.Equals("I'm your Huckleberry"))
            {
                string[] inputTokens = inputLine.Split().ToArray();

                if (inputTokens.Length > 2)
                {
                    string animalType = inputTokens[0];
                    string name = inputTokens[1];
                    int age = int.Parse(inputTokens[2]);
                    int parameter = int.Parse(inputTokens[3]);

                    switch (animalType)
                    {
                        case "Dog":
                            Dog newDog = new Dog
                            {
                                name = name,
                                age = age,
                                numberOfLegs = parameter
                            };

                            dogsList.Add(newDog.name, newDog);

                            break;
                        case "Cat":
                            Cat newCat = new Cat
                            {
                                name = name,
                                age = age,
                                intelligenceQuotient = parameter
                            };

                            catsList.Add(newCat.name, newCat);
                            break;
                        case "Snake":
                            Snake newSnake = new Snake
                            {
                                name = name,
                                age = age,
                                crueltyCoefficient = parameter
                            };

                            snakesList.Add(newSnake.name, newSnake);
                            break;
                    }
                }
                else
                {
                    string name = inputTokens[1];

                    if (dogsList.ContainsKey(name))
                    {
                        Console.WriteLine(dogsList[name].produceSound());
                    }
                    else if (catsList.ContainsKey(name))
                    {
                        Console.WriteLine(catsList[name].produceSound());
                    }
                    else if (snakesList.ContainsKey(name))
                    {
                        Console.WriteLine(snakesList[name].produceSound());
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in dogsList)
            {
                string name = kvp.Key;
                Dog currentDog = kvp.Value;

                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}", currentDog.name, currentDog.age, currentDog.numberOfLegs);
            }

            foreach (var kvp in catsList)
            {
                string name = kvp.Key;
                Cat currentCat = kvp.Value;

                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}", currentCat.name, currentCat.age, currentCat.intelligenceQuotient);
            }

            foreach (var kvp in snakesList)
            {
                string name = kvp.Key;
                Snake currentSnake = kvp.Value;

                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}", currentSnake.name, currentSnake.age, currentSnake.crueltyCoefficient);
            }
        }
    }
}
