using System;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|");
            int bitcoins = 0;
            int health = 100;
            bool isAlive = true;
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currentRoom = rooms[i].Split();

                if (currentRoom[0] == "potion")
                {
                    int currentHealth = health;
                    int potion = int.Parse(currentRoom[1]);
                    health += potion;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    potion = health - currentHealth;
                    Console.WriteLine($"You healed for {potion} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (currentRoom[0] == "chest")
                {
                    int chest = int.Parse(currentRoom[1]);
                    Console.WriteLine($"You found {chest} bitcoins.");
                    bitcoins += chest;
                }
                else
                {
                    int damage = int.Parse(currentRoom[1]);
                    string monster = currentRoom[0];
                    health -= damage;
                    if (health <= 0)
                    {
                        health = 0;
                        isAlive = false;
                        int bestRoom = i + 1;
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
            }
            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
