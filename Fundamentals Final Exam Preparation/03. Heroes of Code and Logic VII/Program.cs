using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroInput = Console.ReadLine().Split();
                string heroName = heroInput[0];
                int heroHitPoints = int.Parse(heroInput[1]);
                int heroManaPoints = int.Parse(heroInput[2]);

                heroes.Add(heroName, new int[2]);
                heroes[heroName][0] = heroHitPoints;
                heroes[heroName][1] = heroManaPoints;
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitted = command.Split(" - ");
                if (splitted[0] == "CastSpell")
                {
                    string hero = splitted[1];
                    int manaNeeded = int.Parse(splitted[2]);
                    int mana = heroes[hero][1];
                    if (manaNeeded > mana)
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {splitted[3]}!");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        int newMana = mana - manaNeeded;
                        heroes[hero][1] = newMana;
                        Console.WriteLine($"{hero} has successfully cast {splitted[3]} and now has {newMana} MP!");
                    }
                }
                if (splitted[0] == "TakeDamage")
                {
                    string hero = splitted[1];
                    int damage = int.Parse(splitted[2]);
                    int hp = heroes[hero][0];
                    if (damage >= hp)
                    {
                        Console.WriteLine($"{hero} has been killed by {splitted[3]}!");
                        heroes.Remove(hero);
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        hp -= damage;
                        heroes[hero][0] = hp;
                        Console.WriteLine($"{hero} was hit for {damage} HP by {splitted[3]} and now has {hp} HP left!");
                    }
                }
                if (splitted[0] == "Recharge")
                {
                    string hero = splitted[1];
                    int mp = heroes[hero][1];
                    int mpPurchased = int.Parse(splitted[2]);
                    int oldMp = mp;
                    heroes[hero][1] = mp + mpPurchased;
                    if (heroes[hero][1] > 200)
                    {
                        heroes[hero][1] = 200;
                        mpPurchased = 200 - oldMp;
                    }
                    Console.WriteLine($"{hero} recharged for {mpPurchased} MP!");
                }
                if (splitted[0] == "Heal")
                {
                    string hero = splitted[1];
                    int hp = heroes[hero][0];
                    int hpPurchased = int.Parse(splitted[2]);
                    int oldHp = hp;
                    heroes[hero][0] = hp + hpPurchased;
                    if (heroes[hero][0] > 100)
                    {
                        heroes[hero][0] = 100;
                        hpPurchased = 100 - oldHp;
                    }
                    Console.WriteLine($"{hero} healed for {hpPurchased} HP!");
                }

                command = Console.ReadLine();
            }

            heroes = heroes.
                OrderByDescending(x => x.Value[0]).
                ThenBy(x => x.Key).
                ToDictionary(x => x.Key, x => x.Value);
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($" HP: {hero.Value[0]}");
                Console.WriteLine($" MP: {hero.Value[1]}");
            }
        }
    }
}
