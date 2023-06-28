using System;
using System.Collections.Generic;
using System.Linq; 

namespace Newspaper
{
   public class Startup
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            int n = int.Parse(Console.ReadLine());
            News article = new News(input[0], input[1], input[2]);
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();
                switch (command[0])
                {
                    case "Edit":
                        {
                            article.Edit(command[1]);
                            break;
                        }
                    case "ChangeWritter":
                        {
                            article.ChangeWritter(command[1]);
                            break;
                        }
                    case "Rename":
                        {
                            article.Rename(command[1]);
                            break;
                        }
                    case "Override":
                        {
                            Console.WriteLine($"{input[0]} - {input[1]}: {input[2]}");
                            break;
                        }
                }
            }
            Console.WriteLine(article.ToString());
            }

        }
    }

