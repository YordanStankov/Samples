using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp167
{
    class Program
    {
        static void Main(string[] args)
        {
            string gearPattern = @"<>(?<gear>\w+)<>(?<quantity>\d+)--(?<price>\d+(?:\.\d+|))";
            List<string> gearNames = new List<string>();
            double totalPrice = 0.0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Run!") break;

                if (Regex.IsMatch(input, gearPattern))
                {
                    Match match = Regex.Match(input, gearPattern);

                    string gearName = match.Groups["gear"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = 
                    try 
                    {
                    }
                    double price = double.Parse(match.Groups["price"].Value);

                    gearNames.Add(gearName);

                    totalPrice += quantity * price;
                }
            }

            Console.WriteLine("Gear bought:");
            foreach (var item in gearNames)
                Console.WriteLine(item);

            Console.WriteLine($"Total cost: {totalPrice:f2}");
        }
    }
}
