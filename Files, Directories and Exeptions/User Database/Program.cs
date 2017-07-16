using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace User_Database
{
    public class Program
    {
        public static void Main()
        {
            if (!File.Exists("users.txt"))
            {
                File.Create("users.txt").Close();
            }

            string inputLine = Console.ReadLine();
            bool loggedUser = false;
            string[] readFile = File.ReadAllLines("users.txt");
            Dictionary<string, string> users = new Dictionary<string, string>();

            foreach (var line in readFile)
            {
                string[] userPassword = line.Split();
                string username = userPassword[0];
                string password = userPassword[1];

                users.Add(username, password);
            }

            while (!inputLine.Equals("exit"))
            {
                string[] inputTokens = inputLine.Split();

                switch (inputTokens[0])
                {
                    case "register":
                        string username = inputTokens[1];
                        string password = inputTokens[2];
                        string confirmPassword = inputTokens[3];

                        if (users.ContainsKey(username))
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                        else
                        {
                            if (password.Equals(confirmPassword))
                            {
                                users.Add(username, password);

                                File.AppendAllLines("users.txt", new[] { $"{username} {password}" });
                            }
                            else
                            {
                                Console.WriteLine("The two passwords must match.");
                            }
                        }

                        break;
                    case "login":
                        username = inputTokens[1];
                        password = inputTokens[2];

                        if (loggedUser)
                        {
                            Console.WriteLine("There is already a logged in user.");
                        }
                        else
                        {
                            if (!users.ContainsKey(username))
                            {
                                Console.WriteLine("There is no user with the given username.");
                            }
                            else if (!users[username].Equals(password))
                            {
                                Console.WriteLine("The password you entered is incorrect.");
                            }
                            else
                            {
                                loggedUser = true;
                            }
                        }

                        break;
                    case "logout":
                        if (loggedUser)
                        {
                            loggedUser = false;
                        }
                        else
                        {
                            Console.WriteLine("There is no currently logged in user.");
                        }
                        break;
                }

                inputLine = Console.ReadLine();
            }

        }
    }
 }
