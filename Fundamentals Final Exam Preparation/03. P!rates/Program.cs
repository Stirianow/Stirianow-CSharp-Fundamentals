using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("||");
            var cities = new Dictionary<string, int[]>();

            while (input[0] != "Sail")
            {
                string cityName = input[0];
                int people = int.Parse(input[1]);
                int gold = int.Parse(input[2]);
                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new int[2]);
                    cities[cityName][0] = people;
                    cities[cityName][1] = gold;
                }
                else
                {
                    cities[cityName][0] += people;
                    cities[cityName][1] += gold;
                }
                input = Console.ReadLine().Split("||");
            }
            string[] commmand = Console.ReadLine().Split("=>");

            while (commmand[0] != "End")
            {
                if (commmand[0] == "Plunder")
                {
                    string currentCity = commmand[1];
                    int peopleKilled = int.Parse(commmand[2]);
                    int goldStolen = int.Parse(commmand[3]);
                    int population = cities[currentCity][0];
                    int gold = cities[currentCity][1];
                    Console.WriteLine($"{currentCity} plundered! {goldStolen} gold stolen, {peopleKilled} citizens killed.");
                    if (peopleKilled >= population || goldStolen >= gold)
                    {
                        cities.Remove(currentCity);
                        Console.WriteLine($"{currentCity} has been wiped off the map!");
                    }
                    else
                    {
                        population -= peopleKilled;
                        cities[currentCity][0] = population;
                        gold -= goldStolen;
                        cities[currentCity][1] = gold;
                    }
                }
                else if (commmand[0] == "Prosper")
                {
                    string currentCity = commmand[1];
                    int goldAdded = int.Parse(commmand[2]);
                    if (goldAdded < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        commmand = Console.ReadLine().Split("=>");
                        continue;
                    }
                    cities[currentCity][1] += goldAdded;
                    Console.WriteLine($"{goldAdded} gold added to the city treasury. {currentCity} now has {cities[currentCity][1]} gold.");
                }
                commmand = Console.ReadLine().Split("=>");
            }
            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }
            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            cities = cities.
                OrderByDescending(x => x.Value[1]).
                ThenBy(x => x.Key).
                ToDictionary(x => x.Key, x => x.Value);
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
            }


        }
    }
}
