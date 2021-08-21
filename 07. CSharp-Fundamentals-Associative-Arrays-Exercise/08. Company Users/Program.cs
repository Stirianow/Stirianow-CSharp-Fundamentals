using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var companyCatalogue = new Dictionary<string, List<string>>();
            while (input != "End")
            {
                string[] currentInput = input.Split(" -> ");
                string company = currentInput[0];
                string employeeId = currentInput[1];
                if (!companyCatalogue.ContainsKey(company))
                {
                    companyCatalogue.Add(company, new List<string>());
                }
                if (!companyCatalogue[company].Contains(employeeId))
                {
                    companyCatalogue[company].Add(employeeId);
                }
                input = Console.ReadLine();
            }
            var orderedDict = companyCatalogue.OrderBy(s => s.Key);
            foreach (var company in orderedDict)
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
