using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            OrderedDictionary<string, string> companies = new OrderedDictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] companyInfo = Console.ReadLine().Split(" | ");
                companies.Add(companyInfo[1], companyInfo[0]);
            }

            string[] letters = Console.ReadLine().Split(" - ");
            char firstLetter = char.ToLower(letters[0][0]);
            char secondLetter = char.ToLower(letters[1][0]);

            var newDict = companies.RemoveAll(x => char.ToLower(x.Key[0]) >= firstLetter && char.ToLower(x.Key[0]) < secondLetter);

            foreach (var company in newDict)
            {
                Console.WriteLine($"{company.Key} - {company.Value}");
            }
        }
    }
}